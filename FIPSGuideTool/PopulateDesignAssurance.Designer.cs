namespace FIPSGuideTool
{
	partial class PopulateDesignAssurance
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopulateDesignAssurance));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_DesAssurTEs = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel1.Controls.Add(this.btn_DesAssurTEs);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1086, 272);
			this.panel1.TabIndex = 0;
			// 
			// btn_DesAssurTEs
			// 
			this.btn_DesAssurTEs.BackColor = System.Drawing.Color.Gray;
			this.btn_DesAssurTEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DesAssurTEs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_DesAssurTEs.Location = new System.Drawing.Point(750, 117);
			this.btn_DesAssurTEs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_DesAssurTEs.Name = "btn_DesAssurTEs";
			this.btn_DesAssurTEs.Size = new System.Drawing.Size(309, 134);
			this.btn_DesAssurTEs.TabIndex = 84;
			this.btn_DesAssurTEs.Text = "A10. Design Assurance";
			this.btn_DesAssurTEs.UseVisualStyleBackColor = false;
			this.btn_DesAssurTEs.Click += new System.EventHandler(this.btn_DesAssurTEs_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(690, 87);
			this.label1.TabIndex = 1;
			this.label1.Text = "The assessments for Area 10 was populated successfully. \r\n\r\nClick below to see th" +
    "e responses.";
			// 
			// PopulateDesignAssurance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(1110, 296);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PopulateDesignAssurance";
			this.Text = "Area 10 was populated";
			this.Load += new System.EventHandler(this.PopulateDesignAssurance_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btn_DesAssurTEs;
	}
}