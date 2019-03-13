namespace FIPSGuideTool
{
	partial class RolesAndServices
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
			System.Windows.Forms.Button btn_serviceAuthorizedRole;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolesAndServices));
			this.Authentication = new System.Windows.Forms.TabPage();
			this.Embodiment_tabs = new System.Windows.Forms.TabControl();
			this.Roles = new System.Windows.Forms.TabPage();
			this.checkBox_BypassCapability = new System.Windows.Forms.CheckBox();
			this.checkBox_idleState = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox_AS0302 = new System.Windows.Forms.CheckBox();
			this.checkBox_ChangeRoles = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.txtbox_TE032301 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.comboBox_AuthnticationType = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_AddRolesServices = new System.Windows.Forms.Button();
			this.textBox_TE030301 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_TE030301 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn_TE030601 = new System.Windows.Forms.Button();
			this.btn_TE031101 = new System.Windows.Forms.Button();
			this.btn_TE031102 = new System.Windows.Forms.Button();
			this.btn_TE031501 = new System.Windows.Forms.Button();
			this.textBox_TE030601 = new System.Windows.Forms.TextBox();
			this.textBox_TE031101 = new System.Windows.Forms.TextBox();
			this.textBox_TE031102 = new System.Windows.Forms.TextBox();
			this.textBox_TE031501 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_UnauthService = new System.Windows.Forms.Button();
			this.btn_refresh = new System.Windows.Forms.Button();
			btn_serviceAuthorizedRole = new System.Windows.Forms.Button();
			this.Authentication.SuspendLayout();
			this.Embodiment_tabs.SuspendLayout();
			this.Roles.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Authentication
			// 
			this.Authentication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Authentication.Controls.Add(this.panel4);
			this.Authentication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Authentication.Location = new System.Drawing.Point(4, 41);
			this.Authentication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Authentication.Name = "Authentication";
			this.Authentication.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Authentication.Size = new System.Drawing.Size(1916, 1005);
			this.Authentication.TabIndex = 2;
			this.Authentication.Text = "Authentication    ";
			// 
			// Embodiment_tabs
			// 
			this.Embodiment_tabs.Controls.Add(this.Roles);
			this.Embodiment_tabs.Controls.Add(this.Authentication);
			this.Embodiment_tabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Embodiment_tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Embodiment_tabs.Location = new System.Drawing.Point(0, 0);
			this.Embodiment_tabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Embodiment_tabs.Name = "Embodiment_tabs";
			this.Embodiment_tabs.SelectedIndex = 0;
			this.Embodiment_tabs.Size = new System.Drawing.Size(1924, 1050);
			this.Embodiment_tabs.TabIndex = 38;
			// 
			// Roles
			// 
			this.Roles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Roles.Controls.Add(this.panel2);
			this.Roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Roles.Location = new System.Drawing.Point(4, 41);
			this.Roles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Roles.Name = "Roles";
			this.Roles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Roles.Size = new System.Drawing.Size(1916, 1005);
			this.Roles.TabIndex = 0;
			this.Roles.Text = "Roles & Services    ";
			// 
			// checkBox_BypassCapability
			// 
			this.checkBox_BypassCapability.AutoSize = true;
			this.checkBox_BypassCapability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_BypassCapability.Location = new System.Drawing.Point(937, 201);
			this.checkBox_BypassCapability.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_BypassCapability.Name = "checkBox_BypassCapability";
			this.checkBox_BypassCapability.Size = new System.Drawing.Size(241, 33);
			this.checkBox_BypassCapability.TabIndex = 25;
			this.checkBox_BypassCapability.Text = "Bypass capability";
			this.checkBox_BypassCapability.UseVisualStyleBackColor = true;
			this.checkBox_BypassCapability.CheckedChanged += new System.EventHandler(this.checkBox_BypassCapability_CheckedChanged);
			// 
			// checkBox_idleState
			// 
			this.checkBox_idleState.AutoSize = true;
			this.checkBox_idleState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_idleState.Location = new System.Drawing.Point(937, 125);
			this.checkBox_idleState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_idleState.Name = "checkBox_idleState";
			this.checkBox_idleState.Size = new System.Drawing.Size(159, 33);
			this.checkBox_idleState.TabIndex = 35;
			this.checkBox_idleState.Text = "Idle states";
			this.checkBox_idleState.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 43);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(215, 29);
			this.label1.TabIndex = 30;
			this.label1.Text = "Module supports:";
			// 
			// checkBox_AS0302
			// 
			this.checkBox_AS0302.AutoSize = true;
			this.checkBox_AS0302.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_AS0302.Location = new System.Drawing.Point(67, 125);
			this.checkBox_AS0302.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_AS0302.Name = "checkBox_AS0302";
			this.checkBox_AS0302.Size = new System.Drawing.Size(286, 33);
			this.checkBox_AS0302.TabIndex = 0;
			this.checkBox_AS0302.Text = "Concurrent operators";
			this.checkBox_AS0302.UseVisualStyleBackColor = true;
			// 
			// checkBox_ChangeRoles
			// 
			this.checkBox_ChangeRoles.AutoSize = true;
			this.checkBox_ChangeRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_ChangeRoles.Location = new System.Drawing.Point(67, 201);
			this.checkBox_ChangeRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox_ChangeRoles.Name = "checkBox_ChangeRoles";
			this.checkBox_ChangeRoles.Size = new System.Drawing.Size(544, 33);
			this.checkBox_ChangeRoles.TabIndex = 38;
			this.checkBox_ChangeRoles.Text = "Module allows the operator to change roles";
			this.checkBox_ChangeRoles.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(23, 439);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(983, 29);
			this.label3.TabIndex = 50;
			this.label3.Text = "How module authenticate the operator upon accessing the module for the first time" +
    "?";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "",
            "Yes",
            "No"});
			this.comboBox1.Location = new System.Drawing.Point(994, 313);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(273, 37);
			this.comboBox1.TabIndex = 49;
			// 
			// txtbox_TE032301
			// 
			this.txtbox_TE032301.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbox_TE032301.Location = new System.Drawing.Point(28, 505);
			this.txtbox_TE032301.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtbox_TE032301.Multiline = true;
			this.txtbox_TE032301.Name = "txtbox_TE032301";
			this.txtbox_TE032301.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtbox_TE032301.Size = new System.Drawing.Size(1239, 397);
			this.txtbox_TE032301.TabIndex = 51;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 317);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(606, 29);
			this.label2.TabIndex = 48;
			this.label2.Text = "Does module control access before it is initialized?";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txtbox_TE032301);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.checkBox_ChangeRoles);
			this.panel4.Controls.Add(this.checkBox_AS0302);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.checkBox_idleState);
			this.panel4.Controls.Add(this.checkBox_BypassCapability);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(3, 2);
			this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1910, 1001);
			this.panel4.TabIndex = 15;
			// 
			// comboBox_AuthnticationType
			// 
			this.comboBox_AuthnticationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_AuthnticationType.FormattingEnabled = true;
			this.comboBox_AuthnticationType.Items.AddRange(new object[] {
            "",
            "No authentication",
            "Role-based authentication",
            "Identity-based authentication"});
			this.comboBox_AuthnticationType.Location = new System.Drawing.Point(706, 43);
			this.comboBox_AuthnticationType.Name = "comboBox_AuthnticationType";
			this.comboBox_AuthnticationType.Size = new System.Drawing.Size(454, 40);
			this.comboBox_AuthnticationType.TabIndex = 54;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(23, 43);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(370, 29);
			this.label4.TabIndex = 55;
			this.label4.Text = "Module authentication method:";
			// 
			// btn_AddRolesServices
			// 
			this.btn_AddRolesServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_AddRolesServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_AddRolesServices.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_AddRolesServices.Location = new System.Drawing.Point(23, 122);
			this.btn_AddRolesServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_AddRolesServices.Name = "btn_AddRolesServices";
			this.btn_AddRolesServices.Size = new System.Drawing.Size(138, 75);
			this.btn_AddRolesServices.TabIndex = 162;
			this.btn_AddRolesServices.Text = "Add";
			this.btn_AddRolesServices.UseVisualStyleBackColor = false;
			this.btn_AddRolesServices.Click += new System.EventHandler(this.btn_AddRoles_Click);
			// 
			// textBox_TE030301
			// 
			this.textBox_TE030301.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_TE030301.Location = new System.Drawing.Point(5, 461);
			this.textBox_TE030301.Multiline = true;
			this.textBox_TE030301.Name = "textBox_TE030301";
			this.textBox_TE030301.ReadOnly = true;
			this.textBox_TE030301.Size = new System.Drawing.Size(1900, 534);
			this.textBox_TE030301.TabIndex = 163;
			this.textBox_TE030301.TextChanged += new System.EventHandler(this.textBox_AddtoList_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(194, 145);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(842, 29);
			this.label5.TabIndex = 164;
			this.label5.Text = "Click the Add button to add the \"Roles\" and the \"Services\" for each role.\r\n";
			// 
			// btn_TE030301
			// 
			this.btn_TE030301.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE030301.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE030301.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE030301.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE030301.Location = new System.Drawing.Point(1659, 16);
			this.btn_TE030301.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE030301.Name = "btn_TE030301";
			this.btn_TE030301.Size = new System.Drawing.Size(240, 76);
			this.btn_TE030301.TabIndex = 167;
			this.btn_TE030301.Text = "TE.03.03.01";
			this.btn_TE030301.UseVisualStyleBackColor = false;
			this.btn_TE030301.UseWaitCursor = true;
			this.btn_TE030301.Click += new System.EventHandler(this.btn_TE030301_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.AutoScroll = true;
			this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panel2.Controls.Add(this.btn_refresh);
			this.panel2.Controls.Add(this.btn_UnauthService);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(btn_serviceAuthorizedRole);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.textBox_TE031501);
			this.panel2.Controls.Add(this.textBox_TE031102);
			this.panel2.Controls.Add(this.textBox_TE031101);
			this.panel2.Controls.Add(this.textBox_TE030601);
			this.panel2.Controls.Add(this.btn_TE031501);
			this.panel2.Controls.Add(this.btn_TE031102);
			this.panel2.Controls.Add(this.btn_TE031101);
			this.panel2.Controls.Add(this.btn_TE030601);
			this.panel2.Controls.Add(this.btn_TE030301);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.textBox_TE030301);
			this.panel2.Controls.Add(this.btn_AddRolesServices);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.comboBox_AuthnticationType);
			this.panel2.Location = new System.Drawing.Point(3, 2);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1910, 1001);
			this.panel2.TabIndex = 22;
			// 
			// btn_TE030601
			// 
			this.btn_TE030601.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE030601.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE030601.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE030601.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE030601.Location = new System.Drawing.Point(1659, 101);
			this.btn_TE030601.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE030601.Name = "btn_TE030601";
			this.btn_TE030601.Size = new System.Drawing.Size(240, 76);
			this.btn_TE030601.TabIndex = 168;
			this.btn_TE030601.Text = "TE.03.06.01";
			this.btn_TE030601.UseVisualStyleBackColor = false;
			this.btn_TE030601.UseWaitCursor = true;
			this.btn_TE030601.Click += new System.EventHandler(this.btn_TE030601_Click);
			// 
			// btn_TE031101
			// 
			this.btn_TE031101.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE031101.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE031101.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE031101.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE031101.Location = new System.Drawing.Point(1659, 187);
			this.btn_TE031101.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE031101.Name = "btn_TE031101";
			this.btn_TE031101.Size = new System.Drawing.Size(240, 76);
			this.btn_TE031101.TabIndex = 169;
			this.btn_TE031101.Text = "TE.03.11.01";
			this.btn_TE031101.UseVisualStyleBackColor = false;
			this.btn_TE031101.UseWaitCursor = true;
			this.btn_TE031101.Click += new System.EventHandler(this.btn_TE031101_Click);
			// 
			// btn_TE031102
			// 
			this.btn_TE031102.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE031102.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE031102.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE031102.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE031102.Location = new System.Drawing.Point(1659, 273);
			this.btn_TE031102.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE031102.Name = "btn_TE031102";
			this.btn_TE031102.Size = new System.Drawing.Size(240, 76);
			this.btn_TE031102.TabIndex = 170;
			this.btn_TE031102.Text = "TE.03.11.02";
			this.btn_TE031102.UseVisualStyleBackColor = false;
			this.btn_TE031102.UseWaitCursor = true;
			this.btn_TE031102.Click += new System.EventHandler(this.btn_TE031102_Click);
			// 
			// btn_TE031501
			// 
			this.btn_TE031501.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TE031501.BackColor = System.Drawing.Color.Maroon;
			this.btn_TE031501.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TE031501.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_TE031501.Location = new System.Drawing.Point(1659, 359);
			this.btn_TE031501.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_TE031501.Name = "btn_TE031501";
			this.btn_TE031501.Size = new System.Drawing.Size(240, 76);
			this.btn_TE031501.TabIndex = 171;
			this.btn_TE031501.Text = "TE.03.15.01";
			this.btn_TE031501.UseVisualStyleBackColor = false;
			this.btn_TE031501.UseWaitCursor = true;
			this.btn_TE031501.Click += new System.EventHandler(this.btn_TE031501_Click);
			// 
			// textBox_TE030601
			// 
			this.textBox_TE030601.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_TE030601.Location = new System.Drawing.Point(5, 461);
			this.textBox_TE030601.Multiline = true;
			this.textBox_TE030601.Name = "textBox_TE030601";
			this.textBox_TE030601.ReadOnly = true;
			this.textBox_TE030601.Size = new System.Drawing.Size(1900, 534);
			this.textBox_TE030601.TabIndex = 172;
			// 
			// textBox_TE031101
			// 
			this.textBox_TE031101.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_TE031101.Location = new System.Drawing.Point(5, 461);
			this.textBox_TE031101.Multiline = true;
			this.textBox_TE031101.Name = "textBox_TE031101";
			this.textBox_TE031101.ReadOnly = true;
			this.textBox_TE031101.Size = new System.Drawing.Size(1900, 534);
			this.textBox_TE031101.TabIndex = 173;
			// 
			// textBox_TE031102
			// 
			this.textBox_TE031102.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_TE031102.Location = new System.Drawing.Point(5, 461);
			this.textBox_TE031102.Multiline = true;
			this.textBox_TE031102.Name = "textBox_TE031102";
			this.textBox_TE031102.ReadOnly = true;
			this.textBox_TE031102.Size = new System.Drawing.Size(1900, 534);
			this.textBox_TE031102.TabIndex = 174;
			// 
			// textBox_TE031501
			// 
			this.textBox_TE031501.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_TE031501.Location = new System.Drawing.Point(5, 461);
			this.textBox_TE031501.Multiline = true;
			this.textBox_TE031501.Name = "textBox_TE031501";
			this.textBox_TE031501.ReadOnly = true;
			this.textBox_TE031501.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox_TE031501.Size = new System.Drawing.Size(1900, 534);
			this.textBox_TE031501.TabIndex = 175;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(194, 215);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(979, 58);
			this.label6.TabIndex = 176;
			this.label6.Text = "Click the Add button to add the authorized roles allocated by \"Show Status\" servi" +
    "ce \r\nand the user callable self-test initiation service.";
			// 
			// btn_serviceAuthorizedRole
			// 
			btn_serviceAuthorizedRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			btn_serviceAuthorizedRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			btn_serviceAuthorizedRole.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			btn_serviceAuthorizedRole.Location = new System.Drawing.Point(23, 207);
			btn_serviceAuthorizedRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			btn_serviceAuthorizedRole.Name = "btn_serviceAuthorizedRole";
			btn_serviceAuthorizedRole.Size = new System.Drawing.Size(138, 75);
			btn_serviceAuthorizedRole.TabIndex = 177;
			btn_serviceAuthorizedRole.Text = "Add";
			btn_serviceAuthorizedRole.UseVisualStyleBackColor = false;
			btn_serviceAuthorizedRole.Click += new System.EventHandler(this.btn_serviceAuthorizedRole_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(194, 315);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(671, 29);
			this.label7.TabIndex = 178;
			this.label7.Text = "Click the Add button to add the unauthenticated services.";
			// 
			// btn_UnauthService
			// 
			this.btn_UnauthService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_UnauthService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_UnauthService.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_UnauthService.Location = new System.Drawing.Point(23, 292);
			this.btn_UnauthService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_UnauthService.Name = "btn_UnauthService";
			this.btn_UnauthService.Size = new System.Drawing.Size(138, 75);
			this.btn_UnauthService.TabIndex = 179;
			this.btn_UnauthService.Text = "Add";
			this.btn_UnauthService.UseVisualStyleBackColor = false;
			this.btn_UnauthService.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_refresh
			// 
			this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_refresh.Location = new System.Drawing.Point(23, 390);
			this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_refresh.Name = "btn_refresh";
			this.btn_refresh.Size = new System.Drawing.Size(168, 63);
			this.btn_refresh.TabIndex = 180;
			this.btn_refresh.Text = "Refresh";
			this.btn_refresh.UseVisualStyleBackColor = false;
			this.btn_refresh.UseWaitCursor = true;
			this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
			// 
			// RolesAndServices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(1924, 1050);
			this.Controls.Add(this.Embodiment_tabs);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "RolesAndServices";
			this.Text = "Roles, Services and Authentication";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RolesAndServices_FormClosing);
			this.Load += new System.EventHandler(this.RolesAndServices_Load);
			this.Authentication.ResumeLayout(false);
			this.Embodiment_tabs.ResumeLayout(false);
			this.Roles.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage Authentication;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtbox_TE032301;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBox_ChangeRoles;
		private System.Windows.Forms.CheckBox checkBox_AS0302;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox_idleState;
		private System.Windows.Forms.CheckBox checkBox_BypassCapability;
		private System.Windows.Forms.TabControl Embodiment_tabs;
		private System.Windows.Forms.TabPage Roles;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btn_refresh;
		private System.Windows.Forms.Button btn_UnauthService;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox_TE031501;
		private System.Windows.Forms.TextBox textBox_TE031102;
		private System.Windows.Forms.TextBox textBox_TE031101;
		private System.Windows.Forms.TextBox textBox_TE030601;
		private System.Windows.Forms.Button btn_TE031501;
		private System.Windows.Forms.Button btn_TE031102;
		private System.Windows.Forms.Button btn_TE031101;
		private System.Windows.Forms.Button btn_TE030601;
		private System.Windows.Forms.Button btn_TE030301;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_TE030301;
		private System.Windows.Forms.Button btn_AddRolesServices;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox_AuthnticationType;
	}
}