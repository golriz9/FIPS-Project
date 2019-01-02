namespace FIPSGuideTool
{
	partial class DRBG
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DRBG));
			this.DRBG_tabs = new System.Windows.Forms.TabControl();
			this.HASH_DRBG = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.HMAC_DRBG = new System.Windows.Forms.TabPage();
			this.panel3 = new System.Windows.Forms.Panel();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox10 = new System.Windows.Forms.CheckBox();
			this.checkBox11 = new System.Windows.Forms.CheckBox();
			this.checkBox12 = new System.Windows.Forms.CheckBox();
			this.checkBox13 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox14 = new System.Windows.Forms.CheckBox();
			this.CTR_DRBG = new System.Windows.Forms.TabPage();
			this.panel5 = new System.Windows.Forms.Panel();
			this.checkBox15 = new System.Windows.Forms.CheckBox();
			this.checkBox16 = new System.Windows.Forms.CheckBox();
			this.checkBox17 = new System.Windows.Forms.CheckBox();
			this.checkBox18 = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox19 = new System.Windows.Forms.CheckBox();
			this.checkBox20 = new System.Windows.Forms.CheckBox();
			this.checkBox21 = new System.Windows.Forms.CheckBox();
			this.DRBG_tabs.SuspendLayout();
			this.HASH_DRBG.SuspendLayout();
			this.panel1.SuspendLayout();
			this.HMAC_DRBG.SuspendLayout();
			this.panel3.SuspendLayout();
			this.CTR_DRBG.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// DRBG_tabs
			// 
			this.DRBG_tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DRBG_tabs.Controls.Add(this.HASH_DRBG);
			this.DRBG_tabs.Controls.Add(this.HMAC_DRBG);
			this.DRBG_tabs.Controls.Add(this.CTR_DRBG);
			this.DRBG_tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DRBG_tabs.Location = new System.Drawing.Point(12, 83);
			this.DRBG_tabs.Name = "DRBG_tabs";
			this.DRBG_tabs.SelectedIndex = 0;
			this.DRBG_tabs.Size = new System.Drawing.Size(1064, 470);
			this.DRBG_tabs.TabIndex = 82;
			// 
			// HASH_DRBG
			// 
			this.HASH_DRBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.HASH_DRBG.Controls.Add(this.panel1);
			this.HASH_DRBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HASH_DRBG.Location = new System.Drawing.Point(4, 41);
			this.HASH_DRBG.Name = "HASH_DRBG";
			this.HASH_DRBG.Padding = new System.Windows.Forms.Padding(3);
			this.HASH_DRBG.Size = new System.Drawing.Size(1056, 425);
			this.HASH_DRBG.TabIndex = 0;
			this.HASH_DRBG.Text = "HASH-DRBG    ";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel1.Controls.Add(this.checkBox7);
			this.panel1.Controls.Add(this.checkBox6);
			this.panel1.Controls.Add(this.checkBox5);
			this.panel1.Controls.Add(this.checkBox4);
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1050, 419);
			this.panel1.TabIndex = 22;
			// 
			// checkBox7
			// 
			this.checkBox7.AutoSize = true;
			this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox7.Location = new System.Drawing.Point(285, 224);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(191, 33);
			this.checkBox7.TabIndex = 37;
			this.checkBox7.Text = "SHA-512/256";
			this.checkBox7.UseVisualStyleBackColor = true;
			// 
			// checkBox6
			// 
			this.checkBox6.AutoSize = true;
			this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox6.Location = new System.Drawing.Point(285, 158);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(191, 33);
			this.checkBox6.TabIndex = 36;
			this.checkBox6.Text = "SHA-512/224";
			this.checkBox6.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox5.Location = new System.Drawing.Point(285, 92);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(141, 33);
			this.checkBox5.TabIndex = 35;
			this.checkBox5.Text = "SHA-512";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox4.Location = new System.Drawing.Point(23, 294);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(141, 33);
			this.checkBox4.TabIndex = 34;
			this.checkBox4.Text = "SHA-384";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox3.Location = new System.Drawing.Point(22, 224);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(141, 33);
			this.checkBox3.TabIndex = 33;
			this.checkBox3.Text = "SHA-256";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox2.Location = new System.Drawing.Point(22, 158);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(141, 33);
			this.checkBox2.TabIndex = 32;
			this.checkBox2.Text = "SHA-224";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(18, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(408, 29);
			this.label1.TabIndex = 31;
			this.label1.Text = "Please select the SHA algorithms.";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(22, 92);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(113, 33);
			this.checkBox1.TabIndex = 30;
			this.checkBox1.Text = "SHA-1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// HMAC_DRBG
			// 
			this.HMAC_DRBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.HMAC_DRBG.Controls.Add(this.panel3);
			this.HMAC_DRBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HMAC_DRBG.Location = new System.Drawing.Point(4, 41);
			this.HMAC_DRBG.Name = "HMAC_DRBG";
			this.HMAC_DRBG.Padding = new System.Windows.Forms.Padding(3);
			this.HMAC_DRBG.Size = new System.Drawing.Size(1056, 425);
			this.HMAC_DRBG.TabIndex = 1;
			this.HMAC_DRBG.Text = "HMAC-DRBG    ";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel3.Controls.Add(this.checkBox8);
			this.panel3.Controls.Add(this.checkBox9);
			this.panel3.Controls.Add(this.checkBox10);
			this.panel3.Controls.Add(this.checkBox11);
			this.panel3.Controls.Add(this.checkBox12);
			this.panel3.Controls.Add(this.checkBox13);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.checkBox14);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1050, 419);
			this.panel3.TabIndex = 16;
			// 
			// checkBox8
			// 
			this.checkBox8.AutoSize = true;
			this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox8.Location = new System.Drawing.Point(286, 232);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(191, 33);
			this.checkBox8.TabIndex = 45;
			this.checkBox8.Text = "SHA-512/256";
			this.checkBox8.UseVisualStyleBackColor = true;
			// 
			// checkBox9
			// 
			this.checkBox9.AutoSize = true;
			this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox9.Location = new System.Drawing.Point(286, 166);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(191, 33);
			this.checkBox9.TabIndex = 44;
			this.checkBox9.Text = "SHA-512/224";
			this.checkBox9.UseVisualStyleBackColor = true;
			// 
			// checkBox10
			// 
			this.checkBox10.AutoSize = true;
			this.checkBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox10.Location = new System.Drawing.Point(286, 100);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new System.Drawing.Size(141, 33);
			this.checkBox10.TabIndex = 43;
			this.checkBox10.Text = "SHA-512";
			this.checkBox10.UseVisualStyleBackColor = true;
			// 
			// checkBox11
			// 
			this.checkBox11.AutoSize = true;
			this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox11.Location = new System.Drawing.Point(24, 302);
			this.checkBox11.Name = "checkBox11";
			this.checkBox11.Size = new System.Drawing.Size(141, 33);
			this.checkBox11.TabIndex = 42;
			this.checkBox11.Text = "SHA-384";
			this.checkBox11.UseVisualStyleBackColor = true;
			// 
			// checkBox12
			// 
			this.checkBox12.AutoSize = true;
			this.checkBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox12.Location = new System.Drawing.Point(23, 232);
			this.checkBox12.Name = "checkBox12";
			this.checkBox12.Size = new System.Drawing.Size(141, 33);
			this.checkBox12.TabIndex = 41;
			this.checkBox12.Text = "SHA-256";
			this.checkBox12.UseVisualStyleBackColor = true;
			// 
			// checkBox13
			// 
			this.checkBox13.AutoSize = true;
			this.checkBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox13.Location = new System.Drawing.Point(23, 166);
			this.checkBox13.Name = "checkBox13";
			this.checkBox13.Size = new System.Drawing.Size(141, 33);
			this.checkBox13.TabIndex = 40;
			this.checkBox13.Text = "SHA-224";
			this.checkBox13.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(408, 29);
			this.label2.TabIndex = 39;
			this.label2.Text = "Please select the SHA algorithms.";
			// 
			// checkBox14
			// 
			this.checkBox14.AutoSize = true;
			this.checkBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox14.Location = new System.Drawing.Point(23, 100);
			this.checkBox14.Name = "checkBox14";
			this.checkBox14.Size = new System.Drawing.Size(113, 33);
			this.checkBox14.TabIndex = 38;
			this.checkBox14.Text = "SHA-1";
			this.checkBox14.UseVisualStyleBackColor = true;
			// 
			// CTR_DRBG
			// 
			this.CTR_DRBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.CTR_DRBG.Controls.Add(this.panel5);
			this.CTR_DRBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CTR_DRBG.Location = new System.Drawing.Point(4, 41);
			this.CTR_DRBG.Name = "CTR_DRBG";
			this.CTR_DRBG.Padding = new System.Windows.Forms.Padding(3);
			this.CTR_DRBG.Size = new System.Drawing.Size(1056, 425);
			this.CTR_DRBG.TabIndex = 2;
			this.CTR_DRBG.Text = "CTR-DRBG    ";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel5.Controls.Add(this.checkBox15);
			this.panel5.Controls.Add(this.checkBox16);
			this.panel5.Controls.Add(this.checkBox17);
			this.panel5.Controls.Add(this.checkBox18);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(3, 3);
			this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1050, 419);
			this.panel5.TabIndex = 15;
			// 
			// checkBox15
			// 
			this.checkBox15.AutoSize = true;
			this.checkBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox15.Location = new System.Drawing.Point(342, 164);
			this.checkBox15.Name = "checkBox15";
			this.checkBox15.Size = new System.Drawing.Size(140, 33);
			this.checkBox15.TabIndex = 9;
			this.checkBox15.Text = "AES-256";
			this.checkBox15.UseVisualStyleBackColor = true;
			// 
			// checkBox16
			// 
			this.checkBox16.AutoSize = true;
			this.checkBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox16.Location = new System.Drawing.Point(342, 96);
			this.checkBox16.Name = "checkBox16";
			this.checkBox16.Size = new System.Drawing.Size(140, 33);
			this.checkBox16.TabIndex = 8;
			this.checkBox16.Text = "AES-192";
			this.checkBox16.UseVisualStyleBackColor = true;
			// 
			// checkBox17
			// 
			this.checkBox17.AutoSize = true;
			this.checkBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox17.Location = new System.Drawing.Point(25, 164);
			this.checkBox17.Name = "checkBox17";
			this.checkBox17.Size = new System.Drawing.Size(140, 33);
			this.checkBox17.TabIndex = 7;
			this.checkBox17.Text = "AES-128";
			this.checkBox17.UseVisualStyleBackColor = true;
			// 
			// checkBox18
			// 
			this.checkBox18.AutoSize = true;
			this.checkBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox18.Location = new System.Drawing.Point(25, 96);
			this.checkBox18.Name = "checkBox18";
			this.checkBox18.Size = new System.Drawing.Size(179, 33);
			this.checkBox18.TabIndex = 6;
			this.checkBox18.Text = "3 Key TDEA";
			this.checkBox18.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(20, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(550, 29);
			this.label3.TabIndex = 5;
			this.label3.Text = "Please choose the block cipher (CTR) DRBG. ";
			// 
			// checkBox19
			// 
			this.checkBox19.AutoSize = true;
			this.checkBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox19.Location = new System.Drawing.Point(788, 24);
			this.checkBox19.Name = "checkBox19";
			this.checkBox19.Size = new System.Drawing.Size(173, 33);
			this.checkBox19.TabIndex = 85;
			this.checkBox19.Text = "CTR-DRBG";
			this.checkBox19.UseVisualStyleBackColor = true;
			this.checkBox19.CheckedChanged += new System.EventHandler(this.checkBox19_CheckedChanged);
			// 
			// checkBox20
			// 
			this.checkBox20.AutoSize = true;
			this.checkBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox20.Location = new System.Drawing.Point(398, 24);
			this.checkBox20.Name = "checkBox20";
			this.checkBox20.Size = new System.Drawing.Size(193, 33);
			this.checkBox20.TabIndex = 84;
			this.checkBox20.Text = "HMAC-DRBG";
			this.checkBox20.UseVisualStyleBackColor = true;
			this.checkBox20.CheckedChanged += new System.EventHandler(this.checkBox20_CheckedChanged);
			// 
			// checkBox21
			// 
			this.checkBox21.AutoSize = true;
			this.checkBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox21.Location = new System.Drawing.Point(12, 24);
			this.checkBox21.Name = "checkBox21";
			this.checkBox21.Size = new System.Drawing.Size(189, 33);
			this.checkBox21.TabIndex = 83;
			this.checkBox21.Text = "HASH-DRBG";
			this.checkBox21.UseVisualStyleBackColor = true;
			this.checkBox21.CheckedChanged += new System.EventHandler(this.checkBox21_CheckedChanged);
			// 
			// DRBG
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(1088, 565);
			this.Controls.Add(this.checkBox19);
			this.Controls.Add(this.checkBox20);
			this.Controls.Add(this.checkBox21);
			this.Controls.Add(this.DRBG_tabs);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "DRBG";
			this.Text = "DRBG";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DRBG_FormClosing);
			this.Load += new System.EventHandler(this.DRBG_Load);
			this.DRBG_tabs.ResumeLayout(false);
			this.HASH_DRBG.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.HMAC_DRBG.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.CTR_DRBG.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TabControl DRBG_tabs;
		private System.Windows.Forms.TabPage HASH_DRBG;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabPage HMAC_DRBG;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TabPage CTR_DRBG;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox8;
		private System.Windows.Forms.CheckBox checkBox9;
		private System.Windows.Forms.CheckBox checkBox10;
		private System.Windows.Forms.CheckBox checkBox11;
		private System.Windows.Forms.CheckBox checkBox12;
		private System.Windows.Forms.CheckBox checkBox13;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox14;
		private System.Windows.Forms.CheckBox checkBox15;
		private System.Windows.Forms.CheckBox checkBox16;
		private System.Windows.Forms.CheckBox checkBox17;
		private System.Windows.Forms.CheckBox checkBox18;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBox19;
		private System.Windows.Forms.CheckBox checkBox20;
		private System.Windows.Forms.CheckBox checkBox21;
	}
}