using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FIPSGuideTool
{
	class MitigationOtherAttacksAssertions
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();

		public MitigationOtherAttacksAssertions()
		{
			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
			connection.Open();

			command.Connection = connection;
			connection.Close();
		}


		public void populateMitigationOtherAttacksLevel1234()
		{
			// start writing assertions for Level 1,2,3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				string TE110101 = "The tester verified that the vendor provided nonproprietary security policy specified the mechanism(s) implemented to mitigate the attack(s).";
				string TE110102 = "The tester verified that the vendor provided nonproprietary security policy indicated how the implemented mechanism(s) were shown to mitigate the attack(s).";

				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE110101 + "'  WHERE VendorTester = 'TE' and Section = " + 11 + " and Requirement = " + 1 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE110102 + "'  WHERE VendorTester = 'TE' and Section = " + 11 + " and Requirement = " + 1 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


	}
}