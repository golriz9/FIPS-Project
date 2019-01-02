namespace FIPSGuideTool
{
	partial class CTR_AES
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTR_AES));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.checkBox_256en = new System.Windows.Forms.CheckBox();
			this.checkBox_192en = new System.Windows.Forms.CheckBox();
			this.checkBox_128en = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.checkBox_256en);
			this.panel1.Controls.Add(this.checkBox_192en);
			this.panel1.Controls.Add(this.checkBox_128en);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1655, 833);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(576, 89);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(454, 419);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 54;
			this.pictureBox1.TabStop = false;
			// 
			// checkBox_256en
			// 
			this.checkBox_256en.AutoSize = true;
			this.checkBox_256en.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_256en.Location = new System.Drawing.Point(106, 252);
			this.checkBox_256en.Name = "checkBox_256en";
			this.checkBox_256en.Size = new System.Drawing.Size(278, 33);
			this.checkBox_256en.TabIndex = 56;
			this.checkBox_256en.Text = "256 bits (Encryption)";
			this.checkBox_256en.UseVisualStyleBackColor = true;
			// 
			// checkBox_192en
			// 
			this.checkBox_192en.AutoSize = true;
			this.checkBox_192en.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_192en.Location = new System.Drawing.Point(106, 176);
			this.checkBox_192en.Name = "checkBox_192en";
			this.checkBox_192en.Size = new System.Drawing.Size(278, 33);
			this.checkBox_192en.TabIndex = 55;
			this.checkBox_192en.Text = "192 bits (Encryption)";
			this.checkBox_192en.UseVisualStyleBackColor = true;
			// 
			// checkBox_128en
			// 
			this.checkBox_128en.AutoSize = true;
			this.checkBox_128en.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_128en.Location = new System.Drawing.Point(106, 97);
			this.checkBox_128en.Name = "checkBox_128en";
			this.checkBox_128en.Size = new System.Drawing.Size(278, 33);
			this.checkBox_128en.TabIndex = 53;
			this.checkBox_128en.Text = "128 bits (Encryption)";
			this.checkBox_128en.UseVisualStyleBackColor = true;
			// 
			// CTR_AES
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(1679, 857);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CTR_AES";
			this.Text = "AES Counter Mode";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CTR_FormClosing);
			this.Load += new System.EventHandler(this.CTR_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox checkBox_256en;
		private System.Windows.Forms.CheckBox checkBox_192en;
		private System.Windows.Forms.CheckBox checkBox_128en;
	}
}