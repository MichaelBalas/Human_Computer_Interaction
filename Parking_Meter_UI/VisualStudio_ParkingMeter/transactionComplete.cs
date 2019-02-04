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
    public partial class transactionComplete : UserControl
    {
        public transactionComplete()
        {
            InitializeComponent();
            smsReminder1.Hide();
            promotions1.Hide();
        }

        public void foo()
        {
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            } while (Tthen.AddSeconds(3) > DateTime.Now);
            
            bar();
        }

        public void getTimePaidFor(string hour, string minute, string meridium)
        {
            if (hour.StartsWith("0")) { hour = hour.Substring(1); }
            time.Tag = hour + ":" + minute + " " + meridium;
        }

        public void updatePriceToPay(double totalDif)
        {
            label2.Tag = "$" + totalDif.ToString("n");
        }

        public void expireTicket(string expirey)
        {
            ticketInfo.Tag = expirey;
        }

        public void bar()
        {
            customMsgBox.Show("Insert this side up for refund" + "\n" + "\n" + "Purchase Date/Time: " + DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToShortDateString() + 
                "\n" + "Expiration Date/Time: " + ticketInfo.Tag + "\n" + "Total Paid: " + label2.Tag, "Transaction Completed", "", "Take Ticket", "");
            updateText();
        }
        public void updateText()
        {
            ticketInfo.Text = "Take ticket, place inside vehicle face-up on dashboard, curbside.";
        }

        private void done_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void smsReminder_Click(object sender, EventArgs e)
        {
            smsReminder1.Show();
            smsReminder1.BringToFront();
        }

        private void promotions_Click(object sender, EventArgs e)
        {
            promotions1.Show();
            promotions1.BringToFront();
        }
    }
}
