using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            //display current temp
            double currentTemp = Convert.ToDouble(Form1.days[0].currentTemp);
            tempOutput.Text = currentTemp.ToString("##") + "\u00B0" + "C";

            //display day low temp
            double tempLow = Convert.ToDouble(Form1.days[0].tempLow);
            minOutput.Text = tempLow.ToString("##") + "\u00B0" + "C";

            //display day high temp
            double tempHigh = Convert.ToDouble(Form1.days[0].tempHigh);
            maxOutput.Text = tempHigh.ToString("##") + "\u00B0" + "C";

            //display feels like temp
            double feelsLikeTemp = Convert.ToDouble(Form1.days[0].feelsLikeTemp);
            feelsLikeLabel.Text = "Feels like " + feelsLikeTemp.ToString("##") + "\u00B0" + "C";

            //display weather condition 
            conditionLabel.Text = Form1.days[0].condition;

            //display windspeed
            windSpeedLabel.Text = Form1.days[0].windSpeed;

            //display humidity 
            humidityLabel.Text = "Humidity "+Form1.days[0].humidity + "%";

            //display clock
            dateLabel.Text = DateTime.Now.ToString("hh:mm tt");


        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            DisplayCurrent();
        }
    }
}
