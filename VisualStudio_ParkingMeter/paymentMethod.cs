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
    public partial class paymentMethod : UserControl
    {
        public paymentMethod()
        {
            InitializeComponent();
            payCash.Hide();
            payCard.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void payByCash_Click(object sender, EventArgs e)
        {
            payCash.Show();
            payCash.BringToFront();
        }

        private void payByCard_Click(object sender, EventArgs e)
        {
            payCard.Show();
            payCard.BringToFront();
        }
        public void updatePriceToPay(Double totalDif)
        {
            payCash.updatePriceToPay(totalDif);
            payCard.updatePriceToPay(totalDif);
        }

        public void minusCash(double amt)
        {
            payCash.minusCash(amt);
        }

        public void getTimePaidFor(string hour, string minute, string meridium)
        {
            payCash.getTimePaidFor(hour, minute, meridium);
            payCard.getTimePaidFor(hour, minute, meridium);
        }

        public void payWithCard(bool paid)
        {
            if (paid) { payCard.paidYet(); }
        }
        public void insertedCard(bool inserted)
        {
            if (inserted) { payCard.insertedYet();  }
        }
        public void expireTicket(string expirey)
        {
            payCash.expireTicket(expirey);
            payCard.expireTicket(expirey);
        }
    }
}
