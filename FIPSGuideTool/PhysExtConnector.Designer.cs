namespace FIPSGuideTool
{
	partial class PhysExtConnector
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhysExtConnector));
			this.txtBox_PhysExtConnector = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_PhysExtConnector
			// 
			this.txtBox_PhysExtConnector.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_PhysExtConnector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_PhysExtConnector.Location = new System.Drawing.Point(0, 0);
			this.txtBox_PhysExtConnector.Margin = new System.Windows.Forms.Padding(6);
			this.txtBox_PhysExtConnector.Multiline = true;
			this.txtBox_PhysExtConnector.Name = "txtBox_PhysExtConnector";
			this.txtBox_PhysExtConnector.Size = new System.Drawing.Size(978, 944);
			this.txtBox_PhysExtConnector.TabIndex = 6;
			// 
			// PhysExtConnector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.txtBox_PhysExtConnector);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "PhysExtConnector";
			this.Text = "Physical External Connector";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PhysExtConnector_FormClosed);
			this.Load += new System.EventHandler(this.PhysExtConnector_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_PhysExtConnector;
	}
}