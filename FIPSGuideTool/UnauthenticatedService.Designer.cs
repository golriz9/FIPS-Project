namespace FIPSGuideTool
{
	partial class UnauthenticatedService
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnauthenticatedService));
			this.txtBox_UnauthenticatedServices = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_UnauthenticatedServices
			// 
			this.txtBox_UnauthenticatedServices.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_UnauthenticatedServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_UnauthenticatedServices.Location = new System.Drawing.Point(0, 0);
			this.txtBox_UnauthenticatedServices.Multiline = true;
			this.txtBox_UnauthenticatedServices.Name = "txtBox_UnauthenticatedServices";
			this.txtBox_UnauthenticatedServices.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_UnauthenticatedServices.Size = new System.Drawing.Size(978, 944);
			this.txtBox_UnauthenticatedServices.TabIndex = 0;
			// 
			// UnauthenticatedService
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.txtBox_UnauthenticatedServices);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UnauthenticatedService";
			this.Text = "Unauthenticated Service";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnauthenticatedService_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UnauthenticatedService_FormClosed);
			this.Load += new System.EventHandler(this.UnauthenticatedService_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_UnauthenticatedServices;
	}
}