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
	public partial class EMI_EMC : Form
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();

		public static string FCC_Lab;
		public static string FCC_ID_No;
		public static string EMI_EMCSecurityLevel;
		public static string IssuedDate;

		public EMI_EMC()
		{
			InitializeComponent();
			FCC_Lab    = Properties.Settings.Default.FCC_Lab.ToString();
			FCC_ID_No  = Properties.Settings.Default.FCC_ID_No.ToString();
			IssuedDate = Properties.Settings.Default.IssuedDate.ToString();

			txtbox_FCC_Lab.Text = FCC_Lab;
			txtbox_FCC_ID_No.Text = FCC_ID_No;
			txtBox_IssuedDate.Text = IssuedDate;
		}


		private void EMI_EMC_Load(object sender, EventArgs e)
		{

		}

		private void EMI_EMC_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
				connection.Open();
				command.Connection = connection;

				FCC_Lab = txtbox_FCC_Lab.Text;
				Properties.Settings.Default.FCC_Lab = FCC_Lab;

				FCC_ID_No = txtbox_FCC_ID_No.Text;
				Properties.Settings.Default.FCC_ID_No = FCC_ID_No;

				IssuedDate = txtBox_IssuedDate.Text;
				Properties.Settings.Default.IssuedDate = IssuedDate;

				Properties.Settings.Default.Save();

				EMI_EMCAssertions f1 = new EMI_EMCAssertions();
				f1.populateEMI_EMCLevel12();
				f1.populateEMI_EMCLevel1234();
				f1.populateEMI_EMCLevel34();

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