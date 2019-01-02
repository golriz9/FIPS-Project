using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FIPSGuideTool
{
	class OpEnvironmentAssertions
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();

		string OpEnv_Modif    = OpEnvironment.OpEnv_Modif;
		string OpEnv_Nonmodif = OpEnvironment.OpEnv_Nonmodif;

		public OpEnvironmentAssertions()
		{
			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
			connection.Open();

			command.Connection = connection;
			connection.Close();
		}

		public void populateOpEnvironmentLevel1234()
		{
			// start writing assertions for Level 1,2,3,4
			try
			{
				connection.Open();
				command.Connection = connection;			

				string AS0601   = "This assertion is not separately tested.";
				string AS0602   = "";
				string TE060201;

				if (OpEnv_Modif == "True")
				{
					TE060201 = "The tester verified that the information specified in VE06.02.01 was included." + Environment.NewLine +
					"The operational environment in which the module operates is modifiable.";

					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE060201 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 2 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (OpEnv_Nonmodif == "True")
				{
					TE060201 = "The tester verified that the information specified in VE06.02.01 was included." + Environment.NewLine +
					"The operational environment in which the module operates is non-modifiable.";

					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE060201 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 2 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}

				string AS0603   = "This assertion is tested as part of AS06.04 through AS06.08.";
				string TE060701 = "The tester attempted to perform unauthorized accesses and unauthorized modifications to software and firmware source and executable code. The " +
					"tester verified that the software and firmware sources and executable code were protected from unauthorized disclosure and modification.";
				string TE060801 = "The tester verified that the documentation identified the technique used to maintain the integrity of the cryptographic software and firmware component.";
				string TE060802 = "The tester attempted to corrupt the cryptographic software and firmware components and verified that the integrity was not maintained.";


				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0601   + "'  WHERE VendorTester = 'AS' and Section = " + 6 + " and Requirement = " + 1 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0602   + "'  WHERE VendorTester = 'AS' and Section = " + 6 + " and Requirement = " + 2 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0603   + "'  WHERE VendorTester = 'AS' and Section = " + 6 + " and Requirement = " + 3 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE060701 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 7 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE060801 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 8 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE060802 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 8 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populateOpEnvironmentLevel1()
		{
			// start writing assertions for Level 1
			try
			{
				connection.Open();
				command.Connection = connection;

				string TE060401 = "The tester operated the cryptographic module as described in the crypto officer and user guidance documentation. While the cryptographic module was" +
					" operating as specified, the tester attempted to circumvent the single-user enforcement mechanism. The tester verified that only one user at a time can use module.";

				string TE060501 = "The tester performed cryptographic functions as described in the crypto officer and user guidance documentation. While the cryptographic functions were" +
					" executing, the tester attempted to access secret and private keys, intermediate key generation values, and other CSPs. The tester verified that while cryptographic " +
					"process was in use, no other process could access private and secret keys, intermediate key generation values, and other CSPs.";

				string TE060601 = "The tester performed cryptographic functions as described in the crypto officer and user guidance documentation. While the cryptographic functions were " +
					" operating, the tester attempted to execute another process. The tester verified that no other process can interrupt the cryptographic module during execution.";

				


				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE060401 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 4 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE060501 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 5 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE060601 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 6 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				


				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}

		public void populateOpEnvironmentLevel2()
		{
			// start writing assertions for Level 2
			try
			{
				connection.Open();
				command.Connection = connection;

				string AS0609   = "This assertion is tested as part of AS06.10 through AS06.19.";
				string TE061001 = "The tester verified that the operating system received a certificate mutually recognized in accordance with the Arrangement on the Recognition of " +
					"Common Criteria Certificates in the field of Information Technology Security.";
				


				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0609   + "'  WHERE VendorTester = 'AS' and Section = " + 6 + " and Requirement = " + 9 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061001 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 10 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();


				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}



		public void populateOpEnvironmentLevel3()
		{
			// start writing assertions for Level 3
			try
			{
				connection.Open();
				command.Connection = connection;

				string AS0620   = "This assertion is tested as part of AS06.21 through AS06.25.";
				string TE062101 = "The tester verified that the operating system had received a certificate mutually recognized in accordance with the Arrangement on the Recognition" +
					" of Common Criteria Certificates in the field of Information Technology Security.";


				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0620   + "'  WHERE VendorTester = 'AS' and Section = " + 6 + " and Requirement = " + 20 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE062101 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 21 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();


				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populateOpEnvironmentLevel4()
		{
			// start writing assertions for Level 4
			try
			{
				connection.Open();
				command.Connection = connection;

				string AS0626 = "This assertion is tested as part of AS06.27.";
				string TE062701 = "The tester verified that the operating system had received a certificate mutually recognized in accordance with the Arrangement on the Recognition " +
					"of Common Criteria Certificates in the field of Information Technology Security.";


				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0626   + "'  WHERE VendorTester = 'AS' and Section = " + 6 + " and Requirement = " + 26 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE062701 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 27 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();


				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populateOpEnvironmentLevel234()
		{
			// start writing assertions for Level 2,3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				string TE061101 = "This TE is tested as part of TE06.14.01.";
				string TE061102 = "The tester assumed a role with privileges to execute the stored cryptographic software and firmware components. The tester executed the stored cryptographic" +
					" software and firmware components and verified the correct configuration of the operating system access control mechanisms.";
				string TE061103 = "The tester assumed a role that did not have privileges to execute the stored cryptographic software and firmware components. The tester attempted" +
					" to execute the stored cryptographic software and firmware components and verified the correct configuration of the operating system access control mechanisms." +
					" It was not possible to execute the stored cryptographic software and firmware components.";
				string TE061201 = "This TE is tested as part of TE06.14.01.";
				string TE061202 = "The tester assumed a role with privileges to modify the following cryptographic module software and firmware components stored within the cryptographic" +
					" boundary:"+ Environment.NewLine +
					"1. Cryptographic programs" + Environment.NewLine +
					"2.Cryptographic data(e.g., cryptographic keys, audit data)" + Environment.NewLine +
					"3.CSPs" + Environment.NewLine +
					"4.Plaintext data " + Environment.NewLine +
					"The tester modified the cryptographic module software and firmware components stored within the cryptographic boundary.";
				string TE061203 = "The tester assumed a role that did not have privileges to modify the stored cryptographic software and firmware components. The tester attempted" +
					" to modify the stored cryptographic software and firmware components.";
				string TE061301 = "This TE is tested as part of TE06.14.01.";
				string TE061302 = "The tester assumed a role with privileges to read the following cryptographic module software components stored within the cryptographic boundary: " + Environment.NewLine +
					"1.Cryptographic data(e.g., cryptographic keys and audit data) " + Environment.NewLine +
					"2.CSPs " + Environment.NewLine +
					"3.Plaintext data " + Environment.NewLine +
					"The tester read the cryptographic module software components stored within the cryptographic boundary.";
				string TE061303 = "The tester assumed a role that did not have privileges to read the stored cryptographic software components and attempted to read the stored " +
					"cryptographic software components.";
				string TE061401 = "The tester verified that the vendor documentation specified how the discretionary access control (DAC) mechanism was configured to meet" +
					" the requirements of AS06.11, AS06.12, AS06.13, and AS06.14.";
				string TE061402 = "The tester assumed a role with privileges to enter cryptographic keys and CSPs. The tester entered cryptographic keys and CSPs.";
				string TE061403 = "The tester assume a role that did not have privileges to enter cryptographic keys and CSPs.The tester attempt to enter cryptographic keys and CSPs.";
				string TE061501 = "The tester verified that the vendor documentation specified how the operating system prevented all operators and executing processes from modifying" +
					" executing cryptographic processes.";
				string TE061502 = "The tester attempted to modify executing cryptographic processes. The tester verified that the operator or executing process could not modify " +
					"an executing cryptographic process.";
				string TE061601 = "The tester verified that the vendor documentation specified how the operating system prevented operators and executing processes from reading " +
					"cryptographic software stored within the cryptographic boundary.";
				string TE061602 = "The tester attempted to read cryptographic software stored within the cryptographic boundary. The tester verified that no operator or executing " +
					"process can read the cryptographic software stored within the cryptographic boundary.";
				string TE061701 = "The tester verified that the vendor identified all the events that are auditable by the cryptographic module software. The list included" +
					" the events specified in AS06.18 and AS06.19.";
				string TE061702 = "The tester exercised the cryptographic module, with the auditing capability turned on, and performed the actions that generate auditable events. " +
					"The tester reviewed the system’s audit log to determine if all the events were audited.";
				string AS0618   = "This assertion is tested as part of AS06.17.";
				




				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061101 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 11 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061102 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 11 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061103 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 11 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061201 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 12 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061202 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 12 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061203 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 12 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061301 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 13 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061302 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 13 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061303 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 13 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061401 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 14 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061402 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 14 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061403 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 14 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061501 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 15 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061502 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 15 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061601 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 16 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061602 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 16 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061701 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 17 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE061702 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 17 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0618   + "'  WHERE VendorTester = 'AS' and Section = " + 6 + " and Requirement = " + 18 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0618   + "'  WHERE VendorTester = 'AS' and Section = " + 6 + " and Requirement = " + 19 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				


				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populateOpEnvironmentLevel34()
		{
			// start writing assertions for Level 3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				string TE062201 = "The tester verified that the vendor documentation specified the trusted path mechanism used by the cryptographic module to communicate cryptographic " +
					"keys and CSPs, authentication data, control inputs, and status outputs.";
				string TE062202 = "The tester used the trusted mechanism to communicate all cryptographic keys and CSPs, authentication data, control inputs, and status outputs";
				string TE062203 = "The tester attempted, for each input and output identified in AS06.22, to enter or output the information via an untrusted mechanism.";
				string TE062301 = "The tester verified that the vendor documentation specified the trusted path used between the TSF and the operator when a positive TSF-to-operator " +
					"connection is required.";
				string TE062401 = "The tester verified that the vendor documentation specified how the trusted path was activated exclusively by an operator or the TSF and was" +
					" logically isolated from other paths.";
				string TE062402 = "The tester invoked the trusted path. If the capability existed for the TSF to invoke the trusted path, the tester exercised the cryptographic module " +
					"to cause the TSF to invoke the trusted path.";
				string TE062403 = "The tester attempted to cause the trusted path to be invoked by non-TSF software.";
				string TE062501 = "The tester verified that the vendor list of audited events included attempts to use the trusted path function, and identification of the initiator" +
					" and target of a trusted path.";
				string TE062502 = "The tester exercised the cryptographic module, with the auditing capability turned on, and performed the actions that generated the audited events. " +
					"The tester reviewed the system''s audit log to determine if all the events were audited.";


				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE062201 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 22 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE062202 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 22 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE062203 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 22 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE062301 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 23 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE062401 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 24 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE062402 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 24 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE062403 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 24 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE062501 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 25 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE062502 + "'  WHERE VendorTester = 'TE' and Section = " + 6 + " and Requirement = " + 25 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
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