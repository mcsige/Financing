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
    public partial class Form1 : Form
    {
    	
    	private DBhelper helper;
        public Form1()
        {
            InitializeComponent();
            helper = new DBhelper();
            label4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        	
        	this.Visible = false;
            Form4 form4 = new Form4(this);
            form4.Show();
//            if(helper.onLogin(textBox1.Text,textBox2.Text)){
//        		this.Visible = false;
//	            Form4 form4 = new Form4(this);
//	            form4.Show();
//            }
//            else{
//            	label4.Text = "用户名或密码错误";
//            	label4.Visible = true;
//            }
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            this.Location = new Point(500,200);
        }
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
    }
}
