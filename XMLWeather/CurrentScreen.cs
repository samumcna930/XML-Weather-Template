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
            humidityLabel.Parent = background;
            dateLabel.Parent = background;
            tmrwCondLabel.Parent = background;
            nextDayLabel.Parent = background;
            day2CondLabel.Parent = background;
            finalDayLabel.Parent = background;
            day3CondLabel.Parent = background;
            tomorrowLabel.Parent = background;
            forecastLabel.Parent = background;
            lowLabel.Parent = background;
            highLabel.Parent = background;
            day1Icon.Parent = background;
            day2Icon.Parent = background;
            day3Icon.Parent = background;
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

            //display humidity 
            humidityLabel.Text = "Humidity " + Form1.days[0].humidity + "%";

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

            #region Background Change
            //weather number
            int conditionNumber = Convert.ToInt32(Form1.days[0].conditionNumber);
            //clear sky conditions
            if (conditionNumber == 800)
            {
                background.Image = Properties.Resources.SunnyBackGround;
                background.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //rain conditions
            else if (conditionNumber < 600 && conditionNumber > 300)
            {
                background.Image = Properties.Resources.RainBackground;
                background.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //thunder conditions
            else if (conditionNumber > 200 && conditionNumber < 300)
            {
                background.Image = Properties.Resources.ThunderStormBackground;
                background.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //cloudy
            else if (conditionNumber > 800)
            {
                background.Image = Properties.Resources.CloudyBackground;
                background.BackgroundImageLayout = ImageLayout.Stretch;
                tomorrowLabel.ForeColor = Color.Black;
                nextDayLabel.ForeColor = Color.Black;
                finalDayLabel.ForeColor = Color.Black;
                humidityLabel.ForeColor = Color.Black;
                feelsLikeLabel.ForeColor = Color.Black;
                tmrwCondLabel.ForeColor = Color.Black;
                day2CondLabel.ForeColor = Color.Black;
                day3CondLabel.ForeColor = Color.Black;
            }
            else
            {
                background.Image = Properties.Resources.DefaultBackground;
                background.BackgroundImageLayout = ImageLayout.Stretch;
            }
            #endregion

            #region Tomorrow icon Change
            int conditionNumber1 = Convert.ToInt32(Form1.days[1].conditionNumber);
            if (conditionNumber1 == 800)
            {
                day1Icon.BackgroundImage = Properties.Resources.SunnyIcon;
                day1Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //rain conditions
            else if (conditionNumber1 < 600 && conditionNumber1 > 300)
            {
                day1Icon.BackgroundImage = Properties.Resources.RainIcon;
                day1Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //thunder conditions
            else if (conditionNumber1 > 200 && conditionNumber1 < 300)
            {
                day1Icon.BackgroundImage = Properties.Resources.ThunderStormIcon;
                day1Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //cloudy
            else if (conditionNumber1 > 800)
            {
                day1Icon.BackgroundImage = Properties.Resources.CloudyIcon;
                day1Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            #endregion

            #region Day after tomorrow icon Change
            int conditionNumber2 = Convert.ToInt32(Form1.days[2].conditionNumber);
            //sunny condition
            if (conditionNumber2 == 800)
            {
                day2Icon.BackgroundImage = Properties.Resources.SunnyIcon;
                day2Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //rain conditions
            else if (conditionNumber2 < 600 && conditionNumber2 > 300)
            {
                day2Icon.BackgroundImage = Properties.Resources.RainIcon;
                day2Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //thunder conditions
            else if (conditionNumber2 > 200 && conditionNumber2 < 300)
            {
                day2Icon.BackgroundImage = Properties.Resources.ThunderStormIcon;
                day2Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //cloudy
            else if (conditionNumber2 > 800)
            {
                day2Icon.BackgroundImage = Properties.Resources.CloudyIcon;
                day2Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            #endregion

            #region Final Day Icon
            int conditionNumber3 = Convert.ToInt32(Form1.days[3].conditionNumber);
            if (conditionNumber3 == 800)
            {
                day3Icon.Image = Properties.Resources.SunnyIcon;
                day3Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //rain conditions
            else if (conditionNumber3 < 600 && conditionNumber3 > 300)
            {
                day3Icon.BackgroundImage = Properties.Resources.RainIcon;
                day3Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //thunder conditions
            else if (conditionNumber3 > 200 && conditionNumber3 < 300)
            {
                day3Icon.BackgroundImage = Properties.Resources.ThunderStormIcon;
                day3Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //cloudy
            else if (conditionNumber3 > 800)
            {
                day3Icon.BackgroundImage = Properties.Resources.CloudyIcon;
                day3Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            #endregion 

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
