namespace FIPSGuideTool
{
	partial class FullyCustomIC
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullyCustomIC));
			this.txtBox_FullyCustomIC = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_FullyCustomIC
			// 
			this.txtBox_FullyCustomIC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_FullyCustomIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_FullyCustomIC.Location = new System.Drawing.Point(0, 0);
			this.txtBox_FullyCustomIC.Margin = new System.Windows.Forms.Padding(6);
			this.txtBox_FullyCustomIC.Multiline = true;
			this.txtBox_FullyCustomIC.Name = "txtBox_FullyCustomIC";
			this.txtBox_FullyCustomIC.Size = new System.Drawing.Size(978, 944);
			this.txtBox_FullyCustomIC.TabIndex = 5;
			// 
			// FullyCustomIC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.txtBox_FullyCustomIC);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FullyCustomIC";
			this.Text = "Fully Custom IC";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FullyCustomIC_FormClosed);
			this.Load += new System.EventHandler(this.FullyCustomIC_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_FullyCustomIC;
	}
}