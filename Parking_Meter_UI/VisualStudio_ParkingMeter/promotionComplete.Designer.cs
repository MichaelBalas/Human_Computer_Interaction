namespace ParkingMeter
{
    partial class promotionComplete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(promotionComplete));
            this.dateAndTime1 = new ParkingMeter.dateAndTime();
            this.ticketInfo = new System.Windows.Forms.Label();
            this.theEnd = new ParkingMeter.theEnd();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dateAndTime1
            // 
            this.dateAndTime1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dateAndTime1.Location = new System.Drawing.Point(741, 0);
            this.dateAndTime1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateAndTime1.Name = "dateAndTime1";
            this.dateAndTime1.Size = new System.Drawing.Size(416, 75);
            this.dateAndTime1.TabIndex = 0;
            // 
            // ticketInfo
            // 
            this.ticketInfo.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketInfo.ForeColor = System.Drawing.Color.Black;
            this.ticketInfo.Location = new System.Drawing.Point(235, 86);
            this.ticketInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ticketInfo.Name = "ticketInfo";
            this.ticketInfo.Size = new System.Drawing.Size(695, 158);
            this.ticketInfo.TabIndex = 7;
            this.ticketInfo.Text = "Printing promotional offer...";
            this.ticketInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // theEnd
            // 
            this.theEnd.BackColor = System.Drawing.Color.SlateBlue;
            this.theEnd.Location = new System.Drawing.Point(0, 0);
            this.theEnd.Name = "theEnd";
            this.theEnd.Size = new System.Drawing.Size(1157, 510);
            this.theEnd.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(693, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(428, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(693, 297);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(296, 213);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(561, 297);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(288, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 294);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(663, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 294);
            this.panel2.TabIndex = 13;
            // 
            // promotionComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ticketInfo);
            this.Controls.Add(this.dateAndTime1);
            this.Controls.Add(this.theEnd);
            this.Name = "promotionComplete";
            this.Size = new System.Drawing.Size(1157, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dateAndTime dateAndTime1;
        private System.Windows.Forms.Label ticketInfo;
        private theEnd theEnd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
