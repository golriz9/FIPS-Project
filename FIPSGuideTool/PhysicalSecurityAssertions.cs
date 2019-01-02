using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FIPSGuideTool
{
	public class PhysicalSecurityAssertions
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command               = new OleDbCommand();

		public static string MaintenanceRole;
		public static string ContainsHoleSlit;
		public static string ContainsDoorCover;
		public static string ContainsCoating;
		public static string ContainsEnclosure;

		string PhySecLevel           = ModuleSpecs.PhysicalSecurityLevel;
		string Embodiment            = PhysicalSecurity.Embodiment;
		string MaintenanceRole_SC    = Properties.Settings.Default.MaintenanceRole_SC.ToString();
		string MaintenanceRole_MCE   = Properties.Settings.Default.MaintenanceRole_MCE.ToString();
		string MaintenanceRole_MCS   = Properties.Settings.Default.MaintenanceRole_MCS.ToString();
		string ContainsHoleSlit_SC   = Properties.Settings.Default.ContainsHoleSlit_SC.ToString();
		string ContainsHoleSlit_MCE  = Properties.Settings.Default.ContainsHoleSlit_MCE.ToString();
		string ContainsHoleSlit_MCS  = Properties.Settings.Default.ContainsHoleSlit_MCS.ToString();
		string ContainsCoating_SC    = PhysicalSecurity.ContainsCoating_SC;
		string ContainsCoating_MCE   = PhysicalSecurity.ContainsCoating_MCE;
		string ContainsCoating_MCS   = PhysicalSecurity.ContainsCoating_MCS;
		string enclosureAS0529       = PhysicalSecurity.enclosureAS0529;
		string enclosureAS0537       = PhysicalSecurity.enclosureAS0537;
		string enclosureAS0553       = PhysicalSecurity.enclosureAS0553;
		string CoatingType           = PhysicalSecurity.CoatingType;
		string ContainsDoorCover_SC  = PhysicalSecurity.ContainsDoorCover_SC;
		string ContainsDoorCover_MCE = PhysicalSecurity.ContainsDoorCover_MCE;
		string ContainsDoorCover_MCS = PhysicalSecurity.ContainsDoorCover_MCS;
		string keyTE053703           = PhysicalSecurity.keyTE053703;
		string tapeTE053703          = PhysicalSecurity.tapeTE053703;
		string keyTE0553             = PhysicalSecurity.keyTE0553;
		string tapeTE0553            = PhysicalSecurity.tapeTE0553;

		public PhysicalSecurityAssertions()
		{
			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
			connection.Open();

			command.Connection = connection;
			connection.Close();

			// Maintenance role
			if (Embodiment == "Single Chip")
			{
				MaintenanceRole = MaintenanceRole_SC;
			}
			else if (Embodiment == "Multi-Chip Embedded")
			{
				MaintenanceRole = MaintenanceRole_MCE;
			}
			else if (Embodiment == "Multi-Chip Standalone")
			{
				MaintenanceRole = MaintenanceRole_MCS;
			}

			// Contains Holes Slit
			if (Embodiment == "Single Chip")
			{
				ContainsHoleSlit = ContainsHoleSlit_SC;
			}
			else if (Embodiment == "Multi-Chip Embedded")
			{
				ContainsHoleSlit = ContainsHoleSlit_MCE;
			}
			else if (Embodiment == "Multi-Chip Standalone")
			{
				ContainsHoleSlit = ContainsHoleSlit_MCS;
			}

			// Contains Coating
			if (Embodiment == "Single Chip")
			{
				ContainsCoating = ContainsCoating_SC;
			}
			else if (Embodiment == "Multi-Chip Embedded")
			{
				ContainsCoating = ContainsCoating_MCE;
			}
			else if (Embodiment == "Multi-Chip Standalone")
			{
				ContainsCoating = ContainsCoating_MCS;
			}

			// Contains Door Cover
			if (Embodiment == "Single Chip")
			{
				ContainsDoorCover = ContainsDoorCover_SC;
			}
			else if (Embodiment == "Multi-Chip Embedded")
			{
				ContainsDoorCover = ContainsDoorCover_MCE;
			}
			else if (Embodiment == "Multi-Chip Standalone")
			{
				ContainsDoorCover = ContainsDoorCover_MCS;
			}

			// Contains Enclosure
			if (Embodiment == "Single Chip")
			{
				ContainsEnclosure = enclosureAS0529;
			}
			else if (Embodiment == "Multi-Chip Embedded")
			{
				ContainsEnclosure = enclosureAS0537;
			}
			else if (Embodiment == "Multi-Chip Standalone")
			{
				ContainsEnclosure = enclosureAS0553;
			}
		}

		public void populatePhySecLevel1()
		{
			// start writing assertions for Level 1
			try
			{
				connection.Open();				
				command.Connection = connection;

				string AS0511 = "This assertion is not separately tested.";

				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0511 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 11 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();


				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populatePhySecLevels1234()
		{
			// start writing assertions for Level 1,2,3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				string TE050101 = "During operational and physical security testing of the module it was confirmed that the module''s secret key(s) or other CSPs could not be accessed or circumvented. Ref: Physical Security Report";
				string TE050102 = "During operational and physical security testing of the module it was confirmed that attempts to execute other processes while cryptographic functions were operating and were unsuccessful. Ref: Physical Security Report";
				string TE050103 = "During operational and physical security testing of the module it was confirmed that attempts to perform unauthorized accesses and unauthorized modifications to software and firmware source and executable code were unsuccessful.";
				string AS0502   = "This assertion is not separately tested.";
				string TE050401 = "The tester verified that the vendor identified the cryptographic module as a " + Embodiment + "embodiment as defined in Section 4.5 of FIPS 140‐ 2. The tester made an independent determination" +
					" that the physical embodiment satisfies the vendor defined embodiment. Ref: Physical Security Report";
				string TE050402 = "It was verified that the vendor documentation states that the module is intended to meet all requirements for FIPS 140-2 Security " + PhySecLevel + ". Independent analysis and testing determined" +
					" that the module satisfies all the necessary physical security requirements for a FIPS 140-2 " + Embodiment + "device. The results of the physical security testing and documentation review concurred is consistent" +
					" with the vendor's statements. Ref: Physical Security Report";
				string TE050501 = " ";  // needs modification (physical security mechanisms)


				string TE051201 = "The module contains standard integrated circuits with a uniform exterior material and standard connectors. The module is commercial grade in regards to power and voltage ranges, temperature, " +
					"reliability, and shock and vibration resistant. Ref: Physical Security Report ";
				string TE051202 = "The tester verified from vendor documentation that the module has a standard passivation applied to it to protect it against environmental or other physical damage. Ref: Physical Security Report";
				string AS0513   = "This assertion is tested as part of AS05.09.";

				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE050101 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 1 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE050102 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 1 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE050103 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 1 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0502   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 2 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0502   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 3 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE051201 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 12 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE051202 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 12 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0513   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 13 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0502   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 14 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();


				
		
	
				if (MaintenanceRole == "Checked")
				{
					string TE050601 = "It was verified that the vendor documentation describes the maintenance access interface.";  // needs modification
					string TE050602 = "It was verified that the vendor documentation and implementation are consistent.";  // needs modification
					string TE050701 = " ";  // needs modification
					string AS0508   = "This assertion is tested as part of AS05.07.";
					string TE050901 = "";   // needs modification
					string TE050902 = "";   // needs modification
					string TE051001 = "";   // needs modification

					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE050601 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 6 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE050602 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 6 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE050701 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 7 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0508 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 8 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE050901 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 9 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE050902 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 9 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE051001 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 10 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();

				}
				else
				{
					string TE050601 = "N/A";  
					string TE050602 = "N/A";
					string TE050701 = "N/A";  
					string AS0508   = "N/A";
					string TE050901 = "N/A";   
					string TE050902 = "N/A";   
					string TE051001 = "N/A";

					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 6 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 6 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 6 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 7 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 7 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 8 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 9 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 9 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 9 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 10 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 10 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 13 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();


					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE050601 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 6 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE050602 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 6 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE050701 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 7 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0508   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 8 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE050901 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 9 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE050902 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 9 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE051001 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 10 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}


				if (Embodiment == "Single chip")
				{
						
				}
				else if (Embodiment == "Multi-chip embedded")
				{
					string AS0533   = "This assertion is not separately tested.";
					string TE053401 = "It was verified by inspection and from vendor documentation that the module is contained within an enclosure or removable cover that is of production grade.";					

					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0533   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 33 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + null + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 34 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053401 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 34 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();


				}
				else if (Embodiment == "Multi-chip standalone")
				{
					string AS0546 = "This assertion is not separately tested.";
					


					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0546 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 46 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();


					if (ContainsCoating_MCE == "True" && enclosureAS0537 == "False")
					{
						string TE054701 = "N/A";

						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE054701 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 47 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
					}

					else if (ContainsCoating_MCE == "False" && enclosureAS0537 == "True")
					{
						string TE054701 = "The tester verified by inspection and from vendor documentation that the module is contained within an enclosure that meets the following requirements: 1.The enclosure" +
							" completely surrounds the entire module. 2.The enclosure material composition is defined in the vendor documentation. 3.The enclosure is production grade, and a commercial product.";

						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE054701 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 47 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();


					}
					else
					{
						string TE054701 = "N/A";

						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE054701 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 47 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
					}

				}

				command.ExecuteNonQuery();
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populatePhySecLevels234()
		{
			// start writing assertions for Levels 2, 3, 4
			try
			{
				connection.Open();
				command.Connection = connection;

				string AS0515 = "This assertion is not separately tested.";
				
				if (Embodiment == "Single chip")
				{
					string AS0516   = "This assertion is tested as part of AS05.25.";
					string AS0524   = "This assertion is not separately tested.";
					string AS0525   = "This requirement is associated with AS05.16.";
					string TE052501 = "It was verified by inspection and from vendor documentation that the module is covered with a tamper-evident coating.The inspection shall verify that the tamper-evident" +
						" coating completely covers the module and deters direct observation, probing, or manipulation of the single-chip.";
					string TE052601 = "It was verified by inspection and from vendor documentation that the single-chip module is covered by an opaque coating within the visible spectrum.";


					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0516   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 16 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0524   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 24 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0525   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 25 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052501 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 25 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052601 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 26 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (Embodiment == "Multi-chip embedded")
				{
					string AS0516 = "This assertion is tested as part of AS05.36 and AS05.37.";
					string AS0535 = "This assertion is not separately tested.";



					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0516 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 16 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0535 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 35 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();

		
					if (ContainsCoating_MCE == "True" && enclosureAS0537 == "False")
					{						
						string TE053601 = "The tester verified by inspection and from vendor documentation that the module is encapsulated with an opaque, tamper-evident material.The inspection verified that" +
							" the tamper-evident material completely covers the module and is visibly opaque.";
						string TE053602 = "The tester verified by testing that the module provides evidence of attempts to tamper with or remove module components.";
						string AS0537   = "AS05.36 is satisfied.";


						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053601 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 36 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053602 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 36 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0537   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 37 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0537   + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 37 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0537   + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 37 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0537   + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 37 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
					}

					else if (ContainsCoating_MCE == "False" && enclosureAS0537 == "True")
					{
						string AS0536 = "AS05.37 is satisfied.";
						string TE053701 = "The tester verified by inspection and from vendor documentation that the module is contained within an enclosure that meets the following requirements: 1.The enclosure" +
							" completely surrounds the entire module. 2.The enclosure material composition is defined in the vendor documentation. 3.The vendor literature shows that the enclosure is production grade and commercial product."; 
						string TE053702 = "The tester verified by inspection that the enclosure is opaque within the visible spectrum.";
						


						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0536   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 36 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0536   + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 36 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0536   + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 36 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053701 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 37 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053702 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 37 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
												
						if (ContainsDoorCover == "Checked")
						{
							if (keyTE053703 == "True")
							{
								string TE053703 = "The tester determined that the enclosure contains removable covers or doors and each cover or door is locked with a pick-resistant lock that requires a physical" +
									" key or a logical key. The tester attempted to open the locked cover or door without use of the key and determined that the cover or door will not open without signs of damage;";

								command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053703 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 37 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
								command.ExecuteNonQuery();
							}
							else if (tapeTE053703 == "True")
							{
								string TE053703 = "The tester determined that the enclosure contains removable covers or doors and each cover and door is protected with a seal such as evidence tape or a " +
									"holographic seal.The tester verified that the cover or door cannot be opened without breaking or removing the seal, and that the seal cannot be removed and later replaced.";

								command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053703 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 37 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
								command.ExecuteNonQuery();
							}

						}
						else
						{
							string TE053703 = "N/A";

							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053703 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 37 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
						}

					}


				}
				else if (Embodiment == "Multi-chip standalone")
				{
					string AS0516   = "This assertion is tested as part of AS05.50.";
					string AS0548   = "This assertion is not separately tested.";
					string TE054901 = "The tester verified by inspection that the enclosure is opaque within the visible spectrum.";


					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0516   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 16 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0548   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 48 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE054901 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 49 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();

					if (ContainsDoorCover == "Checked")
					{
						string TE055001 = "";  // needs modification
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055001 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 50 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
					}
					else
					{
						string TE055001 = "N/A";  // needs modification
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055001 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 50 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
					}
				}

				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0515 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 15 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populatePhySecLevels34()
		{
			// start writing assertions for Levels 3 and 4
			try
			{
				connection.Open();
				command.Connection = connection;

				string AS0517 = "This assertion is not separately tested.";
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0517 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 17 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();


				if (Embodiment == "Single chip")
				{
					string AS0518   = "This assertion is tested as part of AS05.29.";
					string AS0527   = "This assertion is not separately tested.";
				
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0518   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 18 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0518   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 19 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0518   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 20 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0527   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 27 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
										

					if (ContainsCoating == "True" && enclosureAS0529 == "False")
					{
						string TE052801 = "It was verified by inspection and from vendor documentation that the module is covered with a hard opaque tamper evident coating. The type of coating is " + CoatingType + ".";  // type of coating and its characteristics 
						string TE052802 = "It was verified that the coating cannot be easily penetrated to the depth of the underlying circuitry, and that it leaves tamper evidence.It was verfied that the coating" +
							" completely covers the module, is visibly opaque, and deters direct observation, probing, or manipulation.";
						string TE052901 = "AS05.29 is satisfied."; 

						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052801 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 28 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052802 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 28 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052901 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052901 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052901 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052901 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052901 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 5 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052901 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 6 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
					}
					else if (ContainsCoating == "False" && enclosureAS0529 == "True")
					{

						string TE052801 = "AS05.28 is satisfied.";								
						string TE052903 = "The tester verified by inspection and from vendor documentation that the tamper response and zeroization circuitry remains operational when plaintext secret and private keys and CSPs are contained within the module.";
						string TE052904 = "The tester verified by inspection and from vendor documentation that the enclosure cannot be removed or penetrated without having a high probability of causing serious damage to the module.";
						
						string TE052906 = "The tester tested that the enclosure cannot be removed or penetrated without having a high probability of causing serious damage to the module.";


						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052801 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 28 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052801 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 28 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052903 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052904 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();

						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052906 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 6 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();


						if (MaintenanceRole == "Checked" && ContainsDoorCover != "Checked")
						{
							string TE052901 = "The vendor documentation specified that the module has a maintenance access interface, and therefore the module contains tamper response and zeroization circuitry.";
							string TE052902 = "Since the enclosure has a maintenance access interface, the tester verified from vendor documentation that the module zeroizes all plaintext secret and private keys, and CSPs when the maintenance access interface is accessed.";
							string TE052905 = "The enclosure has a maintenance access interface, therefore the tester tested that the module zeroizes all plaintext secret and private keys, and CSPs when the maintenance access interface is accessed.";

							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052901 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052902 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052905 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 5 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();

						}
						else if (MaintenanceRole != "Checked" && ContainsDoorCover == "Checked")
						{
							string TE052901 = "The vendor documentation specified that the module contains doors or removable covers, and therefore the module contains tamper response and zeroization circuitry.";
							string TE052902 = "Since the enclosure has removable covers or doors, the tester verified from vendor documentation that the module zeroizes all plaintext secret and private keys, and CSPs when a cover or door is removed.";
							string TE052905 = "The enclosure has removable covers or doors, therefore the tester tested that the module zeroizes all plaintext secret and private keys, and CSPs when a cover or door is removed.";

							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052901 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052902 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052905 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 5 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();

						}
						else if (MaintenanceRole == "Checked" && ContainsDoorCover == "Checked")
						{
							string TE052901 = "The vendor documentation specified that the module contains doors or removable covers and has a maintenance access interface, and therefore the module contains tamper response and zeroization circuitry.";
							string TE052902 = "The enclosure has removable covers or doors, and a maintenance access interface. Therefore, the tester verified from vendor documentation that the module zeroizes all " +
								"plaintext secret and private keys, and CSPs when a cover or door is removed or if the maintenance access interface is accessed.";
							string TE052905 = "The enclosure has removable covers or doors, and a maintenance access interface, therefore the tester tested that the module zeroizes all plaintext secret and private keys," +
								" and CSPs when a cover or door is removed or if the maintenance access interface is accessed.";

							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052901 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052902 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052905 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 5 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
						}	
						else
						{
							string TE052901 = "N/A";

							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052901 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052901 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052901 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 29 + "  and SequenceNo = " + 5 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
						}
					}

				}
				else if (Embodiment == "Multi-chip embedded")
				{
					string AS0518   = "This assertion is tested as part of AS05.53.";
					string AS0519   = "This assertion is tested as part of AS05.39.";
					string AS0538   = "This assertion is not separately tested.";
					string TE053904 = "The tester verified by inspection and from vendor documentation that the tamper response and zeroization circuitry remains operational when plaintext secret and private keys and CSPs are contained within the module.";
					string TE053905 = "The tester verified by inspection and from vendor documentation that the enclosure cannot be removed or penetrated without having a high probability of causing serious damage to the module.";


					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0518 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 18 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0519 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 19 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0519 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 20 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0538 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 38 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053904 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053905 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();

				
					

					if (ContainsCoating_MCE == "False" && enclosureAS0537 == "True") 
					{

						string TE053903 = ""; // needs modification
						string TE053906 = "N/A";
						string TE053907 = "The tester determined the strength of the enclosure by attempting to access the underlying circuitry and verifying that the enclosure is not easily breached.The tester verified by" +
							" inspection and from vendor documentation that the enclosure cannot be removed.";
						string TE053910 = "The tester tested that the enclosure cannot be removed or penetrated without having a high probability of causing serious damage to the module.";

						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053903 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053906 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 6 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053907 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 7 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053910 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 10 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();


						if (MaintenanceRole == "Checked" || ContainsDoorCover == "Checked")
						{
							if (MaintenanceRole == "Checked")
							{
								string TE053901 = "The vendor documentation specified that the module has a maintenance access interface, and it contains tamper response and zeroization circuitry.";
								string TE053908 = "N/A";
								string TE053909 = "The tester tested that the module zeroizes all plaintext secret and private keys and CSPs when the maintenance access interface is accessed.";

								command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053901 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
								command.ExecuteNonQuery();
								command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053908 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 8 + " and SubSeq = " + 0 + " ";
								command.ExecuteNonQuery();
								command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053909 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 9 + " and SubSeq = " + 0 + " ";
								command.ExecuteNonQuery();

							}
							else if (ContainsDoorCover == "Checked")
							{
								string TE053901 = "The vendor documentation specified that the module contains doors or removable covers, and it contains tamper response and zeroization circuitry.";
								string TE053908 = "The tester verified from vendor documentation that the module zeroizes all plaintext secret and private keys and CSPs when a cover or door is removed.";
								string TE053909 = "The tester tested that the module zeroizes all plaintext secret and private keys and CSPs when a cover or door is removed.";

								command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053901 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
								command.ExecuteNonQuery();
								command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053908 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 8 + " and SubSeq = " + 0 + " ";
								command.ExecuteNonQuery();
								command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053909 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 9 + " and SubSeq = " + 0 + " ";
								command.ExecuteNonQuery();
							}

							string TE053902 = "The tester verified from vendor documentation that the module zeroizes all plaintext secret and private keys, and CSPs when a cover or door is removed or if the maintenance access interface is accessed.";

							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053902 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
						}




					}
					else if (ContainsCoating_MCE == "True" && enclosureAS0537 == "False") 
					{

						string TE053903 = ""; // needs modification
						string TE053906 = "The tester verified by inspection and from vendor documentation that the module is covered with a hard opaque material. The documentation specified the material that is used.The tester" +
							" verified that it cannot be easily penetrated to the depth of the underlying circuitry.The tester verified that the material completely covers the module and is visibly opaque within the visible spectrum.";  // needs coating material
						string TE053907 = "N/A";
			

						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053903 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053906 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 6 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053907 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 7 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053907 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 10 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053907 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053907 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053907 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 8 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053907 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 39 + "  and SequenceNo = " + 9 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						

					}

				}
				else if (Embodiment == "Multi-chip standalone")
				{
					string AS0518 = "This assertion is tested as part of AS05.53.";
					string AS0551 = "This assertion is not separately tested.";
					

					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0518 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 18 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0518 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 19 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0518 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 20 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0551 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 51 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();

					if (ContainsCoating_MCE == "True" && enclosureAS0537 == "False")
					{

						string TE055201 = "The tester verified that the vendor documentation specifies that the cryptographic module is covered with a hard potting material that is opaque within the visible spectrum.";
						string TE055202 = "The tester verified that the module is encapsulated within a hard, opaque potting material. The tester verified from vendor documentation and by inspection that the circuitry within" +
							" the module is covered with a hard opaque potting material.The documentation specified which potting material is used and its hardness characteristics.";  // potting material
						string TE055203 = "The tester verified that the cover cannot be easily penetrated to the depth of the underlying circuitry.If access is possible, the tester verified that the potting material covers the circuitry within the module and is opaque in the visible spectrum.";
						string TE055301 = "AS05.53 is satisfied.";

						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055201 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 52 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055202 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 52 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055203 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 52 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055301 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055301 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055301 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055301 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055301 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 5 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055301 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 6 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055301 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 7 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055301 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 8 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055301 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 9 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();

					}
					else if (ContainsCoating_MCE == "False" && enclosureAS0537 == "True")
					{

						string TE055201 = "N/A";
						string TE055202 = "AS05.52 is satisfied.";  						
						string TE055303 = "The tester verified that the vendor documentation specified that the module is contained within a strong enclosure such that attempts at removal or penetration will have a high probability of causing serious damage to the module.";
						string TE055304 = "The tester verified by inspection and from vendor documentation that the tamper response and zeroization circuitry remains operational when plaintext secret and private keys and CSPs are contained within the module.";
						string TE055305 = "The tester verified by inspection and from vendor documentation that the enclosure cannot be removed or penetrated without having a high probability of causing serious damage to the module.";
						string TE055306 = "The tester determined the strength of the enclosure by attempting to access the underlying circuitry and verifying that the enclosure is not easily breached.The tester verified by " +
							"inspection and from vendor documentation that the enclosure cannot be removed.";						
						string TE055309 = "The tester tested that the enclosure cannot be removed or penetrated without having a high probability of causing serious damage to the module.";


						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055201 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 52 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055202 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 52 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055202 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 52 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();						
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055303 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055304 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055305 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 5 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055306 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 6 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();
						command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055309 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 9 + " and SubSeq = " + 0 + " ";
						command.ExecuteNonQuery();


						if (MaintenanceRole == "Checked") 
						{
							string TE055301 = "The vendor documentation specified that the module contains tamper response and zeroization circuitry.";
							string TE055302 = "The tester verified from vendor documentation that the module zeroizes all plaintext secret and private keys and CSPs when the maintenance access interface is accessed.";
							string TE055308 = "The tester tested that the module zeroizes all plaintext secret and private keys and CSPs when the maintenance access interface is accessed.";


							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055301 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055302 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055308 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 8 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();

						}
						else if (ContainsDoorCover == "Checked")
						{
							string TE055301 = "The vendor documentation specified that the module contains tamper response and zeroization circuitry.";
							string TE055302 = "The tester verified from vendor documentation that the module zeroizes all plaintext secret and private keys and CSPs when a cover or door is removed.";
							string TE055307 = "The tester verified from vendor documentation that the module zeroizes all plaintext secret and private keys and CSPs when a cover or door is removed.";
							string TE055308 = "The tester tested that the module zeroizes all plaintext secret and private keys and CSPs when a cover or door is removed.";


							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055301 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055302 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055307 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 7 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055308 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 53 + "  and SequenceNo = " + 8 + " and SubSeq = " + 0 + " ";
							command.ExecuteNonQuery();
						}

					}
				}



				if (ContainsHoleSlit == "Checked")  // needs to ckeck the if else 
				{
					string TE052101 = "It was verified by inspection and from vendor documentation that the module has a cover or enclosure with ventilation holes, slits, or other openings, and they are constructed to deter undetected probing inside the cover or enclosure.";
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052101 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 21 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else
				{
					string TE052101 = "N/A";
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE052101 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 21 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
								
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}

		public void populatePhySecLevels4()
		{
			// start writing assertions for Level 4 single chip
			try
			{
				connection.Open();
				command.Connection = connection;

				string AS0522 = "This assertion is not separately tested.";
				string AS0523 = "This assertion is tested as part of AS05.60 – AS05.69.";
				string AS0560 = "";



				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0522 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 22 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0523 + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 23 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();

				if (Embodiment == "Single chip")
				{
					string AS0530   = "This assertion is not separately tested.";
					string TE053101 = "It was verified by inspection and from vendor documentation that the module is covered with a hard, opaque removal-resistant coating.The documentation shall specify the coating used and provide data on its hardness and removal resistance.";
					string TE053102 = "The removal-resistant properties of the module coating was verified. Attempts to peel or pry the material from the module were made, and it was verified that it is not possible to reach the" +
						" underlying circuitry with a reasonable application of force. As a result of peeling or prying the module ceased to function, and the module circuitry was physically destroyed.";
					string TE053201 = "The vendor documentation includes explanation about the solvency properties of the modules removal-resistant coating.";  // needs modification
					string TE053202 = "The tester tested the solvency properties of the modules removal-resistant coating. The tester, based on documentation provided in VE05.32.01, determined what type of solvent would be required to compromise the removal–resistant coating.";    // needs modification


					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0530   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 30 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053101 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 31 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053102 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 31 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053201 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 32 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE053202 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 32 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}
				else if (Embodiment == "Multi-chip embedded")
				{
					string AS0540   = "This assertion is not separately tested.";
					string TE054101 = "It was verified from vendor documentation and by inspection that the module contains a tamper detection envelope that surrounds the module components.This barrier is designed such that any" +
						" breach by means such as drilling, milling, grinding, or dissolving to access the module components can be detected by monitoring components in the module.";
					string AS0542   = "This assertion is tested as part of AS05.43 and AS05.44.";
					string AS0543   = "This assertion is tested in AS05.44.";
					string TE054401 = "The tester verified from vendor documentation that the module contains tamper response and zeroization circuitry that continuously monitors the tamper detection envelope; detects any breach" +
						" by means such as drilling, milling, grinding or dissolving any portion of the envelope; and then zeroizes all plaintext secret and private keys and other unprotected CSPs.";
					string TE054402 = "The tester breached the tamper detection envelope barrier and then verify that the module zeroizes all plaintext secret and private keys and other unprotected CSPs.";

					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0540   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 40 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE054101 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 41 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0542   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 42 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0543   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 43 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE054401 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 44 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE054402 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 44 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0542   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 45 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();

				}
				else if (Embodiment == "Multi-chip standalone")
				{
					string AS0554   = "This assertion is not separately tested.";
					string TE055501 = "The tester verified vendor documentation and by inspection that the module enclosure or potting material contains tamper detection mechanisms, which shall form a tamper detection envelope that protects the module components.";
					string AS0556   = "This assertion is tested as part of AS05.58.";
					string TE055801 = "The tester verified from vendor documentation that the module contains tamper response and zeroization circuitry that continuously monitors the tamper detection envelope; detects any breach by" +
						" means such as drilling, milling, grinding or dissolving any portion of the envelope; and then zeroizes all plaintext secret and private keys and other unprotected CSPs.";
					string TE055802 = "The tester breached the tamper detection envelope barrier and then verified that the module zeroizes all plaintext secret and private keys and other unprotected CSPs.";

					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0554   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 54 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055501 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 55 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0556   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 56 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0556   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 57 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055801 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 58 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE055802 + "'  WHERE VendorTester = 'TE' and Section = " + 5 + " and Requirement = " + 58 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0556   + "'  WHERE VendorTester = 'AS' and Section = " + 5 + " and Requirement = " + 56 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}

				
				//MessageBox.Show("Data was edited successfully");
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


	}
}
