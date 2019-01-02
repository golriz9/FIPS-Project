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
	public partial class OpEnvironment : Form
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();
		public static string OpEnv_Modif;
		public static string OpEnv_Nonmodif;
		public static string OpEnvironmentSecurityLevel;

		public OpEnvironment()
		{
			InitializeComponent();

			OpEnv_Modif                = Properties.Settings.Default.OpEnv_Modif.ToString();
			OpEnv_Nonmodif             = Properties.Settings.Default.OpEnv_Nonmodif.ToString();
			OpEnvironmentSecurityLevel = Properties.Settings.Default.OpEnvironmentSecurityLevel.ToString();

			if (OpEnv_Modif == "True")
			{
				radioButton1.Checked = true;
			}
			else if (OpEnv_Nonmodif == "True")
			{
				radioButton2.Checked = true;
			}
		}

		private void OpEnvironment_Load(object sender, EventArgs e)
		{
			if (OpEnv_Modif == "True")
			{
				radioButton1.Checked = true;
			}

			if (OpEnv_Nonmodif == "True")
			{
				radioButton2.Checked = true;
			}
		}

			private void OpEnvironment_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
				connection.Open();

				command.Connection = connection;

				OpEnv_Modif = radioButton1.Checked.ToString();
				Properties.Settings.Default.OpEnv_Modif = OpEnv_Modif;

				OpEnv_Nonmodif = radioButton2.Checked.ToString();
				Properties.Settings.Default.OpEnv_Nonmodif = OpEnv_Nonmodif;
				Properties.Settings.Default.Save();

				OpEnvironmentAssertions f4 = new OpEnvironmentAssertions();

				f4.populateOpEnvironmentLevel1();
				f4.populateOpEnvironmentLevel1234();
				f4.populateOpEnvironmentLevel2();
				f4.populateOpEnvironmentLevel3();
				f4.populateOpEnvironmentLevel4();
				f4.populateOpEnvironmentLevel234();
				f4.populateOpEnvironmentLevel34();


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
	}
}