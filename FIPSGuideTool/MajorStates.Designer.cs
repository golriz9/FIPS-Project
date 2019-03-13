namespace FIPSGuideTool
{
	partial class MajorStates
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MajorStates));
			this.MjrStates = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// MjrStates
			// 
			this.MjrStates.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MjrStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MjrStates.Location = new System.Drawing.Point(0, 0);
			this.MjrStates.Multiline = true;
			this.MjrStates.Name = "MjrStates";
			this.MjrStates.Size = new System.Drawing.Size(978, 944);
			this.MjrStates.TabIndex = 0;
			// 
			// MajorStates
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.MjrStates);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MajorStates";
			this.Text = "MajorStates";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MajorStates_FormClosing);
			this.Load += new System.EventHandler(this.MajorStates_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox MjrStates;
	}
}