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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            #region day 1 icon conditions
            int conditionNumber1 = Convert.ToInt32(Form1.days[0].conditionNumber);
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

            #region day 2 icon conditions
            int conditionNumber2 = Convert.ToInt32(Form1.days[1].conditionNumber);
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

            #region day 3 icon conditions 
            int conditionNumber3 = Convert.ToInt32(Form1.days[2].conditionNumber);
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

            #region day 4 icon conditions
            int conditionNumber4 = Convert.ToInt32(Form1.days[3].conditionNumber);
            if (conditionNumber4 == 800)
            {
                day4Icon.Image = Properties.Resources.SunnyIcon;
                day4Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //rain conditions
            else if (conditionNumber3 < 600 && conditionNumber3 > 300)
            {
                day4Icon.BackgroundImage = Properties.Resources.RainIcon;
                day4Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //thunder conditions
            else if (conditionNumber3 > 200 && conditionNumber3 < 300)
            {
                day4Icon.BackgroundImage = Properties.Resources.ThunderStormIcon;
                day4Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //cloudy
            else if (conditionNumber3 > 800)
            {
                day4Icon.BackgroundImage = Properties.Resources.CloudyIcon;
                day4Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            #endregion

            #region day 5 icon coditions
            int conditionNumber5 = Convert.ToInt32(Form1.days[4].conditionNumber);
            //day 5 icon conditions
            if (conditionNumber5 == 800)
            {
                day5Icon.Image = Properties.Resources.SunnyIcon;
                day5Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //rain conditions
            else if (conditionNumber5 < 600 && conditionNumber5 > 300)
            {
                day5Icon.Image = Properties.Resources.RainIcon;
                day5Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //thunder conditions
            else if (conditionNumber5 > 200 && conditionNumber5 < 300)
            {
                day5Icon.Image = Properties.Resources.ThunderStormIcon;
                day5Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //cloudy
            else if (conditionNumber5 > 800)
            {
                day5Icon.Image = Properties.Resources.CloudyIcon;
                day5Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            #endregion

            double tempLow = Convert.ToDouble(Form1.days[0].tempLow);
            double tempHigh = Convert.ToDouble(Form1.days[0].tempHigh);
            temp1Label.Text = tempLow.ToString("##") + "\u00B0" + "C" + " / " + tempHigh.ToString("##") + "\u00B0" + "C";

            double tempLow2 = Convert.ToDouble(Form1.days[1].tempLow);
            double tempHigh2 = Convert.ToDouble(Form1.days[1].tempHigh);
            temp2Label.Text = tempLow2.ToString("##") + "\u00B0" + "C" + " / " + tempHigh2.ToString("##") + "\u00B0" + "C";

            double tempLow3 = Convert.ToDouble(Form1.days[2].tempLow);
            double tempHigh3 = Convert.ToDouble(Form1.days[2].tempHigh);
            temp3Label.Text = tempLow3.ToString("##") + "\u00B0" + "C" + " / " + tempHigh3.ToString("##") + "\u00B0" + "C";

            double tempLow4 = Convert.ToDouble(Form1.days[3].tempLow);
            double tempHigh4 = Convert.ToDouble(Form1.days[3].tempHigh);
            temp4Label.Text = tempLow4.ToString("##") + "\u00B0" + "C" + " / " + tempHigh4.ToString("##") + "\u00B0" + "C";

            double tempLow5 = Convert.ToDouble(Form1.days[4].tempLow);
            double tempHigh5 = Convert.ToDouble(Form1.days[4].tempHigh);
            temp5Label.Text = tempLow5.ToString("##") + "\u00B0" + "C" + " / " + tempHigh5.ToString("##") + "\u00B0" + "C";

            day1Label.Text = DateTime.Now.ToString("dddd");
            day2Label.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            day3Label.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            day4Label.Text = DateTime.Now.AddDays(3).DayOfWeek.ToString();
            day5Label.Text = DateTime.Now.AddDays(4).DayOfWeek.ToString();
        }

        private void todayLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
