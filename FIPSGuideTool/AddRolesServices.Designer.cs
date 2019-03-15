namespace FIPSGuideTool
{
	partial class AddRolesServices
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRolesServices));
			this.txtBox_RolesServicesList = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox_RolesServicesList
			// 
			this.txtBox_RolesServicesList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox_RolesServicesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_RolesServicesList.Location = new System.Drawing.Point(0, 0);
			this.txtBox_RolesServicesList.Multiline = true;
			this.txtBox_RolesServicesList.Name = "txtBox_RolesServicesList";
			this.txtBox_RolesServicesList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_RolesServicesList.Size = new System.Drawing.Size(978, 944);
			this.txtBox_RolesServicesList.TabIndex = 0;
			// 
			// AddRolesServices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 944);
			this.Controls.Add(this.txtBox_RolesServicesList);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AddRolesServices";
			this.Text = "Add Roles and Services";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddRolesServices_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddRolesServices_FormClosed);
			this.Load += new System.EventHandler(this.AddRolesServices_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox_RolesServicesList;
	}
}