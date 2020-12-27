/*
 * 由SharpDevelop创建。
 * 用户： Dell
 * 日期: 2020/12/24
 * 时间: 16:20
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace test
{
	/// <summary>
	/// Description of Record.
	/// </summary>
	public class Record
	{
		private int iid;
		private DateTime date;
		private string explain;
		private int pkind;
		private int money;
		private string remarks;
		public Record(int iid,DateTime date,string explain,int pkind,int money,string remarks)
		{
			this.iid = iid;
			this.date = date;
			this.explain = explain;
			this.pkind = pkind;
			this.money = money;
			this.remarks = remarks;
		}

		public int Iid {
			get {
				return iid;
			}
			set {
				iid = value;
			}
		}

		public DateTime Date {
			get {
				return date;
			}
			set {
				date = value;
			}
		}

		public string Explain {
			get {
				return explain;
			}
			set {
				explain = value;
			}
		}

		public int Pkind {
			get {
				return pkind;
			}
			set {
				pkind = value;
			}
		}

		public int Money {
			get {
				return money;
			}
			set {
				money = value;
			}
		}

		public string Remarks {
			get {
				return remarks;
			}
			set {
				remarks = value;
			}
		}
	}
}
