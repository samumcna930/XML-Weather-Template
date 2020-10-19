namespace XMLWeather
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
            this.minOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.feelsLikeLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.tomorrowLabel = new System.Windows.Forms.Label();
            this.finalDayLabel = new System.Windows.Forms.Label();
            this.nextDayLabel = new System.Windows.Forms.Label();
            this.tmrwCondLabel = new System.Windows.Forms.Label();
            this.day2CondLabel = new System.Windows.Forms.Label();
            this.day3CondLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.underlineLabel = new System.Windows.Forms.Label();
            this.day3Icon = new System.Windows.Forms.PictureBox();
            this.day2Icon = new System.Windows.Forms.PictureBox();
            this.day1Icon = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.day3Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day2Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day1Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(-22, 0);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(262, 55);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempOutput
            // 
            this.tempOutput.BackColor = System.Drawing.Color.Transparent;
            this.tempOutput.Font = new System.Drawing.Font("Yu Gothic UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempOutput.ForeColor = System.Drawing.Color.White;
            this.tempOutput.Location = new System.Drawing.Point(113, 241);
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
            this.forecastLabel.Location = new System.Drawing.Point(285, 0);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(198, 55);
            this.forecastLabel.TabIndex = 40;
            this.forecastLabel.Text = "Forecast";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(26, 241);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(105, 52);
            this.minOutput.TabIndex = 43;
            this.minOutput.Text = "123";
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Myanmar Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(364, 241);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(110, 51);
            this.maxOutput.TabIndex = 44;
            this.maxOutput.Text = "123";
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(-15, 41);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(247, 44);
            this.dateLabel.TabIndex = 45;
            this.dateLabel.Text = "00:12:60";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feelsLikeLabel
            // 
            this.feelsLikeLabel.BackColor = System.Drawing.Color.Transparent;
            this.feelsLikeLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feelsLikeLabel.ForeColor = System.Drawing.Color.White;
            this.feelsLikeLabel.Location = new System.Drawing.Point(133, 383);
            this.feelsLikeLabel.Name = "feelsLikeLabel";
            this.feelsLikeLabel.Size = new System.Drawing.Size(230, 30);
            this.feelsLikeLabel.TabIndex = 46;
            this.feelsLikeLabel.Text = "Feels like";
            this.feelsLikeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humidityLabel
            // 
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.ForeColor = System.Drawing.Color.White;
            this.humidityLabel.Location = new System.Drawing.Point(133, 413);
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
            this.conditionLabel.Location = new System.Drawing.Point(57, 167);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(387, 49);
            this.conditionLabel.TabIndex = 49;
            this.conditionLabel.Text = "Sunny";
            this.conditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 60000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // tomorrowLabel
            // 
            this.tomorrowLabel.BackColor = System.Drawing.Color.Transparent;
            this.tomorrowLabel.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tomorrowLabel.ForeColor = System.Drawing.Color.White;
            this.tomorrowLabel.Location = new System.Drawing.Point(0, 527);
            this.tomorrowLabel.Name = "tomorrowLabel";
            this.tomorrowLabel.Size = new System.Drawing.Size(153, 39);
            this.tomorrowLabel.TabIndex = 50;
            this.tomorrowLabel.Text = "Tomorrow";
            // 
            // finalDayLabel
            // 
            this.finalDayLabel.BackColor = System.Drawing.Color.Transparent;
            this.finalDayLabel.Font = new System.Drawing.Font("Myanmar Text", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalDayLabel.ForeColor = System.Drawing.Color.White;
            this.finalDayLabel.Location = new System.Drawing.Point(323, 526);
            this.finalDayLabel.Name = "finalDayLabel";
            this.finalDayLabel.Size = new System.Drawing.Size(178, 40);
            this.finalDayLabel.TabIndex = 51;
            this.finalDayLabel.Text = "Thursday";
            this.finalDayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nextDayLabel
            // 
            this.nextDayLabel.BackColor = System.Drawing.Color.Transparent;
            this.nextDayLabel.Font = new System.Drawing.Font("Myanmar Text", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextDayLabel.ForeColor = System.Drawing.Color.White;
            this.nextDayLabel.Location = new System.Drawing.Point(159, 527);
            this.nextDayLabel.Name = "nextDayLabel";
            this.nextDayLabel.Size = new System.Drawing.Size(176, 39);
            this.nextDayLabel.TabIndex = 52;
            this.nextDayLabel.Text = "Wednesday";
            this.nextDayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmrwCondLabel
            // 
            this.tmrwCondLabel.BackColor = System.Drawing.Color.Transparent;
            this.tmrwCondLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmrwCondLabel.ForeColor = System.Drawing.Color.White;
            this.tmrwCondLabel.Location = new System.Drawing.Point(3, 590);
            this.tmrwCondLabel.Name = "tmrwCondLabel";
            this.tmrwCondLabel.Size = new System.Drawing.Size(168, 119);
            this.tmrwCondLabel.TabIndex = 56;
            this.tmrwCondLabel.Text = "label1";
            this.tmrwCondLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tmrwCondLabel.Visible = false;
            // 
            // day2CondLabel
            // 
            this.day2CondLabel.BackColor = System.Drawing.Color.Transparent;
            this.day2CondLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day2CondLabel.ForeColor = System.Drawing.Color.White;
            this.day2CondLabel.Location = new System.Drawing.Point(162, 590);
            this.day2CondLabel.Name = "day2CondLabel";
            this.day2CondLabel.Size = new System.Drawing.Size(168, 119);
            this.day2CondLabel.TabIndex = 57;
            this.day2CondLabel.Text = "label2";
            this.day2CondLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.day2CondLabel.Visible = false;
            // 
            // day3CondLabel
            // 
            this.day3CondLabel.BackColor = System.Drawing.Color.Transparent;
            this.day3CondLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day3CondLabel.ForeColor = System.Drawing.Color.White;
            this.day3CondLabel.Location = new System.Drawing.Point(330, 590);
            this.day3CondLabel.Name = "day3CondLabel";
            this.day3CondLabel.Size = new System.Drawing.Size(168, 119);
            this.day3CondLabel.TabIndex = 58;
            this.day3CondLabel.Text = "label3";
            this.day3CondLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.day3CondLabel.Visible = false;
            // 
            // lowLabel
            // 
            this.lowLabel.BackColor = System.Drawing.Color.Transparent;
            this.lowLabel.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowLabel.ForeColor = System.Drawing.Color.White;
            this.lowLabel.Location = new System.Drawing.Point(45, 293);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(61, 47);
            this.lowLabel.TabIndex = 60;
            this.lowLabel.Text = "Lo";
            // 
            // highLabel
            // 
            this.highLabel.BackColor = System.Drawing.Color.Transparent;
            this.highLabel.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLabel.ForeColor = System.Drawing.Color.White;
            this.highLabel.Location = new System.Drawing.Point(385, 293);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(63, 39);
            this.highLabel.TabIndex = 61;
            this.highLabel.Text = "Hi";
            // 
            // underlineLabel
            // 
            this.underlineLabel.BackColor = System.Drawing.Color.Transparent;
            this.underlineLabel.ForeColor = System.Drawing.Color.White;
            this.underlineLabel.Location = new System.Drawing.Point(291, 41);
            this.underlineLabel.Name = "underlineLabel";
            this.underlineLabel.Size = new System.Drawing.Size(226, 23);
            this.underlineLabel.TabIndex = 62;
            this.underlineLabel.Text = "_____________________________________________";
            // 
            // day3Icon
            // 
            this.day3Icon.BackColor = System.Drawing.Color.Transparent;
            this.day3Icon.Location = new System.Drawing.Point(373, 578);
            this.day3Icon.Name = "day3Icon";
            this.day3Icon.Size = new System.Drawing.Size(86, 70);
            this.day3Icon.TabIndex = 55;
            this.day3Icon.TabStop = false;
            // 
            // day2Icon
            // 
            this.day2Icon.BackColor = System.Drawing.Color.Transparent;
            this.day2Icon.Location = new System.Drawing.Point(199, 578);
            this.day2Icon.Name = "day2Icon";
            this.day2Icon.Size = new System.Drawing.Size(86, 70);
            this.day2Icon.TabIndex = 54;
            this.day2Icon.TabStop = false;
            // 
            // day1Icon
            // 
            this.day1Icon.BackColor = System.Drawing.Color.Transparent;
            this.day1Icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("day1Icon.BackgroundImage")));
            this.day1Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.day1Icon.Location = new System.Drawing.Point(30, 578);
            this.day1Icon.Name = "day1Icon";
            this.day1Icon.Size = new System.Drawing.Size(86, 70);
            this.day1Icon.TabIndex = 53;
            this.day1Icon.TabStop = false;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Transparent;
            this.background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background.BackgroundImage")));
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(487, 705);
            this.background.TabIndex = 59;
            this.background.TabStop = false;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.underlineLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.day3Icon);
            this.Controls.Add(this.day2Icon);
            this.Controls.Add(this.day1Icon);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.day2CondLabel);
            this.Controls.Add(this.tmrwCondLabel);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.day3CondLabel);
            this.Controls.Add(this.finalDayLabel);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.feelsLikeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.tempOutput);
            this.Controls.Add(this.nextDayLabel);
            this.Controls.Add(this.tomorrowLabel);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(487, 705);
            ((System.ComponentModel.ISupportInitialize)(this.day3Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day2Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day1Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label tempOutput;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label feelsLikeLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label tomorrowLabel;
        private System.Windows.Forms.Label finalDayLabel;
        private System.Windows.Forms.Label nextDayLabel;
        private System.Windows.Forms.PictureBox day1Icon;
        private System.Windows.Forms.PictureBox day2Icon;
        private System.Windows.Forms.PictureBox day3Icon;
        private System.Windows.Forms.Label tmrwCondLabel;
        private System.Windows.Forms.Label day2CondLabel;
        private System.Windows.Forms.Label day3CondLabel;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label underlineLabel;
    }
}
