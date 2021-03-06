﻿using System;
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
    public partial class Form3 : Form
    {

        private Form parent;
        private DBhelper helper;

        public Form3(Form parent)
        {
            this.parent = parent;
            helper = new DBhelper();
            InitializeComponent();
            label3.Visible = false;
            comboBox1.DataSource = helper.onKindQuery();
            comboBox1.ValueMember = "kid";
            comboBox1.DisplayMember = "kindName";
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Format("要添加的收支项目为{0}\n所属类别：{1}\n是{2}类型的项目"
        	                                  ,textBox1.Text,comboBox1.Text,radioButton1.Checked?"收入":"支出");
            tabControl1.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        	helper.onInsertItem(new Item(textBox1.Text,int.Parse(comboBox1.SelectedValue.ToString()),radioButton1.Checked));
            tabControl1.SelectedTab = tabPage1;
            label3.Visible = true;
        }
		void TabControl1SelectedIndexChanged(object sender, EventArgs e)
		{
			if(tabControl1.SelectedTab==tabPage2)
				richTextBox1.Text = string.Format("要添加的收支项目为{0}\n所属类别：{1}\n是{2}类型的项目"
        	                                  ,textBox1.Text,comboBox1.Text,radioButton1.Checked?"收入":"支出");
		}
    }
}
