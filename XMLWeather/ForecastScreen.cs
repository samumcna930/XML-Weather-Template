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
            int conditionNumber4 = Convert.ToInt32(Form1.days[4].conditionNumber);
            if (conditionNumber4 == 800)
            {
                day3Icon.Image = Properties.Resources.SunnyIcon;
                day3Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            ////rain conditions
            //else if (conditionNumber3 < 600 && conditionNumber3 > 300)
            //{
            //    day3Icon.Image = Properties.Resources.RainIcon;
            //    day3Icon.BackgroundImageLayout = ImageLayout.Stretch;
            //}
            ////thunder conditions
            //else if (conditionNumber3 > 200 && conditionNumber3 < 300)
            //{
            //    day3Icon.Image = Properties.Resources.ThunderStormIcon;
            //    day3Icon.BackgroundImageLayout = ImageLayout.Stretch;
            //}
            ////cloudy
            //else if (conditionNumber3 > 800)
            //{
            //    day3Icon.Image = Properties.Resources.CloudyIcon;
            //    day3Icon.BackgroundImageLayout = ImageLayout.Stretch;
            //}
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
