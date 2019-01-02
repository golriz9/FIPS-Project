namespace FIPSGuideTool
{
	partial class RAM
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RAM));
			this.txtBox_RAM = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_RAM
			// 
			this.txtBox_RAM.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_RAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_RAM.Location = new System.Drawing.Point(0, 0);
			this.txtBox_RAM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtBox_RAM.Multiline = true;
			this.txtBox_RAM.Name = "txtBox_RAM";
			this.txtBox_RAM.Size = new System.Drawing.Size(978, 944);
			this.txtBox_RAM.TabIndex = 1;
			// 
			// RAM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.txtBox_RAM);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "RAM";
			this.Text = "RAM";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RAM_FormClosed);
			this.Load += new System.EventHandler(this.RAM_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_RAM;
	}
}