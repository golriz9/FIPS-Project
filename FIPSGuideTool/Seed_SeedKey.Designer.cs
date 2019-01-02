namespace FIPSGuideTool
{
	partial class Seed_SeedKey
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seed_SeedKey));
			this.textBox_SeedKey = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_Seed = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox_SeedKey
			// 
			this.textBox_SeedKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_SeedKey.Location = new System.Drawing.Point(467, 136);
			this.textBox_SeedKey.Multiline = true;
			this.textBox_SeedKey.Name = "textBox_SeedKey";
			this.textBox_SeedKey.Size = new System.Drawing.Size(298, 64);
			this.textBox_SeedKey.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(51, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Seed Length:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(51, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(219, 29);
			this.label2.TabIndex = 3;
			this.label2.Text = "Seed Key Length:";
			// 
			// textBox_Seed
			// 
			this.textBox_Seed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Seed.Location = new System.Drawing.Point(467, 39);
			this.textBox_Seed.Multiline = true;
			this.textBox_Seed.Name = "textBox_Seed";
			this.textBox_Seed.Size = new System.Drawing.Size(298, 64);
			this.textBox_Seed.TabIndex = 4;
			// 
			// Seed_SeedKey
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(867, 260);
			this.Controls.Add(this.textBox_Seed);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_SeedKey);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Seed_SeedKey";
			this.Text = "Seed and Seed Key Lengths";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Seed_SeedKey_FormClosed);
			this.Load += new System.EventHandler(this.Seed_SeedKey_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox_SeedKey;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_Seed;
	}
}