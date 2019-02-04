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
    public partial class refundEnd : UserControl
    {
        public refundEnd()
        {
            InitializeComponent();
        }

        private void done_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
