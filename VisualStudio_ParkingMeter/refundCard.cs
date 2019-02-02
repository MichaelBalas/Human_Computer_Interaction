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
    public partial class refundCard : UserControl
    {
        public refundCard()
        {
            InitializeComponent();
            bankAccount.Hide();
            pinPad.Hide();
        }

        private void accountNumber_Click(object sender, EventArgs e)
        {
            moneyBack(true);
            bankAccount.Show();
            bankAccount.BringToFront();
        }

        public void insertedCard(bool inserted)
        {
            if (this.Visible == true && inserted == true)
            {
                moneyBack(true);
                pinPad.Show();
                pinPad.BringToFront();
            }
        }

        public void moneyBack(bool mBack)
        {
            pinPad.moneyBack(mBack);
            bankAccount.moneyBack(mBack);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
