﻿namespace XMLWeather
{
    partial class CurrentScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentScreen));
            this.cityOutput = new System.Windows.Forms.Label();
            this.tempOutput = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.underlineLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.feelsLikeLabel = new System.Windows.Forms.Label();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.tomorrowLabel = new System.Windows.Forms.Label();
            this.nextDayLabel = new System.Windows.Forms.Label();
            this.finalDayLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tomorrowTempLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(-45, 0);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(283, 55);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempOutput
            // 
            this.tempOutput.BackColor = System.Drawing.Color.Transparent;
            this.tempOutput.Font = new System.Drawing.Font("Yu Gothic UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempOutput.ForeColor = System.Drawing.Color.White;
            this.tempOutput.Location = new System.Drawing.Point(114, 168);
            this.tempOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempOutput.Name = "tempOutput";
            this.tempOutput.Size = new System.Drawing.Size(265, 132);
            this.tempOutput.TabIndex = 28;
            this.tempOutput.Text = "123";
            this.tempOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(191, 0);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(198, 55);
            this.forecastLabel.TabIndex = 40;
            this.forecastLabel.Text = "Forecast";
            // 
            // underlineLabel
            // 
            this.underlineLabel.BackColor = System.Drawing.Color.Transparent;
            this.underlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineLabel.ForeColor = System.Drawing.Color.White;
            this.underlineLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.underlineLabel.Location = new System.Drawing.Point(243, 31);
            this.underlineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.underlineLabel.Name = "underlineLabel";
            this.underlineLabel.Size = new System.Drawing.Size(263, 34);
            this.underlineLabel.TabIndex = 42;
            this.underlineLabel.Text = "_________________________";
            this.underlineLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.Aqua;
            this.minOutput.Location = new System.Drawing.Point(41, 158);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(115, 52);
            this.minOutput.TabIndex = 43;
            this.minOutput.Text = "123";
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Myanmar Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.OrangeRed;
            this.maxOutput.Location = new System.Drawing.Point(340, 158);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(115, 51);
            this.maxOutput.TabIndex = 44;
            this.maxOutput.Text = "123";
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(-30, 41);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(247, 42);
            this.dateLabel.TabIndex = 45;
            this.dateLabel.Text = "00:12:60";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feelsLikeLabel
            // 
            this.feelsLikeLabel.BackColor = System.Drawing.Color.Transparent;
            this.feelsLikeLabel.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feelsLikeLabel.ForeColor = System.Drawing.Color.White;
            this.feelsLikeLabel.Location = new System.Drawing.Point(134, 310);
            this.feelsLikeLabel.Name = "feelsLikeLabel";
            this.feelsLikeLabel.Size = new System.Drawing.Size(230, 30);
            this.feelsLikeLabel.TabIndex = 46;
            this.feelsLikeLabel.Text = "Feels like";
            this.feelsLikeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.windSpeedLabel.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.windSpeedLabel.Location = new System.Drawing.Point(10, 360);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(230, 33);
            this.windSpeedLabel.TabIndex = 47;
            this.windSpeedLabel.Text = "1234";
            this.windSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humidityLabel
            // 
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.ForeColor = System.Drawing.Color.White;
            this.humidityLabel.Location = new System.Drawing.Point(245, 360);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(230, 33);
            this.humidityLabel.TabIndex = 48;
            this.humidityLabel.Text = "Humidity";
            this.humidityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conditionLabel
            // 
            this.conditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionLabel.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.ForeColor = System.Drawing.Color.White;
            this.conditionLabel.Location = new System.Drawing.Point(88, 109);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(310, 49);
            this.conditionLabel.TabIndex = 49;
            this.conditionLabel.Text = "Sunny";
            this.conditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // tomorrowLabel
            // 
            this.tomorrowLabel.BackColor = System.Drawing.Color.Transparent;
            this.tomorrowLabel.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tomorrowLabel.ForeColor = System.Drawing.Color.White;
            this.tomorrowLabel.Location = new System.Drawing.Point(3, 485);
            this.tomorrowLabel.Name = "tomorrowLabel";
            this.tomorrowLabel.Size = new System.Drawing.Size(153, 53);
            this.tomorrowLabel.TabIndex = 50;
            this.tomorrowLabel.Text = "Tomorrow";
            // 
            // nextDayLabel
            // 
            this.nextDayLabel.BackColor = System.Drawing.Color.Transparent;
            this.nextDayLabel.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextDayLabel.ForeColor = System.Drawing.Color.White;
            this.nextDayLabel.Location = new System.Drawing.Point(335, 485);
            this.nextDayLabel.Name = "nextDayLabel";
            this.nextDayLabel.Size = new System.Drawing.Size(171, 53);
            this.nextDayLabel.TabIndex = 51;
            this.nextDayLabel.Text = "Thursday";
            this.nextDayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // finalDayLabel
            // 
            this.finalDayLabel.BackColor = System.Drawing.Color.Transparent;
            this.finalDayLabel.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalDayLabel.ForeColor = System.Drawing.Color.White;
            this.finalDayLabel.Location = new System.Drawing.Point(162, 485);
            this.finalDayLabel.Name = "finalDayLabel";
            this.finalDayLabel.Size = new System.Drawing.Size(168, 53);
            this.finalDayLabel.TabIndex = 52;
            this.finalDayLabel.Text = "Wednesday";
            this.finalDayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(36, 528);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 67);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(205, 528);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 67);
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(379, 528);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 67);
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // tomorrowTempLabel
            // 
            this.tomorrowTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tomorrowTempLabel.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tomorrowTempLabel.ForeColor = System.Drawing.Color.White;
            this.tomorrowTempLabel.Location = new System.Drawing.Point(27, 611);
            this.tomorrowTempLabel.Name = "tomorrowTempLabel";
            this.tomorrowTempLabel.Size = new System.Drawing.Size(100, 37);
            this.tomorrowTempLabel.TabIndex = 56;
            this.tomorrowTempLabel.Text = "label1";
            this.tomorrowTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(201, 611);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 37);
            this.label2.TabIndex = 57;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(370, 611);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 34);
            this.label3.TabIndex = 58;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tomorrowTempLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.finalDayLabel);
            this.Controls.Add(this.nextDayLabel);
            this.Controls.Add(this.tomorrowLabel);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.windSpeedLabel);
            this.Controls.Add(this.feelsLikeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.tempOutput);
            this.Controls.Add(this.underlineLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(487, 705);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label tempOutput;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label underlineLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label feelsLikeLabel;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label tomorrowLabel;
        private System.Windows.Forms.Label nextDayLabel;
        private System.Windows.Forms.Label finalDayLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label tomorrowTempLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
