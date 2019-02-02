namespace ParkingMeter
{
    partial class refundCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(refundCard));
            this.dateAndTime1 = new ParkingMeter.dateAndTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accountNumber = new System.Windows.Forms.Button();
            this.bankAccount = new ParkingMeter.bankAccount();
            this.pinPad = new ParkingMeter.pinPad();
            this.backButton = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 34.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 93);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please insert card below.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 34.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(875, 93);
            this.label2.TabIndex = 10;
            this.label2.Text = "Alternatively, you can enter your";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountNumber
            // 
            this.accountNumber.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.accountNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountNumber.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.accountNumber.FlatAppearance.BorderSize = 3;
            this.accountNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountNumber.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumber.Location = new System.Drawing.Point(322, 395);
            this.accountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Size = new System.Drawing.Size(519, 84);
            this.accountNumber.TabIndex = 14;
            this.accountNumber.Text = "Account Number";
            this.accountNumber.UseVisualStyleBackColor = false;
            this.accountNumber.Click += new System.EventHandler(this.accountNumber_Click);
            // 
            // bankAccount
            // 
            this.bankAccount.BackColor = System.Drawing.Color.SlateBlue;
            this.bankAccount.Location = new System.Drawing.Point(0, 0);
            this.bankAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bankAccount.Name = "bankAccount";
            this.bankAccount.Size = new System.Drawing.Size(1157, 510);
            this.bankAccount.TabIndex = 15;
            // 
            // pinPad
            // 
            this.pinPad.BackColor = System.Drawing.Color.SlateBlue;
            this.pinPad.Location = new System.Drawing.Point(0, 0);
            this.pinPad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pinPad.Name = "pinPad";
            this.pinPad.Size = new System.Drawing.Size(1157, 510);
            this.pinPad.TabIndex = 16;
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
            this.backButton.TabIndex = 17;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // refundCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.accountNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateAndTime1);
            this.Controls.Add(this.bankAccount);
            this.Controls.Add(this.pinPad);
            this.Name = "refundCard";
            this.Size = new System.Drawing.Size(1157, 510);
            this.ResumeLayout(false);

        }

        #endregion

        private dateAndTime dateAndTime1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button accountNumber;
        private bankAccount bankAccount;
        private pinPad pinPad;
        private System.Windows.Forms.Button backButton;
    }
}
