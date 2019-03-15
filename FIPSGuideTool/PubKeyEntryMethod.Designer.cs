namespace FIPSGuideTool
{
	partial class PubKeyEntryMethod
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PubKeyEntryMethod));
			this.txtBox_PubKeyEntryMethod = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_PubKeyEntryMethod
			// 
			this.txtBox_PubKeyEntryMethod.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_PubKeyEntryMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_PubKeyEntryMethod.Location = new System.Drawing.Point(0, 0);
			this.txtBox_PubKeyEntryMethod.Multiline = true;
			this.txtBox_PubKeyEntryMethod.Name = "txtBox_PubKeyEntryMethod";
			this.txtBox_PubKeyEntryMethod.Size = new System.Drawing.Size(678, 644);
			this.txtBox_PubKeyEntryMethod.TabIndex = 0;
			// 
			// PubKeyEntryMethod
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 644);
			this.Controls.Add(this.txtBox_PubKeyEntryMethod);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PubKeyEntryMethod";
			this.Text = "Public Key Entry Methods";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PubKeyEntryMethod_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PubKeyEntryMethod_FormClosed);
			this.Load += new System.EventHandler(this.PubKeyEntryMethod_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_PubKeyEntryMethod;
	}
}