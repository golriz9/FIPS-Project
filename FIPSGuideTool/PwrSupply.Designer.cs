namespace FIPSGuideTool
{
	partial class PwrSupply
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PwrSupply));
			this.txtBox_PwrSupply = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_PwrSupply
			// 
			this.txtBox_PwrSupply.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_PwrSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_PwrSupply.Location = new System.Drawing.Point(0, 0);
			this.txtBox_PwrSupply.Margin = new System.Windows.Forms.Padding(6);
			this.txtBox_PwrSupply.Multiline = true;
			this.txtBox_PwrSupply.Name = "txtBox_PwrSupply";
			this.txtBox_PwrSupply.Size = new System.Drawing.Size(978, 944);
			this.txtBox_PwrSupply.TabIndex = 6;
			// 
			// PwrSupply
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.txtBox_PwrSupply);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "PwrSupply";
			this.Text = "Power Supply";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PwrSupply_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PwrSupply_FormClosed);
			this.Load += new System.EventHandler(this.PwrSupply_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_PwrSupply;
	}
}