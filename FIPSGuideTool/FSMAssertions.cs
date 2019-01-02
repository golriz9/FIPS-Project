using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FIPSGuideTool
{
	class FSMAssertions
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();

		//public static string Embodiment;
		public static string MaintenanceRole_SC  = RolesAndServices.MaintenanceRole_SC;
		public static string MaintenanceRole_MCE = RolesAndServices.MaintenanceRole_MCE;
		public static string MaintenanceRole_MCS = RolesAndServices.MaintenanceRole_MCS;

		string BypassCapability = RolesAndServices.BypassCapability;
		string idleState        = RolesAndServices.idleState;
		string CtrlAccess       = RolesAndServices.CtrlAccess;
		string KeyEntryOutput   = KeyManagement.KeyEntryOutput;
		string KeyGen           = KeyManagement.KeyGen;
	

		public FSMAssertions()
		{
			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
			connection.Open();

			command.Connection = connection;
			connection.Close();
		}


		public void populateFSMLevel1234()
		{
			// start writing assertions for Level 1,2,3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				string AS0401 = "This assertion is tested as part of AS04.05.";
				string TE040301 = "During operational testing, the tester verified from each error state that did not require maintenance, service, or repair, the cryptographic module could be caused to " +
					"transition to an acceptable operational or initialization state. The tester verified that the cryptographic module indicated when it was an error state, " +
					"and the module operated correctly in this state.";
				string TE040501 = "The tester verified that the vendor provided a description of the finite state model. This description contained the identification and description" +
					" of all states of the module, and a description of all corresponding state transitions. The tester verified that the descriptions of the state transitions included" +
					" the internal module conditions, data inputs and control inputs that caused transitions from one state to another, data outputs and status outputs resulting from" +
					" transitions from one state to another.";

				command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 4 + " and Requirement = " + 4 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();

				string TE040502_13;
				string TE040502_14;
				string TE040502_18;
				string TE040502_19;
				string TE040502_8;
				string TE040502_16;
				string TE040502_17;	

				if (BypassCapability == "True" || BypassCapability == "Checked") { TE040502_13 = ""; } else { TE040502_13 = "N/A"; }

				if (MaintenanceRole_SC == "Checked" || MaintenanceRole_SC == "True") { TE040502_14 = ""; } else { TE040502_14 = "N/A"; }

				if (MaintenanceRole_MCE == "Checked" || MaintenanceRole_MCE == "True") { TE040502_14 = ""; } else { TE040502_14 = "N/A"; }	
				
				if (MaintenanceRole_MCS == "Checked" || MaintenanceRole_MCS == "True") { TE040502_14 = ""; } else { TE040502_14 = "N/A"; }				

				if (idleState == "True" || idleState == "Checked") { TE040502_18 = ""; } else { TE040502_18 = "N/A"; }
	
				if (CtrlAccess == "Yes") { TE040502_19 = ""; } else { TE040502_19 = "N/A"; }

				if (KeyEntryOutput == "True") { TE040502_8 = ""; } else { TE040502_8 = "N/A"; }

				if (KeyEntryOutput == "True") { TE040502_16 = ""; } else { TE040502_16 = "N/A"; }

				if (KeyEntryOutput == "True" ) { TE040502_17 = ""; } else { TE040502_17 = "N/A"; }
		
				
				string TE040502 = "The tester verified that the finite state diagrams and the descriptions were consistent with the vendor documentation that describes the following:" + Environment.NewLine +
					"1. Data input interface" + Environment.NewLine +
					"2. Data output interface " + Environment.NewLine +
					"3. Control input interface " + Environment.NewLine +
					"4. Status output interface " + Environment.NewLine +
					"5. Crypto officer role " + Environment.NewLine +
					"6. User role " + Environment.NewLine +
					"7. Other roles " + Environment.NewLine +
					"8. Key entry services " + TE040502_8 + Environment.NewLine +
					"9. Show status service " + Environment.NewLine +
					"10. Self-tests " + Environment.NewLine +
					"11. Other authorized services, operations, and functions" + Environment.NewLine +
					"12. Error states " + Environment.NewLine +
					"13. Bypass service " + TE040502_13 + Environment.NewLine +
					"14. Maintenance interface " + TE040502_14 + Environment.NewLine +
					"15. Maintenance role " + TE040502_14 + Environment.NewLine +
					"16. Key generation services " + TE040502_16 + Environment.NewLine +
					"17. Key output services "+ TE040502_17 + Environment.NewLine +
					"18. Idle states " + TE040502_18 + Environment.NewLine +
					"19. Uninitialized states " + TE040502_19;

				string TE040503 = "The tester verified that every state that was identified in the finite state diagram(s) was also identified and described in the description.";
				string TE040504 = "The tester verified that every state that was identified and described in the description was also identified in the finite state diagram(s).";
				string TE040505 = "The tester verified that the operation of the module was consistent with the finite state diagrams and descriptions.";
				
				string TE040506;
				if (MaintenanceRole_SC == "True" || MaintenanceRole_MCE == "True" || MaintenanceRole_MCS == "True")
				{
					TE040506 = "The tester verified that the finite state model had at least one maintenance state defined. All maintenance states were contained in the finite state" +
						" diagram(s) and described in the description of the finite state model.";
				}
				else
				{
					TE040506 = "N/A";

					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 4 + " and Requirement = " + 4 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();

					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 5 + "  and SequenceNo = " + 6 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}

				string TE040507 = "The tester reviewed the descriptions of the states of the cryptographic module and determined that the descriptions clearly defined disjoint states. " +
					"The tester verified that all possible combinations of data and control inputs could be partitioned into disjoint sets.";
				string TE040508 = "The tester examined the cryptographic module, caused it to enter each of its major states. For each state that had a distinct indicator, the tester attempted" +
					" to observe the indicator while the module was in the state. The expected indicator was observed.";
				string TE040509 = "The tester verified that a chain of transitions from an initial power on state to each other state in the model existed that was not an initial power on state.";
				string TE040510 = "The tester verified that a chain of transitions from each non-power off state to a power off state of the model existed.";
				string TE040511 = "The tester verified that the actions of the finite state model, as the result of all possible data and control inputs, were defined.";

				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0401   + "'  WHERE VendorTester = 'AS' and Section = " + 4 + " and Requirement = " + 1 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0401   + "'  WHERE VendorTester = 'AS' and Section = " + 4 + " and Requirement = " + 2 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE040301 + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 3 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0401   + "'  WHERE VendorTester = 'AS' and Section = " + 4 + " and Requirement = " + 4 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE040501 + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 5 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE040502 + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 5 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE040503 + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 5 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE040504 + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 5 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE040505 + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 5 + "  and SequenceNo = " + 5 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE040506 + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 5 + "  and SequenceNo = " + 6 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE040507 + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 5 + "  and SequenceNo = " + 7 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE040508 + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 5 + "  and SequenceNo = " + 8 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE040509 + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 5 + "  and SequenceNo = " + 9 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE040510 + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 5 + "  and SequenceNo = " + 10 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE040511 + "'  WHERE VendorTester = 'TE' and Section = " + 4 + " and Requirement = " + 5 + "  and SequenceNo = " + 11 + " and SubSeq = " + 0 + " ";
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