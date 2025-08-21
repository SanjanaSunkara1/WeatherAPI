namespace WeatherAPI
{
    partial class frmWeatherAPI
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
            this.btnGetXML = new System.Windows.Forms.Button();
            this.btnGetJSON = new System.Windows.Forms.Button();
            this.labelZip = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.labelLong = new System.Windows.Forms.Label();
            this.labelLat = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.labelHigh = new System.Windows.Forms.Label();
            this.labelLow = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelFeelsLike = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtFeelsLike = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.labelWind = new System.Windows.Forms.Label();
            this.labelClouds = new System.Windows.Forms.Label();
            this.txtClouds = new System.Windows.Forms.TextBox();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetXML
            // 
            this.btnGetXML.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGetXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetXML.ForeColor = System.Drawing.Color.White;
            this.btnGetXML.Location = new System.Drawing.Point(25, 441);
            this.btnGetXML.Name = "btnGetXML";
            this.btnGetXML.Size = new System.Drawing.Size(211, 60);
            this.btnGetXML.TabIndex = 0;
            this.btnGetXML.Text = "Get Weather (XML)";
            this.btnGetXML.UseVisualStyleBackColor = false;
            this.btnGetXML.Click += new System.EventHandler(this.btnGetXML_Click);
            // 
            // btnGetJSON
            // 
            this.btnGetJSON.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGetJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetJSON.ForeColor = System.Drawing.Color.White;
            this.btnGetJSON.Location = new System.Drawing.Point(286, 441);
            this.btnGetJSON.Name = "btnGetJSON";
            this.btnGetJSON.Size = new System.Drawing.Size(195, 60);
            this.btnGetJSON.TabIndex = 1;
            this.btnGetJSON.Text = "Get Weather (JSON)";
            this.btnGetJSON.UseVisualStyleBackColor = false;
            this.btnGetJSON.Click += new System.EventHandler(this.btnGetJSON_Click);
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.BackColor = System.Drawing.Color.Transparent;
            this.labelZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZip.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelZip.Location = new System.Drawing.Point(21, 41);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(169, 24);
            this.labelZip.TabIndex = 2;
            this.labelZip.Text = "Enter a zip code:";
            // 
            // txtZipCode
            // 
            this.txtZipCode.AcceptsReturn = true;
            this.txtZipCode.Location = new System.Drawing.Point(25, 78);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(243, 20);
            this.txtZipCode.TabIndex = 3;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.Transparent;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCity.Location = new System.Drawing.Point(21, 114);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(44, 24);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(25, 151);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(243, 20);
            this.txtCity.TabIndex = 5;
            // 
            // labelLong
            // 
            this.labelLong.AutoSize = true;
            this.labelLong.BackColor = System.Drawing.Color.Transparent;
            this.labelLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLong.Location = new System.Drawing.Point(247, 196);
            this.labelLong.Name = "labelLong";
            this.labelLong.Size = new System.Drawing.Size(103, 24);
            this.labelLong.TabIndex = 6;
            this.labelLong.Text = "Longitude";
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.BackColor = System.Drawing.Color.Transparent;
            this.labelLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLat.Location = new System.Drawing.Point(21, 196);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(83, 24);
            this.labelLat.TabIndex = 7;
            this.labelLat.Text = "Latitude";
            // 
            // txtLat
            // 
            this.txtLat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLat.Enabled = false;
            this.txtLat.Location = new System.Drawing.Point(25, 232);
            this.txtLat.Name = "txtLat";
            this.txtLat.ReadOnly = true;
            this.txtLat.Size = new System.Drawing.Size(203, 20);
            this.txtLat.TabIndex = 9;
            // 
            // txtLong
            // 
            this.txtLong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLong.Enabled = false;
            this.txtLong.Location = new System.Drawing.Point(251, 232);
            this.txtLong.Name = "txtLong";
            this.txtLong.ReadOnly = true;
            this.txtLong.Size = new System.Drawing.Size(203, 20);
            this.txtLong.TabIndex = 10;
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.BackColor = System.Drawing.Color.Transparent;
            this.labelHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHigh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelHigh.Location = new System.Drawing.Point(269, 278);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(54, 24);
            this.labelHigh.TabIndex = 11;
            this.labelHigh.Text = "High";
            // 
            // labelLow
            // 
            this.labelLow.AutoSize = true;
            this.labelLow.BackColor = System.Drawing.Color.Transparent;
            this.labelLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLow.Location = new System.Drawing.Point(167, 278);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(48, 24);
            this.labelLow.TabIndex = 12;
            this.labelLow.Text = "Low";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTemp.Location = new System.Drawing.Point(21, 278);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(119, 24);
            this.labelTemp.TabIndex = 13;
            this.labelTemp.Text = "Temperture";
            // 
            // labelFeelsLike
            // 
            this.labelFeelsLike.AutoSize = true;
            this.labelFeelsLike.BackColor = System.Drawing.Color.Transparent;
            this.labelFeelsLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeelsLike.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFeelsLike.Location = new System.Drawing.Point(370, 278);
            this.labelFeelsLike.Name = "labelFeelsLike";
            this.labelFeelsLike.Size = new System.Drawing.Size(106, 24);
            this.labelFeelsLike.TabIndex = 14;
            this.labelFeelsLike.Text = "Feels Like";
            // 
            // txtTemp
            // 
            this.txtTemp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTemp.Enabled = false;
            this.txtTemp.Location = new System.Drawing.Point(25, 314);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.ReadOnly = true;
            this.txtTemp.Size = new System.Drawing.Size(107, 20);
            this.txtTemp.TabIndex = 15;
            // 
            // txtFeelsLike
            // 
            this.txtFeelsLike.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFeelsLike.Enabled = false;
            this.txtFeelsLike.Location = new System.Drawing.Point(374, 314);
            this.txtFeelsLike.Name = "txtFeelsLike";
            this.txtFeelsLike.ReadOnly = true;
            this.txtFeelsLike.Size = new System.Drawing.Size(107, 20);
            this.txtFeelsLike.TabIndex = 16;
            // 
            // txtHigh
            // 
            this.txtHigh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHigh.Enabled = false;
            this.txtHigh.Location = new System.Drawing.Point(273, 314);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.ReadOnly = true;
            this.txtHigh.Size = new System.Drawing.Size(77, 20);
            this.txtHigh.TabIndex = 17;
            // 
            // txtLow
            // 
            this.txtLow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLow.Enabled = false;
            this.txtLow.Location = new System.Drawing.Point(171, 314);
            this.txtLow.Name = "txtLow";
            this.txtLow.ReadOnly = true;
            this.txtLow.Size = new System.Drawing.Size(74, 20);
            this.txtLow.TabIndex = 18;
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.BackColor = System.Drawing.Color.Transparent;
            this.labelWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWind.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelWind.Location = new System.Drawing.Point(247, 358);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(58, 24);
            this.labelWind.TabIndex = 19;
            this.labelWind.Text = "Wind";
            // 
            // labelClouds
            // 
            this.labelClouds.AutoSize = true;
            this.labelClouds.BackColor = System.Drawing.Color.Transparent;
            this.labelClouds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClouds.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelClouds.Location = new System.Drawing.Point(21, 358);
            this.labelClouds.Name = "labelClouds";
            this.labelClouds.Size = new System.Drawing.Size(75, 24);
            this.labelClouds.TabIndex = 20;
            this.labelClouds.Text = "Clouds";
            // 
            // txtClouds
            // 
            this.txtClouds.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtClouds.Enabled = false;
            this.txtClouds.Location = new System.Drawing.Point(25, 396);
            this.txtClouds.Name = "txtClouds";
            this.txtClouds.ReadOnly = true;
            this.txtClouds.Size = new System.Drawing.Size(203, 20);
            this.txtClouds.TabIndex = 21;
            // 
            // txtWind
            // 
            this.txtWind.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtWind.Enabled = false;
            this.txtWind.Location = new System.Drawing.Point(251, 396);
            this.txtWind.Name = "txtWind";
            this.txtWind.ReadOnly = true;
            this.txtWind.Size = new System.Drawing.Size(203, 20);
            this.txtWind.TabIndex = 22;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Snow;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.Location = new System.Drawing.Point(401, 544);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 41);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmWeatherAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 597);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtWind);
            this.Controls.Add(this.txtClouds);
            this.Controls.Add(this.labelClouds);
            this.Controls.Add(this.labelWind);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtFeelsLike);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.labelFeelsLike);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelLow);
            this.Controls.Add(this.labelHigh);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.labelLat);
            this.Controls.Add(this.labelLong);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.btnGetJSON);
            this.Controls.Add(this.btnGetXML);
            this.Name = "frmWeatherAPI";
            this.Text = "Weather API";
            this.Load += new System.EventHandler(this.frmWeatherAPI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetXML;
        private System.Windows.Forms.Button btnGetJSON;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label labelLong;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label labelLow;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelFeelsLike;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtFeelsLike;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.Label labelWind;
        private System.Windows.Forms.Label labelClouds;
        private System.Windows.Forms.TextBox txtClouds;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.Button btnClose;
    }
}