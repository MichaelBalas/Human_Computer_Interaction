using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingMeter
{
    public partial class customMsgBox : Form
    {
        public customMsgBox()
        {
            InitializeComponent();
        }
        static customMsgBox MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string left, string middle, string right)
        {
            MsgBox = new customMsgBox();
            MsgBox.Location = new Point(550, 150);
            MsgBox.label1.Text = Text;
            MsgBox.button3.Text = middle;
            if (MsgBox.button3.Text != "") { MsgBox.button1.Visible = false; MsgBox.button2.Visible = false; }
            MsgBox.button1.Text = left;
            MsgBox.button2.Text = right;
            if (MsgBox.button1.Text != "" || MsgBox.button1.Text != "") { MsgBox.button3.Visible = false; }
            MsgBox.Text = Caption;
            result = DialogResult.No;
            MsgBox.ShowDialog();
            return result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            MsgBox.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            MsgBox.Close();
        }
    }
}
