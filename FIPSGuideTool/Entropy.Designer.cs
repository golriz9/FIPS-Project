namespace FIPSGuideTool
{
	partial class Entropy
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entropy));
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBoxTE071301 = new System.Windows.Forms.TextBox();
			this.btn_refresh = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.comboBox_FullEntropyOutput = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtBox_MaxEntropy = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtBox_MinEntropy = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.comboBox_Standard = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtBox_DRBGOutputLength = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.btn_TE071301 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.comboBox_DerivFunc = new System.Windows.Forms.ComboBox();
			this.comboBox_DRBG_Type = new System.Windows.Forms.ComboBox();
			this.txtBox_AlgDRBGDepends = new System.Windows.Forms.TextBox();
			this.txtBox_NoBitsPersonalStr = new System.Windows.Forms.TextBox();
			this.txtBox_NoBitsAdditInput = new System.Windows.Forms.TextBox();
			this.txtBox_NoBitsNonce = new System.Windows.Forms.TextBox();
			this.txtBox_NoBitsEntropyInput = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBox_NoBitsGenNDRNG = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.textBoxTE071301);
			this.panel1.Controls.Add(this.btn_refresh);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.btn_TE071301);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1924, 1050);
			this.panel1.TabIndex = 0;
			// 
			// textBoxTE071301
			// 
			this.textBoxTE071301.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTE071301.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTE071301.Location = new System.Drawing.Point(13, 621);
			this.textBoxTE071301.Multiline = true;
			this.textBoxTE071301.Name = "textBoxTE071301";
			this.textBoxTE071301.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxTE071301.Size = new System.Drawing.Size(1900, 417);
			this.textBoxTE071301.TabIndex = 94;
			this.textBoxTE071301.UseWaitCursor = true;
			this.textBoxTE071301.TextChanged += new System.EventHandler(this.textBoxTE071301_TextChanged);
			// 
			// btn_refresh
			// 
			this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_refresh.Location = new System.Drawing.Point(1743, 537);
			this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_refresh.Name = "btn_refresh";
			this.btn_refresh.Size = new System.Drawing.Size(168, 63);
			this.btn_refresh.TabIndex = 92;
			this.btn_refresh.Text = "Refresh";
			this.btn_refresh.UseVisualStyleBackColor = false;
			this.btn_refresh.UseWaitCursor = true;
			this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel2.Controls.Add(this.comboBox_FullEntropyOutput);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.txtBox_MaxEntropy);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.txtBox_MinEntropy);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.comboBox_Standard);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.txtBox_DRBGOutputLength);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Location = new System.Drawing.Point(1035, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(877, 498);
			this.panel2.TabIndex = 91;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// comboBox_FullEntropyOutput
			// 
			this.comboBox_FullEntropyOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_FullEntropyOutput.FormattingEnabled = true;
			this.comboBox_FullEntropyOutput.Items.AddRange(new object[] {
            " ",
            "fully",
            "partially"});
			this.comboBox_FullEntropyOutput.Location = new System.Drawing.Point(443, 431);
			this.comboBox_FullEntropyOutput.Name = "comboBox_FullEntropyOutput";
			this.comboBox_FullEntropyOutput.Size = new System.Drawing.Size(208, 37);
			this.comboBox_FullEntropyOutput.TabIndex = 49;
			this.comboBox_FullEntropyOutput.SelectedIndexChanged += new System.EventHandler(this.comboBox_FullEntropyOutput_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(25, 17);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(243, 58);
			this.label9.TabIndex = 40;
			this.label9.Text = "DRBG output length\r\n\r\n";
			// 
			// txtBox_MaxEntropy
			// 
			this.txtBox_MaxEntropy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_MaxEntropy.Location = new System.Drawing.Point(443, 326);
			this.txtBox_MaxEntropy.Multiline = true;
			this.txtBox_MaxEntropy.Name = "txtBox_MaxEntropy";
			this.txtBox_MaxEntropy.Size = new System.Drawing.Size(208, 48);
			this.txtBox_MaxEntropy.TabIndex = 48;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(25, 131);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(303, 29);
			this.label10.TabIndex = 41;
			this.label10.Text = "Standard for Assessment";
			// 
			// txtBox_MinEntropy
			// 
			this.txtBox_MinEntropy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_MinEntropy.Location = new System.Drawing.Point(443, 221);
			this.txtBox_MinEntropy.Multiline = true;
			this.txtBox_MinEntropy.Name = "txtBox_MinEntropy";
			this.txtBox_MinEntropy.Size = new System.Drawing.Size(208, 48);
			this.txtBox_MinEntropy.TabIndex = 47;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(25, 231);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(275, 29);
			this.label11.TabIndex = 42;
			this.label11.Text = "Min Entropy (heuristic)\r\n";
			// 
			// comboBox_Standard
			// 
			this.comboBox_Standard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_Standard.FormattingEnabled = true;
			this.comboBox_Standard.Items.AddRange(new object[] {
            " ",
            "IG 7.15 (using statistical analysis from NIST SP 800-90B)",
            "NIST SP 800-90B"});
			this.comboBox_Standard.Location = new System.Drawing.Point(443, 127);
			this.comboBox_Standard.Name = "comboBox_Standard";
			this.comboBox_Standard.Size = new System.Drawing.Size(388, 37);
			this.comboBox_Standard.TabIndex = 46;
			this.comboBox_Standard.SelectedIndexChanged += new System.EventHandler(this.comboBox_Standard_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(25, 336);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(288, 29);
			this.label12.TabIndex = 43;
			this.label12.Text = "Max entropy (statistical)\r\n";
			// 
			// txtBox_DRBGOutputLength
			// 
			this.txtBox_DRBGOutputLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_DRBGOutputLength.Location = new System.Drawing.Point(443, 22);
			this.txtBox_DRBGOutputLength.Multiline = true;
			this.txtBox_DRBGOutputLength.Name = "txtBox_DRBGOutputLength";
			this.txtBox_DRBGOutputLength.Size = new System.Drawing.Size(208, 48);
			this.txtBox_DRBGOutputLength.TabIndex = 45;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(25, 435);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(243, 29);
			this.label13.TabIndex = 44;
			this.label13.Text = "Full entropy output?\r\n";
			// 
			// btn_TE071301
			// 
			this.btn_TE071301.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE071301.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE071301.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE071301.Location = new System.Drawing.Point(13, 524);
			this.btn_TE071301.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE071301.Name = "btn_TE071301";
			this.btn_TE071301.Size = new System.Drawing.Size(240, 76);
			this.btn_TE071301.TabIndex = 93;
			this.btn_TE071301.Text = "TE.07.13.01";
			this.btn_TE071301.UseVisualStyleBackColor = false;
			this.btn_TE071301.UseWaitCursor = true;
			this.btn_TE071301.Click += new System.EventHandler(this.btn_TE071301_Click);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel3.Controls.Add(this.comboBox_DerivFunc);
			this.panel3.Controls.Add(this.comboBox_DRBG_Type);
			this.panel3.Controls.Add(this.txtBox_AlgDRBGDepends);
			this.panel3.Controls.Add(this.txtBox_NoBitsPersonalStr);
			this.panel3.Controls.Add(this.txtBox_NoBitsAdditInput);
			this.panel3.Controls.Add(this.txtBox_NoBitsNonce);
			this.panel3.Controls.Add(this.txtBox_NoBitsEntropyInput);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.txtBox_NoBitsGenNDRNG);
			this.panel3.Location = new System.Drawing.Point(12, 12);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(892, 498);
			this.panel3.TabIndex = 90;
			this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			// 
			// comboBox_DerivFunc
			// 
			this.comboBox_DerivFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_DerivFunc.FormattingEnabled = true;
			this.comboBox_DerivFunc.Items.AddRange(new object[] {
            " ",
            "with a derivation function",
            "no derivation function"});
			this.comboBox_DerivFunc.Location = new System.Drawing.Point(682, 431);
			this.comboBox_DerivFunc.Name = "comboBox_DerivFunc";
			this.comboBox_DerivFunc.Size = new System.Drawing.Size(155, 37);
			this.comboBox_DerivFunc.TabIndex = 34;
			this.comboBox_DerivFunc.SelectedIndexChanged += new System.EventHandler(this.comboBox_DerivFunc_SelectedIndexChanged);
			// 
			// comboBox_DRBG_Type
			// 
			this.comboBox_DRBG_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_DRBG_Type.FormattingEnabled = true;
			this.comboBox_DRBG_Type.Items.AddRange(new object[] {
            " ",
            "CTR",
            "HASH",
            "HMAC"});
			this.comboBox_DRBG_Type.Location = new System.Drawing.Point(682, 382);
			this.comboBox_DRBG_Type.Name = "comboBox_DRBG_Type";
			this.comboBox_DRBG_Type.Size = new System.Drawing.Size(155, 37);
			this.comboBox_DRBG_Type.TabIndex = 33;
			this.comboBox_DRBG_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox_DRBG_Type_SelectedIndexChanged);
			// 
			// txtBox_AlgDRBGDepends
			// 
			this.txtBox_AlgDRBGDepends.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_AlgDRBGDepends.Location = new System.Drawing.Point(682, 322);
			this.txtBox_AlgDRBGDepends.Multiline = true;
			this.txtBox_AlgDRBGDepends.Name = "txtBox_AlgDRBGDepends";
			this.txtBox_AlgDRBGDepends.Size = new System.Drawing.Size(155, 48);
			this.txtBox_AlgDRBGDepends.TabIndex = 32;
			// 
			// txtBox_NoBitsPersonalStr
			// 
			this.txtBox_NoBitsPersonalStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_NoBitsPersonalStr.Location = new System.Drawing.Point(682, 262);
			this.txtBox_NoBitsPersonalStr.Multiline = true;
			this.txtBox_NoBitsPersonalStr.Name = "txtBox_NoBitsPersonalStr";
			this.txtBox_NoBitsPersonalStr.Size = new System.Drawing.Size(155, 48);
			this.txtBox_NoBitsPersonalStr.TabIndex = 31;
			// 
			// txtBox_NoBitsAdditInput
			// 
			this.txtBox_NoBitsAdditInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_NoBitsAdditInput.Location = new System.Drawing.Point(682, 202);
			this.txtBox_NoBitsAdditInput.Multiline = true;
			this.txtBox_NoBitsAdditInput.Name = "txtBox_NoBitsAdditInput";
			this.txtBox_NoBitsAdditInput.Size = new System.Drawing.Size(155, 48);
			this.txtBox_NoBitsAdditInput.TabIndex = 30;
			// 
			// txtBox_NoBitsNonce
			// 
			this.txtBox_NoBitsNonce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_NoBitsNonce.Location = new System.Drawing.Point(682, 142);
			this.txtBox_NoBitsNonce.Multiline = true;
			this.txtBox_NoBitsNonce.Name = "txtBox_NoBitsNonce";
			this.txtBox_NoBitsNonce.Size = new System.Drawing.Size(155, 48);
			this.txtBox_NoBitsNonce.TabIndex = 29;
			// 
			// txtBox_NoBitsEntropyInput
			// 
			this.txtBox_NoBitsEntropyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_NoBitsEntropyInput.Location = new System.Drawing.Point(682, 82);
			this.txtBox_NoBitsEntropyInput.Multiline = true;
			this.txtBox_NoBitsEntropyInput.Name = "txtBox_NoBitsEntropyInput";
			this.txtBox_NoBitsEntropyInput.Size = new System.Drawing.Size(155, 48);
			this.txtBox_NoBitsEntropyInput.TabIndex = 28;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(24, 420);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(236, 29);
			this.label8.TabIndex = 22;
			this.label8.Text = "Derivation function:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(24, 371);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(180, 58);
			this.label7.TabIndex = 21;
			this.label7.Text = "Type of DRBG\r\n\r\n";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(24, 317);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(601, 58);
			this.label6.TabIndex = 20;
			this.label6.Text = "Algorithm (including length) the DRBG depends on\r\n\r\n";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 257);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(414, 58);
			this.label5.TabIndex = 19;
			this.label5.Text = "# bits for the personalization string\r\n\r\n";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 197);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(343, 58);
			this.label4.TabIndex = 18;
			this.label4.Text = "# bits for the additional input\r\n\r\n";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(235, 58);
			this.label3.TabIndex = 17;
			this.label3.Text = "# bits for the nonce\r\n\r\n";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(272, 29);
			this.label2.TabIndex = 16;
			this.label2.Text = "# bits for entropy input\r\n";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(432, 29);
			this.label1.TabIndex = 15;
			this.label1.Text = "Total # of bits generated by NDRNG";
			// 
			// txtBox_NoBitsGenNDRNG
			// 
			this.txtBox_NoBitsGenNDRNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_NoBitsGenNDRNG.Location = new System.Drawing.Point(682, 22);
			this.txtBox_NoBitsGenNDRNG.Multiline = true;
			this.txtBox_NoBitsGenNDRNG.Name = "txtBox_NoBitsGenNDRNG";
			this.txtBox_NoBitsGenNDRNG.Size = new System.Drawing.Size(155, 48);
			this.txtBox_NoBitsGenNDRNG.TabIndex = 14;
			// 
			// Entropy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(1924, 1050);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Entropy";
			this.Text = "Entropy";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Entropy_FormClosing);
			this.Load += new System.EventHandler(this.Entropy_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.TextBox textBoxTE071301;
		private System.Windows.Forms.Button btn_refresh;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox comboBox_FullEntropyOutput;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtBox_MaxEntropy;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtBox_MinEntropy;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox comboBox_Standard;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtBox_DRBGOutputLength;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btn_TE071301;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ComboBox comboBox_DerivFunc;
		private System.Windows.Forms.ComboBox comboBox_DRBG_Type;
		private System.Windows.Forms.TextBox txtBox_AlgDRBGDepends;
		private System.Windows.Forms.TextBox txtBox_NoBitsPersonalStr;
		private System.Windows.Forms.TextBox txtBox_NoBitsAdditInput;
		private System.Windows.Forms.TextBox txtBox_NoBitsNonce;
		private System.Windows.Forms.TextBox txtBox_NoBitsEntropyInput;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBox_NoBitsGenNDRNG;
	}
}