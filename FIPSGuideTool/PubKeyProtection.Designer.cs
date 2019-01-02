namespace FIPSGuideTool
{
	partial class PubKeyProtection
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PubKeyProtection));
			this.txtBox_PubKeyProtect = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_PubKeyProtect
			// 
			this.txtBox_PubKeyProtect.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_PubKeyProtect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_PubKeyProtect.Location = new System.Drawing.Point(0, 0);
			this.txtBox_PubKeyProtect.Multiline = true;
			this.txtBox_PubKeyProtect.Name = "txtBox_PubKeyProtect";
			this.txtBox_PubKeyProtect.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_PubKeyProtect.Size = new System.Drawing.Size(678, 644);
			this.txtBox_PubKeyProtect.TabIndex = 0;
			// 
			// PubKeyProtection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(678, 644);
			this.Controls.Add(this.txtBox_PubKeyProtect);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PubKeyProtection";
			this.Text = "Public Keys Protection";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PubKeyProtection_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PubKeyProtection_FormClosed);
			this.Load += new System.EventHandler(this.PubKeyProtection_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_PubKeyProtect;
	}
}