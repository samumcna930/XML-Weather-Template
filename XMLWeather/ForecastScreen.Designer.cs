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
            this.label3 = new System.Windows.Forms.Label();
            this.underlineLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 57);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.underlineLabel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(487, 654);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label underlineLabel2;
    }
}
