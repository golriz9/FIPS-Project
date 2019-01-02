namespace FIPSGuideTool
{
	partial class FWVersion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FWVersion));
			this.txtBox_FWSVersion = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_FWSVersion
			// 
			this.txtBox_FWSVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_FWSVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_FWSVersion.Location = new System.Drawing.Point(0, 0);
			this.txtBox_FWSVersion.Margin = new System.Windows.Forms.Padding(6);
			this.txtBox_FWSVersion.Multiline = true;
			this.txtBox_FWSVersion.Name = "txtBox_FWSVersion";
			this.txtBox_FWSVersion.Size = new System.Drawing.Size(978, 944);
			this.txtBox_FWSVersion.TabIndex = 4;
			// 
			// FWVersion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.txtBox_FWSVersion);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FWVersion";
			this.Text = "FW Version";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FWVersion_FormClosed);
			this.Load += new System.EventHandler(this.FWVersion_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_FWSVersion;
	}
}