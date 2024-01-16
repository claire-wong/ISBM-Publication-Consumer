/* Purpose: This is a simple application that acts as an ISBM publication consumer.
 *          It demonstrates the idea of using open standards to receive
 *          messages from an ISBM adapter. This application interacts with an ISBM adapter that's
 *          compatible with ISBM 2.0. It should be interoperable with other ISBM adapters
 *          regardless of the actual service bus that delivers the messages.  
 *          
 * Author: Claire Wong
 * Date Created:  2023/01/03
 * 
 * (c) 2023
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
using RapidRedPanda.ISBM.ClientAdapter;
using RapidRedPanda.ISBM.ClientAdapter.Enums;
using RapidRedPanda.ISBM.ClientAdapter.ResponseType;

namespace ISBM_Temp_Gauge
{
    public partial class FormMain : Form
    {
        Timer timerReadTemperature;
        //ISBM Consumer Publication Service
        ConsumerPublicationService myConsumerPublicationService = new ConsumerPublicationService();

        public FormMain()
        {
            InitializeComponent();

            // Setup timer to read publication every 5 seconds
            timerReadTemperature = new Timer();
            timerReadTemperature.Interval = 5000;
            timerReadTemperature.Tick += TimerReadTemperature_Tick;

        }

        private void TimerReadTemperature_Tick(object sender, object c)
        {
            // Pause timer when reading publication from ISBM Adapter 
            timerReadTemperature.Stop();

            try
            {
                //Read Publication
                ReadPublicationResponse myReadPublicationResponse = myConsumerPublicationService.ReadPublication(textBoxHostName.Text, textBoxSessionId.Text);

                //Load Read Publication Message Content into Newtonsoft JObject
                JObject objBOD = JObject.Parse(myReadPublicationResponse.MessageContent);

                // Retrieve measured temperature data. 
                // The response content is an ISBM defined BOD message that contains CCOM data in the data area. 
                textBoxValue.Text = (string)objBOD["syncMeasurements"]["dataArea"]["measurements"][0]["measurement"][0]["data"]["measure"]["value"];
                labelUnit.Text = (string)objBOD["syncMeasurements"]["dataArea"]["measurements"][0]["measurement"][0]["data"]["measure"]["unitOfMeasure"]["shortName"];

                decimal stringToDecimal = Convert.ToDecimal(textBoxValue.Text);

                // Calcualte the length of the empty white bar in front or the red bar,
                // The full scale of the gauge is from 0 to 50 degree Celsius.
                pictureBoxEmpty.Height = 200 - Convert.ToInt16(stringToDecimal * 4);

                RemovePublicationResponse myRemovePublicationResponse = myConsumerPublicationService.RemovePublication(textBoxHostName.Text, textBoxSessionId.Text);
            }
            catch (Exception)
            {
                // Handle BOD or ISBM error 
            }

            // Start timer again
            timerReadTemperature.Start();

        }   

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Connect")
            {
                try
                {
                    //Open Subscription Session
                    OpenSubscriptionSessionResponse myOpenSubscriptionSessionResponse = myConsumerPublicationService.OpenSubscriptionSession(textBoxHostName.Text, textBoxChannelId.Text, textBoxTopic.Text);
                     
                    textBoxResponse.Text = myOpenSubscriptionSessionResponse.ReasonPhrase;
                    textBoxStatusCode.Text = myOpenSubscriptionSessionResponse.StatusCode.ToString();

                    if (myOpenSubscriptionSessionResponse.StatusCode == 201)
                    {

                        textBoxSessionId.Text = myOpenSubscriptionSessionResponse.SessionID;

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
                try
                {
                    //Close Subscription Session
                    CloseSubscriptionSessionResponse myCloseSubscriptionSessionResponse = myConsumerPublicationService.CloseSubscriptionSession(textBoxHostName.Text, textBoxSessionId.Text);
                    
                    textBoxResponse.Text = myCloseSubscriptionSessionResponse.ReasonPhrase;
                    textBoxStatusCode.Text = myCloseSubscriptionSessionResponse.StatusCode.ToString();

                    if (myCloseSubscriptionSessionResponse.StatusCode == 204)
                    {
                        textBoxSessionId.Text = "";

                        buttonConnect.Text = "Connect";
                        buttonReadTemp.Enabled = false;

                    }
                }
                 catch (Exception)
                {
                    // Handle BOD or ISBM error 
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
