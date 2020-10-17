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

            //display tomorrow conditions
            tmrwCondLabel.Text = Form1.days[1].condition;

            //display day after tomorrow
            nextDayLabel.Text = DateTime.Now.AddDays(2).ToString("dddd");
            day2CondLabel.Text = Form1.days[2].condition;

            //display next day after 
            finalDayLabel.Text = DateTime.Now.AddDays(3).ToString("dddd");
            day3CondLabel.Text = Form1.days[3].condition;

            //image in background
            int conditionNumber = Convert.ToInt32(Form1.days[0].conditionNumber);
            if (conditionNumber == 800)
            {
                //backgroundPicture.Image = Properties.Resources.SunnyBackGround;
            }
            //picture boxes backgroundPicture.Image = Properties.Resources.insidecabin;
            //backgroundPicture.BackgroundImageLayout = ImageLayout.Zoom;




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
