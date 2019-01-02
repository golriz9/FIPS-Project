using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FIPSGuideTool
{
	class DesignAssuranceAssertions
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();

		public DesignAssuranceAssertions()
		{
			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
			connection.Open();

			command.Connection = connection;
			connection.Close();
		}

		public void populateDesignAssuranceLevel1234()
		{
			// start writing assertions for Level 1,2,3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				string TE100101 = "The tester reviewed the vendor provided documents and verified that a CM system has been implemented.";
				string TE100201 = "The tester reviewed the vendor provided configuration list and verified inclusion of configuration items.";
				string TE100202 = "The tester verified that the CM documentation specified the method used to uniquely identify all configuration items.";
				string TE100203 = "The tester reviewed the vendor provided CM documentation and verified that it included a description of the method used to uniquely identify" +
					" each version of a configuration item being validated.";
				string TE100204 = "The tester verified that the CM documentation uniquely identified the version of each configuration item being validated.";
				string TE100301 = "The tester reviewed the vendor provided documentation and verified that it included installation, initialization, and start-up procedures" +
					" that result in a secure configuration.";
				string TE100302 = "The tester performed the procedures for the secure installation, initialization, and startup of the cryptographic module and verified their correctness.";
				string AS1005   = "This assertion is tested as part of AS10.06 and AS10.07.";
				string TE100601 = "The tester reviewed the vendor documentation and verified that the security policy (rules of operation) of the cryptographic module were correct. " +
					"The tester verified that each security rule was reflected in the design, and that the design implemented the rule.";
				string TE100701 = "The tester used the list supplied by the vendor and verified that a source listing for each software or firmware component was contained in the module.";
				string TE100801 = "The tester used the list supplied by the vendor and verified that the documentation included schematics and/or Hardware Description Language(HDL) listings" +
					" for the hardware components.";
				string AS1021   = "This assertion is tested as part of AS10.23.";
				string TE102301 = "The tester verified that the vendor documentation included the information listed in AS10.21, AS10.22 and AS10.23. And the crypto officer nonproprietary" +
					" guidance was available to the crypto officer.";
				string AS1024   = "This assertion is tested as part of AS10.25.";
				string TE102501 = "The tester verified that the vendor documentation included the information listed in AS10.24 and AS10.25. And the user nonproprietary guidance" +
					" was available to the user.";


				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE100101 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 1 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE100201 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 2 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE100202 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 2 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE100203 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 2 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE100204 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 2 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE100301 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 3 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE100302 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 3 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS1005   + "'  WHERE VendorTester = 'AS' and Section = " + 10 + " and Requirement = " + 5 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE100601 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 6 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE100701 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 7 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE100801 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 8 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS1021   + "'  WHERE VendorTester = 'AS' and Section = " + 10 + " and Requirement = " + 21 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS1021   + "'  WHERE VendorTester = 'AS' and Section = " + 10 + " and Requirement = " + 22 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE102301 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 23 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS1024   + "'  WHERE VendorTester = 'AS' and Section = " + 10 + " and Requirement = " + 24 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE102501 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 25 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();



				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populateDesignAssuranceLevel234()
		{
			// start writing assertions for Level 2,3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				string TE100401 = "The tester reviewed the vendor provided documentation and verified that procedures required for maintaining security while distributing and delivering" +
					" versions of the cryptographic module to authorized operators were correct.";
				string AS1009   = "This assertion is tested as part of AS10.10.";
				string TE101001 = "The tester reviewed the vendor functional specification and verified that the vendor functional specification described the cryptographic module," +
					" and each external interface and port.";
				string TE101002 = "The tester reviewed the vendor functional specification and verified that the vendor functional specification described the purpose of each external interface.";



				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE100401 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 4 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS1009   + "'  WHERE VendorTester = 'AS' and Section = " + 10 + " and Requirement = " + 9 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE101001 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 10 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE101002 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 10 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();


				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}

		public void populateDesignAssuranceLevel34()
		{
			// start writing assertions for Level 3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				string AS1011   = "This assertion is tested as part of AS10.12 and AS10.13.";
				string TE101201 = "The tester examined the source code for each of the software and/or firmware components to determine which ones were written in a low-level language. " +
					"The tester verified that there were no software and/or firmware components written in a low-level language that were not identified by the vendor in VE10.12.01.";
				string TE101301 = "The tester reviewed the vendor documentation and verified that the vendor supplied documentation on the hardware components that were implemented using a high-level " +
					"specification language.";


				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS1011   + "'  WHERE VendorTester = 'AS' and Section = " + 10 + " and Requirement = " + 11 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE101201 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 12 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE101301 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 13 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();


				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}

		public void populateDesignAssuranceLevel4()
		{
			// start writing assertions for Level 4
			try
			{
				connection.Open();
				command.Connection = connection;

				string AS1014   = "This assertion is tested as part of AS10.15 through AS10.20.";
				string TE101501 = "The tester analyzed the formal model to verify that:" + Environment.NewLine +
					"1. The statements of the formal model were written correctly in the vendor''s chosen formal specification language." + Environment.NewLine +
					"2. The formal model contained: " + Environment.NewLine +
					"a) a definition of a secure state, " + Environment.NewLine +
					"b) a representation of the initial state of the module, " + Environment.NewLine +
					"c) a model of the state transitions.";
				string AS1016   = "This assertion is tested as part of AS10.15.";
				string TE101701 = "The tester reviewed the vendor provided documentation for completeness and correctness in representing the rules specified in the security policy" +
					" of the cryptographic module.";
				string TE101801 = "The tester reviewed the informal proof and verified that the vendor provided an informal proof of the correspondence between the formal model and " +
					"the functional specification.";
				string TE101901 = "The tester reviewed the source code listings and verified that the source code listings for all hardware, software, and firmware components, included " +
					"as comments, pre- and post-conditions as required in AS10.19.";
				string TE102001 = "The tester reviewed the informal proof and verified that the vendor documentation included an informal proof of the correspondence between the design" +
					" of the cryptographic module and the functional specification.";

				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS1014   + "'  WHERE VendorTester = 'AS' and Section = " + 10 + " and Requirement = " + 14 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE101501 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 15 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS1016   + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 16 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE101701 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 17 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE101801 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 18 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE101901 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 19 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE102001 + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 20 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
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