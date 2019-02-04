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
    public partial class promotionComplete : UserControl
    {
        public promotionComplete()
        {
            InitializeComponent();
            theEnd.Hide();
        }

        public void foo()
        {
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            } while (Tthen.AddSeconds(5) > DateTime.Now);

            bar();
        }

        public void bar()
        {
            customMsgBox.Show("\"The promotional offer has printed.\"", "Transaction Completed", "", "Take Promotion", "");
            theEnd.Show();
            theEnd.BringToFront();
        }
    }
}
