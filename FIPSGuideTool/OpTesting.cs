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
using System.Data.SqlClient;
using System.IO;

namespace FIPSGuideTool
{
	public partial class OpTesting : Form
	{
		// Algorithms  
		public static string TDES;
		public static string AES;
		public static string SHS;
		public static string SHA_3;
		public static string DRBG;
		public static string DSA;
		public static string ECDSA;
		public static string RSA;
		public static string HMAC;
		public static string CCM;
		public static string CMAC;
		public static string KAS_FFC;
		public static string KAS_ECC;
		public static string GCM;
		public static string XTS;
		public static string KDF_108;
		public static string KDF_135;
		public static string KeyWrap;
		public static string CVL;

		string txtFilePath;
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();
		OleDbDataReader dataSearch;

		public static int VectorLength = 1000;
		string[] VendorTesterAll = new string[VectorLength];
		string[] AssessmentAll = new string[VectorLength];
		string[] Section = new string[VectorLength];
		string[] RequirementAll = new string[VectorLength];
		string[] SequenceNoAll = new string[VectorLength];
		int NoAlgs;

		public OpTesting()
		{
			InitializeComponent();
			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
			connection.Open();
			command.Connection = connection;
			connection.Close();

			TDES = Properties.Settings.Default.TDES.ToString();
			AES = Properties.Settings.Default.AES.ToString();
			SHS = Properties.Settings.Default.SHS.ToString();
			SHA_3 = Properties.Settings.Default.SHA_3.ToString();
			DRBG = Properties.Settings.Default.DRBG.ToString();
			DSA = Properties.Settings.Default.DSA.ToString();
			ECDSA = Properties.Settings.Default.ECDSA.ToString();
			RSA = Properties.Settings.Default.RSA.ToString();
			HMAC = Properties.Settings.Default.HMAC.ToString();
			CCM = Properties.Settings.Default.CCM.ToString();
			CMAC = Properties.Settings.Default.CMAC.ToString();
			KAS_FFC = Properties.Settings.Default.KAS_FFC.ToString();
			KAS_ECC = Properties.Settings.Default.KAS_ECC.ToString();
			GCM = Properties.Settings.Default.GCM.ToString();
			XTS = Properties.Settings.Default.XTS.ToString();
			KDF_108 = Properties.Settings.Default.KDF_108.ToString();
			KDF_135 = Properties.Settings.Default.KDF_135.ToString();
			KeyWrap = Properties.Settings.Default.KeyWrap.ToString();
			CVL = Properties.Settings.Default.CVL.ToString();

			
		}

