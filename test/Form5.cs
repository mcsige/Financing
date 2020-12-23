using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form5 : Form
    {
        private Form parent;

        public Form5(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
            timer1.Enabled = true;
            label9.Text = "勤俭节约是中华人民的传统美德！".PadRight(64);
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = label9.Text.Substring(1)+label9.Text[0].ToString();
        }
    }
}
