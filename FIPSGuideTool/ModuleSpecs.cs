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
	public partial class ModuleSpecs : Form
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();
		OleDbDataReader dataSearch;

		public static string PhysicalSecurityLevel;
		public static string SpecSecurityLevel;
		public static string PortsInterfacesSecurityLevel;
		public static string RolesServicesSecurityLevel;
		public static string FSMSecurityLevel;
		public static string OpEnvironmentSecurityLevel;
		public static string KeyManagementSecurityLevel;
		public static string EMI_EMCSecurityLevel;
		public static string SelfTestsSecurityLevel;
		public static string DesignAssuranceSecurityLevel;
		public static string MitigationAttacksSecurityLevel;

		public static string TE010802_processor; 
		public static string TE010802_ROM;
		public static string TE010802_RAM;
		public static string TE010802_SemiCustomIC;
		public static string TE010802_FullCustomIC;
		public static string TE010802_activeComp;
		public static string TE010802_pwr;
		public static string TE010802_phyExtConnect;
		public static string TE010802_NonMod_FWSW;
		public static string TE010802_ModFWSW;
		public static string TE010802_otherComponents;
		public static string TE010808_excld;
		public static string TE010803_CoolingSys;
		public static string FWSVersion;
		public static string ExComponents_YesNo;
		public static string CoolingSys_YesNo;

		public ModuleSpecs()
		{
			InitializeComponent();
			//txt_ExComponents.Visible = false;
			//label24.Visible = false;
			txt_CoolingSys.Visible = false;
			label27.Visible = false;

			PhysicalSecurityLevel          = Properties.Settings.Default.PhysicalSecurityLevel.ToString();
			SpecSecurityLevel              = Properties.Settings.Default.SpecSecurityLevel.ToString();
			PortsInterfacesSecurityLevel   = Properties.Settings.Default.PortsInterfacesSecurityLevel.ToString();
			RolesServicesSecurityLevel     = Properties.Settings.Default.RolesServicesSecurityLevel.ToString();
			FSMSecurityLevel               = Properties.Settings.Default.FSMSecurityLevel.ToString();
			OpEnvironmentSecurityLevel     = Properties.Settings.Default.OpEnvironmentSecurityLevel.ToString();
			KeyManagementSecurityLevel     = Properties.Settings.Default.KeyManagementSecurityLevel.ToString();
			EMI_EMCSecurityLevel           = Properties.Settings.Default.EMI_EMCSecurityLevel.ToString();
			SelfTestsSecurityLevel         = Properties.Settings.Default.SelfTestsSecurityLevel.ToString();
			DesignAssuranceSecurityLevel   = Properties.Settings.Default.DesignAssuranceSecurityLevel.ToString();
			MitigationAttacksSecurityLevel = Properties.Settings.Default.MitigationAttacksSecurityLevel.ToString();
			TE010802_processor             = Properties.Settings.Default.TE010802_processor.ToString();
			TE010802_ROM				   = Properties.Settings.Default.TE010802_ROM.ToString();
			TE010802_RAM				   = Properties.Settings.Default.TE010802_RAM.ToString();
			TE010802_SemiCustomIC		   = Properties.Settings.Default.TE010802_SemiCustomIC.ToString();
			TE010802_FullCustomIC		   = Properties.Settings.Default.TE010802_FullCustomIC.ToString();
			TE010802_activeComp			   = Properties.Settings.Default.TE010802_activeComp.ToString();
			TE010802_pwr                   = Properties.Settings.Default.TE010802_pwr.ToString();
			TE010802_phyExtConnect         = Properties.Settings.Default.TE010802_phyExtConnect.ToString();
			TE010802_NonMod_FWSW           = Properties.Settings.Default.TE010802_NonMod_FWSW.ToString();
			TE010802_ModFWSW               = Properties.Settings.Default.TE010802_ModFWSW.ToString();
			TE010802_otherComponents       = Properties.Settings.Default.TE010802_otherComponents.ToString();
			TE010808_excld                 = Properties.Settings.Default.TE010808_excld.ToString();
			TE010803_CoolingSys            = Properties.Settings.Default.TE010803_CoolingSys.ToString();
			ExComponents_YesNo             = Properties.Settings.Default.ExComponents_YesNo.ToString();
			CoolingSys_YesNo               = Properties.Settings.Default.CoolingSys_YesNo.ToString();


			if (PhysicalSecurityLevel == "1")
			{
				PhysicalSecurityLevel = "Level 1";
			}
			if (PhysicalSecurityLevel == "2")
			{
				PhysicalSecurityLevel = "Level 2";
			}
			if (PhysicalSecurityLevel == "3")
			{
				PhysicalSecurityLevel = "Level 3";
			}
			if (PhysicalSecurityLevel == "4")
			{
				PhysicalSecurityLevel = "Level 4";
			}

			if (SpecSecurityLevel == "1")
			{
				SpecSecurityLevel = "Level 1";
			}
			if (SpecSecurityLevel == "2")
			{
				SpecSecurityLevel = "Level 2";
			}
			if (SpecSecurityLevel == "3")
			{
				SpecSecurityLevel = "Level 3";
			}
			if (SpecSecurityLevel == "4")
			{
				SpecSecurityLevel = "Level 4";
			}

			if (PortsInterfacesSecurityLevel == "1")
			{
				PortsInterfacesSecurityLevel = "Level 1";
			}
			if (PortsInterfacesSecurityLevel == "2")
			{
				PortsInterfacesSecurityLevel = "Level 2";
			}
			if (PortsInterfacesSecurityLevel == "3")
			{
				PortsInterfacesSecurityLevel = "Level 3";
			}
			if (PortsInterfacesSecurityLevel == "4")
			{
				PortsInterfacesSecurityLevel = "Level 4";
			}

			if (RolesServicesSecurityLevel == "1")
			{
				RolesServicesSecurityLevel = "Level 1";
			}
			if (RolesServicesSecurityLevel == "2")
			{
				RolesServicesSecurityLevel = "Level 2";
			}
			if (RolesServicesSecurityLevel == "3")
			{
				RolesServicesSecurityLevel = "Level 3";
			}
			if (RolesServicesSecurityLevel == "4")
			{
				RolesServicesSecurityLevel = "Level 4";
			}

			if (FSMSecurityLevel == "1")
			{
				FSMSecurityLevel = "Level 1";
			}
			if (FSMSecurityLevel == "2")
			{
				FSMSecurityLevel = "Level 2";
			}
			if (FSMSecurityLevel == "3")
			{
				FSMSecurityLevel = "Level 3";
			}
			if (FSMSecurityLevel == "4")
			{
				FSMSecurityLevel = "Level 4";
			}

			if (OpEnvironmentSecurityLevel == "1")
			{
				OpEnvironmentSecurityLevel = "Level 1";
			}
			if (OpEnvironmentSecurityLevel == "2")
			{
				OpEnvironmentSecurityLevel = "Level 2";
			}
			if (OpEnvironmentSecurityLevel == "3")
			{
				OpEnvironmentSecurityLevel = "Level 3";
			}
			if (OpEnvironmentSecurityLevel == "4")
			{
				OpEnvironmentSecurityLevel = "Level 4";
			}

			if (KeyManagementSecurityLevel == "1")
			{
				KeyManagementSecurityLevel = "Level 1";
			}
			if (KeyManagementSecurityLevel == "2")
			{
				KeyManagementSecurityLevel = "Level 2";
			}
			if (KeyManagementSecurityLevel == "3")
			{
				KeyManagementSecurityLevel = "Level 3";
			}
			if (KeyManagementSecurityLevel == "4")
			{
				KeyManagementSecurityLevel = "Level 4";
			}

			if (EMI_EMCSecurityLevel == "1")
			{
				EMI_EMCSecurityLevel = "Level 1";
			}
			if (EMI_EMCSecurityLevel == "2")
			{
				EMI_EMCSecurityLevel = "Level 2";
			}
			if (EMI_EMCSecurityLevel == "3")
			{
				EMI_EMCSecurityLevel = "Level 3";
			}
			if (EMI_EMCSecurityLevel == "4")
			{
				EMI_EMCSecurityLevel = "Level 4";
			}

			if (SelfTestsSecurityLevel == "1")
			{
				SelfTestsSecurityLevel = "Level 1";
			}
			if (SelfTestsSecurityLevel == "2")
			{
				SelfTestsSecurityLevel = "Level 2";
			}
			if (SelfTestsSecurityLevel == "3")
			{
				SelfTestsSecurityLevel = "Level 3";
			}
			if (SelfTestsSecurityLevel == "4")
			{
				SelfTestsSecurityLevel = "Level 4";
			}

			if (DesignAssuranceSecurityLevel == "1")
			{
				DesignAssuranceSecurityLevel = "Level 1";
			}
			if (DesignAssuranceSecurityLevel == "2")
			{
				DesignAssuranceSecurityLevel = "Level 2";
			}
			if (DesignAssuranceSecurityLevel == "3")
			{
				DesignAssuranceSecurityLevel = "Level 3";
			}
			if (DesignAssuranceSecurityLevel == "4")
			{
				DesignAssuranceSecurityLevel = "Level 4";
			}

			if (MitigationAttacksSecurityLevel == "1")
			{
				MitigationAttacksSecurityLevel = "Level 1";
			}
			if (MitigationAttacksSecurityLevel == "2")
			{
				MitigationAttacksSecurityLevel = "Level 2";
			}
			if (MitigationAttacksSecurityLevel == "3")
			{
				MitigationAttacksSecurityLevel = "Level 3";
			}
			if (MitigationAttacksSecurityLevel == "4")
			{
				MitigationAttacksSecurityLevel = "Level 4";
			}

			comboBox1.SelectedItem  = SpecSecurityLevel;
			comboBox2.SelectedItem  = PortsInterfacesSecurityLevel;
			comboBox3.SelectedItem  = RolesServicesSecurityLevel;
			comboBox4.SelectedItem  = FSMSecurityLevel;
			comboBox5.SelectedItem  = PhysicalSecurityLevel;
			comboBox6.SelectedItem  = OpEnvironmentSecurityLevel;
			comboBox7.SelectedItem  = KeyManagementSecurityLevel;
			comboBox8.SelectedItem  = EMI_EMCSecurityLevel;
			comboBox9.SelectedItem  = SelfTestsSecurityLevel;
			comboBox10.SelectedItem = DesignAssuranceSecurityLevel;
			comboBox11.SelectedItem = MitigationAttacksSecurityLevel;
			comboBox12.SelectedItem = ExComponents_YesNo;
			comboBox13.SelectedItem = CoolingSys_YesNo;
			//txt_ExComponents.Text   = TE010803_ExComponents;
			txt_CoolingSys.Text     = TE010803_CoolingSys;

		}

		private void label13_Click(object sender, EventArgs e)
		{

		}


		private void ModuleInfo_Load_1(object sender, EventArgs e)
		{
			
		}

		private void ModModule_SelectedIndexChanged(object sender, EventArgs e)
		{
		
		}

		private void label13_Click_1(object sender, EventArgs e)
		{

		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void txt_ExComponents_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_Processors_Click(object sender, EventArgs e)
		{
			Processors f1 = new Processors();
			f1.ShowDialog();			
		}

		private void btn_ROMFlash_Click(object sender, EventArgs e)
		{
			ROMFlash f1 = new ROMFlash();
			f1.ShowDialog();
		}

		private void btn_RAM_Click(object sender, EventArgs e)
		{
			RAM f1 = new RAM();
			f1.ShowDialog();
		}

		private void btn_activeCompon_Click(object sender, EventArgs e)
		{
			ActiveComponents f1 = new ActiveComponents();
			f1.ShowDialog();
		}

		private void btn_nonModFWSW_Click(object sender, EventArgs e)
		{
			nonModifFWSW f1 = new nonModifFWSW();
			f1.ShowDialog();
		}

		private void btn_FWVersion_Click(object sender, EventArgs e)
		{
			FWVersion f1 = new FWVersion();
			f1.ShowDialog();
		}

		private void btn_SemiCustom_Click(object sender, EventArgs e)
		{
			SemiCustomIC f1 = new SemiCustomIC();
			f1.ShowDialog();
		}

		private void btn_FullyCustom_Click(object sender, EventArgs e)
		{
			FullyCustomIC f1 = new FullyCustomIC();
			f1.ShowDialog();
		}

		private void btn_PwrSupply_Click(object sender, EventArgs e)
		{
			PwrSupply f1 = new PwrSupply();
			f1.ShowDialog();
		}

		private void btn_PhyExtConn_Click(object sender, EventArgs e)
		{
			PhysExtConnector f1 = new PhysExtConnector();
			f1.ShowDialog();
		}

		private void btn_ModFWSW_Click(object sender, EventArgs e)
		{
			ModifFWSW f1 = new ModifFWSW();
			f1.ShowDialog();
		}

		private void comboBox13_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (comboBox13.SelectedItem.ToString() == "Yes")
			{
				txt_CoolingSys.Visible = true;
				label27.Visible = true;
				txt_CoolingSys.Text = "";
				CoolingSys_YesNo    = "Yes";
			}
			else if (comboBox13.SelectedItem.ToString() == "No")
			{
				txt_CoolingSys.Visible = false;
				label27.Visible = false;
				txt_CoolingSys.Text = "N/A";
				CoolingSys_YesNo = "No";
			}
		}

		private void comboBox12_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			//if (comboBox12.SelectedItem.ToString() == "Yes")
			//{
			//	//txt_ExComponents.Visible = true;
			//	//label24.Visible          = true;
			//	//txt_ExComponents.Text    = "";
			//	//ExComponents_YesNo       = "Yes";

			//	//ExcludedComponents f1 = new ExcludedComponents();
			//	//f1.ShowDialog();

			//}
			//else if (comboBox12.SelectedItem.ToString() == "No")
			//{
			//	//txt_ExComponents.Visible = false;
			//	//label24.Visible          = false;
			//	//txt_ExComponents.Text = "N/A";
			//	//ExComponents_YesNo = "No";
			//}
		}

		private void textBoxTE_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_refresh_Click(object sender, EventArgs e)
		{
			//TE010803_ExComponents = txt_ExComponents.Text;
			TE010803_CoolingSys = txt_CoolingSys.Text;

			SpecificationsAssertions f1 = new SpecificationsAssertions();
			f1.populateSpecLevel1234();
			f1.populateSpecLevel34();

			textBoxTE010802.Text = SpecificationsAssertions.TE010802_txt;

			textBoxTE010808.Text = SpecificationsAssertions.TE010808_txt;

			textBoxTE010812.Text = SpecificationsAssertions.TE010812_txt;		
						
		}

		private void btn_otherComponents_Click(object sender, EventArgs e)
		{
			OtherComponents f1 = new OtherComponents();
			f1.ShowDialog();
		}

		private void ModuleInfo_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				if (comboBox5.SelectedItem == null || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
				{
					string m1 = "Please make sure all fields are chosen appropriately.";
					MessageBox.Show(m1);
				}
				else
				{
					connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
					connection.Open();

					command.Connection = connection;

					SpecSecurityLevel = comboBox1.SelectedItem.ToString();
					Properties.Settings.Default.SpecSecurityLevel = SpecSecurityLevel;
					if (SpecSecurityLevel == "Level 1")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section1Level='" + 1 + "'";
						command.ExecuteNonQuery();
					}
					else if (SpecSecurityLevel == "Level 2")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section1Level='" + 2 + "'"; 
						command.ExecuteNonQuery();
					}
					else if (SpecSecurityLevel == "Level 3")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section1Level='" + 3 + "'"; 
						command.ExecuteNonQuery();
					}
					else if (SpecSecurityLevel == "Level 4")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section1Level='" + 4 + "'";
						command.ExecuteNonQuery();
					}

					PortsInterfacesSecurityLevel = comboBox2.SelectedItem.ToString();
					Properties.Settings.Default.PortsInterfacesSecurityLevel = PortsInterfacesSecurityLevel;
					if (PortsInterfacesSecurityLevel == "Level 1")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section2Level='" + 1 + "'";
						command.ExecuteNonQuery();
					}
					else if (PortsInterfacesSecurityLevel == "Level 2")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section2Level='" + 2 + "'"; 
						command.ExecuteNonQuery();
					}
					else if (PortsInterfacesSecurityLevel == "Level 3")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section2Level='" + 3 + "'";
						command.ExecuteNonQuery();
					}
					else if (PortsInterfacesSecurityLevel == "Level 4")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section2Level='" + 4 + "'";
						command.ExecuteNonQuery();
					}

					RolesServicesSecurityLevel = comboBox3.SelectedItem.ToString();
					Properties.Settings.Default.RolesServicesSecurityLevel = RolesServicesSecurityLevel;
					if (RolesServicesSecurityLevel == "Level 1")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section3Level='" + 1 + "'";
						command.ExecuteNonQuery();
					}
					else if (RolesServicesSecurityLevel == "Level 2")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section3Level='" + 2 + "'";
						command.ExecuteNonQuery();
					}
					else if (RolesServicesSecurityLevel == "Level 3")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section3Level='" + 3 + "'";
						command.ExecuteNonQuery();
					}
					else if (RolesServicesSecurityLevel == "Level 4")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section3Level='" + 4 + "'";
						command.ExecuteNonQuery();
					}

					FSMSecurityLevel = comboBox4.SelectedItem.ToString();
					Properties.Settings.Default.FSMSecurityLevel = FSMSecurityLevel;
					if (FSMSecurityLevel == "Level 1")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section4Level='" + 1 + "'";
						command.ExecuteNonQuery();
					}
					else if (FSMSecurityLevel == "Level 2")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section4Level='" + 2 + "'";
						command.ExecuteNonQuery();
					}
					else if (FSMSecurityLevel == "Level 3")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section4Level='" + 3 + "'";
						command.ExecuteNonQuery();
					}
					else if (FSMSecurityLevel == "Level 4")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section4Level='" + 4 + "'";
						command.ExecuteNonQuery();
					}

					PhysicalSecurityLevel = comboBox5.SelectedItem.ToString();
					Properties.Settings.Default.PhysicalSecurityLevel = PhysicalSecurityLevel;
					if (PhysicalSecurityLevel == "Level 1")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section5Level='" + 1 + "'";
						command.ExecuteNonQuery();
					}
					else if (PhysicalSecurityLevel == "Level 2")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section5Level='" + 2 + "'";
						command.ExecuteNonQuery();
					}
					else if (PhysicalSecurityLevel == "Level 3")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section5Level='" + 3 + "'";
						command.ExecuteNonQuery();
					}
					else if (PhysicalSecurityLevel == "Level 4")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section5Level='" + 4 + "'";
						command.ExecuteNonQuery();
					}
					//else if (PhysicalSecurityLevel == "N/A")
					//{
					//	command.CommandText = "UPDATE GeneralVendorInfo SET Section5Level='" + 5 + "'";
					//	command.ExecuteNonQuery();
					//}

					OpEnvironmentSecurityLevel = comboBox6.SelectedItem.ToString();
					Properties.Settings.Default.OpEnvironmentSecurityLevel = OpEnvironmentSecurityLevel;
					if (OpEnvironmentSecurityLevel == "Level 1")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section6Level='" + 1 + "'";
						command.ExecuteNonQuery();
					}
					else if (OpEnvironmentSecurityLevel == "Level 2")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section6Level='" + 2 + "'";
						command.ExecuteNonQuery();
					}
					else if (OpEnvironmentSecurityLevel == "Level 3")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section6Level='" + 3 + "'";
						command.ExecuteNonQuery();
					}
					else if (OpEnvironmentSecurityLevel == "Level 4")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section6Level='" + 4 + "'";
						command.ExecuteNonQuery();
					}
					//else if (OpEnvironmentSecurityLevel == "N/A")
					//{
					//	command.CommandText = "UPDATE GeneralVendorInfo SET Section6Level='" + 5 + "'";
					//	command.ExecuteNonQuery();
					//}

					KeyManagementSecurityLevel = comboBox7.SelectedItem.ToString();
					Properties.Settings.Default.KeyManagementSecurityLevel = KeyManagementSecurityLevel;
					if (KeyManagementSecurityLevel == "Level 1")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section7Level='" + 1 + "'";
						command.ExecuteNonQuery();
					}
					else if (KeyManagementSecurityLevel == "Level 2")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section7Level='" + 2 + "'";
						command.ExecuteNonQuery();
					}
					else if (KeyManagementSecurityLevel == "Level 3")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section7Level='" + 3 + "'";
						command.ExecuteNonQuery();
					}
					else if (KeyManagementSecurityLevel == "Level 4")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section7Level='" + 4 + "'";
						command.ExecuteNonQuery();
					}

					EMI_EMCSecurityLevel = comboBox8.SelectedItem.ToString();
					Properties.Settings.Default.EMI_EMCSecurityLevel = EMI_EMCSecurityLevel;
					if (EMI_EMCSecurityLevel == "Level 1")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section8Level='" + 1 + "'";
						command.ExecuteNonQuery();
					}
					else if (EMI_EMCSecurityLevel == "Level 2")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section8Level='" + 2 + "'";
						command.ExecuteNonQuery();
					}
					else if (EMI_EMCSecurityLevel == "Level 3")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section8Level='" + 3 + "'";
						command.ExecuteNonQuery();
					}
					else if (EMI_EMCSecurityLevel == "Level 4")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section8Level='" + 4 + "'";
						command.ExecuteNonQuery();
					}

					SelfTestsSecurityLevel = comboBox9.SelectedItem.ToString();
					Properties.Settings.Default.SelfTestsSecurityLevel = SelfTestsSecurityLevel;
					if (SelfTestsSecurityLevel == "Level 1")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section9Level='" + 1 + "'";
						command.ExecuteNonQuery();
					}
					else if (SelfTestsSecurityLevel == "Level 2")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section9Level='" + 2 + "'";
						command.ExecuteNonQuery();
					}
					else if (SelfTestsSecurityLevel == "Level 3")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section9Level='" + 3 + "'";
						command.ExecuteNonQuery();
					}
					else if (SelfTestsSecurityLevel == "Level 4")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section9Level='" + 4 + "'";
						command.ExecuteNonQuery();
					}

					DesignAssuranceSecurityLevel = comboBox10.SelectedItem.ToString();
					Properties.Settings.Default.DesignAssuranceSecurityLevel = DesignAssuranceSecurityLevel;
					if (DesignAssuranceSecurityLevel == "Level 1")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section10Level='" + 1 + "'";
						command.ExecuteNonQuery();
					}
					else if (DesignAssuranceSecurityLevel == "Level 2")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section10Level='" + 2 + "'";
						command.ExecuteNonQuery();
					}
					else if (DesignAssuranceSecurityLevel == "Level 3")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section10Level='" + 3 + "'";
						command.ExecuteNonQuery();
					}
					else if (DesignAssuranceSecurityLevel == "Level 4")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section10Level='" + 4 + "'";
						command.ExecuteNonQuery();
					}

					MitigationAttacksSecurityLevel = comboBox11.SelectedItem.ToString();
					Properties.Settings.Default.MitigationAttacksSecurityLevel = MitigationAttacksSecurityLevel;
					if (MitigationAttacksSecurityLevel == "Level 1")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section11Level='" + 1 + "'";
						command.ExecuteNonQuery();
					}
					else if (MitigationAttacksSecurityLevel == "Level 2")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section11Level='" + 2 + "'";
						command.ExecuteNonQuery();
					}
					else if (MitigationAttacksSecurityLevel == "Level 3")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section11Level='" + 3 + "'";
						command.ExecuteNonQuery();
					}
					else if (MitigationAttacksSecurityLevel == "Level 4")
					{
						command.CommandText = "UPDATE GeneralVendorInfo SET Section11Level='" + 4 + "'";
						command.ExecuteNonQuery();
					}
					//else if (MitigationAttacksSecurityLevel == "N/A")
					//{	
					//	command.CommandText = "UPDATE GeneralVendorInfo SET Section11Level='" + 5 + "'";
					//	command.ExecuteNonQuery();
					//}

					//TE010803_ExComponents = txt_ExComponents.Text;
					Properties.Settings.Default.TE010808_excld = TE010808_excld;

					TE010803_CoolingSys = txt_CoolingSys.Text;
					Properties.Settings.Default.TE010803_CoolingSys = TE010803_CoolingSys;

					ExComponents_YesNo = comboBox12.SelectedItem.ToString();
					Properties.Settings.Default.ExComponents_YesNo = ExComponents_YesNo;

					CoolingSys_YesNo = comboBox13.SelectedItem.ToString();
					Properties.Settings.Default.CoolingSys_YesNo = CoolingSys_YesNo;
					Properties.Settings.Default.Save();

	
					SpecificationsAssertions f1 = new SpecificationsAssertions();
					f1.populateSpecLevel1234();
					f1.populateSpecLevel34();

					DesignAssuranceAssertions f2 = new DesignAssuranceAssertions();
					f2.populateDesignAssuranceLevel1234();
					f2.populateDesignAssuranceLevel234();
					f2.populateDesignAssuranceLevel34();
					f2.populateDesignAssuranceLevel4();

					MitigationOtherAttacksAssertions f3 = new MitigationOtherAttacksAssertions();
					f3.populateMitigationOtherAttacksLevel1234();

					FSMAssertions f4 = new FSMAssertions();
					f4.populateFSMLevel1234();

					e.Cancel = false;
				}
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

		private void btn_TE010803_Click(object sender, EventArgs e)
		{
			textBoxTE010808.Visible = false;
			textBoxTE010802.Visible = false;
			textBoxTE010812.Visible = true;
			SpecificationsAssertions f1 = new SpecificationsAssertions();
			f1.populateSpecLevel1234();

			textBoxTE010812.Text = SpecificationsAssertions.TE010812_txt;
		}

		private void btn_TE010802_Click(object sender, EventArgs e)
		{
			textBoxTE010808.Visible = false;
			textBoxTE010812.Visible = false;
			textBoxTE010802.Visible = true;
			SpecificationsAssertions f1 = new SpecificationsAssertions();
			f1.populateSpecLevel1234();

			textBoxTE010802.Text = SpecificationsAssertions.TE010802_txt;
		}

		private void btn_TE010808_Click(object sender, EventArgs e)
		{
			textBoxTE010808.Visible = true;
			textBoxTE010802.Visible = false;
			textBoxTE010812.Visible = false;
			SpecificationsAssertions f1 = new SpecificationsAssertions();
			f1.populateSpecLevel1234();

			textBoxTE010808.Text = SpecificationsAssertions.TE010808_txt;
		}

		private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ModuleInfo_Load(object sender, EventArgs e)
		{

		}

		private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox12_DropDownClosed(object sender, EventArgs e)
		{
			if (comboBox12.SelectedItem.ToString() == "Yes")
			{
				ExcludedComponents f1 = new ExcludedComponents();
				f1.ShowDialog();

			}
			else if (comboBox12.SelectedItem.ToString() == "No")
			{
				ExcludedComponents f1 = new ExcludedComponents();
				TE010808_excld = "N/A";

				textBoxTE010812.Text = TE010808_excld;
			}
		}
	}
}
 