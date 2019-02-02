namespace ParkingMeter
{
    partial class theEnd
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
            this.dateAndTime1 = new ParkingMeter.dateAndTime();
            this.smsReminder = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketInfo = new System.Windows.Forms.Label();
            this.smsReminder1 = new ParkingMeter.smsReminder();
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
            // smsReminder
            // 
            this.smsReminder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.smsReminder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smsReminder.FlatAppearance.BorderSize = 0;
            this.smsReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smsReminder.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smsReminder.ForeColor = System.Drawing.Color.White;
            this.smsReminder.Location = new System.Drawing.Point(63, 413);
            this.smsReminder.Margin = new System.Windows.Forms.Padding(4);
            this.smsReminder.Name = "smsReminder";
            this.smsReminder.Size = new System.Drawing.Size(439, 69);
            this.smsReminder.TabIndex = 5;
            this.smsReminder.Text = "Send SMS Reminder";
            this.smsReminder.UseVisualStyleBackColor = false;
            this.smsReminder.Click += new System.EventHandler(this.smsReminder_Click);
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.done.FlatAppearance.BorderSize = 0;
            this.done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.ForeColor = System.Drawing.Color.White;
            this.done.Location = new System.Drawing.Point(539, 413);
            this.done.Margin = new System.Windows.Forms.Padding(4);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(163, 69);
            this.done.TabIndex = 4;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(224, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(711, 140);
            this.label2.TabIndex = 6;
            this.label2.Text = "Promotion Collected!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ticketInfo
            // 
            this.ticketInfo.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketInfo.ForeColor = System.Drawing.Color.Black;
            this.ticketInfo.Location = new System.Drawing.Point(227, 184);
            this.ticketInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ticketInfo.Name = "ticketInfo";
            this.ticketInfo.Size = new System.Drawing.Size(693, 201);
            this.ticketInfo.TabIndex = 7;
            this.ticketInfo.Text = "Offer only valid at printed store locations.";
            this.ticketInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smsReminder1
            // 
            this.smsReminder1.BackColor = System.Drawing.Color.SlateBlue;
            this.smsReminder1.Location = new System.Drawing.Point(0, 0);
            this.smsReminder1.Margin = new System.Windows.Forms.Padding(4);
            this.smsReminder1.Name = "smsReminder1";
            this.smsReminder1.Size = new System.Drawing.Size(1157, 510);
            this.smsReminder1.TabIndex = 8;
            // 
            // theEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.ticketInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.smsReminder);
            this.Controls.Add(this.done);
            this.Controls.Add(this.dateAndTime1);
            this.Controls.Add(this.smsReminder1);
            this.Name = "theEnd";
            this.Size = new System.Drawing.Size(1157, 510);
            this.ResumeLayout(false);

        }

        #endregion

        private dateAndTime dateAndTime1;
        private System.Windows.Forms.Button smsReminder;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ticketInfo;
        private smsReminder smsReminder1;
    }
}
