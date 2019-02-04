namespace ParkingMeter
{
    partial class refundScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refundTimeRemaining = new System.Windows.Forms.Label();
            this.redeemableFunds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cashBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateAndTime1 = new ParkingMeter.dateAndTime();
            this.refundCash = new ParkingMeter.refundCash();
            this.refundCard = new ParkingMeter.refundCard();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 77);
            this.label1.TabIndex = 9;
            this.label1.Text = "Time Remaining:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 77);
            this.label2.TabIndex = 10;
            this.label2.Text = "Redeemable Funds:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // refundTimeRemaining
            // 
            this.refundTimeRemaining.Font = new System.Drawing.Font("Roboto", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refundTimeRemaining.Location = new System.Drawing.Point(458, 110);
            this.refundTimeRemaining.Name = "refundTimeRemaining";
            this.refundTimeRemaining.Size = new System.Drawing.Size(685, 77);
            this.refundTimeRemaining.TabIndex = 11;
            this.refundTimeRemaining.Text = "08 hours and 48 minutes";
            this.refundTimeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // redeemableFunds
            // 
            this.redeemableFunds.Font = new System.Drawing.Font("Roboto", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redeemableFunds.Location = new System.Drawing.Point(458, 194);
            this.redeemableFunds.Name = "redeemableFunds";
            this.redeemableFunds.Size = new System.Drawing.Size(685, 77);
            this.redeemableFunds.TabIndex = 12;
            this.redeemableFunds.Text = "$52.80";
            this.redeemableFunds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(745, 151);
            this.label3.TabIndex = 13;
            this.label3.Text = "Please select your preferred method of reimbursment";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cashBack
            // 
            this.cashBack.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cashBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashBack.FlatAppearance.BorderSize = 0;
            this.cashBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashBack.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashBack.ForeColor = System.Drawing.Color.White;
            this.cashBack.Location = new System.Drawing.Point(215, 430);
            this.cashBack.Margin = new System.Windows.Forms.Padding(4);
            this.cashBack.Name = "cashBack";
            this.cashBack.Size = new System.Drawing.Size(163, 69);
            this.cashBack.TabIndex = 14;
            this.cashBack.Text = "Cash";
            this.cashBack.UseVisualStyleBackColor = false;
            this.cashBack.Click += new System.EventHandler(this.cashBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(488, 430);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 69);
            this.button1.TabIndex = 15;
            this.button1.Text = "Card";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(769, 430);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 69);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // refundCash
            // 
            this.refundCash.BackColor = System.Drawing.Color.SlateBlue;
            this.refundCash.Location = new System.Drawing.Point(0, 0);
            this.refundCash.Name = "refundCash";
            this.refundCash.Size = new System.Drawing.Size(1157, 510);
            this.refundCash.TabIndex = 17;
            // 
            // refundCard
            // 
            this.refundCard.BackColor = System.Drawing.Color.SlateBlue;
            this.refundCard.Location = new System.Drawing.Point(0, 0);
            this.refundCard.Name = "refundCard";
            this.refundCard.Size = new System.Drawing.Size(1157, 510);
            this.refundCard.TabIndex = 18;
            // 
            // refundScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cashBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.redeemableFunds);
            this.Controls.Add(this.refundTimeRemaining);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateAndTime1);
            this.Controls.Add(this.refundCash);
            this.Controls.Add(this.refundCard);
            this.Name = "refundScreen";
            this.Size = new System.Drawing.Size(1157, 510);
            this.ResumeLayout(false);

        }

        #endregion

        private dateAndTime dateAndTime1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label refundTimeRemaining;
        private System.Windows.Forms.Label redeemableFunds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cashBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private refundCash refundCash;
        private refundCard refundCard;
    }
}
