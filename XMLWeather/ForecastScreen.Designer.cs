namespace XMLWeather
{
    partial class ForecastScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.todayLabel = new System.Windows.Forms.Label();
            this.underlineLabel2 = new System.Windows.Forms.Label();
            this.day1Label = new System.Windows.Forms.Label();
            this.day2Label = new System.Windows.Forms.Label();
            this.day3Label = new System.Windows.Forms.Label();
            this.day4Label = new System.Windows.Forms.Label();
            this.day5Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(82, 0);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(169, 57);
            this.todayLabel.TabIndex = 61;
            this.todayLabel.Text = "Today";
            this.todayLabel.Click += new System.EventHandler(this.todayLabel_Click);
            // 
            // underlineLabel2
            // 
            this.underlineLabel2.BackColor = System.Drawing.Color.Transparent;
            this.underlineLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineLabel2.ForeColor = System.Drawing.Color.White;
            this.underlineLabel2.Location = new System.Drawing.Point(-6, 36);
            this.underlineLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.underlineLabel2.Name = "underlineLabel2";
            this.underlineLabel2.Size = new System.Drawing.Size(257, 34);
            this.underlineLabel2.TabIndex = 63;
            this.underlineLabel2.Text = "____________________________";
            this.underlineLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // day1Label
            // 
            this.day1Label.BackColor = System.Drawing.Color.Transparent;
            this.day1Label.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day1Label.ForeColor = System.Drawing.Color.White;
            this.day1Label.Location = new System.Drawing.Point(3, 70);
            this.day1Label.Name = "day1Label";
            this.day1Label.Size = new System.Drawing.Size(299, 56);
            this.day1Label.TabIndex = 64;
            this.day1Label.Text = "Monday";
            // 
            // day2Label
            // 
            this.day2Label.BackColor = System.Drawing.Color.Transparent;
            this.day2Label.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day2Label.ForeColor = System.Drawing.Color.White;
            this.day2Label.Location = new System.Drawing.Point(3, 179);
            this.day2Label.Name = "day2Label";
            this.day2Label.Size = new System.Drawing.Size(299, 56);
            this.day2Label.TabIndex = 65;
            this.day2Label.Text = "Tueday";
            // 
            // day3Label
            // 
            this.day3Label.BackColor = System.Drawing.Color.Transparent;
            this.day3Label.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day3Label.ForeColor = System.Drawing.Color.White;
            this.day3Label.Location = new System.Drawing.Point(3, 302);
            this.day3Label.Name = "day3Label";
            this.day3Label.Size = new System.Drawing.Size(299, 56);
            this.day3Label.TabIndex = 66;
            this.day3Label.Text = "Wednesday";
            // 
            // day4Label
            // 
            this.day4Label.BackColor = System.Drawing.Color.Transparent;
            this.day4Label.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day4Label.ForeColor = System.Drawing.Color.White;
            this.day4Label.Location = new System.Drawing.Point(3, 425);
            this.day4Label.Name = "day4Label";
            this.day4Label.Size = new System.Drawing.Size(299, 56);
            this.day4Label.TabIndex = 67;
            this.day4Label.Text = "Thursday";
            // 
            // day5Label
            // 
            this.day5Label.BackColor = System.Drawing.Color.Transparent;
            this.day5Label.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day5Label.ForeColor = System.Drawing.Color.White;
            this.day5Label.Location = new System.Drawing.Point(3, 547);
            this.day5Label.Name = "day5Label";
            this.day5Label.Size = new System.Drawing.Size(299, 56);
            this.day5Label.TabIndex = 68;
            this.day5Label.Text = "Friday";
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.ForeCastBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.day5Label);
            this.Controls.Add(this.day4Label);
            this.Controls.Add(this.day3Label);
            this.Controls.Add(this.day2Label);
            this.Controls.Add(this.day1Label);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.underlineLabel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(487, 705);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label underlineLabel2;
        private System.Windows.Forms.Label day1Label;
        private System.Windows.Forms.Label day2Label;
        private System.Windows.Forms.Label day3Label;
        private System.Windows.Forms.Label day4Label;
        private System.Windows.Forms.Label day5Label;
    }
}
