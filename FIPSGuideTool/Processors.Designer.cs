namespace FIPSGuideTool
{
	partial class Processors
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Processors));
			this.txtBox_processors = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_processors
			// 
			this.txtBox_processors.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_processors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_processors.Location = new System.Drawing.Point(0, 0);
			this.txtBox_processors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtBox_processors.Multiline = true;
			this.txtBox_processors.Name = "txtBox_processors";
			this.txtBox_processors.Size = new System.Drawing.Size(978, 944);
			this.txtBox_processors.TabIndex = 0;
			this.txtBox_processors.TextChanged += new System.EventHandler(this.txtBox_processors_TextChanged);
			// 
			// Processors
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.txtBox_processors);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Processors";
			this.Text = "Processors";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Processors_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Processors_FormClosed);
			this.Load += new System.EventHandler(this.Processors_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_processors;
	}
}