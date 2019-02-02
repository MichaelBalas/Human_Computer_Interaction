namespace ParkingMeter
{
    partial class setParkTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setParkTime));
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.countdown = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.hours = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.decreaseHours = new System.Windows.Forms.Button();
            this.toggleAmPm = new System.Windows.Forms.Button();
            this.increaseMinutes = new System.Windows.Forms.Button();
            this.decreaseMinutes = new System.Windows.Forms.Button();
            this.increaseHours = new System.Windows.Forms.Button();
            this.dateAndTime1 = new ParkingMeter.dateAndTime();
            this.paymentMethod = new ParkingMeter.paymentMethod();
            this.todayOrTmrw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(-1, 0);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 75);
            this.backButton.TabIndex = 6;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 34.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 91);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parking Until...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 34.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(837, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 91);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Roboto", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(799, 159);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(292, 91);
            this.price.TabIndex = 9;
            this.price.Text = "$0.00";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(877, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 66);
            this.label4.TabIndex = 10;
            this.label4.Text = "for";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countdown
            // 
            this.countdown.Font = new System.Drawing.Font("Roboto", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown.Location = new System.Drawing.Point(816, 326);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(267, 126);
            this.countdown.TabIndex = 11;
            this.countdown.Text = "3 hours and 45 minutes";
            this.countdown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.DarkGreen;
            this.payButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payButton.FlatAppearance.BorderSize = 0;
            this.payButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payButton.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.ForeColor = System.Drawing.Color.White;
            this.payButton.Location = new System.Drawing.Point(512, 401);
            this.payButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(152, 87);
            this.payButton.TabIndex = 12;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // hours
            // 
            this.hours.BackColor = System.Drawing.Color.LightSteelBlue;
            this.hours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hours.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.Location = new System.Drawing.Point(19, 229);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(151, 123);
            this.hours.TabIndex = 13;
            this.hours.Text = "06";
            this.hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Roboto", 55.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 112);
            this.label7.TabIndex = 14;
            this.label7.Text = ":";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minutes
            // 
            this.minutes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.minutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minutes.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.Location = new System.Drawing.Point(252, 229);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(167, 123);
            this.minutes.TabIndex = 15;
            this.minutes.Text = "00";
            this.minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decreaseHours
            // 
            this.decreaseHours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decreaseHours.FlatAppearance.BorderSize = 0;
            this.decreaseHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decreaseHours.Image = ((System.Drawing.Image)(resources.GetObject("decreaseHours.Image")));
            this.decreaseHours.Location = new System.Drawing.Point(56, 358);
            this.decreaseHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decreaseHours.Name = "decreaseHours";
            this.decreaseHours.Size = new System.Drawing.Size(60, 58);
            this.decreaseHours.TabIndex = 17;
            this.decreaseHours.UseVisualStyleBackColor = true;
            this.decreaseHours.Click += new System.EventHandler(this.decreaseHours_Click);
            // 
            // toggleAmPm
            // 
            this.toggleAmPm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toggleAmPm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleAmPm.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.toggleAmPm.FlatAppearance.BorderSize = 7;
            this.toggleAmPm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleAmPm.Font = new System.Drawing.Font("Roboto", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleAmPm.Location = new System.Drawing.Point(443, 229);
            this.toggleAmPm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toggleAmPm.Name = "toggleAmPm";
            this.toggleAmPm.Size = new System.Drawing.Size(192, 123);
            this.toggleAmPm.TabIndex = 18;
            this.toggleAmPm.Text = "AM";
            this.toggleAmPm.UseVisualStyleBackColor = false;
            this.toggleAmPm.Click += new System.EventHandler(this.toggleAmPm_Click);
            // 
            // increaseMinutes
            // 
            this.increaseMinutes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.increaseMinutes.FlatAppearance.BorderSize = 0;
            this.increaseMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseMinutes.Image = ((System.Drawing.Image)(resources.GetObject("increaseMinutes.Image")));
            this.increaseMinutes.Location = new System.Drawing.Point(309, 167);
            this.increaseMinutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.increaseMinutes.Name = "increaseMinutes";
            this.increaseMinutes.Size = new System.Drawing.Size(60, 55);
            this.increaseMinutes.TabIndex = 19;
            this.increaseMinutes.UseVisualStyleBackColor = true;
            this.increaseMinutes.Click += new System.EventHandler(this.increaseMinutes_Click);
            // 
            // decreaseMinutes
            // 
            this.decreaseMinutes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decreaseMinutes.FlatAppearance.BorderSize = 0;
            this.decreaseMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decreaseMinutes.Image = ((System.Drawing.Image)(resources.GetObject("decreaseMinutes.Image")));
            this.decreaseMinutes.Location = new System.Drawing.Point(309, 358);
            this.decreaseMinutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decreaseMinutes.Name = "decreaseMinutes";
            this.decreaseMinutes.Size = new System.Drawing.Size(60, 58);
            this.decreaseMinutes.TabIndex = 20;
            this.decreaseMinutes.UseVisualStyleBackColor = true;
            this.decreaseMinutes.Click += new System.EventHandler(this.decreaseMinutes_Click);
            // 
            // increaseHours
            // 
            this.increaseHours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.increaseHours.FlatAppearance.BorderSize = 0;
            this.increaseHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseHours.Image = ((System.Drawing.Image)(resources.GetObject("increaseHours.Image")));
            this.increaseHours.Location = new System.Drawing.Point(56, 167);
            this.increaseHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.increaseHours.Name = "increaseHours";
            this.increaseHours.Size = new System.Drawing.Size(60, 55);
            this.increaseHours.TabIndex = 21;
            this.increaseHours.UseVisualStyleBackColor = true;
            this.increaseHours.Click += new System.EventHandler(this.increaseHours_Click);
            // 
            // dateAndTime1
            // 
            this.dateAndTime1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dateAndTime1.Location = new System.Drawing.Point(741, -4);
            this.dateAndTime1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateAndTime1.Name = "dateAndTime1";
            this.dateAndTime1.Size = new System.Drawing.Size(416, 75);
            this.dateAndTime1.TabIndex = 5;
            // 
            // paymentMethod
            // 
            this.paymentMethod.BackColor = System.Drawing.Color.SlateBlue;
            this.paymentMethod.Location = new System.Drawing.Point(0, 0);
            this.paymentMethod.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.Size = new System.Drawing.Size(1157, 510);
            this.paymentMethod.TabIndex = 22;
            // 
            // todayOrTmrw
            // 
            this.todayOrTmrw.Font = new System.Drawing.Font("Roboto", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayOrTmrw.Location = new System.Drawing.Point(11, 423);
            this.todayOrTmrw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayOrTmrw.Name = "todayOrTmrw";
            this.todayOrTmrw.Size = new System.Drawing.Size(444, 65);
            this.todayOrTmrw.TabIndex = 23;
            this.todayOrTmrw.Text = "November 25, 2018";
            this.todayOrTmrw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setParkTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.todayOrTmrw);
            this.Controls.Add(this.increaseHours);
            this.Controls.Add(this.decreaseMinutes);
            this.Controls.Add(this.increaseMinutes);
            this.Controls.Add(this.toggleAmPm);
            this.Controls.Add(this.decreaseHours);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dateAndTime1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentMethod);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "setParkTime";
            this.Size = new System.Drawing.Size(1157, 510);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Button decreaseHours;
        private System.Windows.Forms.Button toggleAmPm;
        private System.Windows.Forms.Button increaseMinutes;
        private System.Windows.Forms.Button decreaseMinutes;
        private System.Windows.Forms.Button increaseHours;
        private dateAndTime dateAndTime1;
        private paymentMethod paymentMethod;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label todayOrTmrw;
    }
}
