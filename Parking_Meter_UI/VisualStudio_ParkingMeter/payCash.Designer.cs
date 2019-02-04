namespace ParkingMeter
{
    partial class payCash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payCash));
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.remainingPrice = new System.Windows.Forms.Label();
            this.original = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.until = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateAndTime1 = new ParkingMeter.dateAndTime();
            this.transactionComplete = new ParkingMeter.transactionComplete();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 75);
            this.backButton.TabIndex = 8;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(783, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 175);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please enter  bills face-up in the slot below.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 210);
            this.label2.TabIndex = 10;
            this.label2.Text = "Please enter coins in the top slot below.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 210);
            this.label3.TabIndex = 11;
            this.label3.Text = "And/Or";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remainingPrice
            // 
            this.remainingPrice.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingPrice.Location = new System.Drawing.Point(408, 230);
            this.remainingPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.remainingPrice.Name = "remainingPrice";
            this.remainingPrice.Size = new System.Drawing.Size(343, 75);
            this.remainingPrice.TabIndex = 12;
            this.remainingPrice.Text = "10000000";
            this.remainingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // original
            // 
            this.original.AutoSize = true;
            this.original.Location = new System.Drawing.Point(969, 358);
            this.original.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(0, 17);
            this.original.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 47);
            this.label5.TabIndex = 16;
            this.label5.Text = "Parking Until";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // until
            // 
            this.until.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.until.Location = new System.Drawing.Point(404, 433);
            this.until.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.until.Name = "until";
            this.until.Size = new System.Drawing.Size(343, 75);
            this.until.TabIndex = 17;
            this.until.Text = "XX:XX XX";
            this.until.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 64);
            this.label4.TabIndex = 13;
            this.label4.Text = "Remaining Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(351, 148);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 4);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(693, 148);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 4);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 272);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(888, 270);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 238);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
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
            // transactionComplete
            // 
            this.transactionComplete.BackColor = System.Drawing.Color.SlateBlue;
            this.transactionComplete.Location = new System.Drawing.Point(0, 0);
            this.transactionComplete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.transactionComplete.Name = "transactionComplete";
            this.transactionComplete.Size = new System.Drawing.Size(1157, 510);
            this.transactionComplete.TabIndex = 15;
            // 
            // payCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateAndTime1);
            this.Controls.Add(this.until);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.original);
            this.Controls.Add(this.remainingPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.transactionComplete);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "payCash";
            this.Size = new System.Drawing.Size(1157, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dateAndTime dateAndTime1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label remainingPrice;
        private System.Windows.Forms.Label original;
        private transactionComplete transactionComplete;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label until;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
