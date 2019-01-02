namespace FIPSGuideTool
{
	partial class AES
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AES));
			this.btn_ECB = new System.Windows.Forms.Button();
			this.btn_CBC = new System.Windows.Forms.Button();
			this.btn_OFB = new System.Windows.Forms.Button();
			this.btn_CFB = new System.Windows.Forms.Button();
			this.btn_CTR = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox_CTR = new System.Windows.Forms.CheckBox();
			this.checkBox_CFB = new System.Windows.Forms.CheckBox();
			this.checkBox_OFB = new System.Windows.Forms.CheckBox();
			this.checkBox_CBC = new System.Windows.Forms.CheckBox();
			this.checkBox_ECB = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_ECB
			// 
			this.btn_ECB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ECB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_ECB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ECB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_ECB.Location = new System.Drawing.Point(302, 94);
			this.btn_ECB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_ECB.Name = "btn_ECB";
			this.btn_ECB.Size = new System.Drawing.Size(216, 58);
			this.btn_ECB.TabIndex = 76;
			this.btn_ECB.Text = "ECB";
			this.btn_ECB.UseVisualStyleBackColor = false;
			this.btn_ECB.Click += new System.EventHandler(this.btn_ECB_Click);
			// 
			// btn_CBC
			// 
			this.btn_CBC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_CBC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_CBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_CBC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_CBC.Location = new System.Drawing.Point(302, 162);
			this.btn_CBC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_CBC.Name = "btn_CBC";
			this.btn_CBC.Size = new System.Drawing.Size(216, 58);
			this.btn_CBC.TabIndex = 77;
			this.btn_CBC.Text = "CBC";
			this.btn_CBC.UseVisualStyleBackColor = false;
			this.btn_CBC.Click += new System.EventHandler(this.btn_CBC_Click);
			// 
			// btn_OFB
			// 
			this.btn_OFB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_OFB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_OFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_OFB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_OFB.Location = new System.Drawing.Point(302, 230);
			this.btn_OFB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_OFB.Name = "btn_OFB";
			this.btn_OFB.Size = new System.Drawing.Size(216, 58);
			this.btn_OFB.TabIndex = 78;
			this.btn_OFB.Text = "OFB";
			this.btn_OFB.UseVisualStyleBackColor = false;
			this.btn_OFB.Click += new System.EventHandler(this.btn_OFB_Click);
			// 
			// btn_CFB
			// 
			this.btn_CFB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_CFB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_CFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_CFB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_CFB.Location = new System.Drawing.Point(302, 298);
			this.btn_CFB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_CFB.Name = "btn_CFB";
			this.btn_CFB.Size = new System.Drawing.Size(216, 58);
			this.btn_CFB.TabIndex = 79;
			this.btn_CFB.Text = "CFB";
			this.btn_CFB.UseVisualStyleBackColor = false;
			this.btn_CFB.Click += new System.EventHandler(this.btn_CFB_Click);
			// 
			// btn_CTR
			// 
			this.btn_CTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_CTR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_CTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_CTR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_CTR.Location = new System.Drawing.Point(302, 366);
			this.btn_CTR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_CTR.Name = "btn_CTR";
			this.btn_CTR.Size = new System.Drawing.Size(216, 58);
			this.btn_CTR.TabIndex = 80;
			this.btn_CTR.Text = "CTR";
			this.btn_CTR.UseVisualStyleBackColor = false;
			this.btn_CTR.Click += new System.EventHandler(this.btn_CTR_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btn_CTR);
			this.panel1.Controls.Add(this.checkBox_CTR);
			this.panel1.Controls.Add(this.btn_CFB);
			this.panel1.Controls.Add(this.checkBox_CFB);
			this.panel1.Controls.Add(this.btn_OFB);
			this.panel1.Controls.Add(this.checkBox_OFB);
			this.panel1.Controls.Add(this.btn_CBC);
			this.panel1.Controls.Add(this.checkBox_CBC);
			this.panel1.Controls.Add(this.btn_ECB);
			this.panel1.Controls.Add(this.checkBox_ECB);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(568, 552);
			this.panel1.TabIndex = 92;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(55, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 32);
			this.label1.TabIndex = 107;
			this.label1.Text = "Modes";
			// 
			// checkBox_CTR
			// 
			this.checkBox_CTR.AutoSize = true;
			this.checkBox_CTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_CTR.Location = new System.Drawing.Point(60, 380);
			this.checkBox_CTR.Name = "checkBox_CTR";
			this.checkBox_CTR.Size = new System.Drawing.Size(92, 33);
			this.checkBox_CTR.TabIndex = 4;
			this.checkBox_CTR.Text = "CTR";
			this.checkBox_CTR.UseVisualStyleBackColor = true;
			this.checkBox_CTR.CheckedChanged += new System.EventHandler(this.checkBox_CTR_CheckedChanged);
			// 
			// checkBox_CFB
			// 
			this.checkBox_CFB.AutoSize = true;
			this.checkBox_CFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_CFB.Location = new System.Drawing.Point(60, 312);
			this.checkBox_CFB.Name = "checkBox_CFB";
			this.checkBox_CFB.Size = new System.Drawing.Size(90, 33);
			this.checkBox_CFB.TabIndex = 3;
			this.checkBox_CFB.Text = "CFB";
			this.checkBox_CFB.UseVisualStyleBackColor = true;
			this.checkBox_CFB.CheckedChanged += new System.EventHandler(this.checkBox_CFB_CheckedChanged);
			// 
			// checkBox_OFB
			// 
			this.checkBox_OFB.AutoSize = true;
			this.checkBox_OFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_OFB.Location = new System.Drawing.Point(60, 244);
			this.checkBox_OFB.Name = "checkBox_OFB";
			this.checkBox_OFB.Size = new System.Drawing.Size(92, 33);
			this.checkBox_OFB.TabIndex = 2;
			this.checkBox_OFB.Text = "OFB";
			this.checkBox_OFB.UseVisualStyleBackColor = true;
			this.checkBox_OFB.CheckedChanged += new System.EventHandler(this.checkBox_OFB_CheckedChanged);
			// 
			// checkBox_CBC
			// 
			this.checkBox_CBC.AutoSize = true;
			this.checkBox_CBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_CBC.Location = new System.Drawing.Point(60, 176);
			this.checkBox_CBC.Name = "checkBox_CBC";
			this.checkBox_CBC.Size = new System.Drawing.Size(92, 33);
			this.checkBox_CBC.TabIndex = 1;
			this.checkBox_CBC.Text = "CBC";
			this.checkBox_CBC.UseVisualStyleBackColor = true;
			this.checkBox_CBC.CheckedChanged += new System.EventHandler(this.checkBox_CBC_CheckedChanged);
			// 
			// checkBox_ECB
			// 
			this.checkBox_ECB.AutoSize = true;
			this.checkBox_ECB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_ECB.Location = new System.Drawing.Point(61, 108);
			this.checkBox_ECB.Name = "checkBox_ECB";
			this.checkBox_ECB.Size = new System.Drawing.Size(91, 33);
			this.checkBox_ECB.TabIndex = 0;
			this.checkBox_ECB.Text = "ECB";
			this.checkBox_ECB.UseVisualStyleBackColor = true;
			this.checkBox_ECB.CheckedChanged += new System.EventHandler(this.checkBox_ECB_CheckedChanged);
			// 
			// AES
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(592, 576);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AES";
			this.Text = "AES";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AES_FormClosing);
			this.Load += new System.EventHandler(this.AES_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btn_ECB;
		private System.Windows.Forms.Button btn_CBC;
		private System.Windows.Forms.Button btn_OFB;
		private System.Windows.Forms.Button btn_CFB;
		private System.Windows.Forms.Button btn_CTR;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox_CTR;
		private System.Windows.Forms.CheckBox checkBox_CFB;
		private System.Windows.Forms.CheckBox checkBox_OFB;
		private System.Windows.Forms.CheckBox checkBox_CBC;
		private System.Windows.Forms.CheckBox checkBox_ECB;
	}
}