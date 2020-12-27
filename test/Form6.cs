/*
 * 由SharpDevelop创建。
 * 用户： Dell
 * 日期: 2020/12/26
 * 时间: 20:38
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace test
{
	/// <summary>
	/// Description of Form6.
	/// </summary>
	public partial class Form6 : Form
	{
		private Form parent;
		private DBhelper helper;
		public Form6(Form parent)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.parent = parent;
			helper = new DBhelper();
		}
		void Form6FormClosing(object sender, FormClosingEventArgs e)
		{
			parent.Enabled = true;
		}
		void Button1Click(object sender, EventArgs e)
		{
			DataTable table = helper.onRecordQuery(null);
			dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = table;
		}
	}
}
