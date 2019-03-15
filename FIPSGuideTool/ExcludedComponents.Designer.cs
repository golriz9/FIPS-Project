namespace FIPSGuideTool
{
	partial class ExcludedComponents
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcludedComponents));
			this.txtBox_ExComp = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_ExComp
			// 
			this.txtBox_ExComp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_ExComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_ExComp.Location = new System.Drawing.Point(0, 0);
			this.txtBox_ExComp.Multiline = true;
			this.txtBox_ExComp.Name = "txtBox_ExComp";
			this.txtBox_ExComp.Size = new System.Drawing.Size(978, 944);
			this.txtBox_ExComp.TabIndex = 0;
			// 
			// ExcludedComponents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.txtBox_ExComp);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ExcludedComponents";
			this.Text = "Excluded Components";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExcludedComponents_FormClosing);
			this.Load += new System.EventHandler(this.ExcludedComponents_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox txtBox_ExComp;
	}
}