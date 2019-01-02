namespace FIPSGuideTool
{
	partial class PopulateMitigation
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopulateMitigation));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_MitOtherAttackTEs = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel1.Controls.Add(this.btn_MitOtherAttackTEs);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1086, 272);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(690, 87);
			this.label1.TabIndex = 1;
			this.label1.Text = "The assessments for Area 11 was populated successfully. \r\n\r\nClick below to see th" +
    "e responses.";
			// 
			// btn_MitOtherAttackTEs
			// 
			this.btn_MitOtherAttackTEs.BackColor = System.Drawing.Color.Gray;
			this.btn_MitOtherAttackTEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_MitOtherAttackTEs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_MitOtherAttackTEs.Location = new System.Drawing.Point(750, 117);
			this.btn_MitOtherAttackTEs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_MitOtherAttackTEs.Name = "btn_MitOtherAttackTEs";
			this.btn_MitOtherAttackTEs.Size = new System.Drawing.Size(309, 134);
			this.btn_MitOtherAttackTEs.TabIndex = 85;
			this.btn_MitOtherAttackTEs.Text = "A11. Mitigation of Other Attacks";
			this.btn_MitOtherAttackTEs.UseVisualStyleBackColor = false;
			this.btn_MitOtherAttackTEs.Click += new System.EventHandler(this.btn_MitOtherAttackTEs_Click);
			// 
			// PopulateMitigation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(1110, 296);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PopulateMitigation";
			this.Text = "Area 11 was populated";
			this.Load += new System.EventHandler(this.PopulateMitigation_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btn_MitOtherAttackTEs;
	}
}