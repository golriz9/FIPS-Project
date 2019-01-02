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
	public partial class ModuleInfo : Form
	{
		private OleDbConnection connection = new OleDbConnection();
		public ModuleInfo()
		{
			InitializeComponent();
			connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\GolrizSedaghat\Desktop\Template.mdb;
Persist Security Info=False;";
		}

		private void VendorInfo_Load(object sender, EventArgs e)
		{

		}

		private void btn_SaveData_Click(object sender, EventArgs e)
		{
			try
			{
				connection.Open();
				OleDbCommand command = new OleDbCommand();
				command.Connection = connection;
				//command.CommandText = "select * from ValidationInfo where Requirement = '" + txt_Req1.Text + "' and SequenceNo ='" + txt_SeqNo1.Text + "'";
				command.CommandText = "insert into GeneralVendorInfo (Vendor,Address1) values('" + txt_LabInternalID.Text + "', '" + txt_Addr1.Text + "')";

				command.ExecuteNonQuery();
				MessageBox.Show("Data Saved");
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}
	}
}
