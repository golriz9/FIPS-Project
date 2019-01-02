namespace FIPSGuideTool
{
	partial class RSA_ComponentTest
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSA_ComponentTest));
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.checkBox27 = new System.Windows.Forms.CheckBox();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox6
			// 
			this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox6.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.groupBox6.Controls.Add(this.checkBox27);
			this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox6.Location = new System.Drawing.Point(12, 12);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(1040, 166);
			this.groupBox6.TabIndex = 42;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Testing of RSA Components";
			// 
			// checkBox27
			// 
			this.checkBox27.AutoSize = true;
			this.checkBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox27.Location = new System.Drawing.Point(67, 69);
			this.checkBox27.Name = "checkBox27";
			this.checkBox27.Size = new System.Drawing.Size(654, 33);
			this.checkBox27.TabIndex = 32;
			this.checkBox27.Text = "Signature Generation Primitive RSASP1 for Mod2048";
			this.checkBox27.UseVisualStyleBackColor = true;
			// 
			// RSA_ComponentTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(1064, 190);
			this.Controls.Add(this.groupBox6);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "RSA_ComponentTest";
			this.Text = "RSA - Component Test";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RSA_ComponentTest_FormClosing);
			this.Load += new System.EventHandler(this.RSA_ComponentTest_Load);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.CheckBox checkBox27;
	}
}