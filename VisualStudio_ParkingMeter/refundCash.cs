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
    public partial class refundCash : UserControl
    {
        public refundCash()
        {
            InitializeComponent();
            refundEnd.Hide();
        }

        public void foo(string refund)
        {
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            } while (Tthen.AddSeconds(4) > DateTime.Now);

            bar(refund);
        }

        public void bar(string refund)
        {
            if (customMsgBox.Show("\"" + refund + " drops into the change tray below.\"", "Transaction Completed", "", "Collect Refund", "") == DialogResult.OK)
            {
                refundEnd.Show();
                refundEnd.BringToFront();
            }
        }
    }
}
