namespace FIPSGuideTool
{
	partial class KeyProtStratg
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyProtStratg));
			this.txtBox_CSPProtcStratg = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_CSPProtcStratg
			// 
			this.txtBox_CSPProtcStratg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_CSPProtcStratg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_CSPProtcStratg.Location = new System.Drawing.Point(0, 0);
			this.txtBox_CSPProtcStratg.Multiline = true;
			this.txtBox_CSPProtcStratg.Name = "txtBox_CSPProtcStratg";
			this.txtBox_CSPProtcStratg.Size = new System.Drawing.Size(678, 644);
			this.txtBox_CSPProtcStratg.TabIndex = 0;
			// 
			// KeyProtStratg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(678, 644);
			this.Controls.Add(this.txtBox_CSPProtcStratg);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "KeyProtStratg";
			this.Text = "Key and CSP Protection Strategies";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeyProtStratg_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KeyProtStratg_FormClosed);
			this.Load += new System.EventHandler(this.KeyProtStratg_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox txtBox_CSPProtcStratg;
	}
}