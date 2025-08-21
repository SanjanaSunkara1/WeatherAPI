using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherAPI.Models;
using WeatherAPI.Services;

namespace WeatherAPI
{
    public partial class frmWeatherAPI : Form
    {

        List<Weather> weather;
        public frmWeatherAPI()
        {
            InitializeComponent();
        }

        private void frmWeatherAPI_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //TextBox Settings
            this.txtZipCode.MaxLength = 5;
            this.txtZipCode.Text = "78758";
            this.txtCity.Text = "";
            this.txtClouds.Text = "";
            this.txtFeelsLike.Text = "";
            this.txtHigh.Text = "";
            this.txtLat.Text = "";
            this.txtLong.Text = "";
            this.txtLow.Text = "";
            this.txtTemp.Text = "";
            this.txtWind.Text = "";
            this.txtCity.Enabled = false;
            this.txtClouds.Enabled = false;
            this.txtFeelsLike.Enabled = false;
            this.txtHigh.Enabled = false;
            this.txtLat.Enabled = false;
            this.txtLong.Enabled = false;
            this.txtLow.Enabled = false;
            this.txtTemp.Enabled = false;
            this.txtWind.Enabled = false;
        }


        private void btnGetXML_Click(object sender, EventArgs e)
        {
            this.GetWeather(true);
        }


        private void btnGetJSON_Click(object sender, EventArgs e)
        {
            this.GetWeather(false);
        }

        private void GetWeather(bool isXML)
        {
            string sZip = this.txtZipCode.Text.Trim();

            int iZip = Validation(sZip);

            if (iZip == 0)
                return;

            try
            {
                weather = WeatherService.GetWeather(iZip, isXML);

                this.PopulateWeatherData(weather);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.SetControls();
            }
        }

        private void PopulateWeatherData(List<Weather> weather)
        {
            this.txtCity.Text = weather[0].City;
            this.txtClouds.Text = weather[0].Clouds;
            this.txtFeelsLike.Text = weather[0].FeelsLike;
            this.txtHigh.Text = weather[0].HighTemp;
            this.txtLat.Text = weather[0].Latitude;
            this.txtLong.Text = weather[0].Longitude;
            this.txtLow.Text = weather[0].LowTemp;
            this.txtTemp.Text = weather[0].CurrentTemp;
            this.txtWind.Text = weather[0].Wind;
        }

        private int Validation(string sZip)
        {
            int iZip = 0;

            bool result = int.TryParse(sZip, out iZip);

            if (!result)
            {
                MessageBox.Show("A numeric value must be entered for zip code!");
                return iZip;
            }
            else if (sZip.Length != 5)
            {
                MessageBox.Show("Zip code must be 5 numbers!");
                iZip = 0;
                return iZip;
            }

            return iZip;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
