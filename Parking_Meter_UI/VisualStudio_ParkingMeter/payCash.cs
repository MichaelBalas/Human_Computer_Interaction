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
    public partial class payCash : UserControl
    {
        public payCash()
        {
            InitializeComponent();
            transactionComplete.Hide();
        }

        public void getTimePaidFor(string hour, string minute, string meridium)
        {
            transactionComplete.getTimePaidFor(hour, minute, meridium);
            until.Text = hour + ":" + minute + " " + meridium;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            String change = originalPrice().ToString();
            if (customMsgBox.Show("Are you sure you want to cancel the payment?", "Cancelling Payment...", "Yes", "", "No") == DialogResult.Yes)
            {
                if (Convert.ToDouble(change) > 0)
                {
                    customMsgBox.Show("\"You recieve $" + change + " in change.\"", "Collect Change", "", "Collect change.", "");
                    double temp = Convert.ToDouble(original.Tag);
                    remainingPrice.Text = "$" + temp.ToString("n");
                } else
                {
                    customMsgBox.Show("You recieve no change.", "Cancelling Payment...", "", "OK", "");
                }
                this.Hide();
            }
        }
        public Double originalPrice()
        {
            return Convert.ToDouble(original.Tag) - Convert.ToDouble(remainingPrice.Text.Trim('$'));
        }
        public void updatePriceToPay(double totalDif)
        {
            transactionComplete.updatePriceToPay(totalDif);
            remainingPrice.Text = "$" + totalDif.ToString("n");
            original.Tag = totalDif.ToString();
        }

        public void minusCash(double amt)
        {
            double remaining = Convert.ToDouble(remainingPrice.Text.Trim('$')) - amt;
            if (remaining < 0)
            {
                remaining = 0;
                giveChange(amt - Convert.ToDouble(remainingPrice.Text.Trim('$')));
            } else if (remaining == 0)
            {
                remainingPrice.Text = "$" + remaining.ToString("n");
                if (customMsgBox.Show("Transaction Completed.", "Transaction Completed", "", "OK", "") == DialogResult.OK)
                {
                    transactionComplete.Show();
                    transactionComplete.BringToFront();
                    transactionComplete.foo();
                }
            }
            remainingPrice.Text = "$" + remaining.ToString("n");

        }
        public void giveChange(Double change)
        {
            if (change >= 0)
            {
                if (customMsgBox.Show("You recieve $" + change.ToString("n") + " in change. You collect it.", "Transaction Completed", "", "OK", "") == DialogResult.OK)
                {
                    transactionComplete.Show();
                    transactionComplete.BringToFront();
                    transactionComplete.foo();
                }
            }
        }
        public void expireTicket(string expirey)
        {
            transactionComplete.expireTicket(expirey);
        }
    }
}
