namespace FIPSGuideTool
{
	partial class nonApprovedRNG
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nonApprovedRNG));
			this.textBox_nonAppRNGFunc = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox_nonAppRNGFunc
			// 
			this.textBox_nonAppRNGFunc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_nonAppRNGFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_nonAppRNGFunc.Location = new System.Drawing.Point(0, 0);
			this.textBox_nonAppRNGFunc.Multiline = true;
			this.textBox_nonAppRNGFunc.Name = "textBox_nonAppRNGFunc";
			this.textBox_nonAppRNGFunc.Size = new System.Drawing.Size(678, 644);
			this.textBox_nonAppRNGFunc.TabIndex = 0;
			// 
			// nonApprovedRNG
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 644);
			this.Controls.Add(this.textBox_nonAppRNGFunc);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "nonApprovedRNG";
			this.Text = "nonApproved RNGs";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.nonApprovedRNG_FormClosed);
			this.Load += new System.EventHandler(this.nonApprovedRNG_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_nonAppRNGFunc;
	}
}