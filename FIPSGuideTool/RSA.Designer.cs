namespace FIPSGuideTool
{
	partial class RSA
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSA));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_RSA_CompTest = new System.Windows.Forms.Button();
			this.btn_RSA_SigGenPSS = new System.Windows.Forms.Button();
			this.btn_RSA_SigGen = new System.Windows.Forms.Button();
			this.btn_RSA_SigVerPKCS = new System.Windows.Forms.Button();
			this.btn_RSA_SigVerPSS = new System.Windows.Forms.Button();
			this.btn_RSA_SigGenPKCS = new System.Windows.Forms.Button();
			this.btn_RSA_IFC_Key_Gen = new System.Windows.Forms.Button();
			this.btn_RSA_LegTests = new System.Windows.Forms.Button();
			this.btn_RSA_SigVer = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel1.Controls.Add(this.btn_RSA_CompTest);
			this.panel1.Controls.Add(this.btn_RSA_SigGenPSS);
			this.panel1.Controls.Add(this.btn_RSA_SigGen);
			this.panel1.Controls.Add(this.btn_RSA_SigVerPKCS);
			this.panel1.Controls.Add(this.btn_RSA_SigVerPSS);
			this.panel1.Controls.Add(this.btn_RSA_SigGenPKCS);
			this.panel1.Controls.Add(this.btn_RSA_IFC_Key_Gen);
			this.panel1.Controls.Add(this.btn_RSA_LegTests);
			this.panel1.Controls.Add(this.btn_RSA_SigVer);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1232, 663);
			this.panel1.TabIndex = 91;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btn_RSA_CompTest
			// 
			this.btn_RSA_CompTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_RSA_CompTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_RSA_CompTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_RSA_CompTest.Location = new System.Drawing.Point(32, 454);
			this.btn_RSA_CompTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_RSA_CompTest.Name = "btn_RSA_CompTest";
			this.btn_RSA_CompTest.Size = new System.Drawing.Size(335, 165);
			this.btn_RSA_CompTest.TabIndex = 98;
			this.btn_RSA_CompTest.Text = "Component Test";
			this.btn_RSA_CompTest.UseVisualStyleBackColor = false;
			this.btn_RSA_CompTest.Click += new System.EventHandler(this.btn_RSA_CompTest_Click);
			// 
			// btn_RSA_SigGenPSS
			// 
			this.btn_RSA_SigGenPSS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_RSA_SigGenPSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_RSA_SigGenPSS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_RSA_SigGenPSS.Location = new System.Drawing.Point(445, 454);
			this.btn_RSA_SigGenPSS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_RSA_SigGenPSS.Name = "btn_RSA_SigGenPSS";
			this.btn_RSA_SigGenPSS.Size = new System.Drawing.Size(335, 165);
			this.btn_RSA_SigGenPSS.TabIndex = 97;
			this.btn_RSA_SigGenPSS.Text = "Signature Generation PSS";
			this.btn_RSA_SigGenPSS.UseVisualStyleBackColor = false;
			this.btn_RSA_SigGenPSS.Click += new System.EventHandler(this.btn_RSA_SigGenPSS_Click);
			// 
			// btn_RSA_SigGen
			// 
			this.btn_RSA_SigGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_RSA_SigGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_RSA_SigGen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_RSA_SigGen.Location = new System.Drawing.Point(445, 44);
			this.btn_RSA_SigGen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_RSA_SigGen.Name = "btn_RSA_SigGen";
			this.btn_RSA_SigGen.Size = new System.Drawing.Size(335, 165);
			this.btn_RSA_SigGen.TabIndex = 96;
			this.btn_RSA_SigGen.Text = "Signature Generation";
			this.btn_RSA_SigGen.UseVisualStyleBackColor = false;
			this.btn_RSA_SigGen.Click += new System.EventHandler(this.btn_RSA_SigGen_Click);
			// 
			// btn_RSA_SigVerPKCS
			// 
			this.btn_RSA_SigVerPKCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_RSA_SigVerPKCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_RSA_SigVerPKCS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_RSA_SigVerPKCS.Location = new System.Drawing.Point(858, 249);
			this.btn_RSA_SigVerPKCS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_RSA_SigVerPKCS.Name = "btn_RSA_SigVerPKCS";
			this.btn_RSA_SigVerPKCS.Size = new System.Drawing.Size(335, 165);
			this.btn_RSA_SigVerPKCS.TabIndex = 95;
			this.btn_RSA_SigVerPKCS.Text = "Signature Verification PKCS";
			this.btn_RSA_SigVerPKCS.UseVisualStyleBackColor = false;
			this.btn_RSA_SigVerPKCS.Click += new System.EventHandler(this.btn_RSA_SigVerPKCS_Click);
			// 
			// btn_RSA_SigVerPSS
			// 
			this.btn_RSA_SigVerPSS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_RSA_SigVerPSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_RSA_SigVerPSS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_RSA_SigVerPSS.Location = new System.Drawing.Point(858, 454);
			this.btn_RSA_SigVerPSS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_RSA_SigVerPSS.Name = "btn_RSA_SigVerPSS";
			this.btn_RSA_SigVerPSS.Size = new System.Drawing.Size(335, 165);
			this.btn_RSA_SigVerPSS.TabIndex = 94;
			this.btn_RSA_SigVerPSS.Text = "Signature Verification PSS";
			this.btn_RSA_SigVerPSS.UseVisualStyleBackColor = false;
			this.btn_RSA_SigVerPSS.Click += new System.EventHandler(this.btn_RSA_SigVerPSS_Click);
			// 
			// btn_RSA_SigGenPKCS
			// 
			this.btn_RSA_SigGenPKCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_RSA_SigGenPKCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_RSA_SigGenPKCS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_RSA_SigGenPKCS.Location = new System.Drawing.Point(445, 249);
			this.btn_RSA_SigGenPKCS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_RSA_SigGenPKCS.Name = "btn_RSA_SigGenPKCS";
			this.btn_RSA_SigGenPKCS.Size = new System.Drawing.Size(335, 165);
			this.btn_RSA_SigGenPKCS.TabIndex = 93;
			this.btn_RSA_SigGenPKCS.Text = "Signature Generation PKCS";
			this.btn_RSA_SigGenPKCS.UseVisualStyleBackColor = false;
			this.btn_RSA_SigGenPKCS.Click += new System.EventHandler(this.btn_RSA_SigGenPKCS_Click);
			// 
			// btn_RSA_IFC_Key_Gen
			// 
			this.btn_RSA_IFC_Key_Gen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_RSA_IFC_Key_Gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_RSA_IFC_Key_Gen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_RSA_IFC_Key_Gen.Location = new System.Drawing.Point(32, 44);
			this.btn_RSA_IFC_Key_Gen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_RSA_IFC_Key_Gen.Name = "btn_RSA_IFC_Key_Gen";
			this.btn_RSA_IFC_Key_Gen.Size = new System.Drawing.Size(335, 165);
			this.btn_RSA_IFC_Key_Gen.TabIndex = 92;
			this.btn_RSA_IFC_Key_Gen.Text = "IFC Key Generation";
			this.btn_RSA_IFC_Key_Gen.UseVisualStyleBackColor = false;
			this.btn_RSA_IFC_Key_Gen.Click += new System.EventHandler(this.btn_IFC_Key_Gen_Click);
			// 
			// btn_RSA_LegTests
			// 
			this.btn_RSA_LegTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_RSA_LegTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_RSA_LegTests.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_RSA_LegTests.Location = new System.Drawing.Point(32, 249);
			this.btn_RSA_LegTests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_RSA_LegTests.Name = "btn_RSA_LegTests";
			this.btn_RSA_LegTests.Size = new System.Drawing.Size(335, 165);
			this.btn_RSA_LegTests.TabIndex = 91;
			this.btn_RSA_LegTests.Text = "186-2 Legacy Tests";
			this.btn_RSA_LegTests.UseVisualStyleBackColor = false;
			this.btn_RSA_LegTests.Click += new System.EventHandler(this.btn_RSA_LegTests_Click);
			// 
			// btn_RSA_SigVer
			// 
			this.btn_RSA_SigVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_RSA_SigVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_RSA_SigVer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_RSA_SigVer.Location = new System.Drawing.Point(858, 44);
			this.btn_RSA_SigVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_RSA_SigVer.Name = "btn_RSA_SigVer";
			this.btn_RSA_SigVer.Size = new System.Drawing.Size(335, 165);
			this.btn_RSA_SigVer.TabIndex = 90;
			this.btn_RSA_SigVer.Text = "Signature Verification";
			this.btn_RSA_SigVer.UseVisualStyleBackColor = false;
			this.btn_RSA_SigVer.Click += new System.EventHandler(this.btn_RSA_SigVer_Click);
			// 
			// RSA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(1256, 687);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "RSA";
			this.Text = "RSA";
			this.Load += new System.EventHandler(this.RSA_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_RSA_CompTest;
		private System.Windows.Forms.Button btn_RSA_SigGenPSS;
		private System.Windows.Forms.Button btn_RSA_SigGen;
		private System.Windows.Forms.Button btn_RSA_SigVerPKCS;
		private System.Windows.Forms.Button btn_RSA_SigVerPSS;
		private System.Windows.Forms.Button btn_RSA_SigGenPKCS;
		private System.Windows.Forms.Button btn_RSA_IFC_Key_Gen;
		private System.Windows.Forms.Button btn_RSA_LegTests;
		private System.Windows.Forms.Button btn_RSA_SigVer;
	}
}