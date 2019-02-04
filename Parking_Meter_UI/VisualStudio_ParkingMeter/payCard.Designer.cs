namespace ParkingMeter
{
    partial class payCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payCard));
            this.backButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accountNumber = new System.Windows.Forms.Button();
            this.cardPayFeedback = new System.Windows.Forms.Label();
            this.original = new System.Windows.Forms.Label();
            this.dateAndTime1 = new ParkingMeter.dateAndTime();
            this.transactionComplete = new ParkingMeter.transactionComplete();
            this.pinPad = new ParkingMeter.pinPad();
            this.bankAccount = new ParkingMeter.bankAccount();
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
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 61);
            this.backButton.TabIndex = 9;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(563, 143);
            this.label2.TabIndex = 11;
            this.label2.Text = "Please tap, swipe, or insert card below...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 88);
            this.label1.TabIndex = 12;
            this.label1.Text = "Alternatively, you can enter your";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountNumber
            // 
            this.accountNumber.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.accountNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountNumber.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.accountNumber.FlatAppearance.BorderSize = 3;
            this.accountNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountNumber.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumber.Location = new System.Drawing.Point(271, 332);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Size = new System.Drawing.Size(342, 56);
            this.accountNumber.TabIndex = 13;
            this.accountNumber.Text = "Account Number";
            this.accountNumber.UseVisualStyleBackColor = false;
            this.accountNumber.Click += new System.EventHandler(this.accountNumber_Click);
            // 
            // cardPayFeedback
            // 
            this.cardPayFeedback.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardPayFeedback.Location = new System.Drawing.Point(76, 78);
            this.cardPayFeedback.Name = "cardPayFeedback";
            this.cardPayFeedback.Size = new System.Drawing.Size(767, 68);
            this.cardPayFeedback.TabIndex = 14;
            this.cardPayFeedback.Text = "Pay $XX.XX and park until XX:XX XX";
            this.cardPayFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // original
            // 
            this.original.AutoSize = true;
            this.original.Location = new System.Drawing.Point(772, 239);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(0, 13);
            this.original.TabIndex = 15;
            this.original.Visible = false;
            // 
            // dateAndTime1
            // 
            this.dateAndTime1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dateAndTime1.Location = new System.Drawing.Point(556, 0);
            this.dateAndTime1.Margin = new System.Windows.Forms.Padding(2);
            this.dateAndTime1.Name = "dateAndTime1";
            this.dateAndTime1.Size = new System.Drawing.Size(312, 61);
            this.dateAndTime1.TabIndex = 0;
            // 
            // transactionComplete
            // 
            this.transactionComplete.BackColor = System.Drawing.Color.SlateBlue;
            this.transactionComplete.Location = new System.Drawing.Point(0, 0);
            this.transactionComplete.Name = "transactionComplete";
            this.transactionComplete.Size = new System.Drawing.Size(868, 414);
            this.transactionComplete.TabIndex = 16;
            // 
            // pinPad
            // 
            this.pinPad.BackColor = System.Drawing.Color.SlateBlue;
            this.pinPad.Location = new System.Drawing.Point(0, 0);
            this.pinPad.Name = "pinPad";
            this.pinPad.Size = new System.Drawing.Size(868, 414);
            this.pinPad.TabIndex = 17;
            // 
            // bankAccount
            // 
            this.bankAccount.BackColor = System.Drawing.Color.SlateBlue;
            this.bankAccount.Location = new System.Drawing.Point(0, 0);
            this.bankAccount.Name = "bankAccount";
            this.bankAccount.Size = new System.Drawing.Size(868, 414);
            this.bankAccount.TabIndex = 18;
            // 
            // payCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.original);
            this.Controls.Add(this.cardPayFeedback);
            this.Controls.Add(this.accountNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dateAndTime1);
            this.Controls.Add(this.transactionComplete);
            this.Controls.Add(this.pinPad);
            this.Controls.Add(this.bankAccount);
            this.Name = "payCard";
            this.Size = new System.Drawing.Size(868, 414);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dateAndTime dateAndTime1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button accountNumber;
        private System.Windows.Forms.Label cardPayFeedback;
        private System.Windows.Forms.Label original;
        private transactionComplete transactionComplete;
        private pinPad pinPad;
        private bankAccount bankAccount;
    }
}
