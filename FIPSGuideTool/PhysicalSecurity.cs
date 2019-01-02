using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FIPSGuideTool
{
	public partial class PhysicalSecurity : Form
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();

		public static string Embodiment;
		public static string MaintenanceRole_SC;
		public static string MaintenanceRole_MCE;
		public static string MaintenanceRole_MCS;
		public static string ContainsHoleSlit_SC;
		public static string ContainsHoleSlit_MCE;
		public static string ContainsHoleSlit_MCS;
		public static string ContainsCoating_SC;
		public static string ContainsCoating_MCE;
		public static string ContainsCoating_MCS;
		public static string ContainsDoorCover_SC;
		public static string ContainsDoorCover_MCE;
		public static string ContainsDoorCover_MCS;
		public static string CoatingType;
		public static string enclosureAS0529;		
		public static string enclosureAS0537;
		public static string enclosureAS0553;
		public static string keyTE053703;
		public static string tapeTE053703;
		public static string keyTE0553;
		public static string tapeTE0553;
		public static string PhysicalSecurityLevel;


		public PhysicalSecurity()
		{
			InitializeComponent();

			PhysicalSecurityLevel = Properties.Settings.Default.PhysicalSecurityLevel.ToString();
			Embodiment            = Properties.Settings.Default.Embodiment.ToString();
			MaintenanceRole_SC    = Properties.Settings.Default.MaintenanceRole_SC.ToString();
			MaintenanceRole_MCE   = Properties.Settings.Default.MaintenanceRole_MCE.ToString();
			MaintenanceRole_MCS   = Properties.Settings.Default.MaintenanceRole_MCS.ToString();
			ContainsHoleSlit_SC   = Properties.Settings.Default.ContainsHoleSlit_SC.ToString();
			ContainsHoleSlit_MCE  = Properties.Settings.Default.ContainsHoleSlit_MCE.ToString();
			ContainsHoleSlit_MCS  = Properties.Settings.Default.ContainsHoleSlit_MCS.ToString();
			ContainsCoating_SC    = Properties.Settings.Default.ContainsCoating_SC.ToString();
			ContainsCoating_MCE   = Properties.Settings.Default.ContainsCoating_MCE.ToString();
			ContainsCoating_MCS   = Properties.Settings.Default.ContainsCoating_MCS.ToString();
			ContainsDoorCover_SC  = Properties.Settings.Default.ContainsDoorCover_SC.ToString();
			ContainsDoorCover_MCE = Properties.Settings.Default.ContainsDoorCover_MCE.ToString();
			ContainsDoorCover_MCS = Properties.Settings.Default.ContainsDoorCover_MCS.ToString();
			CoatingType           = Properties.Settings.Default.CoatingType.ToString();
			enclosureAS0529       = Properties.Settings.Default.enclosureAS0529.ToString();
			enclosureAS0537       = Properties.Settings.Default.enclosureAS0537.ToString();
			enclosureAS0553       = Properties.Settings.Default.enclosureAS0553.ToString();			
			keyTE053703           = Properties.Settings.Default.keyTE053703.ToString();
			tapeTE053703          = Properties.Settings.Default.tapeTE053703.ToString();
			keyTE0553             = Properties.Settings.Default.keyTE0553.ToString();
			tapeTE0553            = Properties.Settings.Default.tapeTE0553.ToString();

			comboBox5.SelectedItem      = PhysicalSecurityLevel;
			 
			txtbox_coatingType_SC.Text  = CoatingType;

			if (Embodiment == "Single_Chip")
			{
				radioButton1.Checked = true;
			}
			else if (Embodiment == "MultiChipEmbedded")
			{
				radioButton2.Checked = true;
			}
			else if (Embodiment == "MultiChipStandalone")
			{
				radioButton3.Checked = true;
			}

			if (MaintenanceRole_SC == "True")
			{
				checkBox_MaintenRole_SC.Checked = true;
			}

			if (MaintenanceRole_MCE == "True")
			{
				checkBox_MaintenRole_MCE.Checked = true;
			}

			if (MaintenanceRole_MCS == "True")
			{
				checkBox_MaintenRole_MCS.Checked = true;
			}

			if (ContainsHoleSlit_SC == "True")
			{
				checkBox_HoleSlit_SC.Checked = true;
			}

			if (ContainsHoleSlit_MCE == "True")
			{
				checkBox_HoleSlit_MCE.Checked = true;
			}

			if (ContainsHoleSlit_MCS == "True")
			{
				checkBox_HoleSlit_MCS.Checked = true;
			}
			
			if (ContainsDoorCover_SC == "True")
			{
				checkBox_HoleSlit_SC.Checked = true;
			}

			if (ContainsDoorCover_MCE == "True")
			{
				checkBox_DoorCover_MCE.Checked   = true;
				radioButton_tapeTE053703.Visible = true;
				radioButton_keyTE053703.Visible  = true;
				if (keyTE053703 == "True")
				{
					radioButton_keyTE053703.Checked = true;
				}

				if (tapeTE053703 == "True")
				{
					radioButton_tapeTE053703.Checked = true;
				}
			}
			else
			{
				checkBox_DoorCover_MCE.Checked   = false;
				radioButton_tapeTE053703.Visible = false;
				radioButton_keyTE053703.Visible  = false;
			}

			if (ContainsDoorCover_MCS == "True")
			{
				checkBox_DoorCover_MCS.Checked = true;
				radioButton_tapeTE0553.Visible = true;
				radioButton_keyTE0553.Visible = true;

				if (keyTE0553 == "True")
				{
					radioButton_keyTE0553.Checked = true;
				}

				if (tapeTE0553 == "True")
				{
					radioButton_tapeTE0553.Checked = true;
				}
			}
			else
			{
				checkBox_DoorCover_MCS.Checked = false;
				radioButton_tapeTE0553.Visible = false;
				radioButton_keyTE0553.Visible = false;
			}				

			if (ContainsCoating_SC == "True")
			{
				checkBox_coatingAS0528.Checked = true;				
				label5.Visible = true;
				txtbox_coatingType_SC.Visible = true;			
			}
			else
			{
				checkBox_coatingAS0528.Checked = false;
				label5.Visible = false;
				txtbox_coatingType_SC.Visible = false;
			}

			if (ContainsCoating_MCE == "True")
			{
				radioButton_coatingAS0536.Checked = true;
			}
			else
			{
				radioButton_coatingAS0536.Checked = false;
			}

			if (ContainsCoating_MCS == "True")
			{
				radioButton_coatingAS0552.Checked = true;
			}
			else
			{
				radioButton_coatingAS0552.Checked = false;
			}		

			if (enclosureAS0529 == "True")
			{
				checkBox_enclosureAS0529.Checked = true;
			}

			if (enclosureAS0537 == "True")
			{
				radioButton_enclosureAS0537.Checked = true;
			}

			if (enclosureAS0553 == "True")
			{
				radioButton_enclosureAS0553.Checked = true;
			}

			if (PhysicalSecurityLevel == "Level 4")
			{
				labelEFT_EFP.Visible = true;
				comboBox_EFT_EFP.Visible = true;
			}
			else
			{
				labelEFT_EFP.Visible = false;
				comboBox_EFT_EFP.Visible = false;
			}

			//txtbox_coatingType_SC.Visible = false;
			//label5.Visible = false;
			//checkBox_coatingAS0528.Checked = false;
		}

		private void PhysicalSecurity_Load(object sender, EventArgs e)
		{ }


		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void checkBox_DoorCover_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_DoorCover_MCS.Checked.ToString() == "True" && radioButton_enclosureAS0553.Checked.ToString() == "True")
			{
				panel4.Visible = true;
				radioButton_keyTE0553.Visible = true;
				radioButton_tapeTE0553.Visible = true;
			}
			else
			{
				panel4.Visible = false;
				radioButton_keyTE0553.Visible = false;
				radioButton_tapeTE0553.Visible = false;
			}
		}

		private void radioButton_coatingAS0536_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_DoorCover_MCS.Checked.ToString() == "True" && radioButton_enclosureAS0553.Checked.ToString() == "True")
			{
				panel4.Visible = true;
				radioButton_keyTE0553.Visible = true;
				radioButton_tapeTE0553.Visible = true;
			}
			else
			{
				panel4.Visible = false;
				radioButton_keyTE0553.Visible = false;
				radioButton_tapeTE0553.Visible = false;
			}
		}

		private void radioButton_enclosureAS0537_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_DoorCover_MCS.Checked.ToString() == "True" && radioButton_enclosureAS0553.Checked.ToString() == "True")
			{
				panel4.Visible = true;
				radioButton_keyTE0553.Visible = true;
				radioButton_tapeTE0553.Visible = true;
			}
			else
			{
				panel4.Visible = false;
				radioButton_keyTE0553.Visible = false;
				radioButton_tapeTE0553.Visible = false;
			}
		}


		private void PhysicalSecurity_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
				connection.Open();
				command.Connection = connection;

				PhysicalSecurityLevel = comboBox5.SelectedItem.ToString();
				Properties.Settings.Default.PhysicalSecurityLevel = PhysicalSecurityLevel;

				if (radioButton1.Checked == true)
				{
					Embodiment = "Single_Chip";
					Properties.Settings.Default.Embodiment = Embodiment;
					command.CommandText = "UPDATE GeneralVendorInfo SET Type='" + 1 + "'";
					command.ExecuteNonQuery();

				}
				else if (radioButton2.Checked == true)
				{
					Embodiment = "MultiChipEmbedded";
					Properties.Settings.Default.Embodiment = Embodiment;
					command.CommandText = "UPDATE GeneralVendorInfo SET Type='" + 2 + "'";
					command.ExecuteNonQuery();
				}
				else if (radioButton3.Checked == true)
				{
					Embodiment = "MultiChipStandalone";
					Properties.Settings.Default.Embodiment = Embodiment;
					command.CommandText = "UPDATE GeneralVendorInfo SET Type='" + 3 + "'";
					command.ExecuteNonQuery();
				}

				MaintenanceRole_SC = checkBox_MaintenRole_SC.Checked.ToString();
				Properties.Settings.Default.MaintenanceRole_SC = MaintenanceRole_SC;

				MaintenanceRole_MCE = checkBox_MaintenRole_MCE.Checked.ToString();
				Properties.Settings.Default.MaintenanceRole_MCE = MaintenanceRole_MCE;

				MaintenanceRole_MCS = checkBox_MaintenRole_MCS.Checked.ToString();
				Properties.Settings.Default.MaintenanceRole_MCS = MaintenanceRole_MCS;

				ContainsHoleSlit_SC = checkBox_HoleSlit_SC.Checked.ToString();
				Properties.Settings.Default.ContainsHoleSlit_SC = ContainsHoleSlit_SC;

				ContainsHoleSlit_MCE = checkBox_HoleSlit_MCE.Checked.ToString();
				Properties.Settings.Default.ContainsHoleSlit_MCE = ContainsHoleSlit_MCE;

				ContainsHoleSlit_MCS = checkBox_HoleSlit_MCS.Checked.ToString();
				Properties.Settings.Default.ContainsHoleSlit_MCS = ContainsHoleSlit_MCS;

				ContainsCoating_SC = checkBox_coatingAS0528.Checked.ToString();
				Properties.Settings.Default.ContainsCoating_SC = ContainsCoating_SC;

				ContainsCoating_MCE = radioButton_coatingAS0536.Checked.ToString();
				Properties.Settings.Default.ContainsCoating_MCE = ContainsCoating_MCE;

				ContainsCoating_MCS = radioButton_coatingAS0552.Checked.ToString();
				Properties.Settings.Default.ContainsCoating_MCS = ContainsCoating_MCS;

				CoatingType = txtbox_coatingType_SC.Text;
				Properties.Settings.Default.CoatingType = CoatingType;

				ContainsDoorCover_SC = checkBox_DoorCover_SC.Checked.ToString();
				Properties.Settings.Default.ContainsDoorCover_SC = ContainsDoorCover_SC;

				ContainsDoorCover_MCE = checkBox_DoorCover_MCE.Checked.ToString();
				Properties.Settings.Default.ContainsDoorCover_MCE = ContainsDoorCover_MCE;

				ContainsDoorCover_MCS = checkBox_DoorCover_MCS.Checked.ToString();
				Properties.Settings.Default.ContainsDoorCover_MCS = ContainsDoorCover_MCS;

				enclosureAS0529 = checkBox_enclosureAS0529.Checked.ToString();
				Properties.Settings.Default.enclosureAS0529 = enclosureAS0529;
	
				enclosureAS0537 = radioButton_enclosureAS0537.Checked.ToString();
				Properties.Settings.Default.enclosureAS0537 = enclosureAS0537;

				enclosureAS0553 = radioButton_enclosureAS0553.Checked.ToString();
				Properties.Settings.Default.enclosureAS0553 = enclosureAS0553;

				keyTE053703 = radioButton_keyTE053703.Checked.ToString();
				Properties.Settings.Default.keyTE053703 = keyTE053703;

				keyTE0553 = radioButton_keyTE0553.Checked.ToString();
				Properties.Settings.Default.keyTE0553 = keyTE0553;

				tapeTE053703 = radioButton_tapeTE053703.Checked.ToString();
				Properties.Settings.Default.tapeTE053703 = tapeTE053703;

				tapeTE0553 = radioButton_tapeTE0553.Checked.ToString();
				Properties.Settings.Default.tapeTE0553 = tapeTE0553;

				Properties.Settings.Default.Save();

				PhysicalSecurityAssertions f4 = new PhysicalSecurityAssertions();

				f4.populatePhySecLevel1();
				f4.populatePhySecLevels1234();
				f4.populatePhySecLevels234();
				f4.populatePhySecLevels34();
				f4.populatePhySecLevels4();

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

				if (Embodiment == "Single Chip")
				{
					command.CommandText = "UPDATE GeneralVendorInfo SET Type='" + 1 + "'";
					command.ExecuteNonQuery();
				}
				else if (Embodiment == "Multi-Chip Embedded")
				{
					command.CommandText = "UPDATE GeneralVendorInfo SET Type='" + 2 + "'";
					command.ExecuteNonQuery();
				}
				else if (Embodiment == "Multi-Chip Standalone")
				{
					command.CommandText = "UPDATE GeneralVendorInfo SET Type='" + 3 + "'";
					command.ExecuteNonQuery();
				}

				connection.Close();
				e.Cancel = false;

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

		private void comboBox_EFT_EFP_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
		{
			PhysicalSecurityLevel = comboBox5.SelectedItem.ToString();
			if (radioButton1.Checked == true)
			{
				Embodiment = "Single_Chip";
			}
			else if (radioButton2.Checked == true)
			{
				Embodiment = "MultiChipEmbedded";
			}
			else if (radioButton3.Checked == true)
			{
				Embodiment = "MultiChipStandalone";
			}


			if (PhysicalSecurityLevel == "Level 1")
			{
				labelEFT_EFP.Visible = false;
				comboBox_EFT_EFP.Visible = false;

				if (Embodiment == "MultiChipStandalone")
				{
					radioButton_coatingAS0552.Visible = false;
					radioButton_enclosureAS0553.Visible = false;
					radioButton_coatingAS0536.Visible = false;
					radioButton_enclosureAS0537.Visible = false;
					checkBox_MaintenRole_MCS.Visible = false;
					checkBox_HoleSlit_MCS.Visible = false;
					checkBox_DoorCover_MCS.Visible = false;
					radioButton_keyTE0553.Visible = false;
					radioButton_tapeTE0553.Visible = false;
					panel3.Visible = false;
					panel5.Visible = false;
					label10.Visible = false;
					label11.Visible = false;
					label9.Visible = true;
				}

				if (Embodiment == "MultiChipEmbedded")
				{
					radioButton_coatingAS0536.Visible = false;
					radioButton_enclosureAS0537.Visible = false;
					checkBox_MaintenRole_MCE.Visible = false;
					checkBox_HoleSlit_MCE.Visible = false;
					checkBox_DoorCover_MCE.Visible = false;
					panel2.Visible = false;
					radioButton_keyTE053703.Visible = false;
					radioButton_tapeTE053703.Visible = false;
					label8.Visible = true;
					label7.Visible = false;
					label12.Visible = false;
					panel6.Visible = false;
				}

				if (Embodiment == "Single_Chip")
				{
					checkBox_enclosureAS0529.Visible = false;
					checkBox_coatingAS0528.Visible = false;
					txtbox_coatingType_SC.Visible = false;
					checkBox_MaintenRole_SC.Visible = false;
					checkBox_HoleSlit_SC.Visible = false;
					checkBox_DoorCover_SC.Visible = false;
					label5.Visible = false;
					label6.Visible = false;
					label4.Visible = false;
					label3.Visible = true;
				}
			}

			if (PhysicalSecurityLevel == "Level 2")
			{
				labelEFT_EFP.Visible = false;
				comboBox_EFT_EFP.Visible = false;

				if (Embodiment == "MultiChipStandalone")
				{			
					radioButton_coatingAS0552.Visible = true;
					radioButton_enclosureAS0553.Visible = true;
					radioButton_coatingAS0536.Visible = true;
					radioButton_enclosureAS0537.Visible = true;
					checkBox_MaintenRole_MCS.Visible = true;
					checkBox_HoleSlit_MCS.Visible = true;
					checkBox_DoorCover_MCS.Visible = true;
					if (checkBox_DoorCover_MCS.Checked == true)
					{
						radioButton_keyTE0553.Visible = true;
						radioButton_tapeTE0553.Visible = true;
						panel3.Visible = true;
					}
					else
					{
						radioButton_keyTE0553.Visible = false;
						radioButton_tapeTE0553.Visible = false;
						panel3.Visible = false;
					}

					panel5.Visible = true;
					label10.Visible = true;
					label11.Visible = false;
					label9.Visible = false;
				}

				if (Embodiment == "MultiChipEmbedded")
				{
					radioButton_coatingAS0536.Visible = true;
					radioButton_enclosureAS0537.Visible = true;
					checkBox_MaintenRole_MCE.Visible = true;
					checkBox_HoleSlit_MCE.Visible = true;
					checkBox_DoorCover_MCE.Visible = true;
					if (checkBox_DoorCover_MCE.Checked == true)
					{
						panel2.Visible = true;
						radioButton_keyTE053703.Visible = true;
						radioButton_tapeTE053703.Visible = true;
					}
					else
					{
						panel2.Visible = false;
						radioButton_keyTE053703.Visible = false;
						radioButton_tapeTE053703.Visible = false;
					}
					label8.Visible = false;
					label7.Visible = false;
					label12.Visible = true;
					panel6.Visible = true;
				}

				if (Embodiment == "Single_Chip")
				{
					checkBox_enclosureAS0529.Visible = true;
					checkBox_coatingAS0528.Visible = true;
					if (checkBox_coatingAS0528.Checked == true)
					{
						label5.Visible = true;
						txtbox_coatingType_SC.Visible = true;
					}
					else
					{
						label5.Visible = false;
						txtbox_coatingType_SC.Visible = false;
					}
					checkBox_MaintenRole_SC.Visible = true;
					checkBox_HoleSlit_SC.Visible = true;
					checkBox_DoorCover_SC.Visible = true;

					label6.Visible = false;
					label4.Visible = true;
					label3.Visible = false;
				}
			}

			if (PhysicalSecurityLevel == "Level 3")
			{
				labelEFT_EFP.Visible = false;
				comboBox_EFT_EFP.Visible = false;

				if (Embodiment == "MultiChipStandalone")
				{
					label4.Visible = false;
					label6.Visible = false;

					radioButton_coatingAS0552.Visible = true;
					radioButton_enclosureAS0553.Visible = true;
					radioButton_coatingAS0536.Visible = true;
					radioButton_enclosureAS0537.Visible = true;
					checkBox_MaintenRole_MCS.Visible = true;
					checkBox_HoleSlit_MCS.Visible = true;
					checkBox_DoorCover_MCS.Visible = true;
					if (checkBox_DoorCover_MCS.Checked == true)
					{
						radioButton_keyTE0553.Visible = true;
						radioButton_tapeTE0553.Visible = true;
						panel3.Visible = true;
					}
					else
					{
						radioButton_keyTE0553.Visible = false;
						radioButton_tapeTE0553.Visible = false;
						panel3.Visible = false;
					}

					panel5.Visible = true;
					label10.Visible = false;
					label11.Visible = true;
					label9.Visible = false;
				}

				if (Embodiment == "MultiChipEmbedded")
				{
					radioButton_coatingAS0536.Visible = true;
					radioButton_enclosureAS0537.Visible = true;
					checkBox_MaintenRole_MCE.Visible = true;
					checkBox_HoleSlit_MCE.Visible = true;
					checkBox_DoorCover_MCE.Visible = true;
					if (checkBox_DoorCover_MCE.Checked == true)
					{
						panel2.Visible = true;
						radioButton_keyTE053703.Visible = true;
						radioButton_tapeTE053703.Visible = true;
					}
					else
					{
						panel2.Visible = false;
						radioButton_keyTE053703.Visible = false;
						radioButton_tapeTE053703.Visible = false;
					}
					label8.Visible = false;
					label7.Visible = true;
					label12.Visible = false;
					panel6.Visible = true;
				}

				if (Embodiment == "Single_Chip")
				{
					checkBox_enclosureAS0529.Visible = true;
					checkBox_coatingAS0528.Visible = true;
					if (checkBox_coatingAS0528.Checked == true)
					{
						label5.Visible = true;
						txtbox_coatingType_SC.Visible = true;
					}
					else
					{
						label5.Visible = false;
						txtbox_coatingType_SC.Visible = false;
					}
					checkBox_MaintenRole_SC.Visible = true;
					checkBox_HoleSlit_SC.Visible = true;
					checkBox_DoorCover_SC.Visible = true;

					label6.Visible = true;
					label4.Visible = false;
					label3.Visible = false;
				}
			}

			if ((PhysicalSecurityLevel == "Level 4"))
			{
				//if (PhysicalSecurityLevel == "Level 4")
				//{
					labelEFT_EFP.Visible = true;
					comboBox_EFT_EFP.Visible = true;
				//}
				//else
				//{
				//	labelEFT_EFP.Visible = false;
				//	comboBox_EFT_EFP.Visible = false;
				//}

				if (Embodiment == "Single_Chip")
				{
					checkBox_enclosureAS0529.Visible = true;
					checkBox_coatingAS0528.Visible = true;
					checkBox_coatingAS0528.Checked = true;
					label5.Visible = true;
					txtbox_coatingType_SC.Visible = true;

					checkBox_MaintenRole_SC.Visible = true;
					checkBox_HoleSlit_SC.Visible = true;
					checkBox_DoorCover_SC.Visible = true;

					label6.Visible = true;
					label4.Visible = false;
					label3.Visible = false;
				}

				if (Embodiment == "MultiChipEmbedded")
				{
					radioButton_coatingAS0536.Visible = true;
					radioButton_enclosureAS0537.Visible = true;
					checkBox_MaintenRole_MCE.Visible = true;
					checkBox_HoleSlit_MCE.Visible = true;
					checkBox_DoorCover_MCE.Visible = true;
					if (checkBox_DoorCover_MCE.Checked == true)
					{
						panel2.Visible = true;
						radioButton_keyTE053703.Visible = true;
						radioButton_tapeTE053703.Visible = true;
					}
					else
					{
						panel2.Visible = false;
						radioButton_keyTE053703.Visible = false;
						radioButton_tapeTE053703.Visible = false;
					}

					label8.Visible = false;
					label7.Visible = true;
					label12.Visible = false;
					panel6.Visible = true;
				}

				if (Embodiment == "MultiChipStandalone")
				{
					//label4.Visible = false;
					//label6.Visible = false;

					radioButton_coatingAS0552.Visible = true;
					radioButton_enclosureAS0553.Visible = true;
					radioButton_coatingAS0536.Visible = true;
					radioButton_enclosureAS0537.Visible = true;
					checkBox_MaintenRole_MCS.Visible = true;
					checkBox_HoleSlit_MCS.Visible = true;
					checkBox_DoorCover_MCS.Visible = true;
					if (checkBox_DoorCover_MCS.Checked == true)
					{
						radioButton_keyTE0553.Visible = true;
						radioButton_tapeTE0553.Visible = true;
						panel3.Visible = true;
					}
					else
					{
						radioButton_keyTE0553.Visible = false;
						radioButton_tapeTE0553.Visible = false;
						panel3.Visible = false;
					}

					panel5.Visible = true;
					//label3.Visible = true;
					//label8.Visible = true;
					label10.Visible = false;
					label11.Visible = true;
					label9.Visible = false;
				}
			}
			
			Properties.Settings.Default.PhysicalSecurityLevel = PhysicalSecurityLevel;
			Properties.Settings.Default.Save();
		}

		private void Single_Chip_Click(object sender, EventArgs e)
		{

		}

		private void Embodiment_tabs_SelectedIndexChanged(object sender, EventArgs e)
		{	
			if (Embodiment_tabs.SelectedTab == Single_Chip)
			{
				//chooseEmbod.SelectedItem = "Single Chip";
				//Control tab2 = new Control();
				//tab2 = Single_Chip;
				//tab2.Enabled = true;
			}

			if (Embodiment_tabs.SelectedTab == Multi_Chip_Embedded)
			{
				//chooseEmbod.SelectedItem = "Multi-Chip Embedded";
				//Control tab2 = new Control();
				//tab2 = Multi_Chip_Embedded;
				//tab2.Enabled = true;
			}

			if (Embodiment_tabs.SelectedTab == Multi_Chip_Standalone)
			{
				//chooseEmbod.SelectedItem = "Multi-Chip Standalone";
				//Control tab2 = new Control();
				//tab2 = Multi_Chip_Standalone;
				//tab2.Enabled = true;
			}
		}

		private void Multi_Chip_Standalone_Click(object sender, EventArgs e)
		{

		}

		private void checkBox_DoorCover_CheckedChanged_1(object sender, EventArgs e)
		{
			if (checkBox_DoorCover_MCS.Checked == true)
			{
				radioButton_tapeTE0553.Visible = true;
				radioButton_keyTE0553.Visible = true;
			}
			else
			{
				radioButton_tapeTE0553.Visible = false;
				radioButton_keyTE0553.Visible = false;
			}
		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_coatingAS0528.Checked == true)
			{
				label5.Visible = true;
				txtbox_coatingType_SC.Visible = true;
			}
			else
			{
				label5.Visible = false;
				txtbox_coatingType_SC.Visible = false;
			}
		}

		//private void radioButton5_CheckedChanged(object sender, EventArgs e)
		//{
		//	//if (radioButton_enclosureAS0529.Checked == true)
		//	//{
		//	//	checkBox_MaintenRole_SC.Visible = true;
		//	//	checkBox_HoleSlit_SC.Visible = true;
		//	//	checkBox_DoorCover_SC.Visible = true;
		//	//}
		//	//else
		//	//{
		//	//	checkBox_MaintenRole_SC.Visible = false;
		//	//	checkBox_HoleSlit_SC.Visible = false;
		//	//	checkBox_DoorCover_SC.Visible = false;
		//	//}			
		//}

		private void panel1_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void checkBox_coatingAS0528_CheckedChanged(object sender, EventArgs e)
		{
			if ((PhysicalSecurityLevel == "Level 4"))
			{
				checkBox_coatingAS0528.Checked = true;
			}
			else
			{
				if (checkBox_coatingAS0528.Checked == true)
				{
					checkBox_enclosureAS0529.Checked = false;
				}
			}

			if (checkBox_coatingAS0528.Checked == true)
			{
				txtbox_coatingType_SC.Visible = true;
				label5.Visible = true;
			}
			else
			{
				txtbox_coatingType_SC.Visible = false;
				label5.Visible = false;
			}

		}

		private void checkBox_enclosureAS0529_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_enclosureAS0529.Checked == true)
			{
				checkBox_coatingAS0528.Checked = false;
			}
		}

		private void checkBox_DoorCover_MCE_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_DoorCover_MCE.Checked == true)
			{
				radioButton_tapeTE053703.Visible = true;
				radioButton_keyTE053703.Visible = true;
			}
			else
			{
				radioButton_tapeTE053703.Visible = false;
				radioButton_keyTE053703.Visible = false;
			}
		}

		private void radioButton_tapeTE053703_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{			
			Embodiment_tabs.SelectedTab = Single_Chip;
			PhysicalSecurityLevel = comboBox5.SelectedItem.ToString();

			Control tab0 = new Control();
			tab0 = Multi_Chip_Embedded;
			tab0.Enabled = false;

			Control tab1 = new Control();
			tab1 = Multi_Chip_Standalone;
			tab1.Enabled = false;

			Control tab2 = new Control();
			tab2 = Single_Chip;
			tab2.Enabled = true;
			if (PhysicalSecurityLevel == "")
			{

			}
			else
			{
				if ((PhysicalSecurityLevel == "Level 1"))
				{
					checkBox_enclosureAS0529.Visible = false;
					checkBox_coatingAS0528.Visible = false;
					txtbox_coatingType_SC.Visible = false;
					checkBox_MaintenRole_SC.Visible = false;
					checkBox_HoleSlit_SC.Visible = false;
					checkBox_DoorCover_SC.Visible = false;
					label5.Visible = false;
					label6.Visible = false;
					label4.Visible = false;
					label3.Visible = true;
				}

				if ((PhysicalSecurityLevel == "Level 2"))
				{
					checkBox_enclosureAS0529.Visible = true;
					checkBox_coatingAS0528.Visible = true;
					if (checkBox_coatingAS0528.Checked == true)
					{
						label5.Visible = true;
						txtbox_coatingType_SC.Visible = true;
					}
					else
					{
						label5.Visible = false;
						txtbox_coatingType_SC.Visible = false;
					}
					checkBox_MaintenRole_SC.Visible = true;
					checkBox_HoleSlit_SC.Visible = true;
					checkBox_DoorCover_SC.Visible = true;

					label6.Visible = false;
					label4.Visible = true;
					label3.Visible = false;
				}

				if (PhysicalSecurityLevel == "Level 3")
				{
					checkBox_enclosureAS0529.Visible = true;
					checkBox_coatingAS0528.Visible = true;
					if (checkBox_coatingAS0528.Checked == true)
					{
						label5.Visible = true;
						txtbox_coatingType_SC.Visible = true;
					}
					else
					{
						label5.Visible = false;
						txtbox_coatingType_SC.Visible = false;
					}
					checkBox_MaintenRole_SC.Visible = true;
					checkBox_HoleSlit_SC.Visible = true;
					checkBox_DoorCover_SC.Visible = true;

					label6.Visible = true;
					label4.Visible = false;
					label3.Visible = false;
				}

				if (PhysicalSecurityLevel == "Level 4")
				{
					checkBox_enclosureAS0529.Visible = true;
					checkBox_coatingAS0528.Visible = true;
					checkBox_coatingAS0528.Checked = true;
					label5.Visible = true;
					txtbox_coatingType_SC.Visible = true;

					checkBox_MaintenRole_SC.Visible = true;
					checkBox_HoleSlit_SC.Visible = true;
					checkBox_DoorCover_SC.Visible = true;

					label6.Visible = true;
					label4.Visible = false;
					label3.Visible = false;
				}

			}		
		}

		private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
		{			
			Embodiment_tabs.SelectedTab = Multi_Chip_Embedded;

			Control tab0 = new Control();
			tab0 = Single_Chip;
			tab0.Enabled = false;

			Control tab1 = new Control();
			tab1 = Multi_Chip_Standalone;
			tab1.Enabled = false;

			Control tab2 = new Control();
			tab2 = Multi_Chip_Embedded;
			tab2.Enabled = true;

			if (PhysicalSecurityLevel == "Level 1")
			{
				label4.Visible = false;
				label6.Visible = false;

				radioButton_coatingAS0536.Visible = false;
				radioButton_enclosureAS0537.Visible = false;
				checkBox_MaintenRole_MCE.Visible = false;
				checkBox_HoleSlit_MCE.Visible = false;
				checkBox_DoorCover_MCE.Visible = false;
				panel2.Visible = false;
				radioButton_keyTE053703.Visible = false;
				radioButton_tapeTE053703.Visible = false;
				label8.Visible = true;
				label12.Visible = false;
				panel6.Visible = false;
			}

			if ((PhysicalSecurityLevel == "Level 2"))
			{
				radioButton_coatingAS0536.Visible = true;
				radioButton_enclosureAS0537.Visible = true;
				checkBox_MaintenRole_MCE.Visible = true;
				checkBox_HoleSlit_MCE.Visible = true;
				checkBox_DoorCover_MCE.Visible = true;
				if (checkBox_DoorCover_MCE.Checked == true)
				{
					panel2.Visible = true;
					radioButton_keyTE053703.Visible = true;
					radioButton_tapeTE053703.Visible = true;
				}
				else
				{
					panel2.Visible = false;
					radioButton_keyTE053703.Visible = false;
					radioButton_tapeTE053703.Visible = false;
				}
				label8.Visible = false;
				label7.Visible = false;
				label12.Visible = true;
				panel6.Visible = true;
			}

			if ((PhysicalSecurityLevel == "Level 3"))
			{
				radioButton_coatingAS0536.Visible = true;
				radioButton_enclosureAS0537.Visible = true;
				checkBox_MaintenRole_MCE.Visible = true;
				checkBox_HoleSlit_MCE.Visible = true;
				checkBox_DoorCover_MCE.Visible = true;
				if (checkBox_DoorCover_MCE.Checked == true)
				{
					panel2.Visible = true;
					radioButton_keyTE053703.Visible = true;
					radioButton_tapeTE053703.Visible = true;
				}
				else
				{
					panel2.Visible = false;
					radioButton_keyTE053703.Visible = false;
					radioButton_tapeTE053703.Visible = false;
				}
				label8.Visible = false;
				label7.Visible = true;
				label12.Visible = false;
				panel6.Visible = true;
			}

			if ((PhysicalSecurityLevel == "Level 4"))
			{
				radioButton_coatingAS0536.Visible = true;
				radioButton_enclosureAS0537.Visible = true;
				checkBox_MaintenRole_MCE.Visible = true;
				checkBox_HoleSlit_MCE.Visible = true;
				checkBox_DoorCover_MCE.Visible = true;
				if (checkBox_DoorCover_MCE.Checked == true)
				{
					panel2.Visible = true;
					radioButton_keyTE053703.Visible = true;
					radioButton_tapeTE053703.Visible = true;
				}
				else
				{
					panel2.Visible = false;
					radioButton_keyTE053703.Visible = false;
					radioButton_tapeTE053703.Visible = false;
				}

				label8.Visible = false;
				label7.Visible = true;
				label12.Visible = false;
				panel6.Visible = true;
			}
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			Embodiment_tabs.SelectedTab = Multi_Chip_Standalone;
			Control tab0 = new Control();
			tab0 = Single_Chip;
			tab0.Enabled = false;

			Control tab1 = new Control();
			tab1 = Multi_Chip_Embedded;
			tab1.Enabled = false;

			Control tab2 = new Control();
			tab2 = Multi_Chip_Standalone;
			tab2.Enabled = true;

			if (PhysicalSecurityLevel == "Level 1")
			{
				label4.Visible = false;
				label6.Visible = false;

				radioButton_coatingAS0552.Visible = false;
				radioButton_enclosureAS0553.Visible = false;
				radioButton_coatingAS0536.Visible = false;
				radioButton_enclosureAS0537.Visible = false;
				checkBox_MaintenRole_MCS.Visible = false;
				checkBox_HoleSlit_MCS.Visible = false;
				checkBox_DoorCover_MCS.Visible = false;
				radioButton_keyTE0553.Visible = false;
				radioButton_tapeTE0553.Visible = false;
				panel3.Visible = false;
				panel5.Visible = false;
				label3.Visible = false;
				label8.Visible = false;
				label10.Visible = false;
				label11.Visible = false;
				label9.Visible = true;
			}

			if ((PhysicalSecurityLevel == "Level 2"))
			{
				label4.Visible = false;
				label6.Visible = false;

				radioButton_coatingAS0552.Visible = true;
				radioButton_enclosureAS0553.Visible = true;
				radioButton_coatingAS0536.Visible = true;
				radioButton_enclosureAS0537.Visible = true;
				checkBox_MaintenRole_MCS.Visible = true;
				checkBox_HoleSlit_MCS.Visible = true;
				checkBox_DoorCover_MCS.Visible = true;
				if (checkBox_DoorCover_MCS.Checked == true)
				{
					radioButton_keyTE0553.Visible = true;
					radioButton_tapeTE0553.Visible = true;
					panel3.Visible = true;
				}
				else
				{
					radioButton_keyTE0553.Visible = false;
					radioButton_tapeTE0553.Visible = false;
					panel3.Visible = false;
				}

				panel5.Visible  = true;
				label3.Visible  = true;
				label8.Visible  = true;
				label10.Visible = true;
				label11.Visible = false;
				label9.Visible  = false;
			}

			if ((PhysicalSecurityLevel == "Level 3"))
			{
				label4.Visible = false;
				label6.Visible = false;

				radioButton_coatingAS0552.Visible = true;
				radioButton_enclosureAS0553.Visible = true;
				radioButton_coatingAS0536.Visible = true;
				radioButton_enclosureAS0537.Visible = true;
				checkBox_MaintenRole_MCS.Visible = true;
				checkBox_HoleSlit_MCS.Visible = true;
				checkBox_DoorCover_MCS.Visible = true;
				if (checkBox_DoorCover_MCS.Checked == true)
				{
					radioButton_keyTE0553.Visible = true;
					radioButton_tapeTE0553.Visible = true;
					panel3.Visible = true;
				}
				else
				{
					radioButton_keyTE0553.Visible = false;
					radioButton_tapeTE0553.Visible = false;
					panel3.Visible = false;
				}

				panel5.Visible = true;
				label3.Visible = true;
				label8.Visible = true;
				label10.Visible = false;
				label11.Visible = true;
				label9.Visible = false;
			}

			if ((PhysicalSecurityLevel == "Level 4"))
			{
				label4.Visible = false;
				label6.Visible = false;

				radioButton_coatingAS0552.Visible = true;
				radioButton_enclosureAS0553.Visible = true;
				radioButton_coatingAS0536.Visible = true;
				radioButton_enclosureAS0537.Visible = true;
				checkBox_MaintenRole_MCS.Visible = true;
				checkBox_HoleSlit_MCS.Visible = true;
				checkBox_DoorCover_MCS.Visible = true;
				if (checkBox_DoorCover_MCS.Checked == true)
				{
					radioButton_keyTE0553.Visible = true;
					radioButton_tapeTE0553.Visible = true;
					panel3.Visible = true;
				}
				else
				{
					radioButton_keyTE0553.Visible = false;
					radioButton_tapeTE0553.Visible = false;
					panel3.Visible = false;
				}

				panel5.Visible = true;
				label3.Visible = true;
				label8.Visible = true;
				label10.Visible = false;
				label11.Visible = true;
				label9.Visible = false;
			}
		}

		private void checkBox_MaintenRole_SC_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox_HoleSlit_MCS_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox_DoorCover_MCS_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_DoorCover_MCS.Checked == true)
			{
				radioButton_keyTE0553.Visible = true;
				radioButton_tapeTE0553.Visible = true;
				panel3.Visible = true;
			}
			else
			{
				radioButton_keyTE0553.Visible = false;
				radioButton_tapeTE0553.Visible = false;
				panel3.Visible = false;
			}
		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void checkBox_DoorCover_MCE_CheckedChanged_1(object sender, EventArgs e)
		{
			checkBox_DoorCover_MCE.Visible = true;
			if (checkBox_DoorCover_MCE.Checked == true)
			{
				panel2.Visible = true;
				radioButton_keyTE053703.Visible = true;
				radioButton_tapeTE053703.Visible = true;
			}
			else
			{
				panel2.Visible = false;
				radioButton_keyTE053703.Visible = false;
				radioButton_tapeTE053703.Visible = false;
			}
		}
	}
}