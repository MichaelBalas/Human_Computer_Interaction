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
    public partial class refundScreen : UserControl
    {
        public refundScreen()
        {
            InitializeComponent();
            refundCash.Hide();
            refundCard.Hide();
        }

        private void cashBack_Click(object sender, EventArgs e)
        {
            refundCash.Show();
            refundCash.BringToFront();
            refundCash.foo(redeemableFunds.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refundCard.Show();
            refundCard.BringToFront();
        }

        public void insertedCard(bool inserted)
        {
            refundCard.insertedCard(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (customMsgBox.Show("Are you sure you want to cancel? Your ticket will be returned from the same slot.", "Refund Ticket?", "Yes", "", "No") == DialogResult.Yes)
            {
                if (customMsgBox.Show("\"The ticket returns from the slot.\"", "Refund Ticket?", "", "Collect Ticket", "") == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
        }
    }
}
