using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FIPSGuideTool
{
	class RolesServicesAssertions
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();

		string txt_AS0302      = RolesAndServices.AS0302;
		public static string MaintenanceRole_SC   = RolesAndServices.MaintenanceRole_SC;
		public static string MaintenanceRole_MCE  = RolesAndServices.MaintenanceRole_MCE;
		public static string MaintenanceRole_MCS  = RolesAndServices.MaintenanceRole_MCS;
		public static string textBox_TE030301_txt = RolesAndServices.textBox_TE030301_txt;
		public static string textBox_TE030601_txt = RolesAndServices.textBox_TE030601_txt;
		public static string textBox_TE031101_txt = RolesAndServices.textBox_TE031101_txt;
		public static string textBox_TE031102_txt = RolesAndServices.textBox_TE031102_txt;
		public static string textBox_TE031501_txt = RolesAndServices.textBox_TE031501_txt;

		string txt_TE030601;
		string BypassCapability = RolesAndServices.BypassCapability;
		string txt_AS0318       = RolesAndServices.AS0318;
		string AuthnType        = RolesAndServices.AuthnType;
		string CtrlAccess       = RolesAndServices.CtrlAccess;
		string txt_TE032301     = RolesAndServices.TE032301;

		public RolesServicesAssertions()
		{
			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
			connection.Open();

			command.Connection = connection;
			connection.Close();
		}
			   
		public void populateRolesServicesLevel1234()
		{
			// start writing assertions for Level 1,2,3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				if (txt_AS0302 != null)
				{
					txt_AS0302 = txt_AS0302.Replace("'", "\''");
				}

				if (textBox_TE030301_txt != null)
				{
					textBox_TE030301_txt = textBox_TE030301_txt.Replace("'", "\''");
				}

				if (textBox_TE030601_txt != null)
				{
					textBox_TE030601_txt = textBox_TE030601_txt.Replace("'", "\''");
				}

				if (textBox_TE031101_txt != null)
				{
					textBox_TE031101_txt = textBox_TE031101_txt.Replace("'", "\''");
				}

				if (textBox_TE031102_txt != null)
				{
					textBox_TE031102_txt = textBox_TE031102_txt.Replace("'", "\''");
				}

				if (textBox_TE031501_txt != null)
				{
					textBox_TE031501_txt = textBox_TE031501_txt.Replace("'", "\''");
				}

				if (BypassCapability != null)
				{
					BypassCapability = BypassCapability.Replace("'", "\''");
				}

				if (txt_AS0318 != null)
				{
					txt_AS0318 = txt_AS0318.Replace("'", "\''");
				}

				if (AuthnType != null)
				{
					AuthnType = AuthnType.Replace("'", "\''");
				}

				if (CtrlAccess != null)
				{
					CtrlAccess = CtrlAccess.Replace("'", "\''");
				}

				if (txt_TE032301 != null)
				{
					txt_TE032301 = txt_TE032301.Replace("'", "\''");
				}


				string AS0301 = "This assertion is not separately tested.";
				string TE030201;
				string TE030202;
				string TE030203;				

				if (txt_AS0302 == "True")
				{
					TE030201 = "The tester reviewed the vendor documentation and verified that the method implemented by the module to enforce " +
						"separation between the roles and services performed by concurrent operators was described.";
					TE030202 = "The tester assumed the identity of two independent operators: Operator1 and Operator2. The operators were assumed different" +
						" roles. The tester verified that only the services allocated to each role were possible to be performed in that role. The tester" +
						" attempted, for each operator, to access services that were unique to the role assumed by the other operator in order to verify that" +
						" separation was maintained between the roles and services allowed in concurrent operators.";
					TE030203 = "The tester attempted to violate the concurrent operators restrictions by attempting to concurrently assume restricted roles" +
						" as independent operators and verified that the module enforced the restrictions by preventing the second operator from assuming the role.";
				}
				else
				{
					TE030201 = "N/A";
					TE030202 = TE030201;
					TE030203 = TE030201;
				}

				string TE030301 = textBox_TE030301_txt;

				string TE030401;
				string TE030501;
				string TE030502;
				string TE030503;

				if (MaintenanceRole_SC == "True" || MaintenanceRole_MCE == "True" || MaintenanceRole_MCS == "True")
				{
					TE030401 = "The tester reviewed the specifications of the module interfaces and determined a maintenance interface was specified." +
						" The tester checked the vendor documentation pertaining to the authorized roles and verified that the maintenance role was" +
						" specified by name, purpose, and allowed services.";
					TE030501 = "The tester verified that the vendor documentation specified the method by which all plaintext secret and private keys" +
						" and other unprotected CSPs were zeroized when the maintenance role was entered or exited.";
					TE030502 = "While in a non-maintenance role, the tester loaded nonzero values for all private and secret keys and other unprotected " +
						"CSPs. Upon assuming the maintenance role, the tester verified that zeroization had taken place.";
					TE030503 = "While in the maintenance role, the tester loaded nonzero values for all private and secret keys and other unprotected" +
						" CSPs and, upon exit from the maintenance role, verified that zeroization had taken place.";
					txt_TE030601 = "";
				}
				else
				{
					TE030401 = "N/A";
					TE030501 = TE030401;
					TE030502 = TE030401;
					TE030503 = TE030401;
					txt_TE030601 = TE030401;


					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 4 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 4 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 5 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 5 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 5 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 5 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}

				string TE030601 = textBox_TE030601_txt;
				string TE030602 = "The tester assumed each of the authorized roles described in the vendor documentation and verified that each of them" +
					" could be assumed.";
				string AS0307 = AS0301;
				string AS0308 = AS0301;
				string AS0309 = AS0301;
				string AS0310 = AS0301;

				//string TE031101 = "The tester checked the vendor documentation to verify that the “Show Status” service and the user callable self-test" +
				//	" initiation service were each allocated to at least one authorized role. The tester verified that these services were described" +
				//	" as specified in AS.03.14.";

				string TE031101 = textBox_TE031101_txt;
				string TE031102 = textBox_TE031102_txt;
				string TE031103 = "The tester verified that the module provided for the initiation of the running of power-up self-tests.";

				string TE031201;
				string TE031202;
				string TE031203;
				string TE031301;
				string TE031302;
				if (BypassCapability == "True" || BypassCapability == "Checked")
				{
					TE031201 = "The tester determined that the bypass capability was implemented by the module. The tester checked the vendor documentation to verify that the bypass" +
						" capability was allocated to at least one authorized role.";
					TE031202 = "The tester reviewed the finite state model and other vendor documentation to determine whether each transition into an exclusive or alternating bypass" +
						" state showed two independent internal actions that had to occur in order for the cryptographic module to transition into either exclusive or alternating bypass state.";
					TE031203 = "The tester attempted to transition to each bypass state from each state that showed such a transition, and determined that it took two internal actions" +
						" to accomplish each such transition.";
					TE031301 = "The tester reviewed the vendor documentation for the “Show Status” service and verified the bypass service indication.";
					TE031302 = "The tester transitioned to each bypass state and verified that the “Show Status” indicated the applicable bypass status.";
				}
				else
				{
					TE031201 = "N/A";
					TE031202 = TE031201;
					TE031203 = TE031201;
					TE031301 = TE031201;
					TE031302 = TE031201;


					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 12 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 12 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 12 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 12 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 13 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 13 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 13 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}

				string TE031401 = "The tester checked the vendor documentation and verified that the purpose and function of each service was described. The tester checked " +
					"that the following information was specified for each service: service inputs, corresponding service outputs, and the authorized role or roles in which" +
					" the service can be performed.";
				string TE031402 = "The tester performed the following for each role: " + Environment.NewLine +
					"1. Performed each of the specified services for the role and verified that they have been implemented as specified for that role. " + Environment.NewLine +
					"2. Entered each of the specified service inputs and observed that they resulted in the specified service outputs. " + Environment.NewLine +
					"3. Attempted to perform services that were not specified for the role and verified that they were not implemented for that role.";
				string TE031501 = textBox_TE031501_txt;
				string TE031502 = "The tester performed the following tests:" + Environment.NewLine +
					"1. Entered each of the specified service inputs and observed that they resulted in the specified service outputs. " + Environment.NewLine +
					"2. Attempted to perform services that required a role to verify that they were not implemented.";
				string TE032101 = "The tester reviewed the vendor documentation and verified that the clearing of previous authentications upon power off of the module was described.";
				string TE032102 = "The tester authenticated himself/herself to the module and assumed one or more roles, powered off the module, powered on the module, and attempted" +
					" to perform services in those roles. The module denied access to the services and required that the tester be reauthenticated.";
				string TE032301 = "The tester verified that the vendor documentation described the procedure by which the operator is authenticated upon accessing the module " +
					"for the first time." + Environment.NewLine + txt_TE032301;
				string TE032302;
				if (CtrlAccess == "Yes")
				{
					TE032302 = "The tester initiated an error on an uninitialized module and verified that the module denied access. The tester assumed the authorized role and verified" +
						" that the required authentication complied with the documented procedures. The tester attempted to assume other roles before the module was initialized and " +
						"verified that the module denied access to the roles.";
				}
				else
				{
					TE032302 = "The tester verified that access to the module before initialization was not controlled. During operational testing, the tester inputed incorrect " +
						"default authentication data and verified that access to the module was denied.";
				}

				


				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0301   + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 1 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE030201 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 2 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE030202 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 2 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE030203 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 2 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE030301 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 3 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE030401 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 4 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE030501 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 5 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE030502 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 5 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE030503 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 5 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE030601 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 6 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE030602 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 6 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0307   + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 7 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0308   + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 8 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0309   + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 9 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0310   + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 10 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031101 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 11 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031102 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 11 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031103 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 11 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031201 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 12 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031202 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 12 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031203 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 12 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031301 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 13 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031302 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 13 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031401 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 14 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031501 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 15 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031502 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 15 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE032101 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 21 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE032102 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 21 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE032301 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 23 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE032302 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 23 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0301   + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 29 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();


				
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populateRolesServicesLevel2()
		{
			// start writing assertions for Level 2
			try
			{
				connection.Open();
				command.Connection = connection;

				string TE031701 = "The tester verified that the vendor documentation specified the mechanisms used for the selection of a role or roles and the authentication " +
					"of the operator to assume a role.";
				string TE031702 = "The tester assumed each role and initiated an error during the authentication procedure. The tester observed that the module denied access to each role.";

				string TE031801;
				string TE031802;
				if (txt_AS0318 == "True" || txt_AS0318 == "Checked")
				{
					TE031801 = "The tester checked the vendor documentation and verified that the method by which an operator can change roles included the verification of " +
						"the operator to assume a new role was required.";
					TE031802 = "The tester performed the following tests:" + Environment.NewLine +
						"1. Assumed a role, attempted to change to another role that the operator was authorized to assume, and verified that the module allowed the operator to request" +
						" services assigned to the new role." + Environment.NewLine +
						"2. Assumed a role, attempted to change to another role that the operator was not authorized to assume, and verified that the module did not allow the operator to" +
						" request the services assigned only to the new role.";
				}
				else
				{
					TE031801 = "The module does not permit an operator to change roles.";
					TE031802 = TE031801;
				}
				string AS0331 = "This assertion is tested as part of AS03.17.";
				 
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031701 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 17 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031702 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 17 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031801 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 18 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031802 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 18 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0331   + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 31 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populateRolesServicesLevel234()
		{
			// start writing assertions for Level 2,3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				string AS0316 = "This assertion is not separately tested.";
				string TE032201 = "The tester reviewed the vendor documentation that described the protection of authentication data. The tester verified that the documentation described" +
					" how the data is protected against unauthorized disclosure, modification, and substitution.";
				string TE032202 = "The tester performed the following tests:" + Environment.NewLine +
					"1. Attempted to access authentication data for which the tester was not authorized to have access. The module denied access and only allowed access to encrypted " +
					"and protected forms of data." + Environment.NewLine +
					"2. Modified authentication data using any method not specified by the vendor documentation and attempted to enter the modified data. The module did not allow " +
					"the tester to be authenticated using the modified data.";
				string TE032501 = "The tester reviewed the vendor documentation and verified for each authentication method the associated false acceptance or random access rate is" +
					" less than one in 1,000,000.";
				string TE032601 = "The tester reviewed the vendor documentation and verified for each authentication method the associated probability of a successful random attempt" +
					" during a one-minute period is less than one in 100,000.";
				string TE032701 = "The tester reviewed the vendor documentation and verified that the authentication data was obscured during data entry.";
				string TE032702 = "The tester entered authentication data and verified that there was no visible display of authentication data during data entry.";
				string TE032801 = "The tester reviewed the vendor documentation and verified that the feedback mechanism does not provide information that could be used to guess " +
					"or determine the authentication data.";
				string TE032802 = "The tester entered authentication data to assume each role and ensured that the feedback mechanism did not provide useful information.";

				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0316   + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 16 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE032201 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 22 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE032202 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 22 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0316   + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 24 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE032501 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 25 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE032601 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 26 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE032701 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 27 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE032702 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 27 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE032801 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 28 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE032802 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 28 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populateRolesServicesLevel34()
		{
			// start writing assertions for Level 3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				string TE031901;
				string TE031902;
				string TE031903;
				if (AuthnType == "Identity-based authentication" || AuthnType == "Role-based authentication")
				{
					TE031901 = "The tester verified that the vendor documentation specified how the operator is uniquely identified, how that identity is authenticated, how the" +
						" operator chooses a role, and how the authorization of the operator to assume a role is performed based on the authenticated identity.";
					TE031902 = "The tester initiated an error during the authentication procedure and observed that the module did not allow the tester to proceed beyond the authentication" +
						" procedure.";
					TE031903 = "The tester successfully authenticated his/her identity to the module. When required to select one or more roles, the tester selected roles not compatible" +
						" with the authenticated identity and observed that authorization to assume the roles was denied.";
				}
				else
				{
					TE031901 = "N/A";
					TE031902 = TE031901;
					TE031903 = TE031901;
				}


				string TE032001;
				string TE032002;
				if (txt_AS0318 == "True" || txt_AS0318 == "Checked")
				{
					TE032001 = "The tester reviewed the vendor documentation and verified that the method by which an operator could change roles without re-authentication of the operator''s" +
						" identity included the verification of the authorization of the operator for a role not previously authenticated.";
					TE032002 = "The tester performed the following tests:" + Environment.NewLine +
						"1. Assumed each role, attempted to change to another role that the tester was authorized to assume, verified that the" +
						" tester''s identity did not have to be reauthenticated, and verified that the tester could access the services associated" +
						" with the new role. The tester performed services in the new role that were not associated with the previous role and verified that the tester had" +
						" assumed a different role." + Environment.NewLine +
						"2. Assumed each role, attempted to change to another role that the operator was not authorized to assume, and verified that the module denied access to" +
						" the role based on the identity of the operator.";
				}
				else
				{
					TE032001 = "The module does not permit an operator to change roles.";
					TE032002 = TE032001;
				}
				string AS0332 = "This assertion is tested as part of AS03.19.";

				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031901 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 19 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031902 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 19 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE031903 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 19 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE032001 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 20 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE032002 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 20 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0332   + "'  WHERE VendorTester = 'AS' and Section = " + 3 + " and Requirement = " + 32 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populateRolesServicesLevel1()
		{
			// start writing assertions for Level 1
			try
			{
				connection.Open();
				command.Connection = connection;

				string TE033001 = "The tester verified that the vendor provided nonproprietary security policy provided a description of the roles, either implicit or explicit, that" +
					" the operator could assume and the means to assume each role.";
				string TE033002 = "The tester invoked the method described in the non-proprietary security policy and verified that each role could either be implicitly or explicitly assumed.";


				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE033001 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 30 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE033002 + "'  WHERE VendorTester = 'TE' and Section = " + 3 + " and Requirement = " + 30 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}

		public void populateRolesServicesLevel4()
		{
			// start writing assertions for Level 4
			try
			{
				connection.Open();
				command.Connection = connection;


				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}
	}
}