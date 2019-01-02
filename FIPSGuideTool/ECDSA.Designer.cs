namespace FIPSGuideTool
{
	partial class ECDSA
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECDSA));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Sig_Ver = new System.Windows.Forms.Button();
			this.btn_Sig_Gen = new System.Windows.Forms.Button();
			this.btn_KeyPairGen = new System.Windows.Forms.Button();
			this.btn_PKV = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel1.Controls.Add(this.btn_Sig_Ver);
			this.panel1.Controls.Add(this.btn_Sig_Gen);
			this.panel1.Controls.Add(this.btn_KeyPairGen);
			this.panel1.Controls.Add(this.btn_PKV);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 426);
			this.panel1.TabIndex = 90;
			// 
			// btn_Sig_Ver
			// 
			this.btn_Sig_Ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_Sig_Ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Sig_Ver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_Sig_Ver.Location = new System.Drawing.Point(81, 219);
			this.btn_Sig_Ver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_Sig_Ver.Name = "btn_Sig_Ver";
			this.btn_Sig_Ver.Size = new System.Drawing.Size(289, 119);
			this.btn_Sig_Ver.TabIndex = 93;
			this.btn_Sig_Ver.Text = "Signature Verification";
			this.btn_Sig_Ver.UseVisualStyleBackColor = false;
			this.btn_Sig_Ver.Click += new System.EventHandler(this.btn_Sig_Ver_Click);
			// 
			// btn_Sig_Gen
			// 
			this.btn_Sig_Gen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_Sig_Gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Sig_Gen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_Sig_Gen.Location = new System.Drawing.Point(81, 90);
			this.btn_Sig_Gen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_Sig_Gen.Name = "btn_Sig_Gen";
			this.btn_Sig_Gen.Size = new System.Drawing.Size(289, 119);
			this.btn_Sig_Gen.TabIndex = 92;
			this.btn_Sig_Gen.Text = "Signature Generation";
			this.btn_Sig_Gen.UseVisualStyleBackColor = false;
			this.btn_Sig_Gen.Click += new System.EventHandler(this.btn_Sig_Gen_Click);
			// 
			// btn_KeyPairGen
			// 
			this.btn_KeyPairGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_KeyPairGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_KeyPairGen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_KeyPairGen.Location = new System.Drawing.Point(406, 90);
			this.btn_KeyPairGen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_KeyPairGen.Name = "btn_KeyPairGen";
			this.btn_KeyPairGen.Size = new System.Drawing.Size(289, 119);
			this.btn_KeyPairGen.TabIndex = 91;
			this.btn_KeyPairGen.Text = "Key-pair Generation";
			this.btn_KeyPairGen.UseVisualStyleBackColor = false;
			this.btn_KeyPairGen.Click += new System.EventHandler(this.btn_KeyPairGen_Click_1);
			// 
			// btn_PKV
			// 
			this.btn_PKV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_PKV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_PKV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_PKV.Location = new System.Drawing.Point(406, 219);
			this.btn_PKV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_PKV.Name = "btn_PKV";
			this.btn_PKV.Size = new System.Drawing.Size(289, 119);
			this.btn_PKV.TabIndex = 90;
			this.btn_PKV.Text = "Public Key Validity";
			this.btn_PKV.UseVisualStyleBackColor = false;
			this.btn_PKV.Click += new System.EventHandler(this.btn_PKV_Click);
			// 
			// ECDSA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ECDSA";
			this.Text = "ECDSA";
			this.Load += new System.EventHandler(this.ECDSA_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Sig_Ver;
		private System.Windows.Forms.Button btn_Sig_Gen;
		private System.Windows.Forms.Button btn_KeyPairGen;
		private System.Windows.Forms.Button btn_PKV;
	}
}