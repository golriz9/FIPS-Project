namespace FIPSGuideTool
{
	partial class ROMFlash
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROMFlash));
			this.txtBox_ROMFlash = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_ROMFlash
			// 
			this.txtBox_ROMFlash.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_ROMFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_ROMFlash.Location = new System.Drawing.Point(0, 0);
			this.txtBox_ROMFlash.Margin = new System.Windows.Forms.Padding(5);
			this.txtBox_ROMFlash.Multiline = true;
			this.txtBox_ROMFlash.Name = "txtBox_ROMFlash";
			this.txtBox_ROMFlash.Size = new System.Drawing.Size(978, 944);
			this.txtBox_ROMFlash.TabIndex = 1;
			// 
			// ROMFlash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.txtBox_ROMFlash);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "ROMFlash";
			this.Text = "ROM or Flash";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ROMFlash_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ROMFlash_FormClosed);
			this.Load += new System.EventHandler(this.ROMFlash_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_ROMFlash;
	}
}