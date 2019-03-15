namespace FIPSGuideTool
{
	partial class KeyEstabSec
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyEstabSec));
			this.textBox_KeyEstabSecurity = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox_KeyEstabSecurity
			// 
			this.textBox_KeyEstabSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_KeyEstabSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_KeyEstabSecurity.Location = new System.Drawing.Point(0, 0);
			this.textBox_KeyEstabSecurity.Multiline = true;
			this.textBox_KeyEstabSecurity.Name = "textBox_KeyEstabSecurity";
			this.textBox_KeyEstabSecurity.Size = new System.Drawing.Size(678, 644);
			this.textBox_KeyEstabSecurity.TabIndex = 0;
			// 
			// KeyEstabSec
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 644);
			this.Controls.Add(this.textBox_KeyEstabSecurity);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "KeyEstabSec";
			this.Text = "Key Establishment Security";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeyEstabSec_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KeyEstabSec_FormClosed);
			this.Load += new System.EventHandler(this.KeyEstabSec_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_KeyEstabSecurity;
	}
}