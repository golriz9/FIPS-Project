namespace FIPSGuideTool
{
	partial class ActiveComponents
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveComponents));
			this.txtBox_ActiveComponents = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_ActiveComponents
			// 
			this.txtBox_ActiveComponents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_ActiveComponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_ActiveComponents.Location = new System.Drawing.Point(0, 0);
			this.txtBox_ActiveComponents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtBox_ActiveComponents.Multiline = true;
			this.txtBox_ActiveComponents.Name = "txtBox_ActiveComponents";
			this.txtBox_ActiveComponents.Size = new System.Drawing.Size(978, 944);
			this.txtBox_ActiveComponents.TabIndex = 2;
			// 
			// ActiveComponents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.txtBox_ActiveComponents);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ActiveComponents";
			this.Text = "Active Components";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActiveComponents_FormClosed);
			this.Load += new System.EventHandler(this.ActiveComponents_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_ActiveComponents;
	}
}