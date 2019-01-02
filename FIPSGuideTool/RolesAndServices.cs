using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;

namespace FIPSGuideTool
{
	public partial class RolesAndServices : Form
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();
		
		public static string AS0302;
		public static string Embodiment;
		public static string MaintenanceRole_SC;
		public static string MaintenanceRole_MCE;
		public static string MaintenanceRole_MCS;
		public static string BypassCapability;
		public static string RolesServicesSecurityLevel;
		public static string AS0318;
		public static string AuthnType;
		public static string CtrlAccess;
		public static string TE032301;
		public static string idleState;
		public static string RolesAndServicesList;
		public static string ServicesListForAuthRole;
		public static string UnauthorizedServices;
		public static string text1;
		public static string text2;
		public static string text3;
		public static string text4;
		public static string text5;
		public static string textBox_TE030301_txt;
		public static string textBox_TE030601_txt;
		public static string textBox_TE031101_txt;
		public static string textBox_TE031102_txt;
		public static string textBox_TE031501_txt;

		public RolesAndServices()
		{
			InitializeComponent();

			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";

			MaintenanceRole_SC         = Properties.Settings.Default.MaintenanceRole_SC.ToString();
			MaintenanceRole_MCS        = Properties.Settings.Default.MaintenanceRole_MCS.ToString();
			MaintenanceRole_MCE        = Properties.Settings.Default.MaintenanceRole_MCE.ToString();
			RolesServicesSecurityLevel = Properties.Settings.Default.RolesServicesSecurityLevel.ToString();
			AS0318                     = Properties.Settings.Default.AS0318.ToString();
			AS0302                     = Properties.Settings.Default.AS0302.ToString();
			BypassCapability           = Properties.Settings.Default.BypassCapability.ToString();
			AuthnType                  = Properties.Settings.Default.AuthnType.ToString();
			CtrlAccess                 = Properties.Settings.Default.CtrlAccess.ToString();
			TE032301                   = Properties.Settings.Default.TE032301.ToString();
			idleState                  = Properties.Settings.Default.idleState.ToString();
			RolesAndServicesList       = Properties.Settings.Default.RolesAndServicesList.ToString();
			ServicesListForAuthRole    = Properties.Settings.Default.ServicesListForAuthRole.ToString();
			UnauthorizedServices       = Properties.Settings.Default.UnauthorizedServices.ToString();

			textBox_TE030301_txt = Properties.Settings.Default.textBox_TE030301_txt.ToString();
			textBox_TE030601_txt = Properties.Settings.Default.textBox_TE030601_txt.ToString();
			textBox_TE031101_txt = Properties.Settings.Default.textBox_TE031101_txt.ToString();
			textBox_TE031102_txt = Properties.Settings.Default.textBox_TE031102_txt.ToString();
			textBox_TE031501_txt = Properties.Settings.Default.textBox_TE031501_txt.ToString();


			if (BypassCapability == "Checked" || BypassCapability == "True")
			{
				checkBox_BypassCapability.Checked = true;
			}

			if (AS0302 == "Checked" || AS0302 == "True")
			{
				checkBox_AS0302.Checked = true;
			}

			if (idleState == "Checked" || idleState == "True")
			{
				checkBox_idleState.Checked = true;
			}
			
			if (AuthnType == "No authentication")
			{
				comboBox_AuthnticationType.SelectedItem = "No authentication";
			}
			else if(AuthnType == "Identity-based authentication")
			{
				comboBox_AuthnticationType.SelectedItem = "Identity-based authentication";
			}
			else if (AuthnType == "Role-based authentication")
			{
				comboBox_AuthnticationType.SelectedItem = "Role-based authentication";
			}

			if (RolesServicesSecurityLevel == "Level 2" || RolesServicesSecurityLevel == "Level 3" || RolesServicesSecurityLevel == "Level 4")
			{
				checkBox_ChangeRoles.Visible = true;
				AS0318 = checkBox_ChangeRoles.Checked.ToString();
			}
			else
			{
				checkBox_ChangeRoles.Visible = false;
			}

			comboBox1.SelectedItem = CtrlAccess;
			txtbox_TE032301.Text   = TE032301;
		}

		private void RolesAndServices_Load(object sender, EventArgs e)
		{

		}

		private void RolesAndServices_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				//connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
				connection.Open();
				command.Connection = connection;

				AS0302 = checkBox_AS0302.Checked.ToString();
				Properties.Settings.Default.AS0302 = AS0302;

