/* Purpose: This is a simple application that acts as an ISBM publication consumer.
 *          It demonstrates the idea of using open standards to receive
 *          messages from an ISBM adapter. This application interacts with an ISBM adapter that's
 *          compatible with ISBM 2.0. It should be interoperable with other ISBM adapters
 *          regardless of the actual service bus that delivers the messages.  
 *          
 * Author: Claire Wong
 * Date Created:  2020/05/19
 * 
 * (c) 2020
 * This code is licensed under MIT license
 * 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ISBM_Temp_Gauge
{
    public partial class FormMain : Form
    {
        Timer timerReadTemperature;

        public FormMain()
        {
            InitializeComponent();

            //Setup timer to read publication every 5 seconds
            timerReadTemperature = new Timer();
            timerReadTemperature.Interval = 5000;
            timerReadTemperature.Tick += TimerReadTemperature_Tick;

        }

        private async void TimerReadTemperature_Tick(object sender, object c)
        {
            //Pause timer when reading publication from ISBM Adapter 
            timerReadTemperature.Stop();

            try
            {
                //Format HTTP url for ISBM api
                string uriString = String.Format(textBoxHostName.Text + "/sessions/{0}/publication", textBoxSessionId.Text);
                //Use ISBMApi function to read publication 
                string _ISBMResponse = await ISBMApi("", uriString, "Get");

                //Load HTTP response content into Newtonsoft JObject
                JObject objBOD = JObject.Parse(_ISBMResponse);
                //Retrieve measured temperature data. 
                //The response content is an ISBM defined BOD message that contains CCOM data in the data area. 
                textBoxValue.Text = (string)objBOD["messageContent"]["content"]["syncMeasurements"]["dataArea"]["measurements"][0]["measurement"][0]["data"]["measure"]["value"]["numeric"];
                labelUnit.Text = (string)objBOD["messageContent"]["content"]["syncMeasurements"]["dataArea"]["measurements"][0]["measurement"][0]["data"]["measure"]["UnitOfMeasure"]["ShortName"];

                decimal stringToDecimal = Convert.ToDecimal(textBoxValue.Text);

                //Calcualte the length of the empty white bar in front or the red bar,
                //The full scale of the gauge is from 0 to 50 degree Celsius.
                pictureBoxEmpty.Height = 200 - Convert.ToInt16(stringToDecimal * 4);

                //Format HTTP url for ISBM api
                uriString = String.Format(textBoxHostName.Text + "/sessions/{0}/publication", textBoxSessionId.Text);
                //Use ISBMApi function to delete publication 
                _ISBMResponse = await ISBMApi("", uriString, "Delete");
            }
            catch (Exception ex)
            {
                //Handle BOD or ISBM error 
            }

            //Start timer again
            timerReadTemperature.Start();

        }   

        private async Task<string> ISBMApi(string requestBody, string uriString, string httpMethod)
        {

            try
            {
                //Create a new HTTP Content with requestedBody in UTF encoding  
                var HttpContent = new StringContent(requestBody, Encoding.UTF8, "application/json");
                //Create a HTTP client
                HttpClient client = new HttpClient();
               
                //Create a new Uri with uriString and assign it to HTTP client's BaseAddress property 
                Uri _uri = new Uri(uriString);
                client.BaseAddress = _uri;

                HttpResponseMessage httpResponse = null;

                switch (httpMethod)
                {
                    case "Get":
                        //Use GetAsync to send HTTP request
                        httpResponse = await client.GetAsync(uriString);
                        break;

                    //case "Post":
                    //    httpResponse = await client.PostAsync(uriString, httpContent);
                    //    break;

                    //case "Put":
                    //    break;

                    case "Delete":
                        //Use DeleteAsync to send HTTP request
                        httpResponse = client.DeleteAsync(uriString).Result;
                        break;
                }

                string responseContent = await httpResponse.Content.ReadAsStringAsync();
                textBoxStatusCode.Text = "" + (int)httpResponse.StatusCode;
                textBoxMessage.Text = httpResponse.ReasonPhrase;

                return responseContent;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        private async void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Connect")
            {
                string requestBody = "{\"topics\":[\"" + textBoxTopic.Text + "\"]}";
                string uriString = String.Format(textBoxHostName.Text + "/channels/{0}/subscription-sessions", textBoxChannelId.Text.Replace(@"/", "%252F"));
                string _ISBMResponse = await ISBMApi(requestBody, uriString, "Post");
                textBoxResponse.Text = _ISBMResponse;

                try
                {

                    if (textBoxStatusCode.Text == "201")
                    {
                        JObject objResponseContent = JObject.Parse(_ISBMResponse);
                        textBoxSessionId.Text = (string)objResponseContent["sessionId"];

                        buttonConnect.Text = "Disconnect";
                        buttonReadTemp.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    textBoxSessionId.Text = "";
                }
            }
            else
            {
                string uriString = String.Format(textBoxHostName.Text + "/sessions/{0}", textBoxSessionId.Text);
                string _ISBMResponse = await ISBMApi("", uriString, "Delete");
                textBoxResponse.Text = _ISBMResponse;

                if (textBoxStatusCode.Text == "204")
                {
                    textBoxSessionId.Text = "";

                    buttonConnect.Text = "Connect";
                    buttonReadTemp.Enabled = false;

                }
            }
        }

        private void ButtonReadTemp_Click(object sender, EventArgs e)
        {
            if (buttonReadTemp.Text == "Read Temp")
            {
                timerReadTemperature.Start();
                buttonReadTemp.Text = "Stop";
                buttonConnect.Enabled = false;
            }
            else
            {
                timerReadTemperature.Stop();
                buttonReadTemp.Text = "Read Temp";
                buttonConnect.Enabled = true;
            }
                
        }
    }
}
