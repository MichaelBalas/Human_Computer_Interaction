namespace ParkingMeter
{
    partial class refundEnd
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
            this.label1 = new System.Windows.Forms.Label();
            this.done = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(0, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1154, 222);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your refund has been applied.\r\nHave a nice day.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.done.FlatAppearance.BorderSize = 0;
            this.done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.ForeColor = System.Drawing.Color.White;
            this.done.Location = new System.Drawing.Point(488, 416);
            this.done.Margin = new System.Windows.Forms.Padding(4);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(163, 69);
            this.done.TabIndex = 10;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // refundEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.done);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateAndTime1);
            this.Name = "refundEnd";
            this.Size = new System.Drawing.Size(1157, 510);
            this.ResumeLayout(false);

        }

        #endregion

        private dateAndTime dateAndTime1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button done;
    }
}
