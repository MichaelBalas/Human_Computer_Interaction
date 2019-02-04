namespace ParkingMeter
{
    partial class paymentMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentMethod));
            this.backButton = new System.Windows.Forms.Button();
            this.payByCash = new System.Windows.Forms.Button();
            this.payByCard = new System.Windows.Forms.Button();
            this.dateAndTime1 = new ParkingMeter.dateAndTime();
            this.payCash = new ParkingMeter.payCash();
            this.payCard = new ParkingMeter.payCard();
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
            this.backButton.TabIndex = 7;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // payByCash
            // 
            this.payByCash.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.payByCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.payByCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payByCash.FlatAppearance.BorderSize = 0;
            this.payByCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payByCash.Font = new System.Drawing.Font("Roboto", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payByCash.ForeColor = System.Drawing.Color.Snow;
            this.payByCash.Location = new System.Drawing.Point(122, 93);
            this.payByCash.Margin = new System.Windows.Forms.Padding(2);
            this.payByCash.Name = "payByCash";
            this.payByCash.Size = new System.Drawing.Size(244, 261);
            this.payByCash.TabIndex = 8;
            this.payByCash.TabStop = false;
            this.payByCash.Text = "Cash (Coins/Bills)";
            this.payByCash.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.payByCash.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.payByCash.UseVisualStyleBackColor = false;
            this.payByCash.Click += new System.EventHandler(this.payByCash_Click);
            // 
            // payByCard
            // 
            this.payByCard.BackColor = System.Drawing.Color.Crimson;
            this.payByCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.payByCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payByCard.FlatAppearance.BorderSize = 0;
            this.payByCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payByCard.Font = new System.Drawing.Font("Roboto", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payByCard.ForeColor = System.Drawing.Color.Snow;
            this.payByCard.Location = new System.Drawing.Point(485, 93);
            this.payByCard.Margin = new System.Windows.Forms.Padding(2);
            this.payByCard.Name = "payByCard";
            this.payByCard.Size = new System.Drawing.Size(244, 261);
            this.payByCard.TabIndex = 9;
            this.payByCard.TabStop = false;
            this.payByCard.Text = "Card (Credit/Debit)";
            this.payByCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.payByCard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.payByCard.UseVisualStyleBackColor = false;
            this.payByCard.Click += new System.EventHandler(this.payByCard_Click);
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
            // payCash
            // 
            this.payCash.BackColor = System.Drawing.Color.SlateBlue;
            this.payCash.Location = new System.Drawing.Point(0, 0);
            this.payCash.Name = "payCash";
            this.payCash.Size = new System.Drawing.Size(868, 414);
            this.payCash.TabIndex = 10;
            // 
            // payCard
            // 
            this.payCard.BackColor = System.Drawing.Color.SlateBlue;
            this.payCard.Location = new System.Drawing.Point(0, -3);
            this.payCard.Name = "payCard";
            this.payCard.Size = new System.Drawing.Size(868, 414);
            this.payCard.TabIndex = 11;
            // 
            // paymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.payByCard);
            this.Controls.Add(this.payByCash);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dateAndTime1);
            this.Controls.Add(this.payCard);
            this.Controls.Add(this.payCash);
            this.Name = "paymentMethod";
            this.Size = new System.Drawing.Size(868, 414);
            this.ResumeLayout(false);

        }

        #endregion

        private dateAndTime dateAndTime1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button payByCash;
        private payCash payCash;
        private payCard payCard;
        private System.Windows.Forms.Button payByCard;
    }
}
