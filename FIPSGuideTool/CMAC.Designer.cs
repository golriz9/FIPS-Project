namespace FIPSGuideTool
{
	partial class CMAC
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMAC));
			this.CMAC_tabs = new System.Windows.Forms.TabControl();
			this.Gen_CMAC_AES_Tab = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.Ver_CMAC_AES_Tab = new System.Windows.Forms.TabPage();
			this.panel3 = new System.Windows.Forms.Panel();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.Gen_CMAC_TDES_Tab = new System.Windows.Forms.TabPage();
			this.panel5 = new System.Windows.Forms.Panel();
			this.checkBox18 = new System.Windows.Forms.CheckBox();
			this.Ver_CMAC_TDES_Tab = new System.Windows.Forms.TabPage();
			this.checkBox10 = new System.Windows.Forms.CheckBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox20 = new System.Windows.Forms.CheckBox();
			this.checkBox21 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.CMAC_tabs.SuspendLayout();
			this.Gen_CMAC_AES_Tab.SuspendLayout();
			this.panel1.SuspendLayout();
			this.Ver_CMAC_AES_Tab.SuspendLayout();
			this.panel3.SuspendLayout();
			this.Gen_CMAC_TDES_Tab.SuspendLayout();
			this.panel5.SuspendLayout();
			this.Ver_CMAC_TDES_Tab.SuspendLayout();
			this.SuspendLayout();
			// 
			// CMAC_tabs
			// 
			this.CMAC_tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CMAC_tabs.Controls.Add(this.Gen_CMAC_AES_Tab);
			this.CMAC_tabs.Controls.Add(this.Ver_CMAC_AES_Tab);
			this.CMAC_tabs.Controls.Add(this.Gen_CMAC_TDES_Tab);
			this.CMAC_tabs.Controls.Add(this.Ver_CMAC_TDES_Tab);
			this.CMAC_tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CMAC_tabs.Location = new System.Drawing.Point(12, 134);
			this.CMAC_tabs.Name = "CMAC_tabs";
			this.CMAC_tabs.SelectedIndex = 0;
			this.CMAC_tabs.Size = new System.Drawing.Size(1611, 223);
			this.CMAC_tabs.TabIndex = 83;
			// 
			// Gen_CMAC_AES_Tab
			// 
			this.Gen_CMAC_AES_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Gen_CMAC_AES_Tab.Controls.Add(this.panel1);
			this.Gen_CMAC_AES_Tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Gen_CMAC_AES_Tab.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Gen_CMAC_AES_Tab.Location = new System.Drawing.Point(4, 41);
			this.Gen_CMAC_AES_Tab.Name = "Gen_CMAC_AES_Tab";
			this.Gen_CMAC_AES_Tab.Padding = new System.Windows.Forms.Padding(3);
			this.Gen_CMAC_AES_Tab.Size = new System.Drawing.Size(1603, 178);
			this.Gen_CMAC_AES_Tab.TabIndex = 0;
			this.Gen_CMAC_AES_Tab.Text = "Generate CMAC w/ AES    ";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1597, 172);
			this.panel1.TabIndex = 22;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox3.Location = new System.Drawing.Point(614, 92);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(140, 33);
			this.checkBox3.TabIndex = 33;
			this.checkBox3.Text = "AES-256";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox2.Location = new System.Drawing.Point(326, 92);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(140, 33);
			this.checkBox2.TabIndex = 32;
			this.checkBox2.Text = "AES-192";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(407, 29);
			this.label1.TabIndex = 31;
			this.label1.Text = "Please select the AES algorithms.";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(38, 92);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(140, 33);
			this.checkBox1.TabIndex = 30;
			this.checkBox1.Text = "AES-128";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// Ver_CMAC_AES_Tab
			// 
			this.Ver_CMAC_AES_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Ver_CMAC_AES_Tab.Controls.Add(this.panel3);
			this.Ver_CMAC_AES_Tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ver_CMAC_AES_Tab.Location = new System.Drawing.Point(4, 41);
			this.Ver_CMAC_AES_Tab.Name = "Ver_CMAC_AES_Tab";
			this.Ver_CMAC_AES_Tab.Padding = new System.Windows.Forms.Padding(3);
			this.Ver_CMAC_AES_Tab.Size = new System.Drawing.Size(1603, 178);
			this.Ver_CMAC_AES_Tab.TabIndex = 1;
			this.Ver_CMAC_AES_Tab.Text = "Verify CMAC w/ AES    ";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel3.Controls.Add(this.checkBox4);
			this.panel3.Controls.Add(this.checkBox5);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.checkBox6);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1597, 172);
			this.panel3.TabIndex = 16;
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox4.Location = new System.Drawing.Point(614, 92);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(140, 33);
			this.checkBox4.TabIndex = 37;
			this.checkBox4.Text = "AES-256";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox5.Location = new System.Drawing.Point(326, 92);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(140, 33);
			this.checkBox5.TabIndex = 36;
			this.checkBox5.Text = "AES-192";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(407, 29);
			this.label2.TabIndex = 35;
			this.label2.Text = "Please select the AES algorithms.";
			// 
			// checkBox6
			// 
			this.checkBox6.AutoSize = true;
			this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox6.Location = new System.Drawing.Point(38, 92);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(140, 33);
			this.checkBox6.TabIndex = 34;
			this.checkBox6.Text = "AES-128";
			this.checkBox6.UseVisualStyleBackColor = true;
			// 
			// Gen_CMAC_TDES_Tab
			// 
			this.Gen_CMAC_TDES_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Gen_CMAC_TDES_Tab.Controls.Add(this.panel5);
			this.Gen_CMAC_TDES_Tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Gen_CMAC_TDES_Tab.Location = new System.Drawing.Point(4, 41);
			this.Gen_CMAC_TDES_Tab.Name = "Gen_CMAC_TDES_Tab";
			this.Gen_CMAC_TDES_Tab.Padding = new System.Windows.Forms.Padding(3);
			this.Gen_CMAC_TDES_Tab.Size = new System.Drawing.Size(1603, 178);
			this.Gen_CMAC_TDES_Tab.TabIndex = 2;
			this.Gen_CMAC_TDES_Tab.Text = "Generate CMAC w/ TDES    ";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel5.Controls.Add(this.checkBox18);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(3, 3);
			this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1597, 172);
			this.panel5.TabIndex = 15;
			// 
			// checkBox18
			// 
			this.checkBox18.AutoSize = true;
			this.checkBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox18.Location = new System.Drawing.Point(20, 66);
			this.checkBox18.Name = "checkBox18";
			this.checkBox18.Size = new System.Drawing.Size(242, 33);
			this.checkBox18.TabIndex = 6;
			this.checkBox18.Text = "3 Key Triple-DES";
			this.checkBox18.UseVisualStyleBackColor = true;
			// 
			// Ver_CMAC_TDES_Tab
			// 
			this.Ver_CMAC_TDES_Tab.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.Ver_CMAC_TDES_Tab.Controls.Add(this.checkBox10);
			this.Ver_CMAC_TDES_Tab.Controls.Add(this.checkBox9);
			this.Ver_CMAC_TDES_Tab.Location = new System.Drawing.Point(4, 41);
			this.Ver_CMAC_TDES_Tab.Name = "Ver_CMAC_TDES_Tab";
			this.Ver_CMAC_TDES_Tab.Size = new System.Drawing.Size(1603, 178);
			this.Ver_CMAC_TDES_Tab.TabIndex = 3;
			this.Ver_CMAC_TDES_Tab.Text = "Verify CMAC w/ AES    ";
			// 
			// checkBox10
			// 
			this.checkBox10.AutoSize = true;
			this.checkBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox10.Location = new System.Drawing.Point(20, 66);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new System.Drawing.Size(242, 33);
			this.checkBox10.TabIndex = 8;
			this.checkBox10.Text = "2 Key Triple-DES";
			this.checkBox10.UseVisualStyleBackColor = true;
			// 
			// checkBox9
			// 
			this.checkBox9.AutoSize = true;
			this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox9.Location = new System.Drawing.Point(389, 66);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(242, 33);
			this.checkBox9.TabIndex = 7;
			this.checkBox9.Text = "3 Key Triple-DES";
			this.checkBox9.UseVisualStyleBackColor = true;
			// 
			// checkBox20
			// 
			this.checkBox20.AutoSize = true;
			this.checkBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox20.Location = new System.Drawing.Point(16, 79);
			this.checkBox20.Name = "checkBox20";
			this.checkBox20.Size = new System.Drawing.Size(296, 33);
			this.checkBox20.TabIndex = 87;
			this.checkBox20.Text = "Verify CMAC with AES";
			this.checkBox20.UseVisualStyleBackColor = true;
			this.checkBox20.CheckedChanged += new System.EventHandler(this.checkBox20_CheckedChanged);
			// 
			// checkBox21
			// 
			this.checkBox21.AutoSize = true;
			this.checkBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox21.Location = new System.Drawing.Point(16, 26);
			this.checkBox21.Name = "checkBox21";
			this.checkBox21.Size = new System.Drawing.Size(338, 33);
			this.checkBox21.TabIndex = 86;
			this.checkBox21.Text = "Generate CMAC with AES";
			this.checkBox21.UseVisualStyleBackColor = true;
			this.checkBox21.CheckedChanged += new System.EventHandler(this.checkBox21_CheckedChanged);
			// 
			// checkBox7
			// 
			this.checkBox7.AutoSize = true;
			this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox7.Location = new System.Drawing.Point(672, 26);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(357, 33);
			this.checkBox7.TabIndex = 88;
			this.checkBox7.Text = "Generate CMAC with TDES";
			this.checkBox7.UseVisualStyleBackColor = true;
			this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
			// 
			// checkBox8
			// 
			this.checkBox8.AutoSize = true;
			this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox8.Location = new System.Drawing.Point(672, 79);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(315, 33);
			this.checkBox8.TabIndex = 89;
			this.checkBox8.Text = "Verify CMAC with TDES";
			this.checkBox8.UseVisualStyleBackColor = true;
			this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
			// 
			// CMAC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(1635, 369);
			this.Controls.Add(this.checkBox8);
			this.Controls.Add(this.checkBox7);
			this.Controls.Add(this.checkBox20);
			this.Controls.Add(this.checkBox21);
			this.Controls.Add(this.CMAC_tabs);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CMAC";
			this.Text = "CMAC";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CMAC_FormClosing);
			this.Load += new System.EventHandler(this.CMAC_Load);
			this.CMAC_tabs.ResumeLayout(false);
			this.Gen_CMAC_AES_Tab.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.Ver_CMAC_AES_Tab.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.Gen_CMAC_TDES_Tab.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.Ver_CMAC_TDES_Tab.ResumeLayout(false);
			this.Ver_CMAC_TDES_Tab.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl CMAC_tabs;
		private System.Windows.Forms.TabPage Gen_CMAC_AES_Tab;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TabPage Ver_CMAC_AES_Tab;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.TabPage Gen_CMAC_TDES_Tab;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.CheckBox checkBox18;
		private System.Windows.Forms.TabPage Ver_CMAC_TDES_Tab;
		private System.Windows.Forms.CheckBox checkBox20;
		private System.Windows.Forms.CheckBox checkBox21;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox8;
		private System.Windows.Forms.CheckBox checkBox10;
		private System.Windows.Forms.CheckBox checkBox9;
	}
}