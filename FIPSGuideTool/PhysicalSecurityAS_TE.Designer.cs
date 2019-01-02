namespace FIPSGuideTool
{
	partial class PhysicalSecurityAS_TE
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhysicalSecurityAS_TE));
			this.dataGridView_ASTE = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_ASTE)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_ASTE
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_ASTE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_ASTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_ASTE.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_ASTE.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_ASTE.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_ASTE.Name = "dataGridView_ASTE";
			this.dataGridView_ASTE.RowTemplate.Height = 28;
			this.dataGridView_ASTE.Size = new System.Drawing.Size(1924, 1050);
			this.dataGridView_ASTE.TabIndex = 0;
			this.dataGridView_ASTE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ASTE_CellContentClick);
			this.dataGridView_ASTE.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ASTE_CellMouseDown);
			// 
			// PhysicalSecurityAS_TE
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(1924, 1050);
			this.Controls.Add(this.dataGridView_ASTE);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PhysicalSecurityAS_TE";
			this.Text = "Physical Security Assertions and TEs";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhysicalSecurityAS_TE_FormClosing);
			this.Load += new System.EventHandler(this.PhysicalSecurityAS_TE_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_ASTE)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_ASTE;
	}
}