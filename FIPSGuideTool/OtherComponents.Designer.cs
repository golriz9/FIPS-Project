namespace FIPSGuideTool
{
	partial class OtherComponents
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherComponents));
			this.txtBox_otherComponents = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_otherComponents
			// 
			this.txtBox_otherComponents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_otherComponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_otherComponents.Location = new System.Drawing.Point(0, 0);
			this.txtBox_otherComponents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtBox_otherComponents.Multiline = true;
			this.txtBox_otherComponents.Name = "txtBox_otherComponents";
			this.txtBox_otherComponents.Size = new System.Drawing.Size(978, 944);
			this.txtBox_otherComponents.TabIndex = 0;
			// 
			// OtherComponents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.txtBox_otherComponents);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "OtherComponents";
			this.Text = "Other Components";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OtherComponents_FormClosing);
			this.Load += new System.EventHandler(this.OtherComponents_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_otherComponents;
	}
}