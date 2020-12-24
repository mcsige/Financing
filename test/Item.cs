/*
 * 由SharpDevelop创建。
 * 用户： Dell
 * 日期: 2020/12/24
 * 时间: 15:55
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace test
{
	/// <summary>
	/// Description of Item.
	/// </summary>
	public class Item
	{

		private int kid;
		private bool flag;
		private string name;
			
		public Item(string name,int kid,bool flag)
		{
			this.name = name;
			this.kid = kid;
			this.flag = flag;
		}

		public string Name {
			get {
				return name;
			}
			set {
				name = value;
			}
		}
		

		public int Kid {
			get {
				return kid;
			}
			set {
				kid = value;
			}
		}

		public bool Flag {
			get {
				return flag;
			}
			set {
				flag = value;
			}
		}
	}
}
