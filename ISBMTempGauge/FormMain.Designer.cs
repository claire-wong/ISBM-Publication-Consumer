namespace ISBM_Temp_Gauge
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxStatusCode = new System.Windows.Forms.TextBox();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.textBoxSessionId = new System.Windows.Forms.TextBox();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.textBoxChannelId = new System.Windows.Forms.TextBox();
            this.textBoxHostName = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelStatusCode = new System.Windows.Forms.Label();
            this.labelResponse = new System.Windows.Forms.Label();
            this.labelSessionID = new System.Windows.Forms.Label();
            this.labelTpoic = new System.Windows.Forms.Label();
            this.labelChannelID = new System.Windows.Forms.Label();
            this.labelHostName = new System.Windows.Forms.Label();
            this.labelISBMSettings = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxEmpty = new System.Windows.Forms.PictureBox();
            this.pictureBoxTempBar = new System.Windows.Forms.PictureBox();
            this.buttonReadTemp = new System.Windows.Forms.Button();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTempBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.textBoxMessage);
            this.groupBox1.Controls.Add(this.textBoxStatusCode);
            this.groupBox1.Controls.Add(this.textBoxResponse);
            this.groupBox1.Controls.Add(this.textBoxSessionId);
            this.groupBox1.Controls.Add(this.textBoxTopic);
            this.groupBox1.Controls.Add(this.textBoxChannelId);
            this.groupBox1.Controls.Add(this.textBoxHostName);
            this.groupBox1.Controls.Add(this.labelMessage);
            this.groupBox1.Controls.Add(this.labelStatusCode);
            this.groupBox1.Controls.Add(this.labelResponse);
            this.groupBox1.Controls.Add(this.labelSessionID);
            this.groupBox1.Controls.Add(this.labelTpoic);
            this.groupBox1.Controls.Add(this.labelChannelID);
            this.groupBox1.Controls.Add(this.labelHostName);
            this.groupBox1.Controls.Add(this.labelISBMSettings);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 417);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Indigo;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonConnect.Location = new System.Drawing.Point(475, 361);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(135, 42);
            this.buttonConnect.TabIndex = 17;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(172)))), ((int)(((byte)(196)))));
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessage.Location = new System.Drawing.Point(148, 284);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(462, 66);
            this.textBoxMessage.TabIndex = 16;
            // 
            // textBoxStatusCode
            // 
            this.textBoxStatusCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(172)))), ((int)(((byte)(196)))));
            this.textBoxStatusCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatusCode.Location = new System.Drawing.Point(148, 249);
            this.textBoxStatusCode.Name = "textBoxStatusCode";
            this.textBoxStatusCode.Size = new System.Drawing.Size(69, 26);
            this.textBoxStatusCode.TabIndex = 15;
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(172)))), ((int)(((byte)(196)))));
            this.textBoxResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResponse.Location = new System.Drawing.Point(148, 212);
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.Size = new System.Drawing.Size(462, 26);
            this.textBoxResponse.TabIndex = 14;
            // 
            // textBoxSessionId
            // 
            this.textBoxSessionId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(172)))), ((int)(((byte)(196)))));
            this.textBoxSessionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSessionId.Location = new System.Drawing.Point(148, 174);
            this.textBoxSessionId.Name = "textBoxSessionId";
            this.textBoxSessionId.Size = new System.Drawing.Size(462, 26);
            this.textBoxSessionId.TabIndex = 13;
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(172)))), ((int)(((byte)(196)))));
            this.textBoxTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTopic.Location = new System.Drawing.Point(148, 136);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(462, 26);
            this.textBoxTopic.TabIndex = 12;
            this.textBoxTopic.Text = "OIIE:S30:V1.1/CCOM-JSON:SyncMeasurements:V1.0";
            // 
            // textBoxChannelId
            // 
            this.textBoxChannelId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(172)))), ((int)(((byte)(196)))));
            this.textBoxChannelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChannelId.Location = new System.Drawing.Point(148, 99);
            this.textBoxChannelId.Name = "textBoxChannelId";
            this.textBoxChannelId.Size = new System.Drawing.Size(462, 26);
            this.textBoxChannelId.TabIndex = 11;
            this.textBoxChannelId.Text = "/Robot Fleet/Ball Shooter/Drive System/ISO18435:D1.2/Publication";
            // 
            // textBoxHostName
            // 
            this.textBoxHostName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(172)))), ((int)(((byte)(196)))));
            this.textBoxHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHostName.Location = new System.Drawing.Point(148, 64);
            this.textBoxHostName.Name = "textBoxHostName";
            this.textBoxHostName.Size = new System.Drawing.Size(462, 26);
            this.textBoxHostName.TabIndex = 9;
            this.textBoxHostName.Text = "http://YourIP/isbm/2.0";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMessage.Location = new System.Drawing.Point(44, 287);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(74, 20);
            this.labelMessage.TabIndex = 8;
            this.labelMessage.Text = "Message";
            // 
            // labelStatusCode
            // 
            this.labelStatusCode.AutoSize = true;
            this.labelStatusCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusCode.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStatusCode.Location = new System.Drawing.Point(44, 252);
            this.labelStatusCode.Name = "labelStatusCode";
            this.labelStatusCode.Size = new System.Drawing.Size(98, 20);
            this.labelStatusCode.TabIndex = 7;
            this.labelStatusCode.Text = "Status Code";
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponse.ForeColor = System.Drawing.SystemColors.Control;
            this.labelResponse.Location = new System.Drawing.Point(44, 215);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(82, 20);
            this.labelResponse.TabIndex = 6;
            this.labelResponse.Text = "Response";
            // 
            // labelSessionID
            // 
            this.labelSessionID.AutoSize = true;
            this.labelSessionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionID.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSessionID.Location = new System.Drawing.Point(44, 177);
            this.labelSessionID.Name = "labelSessionID";
            this.labelSessionID.Size = new System.Drawing.Size(87, 20);
            this.labelSessionID.TabIndex = 5;
            this.labelSessionID.Text = "Session ID";
            // 
            // labelTpoic
            // 
            this.labelTpoic.AutoSize = true;
            this.labelTpoic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTpoic.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTpoic.Location = new System.Drawing.Point(44, 139);
            this.labelTpoic.Name = "labelTpoic";
            this.labelTpoic.Size = new System.Drawing.Size(47, 20);
            this.labelTpoic.TabIndex = 4;
            this.labelTpoic.Text = "Topic";
            // 
            // labelChannelID
            // 
            this.labelChannelID.AutoSize = true;
            this.labelChannelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChannelID.ForeColor = System.Drawing.SystemColors.Control;
            this.labelChannelID.Location = new System.Drawing.Point(44, 102);
            this.labelChannelID.Name = "labelChannelID";
            this.labelChannelID.Size = new System.Drawing.Size(89, 20);
            this.labelChannelID.TabIndex = 3;
            this.labelChannelID.Text = "Channel ID";
            // 
            // labelHostName
            // 
            this.labelHostName.AutoSize = true;
            this.labelHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHostName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHostName.Location = new System.Drawing.Point(44, 67);
            this.labelHostName.Name = "labelHostName";
            this.labelHostName.Size = new System.Drawing.Size(89, 20);
            this.labelHostName.TabIndex = 2;
            this.labelHostName.Text = "Host Name";
            // 
            // labelISBMSettings
            // 
            this.labelISBMSettings.AutoSize = true;
            this.labelISBMSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelISBMSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.labelISBMSettings.Location = new System.Drawing.Point(19, 26);
            this.labelISBMSettings.Name = "labelISBMSettings";
            this.labelISBMSettings.Size = new System.Drawing.Size(136, 20);
            this.labelISBMSettings.TabIndex = 1;
            this.labelISBMSettings.Text = "ws-ISBM Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxEmpty);
            this.groupBox2.Controls.Add(this.pictureBoxTempBar);
            this.groupBox2.Controls.Add(this.buttonReadTemp);
            this.groupBox2.Controls.Add(this.labelUnit);
            this.groupBox2.Controls.Add(this.textBoxValue);
            this.groupBox2.Location = new System.Drawing.Point(653, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 417);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // pictureBoxEmpty
            // 
            this.pictureBoxEmpty.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEmpty.Image")));
            this.pictureBoxEmpty.Location = new System.Drawing.Point(76, 126);
            this.pictureBoxEmpty.Name = "pictureBoxEmpty";
            this.pictureBoxEmpty.Size = new System.Drawing.Size(22, 200);
            this.pictureBoxEmpty.TabIndex = 19;
            this.pictureBoxEmpty.TabStop = false;
            // 
            // pictureBoxTempBar
            // 
            this.pictureBoxTempBar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTempBar.Image")));
            this.pictureBoxTempBar.Location = new System.Drawing.Point(76, 126);
            this.pictureBoxTempBar.Name = "pictureBoxTempBar";
            this.pictureBoxTempBar.Size = new System.Drawing.Size(22, 200);
            this.pictureBoxTempBar.TabIndex = 20;
            this.pictureBoxTempBar.TabStop = false;
            // 
            // buttonReadTemp
            // 
            this.buttonReadTemp.BackColor = System.Drawing.Color.Indigo;
            this.buttonReadTemp.Enabled = false;
            this.buttonReadTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadTemp.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReadTemp.Location = new System.Drawing.Point(22, 361);
            this.buttonReadTemp.Name = "buttonReadTemp";
            this.buttonReadTemp.Size = new System.Drawing.Size(135, 42);
            this.buttonReadTemp.TabIndex = 18;
            this.buttonReadTemp.Text = "Read Temp";
            this.buttonReadTemp.UseVisualStyleBackColor = false;
            this.buttonReadTemp.Click += new System.EventHandler(this.ButtonReadTemp_Click);
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUnit.Location = new System.Drawing.Point(18, 26);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(46, 20);
            this.labelUnit.TabIndex = 1;
            this.labelUnit.Text = "UOM";
            this.labelUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxValue
            // 
            this.textBoxValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(172)))), ((int)(((byte)(196)))));
            this.textBoxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValue.Location = new System.Drawing.Point(60, 61);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.ReadOnly = true;
            this.textBoxValue.Size = new System.Drawing.Size(52, 26);
            this.textBoxValue.TabIndex = 0;
            this.textBoxValue.Text = "00.00";
            this.textBoxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(851, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTempBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxStatusCode;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.TextBox textBoxSessionId;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.TextBox textBoxChannelId;
        private System.Windows.Forms.TextBox textBoxHostName;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelStatusCode;
        private System.Windows.Forms.Label labelResponse;
        private System.Windows.Forms.Label labelSessionID;
        private System.Windows.Forms.Label labelTpoic;
        private System.Windows.Forms.Label labelChannelID;
        private System.Windows.Forms.Label labelHostName;
        private System.Windows.Forms.Label labelISBMSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonReadTemp;
        private System.Windows.Forms.PictureBox pictureBoxTempBar;
        private System.Windows.Forms.PictureBox pictureBoxEmpty;
    }
}

