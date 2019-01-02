namespace FIPSGuideTool
{
	partial class AppKeyEstablishment
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppKeyEstablishment));
			this.textBox_AppKeyEstab = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox_AppKeyEstab
			// 
			this.textBox_AppKeyEstab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_AppKeyEstab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_AppKeyEstab.Location = new System.Drawing.Point(0, 0);
			this.textBox_AppKeyEstab.Multiline = true;
			this.textBox_AppKeyEstab.Name = "textBox_AppKeyEstab";
			this.textBox_AppKeyEstab.Size = new System.Drawing.Size(678, 644);
			this.textBox_AppKeyEstab.TabIndex = 0;
			// 
			// AppKeyEstablishment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 644);
			this.Controls.Add(this.textBox_AppKeyEstab);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AppKeyEstablishment";
			this.Text = "Approved Key Establishment";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppKeyEstablishment_FormClosed);
			this.Load += new System.EventHandler(this.AppKeyEstablishment_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_AppKeyEstab;
	}
}