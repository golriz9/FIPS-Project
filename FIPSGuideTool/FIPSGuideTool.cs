using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using FIPSGuideTool.Properties;
using System.IO;



namespace FIPSGuideTool
{
	public partial class FIPSGuideTool : Form
	{
		public OleDbConnection connection = new OleDbConnection();
		
		public static string strfilepath;
		public static string DBPathString;
		public static bool checkCryptik;
		public static string ServerVers;
		public static string JsonfilePathStr;

		OleDbCommand command = new OleDbCommand();
		OleDbDataReader dataSearch;


		public FIPSGuideTool()
		{
			InitializeComponent();
			this.Size = Screen.PrimaryScreen.WorkingArea.Size;
		}

		private void FIPSGuideTool_Load(object sender, EventArgs e)
		{							
			strfilepath = Properties.Settings.Default.DBPath.ToString();
			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strfilepath + ";Persist Security Info=False;";
			//JsonfilePathStr = Properties.Settings.Default.JsonfilePathStr.ToString();

			if (strfilepath == null)
			{
				//connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
				connection.Open();
				command.Connection = connection;
				command.CommandText = "SELECT * FROM GeneralVendorInfo";
				dataSearch = command.ExecuteReader();

				while (dataSearch.Read())
				{
					Properties.Settings.Default.SpecSecurityLevel = dataSearch.GetValue(29).ToString();
					Properties.Settings.Default.PortsInterfacesSecurityLevel = dataSearch.GetValue(30).ToString();
					Properties.Settings.Default.RolesServicesSecurityLevel = dataSearch.GetValue(31).ToString();
					Properties.Settings.Default.FSMSecurityLevel = dataSearch.GetValue(32).ToString();
					Properties.Settings.Default.PhysicalSecurityLevel = dataSearch.GetValue(33).ToString();
					Properties.Settings.Default.OpEnvironmentSecurityLevel = dataSearch.GetValue(34).ToString();
					Properties.Settings.Default.KeyManagementSecurityLevel = dataSearch.GetValue(35).ToString();
					Properties.Settings.Default.EMI_EMCSecurityLevel = dataSearch.GetValue(36).ToString();
					Properties.Settings.Default.SelfTestsSecurityLevel = dataSearch.GetValue(37).ToString();
					Properties.Settings.Default.DesignAssuranceSecurityLevel = dataSearch.GetValue(38).ToString();
					Properties.Settings.Default.MitigationAttacksSecurityLevel = dataSearch.GetValue(39).ToString();
					Properties.Settings.Default.Save();
				}
				dataSearch.Close();
				connection.Close();
			}
			else
			{
				if (File.Exists(strfilepath))
				{
					connection.Open();
					CheckConnection.Text = strfilepath;
				}
				else
				{
					string m1 = "The cryptik tool does not exist. Please open one.";
					MessageBox.Show(m1);
				}				
			}		
		}

		private void btn_CrypticTool_Click(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				CrypticTool f1 = new CrypticTool();
				//this.Hide();
				f1.ShowDialog();
			}		
		}

