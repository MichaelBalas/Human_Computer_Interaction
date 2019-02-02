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
    public partial class enterRefund : UserControl
    {
        public enterRefund()
        {
            InitializeComponent();
            refundScreen.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void insertTicket()
        {
            if (this.Visible == true)
            {
                refundScreen.Show();
                refundScreen.BringToFront();
            }
        }
        public void insertedCard(bool inserted)
        {
            refundScreen.insertedCard(true);
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
