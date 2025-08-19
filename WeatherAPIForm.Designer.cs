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
            this.getWeatherXmlBtn = new System.Windows.Forms.Button();
            this.getWeatherJsonBtn = new System.Windows.Forms.Button();
            this.zipLabel = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.longLabel = new System.Windows.Forms.Label();
            this.latLabel = new System.Windows.Forms.Label();
            this.latTxt = new System.Windows.Forms.TextBox();
            this.longTxt = new System.Windows.Forms.TextBox();
            this.highLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.feelsLikeLabel = new System.Windows.Forms.Label();
            this.tempTxt = new System.Windows.Forms.TextBox();
            this.feelsikeTxt = new System.Windows.Forms.TextBox();
            this.highTxt = new System.Windows.Forms.TextBox();
            this.lowTxt = new System.Windows.Forms.TextBox();
            this.windLabel = new System.Windows.Forms.Label();
            this.cloudsLabel = new System.Windows.Forms.Label();
            this.cloudsTxt = new System.Windows.Forms.TextBox();
            this.windTxt = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getWeatherXmlBtn
            // 
            this.getWeatherXmlBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.getWeatherXmlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getWeatherXmlBtn.ForeColor = System.Drawing.Color.White;
            this.getWeatherXmlBtn.Location = new System.Drawing.Point(25, 441);
            this.getWeatherXmlBtn.Name = "getWeatherXmlBtn";
            this.getWeatherXmlBtn.Size = new System.Drawing.Size(211, 60);
            this.getWeatherXmlBtn.TabIndex = 0;
            this.getWeatherXmlBtn.Text = "Get Weather (XML)";
            this.getWeatherXmlBtn.UseVisualStyleBackColor = false;
            // 
            // getWeatherJsonBtn
            // 
            this.getWeatherJsonBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.getWeatherJsonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getWeatherJsonBtn.ForeColor = System.Drawing.Color.White;
            this.getWeatherJsonBtn.Location = new System.Drawing.Point(286, 441);
            this.getWeatherJsonBtn.Name = "getWeatherJsonBtn";
            this.getWeatherJsonBtn.Size = new System.Drawing.Size(195, 60);
            this.getWeatherJsonBtn.TabIndex = 1;
            this.getWeatherJsonBtn.Text = "Get Weather (JSON)";
            this.getWeatherJsonBtn.UseVisualStyleBackColor = false;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.BackColor = System.Drawing.Color.Transparent;
            this.zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.zipLabel.Location = new System.Drawing.Point(21, 41);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(169, 24);
            this.zipLabel.TabIndex = 2;
            this.zipLabel.Text = "Enter a zip code:";
            this.zipLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtZipCode
            // 
            this.txtZipCode.AcceptsReturn = true;
            this.txtZipCode.Location = new System.Drawing.Point(25, 78);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(243, 20);
            this.txtZipCode.TabIndex = 3;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cityLabel.Location = new System.Drawing.Point(21, 114);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(44, 24);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City";
            // 
            // cityTxt
            // 
            this.cityTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cityTxt.Enabled = false;
            this.cityTxt.Location = new System.Drawing.Point(25, 151);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.ReadOnly = true;
            this.cityTxt.Size = new System.Drawing.Size(243, 20);
            this.cityTxt.TabIndex = 5;
            // 
            // longLabel
            // 
            this.longLabel.AutoSize = true;
            this.longLabel.BackColor = System.Drawing.Color.Transparent;
            this.longLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.longLabel.Location = new System.Drawing.Point(247, 196);
            this.longLabel.Name = "longLabel";
            this.longLabel.Size = new System.Drawing.Size(103, 24);
            this.longLabel.TabIndex = 6;
            this.longLabel.Text = "Longitude";
            // 
            // latLabel
            // 
            this.latLabel.AutoSize = true;
            this.latLabel.BackColor = System.Drawing.Color.Transparent;
            this.latLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.latLabel.Location = new System.Drawing.Point(21, 196);
            this.latLabel.Name = "latLabel";
            this.latLabel.Size = new System.Drawing.Size(83, 24);
            this.latLabel.TabIndex = 7;
            this.latLabel.Text = "Latitude";
            // 
            // latTxt
            // 
            this.latTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.latTxt.Enabled = false;
            this.latTxt.Location = new System.Drawing.Point(25, 232);
            this.latTxt.Name = "latTxt";
            this.latTxt.ReadOnly = true;
            this.latTxt.Size = new System.Drawing.Size(203, 20);
            this.latTxt.TabIndex = 9;
            // 
            // longTxt
            // 
            this.longTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.longTxt.Enabled = false;
            this.longTxt.Location = new System.Drawing.Point(251, 232);
            this.longTxt.Name = "longTxt";
            this.longTxt.ReadOnly = true;
            this.longTxt.Size = new System.Drawing.Size(203, 20);
            this.longTxt.TabIndex = 10;
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.BackColor = System.Drawing.Color.Transparent;
            this.highLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.highLabel.Location = new System.Drawing.Point(269, 278);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(54, 24);
            this.highLabel.TabIndex = 11;
            this.highLabel.Text = "High";
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.BackColor = System.Drawing.Color.Transparent;
            this.lowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lowLabel.Location = new System.Drawing.Point(167, 278);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(48, 24);
            this.lowLabel.TabIndex = 12;
            this.lowLabel.Text = "Low";
            this.lowLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tempLabel.Location = new System.Drawing.Point(21, 278);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(119, 24);
            this.tempLabel.TabIndex = 13;
            this.tempLabel.Text = "Temperture";
            // 
            // feelsLikeLabel
            // 
            this.feelsLikeLabel.AutoSize = true;
            this.feelsLikeLabel.BackColor = System.Drawing.Color.Transparent;
            this.feelsLikeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feelsLikeLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.feelsLikeLabel.Location = new System.Drawing.Point(370, 278);
            this.feelsLikeLabel.Name = "feelsLikeLabel";
            this.feelsLikeLabel.Size = new System.Drawing.Size(106, 24);
            this.feelsLikeLabel.TabIndex = 14;
            this.feelsLikeLabel.Text = "Feels Like";
            // 
            // tempTxt
            // 
            this.tempTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tempTxt.Enabled = false;
            this.tempTxt.Location = new System.Drawing.Point(25, 314);
            this.tempTxt.Name = "tempTxt";
            this.tempTxt.ReadOnly = true;
            this.tempTxt.Size = new System.Drawing.Size(107, 20);
            this.tempTxt.TabIndex = 15;
            // 
            // feelsikeTxt
            // 
            this.feelsikeTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.feelsikeTxt.Enabled = false;
            this.feelsikeTxt.Location = new System.Drawing.Point(374, 314);
            this.feelsikeTxt.Name = "feelsikeTxt";
            this.feelsikeTxt.ReadOnly = true;
            this.feelsikeTxt.Size = new System.Drawing.Size(107, 20);
            this.feelsikeTxt.TabIndex = 16;
            // 
            // highTxt
            // 
            this.highTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.highTxt.Enabled = false;
            this.highTxt.Location = new System.Drawing.Point(273, 314);
            this.highTxt.Name = "highTxt";
            this.highTxt.ReadOnly = true;
            this.highTxt.Size = new System.Drawing.Size(77, 20);
            this.highTxt.TabIndex = 17;
            // 
            // lowTxt
            // 
            this.lowTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lowTxt.Enabled = false;
            this.lowTxt.Location = new System.Drawing.Point(171, 314);
            this.lowTxt.Name = "lowTxt";
            this.lowTxt.ReadOnly = true;
            this.lowTxt.Size = new System.Drawing.Size(74, 20);
            this.lowTxt.TabIndex = 18;
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.windLabel.Location = new System.Drawing.Point(247, 358);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(58, 24);
            this.windLabel.TabIndex = 19;
            this.windLabel.Text = "Wind";
            this.windLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // cloudsLabel
            // 
            this.cloudsLabel.AutoSize = true;
            this.cloudsLabel.BackColor = System.Drawing.Color.Transparent;
            this.cloudsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cloudsLabel.Location = new System.Drawing.Point(21, 358);
            this.cloudsLabel.Name = "cloudsLabel";
            this.cloudsLabel.Size = new System.Drawing.Size(75, 24);
            this.cloudsLabel.TabIndex = 20;
            this.cloudsLabel.Text = "Clouds";
            // 
            // cloudsTxt
            // 
            this.cloudsTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cloudsTxt.Enabled = false;
            this.cloudsTxt.Location = new System.Drawing.Point(25, 396);
            this.cloudsTxt.Name = "cloudsTxt";
            this.cloudsTxt.ReadOnly = true;
            this.cloudsTxt.Size = new System.Drawing.Size(203, 20);
            this.cloudsTxt.TabIndex = 21;
            // 
            // windTxt
            // 
            this.windTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.windTxt.Enabled = false;
            this.windTxt.Location = new System.Drawing.Point(251, 396);
            this.windTxt.Name = "windTxt";
            this.windTxt.ReadOnly = true;
            this.windTxt.Size = new System.Drawing.Size(203, 20);
            this.windTxt.TabIndex = 22;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Snow;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.closeBtn.Location = new System.Drawing.Point(401, 544);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(98, 41);
            this.closeBtn.TabIndex = 23;
            this.closeBtn.Text = "close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // frmWeatherAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 597);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.windTxt);
            this.Controls.Add(this.cloudsTxt);
            this.Controls.Add(this.cloudsLabel);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.lowTxt);
            this.Controls.Add(this.highTxt);
            this.Controls.Add(this.feelsikeTxt);
            this.Controls.Add(this.tempTxt);
            this.Controls.Add(this.feelsLikeLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.longTxt);
            this.Controls.Add(this.latTxt);
            this.Controls.Add(this.latLabel);
            this.Controls.Add(this.longLabel);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.getWeatherJsonBtn);
            this.Controls.Add(this.getWeatherXmlBtn);
            this.Name = "frmWeatherAPI";
            this.Text = "Weather API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getWeatherXmlBtn;
        private System.Windows.Forms.Button getWeatherJsonBtn;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.Label longLabel;
        private System.Windows.Forms.Label latLabel;
        private System.Windows.Forms.TextBox latTxt;
        private System.Windows.Forms.TextBox longTxt;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label feelsLikeLabel;
        private System.Windows.Forms.TextBox tempTxt;
        private System.Windows.Forms.TextBox feelsikeTxt;
        private System.Windows.Forms.TextBox highTxt;
        private System.Windows.Forms.TextBox lowTxt;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label cloudsLabel;
        private System.Windows.Forms.TextBox cloudsTxt;
        private System.Windows.Forms.TextBox windTxt;
        private System.Windows.Forms.Button closeBtn;
    }
}