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
            #region Parent section
            //To allow the labels to be transparents to the picture box image instead of the screen image
            cityOutput.Parent = background;
            tempOutput.Parent = background;
            minOutput.Parent = background;
            maxOutput.Parent = background;
            feelsLikeLabel.Parent = background;
            conditionLabel.Parent = background;
            windSpeedLabel.Parent = background;
            humidityLabel.Parent = background;
            dateLabel.Parent = background;
            tmrwCondLabel.Parent = background;
            nextDayLabel.Parent = background;
            day2CondLabel.Parent = background;
            finalDayLabel.Parent = background;
            day3CondLabel.Parent = background;
            tomorrowLabel.Parent = background;
            forecastLabel.Parent = background;
            underlineLabel.Parent = background;
            #endregion
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

            //weather number
            int conditionNumber = Convert.ToInt32(Form1.days[0].conditionNumber);
            //clear sky conditions
            if (conditionNumber == 800)
            {
                background.Image = Properties.Resources.SunnyBackGround;
                background.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //rain conditions
            else if(conditionNumber < 600 && conditionNumber > 500)
            {
                background.Image = Properties.Resources.RainBackground;
                background.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //thunder conditions
            else if(conditionNumber > 200 && conditionNumber < 300)
            {
                //backgroundImage = Properties.Resources.
            }
            //cloudy
            else if (conditionNumber >800)
            {

            }





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
