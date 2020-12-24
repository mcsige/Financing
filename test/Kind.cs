/*
 * 由SharpDevelop创建。
 * 用户： Dell
 * 日期: 2020/12/24
 * 时间: 15:56
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace test
{
	/// <summary>
	/// Description of Kind.
	/// </summary>
	public class Kind
	{
		
		private int kid;
		private string kindName;
		
		public Kind(int kid,string kindName)
		{
			this.kid = kid;
			this.kindName = kindName;
		}
		
		
		public int Kid {
			get {
				return kid;
			}
			set {
				Kid = value;
			}
		}

		public string KindName {
			get {
				return kindName;
			}
			set {
				kindName = value;
			}
		}
	}
}
