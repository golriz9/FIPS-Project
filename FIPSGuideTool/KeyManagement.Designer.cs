namespace FIPSGuideTool
{
	partial class KeyManagement
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyManagement));
			this.checkBox_KeyGen = new System.Windows.Forms.CheckBox();
			this.checkBox_KeyEntryOutput = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox_KeyEstablishment = new System.Windows.Forms.CheckBox();
			this.checkBox_KeyStorage = new System.Windows.Forms.CheckBox();
			this.checkBox_KeyZeroization = new System.Windows.Forms.CheckBox();
			this.checkBox_RNG = new System.Windows.Forms.CheckBox();
			this.btn_protectionStratg = new System.Windows.Forms.Button();
			this.btn_PubKeyProtec = new System.Windows.Forms.Button();
			this.btn_TE070101 = new System.Windows.Forms.Button();
			this.txtBox_TE070101 = new System.Windows.Forms.TextBox();
			this.btn_TE070201 = new System.Windows.Forms.Button();
			this.txtBox_TE070201 = new System.Windows.Forms.TextBox();
			this.btn_PubKeyEntryMethod = new System.Windows.Forms.Button();
			this.checkBox_OTAR = new System.Windows.Forms.CheckBox();
			this.checkBox_Split_Knowledge = new System.Windows.Forms.CheckBox();
			this.btn_TE070202 = new System.Windows.Forms.Button();
			this.btn_TE070301 = new System.Windows.Forms.Button();
			this.btn_TE070801 = new System.Windows.Forms.Button();
			this.btn_TE070802 = new System.Windows.Forms.Button();
			this.btn_TE070901 = new System.Windows.Forms.Button();
			this.btn_TE071001 = new System.Windows.Forms.Button();
			this.btn_TE071301 = new System.Windows.Forms.Button();
			this.btn_TE071701 = new System.Windows.Forms.Button();
			this.btn_TE071702 = new System.Windows.Forms.Button();
			this.btn_TE071901 = new System.Windows.Forms.Button();
			this.txtBox_TE070202 = new System.Windows.Forms.TextBox();
			this.txtBox_TE070301 = new System.Windows.Forms.TextBox();
			this.txtBox_TE071901 = new System.Windows.Forms.TextBox();
			this.txtBox_TE071702 = new System.Windows.Forms.TextBox();
			this.txtBox_TE071701 = new System.Windows.Forms.TextBox();
			this.txtBox_TE071301 = new System.Windows.Forms.TextBox();
			this.btn_ApprovedRNG = new System.Windows.Forms.Button();
			this.btn_CryptKeysList = new System.Windows.Forms.Button();
			this.btn_Seed = new System.Windows.Forms.Button();
			this.btn_nonAppRNG = new System.Windows.Forms.Button();
			this.btn_KeyGenSec = new System.Windows.Forms.Button();
			this.btn_KeyEstbSec = new System.Windows.Forms.Button();
			this.btn_AppKeyEstab = new System.Windows.Forms.Button();
			this.txtBox_TE070801 = new System.Windows.Forms.TextBox();
			this.txtBox_TE070802 = new System.Windows.Forms.TextBox();
			this.txtBox_TE071001 = new System.Windows.Forms.TextBox();
			this.txtBox_TE070901 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Entropy = new System.Windows.Forms.Button();
			this.checkBox_ManuEnt_SpltKnlg = new System.Windows.Forms.CheckBox();
			this.checkBox_ManuEnt_encrp = new System.Windows.Forms.CheckBox();
			this.checkBox_AutoMethod = new System.Windows.Forms.CheckBox();
			this.checkBox_ManuKeyEntry = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkBox_KeyGen
			// 
			this.checkBox_KeyGen.AutoSize = true;
			this.checkBox_KeyGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_KeyGen.Location = new System.Drawing.Point(52, 251);
			this.checkBox_KeyGen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_KeyGen.Name = "checkBox_KeyGen";
			this.checkBox_KeyGen.Size = new System.Drawing.Size(319, 33);
			this.checkBox_KeyGen.TabIndex = 2;
			this.checkBox_KeyGen.Text = "Key generation services";
			this.checkBox_KeyGen.UseVisualStyleBackColor = true;
			this.checkBox_KeyGen.CheckedChanged += new System.EventHandler(this.checkBox_KeyGen_CheckedChanged);
			// 
			// checkBox_KeyEntryOutput
			// 
			this.checkBox_KeyEntryOutput.AutoSize = true;
			this.checkBox_KeyEntryOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_KeyEntryOutput.Location = new System.Drawing.Point(52, 74);
			this.checkBox_KeyEntryOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_KeyEntryOutput.Name = "checkBox_KeyEntryOutput";
			this.checkBox_KeyEntryOutput.Size = new System.Drawing.Size(380, 33);
			this.checkBox_KeyEntryOutput.TabIndex = 1;
			this.checkBox_KeyEntryOutput.Text = "Key entry and output services";
			this.checkBox_KeyEntryOutput.UseVisualStyleBackColor = true;
			this.checkBox_KeyEntryOutput.CheckedChanged += new System.EventHandler(this.checkBox_KeyEntry_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(215, 29);
			this.label1.TabIndex = 25;
			this.label1.Text = "Module supports:";
			// 
			// checkBox_KeyEstablishment
			// 
			this.checkBox_KeyEstablishment.AutoSize = true;
			this.checkBox_KeyEstablishment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_KeyEstablishment.Location = new System.Drawing.Point(52, 367);
			this.checkBox_KeyEstablishment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_KeyEstablishment.Name = "checkBox_KeyEstablishment";
			this.checkBox_KeyEstablishment.Size = new System.Drawing.Size(356, 33);
			this.checkBox_KeyEstablishment.TabIndex = 26;
			this.checkBox_KeyEstablishment.Text = "Key establishment services";
			this.checkBox_KeyEstablishment.UseVisualStyleBackColor = true;
			this.checkBox_KeyEstablishment.CheckedChanged += new System.EventHandler(this.checkBox_KeyEstablishment_CheckedChanged);
			// 
			// checkBox_KeyStorage
			// 
			this.checkBox_KeyStorage.AutoSize = true;
			this.checkBox_KeyStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_KeyStorage.Location = new System.Drawing.Point(52, 425);
			this.checkBox_KeyStorage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_KeyStorage.Name = "checkBox_KeyStorage";
			this.checkBox_KeyStorage.Size = new System.Drawing.Size(282, 33);
			this.checkBox_KeyStorage.TabIndex = 28;
			this.checkBox_KeyStorage.Text = "Key storage services";
			this.checkBox_KeyStorage.UseVisualStyleBackColor = true;
			this.checkBox_KeyStorage.CheckedChanged += new System.EventHandler(this.checkBox_KeyStorage_CheckedChanged);
			// 
			// checkBox_KeyZeroization
			// 
			this.checkBox_KeyZeroization.AutoSize = true;
			this.checkBox_KeyZeroization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_KeyZeroization.Location = new System.Drawing.Point(52, 483);
			this.checkBox_KeyZeroization.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_KeyZeroization.Name = "checkBox_KeyZeroization";
			this.checkBox_KeyZeroization.Size = new System.Drawing.Size(321, 33);
			this.checkBox_KeyZeroization.TabIndex = 29;
			this.checkBox_KeyZeroization.Text = "Key zeroization services";
			this.checkBox_KeyZeroization.UseVisualStyleBackColor = true;
			this.checkBox_KeyZeroization.CheckedChanged += new System.EventHandler(this.checkBox_KeyZeroization_CheckedChanged);
			// 
			// checkBox_RNG
			// 
			this.checkBox_RNG.AutoSize = true;
			this.checkBox_RNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_RNG.Location = new System.Drawing.Point(52, 541);
			this.checkBox_RNG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_RNG.Name = "checkBox_RNG";
			this.checkBox_RNG.Size = new System.Drawing.Size(635, 33);
			this.checkBox_RNG.TabIndex = 30;
			this.checkBox_RNG.Text = "Module employs Approved or non-Approved RNGs.";
			this.checkBox_RNG.UseVisualStyleBackColor = true;
			this.checkBox_RNG.CheckedChanged += new System.EventHandler(this.checkBox_RNG_CheckedChanged);
			// 
			// btn_protectionStratg
			// 
			this.btn_protectionStratg.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_protectionStratg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_protectionStratg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_protectionStratg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_protectionStratg.Location = new System.Drawing.Point(960, 20);
			this.btn_protectionStratg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_protectionStratg.Name = "btn_protectionStratg";
			this.btn_protectionStratg.Size = new System.Drawing.Size(320, 115);
			this.btn_protectionStratg.TabIndex = 181;
			this.btn_protectionStratg.Text = "CSP Protection Strategies";
			this.btn_protectionStratg.UseVisualStyleBackColor = false;
			this.btn_protectionStratg.UseWaitCursor = true;
			this.btn_protectionStratg.Click += new System.EventHandler(this.btn_protectionStratg_Click);
			// 
			// btn_PubKeyProtec
			// 
			this.btn_PubKeyProtec.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_PubKeyProtec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_PubKeyProtec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_PubKeyProtec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_PubKeyProtec.Location = new System.Drawing.Point(960, 142);
			this.btn_PubKeyProtec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_PubKeyProtec.Name = "btn_PubKeyProtec";
			this.btn_PubKeyProtec.Size = new System.Drawing.Size(320, 115);
			this.btn_PubKeyProtec.TabIndex = 182;
			this.btn_PubKeyProtec.Text = "Public Keys Protection";
			this.btn_PubKeyProtec.UseVisualStyleBackColor = false;
			this.btn_PubKeyProtec.UseWaitCursor = true;
			this.btn_PubKeyProtec.Click += new System.EventHandler(this.btn_PubKeyProtec_Click);
			// 
			// btn_TE070101
			// 
			this.btn_TE070101.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE070101.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE070101.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE070101.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE070101.Location = new System.Drawing.Point(1629, 103);
			this.btn_TE070101.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE070101.Name = "btn_TE070101";
			this.btn_TE070101.Size = new System.Drawing.Size(240, 76);
			this.btn_TE070101.TabIndex = 183;
			this.btn_TE070101.Text = "TE.07.01.01";
			this.btn_TE070101.UseVisualStyleBackColor = false;
			this.btn_TE070101.UseWaitCursor = true;
			this.btn_TE070101.Click += new System.EventHandler(this.btn_TE070101_Click);
			// 
			// txtBox_TE070101
			// 
			this.txtBox_TE070101.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBox_TE070101.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_TE070101.Location = new System.Drawing.Point(11, 652);
			this.txtBox_TE070101.Multiline = true;
			this.txtBox_TE070101.Name = "txtBox_TE070101";
			this.txtBox_TE070101.ReadOnly = true;
			this.txtBox_TE070101.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_TE070101.Size = new System.Drawing.Size(1586, 466);
			this.txtBox_TE070101.TabIndex = 184;
			this.txtBox_TE070101.UseWaitCursor = true;
			// 
			// btn_TE070201
			// 
			this.btn_TE070201.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE070201.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE070201.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE070201.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE070201.Location = new System.Drawing.Point(1629, 189);
			this.btn_TE070201.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE070201.Name = "btn_TE070201";
			this.btn_TE070201.Size = new System.Drawing.Size(240, 76);
			this.btn_TE070201.TabIndex = 185;
			this.btn_TE070201.Text = "TE.07.02.01";
			this.btn_TE070201.UseVisualStyleBackColor = false;
			this.btn_TE070201.UseWaitCursor = true;
			this.btn_TE070201.Click += new System.EventHandler(this.btn_TE070201_Click);
			// 
			// txtBox_TE070201
			// 
			this.txtBox_TE070201.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBox_TE070201.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_TE070201.Location = new System.Drawing.Point(11, 654);
			this.txtBox_TE070201.Multiline = true;
			this.txtBox_TE070201.Name = "txtBox_TE070201";
			this.txtBox_TE070201.ReadOnly = true;
			this.txtBox_TE070201.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_TE070201.Size = new System.Drawing.Size(1586, 466);
			this.txtBox_TE070201.TabIndex = 186;
			this.txtBox_TE070201.UseWaitCursor = true;
			// 
			// btn_PubKeyEntryMethod
			// 
			this.btn_PubKeyEntryMethod.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_PubKeyEntryMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_PubKeyEntryMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_PubKeyEntryMethod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_PubKeyEntryMethod.Location = new System.Drawing.Point(960, 264);
			this.btn_PubKeyEntryMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_PubKeyEntryMethod.Name = "btn_PubKeyEntryMethod";
			this.btn_PubKeyEntryMethod.Size = new System.Drawing.Size(320, 115);
			this.btn_PubKeyEntryMethod.TabIndex = 187;
			this.btn_PubKeyEntryMethod.Text = "Public Keys Entry Method";
			this.btn_PubKeyEntryMethod.UseVisualStyleBackColor = false;
			this.btn_PubKeyEntryMethod.UseWaitCursor = true;
			this.btn_PubKeyEntryMethod.Click += new System.EventHandler(this.btn_PubKeyEntryMethod_Click);
			// 
			// checkBox_OTAR
			// 
			this.checkBox_OTAR.AutoSize = true;
			this.checkBox_OTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_OTAR.Location = new System.Drawing.Point(52, 599);
			this.checkBox_OTAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_OTAR.Name = "checkBox_OTAR";
			this.checkBox_OTAR.Size = new System.Drawing.Size(642, 33);
			this.checkBox_OTAR.TabIndex = 188;
			this.checkBox_OTAR.Text = "Module implements Over The Air Rekeying (OTAR).";
			this.checkBox_OTAR.UseVisualStyleBackColor = true;
			this.checkBox_OTAR.CheckedChanged += new System.EventHandler(this.checkBox_OTAR_CheckedChanged);
			// 
			// checkBox_Split_Knowledge
			// 
			this.checkBox_Split_Knowledge.AutoSize = true;
			this.checkBox_Split_Knowledge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_Split_Knowledge.Location = new System.Drawing.Point(52, 309);
			this.checkBox_Split_Knowledge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_Split_Knowledge.Name = "checkBox_Split_Knowledge";
			this.checkBox_Split_Knowledge.Size = new System.Drawing.Size(369, 33);
			this.checkBox_Split_Knowledge.TabIndex = 189;
			this.checkBox_Split_Knowledge.Text = "Split-knowledge procedures";
			this.checkBox_Split_Knowledge.UseVisualStyleBackColor = true;
			this.checkBox_Split_Knowledge.CheckedChanged += new System.EventHandler(this.checkBox_Split_Knowledge_CheckedChanged);
			// 
			// btn_TE070202
			// 
			this.btn_TE070202.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE070202.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE070202.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE070202.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE070202.Location = new System.Drawing.Point(1629, 275);
			this.btn_TE070202.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE070202.Name = "btn_TE070202";
			this.btn_TE070202.Size = new System.Drawing.Size(240, 76);
			this.btn_TE070202.TabIndex = 190;
			this.btn_TE070202.Text = "TE.07.02.02";
			this.btn_TE070202.UseVisualStyleBackColor = false;
			this.btn_TE070202.UseWaitCursor = true;
			this.btn_TE070202.Click += new System.EventHandler(this.btn_TE070202_Click);
			// 
			// btn_TE070301
			// 
			this.btn_TE070301.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE070301.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE070301.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE070301.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE070301.Location = new System.Drawing.Point(1629, 361);
			this.btn_TE070301.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE070301.Name = "btn_TE070301";
			this.btn_TE070301.Size = new System.Drawing.Size(240, 76);
			this.btn_TE070301.TabIndex = 191;
			this.btn_TE070301.Text = "TE.07.03.01";
			this.btn_TE070301.UseVisualStyleBackColor = false;
			this.btn_TE070301.UseWaitCursor = true;
			this.btn_TE070301.Click += new System.EventHandler(this.btn_TE070301_Click);
			// 
			// btn_TE070801
			// 
			this.btn_TE070801.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE070801.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE070801.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE070801.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE070801.Location = new System.Drawing.Point(1629, 446);
			this.btn_TE070801.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE070801.Name = "btn_TE070801";
			this.btn_TE070801.Size = new System.Drawing.Size(240, 76);
			this.btn_TE070801.TabIndex = 192;
			this.btn_TE070801.Text = "TE.07.08.01";
			this.btn_TE070801.UseVisualStyleBackColor = false;
			this.btn_TE070801.UseWaitCursor = true;
			this.btn_TE070801.Click += new System.EventHandler(this.btn_TE070801_Click);
			// 
			// btn_TE070802
			// 
			this.btn_TE070802.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE070802.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE070802.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE070802.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE070802.Location = new System.Drawing.Point(1629, 532);
			this.btn_TE070802.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE070802.Name = "btn_TE070802";
			this.btn_TE070802.Size = new System.Drawing.Size(240, 76);
			this.btn_TE070802.TabIndex = 193;
			this.btn_TE070802.Text = "TE.07.08.02";
			this.btn_TE070802.UseVisualStyleBackColor = false;
			this.btn_TE070802.UseWaitCursor = true;
			this.btn_TE070802.Click += new System.EventHandler(this.btn_TE070802_Click);
			// 
			// btn_TE070901
			// 
			this.btn_TE070901.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE070901.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE070901.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE070901.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE070901.Location = new System.Drawing.Point(1629, 618);
			this.btn_TE070901.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE070901.Name = "btn_TE070901";
			this.btn_TE070901.Size = new System.Drawing.Size(240, 76);
			this.btn_TE070901.TabIndex = 194;
			this.btn_TE070901.Text = "TE.07.09.01";
			this.btn_TE070901.UseVisualStyleBackColor = false;
			this.btn_TE070901.UseWaitCursor = true;
			this.btn_TE070901.Click += new System.EventHandler(this.btn_TE070901_Click);
			// 
			// btn_TE071001
			// 
			this.btn_TE071001.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE071001.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE071001.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE071001.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE071001.Location = new System.Drawing.Point(1629, 704);
			this.btn_TE071001.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE071001.Name = "btn_TE071001";
			this.btn_TE071001.Size = new System.Drawing.Size(240, 76);
			this.btn_TE071001.TabIndex = 195;
			this.btn_TE071001.Text = "TE.07.10.01";
			this.btn_TE071001.UseVisualStyleBackColor = false;
			this.btn_TE071001.UseWaitCursor = true;
			this.btn_TE071001.Click += new System.EventHandler(this.btn_TE071001_Click);
			// 
			// btn_TE071301
			// 
			this.btn_TE071301.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE071301.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE071301.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE071301.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE071301.Location = new System.Drawing.Point(1629, 790);
			this.btn_TE071301.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE071301.Name = "btn_TE071301";
			this.btn_TE071301.Size = new System.Drawing.Size(240, 76);
			this.btn_TE071301.TabIndex = 196;
			this.btn_TE071301.Text = "TE.07.13.01";
			this.btn_TE071301.UseVisualStyleBackColor = false;
			this.btn_TE071301.UseWaitCursor = true;
			this.btn_TE071301.Click += new System.EventHandler(this.btn_TE071301_Click);
			// 
			// btn_TE071701
			// 
			this.btn_TE071701.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE071701.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE071701.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE071701.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE071701.Location = new System.Drawing.Point(1629, 875);
			this.btn_TE071701.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE071701.Name = "btn_TE071701";
			this.btn_TE071701.Size = new System.Drawing.Size(240, 76);
			this.btn_TE071701.TabIndex = 197;
			this.btn_TE071701.Text = "TE.07.17.01";
			this.btn_TE071701.UseVisualStyleBackColor = false;
			this.btn_TE071701.UseWaitCursor = true;
			this.btn_TE071701.Click += new System.EventHandler(this.btn_TE071701_Click);
			// 
			// btn_TE071702
			// 
			this.btn_TE071702.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE071702.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE071702.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE071702.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE071702.Location = new System.Drawing.Point(1629, 962);
			this.btn_TE071702.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE071702.Name = "btn_TE071702";
			this.btn_TE071702.Size = new System.Drawing.Size(240, 76);
			this.btn_TE071702.TabIndex = 198;
			this.btn_TE071702.Text = "TE.07.17.02";
			this.btn_TE071702.UseVisualStyleBackColor = false;
			this.btn_TE071702.UseWaitCursor = true;
			this.btn_TE071702.Click += new System.EventHandler(this.btn_TE071702_Click);
			// 
			// btn_TE071901
			// 
			this.btn_TE071901.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE071901.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE071901.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE071901.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE071901.Location = new System.Drawing.Point(1629, 1047);
			this.btn_TE071901.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE071901.Name = "btn_TE071901";
			this.btn_TE071901.Size = new System.Drawing.Size(240, 76);
			this.btn_TE071901.TabIndex = 199;
			this.btn_TE071901.Text = "TE.07.19.01";
			this.btn_TE071901.UseVisualStyleBackColor = false;
			this.btn_TE071901.UseWaitCursor = true;
			this.btn_TE071901.Click += new System.EventHandler(this.btn_TE071901_Click);
			// 
			// txtBox_TE070202
			// 
			this.txtBox_TE070202.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBox_TE070202.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_TE070202.Location = new System.Drawing.Point(11, 654);
			this.txtBox_TE070202.Multiline = true;
			this.txtBox_TE070202.Name = "txtBox_TE070202";
			this.txtBox_TE070202.ReadOnly = true;
			this.txtBox_TE070202.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_TE070202.Size = new System.Drawing.Size(1586, 466);
			this.txtBox_TE070202.TabIndex = 200;
			this.txtBox_TE070202.UseWaitCursor = true;
			// 
			// txtBox_TE070301
			// 
			this.txtBox_TE070301.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBox_TE070301.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_TE070301.Location = new System.Drawing.Point(11, 654);
			this.txtBox_TE070301.Multiline = true;
			this.txtBox_TE070301.Name = "txtBox_TE070301";
			this.txtBox_TE070301.ReadOnly = true;
			this.txtBox_TE070301.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_TE070301.Size = new System.Drawing.Size(1586, 466);
			this.txtBox_TE070301.TabIndex = 201;
			this.txtBox_TE070301.UseWaitCursor = true;
			// 
			// txtBox_TE071901
			// 
			this.txtBox_TE071901.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBox_TE071901.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_TE071901.Location = new System.Drawing.Point(11, 652);
			this.txtBox_TE071901.Multiline = true;
			this.txtBox_TE071901.Name = "txtBox_TE071901";
			this.txtBox_TE071901.ReadOnly = true;
			this.txtBox_TE071901.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_TE071901.Size = new System.Drawing.Size(1586, 466);
			this.txtBox_TE071901.TabIndex = 202;
			this.txtBox_TE071901.UseWaitCursor = true;
			// 
			// txtBox_TE071702
			// 
			this.txtBox_TE071702.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBox_TE071702.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_TE071702.Location = new System.Drawing.Point(11, 654);
			this.txtBox_TE071702.Multiline = true;
			this.txtBox_TE071702.Name = "txtBox_TE071702";
			this.txtBox_TE071702.ReadOnly = true;
			this.txtBox_TE071702.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_TE071702.Size = new System.Drawing.Size(1586, 466);
			this.txtBox_TE071702.TabIndex = 203;
			this.txtBox_TE071702.UseWaitCursor = true;
			// 
			// txtBox_TE071701
			// 
			this.txtBox_TE071701.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBox_TE071701.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_TE071701.Location = new System.Drawing.Point(11, 652);
			this.txtBox_TE071701.Multiline = true;
			this.txtBox_TE071701.Name = "txtBox_TE071701";
			this.txtBox_TE071701.ReadOnly = true;
			this.txtBox_TE071701.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_TE071701.Size = new System.Drawing.Size(1586, 466);
			this.txtBox_TE071701.TabIndex = 204;
			this.txtBox_TE071701.UseWaitCursor = true;
			// 
			// txtBox_TE071301
			// 
			this.txtBox_TE071301.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBox_TE071301.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_TE071301.Location = new System.Drawing.Point(11, 652);
			this.txtBox_TE071301.Multiline = true;
			this.txtBox_TE071301.Name = "txtBox_TE071301";
			this.txtBox_TE071301.ReadOnly = true;
			this.txtBox_TE071301.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_TE071301.Size = new System.Drawing.Size(1586, 466);
			this.txtBox_TE071301.TabIndex = 205;
			this.txtBox_TE071301.UseWaitCursor = true;
			// 
			// btn_ApprovedRNG
			// 
			this.btn_ApprovedRNG.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_ApprovedRNG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_ApprovedRNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ApprovedRNG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_ApprovedRNG.Location = new System.Drawing.Point(1289, 20);
			this.btn_ApprovedRNG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_ApprovedRNG.Name = "btn_ApprovedRNG";
			this.btn_ApprovedRNG.Size = new System.Drawing.Size(320, 115);
			this.btn_ApprovedRNG.TabIndex = 210;
			this.btn_ApprovedRNG.Text = "Approved RNGs";
			this.btn_ApprovedRNG.UseVisualStyleBackColor = false;
			this.btn_ApprovedRNG.UseWaitCursor = true;
			this.btn_ApprovedRNG.Click += new System.EventHandler(this.btn_ApprovedRNG_Click);
			// 
			// btn_CryptKeysList
			// 
			this.btn_CryptKeysList.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_CryptKeysList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_CryptKeysList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_CryptKeysList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_CryptKeysList.Location = new System.Drawing.Point(960, 386);
			this.btn_CryptKeysList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_CryptKeysList.Name = "btn_CryptKeysList";
			this.btn_CryptKeysList.Size = new System.Drawing.Size(320, 115);
			this.btn_CryptKeysList.TabIndex = 211;
			this.btn_CryptKeysList.Text = "Cryptographic Keys List";
			this.btn_CryptKeysList.UseVisualStyleBackColor = false;
			this.btn_CryptKeysList.UseWaitCursor = true;
			this.btn_CryptKeysList.Click += new System.EventHandler(this.btn_CryptKeysList_Click);
			// 
			// btn_Seed
			// 
			this.btn_Seed.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_Seed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_Seed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Seed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_Seed.Location = new System.Drawing.Point(960, 508);
			this.btn_Seed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_Seed.Name = "btn_Seed";
			this.btn_Seed.Size = new System.Drawing.Size(320, 115);
			this.btn_Seed.TabIndex = 212;
			this.btn_Seed.Text = "Seed and Seed Key";
			this.btn_Seed.UseVisualStyleBackColor = false;
			this.btn_Seed.UseWaitCursor = true;
			this.btn_Seed.Click += new System.EventHandler(this.btn_Seed_Click);
			// 
			// btn_nonAppRNG
			// 
			this.btn_nonAppRNG.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_nonAppRNG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_nonAppRNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_nonAppRNG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_nonAppRNG.Location = new System.Drawing.Point(1289, 142);
			this.btn_nonAppRNG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_nonAppRNG.Name = "btn_nonAppRNG";
			this.btn_nonAppRNG.Size = new System.Drawing.Size(320, 115);
			this.btn_nonAppRNG.TabIndex = 213;
			this.btn_nonAppRNG.Text = "Non-Approved RNGs";
			this.btn_nonAppRNG.UseVisualStyleBackColor = false;
			this.btn_nonAppRNG.UseWaitCursor = true;
			this.btn_nonAppRNG.Click += new System.EventHandler(this.btn_nonAppRNG_Click);
			// 
			// btn_KeyGenSec
			// 
			this.btn_KeyGenSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_KeyGenSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_KeyGenSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_KeyGenSec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_KeyGenSec.Location = new System.Drawing.Point(1289, 264);
			this.btn_KeyGenSec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_KeyGenSec.Name = "btn_KeyGenSec";
			this.btn_KeyGenSec.Size = new System.Drawing.Size(320, 115);
			this.btn_KeyGenSec.TabIndex = 214;
			this.btn_KeyGenSec.Text = "Key Generation Security";
			this.btn_KeyGenSec.UseVisualStyleBackColor = false;
			this.btn_KeyGenSec.UseWaitCursor = true;
			this.btn_KeyGenSec.Click += new System.EventHandler(this.btn_KeyGenSec_Click);
			// 
			// btn_KeyEstbSec
			// 
			this.btn_KeyEstbSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_KeyEstbSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_KeyEstbSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_KeyEstbSec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_KeyEstbSec.Location = new System.Drawing.Point(1289, 386);
			this.btn_KeyEstbSec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_KeyEstbSec.Name = "btn_KeyEstbSec";
			this.btn_KeyEstbSec.Size = new System.Drawing.Size(320, 115);
			this.btn_KeyEstbSec.TabIndex = 215;
			this.btn_KeyEstbSec.Text = "Key Establishment Security";
			this.btn_KeyEstbSec.UseVisualStyleBackColor = false;
			this.btn_KeyEstbSec.UseWaitCursor = true;
			this.btn_KeyEstbSec.Click += new System.EventHandler(this.btn_KeyEstbSec_Click);
			// 
			// btn_AppKeyEstab
			// 
			this.btn_AppKeyEstab.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_AppKeyEstab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_AppKeyEstab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_AppKeyEstab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_AppKeyEstab.Location = new System.Drawing.Point(1289, 508);
			this.btn_AppKeyEstab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_AppKeyEstab.Name = "btn_AppKeyEstab";
			this.btn_AppKeyEstab.Size = new System.Drawing.Size(320, 115);
			this.btn_AppKeyEstab.TabIndex = 216;
			this.btn_AppKeyEstab.Text = "Approved Key Establishment";
			this.btn_AppKeyEstab.UseVisualStyleBackColor = false;
			this.btn_AppKeyEstab.UseWaitCursor = true;
			this.btn_AppKeyEstab.Click += new System.EventHandler(this.btn_AppKeyEstab_Click);
			// 
			// txtBox_TE070801
			// 
			this.txtBox_TE070801.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBox_TE070801.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_TE070801.Location = new System.Drawing.Point(11, 654);
			this.txtBox_TE070801.Multiline = true;
			this.txtBox_TE070801.Name = "txtBox_TE070801";
			this.txtBox_TE070801.ReadOnly = true;
			this.txtBox_TE070801.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_TE070801.Size = new System.Drawing.Size(1586, 466);
			this.txtBox_TE070801.TabIndex = 217;
			this.txtBox_TE070801.UseWaitCursor = true;
			// 
			// txtBox_TE070802
			// 
			this.txtBox_TE070802.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBox_TE070802.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_TE070802.Location = new System.Drawing.Point(11, 652);
			this.txtBox_TE070802.Multiline = true;
			this.txtBox_TE070802.Name = "txtBox_TE070802";
			this.txtBox_TE070802.ReadOnly = true;
			this.txtBox_TE070802.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_TE070802.Size = new System.Drawing.Size(1586, 466);
			this.txtBox_TE070802.TabIndex = 218;
			this.txtBox_TE070802.UseWaitCursor = true;
			// 
			// txtBox_TE071001
			// 
			this.txtBox_TE071001.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBox_TE071001.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_TE071001.Location = new System.Drawing.Point(11, 654);
			this.txtBox_TE071001.Multiline = true;
			this.txtBox_TE071001.Name = "txtBox_TE071001";
			this.txtBox_TE071001.ReadOnly = true;
			this.txtBox_TE071001.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_TE071001.Size = new System.Drawing.Size(1586, 466);
			this.txtBox_TE071001.TabIndex = 220;
			this.txtBox_TE071001.UseWaitCursor = true;
			// 
			// txtBox_TE070901
			// 
			this.txtBox_TE070901.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBox_TE070901.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBox_TE070901.Location = new System.Drawing.Point(11, 652);
			this.txtBox_TE070901.Multiline = true;
			this.txtBox_TE070901.Name = "txtBox_TE070901";
			this.txtBox_TE070901.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_TE070901.Size = new System.Drawing.Size(1586, 466);
			this.txtBox_TE070901.TabIndex = 221;
			this.txtBox_TE070901.UseWaitCursor = true;
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel1.Controls.Add(this.btn_Entropy);
			this.panel1.Controls.Add(this.checkBox_ManuEnt_SpltKnlg);
			this.panel1.Controls.Add(this.checkBox_ManuEnt_encrp);
			this.panel1.Controls.Add(this.checkBox_AutoMethod);
			this.panel1.Controls.Add(this.checkBox_ManuKeyEntry);
			this.panel1.Controls.Add(this.txtBox_TE070901);
			this.panel1.Controls.Add(this.txtBox_TE071001);
			this.panel1.Controls.Add(this.txtBox_TE070802);
			this.panel1.Controls.Add(this.txtBox_TE070801);
			this.panel1.Controls.Add(this.btn_AppKeyEstab);
			this.panel1.Controls.Add(this.btn_KeyEstbSec);
			this.panel1.Controls.Add(this.btn_KeyGenSec);
			this.panel1.Controls.Add(this.btn_nonAppRNG);
			this.panel1.Controls.Add(this.btn_Seed);
			this.panel1.Controls.Add(this.btn_CryptKeysList);
			this.panel1.Controls.Add(this.btn_ApprovedRNG);
			this.panel1.Controls.Add(this.txtBox_TE071301);
			this.panel1.Controls.Add(this.txtBox_TE071701);
			this.panel1.Controls.Add(this.txtBox_TE071702);
			this.panel1.Controls.Add(this.txtBox_TE071901);
			this.panel1.Controls.Add(this.txtBox_TE070301);
			this.panel1.Controls.Add(this.txtBox_TE070202);
			this.panel1.Controls.Add(this.btn_TE071901);
			this.panel1.Controls.Add(this.btn_TE071702);
			this.panel1.Controls.Add(this.btn_TE071701);
			this.panel1.Controls.Add(this.btn_TE071301);
			this.panel1.Controls.Add(this.btn_TE071001);
			this.panel1.Controls.Add(this.btn_TE070901);
			this.panel1.Controls.Add(this.btn_TE070802);
			this.panel1.Controls.Add(this.btn_TE070801);
			this.panel1.Controls.Add(this.btn_TE070301);
			this.panel1.Controls.Add(this.btn_TE070202);
			this.panel1.Controls.Add(this.checkBox_Split_Knowledge);
			this.panel1.Controls.Add(this.checkBox_OTAR);
			this.panel1.Controls.Add(this.btn_PubKeyEntryMethod);
			this.panel1.Controls.Add(this.txtBox_TE070201);
			this.panel1.Controls.Add(this.btn_TE070201);
			this.panel1.Controls.Add(this.txtBox_TE070101);
			this.panel1.Controls.Add(this.btn_TE070101);
			this.panel1.Controls.Add(this.btn_PubKeyProtec);
			this.panel1.Controls.Add(this.btn_protectionStratg);
			this.panel1.Controls.Add(this.checkBox_RNG);
			this.panel1.Controls.Add(this.checkBox_KeyZeroization);
			this.panel1.Controls.Add(this.checkBox_KeyStorage);
			this.panel1.Controls.Add(this.checkBox_KeyEstablishment);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox_KeyEntryOutput);
			this.panel1.Controls.Add(this.checkBox_KeyGen);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1924, 1050);
			this.panel1.TabIndex = 25;
			// 
			// btn_Entropy
			// 
			this.btn_Entropy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Entropy.BackColor = System.Drawing.Color.Tan;
			this.btn_Entropy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Entropy.ForeColor = System.Drawing.Color.Black;
			this.btn_Entropy.Location = new System.Drawing.Point(1629, 20);
			this.btn_Entropy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_Entropy.Name = "btn_Entropy";
			this.btn_Entropy.Size = new System.Drawing.Size(240, 76);
			this.btn_Entropy.TabIndex = 226;
			this.btn_Entropy.Text = "Entropy";
			this.btn_Entropy.UseVisualStyleBackColor = false;
			this.btn_Entropy.UseWaitCursor = true;
			this.btn_Entropy.Click += new System.EventHandler(this.btn_Entropy_Click);
			// 
			// checkBox_ManuEnt_SpltKnlg
			// 
			this.checkBox_ManuEnt_SpltKnlg.AutoSize = true;
			this.checkBox_ManuEnt_SpltKnlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_ManuEnt_SpltKnlg.Location = new System.Drawing.Point(142, 204);
			this.checkBox_ManuEnt_SpltKnlg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_ManuEnt_SpltKnlg.Name = "checkBox_ManuEnt_SpltKnlg";
			this.checkBox_ManuEnt_SpltKnlg.Size = new System.Drawing.Size(227, 33);
			this.checkBox_ManuEnt_SpltKnlg.TabIndex = 225;
			this.checkBox_ManuEnt_SpltKnlg.Text = "Split knowledge";
			this.checkBox_ManuEnt_SpltKnlg.UseVisualStyleBackColor = true;
			this.checkBox_ManuEnt_SpltKnlg.Visible = false;
			this.checkBox_ManuEnt_SpltKnlg.CheckedChanged += new System.EventHandler(this.checkBox_ManuEnt_SpltKnlg_CheckedChanged);
			// 
			// checkBox_ManuEnt_encrp
			// 
			this.checkBox_ManuEnt_encrp.AutoSize = true;
			this.checkBox_ManuEnt_encrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_ManuEnt_encrp.Location = new System.Drawing.Point(142, 161);
			this.checkBox_ManuEnt_encrp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_ManuEnt_encrp.Name = "checkBox_ManuEnt_encrp";
			this.checkBox_ManuEnt_encrp.Size = new System.Drawing.Size(215, 33);
			this.checkBox_ManuEnt_encrp.TabIndex = 224;
			this.checkBox_ManuEnt_encrp.Text = "Encrypted form";
			this.checkBox_ManuEnt_encrp.UseVisualStyleBackColor = true;
			this.checkBox_ManuEnt_encrp.Visible = false;
			this.checkBox_ManuEnt_encrp.CheckedChanged += new System.EventHandler(this.checkBox_ManuEnt_encrp_CheckedChanged);
			// 
			// checkBox_AutoMethod
			// 
			this.checkBox_AutoMethod.AutoSize = true;
			this.checkBox_AutoMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_AutoMethod.Location = new System.Drawing.Point(520, 117);
			this.checkBox_AutoMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_AutoMethod.Name = "checkBox_AutoMethod";
			this.checkBox_AutoMethod.Size = new System.Drawing.Size(280, 33);
			this.checkBox_AutoMethod.TabIndex = 223;
			this.checkBox_AutoMethod.Text = "Automated Key Entry";
			this.checkBox_AutoMethod.UseVisualStyleBackColor = true;
			this.checkBox_AutoMethod.Visible = false;
			this.checkBox_AutoMethod.CheckedChanged += new System.EventHandler(this.checkBox_AutoMethod_CheckedChanged);
			// 
			// checkBox_ManuKeyEntry
			// 
			this.checkBox_ManuKeyEntry.AutoSize = true;
			this.checkBox_ManuKeyEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_ManuKeyEntry.Location = new System.Drawing.Point(111, 117);
			this.checkBox_ManuKeyEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_ManuKeyEntry.Name = "checkBox_ManuKeyEntry";
			this.checkBox_ManuKeyEntry.Size = new System.Drawing.Size(234, 33);
			this.checkBox_ManuKeyEntry.TabIndex = 222;
			this.checkBox_ManuKeyEntry.Text = "Manual key entry";
			this.checkBox_ManuKeyEntry.UseVisualStyleBackColor = true;
			this.checkBox_ManuKeyEntry.Visible = false;
			this.checkBox_ManuKeyEntry.CheckedChanged += new System.EventHandler(this.checkBox_ManuKeyEntry_CheckedChanged);
			// 
			// KeyManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(1924, 1050);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "KeyManagement";
			this.Text = "Key Management";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeyManagement_FormClosing);
			this.Load += new System.EventHandler(this.KeyManagement_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.CheckBox checkBox_KeyGen;
		private System.Windows.Forms.CheckBox checkBox_KeyEntryOutput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox_KeyEstablishment;
		private System.Windows.Forms.CheckBox checkBox_KeyStorage;
		private System.Windows.Forms.CheckBox checkBox_KeyZeroization;
		private System.Windows.Forms.CheckBox checkBox_RNG;
		private System.Windows.Forms.Button btn_protectionStratg;
		private System.Windows.Forms.Button btn_PubKeyProtec;
		private System.Windows.Forms.Button btn_TE070101;
		public System.Windows.Forms.TextBox txtBox_TE070101;
		private System.Windows.Forms.Button btn_TE070201;
		public System.Windows.Forms.TextBox txtBox_TE070201;
		private System.Windows.Forms.Button btn_PubKeyEntryMethod;
		private System.Windows.Forms.CheckBox checkBox_OTAR;
		private System.Windows.Forms.CheckBox checkBox_Split_Knowledge;
		private System.Windows.Forms.Button btn_TE070202;
		private System.Windows.Forms.Button btn_TE070301;
		private System.Windows.Forms.Button btn_TE070801;
		private System.Windows.Forms.Button btn_TE070802;
		private System.Windows.Forms.Button btn_TE070901;
		private System.Windows.Forms.Button btn_TE071001;
		private System.Windows.Forms.Button btn_TE071301;
		private System.Windows.Forms.Button btn_TE071701;
		private System.Windows.Forms.Button btn_TE071702;
		private System.Windows.Forms.Button btn_TE071901;
		public System.Windows.Forms.TextBox txtBox_TE070202;
		public System.Windows.Forms.TextBox txtBox_TE070301;
		public System.Windows.Forms.TextBox txtBox_TE071901;
		public System.Windows.Forms.TextBox txtBox_TE071702;
		public System.Windows.Forms.TextBox txtBox_TE071701;
		public System.Windows.Forms.TextBox txtBox_TE071301;
		private System.Windows.Forms.Button btn_ApprovedRNG;
		private System.Windows.Forms.Button btn_CryptKeysList;
		private System.Windows.Forms.Button btn_Seed;
		private System.Windows.Forms.Button btn_nonAppRNG;
		private System.Windows.Forms.Button btn_KeyGenSec;
		private System.Windows.Forms.Button btn_KeyEstbSec;
		private System.Windows.Forms.Button btn_AppKeyEstab;
		public System.Windows.Forms.TextBox txtBox_TE070801;
		public System.Windows.Forms.TextBox txtBox_TE070802;
		public System.Windows.Forms.TextBox txtBox_TE071001;
		public System.Windows.Forms.TextBox txtBox_TE070901;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkBox_ManuKeyEntry;
		private System.Windows.Forms.CheckBox checkBox_AutoMethod;
		private System.Windows.Forms.CheckBox checkBox_ManuEnt_SpltKnlg;
		private System.Windows.Forms.CheckBox checkBox_ManuEnt_encrp;
		private System.Windows.Forms.Button btn_Entropy;
	}
}