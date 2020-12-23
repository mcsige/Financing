namespace test
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.tabControl1 = new System.Windows.Forms.TabControl();
        	this.tabPage1 = new System.Windows.Forms.TabPage();
        	this.button1 = new System.Windows.Forms.Button();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.comboBox1 = new System.Windows.Forms.ComboBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.radioButton2 = new System.Windows.Forms.RadioButton();
        	this.radioButton1 = new System.Windows.Forms.RadioButton();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.tabPage2 = new System.Windows.Forms.TabPage();
        	this.button2 = new System.Windows.Forms.Button();
        	this.richTextBox1 = new System.Windows.Forms.RichTextBox();
        	this.tabControl1.SuspendLayout();
        	this.tabPage1.SuspendLayout();
        	this.groupBox1.SuspendLayout();
        	this.tabPage2.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// tabControl1
        	// 
        	this.tabControl1.Controls.Add(this.tabPage1);
        	this.tabControl1.Controls.Add(this.tabPage2);
        	this.tabControl1.Location = new System.Drawing.Point(16, 15);
        	this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.tabControl1.Name = "tabControl1";
        	this.tabControl1.SelectedIndex = 0;
        	this.tabControl1.Size = new System.Drawing.Size(365, 298);
        	this.tabControl1.TabIndex = 0;
        	// 
        	// tabPage1
        	// 
        	this.tabPage1.Controls.Add(this.button1);
        	this.tabPage1.Controls.Add(this.groupBox1);
        	this.tabPage1.Controls.Add(this.textBox1);
        	this.tabPage1.Controls.Add(this.label1);
        	this.tabPage1.Location = new System.Drawing.Point(4, 25);
        	this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.tabPage1.Name = "tabPage1";
        	this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.tabPage1.Size = new System.Drawing.Size(357, 269);
        	this.tabPage1.TabIndex = 0;
        	this.tabPage1.Text = "收支项目信息";
        	this.tabPage1.UseVisualStyleBackColor = true;
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(113, 210);
        	this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(100, 29);
        	this.button1.TabIndex = 3;
        	this.button1.Text = "预览";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.comboBox1);
        	this.groupBox1.Controls.Add(this.label2);
        	this.groupBox1.Controls.Add(this.radioButton2);
        	this.groupBox1.Controls.Add(this.radioButton1);
        	this.groupBox1.Location = new System.Drawing.Point(31, 78);
        	this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.groupBox1.Size = new System.Drawing.Size(267, 125);
        	this.groupBox1.TabIndex = 2;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "所属类别";
        	// 
        	// comboBox1
        	// 
        	this.comboBox1.FormattingEnabled = true;
        	this.comboBox1.Location = new System.Drawing.Point(81, 79);
        	this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.comboBox1.Name = "comboBox1";
        	this.comboBox1.Size = new System.Drawing.Size(160, 23);
        	this.comboBox1.TabIndex = 5;
        	this.comboBox1.Text = "教育培训";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(19, 82);
        	this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(52, 15);
        	this.label2.TabIndex = 4;
        	this.label2.Text = "类别：";
        	// 
        	// radioButton2
        	// 
        	this.radioButton2.AutoSize = true;
        	this.radioButton2.Location = new System.Drawing.Point(145, 39);
        	this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.radioButton2.Name = "radioButton2";
        	this.radioButton2.Size = new System.Drawing.Size(58, 19);
        	this.radioButton2.TabIndex = 1;
        	this.radioButton2.Text = "支出";
        	this.radioButton2.UseVisualStyleBackColor = true;
        	// 
        	// radioButton1
        	// 
        	this.radioButton1.AutoSize = true;
        	this.radioButton1.Checked = true;
        	this.radioButton1.Location = new System.Drawing.Point(21, 39);
        	this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.radioButton1.Name = "radioButton1";
        	this.radioButton1.Size = new System.Drawing.Size(58, 19);
        	this.radioButton1.TabIndex = 0;
        	this.radioButton1.TabStop = true;
        	this.radioButton1.Text = "收入";
        	this.radioButton1.UseVisualStyleBackColor = true;
        	// 
        	// textBox1
        	// 
        	this.textBox1.Location = new System.Drawing.Point(140, 28);
        	this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(132, 25);
        	this.textBox1.TabIndex = 1;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(28, 31);
        	this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(82, 15);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "项目名称：";
        	// 
        	// tabPage2
        	// 
        	this.tabPage2.Controls.Add(this.button2);
        	this.tabPage2.Controls.Add(this.richTextBox1);
        	this.tabPage2.Location = new System.Drawing.Point(4, 25);
        	this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.tabPage2.Name = "tabPage2";
        	this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.tabPage2.Size = new System.Drawing.Size(357, 269);
        	this.tabPage2.TabIndex = 1;
        	this.tabPage2.Text = "确认信息";
        	this.tabPage2.UseVisualStyleBackColor = true;
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(128, 210);
        	this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(100, 29);
        	this.button2.TabIndex = 1;
        	this.button2.Text = "确认添加";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.button2_Click);
        	// 
        	// richTextBox1
        	// 
        	this.richTextBox1.Location = new System.Drawing.Point(33, 24);
        	this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.richTextBox1.Name = "richTextBox1";
        	this.richTextBox1.ReadOnly = true;
        	this.richTextBox1.Size = new System.Drawing.Size(288, 178);
        	this.richTextBox1.TabIndex = 0;
        	this.richTextBox1.Text = "";
        	// 
        	// Form3
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(397, 328);
        	this.Controls.Add(this.tabControl1);
        	this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.Name = "Form3";
        	this.Text = "添加收支项目";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
        	this.tabControl1.ResumeLayout(false);
        	this.tabPage1.ResumeLayout(false);
        	this.tabPage1.PerformLayout();
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.tabPage2.ResumeLayout(false);
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
    }
}