namespace FIPSGuideTool
{
	partial class ModuleInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleInfo));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_SaveData = new System.Windows.Forms.Button();
			this.txt_LabInternalID = new System.Windows.Forms.TextBox();
			this.txt_Addr1 = new System.Windows.Forms.TextBox();
			this.txt_Addr2 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lab Internal ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(173, 29);
			this.label2.TabIndex = 0;
			this.label2.Text = "Address Line 1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(173, 29);
			this.label3.TabIndex = 0;
			this.label3.Text = "Address Line 2";
			// 
			// btn_SaveData
			// 
			this.btn_SaveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_SaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_SaveData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_SaveData.Location = new System.Drawing.Point(617, 451);
			this.btn_SaveData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_SaveData.Name = "btn_SaveData";
			this.btn_SaveData.Size = new System.Drawing.Size(169, 62);
			this.btn_SaveData.TabIndex = 1;
			this.btn_SaveData.Text = "Ok";
			this.btn_SaveData.UseVisualStyleBackColor = false;
			this.btn_SaveData.Click += new System.EventHandler(this.btn_SaveData_Click);
			// 
			// txt_LabInternalID
			// 
			this.txt_LabInternalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_LabInternalID.Location = new System.Drawing.Point(258, 28);
			this.txt_LabInternalID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_LabInternalID.Name = "txt_LabInternalID";
			this.txt_LabInternalID.Size = new System.Drawing.Size(446, 35);
			this.txt_LabInternalID.TabIndex = 2;
			// 
			// txt_Addr1
			// 
			this.txt_Addr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Addr1.Location = new System.Drawing.Point(258, 82);
			this.txt_Addr1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Addr1.Name = "txt_Addr1";
			this.txt_Addr1.Size = new System.Drawing.Size(446, 35);
			this.txt_Addr1.TabIndex = 2;
			// 
			// txt_Addr2
			// 
			this.txt_Addr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Addr2.Location = new System.Drawing.Point(258, 132);
			this.txt_Addr2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Addr2.Name = "txt_Addr2";
			this.txt_Addr2.Size = new System.Drawing.Size(446, 35);
			this.txt_Addr2.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel1.Controls.Add(this.txt_Addr2);
			this.panel1.Controls.Add(this.txt_Addr1);
			this.panel1.Controls.Add(this.txt_LabInternalID);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(774, 397);
			this.panel1.TabIndex = 29;
			// 
			// ModuleInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(798, 779);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_SaveData);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ModuleInfo";
			this.Text = "Module Info";
			this.Load += new System.EventHandler(this.VendorInfo_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_SaveData;
		private System.Windows.Forms.TextBox txt_LabInternalID;
		private System.Windows.Forms.TextBox txt_Addr1;
		private System.Windows.Forms.TextBox txt_Addr2;
		private System.Windows.Forms.Panel panel1;
	}
}