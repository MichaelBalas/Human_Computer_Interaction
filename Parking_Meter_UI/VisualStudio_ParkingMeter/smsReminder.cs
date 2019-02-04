using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingMeter
{
    public partial class smsReminder : UserControl
    {
        public smsReminder()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (pin3.Text.Length == 8)
            {
                if (customMsgBox.Show("You will recieve a text message notification " + minutes.Text + " minutes before your parking expires. Thank you.", "Setup SMS", "", "Ok", "") == DialogResult.OK)
                {
                    okButton.BackColor = Color.Black;
                    okButton.ForeColor = Color.White;
                    okButton.FlatAppearance.BorderColor = Color.White;
                    okButton.Cursor = Cursors.Default;
                    pin1.Text = "";
                    pin1.BackColor = Color.DimGray;
                    pin2.Text = "";
                    pin2.BackColor = Color.Black;
                    pin3.Text = "";
                    pin3.BackColor = Color.Black;
                    minutes.Text = "10";
                    this.Hide();
                }
            }
            else
            {
                // do nothing
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (pin3.Text.Length > 0)
            {
                if (pin3.Text.Length == 8)
                {
                    pin3.BackColor = Color.DimGray;
                    okButton.BackColor = Color.Black;
                    okButton.ForeColor = Color.White;
                    okButton.FlatAppearance.BorderColor = Color.White;
                    okButton.Cursor = Cursors.Default;
                }
                pin3.Text = pin3.Text.Remove(pin3.Text.Length - 2);
                if (pin3.Text.Length < 0) { pin3.BackColor = Color.Black; pin2.BackColor = Color.DimGray; }
            }
            else if (pin2.Text.Length > 0)
            {
                if (pin2.Text.Length == 6) { pin3.BackColor = Color.Black; pin2.BackColor = Color.DimGray; }
                pin2.Text = pin2.Text.Remove(pin2.Text.Length - 2);
                if (pin2.Text.Length < 0) { pin2.BackColor = Color.Black; pin1.BackColor = Color.DimGray; }
            }
            else if (pin1.Text.Length > 0)
            {
                if (pin1.Text.Length == 6) { pin2.BackColor = Color.Black; pin1.BackColor = Color.DimGray; }
                pin1.Text = pin1.Text.Remove(pin1.Text.Length - 2);
            }
            else
            {
                // do nothing
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (customMsgBox.Show("Are you sure you don't want to recieve a text message reminder before your parking expires?", "Cancel SMS?", "Yes", "", "No") == DialogResult.Yes)
            {
                pin1.Text = "";
                pin1.BackColor = Color.DimGray;
                pin2.Text = "";
                pin2.BackColor = Color.Black;
                pin3.Text = "";
                pin3.BackColor = Color.Black;
                okButton.BackColor = Color.Black;
                okButton.ForeColor = Color.White;
                okButton.FlatAppearance.BorderColor = Color.White;
                okButton.Cursor = Cursors.Default;
                minutes.Text = "10";
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pin1.Text.Length < 6)
            {
                pin1.Text += " 1";
                if (pin1.Text.Length == 6) { pin1.BackColor = Color.Black; pin2.BackColor = Color.DimGray; }
            }
            else if (pin2.Text.Length < 6)
            {
                pin2.Text += " 1";
                if (pin2.Text.Length == 6) { pin2.BackColor = Color.Black; pin3.BackColor = Color.DimGray; }
            }
            else if (pin3.Text.Length < 8)
            {
                pin3.Text += " 1";
                if (pin3.Text.Length == 8)
                {
                    pin3.BackColor = Color.Black;
                    okButton.BackColor = Color.MediumSeaGreen;
                    okButton.ForeColor = Color.Black;
                    okButton.FlatAppearance.BorderColor = Color.Black;
                    okButton.Cursor = Cursors.Hand;
                }
            }
            else
            {
                // do nothing
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pin1.Text.Length < 6)
            {
                pin1.Text += " 2";
                if (pin1.Text.Length == 6) { pin1.BackColor = Color.Black; pin2.BackColor = Color.DimGray; }
            }
            else if (pin2.Text.Length < 6)
            {
                pin2.Text += " 2";
                if (pin2.Text.Length == 6) { pin2.BackColor = Color.Black; pin3.BackColor = Color.DimGray; }
            }
            else if (pin3.Text.Length < 8)
            {
                pin3.Text += " 2";
                if (pin3.Text.Length == 8)
                {
                    pin3.BackColor = Color.Black;
                    okButton.BackColor = Color.MediumSeaGreen;
                    okButton.ForeColor = Color.Black;
                    okButton.FlatAppearance.BorderColor = Color.Black;
                    okButton.Cursor = Cursors.Hand;
                }
            }
            else
            {
                // do nothing
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pin1.Text.Length < 6)
            {
                pin1.Text += " 3";
                if (pin1.Text.Length == 6) { pin1.BackColor = Color.Black; pin2.BackColor = Color.DimGray; }
            }
            else if (pin2.Text.Length < 6)
            {
                pin2.Text += " 3";
                if (pin2.Text.Length == 6) { pin2.BackColor = Color.Black; pin3.BackColor = Color.DimGray; }
            }
            else if (pin3.Text.Length < 8)
            {
                pin3.Text += " 3";
                if (pin3.Text.Length == 8)
                {
                    pin3.BackColor = Color.Black;
                    okButton.BackColor = Color.MediumSeaGreen;
                    okButton.ForeColor = Color.Black;
                    okButton.FlatAppearance.BorderColor = Color.Black;
                    okButton.Cursor = Cursors.Hand;
                }
            }
            else
            {
                // do nothing
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pin1.Text.Length < 6)
            {
                pin1.Text += " 4";
                if (pin1.Text.Length == 6) { pin1.BackColor = Color.Black; pin2.BackColor = Color.DimGray; }
            }
            else if (pin2.Text.Length < 6)
            {
                pin2.Text += " 4";
                if (pin2.Text.Length == 6) { pin2.BackColor = Color.Black; pin3.BackColor = Color.DimGray; }
            }
            else if (pin3.Text.Length < 8)
            {
                pin3.Text += " 4";
                if (pin3.Text.Length == 8)
                {
                    pin3.BackColor = Color.Black;
                    okButton.BackColor = Color.MediumSeaGreen;
                    okButton.ForeColor = Color.Black;
                    okButton.FlatAppearance.BorderColor = Color.Black;
                    okButton.Cursor = Cursors.Hand;
                }
            }
            else
            {
                // do nothing
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pin1.Text.Length < 6)
            {
                pin1.Text += " 5";
                if (pin1.Text.Length == 6) { pin1.BackColor = Color.Black; pin2.BackColor = Color.DimGray; }
            }
            else if (pin2.Text.Length < 6)
            {
                pin2.Text += " 5";
                if (pin2.Text.Length == 6) { pin2.BackColor = Color.Black; pin3.BackColor = Color.DimGray; }
            }
            else if (pin3.Text.Length < 8)
            {
                pin3.Text += " 5";
                if (pin3.Text.Length == 8)
                {
                    pin3.BackColor = Color.Black;
                    okButton.BackColor = Color.MediumSeaGreen;
                    okButton.ForeColor = Color.Black;
                    okButton.FlatAppearance.BorderColor = Color.Black;
                    okButton.Cursor = Cursors.Hand;
                }
            }
            else
            {
                // do nothing
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pin1.Text.Length < 6)
            {
                pin1.Text += " 6";
                if (pin1.Text.Length == 6) { pin1.BackColor = Color.Black; pin2.BackColor = Color.DimGray; }
            }
            else if (pin2.Text.Length < 6)
            {
                pin2.Text += " 6";
                if (pin2.Text.Length == 6) { pin2.BackColor = Color.Black; pin3.BackColor = Color.DimGray; }
            }
            else if (pin3.Text.Length < 8)
            {
                pin3.Text += " 6";
                if (pin3.Text.Length == 8)
                {
                    pin3.BackColor = Color.Black;
                    okButton.BackColor = Color.MediumSeaGreen;
                    okButton.ForeColor = Color.Black;
                    okButton.FlatAppearance.BorderColor = Color.Black;
                    okButton.Cursor = Cursors.Hand;
                }
            }
            else
            {
                // do nothing
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pin1.Text.Length < 6)
            {
                pin1.Text += " 7";
                if (pin1.Text.Length == 6) { pin1.BackColor = Color.Black; pin2.BackColor = Color.DimGray; }
            }
            else if (pin2.Text.Length < 6)
            {
                pin2.Text += " 7";
                if (pin2.Text.Length == 6) { pin2.BackColor = Color.Black; pin3.BackColor = Color.DimGray; }
            }
            else if (pin3.Text.Length < 8)
            {
                pin3.Text += " 7";
                if (pin3.Text.Length == 8)
                {
                    pin3.BackColor = Color.Black;
                    okButton.BackColor = Color.MediumSeaGreen;
                    okButton.ForeColor = Color.Black;
                    okButton.FlatAppearance.BorderColor = Color.Black;
                    okButton.Cursor = Cursors.Hand;
                }
            }
            else
            {
                // do nothing
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (pin1.Text.Length < 6)
            {
                pin1.Text += " 8";
                if (pin1.Text.Length == 6) { pin1.BackColor = Color.Black; pin2.BackColor = Color.DimGray; }
            }
            else if (pin2.Text.Length < 6)
            {
                pin2.Text += " 8";
                if (pin2.Text.Length == 6) { pin2.BackColor = Color.Black; pin3.BackColor = Color.DimGray; }
            }
            else if (pin3.Text.Length < 8)
            {
                pin3.Text += " 8";
                if (pin3.Text.Length == 8)
                {
                    pin3.BackColor = Color.Black;
                    okButton.BackColor = Color.MediumSeaGreen;
                    okButton.ForeColor = Color.Black;
                    okButton.FlatAppearance.BorderColor = Color.Black;
                    okButton.Cursor = Cursors.Hand;
                }
            }
            else
            {
                // do nothing
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (pin1.Text.Length < 6)
            {
                pin1.Text += " 9";
                if (pin1.Text.Length == 6) { pin1.BackColor = Color.Black; pin2.BackColor = Color.DimGray; }
            }
            else if (pin2.Text.Length < 6)
            {
                pin2.Text += " 9";
                if (pin2.Text.Length == 6) { pin2.BackColor = Color.Black; pin3.BackColor = Color.DimGray; }
            }
            else if (pin3.Text.Length < 8)
            {
                pin3.Text += " 9";
                if (pin3.Text.Length == 8)
                {
                    pin3.BackColor = Color.Black;
                    okButton.BackColor = Color.MediumSeaGreen;
                    okButton.ForeColor = Color.Black;
                    okButton.FlatAppearance.BorderColor = Color.Black;
                    okButton.Cursor = Cursors.Hand;
                }
            }
            else
            {
                // do nothing
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (pin1.Text.Length < 6)
            {
                pin1.Text += " 0";
                if (pin1.Text.Length == 6) { pin1.BackColor = Color.Black; pin2.BackColor = Color.DimGray; }
            }
            else if (pin2.Text.Length < 6)
            {
                pin2.Text += " 0";
                if (pin2.Text.Length == 6) { pin2.BackColor = Color.Black; pin3.BackColor = Color.DimGray; }
            }
            else if (pin3.Text.Length < 8)
            {
                pin3.Text += " 0";
                if (pin3.Text.Length == 8)
                {
                    pin3.BackColor = Color.Black;
                    okButton.BackColor = Color.MediumSeaGreen;
                    okButton.ForeColor = Color.Black;
                    okButton.FlatAppearance.BorderColor = Color.Black;
                    okButton.Cursor = Cursors.Hand;
                }
            }
            else
            {
                // do nothing
            }
        }

        private void increaseMinutes_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(minutes.Text);
            min += 10;
            if (min > 60) { min = 10; }
            minutes.Text = min.ToString();
        }

        private void decreaseMinutes_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(minutes.Text);
            min -= 10;
            if (min < 10) { min = 60;  }
            minutes.Text = min.ToString();
        }
    }
}
