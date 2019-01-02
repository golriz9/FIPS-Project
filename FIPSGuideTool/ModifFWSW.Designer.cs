namespace FIPSGuideTool
{
	partial class ModifFWSW
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifFWSW));
			this.txtBox_ModFWSW = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_ModFWSW
			// 
			this.txtBox_ModFWSW.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_ModFWSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_ModFWSW.Location = new System.Drawing.Point(0, 0);
			this.txtBox_ModFWSW.Margin = new System.Windows.Forms.Padding(6);
			this.txtBox_ModFWSW.Multiline = true;
			this.txtBox_ModFWSW.Name = "txtBox_ModFWSW";
			this.txtBox_ModFWSW.Size = new System.Drawing.Size(978, 944);
			this.txtBox_ModFWSW.TabIndex = 6;
			this.txtBox_ModFWSW.TextChanged += new System.EventHandler(this.txtBox_ModFWSW_TextChanged);
			// 
			// ModifFWSW
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.txtBox_ModFWSW);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ModifFWSW";
			this.Text = "Modifiable FW/SW";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModifFWSW_FormClosed);
			this.Load += new System.EventHandler(this.ModifFWSW_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_ModFWSW;
	}
}