		private void OpTesting_Load(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string TE = listBox_OpTestTEs.SelectedItem.ToString();

			connection.Open();
			command.Connection = connection;
			command.CommandText = "SELECT * FROM ValidationInfo";
			dataSearch = command.ExecuteReader();

			int ii = 0;
			while (dataSearch.Read())
			{
				VendorTesterAll[ii] = dataSearch.GetValue(0).ToString();
				AssessmentAll[ii] = dataSearch.GetValue(5).ToString();
				Section[ii] = dataSearch.GetValue(1).ToString();
				RequirementAll[ii] = dataSearch.GetValue(2).ToString();
				SequenceNoAll[ii] = dataSearch.GetValue(3).ToString();	
				ii++;
			}
			dataSearch.Close();

			if (TE == "TE01.03.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall invoke the Approved mode of operation using the vendor " +
					"provided instructions found in the nonproprietary Security Policy.";

				dataSearch = command.ExecuteReader();
				int ij = 0;		
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "1") &&  (RequirementAll[ij] == "3") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();							
					}					
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE01.04.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall use the vendor provided instructions described in " +
					"the non-proprietary security policy to obtain the Approved mode of operation indicator.";
				//txtBox_TEs_OpTest_Assessment.Text = "The module has only a single (Approved) mode of operation. " +
				//	"The Approved mode is invoked by powering-on the module if no tamper event is detected. " +
				//	"The “Get Status” service of the module shows whether or not the module is in an error state " +
				//	"or was powered on successfully to the Approved mode of operation. ";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "1") && (RequirementAll[ij] == "4") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE02.04.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall verify if vendor documentation specifies any external " +
					"input devices to be used with the cryptographic module for the entry of data into the data " +
					"input interface, such as smart cards, tokens, keypads, key loaders, and/or biometric devices. " +
					"The tester shall enter data into the data input interface using the identified external " +
					"input device(s), and verify that entry of data using the external input device functions as specified.";
				//txtBox_TEs_OpTest_Assessment.Text = "Given that the module interfaces with other systems. All data " +
				//	"transmitted/received to/from the device should be as documented. No other mechanisms should be " +
				//	"available to store data.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "2") && (RequirementAll[ij] == "4") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE02.05.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall verify if vendor documentation specifies any external output " +
					"devices to be used with the cryptographic module for the output of data from the data input " +
					"interface, such as smart cards, tokens, displays, and/or other storage devices. The tester shall " +
					"output data from the data output interface using the identified external output device(s), and verify" +
					" that output of data using the external output device functions as specified.";
				//txtBox_TEs_OpTest_Assessment.Text = "Given that the module interfaces with other systems. All data " +
				//	"transmitted/received to/from the device should be as documented. No other mechanisms should " +
				//	"be available to store data. ";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "2") && (RequirementAll[ij] == "5") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE02.06.02")
			{
				txtBox_TEs_OpTest.Text = "To the extent that the cryptographic module design and operating procedures " +
					"allow, the tester shall cause the cryptographic module to enter each specified error " +
					"state and verify that all data output via the data output interface is inhibited. If status " +
					"information is output from the status output interface to identify the type of error, " +
					"the tester shall verify that the information output is not sensitive. The following actions may " +
					"be used to cause the cryptographic module to enter an error state - opening a tamper-detected cover or " +
					"door, entering incorrectly-formatted commands, keys, or parameters, reducing input voltage, and/or " +
					"any other error-causing actions.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "2") && (RequirementAll[ij] == "6") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE02.06.04")
			{
				txtBox_TEs_OpTest.Text = "To the extent that the cryptographic module design and operating procedures " +
					"allow, the tester shall command the module to perform the self-tests and verify that all data " +
					"output via the data output interface is inhibited. If status information is output from the " +
					"status output interface to display the results of the self-tests, the tester shall verify that " +
					"no CSPs, plaintext data, or other information that if misused could lead to a compromise.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "2") && (RequirementAll[ij] == "6") && (SequenceNoAll[ij] == "4"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE02.07.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall verify if vendor documentation specifies any external " +
					"input devices to be used with the cryptographic module for the entry of commands, signals, and " +
					"control data into the control input interface, such as smart cards, tokens, or keypads. The " +
					"tester shall enter commands via the control input interface using the identified external " +
					"output device(s), and verify that input of commands using the external output device " +
					"functions as specified.";
				//txtBox_TEs_OpTest_Assessment.Text = "Given that the module interfaces with other systems. " +
				//	"All data transmitted/received to/from the device should be as documented.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "2") && (RequirementAll[ij] == "7") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE02.09.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall verify, by inspection of the cryptographic module, that all" +
					" power entering or exiting the module to/from other devices external to the cryptographic boundary" +
					" passes through the specified power interface. Note that a power interface may not be required if " +
					"all power is provided or maintained internally to the module, and that replacement of an " +
					"internal battery is considered a physical maintenance activity, and is subject to the " +
					"requirements provided under the assertions in Section 5.";
				//txtBox_TEs_OpTest_Assessment.Text = "Given that the module interfaces with other systems. " +
				//	"All power to the device should be as documented.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "2") && (RequirementAll[ij] == "9") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE02.13.03")
			{
				txtBox_TEs_OpTest.Text = "The tester shall verify that the output data path is logically or physically " +
					"disconnected from the processes performing key generation, manual key entry, and zeroization of " +
					"cryptographic keys and CSPs by recording or observing the output data interface and the applicable " +
					"physical ports and verifying that no key or CSP information is released.";
				//txtBox_TEs_OpTest_Assessment.Text = "No sensitive information should be output from the data output" +
				//	" interface during key generation and zeroization of the module. The module does not support manual" +
				//	" key entry. The module does not employ manual key entry.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "2") && (RequirementAll[ij] == "13") && (SequenceNoAll[ij] == "3"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE02.14.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall cause the output of cryptographic key components or other " +
					"unprotected CSPs on one or more physical ports, and verify that the two independent internal " +
					"actions function as specified. If any software or firmware components are executed in the process " +
					"of outputting plaintext cryptographic key components or other unprotected CSPs, the tester " +
					"shall examine the applicable source code listings to ensure that the software or " +
					"firmware components support the requirement for two independent internal actions before the output " +
					"of any plaintext cryptographic key components or other unprotected CSPs occurs.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "2") && (RequirementAll[ij] == "14") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE02.16.02")
			{
				txtBox_TEs_OpTest.Text = "If the cryptographic module inputs or outputs plaintext cryptographic key " +
					"components, plaintext authentication data, or other unprotected CSPs, the tester shall verify " +
					"that only plaintext cryptographic keys, plaintext authentication data, or other unprotected " +
					"CSPs enter or exit the module through the applicable physical ports, and that no " +
					"other data, plaintext or encrypted, enters or exits the module via the " +
					"applicable physical ports.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "2") && (RequirementAll[ij] == "16") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.02.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall assume the identity of two independent operators: " +
					"Operator1 and Operator2. The operators shall assume different roles. The tester shall verify" +
					" that only the services allocated to each role can be performed in that role. The tester shall" +
					" also attempt, for each operator, to access services that are unique to the role assumed" +
					" by the other operator in order to verify that separation is maintained " +
					"between the roles and services allowed in concurrent operators.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "2") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.02.03")
			{
				txtBox_TEs_OpTest.Text = "If the vendor documentation specifies any restrictions on " +
					"concurrent operators, the tester shall attempt to violate the restrictions by attempting to " +
					"concurrently assume restricted roles as independent operators and verify that the module " +
					"enforces the restrictions by preventing the second operator from assuming the role.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "2") && (SequenceNoAll[ij] == "3"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.05.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall, while in a non-maintenance role, load nonzero values for" +
					" all private and secret keys and other unprotected CSPs. Upon assuming the maintenance role, the" +
					" tester shall verify that zeroization has taken place.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "5") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.05.03")
			{
				txtBox_TEs_OpTest.Text = "While in the maintenance role, the tester shall load nonzero values for all " +
					"private and secret keys and other unprotected CSPs and, upon exit from the maintenance role, shall" +
					" verify that zeroization has taken place.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "5") && (SequenceNoAll[ij] == "3"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.06.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall assume each of the authorized roles described in the vendor " +
					"documentation and verify that each of them can be assumed. Verification of the services that are " +
					"designated for each role will be performed under AS03.14.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "6") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.12.03")
			{
				txtBox_TEs_OpTest.Text = "The tester shall attempt to transition to each bypass state from each state " +
					"that shows such a transition, and determine that it takes two internal actions to accomplish each" +
					" such transition.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "12") && (SequenceNoAll[ij] == "3"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.13.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall transition to each bypass state and verify that the " +
					"“Show Status” indicates the applicable bypass status.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "13") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.14.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall perform the following for each role: " + Environment.NewLine + 
					"1.Perform each of the specified services for the role to verify that they have been implemented for that role. " + Environment.NewLine +
					"2.Enter each of the specified service inputs and observe that they result in the specified service outputs. " + Environment.NewLine +
					"3.Attempt to perform services that are not specified for the role to verify that they have not been implemented for that role.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "14") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.15.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall perform the following tests: " + Environment.NewLine +
					"1.Enter each of the specified service inputs and observe that they result in the specified service outputs. " + Environment.NewLine +
					"2.Attempt to perform services that require a role to verify that they have not been implemented.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "15") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.17.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall assume each role and initiate an error during the authentication " +
					"procedure. The tester shall observe that the module denies access to each role.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "17") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.18.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall perform the following tests: " + Environment.NewLine +
					"1.Assume a role, attempt to change to another role that the operator is authorized to assume, and verify that the module allows the " +
					"operator to request services assigned to the new role. " + Environment.NewLine +
					"2.Assume a role, attempt to change to another role that the operator is not authorized to assume, and verify that the module does not" +
					" allow the operator to request the services assigned only to the new role.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "18") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.19.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall initiate an error during the authentication procedure and shall observe that" +
					" the module does not allow the tester to proceed beyond the authentication procedure.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "19") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.19.03")
			{
				txtBox_TEs_OpTest.Text = "The tester shall successfully authenticate his/her identity to the module. When required to select one or " +
					"more roles, the tester shall select roles not compatible with the authenticated identity and shall observe that authorization to " +
					"assume the roles is denied.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "19") && (SequenceNoAll[ij] == "3"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.20.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall perform the following tests: " + Environment.NewLine +
					"1.Assume each role, attempt to change to another role that the tester is authorized to assume, verify that the tester’s identity " +
					"does not have to be reauthenticated, and verify that the tester can access the services associated with the new role.The tester shall" +
					" perform services in the new role that were not associated with the previous role in order to verify that the tester has assumed a different role." + Environment.NewLine +
					"2.Assume each role, attempt to change to another role that the operator is not authorized to assume, and verify that the module " +
					"denies access to the role based on the identity of the operator.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "20") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.21.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall authenticate himself/herself to the module and assume one or more roles, power off the module, " +
					"power on the module, and attempt to perform services in those roles. The module should deny access to the services and require that" +
					" the tester be re-authenticated.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "21") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.22.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall perform the following tests: " + Environment.NewLine +
					"1.Attempt to access(by circumventing the documented protection mechanisms) authentication data for which the tester is not authorized " +
					"to have access.If the module denies access or allows access only to encrypted or otherwise protected forms of data, the requirement is met." + Environment.NewLine +
					"2. Modify authentication data using any method not specified by the vendor documentation and attempt to enter the modified data.The module " +
					"shall not allow the tester to be authenticated using the modified data.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "22") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.23.02")
			{
				txtBox_TEs_OpTest.Text = "If access to the module before initialization is controlled, the tester shall initiate an error on an uninitialized" +
					" module and shall verify that the module denies access. The tester shall assume the authorized role and verify that the required authentication " +
					"complies with the documented procedures. The tester shall attempt to assume other roles before the module has been initialized and verify that " +
					"the module denies access to the roles.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "23") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.27.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall enter authentication data and verify that there is no visible display of authentication data during data entry.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "27") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE03.28.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall enter authentication data to assume each role to ensure that the feedback mechanism does not provide useful information.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "3") && (RequirementAll[ij] == "28") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE04.03.01")
			{
				txtBox_TEs_OpTest.Text = "From each error state that does not require maintenance, service, or repair, the tester shall verify that the cryptographic module can be" +
					" caused to transition to an acceptable operational or initialization state. This effort consists of two parts: first, the tester shall verify that the cryptographic" +
					" module indicates when it is an error state, and second, that the module operates correctly in this target state. The tester shall report how the requirement was" +
					" verified (i.e., by code examination or by exercising the module).";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "4") && (RequirementAll[ij] == "3") && (SequenceNoAll[ij] == "1"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE04.05.05")
			{
				txtBox_TEs_OpTest.Text = "The tester shall verify that the operation of the module is consistent with the finite state diagrams and descriptions.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "4") && (RequirementAll[ij] == "5") && (SequenceNoAll[ij] == "5"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE04.05.08")
			{
				txtBox_TEs_OpTest.Text = "The tester shall exercise the cryptographic module, causing it to enter each of its major states. For each state that has a distinct indicator," +
					" the tester shall attempt to observe the indicator while the module is in the state. If the expected indicator is not observed, or two or more such indicators are " +
					"observed at the same time (indicating that the module is in more than one state at one time), this test fails.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "4") && (RequirementAll[ij] == "5") && (SequenceNoAll[ij] == "8"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE05.09.02")
			{
				txtBox_TEs_OpTest.Text = "If the module design and operating procedures allow it, the tester shall access the maintenance access interface while the unit is powered on," +
					" and verify that all operational keys are zeroized. Removing power to memory and allowing charge to slowly dissipate is not sufficient.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "5") && (RequirementAll[ij] == "9") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.01.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall perform the following tests: " + Environment.NewLine +
					"1. Attempt to access(by circumventing the documented protection mechanisms) secret keys, private keys, and CSPs for which the tester is not authorized " +
					"to access.If the module denies access or allows access only to encrypted or otherwise protected forms of the secret keys, private keys, and CSPs, the " +
					"requirement is met. " + Environment.NewLine +
					"2. Modify all secret keys, private keys, and CSPs using any method not specified by the vendor documentation and attempt to load them into the module. " +
					"The module should not allow any of the secret keys, private keys, and CSPs to be successfully loaded.The tester shall attempt to perform cryptographic operations" +
					" using secret keys and private keys.The module should not perform the operations.The tester shall attempt to perform a cryptographic service using the CSPs. The " +
					"module should not perform the operations.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "1") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.02.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall modify all public keys using any method not specified by the vendor documentation and shall attempt to load them into the module." +
					" The module should not allow any of the keys to be successfully loaded. The tester shall attempt to perform cryptographic operations using these keys; the module should " +
					"not perform the operations, indicating that the keys were not loaded.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "2") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.15.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall verify that no intermediate key generation values are output from the cryptographic module during the key generation process.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "15") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.15.03")
			{
				txtBox_TEs_OpTest.Text = "The tester shall observe the output interface and verify that all output matches the documented output, and that no plaintext intermediate key" +
					" generation values are output.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "15") && (SequenceNoAll[ij] == "3"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.15.04")
			{
				txtBox_TEs_OpTest.Text = "The tester shall verify that upon completion, the intermediate key generation values are output in either 1) in encrypted form, or 2) under " +
					"split knowledge procedures.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "15") && (SequenceNoAll[ij] == "4"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.23.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall enter a seed key and shall verify that the method used to enter it is consistent with the documented method.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "23") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.25.02")
			{
				txtBox_TEs_OpTest.Text = "For each key that can be entered or output, the tester shall first output the key while assuming a particular entity. " +
					"The tester shall then verify the association between key and entity by performing the following tests: " + Environment.NewLine + 
					"1.The tester shall assume a different entity from the one under which the key was output.The tester shall then attempt to enter the key and shall" +
					" verify that key entry fails. " + Environment.NewLine +
					"2.The tester shall, if possible, alter the key component such that the key is associated with a different entity.The tester shall then assume the " +
					"entity under which the key was output, attempt to enter the key, and shall verify that key entry fails.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "25") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.27.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall enter all encrypted cryptographic keys and key components and shall monitor the output interface of the " +
					"module to verify that any resulting plaintext key material is not displayed.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "27") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.28.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall enter and output each of the manually entered keys and shall verify that they are entered and/or" +
					" output according to the documentation.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "28") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.29.02")
			{
				txtBox_TEs_OpTest.Text = "If automated means are used to establish secret and private keys, the tester shall verify that these keys are " +
					"entered into and output from the cryptographic module in encrypted form.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "29") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.31.04")
			{
				txtBox_TEs_OpTest.Text = "If manual methods are used to establish secret and private keys, the tester shall verify that these keys are output " +
					"from the cryptographic module either (1) in encrypted form or (2) using split knowledge procedures (i.e., as two or more plaintext cryptographic key components).";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "31") && (SequenceNoAll[ij] == "4"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.32.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall enter each key component using split knowledge procedures and verify that each operator entering a key component is authenticated.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "32") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.32.03")
			{
				txtBox_TEs_OpTest.Text = "The tester shall output each key component using split knowledge procedures and verify that each operator outputting a key component " +
					"is authenticated.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "32") && (SequenceNoAll[ij] == "3"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.39.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall alter the association of key and entity. The tester shall then attempt to perform cryptographic functions as one of the entities and" +
					" shall verify that these functions fail. ";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "39") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.41.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall note which keys are present in the module and initiate the zeroize command. Following the completion of the zeroize" +
					" command, the tester shall attempt to perform cryptographic operations using each of the plaintext secret and private cryptographic keys and CSPs that were" +
					" stored in the module. The tester shall verify that each plaintext secret and private cryptographic keys and CSPs cannot be accessed.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "41") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE07.41.03")
			{
				txtBox_TEs_OpTest.Text = "The tester shall initiate zeroization and verify the key destruction method is performed in a sufficient time that an attacker cannot access " +
					"plaintext secret and private cryptographic keys and other plaintext CSPs while under the direct control of the operator of the module (i.e. present to observe " +
					"the method has completed successfully or controlled via a remote management session). If the method is not under the direct control of the operator, " +
					"then rationale shall be provided on how the zeroization method(s) are employed such that the secret and private cryptographic " +
					"keys and other CSPs within the module cannot be obtained by an attacker.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "7") && (RequirementAll[ij] == "41") && (SequenceNoAll[ij] == "3"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE09.04.03")
			{
				txtBox_TEs_OpTest.Text = "The tester shall run self-tests and cause the module to enter every error state. The tester shall compare the observed error indicator with the" +
					" indicator specified in the vendor documentation. If they are not the same, the assertion fails.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "9") && (RequirementAll[ij] == "4") && (SequenceNoAll[ij] == "3"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE09.05.03")
			{
				txtBox_TEs_OpTest.Text = "The tester shall put the module in the error state and verify that any cryptographic operations that the tester attempts to initiate are prevented.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "9") && (RequirementAll[ij] == "5") && (SequenceNoAll[ij] == "3"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE09.06.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall put the module in an error state and verify that all data output via the data output interface is inhibited when an error state exists.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "9") && (RequirementAll[ij] == "6") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE09.07.02")
			{
				txtBox_TEs_OpTest.Text = "Documentation shall specify: " + Environment.NewLine + 
					"the self-tests performed by the cryptographic module, including power-up and conditional tests, " + Environment.NewLine +
					"the error states that the cryptographic module can enter when a self-test fails, and " + Environment.NewLine +
					"the conditions and actions necessary to exit the error states and resume normal operation of the cryptographic " +
					"module(i.e., this may include maintenance of the module, or returning the module to the vendor for servicing.) " + Environment.NewLine +
					"The tester shall check that the information provided above is specified for each error condition.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "9") && (RequirementAll[ij] == "7") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE09.07.03")
			{
				txtBox_TEs_OpTest.Text = "The tester shall cause each error condition to occur and shall attempt to clear the error condition. The tester shall verify that actions necessary" +
					" to clear the error condition are consistent with the vendor documentation. If the tester cannot cause each error condition to occur, the tester shall review the " +
					"code listing and or design documentation to determine whether the actions necessary to clear each error condition are consistent with the descriptions in the vendor" +
					" documentation.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "9") && (RequirementAll[ij] == "7") && (SequenceNoAll[ij] == "3"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE09.09.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall power-up the module and verify that the module performs the power-up self-tests without requiring any operator intervention.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "9") && (RequirementAll[ij] == "9") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE09.10.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall power-up the module and shall monitor the status output interface. The expected indicator from the status output interface should" +
					" be consistent with the documented indicator.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "9") && (RequirementAll[ij] == "10") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE09.12.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall initiate the power-up on demand self-tests to verify that the initiation of the power-up self-tests on demand is consistent " +
					"with vendor documentation.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "9") && (RequirementAll[ij] == "12") && (SequenceNoAll[ij] == "2"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE09.22.07")
			{
				txtBox_TEs_OpTest.Text = "If possible, the tester shall test the module by modifying the stored software, firmware, or the implemented integrity mechanism and initiating" +
					" the self-tests, and observing the output from the status output interface. If no indicator is output that indicates that the software/firmware self-test failed, the" +
					" assertion fails.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "9") && (RequirementAll[ij] == "22") && (SequenceNoAll[ij] == "7"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE09.24.01")
			{
				txtBox_TEs_OpTest.Text = "The tester shall verify that the implemented EDCs are at least 16 bits in length.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "9") && (RequirementAll[ij] == "24") && (SequenceNoAll[ij] == "1"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE09.35.05")
			{
				txtBox_TEs_OpTest.Text = "If possible, the tester shall test the module by modifying the software or firmware to be loaded, or the implemented authentication mechanism and " +
					"initiating the self-tests, and observing the output from the status output interface. If no indicator is output that indicates that the software/firmware load test " +
					"failed, the assertion fails.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "9") && (RequirementAll[ij] == "35") && (SequenceNoAll[ij] == "5"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE09.40.03")
			{
				txtBox_TEs_OpTest.Text = "For manual key entry tests using EDCs, the tester shall perform the following tests: " + Environment.NewLine +
					"1.The tester shall enter every manually entered key and verify that the procedure used to enter each key is in accordance with the documented procedure, " +
					"including the form that the keys are in when they are entered.  " + Environment.NewLine +
					"2.The tester shall enter each type of manually - entered key without any errors and shall observe the status output interface. If no indicator is detected," +
					" or if the indicator does not match the documented indicator for the success of the manual key entry test, the test is failed." + Environment.NewLine +
					"3. The tester shall attempt to perform cryptographic operations with each entered key to verify that it was entered correctly. "+ Environment.NewLine +
					"4. The tester shall change either the EDC associated with each manually-entered key or the key itself and shall enter them into the module.The tester " +
					"shall observe the indicator that is output from the status output interface; if no output is detected, or the indicator does not match the documented" +
					" indicator for the failure of the manual key entry test, the test is failed. "+ Environment.NewLine +
					"5. The tester shall attempt to perform cryptographic operations with each key that was not successfully entered.Each operation using each key should fail," +
					" verifying that the key was not entered.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "9") && (RequirementAll[ij] == "40") && (SequenceNoAll[ij] == "3"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE09.40.04")
			{
				txtBox_TEs_OpTest.Text = "For manual key entry tests using duplicate key entries, the tester shall perform the following tests: " + Environment.NewLine +
					"1.The tester shall enter each type of manually - entered key without any errors and shall observe the status output interface. If no indicator is detected," +
					" or if the indicator does not match the documented indicator for the success of the manual key entry test, the test is failed. " + Environment.NewLine +
					"2. The tester shall attempt to perform cryptographic operations with each entered key to verify that it was entered correctly. " + Environment.NewLine +
					"3. The tester shall alter the accuracy of one of the manually entered keys, either the first or second duplicate entry, and shall enter them into the module." +
					"The tester shall observe the indicator that is output from the status output interface; if no output is detected, or the indicator does not match the documented" +
					" indicator for the failure of the manual key entry test, the test is failed. "+ Environment.NewLine +
					"4. The tester shall attempt to perform cryptographic operations with each key that was not successfully entered.Each operation using each key should fail, " +
					"verifying that the key was not entered.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "9") && (RequirementAll[ij] == "40") && (SequenceNoAll[ij] == "4"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE09.45.03")
			{
				txtBox_TEs_OpTest.Text = "The tester shall switch the module from the exclusive bypass service to the exclusive cryptographic service and verify that plaintext " +
					"information is not output.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "9") && (RequirementAll[ij] == "45") && (SequenceNoAll[ij] == "3"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE09.46.03")
			{
				txtBox_TEs_OpTest.Text = "The tester shall verify the correct operation of the bypass test by: " + Environment.NewLine +
					"1. Verifying that the mechanism governing the switching procedure checks to ensure that no alteration of the mechanism has taken place since the last modification. " +
					"The tester will document the method used.If the design allows, the tester shall alter the mechanism to test the method used. " + Environment.NewLine +
					"2.Modifying the mechanism governing the switching procedure in order to verify the correct operation of the mechanism and to verify the correct operation of" +
					" the cryptographic service by verifying that the plaintext information is not output.";
				dataSearch = command.ExecuteReader();
				int ij = 0;
				while (dataSearch.Read())
				{
					if ((VendorTesterAll[ij] == "TE") && (Section[ij] == "9") && (RequirementAll[ij] == "46") && (SequenceNoAll[ij] == "3"))
					{
						txtBox_TEs_OpTest_Assessment.Text = dataSearch.GetValue(5).ToString();
					}
					ij++;
				}
				dataSearch.Close();
			}
			else if (TE == "TE10.03.02")
			{
				txtBox_TEs_OpTest.Text = "The tester shall perform the procedures for the secure installation, initialization, and startup of the cryptographic module and verify " +
					"their correctness.";
				txtBox_TEs_OpTest_Assessment.Text = "";
			}
			connection.Close();
		}

