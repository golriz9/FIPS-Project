namespace FIPSGuideTool
{
	partial class SelfTests
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelfTests));
			this.Algorithms = new System.Windows.Forms.TabPage();
			this.dataGridView_SelfTests = new System.Windows.Forms.DataGridView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Algorithms.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_SelfTests)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Algorithms
			// 
			this.Algorithms.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.Algorithms.Controls.Add(this.dataGridView_SelfTests);
			this.Algorithms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Algorithms.Location = new System.Drawing.Point(4, 41);
			this.Algorithms.Name = "Algorithms";
			this.Algorithms.Padding = new System.Windows.Forms.Padding(3);
			this.Algorithms.Size = new System.Drawing.Size(2403, 1484);
			this.Algorithms.TabIndex = 0;
			this.Algorithms.Text = "Algorithms";
			this.Algorithms.Click += new System.EventHandler(this.Algorithms1_Click);
			// 
			// dataGridView_SelfTests
			// 
			this.dataGridView_SelfTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_SelfTests.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_SelfTests.Location = new System.Drawing.Point(3, 3);
			this.dataGridView_SelfTests.Name = "dataGridView_SelfTests";
			this.dataGridView_SelfTests.RowTemplate.Height = 28;
			this.dataGridView_SelfTests.Size = new System.Drawing.Size(2397, 1478);
			this.dataGridView_SelfTests.TabIndex = 2;
			this.dataGridView_SelfTests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SelfTests_CellContentClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.Algorithms);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(2411, 1529);
			this.tabControl1.TabIndex = 31;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// SelfTests
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(2411, 1529);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "SelfTests";
			this.Text = "Self Tests";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelfTests_FormClosing);
			this.Load += new System.EventHandler(this.SelfTests_Load);
			this.Algorithms.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_SelfTests)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage Algorithms;
		private System.Windows.Forms.DataGridView dataGridView_SelfTests;
		private System.Windows.Forms.TabControl tabControl1;
	}
}