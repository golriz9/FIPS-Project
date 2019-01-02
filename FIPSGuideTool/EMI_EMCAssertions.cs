using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FIPSGuideTool
{
	class EMI_EMCAssertions
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();

		string FCC_Lab    = EMI_EMC.FCC_Lab;
		string FCC_ID_No  = EMI_EMC.FCC_ID_No;
		string IssuedDate = EMI_EMC.IssuedDate;
		string OTAR       = KeyManagement.OTAR;
		string AS0802;
		string TE080201;
		string TE080202;
		string TE080501;
		string TE080502;

		public EMI_EMCAssertions()
		{
			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
			connection.Open();

			command.Connection = connection;
			connection.Close();
		}

		public void populateEMI_EMCLevel1234()
		{
			// start writing assertions for Level 1,2,3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				FCC_Lab = FCC_Lab.Replace("'","\''");
				FCC_ID_No = FCC_ID_No.Replace("'","\''");
				IssuedDate = IssuedDate.Replace("'","\''");

				string AS0801 = "This assertion is not separately tested.";

				if (OTAR == "True")
				{					
					TE080201 = "The tester verified that the vendor had supplied the name of the FCC Accredited Laboratory required under VE08.02.01." + Environment.NewLine +
					"FCC Accredited Laboratory: " + FCC_Lab;
					TE080202 = "The tester verified that the vendor had supplied the FCC ID number required under VE08.02.02." + Environment.NewLine +
				   "FCC ID number: " + FCC_ID_No;
				}
				else
				{					
					AS0802   = "N/A";
					TE080201 = "N/A";
					TE080202 = "N/A";			
				}
								
				string AS0803   = "This assertion is tested as part of AS08.04 and AS08.05.";							   

				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0801   + "'  WHERE VendorTester = 'AS' and Section = " + 8 + " and Requirement = " + 1 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE080201 + "'  WHERE VendorTester = 'TE' and Section = " + 8 + " and Requirement = " + 2 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE080202 + "'  WHERE VendorTester = 'TE' and Section = " + 8 + " and Requirement = " + 2 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0803   + "'  WHERE VendorTester = 'AS' and Section = " + 8 + " and Requirement = " + 3 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populateEMI_EMCLevel12()
		{
			// start writing assertions for Level 1,2
			try
			{
				connection.Open();
				command.Connection = connection;
				
				string TE080401 = "The tester verified that the vendor documentation indicated that the cryptographic module conformed to the EMI/EMC requirements specified by 47 Code " +
					"of Federal Regulations, Part 15, Subpart B, Unintentional Radiators, Digital Devices, Class A(i.e., for business use).";
				string TE080402 = "The tester verified that the version of the cryptographic module that was indicated on the supplied information specified in TE08.04.01 was" +
					" referenced in AS10.02.";

				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE080401 + "'  WHERE VendorTester = 'TE' and Section = " + 8 + " and Requirement = " + 2 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE080402 + "'  WHERE VendorTester = 'TE' and Section = " + 8 + " and Requirement = " + 2 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populateEMI_EMCLevel34()
		{
			// start writing assertions for Level 3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				TE080501 = "It was verified that the vendor supplied documentation (" + FCC_Lab + ", Report number " + FCC_ID_No + " - Year " + IssuedDate +
					") indicating" + " that the cryptographic module conforms to the EMI/EMC requirements specified by 47 Code of Federal Regulations," +
					" Part 15, Subpart B, Unintentional Radiators, Digital Devices, Class B (i.e., for home use).";

				TE080502 = "The tester verified that the versions of the cryptographic module that are indicated on the supplied information specified" +
					" in TE.08.05.01 is referenced in AS.10.02.";

				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE080501 + "'  WHERE VendorTester = 'TE' and Section = " + 8 + " and Requirement = " + 5 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE080502 + "'  WHERE VendorTester = 'TE' and Section = " + 8 + " and Requirement = " + 5 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
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