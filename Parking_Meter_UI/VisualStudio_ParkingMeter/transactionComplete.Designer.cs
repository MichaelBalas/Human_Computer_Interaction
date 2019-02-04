namespace ParkingMeter
{
    partial class transactionComplete
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
            this.done = new System.Windows.Forms.Button();
            this.promotions = new System.Windows.Forms.Button();
            this.smsReminder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketInfo = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.dateAndTime1 = new ParkingMeter.dateAndTime();
            this.smsReminder1 = new ParkingMeter.smsReminder();
            this.promotions1 = new ParkingMeter.promotions();
            this.SuspendLayout();
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.done.FlatAppearance.BorderSize = 0;
            this.done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.ForeColor = System.Drawing.Color.White;
            this.done.Location = new System.Drawing.Point(491, 411);
            this.done.Margin = new System.Windows.Forms.Padding(4);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(163, 69);
            this.done.TabIndex = 1;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // promotions
            // 
            this.promotions.BackColor = System.Drawing.Color.Crimson;
            this.promotions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.promotions.FlatAppearance.BorderSize = 0;
            this.promotions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.promotions.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promotions.ForeColor = System.Drawing.Color.White;
            this.promotions.Location = new System.Drawing.Point(683, 411);
            this.promotions.Margin = new System.Windows.Forms.Padding(4);
            this.promotions.Name = "promotions";
            this.promotions.Size = new System.Drawing.Size(455, 69);
            this.promotions.TabIndex = 2;
            this.promotions.Text = "Find Good Deals Nearby";
            this.promotions.UseVisualStyleBackColor = false;
            this.promotions.Click += new System.EventHandler(this.promotions_Click);
            // 
            // smsReminder
            // 
            this.smsReminder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.smsReminder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smsReminder.FlatAppearance.BorderSize = 0;
            this.smsReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smsReminder.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smsReminder.ForeColor = System.Drawing.Color.White;
            this.smsReminder.Location = new System.Drawing.Point(15, 411);
            this.smsReminder.Margin = new System.Windows.Forms.Padding(4);
            this.smsReminder.Name = "smsReminder";
            this.smsReminder.Size = new System.Drawing.Size(439, 69);
            this.smsReminder.TabIndex = 3;
            this.smsReminder.Text = "Send SMS Reminder";
            this.smsReminder.UseVisualStyleBackColor = false;
            this.smsReminder.Click += new System.EventHandler(this.smsReminder_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(213, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(711, 140);
            this.label2.TabIndex = 5;
            this.label2.Text = "Transaction Completed!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ticketInfo
            // 
            this.ticketInfo.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketInfo.ForeColor = System.Drawing.Color.Black;
            this.ticketInfo.Location = new System.Drawing.Point(199, 171);
            this.ticketInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ticketInfo.Name = "ticketInfo";
            this.ticketInfo.Size = new System.Drawing.Size(693, 201);
            this.ticketInfo.TabIndex = 6;
            this.ticketInfo.Text = "Printing Ticket...";
            this.ticketInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(15, 4);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 17);
            this.time.TabIndex = 7;
            this.time.Visible = false;
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
            // smsReminder1
            // 
            this.smsReminder1.BackColor = System.Drawing.Color.SlateBlue;
            this.smsReminder1.Location = new System.Drawing.Point(0, 0);
            this.smsReminder1.Margin = new System.Windows.Forms.Padding(5);
            this.smsReminder1.Name = "smsReminder1";
            this.smsReminder1.Size = new System.Drawing.Size(1157, 510);
            this.smsReminder1.TabIndex = 0;
            // 
            // promotions1
            // 
            this.promotions1.BackColor = System.Drawing.Color.SlateBlue;
            this.promotions1.Location = new System.Drawing.Point(0, 0);
            this.promotions1.Name = "promotions1";
            this.promotions1.Size = new System.Drawing.Size(1157, 510);
            this.promotions1.TabIndex = 8;
            // 
            // transactionComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.time);
            this.Controls.Add(this.ticketInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.smsReminder);
            this.Controls.Add(this.promotions);
            this.Controls.Add(this.done);
            this.Controls.Add(this.dateAndTime1);
            this.Controls.Add(this.smsReminder1);
            this.Controls.Add(this.promotions1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "transactionComplete";
            this.Size = new System.Drawing.Size(1157, 510);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dateAndTime dateAndTime1;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button promotions;
        private System.Windows.Forms.Button smsReminder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ticketInfo;
        private smsReminder smsReminder1;
        private System.Windows.Forms.Label time;
        private promotions promotions1;
    }
}
