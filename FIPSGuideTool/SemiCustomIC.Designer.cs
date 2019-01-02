namespace FIPSGuideTool
{
	partial class SemiCustomIC
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SemiCustomIC));
			this.txtBox_SemiCustomIC = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_SemiCustomIC
			// 
			this.txtBox_SemiCustomIC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_SemiCustomIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_SemiCustomIC.Location = new System.Drawing.Point(0, 0);
			this.txtBox_SemiCustomIC.Margin = new System.Windows.Forms.Padding(6);
			this.txtBox_SemiCustomIC.Multiline = true;
			this.txtBox_SemiCustomIC.Name = "txtBox_SemiCustomIC";
			this.txtBox_SemiCustomIC.Size = new System.Drawing.Size(978, 944);
			this.txtBox_SemiCustomIC.TabIndex = 5;
			// 
			// SemiCustomIC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.txtBox_SemiCustomIC);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "SemiCustomIC";
			this.Text = "Semi-Custom IC";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SemiCustomIC_FormClosed);
			this.Load += new System.EventHandler(this.SemiCustomIC_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_SemiCustomIC;
	}
}