		private void btn_ModuleInfo_Click(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				ModuleSpecs f2 = new ModuleSpecs();
				//this.Hide();
				f2.ShowDialog();

				// Added
				SpecificationsAssertions f3 = new SpecificationsAssertions();
				f3.populateSpecLevel1234();
				f3.populateSpecLevel34();
			}
			

		}

		private void btn_PhySec_Click(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				PhysicalSecurity f3 = new PhysicalSecurity();
				//this.Hide();
				f3.ShowDialog();
			}

		}

		private void btn_browseCryptic_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDlg = new OpenFileDialog();

			if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				strfilepath = openFileDlg.FileName;
				//Properties.Settings.Default.Upgrade();
				Properties.Settings.Default.DBPath = strfilepath;
				Properties.Settings.Default.Save();
			}
			else
			{
				strfilepath = null;
			}

			if (strfilepath == null) 
			{

			}
			else
			{				
				connection.Close();
				connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strfilepath + ";Persist Security Info=False;";
				//connection.Open();
				//CheckConnection.Text = "Successful connection.";
				string tempString = CheckConnection.Text;
				CheckConnection.Text = strfilepath;
				checkCryptik = strfilepath.Equals(tempString);
				if (strfilepath == null)
				{

				}
				else
				{
					connection.Open();
					command.Connection = connection;
					command.CommandText = "SELECT * FROM GeneralVendorInfo";
					dataSearch = command.ExecuteReader();

					while (dataSearch.Read())
					{
						Properties.Settings.Default.SpecSecurityLevel = dataSearch.GetValue(29).ToString();
						Properties.Settings.Default.PortsInterfacesSecurityLevel = dataSearch.GetValue(30).ToString();
						Properties.Settings.Default.RolesServicesSecurityLevel = dataSearch.GetValue(31).ToString();
						Properties.Settings.Default.FSMSecurityLevel = dataSearch.GetValue(32).ToString();
						Properties.Settings.Default.PhysicalSecurityLevel = dataSearch.GetValue(33).ToString();
						Properties.Settings.Default.OpEnvironmentSecurityLevel = dataSearch.GetValue(34).ToString();
						Properties.Settings.Default.KeyManagementSecurityLevel = dataSearch.GetValue(35).ToString();
						Properties.Settings.Default.EMI_EMCSecurityLevel = dataSearch.GetValue(36).ToString();
						Properties.Settings.Default.SelfTestsSecurityLevel = dataSearch.GetValue(37).ToString();
						Properties.Settings.Default.DesignAssuranceSecurityLevel = dataSearch.GetValue(38).ToString();
						Properties.Settings.Default.MitigationAttacksSecurityLevel = dataSearch.GetValue(39).ToString();
						Properties.Settings.Default.Save();
					}
					dataSearch.Close();
					connection.Close();

				}				
			}			
		}

		private void btn_exit_Click(object sender, EventArgs e)
		{
			connection.Close();
			this.Close();
		}

		private void btn_KeyManage_Click(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				////Added
				//FSMAssertions f7 = new FSMAssertions();
				//f7.populateFSMLevel1234();

				//string m1 = "Successfully populated Area 4.";
				//MessageBox.Show(m1);
				KeyManagement f7 = new KeyManagement();
				f7.ShowDialog();
			}
		}

		private void btn_Algorithm_Click(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				Algorithms f4 = new Algorithms();
				//this.Hide();
				f4.ShowDialog();
			}
		}


		private void btn_reset_cryptic_Click(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				//connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
				connection.Open();
				OleDbCommand command = new OleDbCommand();
				command.Connection = connection;
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + null + "' ";
				command.ExecuteNonQuery();
				connection.Close();
			}
		}

		private void btn_PortInterface_Click(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				PortsAndInterfaces f5 = new PortsAndInterfaces();				
				f5.ShowDialog();

				//Added
				PortsInterfacesAssertions f6 = new PortsInterfacesAssertions();
				f6.populatePortInterfaceLevel1234();
				f6.populatePortInterfaceLevel34();
			}
		}

		private void btn_RolesServices_Click(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				RolesAndServices f6 = new RolesAndServices();
				//this.Hide();
				f6.ShowDialog();

				//Added
				RolesServicesAssertions f7 = new RolesServicesAssertions();
				f7.populateRolesServicesLevel1();
				f7.populateRolesServicesLevel1234();
				f7.populateRolesServicesLevel2();
				f7.populateRolesServicesLevel234();
				f7.populateRolesServicesLevel34();
				f7.populateRolesServicesLevel4();
			}
		}

		private void btn_OpEnvironment_Click(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				OpEnvironment f7 = new OpEnvironment();
				//this.Hide();
				f7.ShowDialog();

				OpEnvironmentAssertions f8 = new OpEnvironmentAssertions();
				f8.populateOpEnvironmentLevel1();
				f8.populateOpEnvironmentLevel1234();
				f8.populateOpEnvironmentLevel2();
				f8.populateOpEnvironmentLevel234();
				f8.populateOpEnvironmentLevel3();
				f8.populateOpEnvironmentLevel34();
				f8.populateOpEnvironmentLevel4();
			}
		}

		private void btn_EMI_EMC_Click(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				EMI_EMC f8 = new EMI_EMC();
				//this.Hide();
				f8.ShowDialog();

				EMI_EMCAssertions f9 = new EMI_EMCAssertions();
				f9.populateEMI_EMCLevel12();
				f9.populateEMI_EMCLevel1234();
				f9.populateEMI_EMCLevel34();
			}
		}

		private void btn_SelfTests_Click(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				SelfTests f9 = new SelfTests();
				//this.Hide();
				f9.ShowDialog();
				SelfTestsAssertions f10 = new SelfTestsAssertions();
				f10.populateSelfTestsLevel1234();
			}
		}

		private void btn_OpTesting_Click(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				OpTesting f10 = new OpTesting();
				f10.ShowDialog();
			}			
		}

		private void btn_ModuleInfo_Click_1(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				//PortsAndInterfaces f5 = new PortsAndInterfaces();
				//f5.ShowDialog();

				////Added
				//PortsInterfacesAssertions f6 = new PortsInterfacesAssertions();
				//f6.populatePortInterfaceLevel1234();
				//f6.populatePortInterfaceLevel34();
			}
		}

		private void btn_FSM_Click(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				//Added
				FSMAssertions f7 = new FSMAssertions();
				f7.populateFSMLevel1234();

				//string m1 = "Successfully populated Area 4.";
				//MessageBox.Show(m1);
				PopulateFSM f8 = new PopulateFSM();
				f8.ShowDialog();
			}			
		}

		private void btn_DesAssurance_Click(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				//Added
				DesignAssuranceAssertions f7 = new DesignAssuranceAssertions();
				f7.populateDesignAssuranceLevel1234();
				f7.populateDesignAssuranceLevel234();
				f7.populateDesignAssuranceLevel34();
				f7.populateDesignAssuranceLevel4();

				//string m1 = "Successfully populated Area 10.";
				//MessageBox.Show(m1);
				PopulateDesignAssurance f8 = new PopulateDesignAssurance();
				f8.ShowDialog();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (CheckConnection.Text == "")
			{
				string m1 = "Please browse the desired cryptic tool.";
				MessageBox.Show(m1);
			}
			else if (CheckConnection.Text == strfilepath)
			{
				//Added
				MitigationOtherAttacksAssertions f7 = new MitigationOtherAttacksAssertions();
				f7.populateMitigationOtherAttacksLevel1234();
				//string m1 = "Successfully populated Area 11.";
				//MessageBox.Show(m1);
				PopulateMitigation f8 = new PopulateMitigation();
				f8.ShowDialog();
			}
		}

		private void btn_Entropy_Click(object sender, EventArgs e)
		{

		}
	}
}