		private void OpTesting_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				//TDES = txtBox_TEs_OpTest_Assessment.Text;
				//Properties.Settings.Default.TDES = TDES;
				//Properties.Settings.Default.Save();

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

		private void button1_Click(object sender, EventArgs e)
		{
			if (listBox_OpTestTEs.SelectedItem != null)
			{ 
				string TE = listBox_OpTestTEs.SelectedItem.ToString();

				connection.Open();
				command.Connection = connection;

				if (TE == "TE01.03.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 3 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE01.04.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 4 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE02.04.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 4 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE02.05.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 5 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE02.06.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 6 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE02.06.04")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 6 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE02.07.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 7 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE02.09.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 9 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE02.13.03")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 13 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE02.14.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 14 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE02.16.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 16 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.02.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 2 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.02.03")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 2 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.05.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 5 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.05.03")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 5 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.06.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 6 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.12.03")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 12 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.13.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 13 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.14.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 14 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.15.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 15 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.17.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 17 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.18.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 18 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.19.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 19 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.19.03")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 19 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.20.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 20 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.21.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 21 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.22.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 22 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.23.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 23 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.27.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 27 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE03.28.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 28 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE04.03.01")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 3 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE04.05.05")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 5 + "  and SequenceNo = " + 5 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE04.05.08")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 5 + "  and SequenceNo = " + 8 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE05.09.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 9 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.01.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 1 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.02.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 2 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.15.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 15 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.15.03")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 15 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.15.04")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 15 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.23.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 23 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.25.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 25 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.27.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 27 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.28.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 28 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.29.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 29 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.31.04")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 31 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.32.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 32 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.32.03")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 32 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.39.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 39 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.41.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 41 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE07.41.03")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 41 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE09.04.03")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 4 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE09.05.03")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 5 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE09.06.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 6 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE09.07.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 7 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE09.07.03")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 7 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE09.09.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 9 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE09.10.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 10 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE09.12.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 12 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE09.22.07")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 22 + "  and SequenceNo = " + 7 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE09.24.01")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 24 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE09.35.05")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 35 + "  and SequenceNo = " + 5 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE09.40.03")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 40 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE09.40.04")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 40 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE09.45.03")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 45 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE09.46.03")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 46 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (TE == "TE10.03.02")
				{
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + txtBox_TEs_OpTest_Assessment.Text + "'  WHERE VendorTester = 'TE' and Section = " + 10 + " and Requirement = " + 3 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}

				connection.Close();
			}
		}

		private void btn_POST_Click(object sender, EventArgs e)
		{
			PwrOnSelfTests f1 = new PwrOnSelfTests();
			f1.ShowDialog();
		}

		private void btn_CondSelftest_Click(object sender, EventArgs e)
		{
			CondSelfTests f1 = new CondSelfTests();
			f1.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			OtherSelfTests f1 = new OtherSelfTests();
			f1.ShowDialog();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{					

			if (txtFilePath != null)
			{
				StreamWriter file = new StreamWriter(txtFilePath, true);
				file.WriteLine(txtBox_TestNotes.Text);
				file.Close();
			}
			else
			{
				string m1 = "Please choose a file to write to.";
				MessageBox.Show(m1);
			}			
		}

		private void btn_browsetxtFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDlg = new OpenFileDialog();

			if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				txtFilePath = openFileDlg.FileName;
			}
			else
			{
				txtFilePath = null;
			}
		}
	}
}