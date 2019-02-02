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
    public partial class pinPad : UserControl
    {
        public pinPad()
        {
            InitializeComponent();
            transactionComplete.Hide();
            refundEnd.Hide();
        }

        public void moneyBack(bool mBack)
        {
            pin.Tag = mBack.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (pin.Text == "   *       *       *       *")
            {
                if (pin.Tag == true.ToString())
                {
                    refundEnd.Show();
                    refundEnd.BringToFront();
                } else
                {
                    transactionComplete.Show();
                    transactionComplete.BringToFront();
                    transactionComplete.foo();
                }
            } else
            {
                // do nothing
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            string msg;
            if (pin.Tag == true.ToString())
            {
                msg = "Are you sure you want to cancel the refund via card insertion?";
            } else
            {
                msg = "Are you sure you want to cancel the payment?";
            }
            if (customMsgBox.Show(msg, "Cancel Payment?", "Yes", "", "No") == DialogResult.Yes)
            {
                pin.Text = "";
                okButton.BackColor = Color.Black;
                okButton.ForeColor = Color.White;
                okButton.FlatAppearance.BorderColor = Color.White;
                okButton.Cursor = Cursors.Default;
                this.Hide();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (pin.Text.Split('*').Length - 1 == 4)
            {
                pin.Text = "   *       *       *    ";
                okButton.BackColor = Color.Black;
                okButton.ForeColor = Color.White;
                okButton.FlatAppearance.BorderColor = Color.White;
                okButton.Cursor = Cursors.Default;
            }
            else if (pin.Text.Split('*').Length - 1 == 3)
            {
                pin.Text = "   *       *    ";
            } else if (pin.Text.Split('*').Length - 1 == 2)
            {
                pin.Text = "   *    ";
            } else if (pin.Text.Split('*').Length - 1 == 1)
            {
                pin.Text = "";
            } else
            {
                // do nothing
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pin.Text == "   *       *       *       *") 
            {
                // do nothing
            } else if (pin.Text == "   *       *       *    ")
            {
                pin.Text += "   *";
                okButton.BackColor = Color.MediumSeaGreen;
                okButton.ForeColor = Color.Black;
                okButton.FlatAppearance.BorderColor = Color.Black;
                okButton.Cursor = Cursors.Hand;
            } else
            {
                pin.Text += "   *    ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pin.Text == "   *       *       *       *    ")
            {
                // do nothing
            }
            else if (pin.Text == "   *       *       *    ")
            {
                pin.Text += "   *";
                okButton.BackColor = Color.MediumSeaGreen;
                okButton.ForeColor = Color.Black;
                okButton.FlatAppearance.BorderColor = Color.Black;
                okButton.Cursor = Cursors.Hand;
            }
            else
            {
                pin.Text += "   *    ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pin.Text == "   *       *       *       *    ")
            {
                // do nothing
            }
            else if (pin.Text == "   *       *       *    ")
            {
                pin.Text += "   *";
                okButton.BackColor = Color.MediumSeaGreen;
                okButton.ForeColor = Color.Black;
                okButton.FlatAppearance.BorderColor = Color.Black;
                okButton.Cursor = Cursors.Hand;
            }
            else
            {
                pin.Text += "   *    ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pin.Text == "   *       *       *       *    ")
            {
                // do nothing
            }
            else if (pin.Text == "   *       *       *    ")
            {
                pin.Text += "   *";
                okButton.BackColor = Color.MediumSeaGreen;
                okButton.ForeColor = Color.Black;
                okButton.FlatAppearance.BorderColor = Color.Black;
                okButton.Cursor = Cursors.Hand;
            }
            else
            {
                pin.Text += "   *    ";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pin.Text == "   *       *       *       *    ")
            {
                // do nothing
            }
            else if (pin.Text == "   *       *       *    ")
            {
                pin.Text += "   *";
                okButton.BackColor = Color.MediumSeaGreen;
                okButton.ForeColor = Color.Black;
                okButton.FlatAppearance.BorderColor = Color.Black;
                okButton.Cursor = Cursors.Hand;
            }
            else
            {
                pin.Text += "   *    ";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pin.Text == "   *       *       *       *    ")
            {
                // do nothing
            }
            else if (pin.Text == "   *       *       *    ")
            {
                pin.Text += "   *";
                okButton.BackColor = Color.MediumSeaGreen;
                okButton.ForeColor = Color.Black;
                okButton.FlatAppearance.BorderColor = Color.Black;
                okButton.Cursor = Cursors.Hand;
            }
            else
            {
                pin.Text += "   *    ";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pin.Text == "   *       *       *       *    ")
            {
                // do nothing
            }
            else if (pin.Text == "   *       *       *    ")
            {
                pin.Text += "   *";
                okButton.BackColor = Color.MediumSeaGreen;
                okButton.ForeColor = Color.Black;
                okButton.FlatAppearance.BorderColor = Color.Black;
                okButton.Cursor = Cursors.Hand;
            }
            else
            {
                pin.Text += "   *    ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (pin.Text == "   *       *       *       *    ")
            {
                // do nothing
            }
            else if (pin.Text == "   *       *       *    ")
            {
                pin.Text += "   *";
                okButton.BackColor = Color.MediumSeaGreen;
                okButton.ForeColor = Color.Black;
                okButton.FlatAppearance.BorderColor = Color.Black;
                okButton.Cursor = Cursors.Hand;
            }
            else
            {
                pin.Text += "   *    ";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (pin.Text == "   *       *       *       *    ")
            {
                // do nothing
            }
            else if (pin.Text == "   *       *       *    ")
            {
                pin.Text += "   *";
                okButton.BackColor = Color.MediumSeaGreen;
                okButton.ForeColor = Color.Black;
                okButton.FlatAppearance.BorderColor = Color.Black;
                okButton.Cursor = Cursors.Hand;
            }
            else
            {
                pin.Text += "   *    ";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (pin.Text == "   *       *       *       *    ")
            {
                // do nothing
            }
            else if (pin.Text == "   *       *       *    ")
            {
                pin.Text += "   *";
                okButton.BackColor = Color.MediumSeaGreen;
                okButton.ForeColor = Color.Black;
                okButton.FlatAppearance.BorderColor = Color.Black;
                okButton.Cursor = Cursors.Hand;
            }
            else
            {
                pin.Text += "   *    ";
            }
        }
        public void getTimePaidFor(string hour, string minute, string meridium)
        {
            transactionComplete.getTimePaidFor(hour, minute, meridium);
        }
        public void updatePriceToPay(double totalDif)
        {
            transactionComplete.updatePriceToPay(totalDif);
        }
        public void expireTicket(string expirey)
        {
            transactionComplete.expireTicket(expirey);
        }
    }
}
