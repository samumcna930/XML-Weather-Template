﻿namespace XMLWeather
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
            this.day1Icon = new System.Windows.Forms.PictureBox();
            this.day2Icon = new System.Windows.Forms.PictureBox();
            this.day4Icon = new System.Windows.Forms.PictureBox();
            this.day3Icon = new System.Windows.Forms.PictureBox();
            this.day5Icon = new System.Windows.Forms.PictureBox();
            this.temp1Label = new System.Windows.Forms.Label();
            this.temp5Label = new System.Windows.Forms.Label();
            this.temp2Label = new System.Windows.Forms.Label();
            this.temp3Label = new System.Windows.Forms.Label();
            this.temp4Label = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.day1Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day2Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day4Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day3Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day5Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(11, 0);
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
            this.underlineLabel2.Size = new System.Drawing.Size(199, 34);
            this.underlineLabel2.TabIndex = 63;
            this.underlineLabel2.Text = "________________________";
            this.underlineLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // day1Label
            // 
            this.day1Label.BackColor = System.Drawing.Color.Transparent;
            this.day1Label.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day1Label.ForeColor = System.Drawing.Color.White;
            this.day1Label.Location = new System.Drawing.Point(-12, 70);
            this.day1Label.Name = "day1Label";
            this.day1Label.Size = new System.Drawing.Size(299, 56);
            this.day1Label.TabIndex = 64;
            this.day1Label.Text = "Monday";
            // 
            // day2Label
            // 
            this.day2Label.BackColor = System.Drawing.Color.Transparent;
            this.day2Label.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day2Label.ForeColor = System.Drawing.Color.White;
            this.day2Label.Location = new System.Drawing.Point(-12, 179);
            this.day2Label.Name = "day2Label";
            this.day2Label.Size = new System.Drawing.Size(299, 56);
            this.day2Label.TabIndex = 65;
            this.day2Label.Text = "Tuesday";
            // 
            // day3Label
            // 
            this.day3Label.BackColor = System.Drawing.Color.Transparent;
            this.day3Label.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day3Label.ForeColor = System.Drawing.Color.White;
            this.day3Label.Location = new System.Drawing.Point(-10, 302);
            this.day3Label.Name = "day3Label";
            this.day3Label.Size = new System.Drawing.Size(299, 56);
            this.day3Label.TabIndex = 66;
            this.day3Label.Text = "Wednesday";
            // 
            // day4Label
            // 
            this.day4Label.BackColor = System.Drawing.Color.Transparent;
            this.day4Label.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day4Label.ForeColor = System.Drawing.Color.White;
            this.day4Label.Location = new System.Drawing.Point(-10, 412);
            this.day4Label.Name = "day4Label";
            this.day4Label.Size = new System.Drawing.Size(299, 56);
            this.day4Label.TabIndex = 67;
            this.day4Label.Text = "Thursday";
            // 
            // day5Label
            // 
            this.day5Label.BackColor = System.Drawing.Color.Transparent;
            this.day5Label.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day5Label.ForeColor = System.Drawing.Color.White;
            this.day5Label.Location = new System.Drawing.Point(-10, 527);
            this.day5Label.Name = "day5Label";
            this.day5Label.Size = new System.Drawing.Size(299, 56);
            this.day5Label.TabIndex = 68;
            this.day5Label.Text = "Friday";
            // 
            // day1Icon
            // 
            this.day1Icon.BackColor = System.Drawing.Color.Transparent;
            this.day1Icon.Location = new System.Drawing.Point(386, 70);
            this.day1Icon.Name = "day1Icon";
            this.day1Icon.Size = new System.Drawing.Size(81, 81);
            this.day1Icon.TabIndex = 69;
            this.day1Icon.TabStop = false;
            // 
            // day2Icon
            // 
            this.day2Icon.BackColor = System.Drawing.Color.Transparent;
            this.day2Icon.Location = new System.Drawing.Point(386, 179);
            this.day2Icon.Name = "day2Icon";
            this.day2Icon.Size = new System.Drawing.Size(81, 81);
            this.day2Icon.TabIndex = 70;
            this.day2Icon.TabStop = false;
            // 
            // day4Icon
            // 
            this.day4Icon.BackColor = System.Drawing.Color.Transparent;
            this.day4Icon.Location = new System.Drawing.Point(386, 425);
            this.day4Icon.Name = "day4Icon";
            this.day4Icon.Size = new System.Drawing.Size(81, 81);
            this.day4Icon.TabIndex = 71;
            this.day4Icon.TabStop = false;
            // 
            // day3Icon
            // 
            this.day3Icon.BackColor = System.Drawing.Color.Transparent;
            this.day3Icon.Location = new System.Drawing.Point(386, 302);
            this.day3Icon.Name = "day3Icon";
            this.day3Icon.Size = new System.Drawing.Size(81, 81);
            this.day3Icon.TabIndex = 71;
            this.day3Icon.TabStop = false;
            // 
            // day5Icon
            // 
            this.day5Icon.BackColor = System.Drawing.Color.Transparent;
            this.day5Icon.Location = new System.Drawing.Point(386, 547);
            this.day5Icon.Name = "day5Icon";
            this.day5Icon.Size = new System.Drawing.Size(81, 81);
            this.day5Icon.TabIndex = 72;
            this.day5Icon.TabStop = false;
            // 
            // temp1Label
            // 
            this.temp1Label.BackColor = System.Drawing.Color.Transparent;
            this.temp1Label.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp1Label.Location = new System.Drawing.Point(7, 119);
            this.temp1Label.Name = "temp1Label";
            this.temp1Label.Size = new System.Drawing.Size(141, 69);
            this.temp1Label.TabIndex = 73;
            this.temp1Label.Text = "label1";
            // 
            // temp5Label
            // 
            this.temp5Label.BackColor = System.Drawing.Color.Transparent;
            this.temp5Label.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp5Label.Location = new System.Drawing.Point(7, 572);
            this.temp5Label.Name = "temp5Label";
            this.temp5Label.Size = new System.Drawing.Size(141, 69);
            this.temp5Label.TabIndex = 74;
            this.temp5Label.Text = "label2";
            // 
            // temp2Label
            // 
            this.temp2Label.BackColor = System.Drawing.Color.Transparent;
            this.temp2Label.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp2Label.Location = new System.Drawing.Point(12, 235);
            this.temp2Label.Name = "temp2Label";
            this.temp2Label.Size = new System.Drawing.Size(141, 69);
            this.temp2Label.TabIndex = 75;
            this.temp2Label.Text = "label3";
            // 
            // temp3Label
            // 
            this.temp3Label.BackColor = System.Drawing.Color.Transparent;
            this.temp3Label.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp3Label.Location = new System.Drawing.Point(14, 356);
            this.temp3Label.Name = "temp3Label";
            this.temp3Label.Size = new System.Drawing.Size(141, 69);
            this.temp3Label.TabIndex = 76;
            this.temp3Label.Text = "label4";
            // 
            // temp4Label
            // 
            this.temp4Label.BackColor = System.Drawing.Color.Transparent;
            this.temp4Label.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp4Label.Location = new System.Drawing.Point(7, 456);
            this.temp4Label.Name = "temp4Label";
            this.temp4Label.Size = new System.Drawing.Size(141, 69);
            this.temp4Label.TabIndex = 77;
            this.temp4Label.Text = "label5";
            // 
            // cityInput
            // 
            this.cityInput.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityInput.Location = new System.Drawing.Point(246, 3);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(202, 35);
            this.cityInput.TabIndex = 78;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.searchButton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.Location = new System.Drawing.Point(237, 53);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(109, 36);
            this.searchButton.TabIndex = 79;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::XMLWeather.Properties.Resources.rec;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(208, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 68);
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.ForeCastBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.temp4Label);
            this.Controls.Add(this.day4Label);
            this.Controls.Add(this.temp5Label);
            this.Controls.Add(this.day5Label);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.temp2Label);
            this.Controls.Add(this.temp1Label);
            this.Controls.Add(this.day5Icon);
            this.Controls.Add(this.day3Icon);
            this.Controls.Add(this.day4Icon);
            this.Controls.Add(this.day2Icon);
            this.Controls.Add(this.day1Icon);
            this.Controls.Add(this.day3Label);
            this.Controls.Add(this.day2Label);
            this.Controls.Add(this.day1Label);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.underlineLabel2);
            this.Controls.Add(this.temp3Label);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(487, 705);
            ((System.ComponentModel.ISupportInitialize)(this.day1Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day2Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day4Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day3Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day5Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label underlineLabel2;
        private System.Windows.Forms.Label day1Label;
        private System.Windows.Forms.Label day2Label;
        private System.Windows.Forms.Label day3Label;
        private System.Windows.Forms.Label day4Label;
        private System.Windows.Forms.Label day5Label;
        private System.Windows.Forms.PictureBox day1Icon;
        private System.Windows.Forms.PictureBox day2Icon;
        private System.Windows.Forms.PictureBox day4Icon;
        private System.Windows.Forms.PictureBox day3Icon;
        private System.Windows.Forms.PictureBox day5Icon;
        private System.Windows.Forms.Label temp1Label;
        private System.Windows.Forms.Label temp5Label;
        private System.Windows.Forms.Label temp2Label;
        private System.Windows.Forms.Label temp3Label;
        private System.Windows.Forms.Label temp4Label;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
