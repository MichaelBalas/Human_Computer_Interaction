namespace ParkingMeter
{
    partial class dateAndTime
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
            this.masterTimer = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // masterTimer
            // 
            this.masterTimer.Enabled = true;
            this.masterTimer.Tick += new System.EventHandler(this.masterTimer_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.time.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Snow;
            this.time.Location = new System.Drawing.Point(212, 18);
            this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(61, 27);
            this.time.TabIndex = 3;
            this.time.Text = "Time";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.date.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Snow;
            this.date.Location = new System.Drawing.Point(14, 18);
            this.date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(57, 27);
            this.date.TabIndex = 2;
            this.date.Text = "Date";
            // 
            // dateAndTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Location = new System.Drawing.Point(634, -1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "dateAndTime";
            this.Size = new System.Drawing.Size(312, 61);
            this.Load += new System.EventHandler(this.dateAndTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer masterTimer;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
    }
}