				BypassCapability = checkBox_BypassCapability.Checked.ToString();
				Properties.Settings.Default.BypassCapability = BypassCapability;

				AuthnType = comboBox_AuthnticationType.SelectedItem.ToString();
				Properties.Settings.Default.AuthnType = AuthnType;

				CtrlAccess = comboBox1.SelectedItem.ToString();
				Properties.Settings.Default.CtrlAccess = CtrlAccess;

				TE032301 = txtbox_TE032301.Text;
				Properties.Settings.Default.TE032301 = TE032301;

				idleState = checkBox_idleState.Checked.ToString();
				Properties.Settings.Default.idleState = idleState;

				Properties.Settings.Default.Save();

				RolesServicesAssertions f4 = new RolesServicesAssertions();
				f4.populateRolesServicesLevel1();
				f4.populateRolesServicesLevel1234();
				f4.populateRolesServicesLevel2();
				f4.populateRolesServicesLevel234();
				f4.populateRolesServicesLevel34();
				f4.populateRolesServicesLevel4();

				e.Cancel = false;

				connection.Close();
			}
			else if (result == DialogResult.No)
			{
				e.Cancel = false;
			}
			else if (result == DialogResult.Cancel)
			{
				e.Cancel = true;

				//e.Cancel = (result == DialogResult.No);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void comboBox_AuthnticationType_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btn_AddRoles_Click(object sender, EventArgs e)
		{
			AddRolesServices f1 = new AddRolesServices();
			f1.ShowDialog();

			//// Set to details view.
			//listView1.View = View.Details;
			//// Add a column with width w and left alignment.
			////listView1.Columns.Add("File type", 200, HorizontalAlignment.Left);
			//string role = textBox_AddtoList.Text;
			//listView1.Columns.Add(role, 200, HorizontalAlignment.Left);
			//textBox_AddtoList.Text = "";
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox_AddtoList_TextChanged(object sender, EventArgs e)
		{

		}

		//private void btn_AddServices_Click(object sender, EventArgs e)
		//{
		//	ListViewItem item = new ListViewItem();
		//	listView1.Items.Add(textBox_TE030301.Text);
		//	//listView1.Items[1].SubItems[1].Text = textBox_AddtoList.Text;
		//	textBox_TE030301.Text = "";
		//}

		private void btn_TE030301_Click(object sender, EventArgs e)
		{
			textBox_TE030301.Visible = true;
			textBox_TE030601.Visible = false;
			textBox_TE031101.Visible = false;
			textBox_TE031102.Visible = false;
			textBox_TE031501.Visible = false;
			RolesServicesAssertions f1 = new RolesServicesAssertions();
			f1.populateRolesServicesLevel1234();

			text1 = "The tester reviewed vendor documentation and verified that a User role and a Crypto-Officer role are defined. " +
				"These roles are specified by name and allowed services and are described as specified in AS.03.03. " +
				"The services allocated to each defined role are as follows:" + Environment.NewLine + Environment.NewLine;
			textBox_TE030301.Text = text1 + RolesAndServicesList;
			textBox_TE030301_txt  = text1 + RolesAndServicesList;
			RolesServicesAssertions.textBox_TE030301_txt = textBox_TE030301_txt;
		}

		private void btn_TE030601_Click(object sender, EventArgs e)
		{
			textBox_TE030301.Visible = false;
			textBox_TE030601.Visible = true;
			textBox_TE031101.Visible = false;
			textBox_TE031102.Visible = false;
			textBox_TE031501.Visible = false;
			RolesServicesAssertions f1 = new RolesServicesAssertions();
			f1.populateRolesServicesLevel1234();

			text2 = "The tester reviewed vendor documentation and verified that, for each defined role, the name and available " +
				"services for the role are specified. The defined roles and services are as follows:" + Environment.NewLine + Environment.NewLine;
			textBox_TE030601.Text = text2 + RolesAndServicesList;
			textBox_TE030601_txt  = text2 + RolesAndServicesList;
			RolesServicesAssertions.textBox_TE030601_txt = textBox_TE030601_txt;
		}

		private void btn_TE031101_Click(object sender, EventArgs e)
		{
			textBox_TE030301.Visible = false;
			textBox_TE030601.Visible = false;
			textBox_TE031101.Visible = true;
			textBox_TE031102.Visible = false;
			textBox_TE031501.Visible = false;
			RolesServicesAssertions f1 = new RolesServicesAssertions();
			f1.populateRolesServicesLevel1234();

			text3 = "The tester reviewed vendor documentation and verified that the ''Get Device Status'' service and" +
				" the user callable self-test initiation service are each allocated to at least one authorized role." +
				" The tester verified that these services are described as specified in AS03.14." + Environment.NewLine + Environment.NewLine;
			textBox_TE031101.Text = text3 + ServicesListForAuthRole;
			textBox_TE031101_txt = text3 + ServicesListForAuthRole;
			RolesServicesAssertions.textBox_TE031101_txt = textBox_TE031101_txt;
		}

		private void btn_TE031102_Click(object sender, EventArgs e)
		{
			textBox_TE030301.Visible = false;
			textBox_TE030601.Visible = false;
			textBox_TE031101.Visible = false;
			textBox_TE031102.Visible = true;
			textBox_TE031501.Visible = false;
			RolesServicesAssertions f1 = new RolesServicesAssertions();
			f1.populateRolesServicesLevel1234();

			text4 = "The tester verified that the Show Status indicator matches vendor documentation. The tester " +
				"verified that the ''Get Device Status'' returned messages matching vendor documentation." + Environment.NewLine + Environment.NewLine;
			textBox_TE031102.Text = text4 + ServicesListForAuthRole;
			textBox_TE031102_txt = text4 + ServicesListForAuthRole;
			RolesServicesAssertions.textBox_TE031102_txt = textBox_TE031102_txt;
		}

		private void btn_TE031501_Click(object sender, EventArgs e)
		{
			textBox_TE030301.Visible = false;
			textBox_TE030601.Visible = false;
			textBox_TE031101.Visible = false;
			textBox_TE031102.Visible = false;
			textBox_TE031501.Visible = true;
			RolesServicesAssertions f1 = new RolesServicesAssertions();
			f1.populateRolesServicesLevel1234();

			text5 = "The tester reviewed vendor documentation and verified that it describes the purpose and function of each service," +
				" the service inputs, and the corresponding service outputs. Please see TE.03.06.01 for a list of roles and services." + Environment.NewLine +
				"The module provides the following unauthenticated services:" + Environment.NewLine + Environment.NewLine;
			textBox_TE031501.Text = text5 + UnauthorizedServices;
			textBox_TE031501_txt = text5 + UnauthorizedServices;
			RolesServicesAssertions.textBox_TE031501_txt = textBox_TE031501_txt;
		}

		private void btn_serviceAuthorizedRole_Click(object sender, EventArgs e)
		{
			ServicesForAuthRole f1 = new ServicesForAuthRole();
			f1.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UnauthenticatedService f1 = new UnauthenticatedService();
			f1.ShowDialog();
		}

		private void btn_refresh_Click(object sender, EventArgs e)
		{
			textBox_TE030301_txt = RolesServicesAssertions.textBox_TE030301_txt;
			textBox_TE030601_txt = RolesServicesAssertions.textBox_TE030601_txt;
			textBox_TE031101_txt = RolesServicesAssertions.textBox_TE031101_txt;
			textBox_TE031102_txt = RolesServicesAssertions.textBox_TE031102_txt;
			textBox_TE031501_txt = RolesServicesAssertions.textBox_TE031501_txt;
		}

		public void populateRolesServicesLevel1234()
		{
			textBox_TE030301_txt = text1 + textBox_TE030301.Text;
			textBox_TE030601_txt = text2 + textBox_TE030601.Text;
			textBox_TE031101_txt = text3 + textBox_TE031101.Text;
			textBox_TE031102_txt = text4 + textBox_TE031102.Text;
			textBox_TE031501_txt = text5 + textBox_TE031501.Text;
		}

		private void checkBox_BypassCapability_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_BypassCapability.Checked)
			{
				connection.Open();
				command.Connection = connection;
				//command.CommandText = "UPDATE GeneralVendorInfo SET By Pass = TRUE ";
				//command.ExecuteNonQuery();
				connection.Close();
			}
			else
			{
				connection.Open();
				command.Connection = connection;
				//command.CommandText = "UPDATE GeneralVendorInfo SET By Pass ='" + 0 + "";
				//command.CommandText = "INSERT INTO GeneralVendorInfo SET By Pass = FALSE";
				//"Insert into Company (dev) values ('" + IIf(CheckBox1.Checked, "yes", "no") + "')"
				//command.ExecuteNonQuery();

				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 12 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 12 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 12 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 12 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 13 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 13 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 13 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();

				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 44 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 45 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 45 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 45 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 45 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 46 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 46 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 46 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 46 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 47 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 48 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();

				//command.ExecuteNonQuery();
				connection.Close();
			}			
		}
	}
}