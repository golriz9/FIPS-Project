﻿namespace FIPSGuideTool
{
	partial class KeyList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyList));
			this.textBox_KeyList = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox_KeyList
			// 
			this.textBox_KeyList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_KeyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_KeyList.Location = new System.Drawing.Point(0, 0);
			this.textBox_KeyList.Multiline = true;
			this.textBox_KeyList.Name = "textBox_KeyList";
			this.textBox_KeyList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox_KeyList.Size = new System.Drawing.Size(678, 644);
			this.textBox_KeyList.TabIndex = 0;
			// 
			// KeyList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 644);
			this.Controls.Add(this.textBox_KeyList);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "KeyList";
			this.Text = "Cryptographic Key List";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KeyList_FormClosed);
			this.Load += new System.EventHandler(this.KeyList_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_KeyList;
	}
}