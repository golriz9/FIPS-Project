namespace FIPSGuideTool
{
	partial class CtrlInputPorts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlInputPorts));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_ExtCtrlDevice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_CtrlIn = new System.Windows.Forms.TextBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel1.Controls.Add(this.txt_ExtCtrlDevice);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txt_CtrlIn);
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1934, 1199);
			this.panel1.TabIndex = 22;
			// 
			// txt_ExtCtrlDevice
			// 
			this.txt_ExtCtrlDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_ExtCtrlDevice.Location = new System.Drawing.Point(48, 1013);
			this.txt_ExtCtrlDevice.Multiline = true;
			this.txt_ExtCtrlDevice.Name = "txt_ExtCtrlDevice";
			this.txt_ExtCtrlDevice.Size = new System.Drawing.Size(708, 149);
			this.txt_ExtCtrlDevice.TabIndex = 31;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(7, 960);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(481, 29);
			this.label4.TabIndex = 30;
			this.label4.Text = "Please specify the control input devices:";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "",
            "Yes",
            "No"});
			this.comboBox1.Location = new System.Drawing.Point(910, 889);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(161, 37);
			this.comboBox1.TabIndex = 29;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(7, 889);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(578, 29);
			this.label3.TabIndex = 28;
			this.label3.Text = "Does module use external control input devices?";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(7, 221);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(752, 29);
			this.label2.TabIndex = 27;
			this.label2.Text = "Following control data enters module via control input interface:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(523, 29);
			this.label1.TabIndex = 26;
			this.label1.Text = "Please specify the control input interface(s):";
			// 
			// txt_CtrlIn
			// 
			this.txt_CtrlIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_CtrlIn.Location = new System.Drawing.Point(818, 50);
			this.txt_CtrlIn.Multiline = true;
			this.txt_CtrlIn.Name = "txt_CtrlIn";
			this.txt_CtrlIn.Size = new System.Drawing.Size(708, 149);
			this.txt_CtrlIn.TabIndex = 25;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox3.Location = new System.Drawing.Point(39, 592);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(814, 33);
			this.checkBox3.TabIndex = 24;
			this.checkBox3.Text = "Manual control inputs (e.g., using switches, buttons, or a keyboard)";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox2.Location = new System.Drawing.Point(39, 441);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(1088, 62);
			this.checkBox2.TabIndex = 23;
			this.checkBox2.Text = "Signals input logically or physically via one or more physical ports, such as com" +
    "mands and\r\nsignals sent through a serial port or a PC Card";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(39, 290);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(1038, 62);
			this.checkBox1.TabIndex = 22;
			this.checkBox1.Text = "Commands input logically via an API, such as function calls to a software library" +
    " or to a\r\nsmart card";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// CtrlInputPorts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(1942, 1209);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CtrlInputPorts";
			this.Text = "Control Input Ports";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CtrlInputPorts_FormClosing);
			this.Load += new System.EventHandler(this.CtrlInputPorts_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txt_ExtCtrlDevice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_CtrlIn;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}