namespace FIPSGuideTool
{
	partial class nonModifFWSW
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nonModifFWSW));
			this.txtBox_nonModFWSW = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_nonModFWSW
			// 
			this.txtBox_nonModFWSW.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_nonModFWSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_nonModFWSW.Location = new System.Drawing.Point(0, 0);
			this.txtBox_nonModFWSW.Margin = new System.Windows.Forms.Padding(5);
			this.txtBox_nonModFWSW.Multiline = true;
			this.txtBox_nonModFWSW.Name = "txtBox_nonModFWSW";
			this.txtBox_nonModFWSW.Size = new System.Drawing.Size(978, 944);
			this.txtBox_nonModFWSW.TabIndex = 3;
			// 
			// nonModifFWSW
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.txtBox_nonModFWSW);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "nonModifFWSW";
			this.Text = "Non-Modifiable FW/SW";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.nonModifFWSW_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.nonModifFWSW_FormClosed);
			this.Load += new System.EventHandler(this.nonModifFWSW_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_nonModFWSW;
	}
}