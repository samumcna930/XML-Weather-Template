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
    public partial class SearchScreen : UserControl
    {
        public SearchScreen()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try 
            {
                errorLabel.Text = "";
                Form1.location = cityInput.Text;

                Form f = this.FindForm();
                f.Controls.Remove(this);

                CurrentScreen cs = new CurrentScreen();
                f.Controls.Add(cs);
            }
            catch 
            {
                errorLabel.Text = "Please try again";
            }
        }
    }
}
