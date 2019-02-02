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
    public partial class theEnd : UserControl
    {
        public theEnd()
        {
            InitializeComponent();
            smsReminder1.Hide();
        }

        private void smsReminder_Click(object sender, EventArgs e)
        {
            smsReminder1.Show();
            smsReminder1.BringToFront();
        }

        private void done_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
