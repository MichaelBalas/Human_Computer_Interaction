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
    public partial class payCard : UserControl
    {
        public payCard()
        {
            InitializeComponent();
            transactionComplete.Hide();
            pinPad.Hide();
            bankAccount.Hide();
        }

        public void paidYet()
        {
            if (this.Visible == true)
            {
                transactionComplete.Show();
                transactionComplete.BringToFront();
                transactionComplete.foo();
            }
        }

        public void insertedYet()
        {
            if (this.Visible == true)
            {
                pinPad.Show();
                pinPad.BringToFront();
            }
        }

        public void getTimePaidFor(string hour, string minute, string meridium)
        {
            bankAccount.getTimePaidFor(hour, minute, meridium);
            pinPad.getTimePaidFor(hour, minute, meridium);
            transactionComplete.getTimePaidFor(hour, minute, meridium);
            double price = originalPrice();
            cardPayFeedback.Text = "Pay $" + price.ToString("n") + " for parking until " + hour + ":" + minute + " " + meridium;
        }

        public double originalPrice()
        {
            return Convert.ToDouble(original.Tag);
        }
        public void updatePriceToPay(double totalDif)
        {
            bankAccount.updatePriceToPay(totalDif);
            pinPad.updatePriceToPay(totalDif);
            transactionComplete.updatePriceToPay(totalDif);
            original.Tag = totalDif.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void accountNumber_Click(object sender, EventArgs e)
        {
            bankAccount.Show();
            bankAccount.BringToFront();
        }
        public void expireTicket(string expirey)
        {
            bankAccount.expireTicket(expirey);
            pinPad.expireTicket(expirey);
            transactionComplete.expireTicket(expirey);
        }
    }
}
