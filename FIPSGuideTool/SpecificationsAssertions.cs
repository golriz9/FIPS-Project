using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FIPSGuideTool
{
	class SpecificationsAssertions
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command               = new OleDbCommand();
		string Embodiment			    = PhysicalSecurity.Embodiment;
		string TE010802_processor       = ModuleSpecs.TE010802_processor;		
		string TE010802_ROM             = ModuleSpecs.TE010802_ROM;
		string TE010802_RAM             = ModuleSpecs.TE010802_RAM;
		string TE010802_SemiCustomIC    = ModuleSpecs.TE010802_SemiCustomIC;
		string TE010802_FullCustomIC    = ModuleSpecs.TE010802_FullCustomIC;
		string TE010802_activeComp      = ModuleSpecs.TE010802_activeComp;
		string TE010802_pwr				= ModuleSpecs.TE010802_pwr;
		string TE010802_phyExtConnect	= ModuleSpecs.TE010802_phyExtConnect;
		string TE010802_NonMod_FWSW     = ModuleSpecs.TE010802_NonMod_FWSW;
		string TE010802_ModFWSW         = ModuleSpecs.TE010802_ModFWSW;
		string TE010802_otherComponents = ModuleSpecs.TE010802_otherComponents;
		string TE010803_ExComponents    = ModuleSpecs.TE010808_excld;
		string TE010803_CoolingSys      = ModuleSpecs.TE010803_CoolingSys;
		public static string TE010802_txt;
		public static string TE010808_txt;
		public static string TE010809_txt;
		public static string TE010812_txt;
		

		public SpecificationsAssertions()
		{
			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
			connection.Open();
			command.Connection = connection;
			connection.Close();
		}

		public void populateSpecLevel1234()
		{
			// start writing assertions for Level 1,2,3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				string AS0101   = "This assertion is not separately tested.";
				string AS0102   = "This assertion is tested as part of AS01.12.";
				string TE010301 = "It was verified that the vendor provided non-proprietary security policy contains a description of the Approved mode of operation.";
				string TE010302 = "The tester invoked the Approved mode of operation using the vendor provided instructions found in the nonproprietary security policy.";
				string AS0105   = "This assertion is tested as part of AS01.08.";
				string TE010601 = "The tester verified that all processors are contained in the master components list under assertion AS01.08 and in the cryptographic boundary " +
					"defined under assertion AS01.08.";
				string TE010602 = "The tester verified that, for each processor, the vendor has identified the software or firmware code modules executed by that processor, " +
					"the services performed by that processor and associated code, and the memory devices containing the executable code and data.";
				string TE010603 = "The tester verified that, for each processor, the vendor has identified any hardware with which the processor interfaces. This must include," +
					" as applicable, any hardware components that provide input, control, or status data to the processor and associated ..." +
					" software/firmware, and any hardware components that receive output, control, or status data from the processor and associated software/firmware. Such " +
					"hardware components may be within the cryptographic module, or may be user equipment outside the module such as input/output devices.";
				string TE010801 = "The tester verified that the documentation includes a master components list that includes all hardware, software, and firmware components" +
					" of the cryptographic module.";	
				
				string TE010802 = "The tester verified that the master components list includes all occurrences of the following types of components when applicable, ..." +
					" excluding only component types that are not used in the module:" + Environment.NewLine + Environment.NewLine +
					"1. Processors, including microprocessors, digital signal processors, custom processors, ..." +
					" microcontrollers, or any other types of processors: " + Environment.NewLine + TE010802_processor + Environment.NewLine + Environment.NewLine +
					"2. Read-only memory (ROM) integrated circuits for program executable code and ..." +
					" data (this may include mask-programmed ROM, programmable ROM(PROM) such as ultraviolet, erasable PROM[EPROM], electrically erasable PROM[EEPROM]," +
					" or FLASH):" + Environment.NewLine + TE010802_ROM + Environment.NewLine + Environment.NewLine +
					"3. Random-access memory (RAM) integrated circuits ..." +
					" for temporary data storage: " + Environment.NewLine + TE010802_RAM + Environment.NewLine + Environment.NewLine +
					"4. Semi-custom, application-specific integrated circuits, such as gate arrays, programmable logic ..." +
					"arrays, field programmable gate arrays, or other programmable logic devices:" + Environment.NewLine + TE010802_SemiCustomIC + 
					Environment.NewLine + Environment.NewLine +
					"5. Fully custom, application-specific, integrated circuits, including any custom cryptographic ..." +
					"integrated circuits:" + Environment.NewLine + TE010802_FullCustomIC + Environment.NewLine + Environment.NewLine +
					"6. Other active electronic circuit elements: " + Environment.NewLine + TE010802_activeComp + Environment.NewLine + Environment.NewLine +
					"7. Power supply components:" + Environment.NewLine + TE010802_pwr + Environment.NewLine + Environment.NewLine +
					"8. Circuit boards " + Environment.NewLine + Environment.NewLine + Environment.NewLine +
					"9. Enclosures " + Environment.NewLine + Environment.NewLine + Environment.NewLine +
					"10. Physical connectors for devices outside the module:" + Environment.NewLine + TE010802_phyExtConnect + Environment.NewLine + Environment.NewLine + 
					"11. Modifiable software/firmware modules: " + Environment.NewLine + TE010802_ModFWSW + Environment.NewLine + Environment.NewLine + 
					"12. Software/firmware modules that are unlikely ..." +
					"to be modified:" + Environment.NewLine + TE010802_NonMod_FWSW + Environment.NewLine + Environment.NewLine +
					"13. All other component types not listed above:" + Environment.NewLine + TE010802_otherComponents;
				TE010802_txt = TE010802;				

				string TE010802_processor1 = TE010802_processor.Replace("'", "\''");
				string TE010802_ROM1 = TE010802_ROM.Replace("'", "\''");
				string TE010802_RAM1 = TE010802_RAM.Replace("'", "\''");
				string TE010802_SemiCustomIC1 = TE010802_SemiCustomIC.Replace("'", "\''");
				string TE010802_FullCustomIC1 = TE010802_FullCustomIC.Replace("'", "\''");
				string TE010802_activeComp1 = TE010802_activeComp.Replace("'", "\''");
				string TE010802_pwr1 = TE010802_pwr.Replace("'", "\''");
				string TE010802_phyExtConnect1 = TE010802_phyExtConnect.Replace("'", "\''");
				string TE010802_NonMod_FWSW1 = TE010802_NonMod_FWSW.Replace("'", "\''");
				string TE010802_ModFWSW1 = TE010802_ModFWSW.Replace("'", "\''");
				string TE010802_otherComponents1 = TE010802_otherComponents.Replace("'", "\''");
				string TE010803_ExComponents1 = TE010803_ExComponents.Replace("'", "\''");
				string TE010803_CoolingSys1 = TE010803_CoolingSys.Replace("'", "\''");

				TE010802 = "The tester verified that the master components list includes all occurrences of the following types of components when applicable, ..." +
					" excluding only component types that are not used in the module:" + Environment.NewLine + Environment.NewLine +
					"1. Processors, including microprocessors, digital signal processors, custom processors, ..." +
					" microcontrollers, or any other types of processors: " + Environment.NewLine + TE010802_processor1 + Environment.NewLine + Environment.NewLine +
					"2. Read-only memory (ROM) integrated circuits for program executable code and ..." +
					" data (this may include mask-programmed ROM, programmable ROM(PROM) such as ultraviolet, erasable PROM[EPROM], electrically erasable PROM[EEPROM]," +
					" or FLASH):" + Environment.NewLine + TE010802_ROM1 + Environment.NewLine + Environment.NewLine +
					"3. Random-access memory (RAM) integrated circuits ..." +
					" for temporary data storage: " + Environment.NewLine + TE010802_RAM1 + Environment.NewLine + Environment.NewLine +
					"4. Semi-custom, application-specific integrated circuits, such as gate arrays, programmable logic ..." +
					"arrays, field programmable gate arrays, or other programmable logic devices:" + Environment.NewLine + TE010802_SemiCustomIC1 +
					Environment.NewLine + Environment.NewLine +
					"5. Fully custom, application-specific, integrated circuits, including any custom cryptographic ..." +
					"integrated circuits:" + Environment.NewLine + TE010802_FullCustomIC1 + Environment.NewLine + Environment.NewLine +
					"6. Other active electronic circuit elements: " + Environment.NewLine + TE010802_activeComp1 + Environment.NewLine + Environment.NewLine +
					"7. Power supply components:" + Environment.NewLine + TE010802_pwr1 + Environment.NewLine + Environment.NewLine +
					"8. Circuit boards " + Environment.NewLine + Environment.NewLine + Environment.NewLine +
					"9. Enclosures " + Environment.NewLine + Environment.NewLine + Environment.NewLine +
					"10. Physical connectors for devices outside the module:" + Environment.NewLine + TE010802_phyExtConnect1 + Environment.NewLine + Environment.NewLine +
					"11. Modifiable software/firmware modules: " + Environment.NewLine + TE010802_ModFWSW1 + Environment.NewLine + Environment.NewLine +
					"12. Software/firmware modules that are unlikely ..." +
					"to be modified:" + Environment.NewLine + TE010802_NonMod_FWSW1 + Environment.NewLine + Environment.NewLine +
					"13. All other component types not listed above:" + Environment.NewLine + TE010802_otherComponents1;


				string TE010803 = "The tester verified that the master components list is consistent with information provided for other assertions of this section, as defined below:" + Environment.NewLine + 
					"1. It was verified that all components inside the cryptographic boundary are included in the master components list, and that any components outside the cryptographic boundary are not listed as components of ..." +
					"the cryptographic module. " + Environment.NewLine + 
					"2. It was verified that the list of processors, software modules, and hardware modules in the master components list is the same as in the specifications under ..." +
					" Assertion AS01.06. " + Environment.NewLine + 
					"3. It was verified that the list of physical structures in the master components list(such as circuit boards or other mounting surfaces, enclosures, and connectors) ..." +
					" is the same as in the specifications under Assertion AS01.08. " + Environment.NewLine + 
					"4. It was verified that any individual components called out in the block diagram(e.g., processors, application-specific ..." +
					"integrated circuits) are also listed in the master components list. " + Environment.NewLine + 
					"5. It was verified that components to be so excluded are still listed in the master components list.";

				string TE010804 = "The tester verified that the documentation explicitly shows where the cryptographic boundary physical perimeter lies. The documentation showed a listing of all significant information ..." +
					" flows and processing to be performed inside the cryptographic boundary plus all information that is input and output to the exterior of the cryptographic boundary.";
				string TE010805 = "The tester verified that the vendor provided documentation included sufficient detail for components at the cryptographic boundary to precisely define the cryptographic boundary.";
				string TE010806 = "The tester verified that the cryptographic boundary is physically contiguous, such that there are no gaps that could allow uncontrolled input, output, or other access into the ..." +
					" cryptographic module.The module design also ensures there are no uncontrolled interfaces into or out of the module that could pass CSPs, plaintext data, or other information that if misused could lead to a compromise.";
				string TE010807 = "The tester verified that the cryptographic boundary encompasses all components that are identified in the block diagram under assertion AS01.13 in this section as inputting, outputting, or ..." +
					"processing CSPs, plaintext data, or other information that if misused could lead to a compromise.";

				string TE010808;
				if (TE010803_ExComponents != "N/A")
				{
					TE010808 = "The tester verified that any interfaces or physical connections between the excluded components and the rest of the module do not allow uncontrolled release of CSPs, plaintext data, or other information that if misused could lead to ..." +
						"a compromise. The excluded components are: " + Environment.NewLine + TE010803_ExComponents;
				}
				else
				{
					TE010808 = "N/A";
				}
				TE010808_txt = TE010808;

				string TE010809 = "The tester verified that the vendor identified that the cryptographic module is a " + Embodiment + "module.";
				TE010809_txt = TE010809;
				string TE010810 = "The tester verified that the vendor’s documentation shows the internal layout of the module, including the placement and approximate dimensions of major identifiable components of the module.This must include drawings that are at least approximately to scale.";
				string TE010811 = "The tester verified that the vendor’s documentation indicates the major physical assemblies of the module and how they are assembled or inserted into the module.";
							

				string TE010812;
				if (TE010803_CoolingSys != "N/A")
				{
					TE010812 = "The tester verified that the vendor’s documentation describes the primary physical parameters of the module " +
						"including:" + Environment.NewLine + "1.Enclosure shape and approximate dimensions, including any access doors or covers " + Environment.NewLine + "2.Circuit board(s) approximate" +
						" dimensions, layout, and interconnections " + Environment.NewLine + "3.Location of power supply, power converters, and power inputs and outputs " + Environment.NewLine + "4.Interconnection " +
						"wiring runs: routing and terminals " + Environment.NewLine + "5.Cooling arrangements, such as conduction plates, cooling airflow, heat exchanger, cooling fins, fans, or other arrangements " +
						"for removing heat from the module: " + TE010803_CoolingSys + Environment.NewLine + "6.Other component types not listed above. Vendor documentation describes all components contained within the module.";
				}
				else
				{
					TE010812 = "N/A";
				}
				TE010812_txt = TE010812;

				string TE010901 = TE010808;
				string TE010902 = TE010808 + "the tester determined that a rationale for the exclusion is provided. The rationale shows that even if the component malfunctions, it cannot cause a potential release of CSPs," +
					" plaintext data, or other information that if misused could lead to a compromise. The rationale includes:" + Environment.NewLine + "1.The excluded component does not process CSPs, plaintext data, or other" +
					" information that if misused could lead to a compromise " + Environment.NewLine + "2.The excluded component is not connected with security relevant components of the module that would allow inappropriate" +
					" transfer of CSPs, plaintext data, or other information that if misused could lead to a compromise " + Environment.NewLine + "3.All information processed by the excluded component is strictly for internal" +
					" use of the module, and does not in any way impact the equipment to which the module is connected";
				string AS0110   = "This assertion is tested as part of AS02.01.";
				string TE011201 = "";  // need modification
				string TE011202 = "";  // need modification
				string TE011203 = "";  // need modification
				string TE011204 = "";  // need modification
				string TE011301 = "The tester verified that the vendor has provided one or more block diagrams indicating major submodules of the cryptographic module including:" + Environment.NewLine +
					"1. Processors" + Environment.NewLine +
					"2.Input/output buffer memory" + Environment.NewLine + 
					"3.Plaintext/ciphertext buffer memory" + Environment.NewLine + 
					"4.Control buffer memory" + Environment.NewLine + 
					"5.Key storage" + Environment.NewLine +
					"6.Working memory" + Environment.NewLine + 
					"7.Program memory" + Environment.NewLine + 
					"8.Fully-custom integrated circuits: " + TE010802_FullCustomIC + Environment.NewLine + "Semi-custom integrated circuits: " + TE010802_SemiCustomIC + Environment.NewLine + 
					"9.All other components types not listed above: All significant components in the module are included in the block diagram";
				string TE011302 = "The tester verified that the block diagram indicates all significant interconnections and data flow among major components of the module, and between the module and outside equipment." +
					" In particular, each line on the block diagram indicating an interconnection must be labeled with the type of information it transmits.";
				string TE011303 = "The tester verified that the block diagram indicates the cryptographic boundary for the cryptographic module, as required under assertion AS01.08 in this section.";
				string TE011401 = "The tester compared the design specification against the list of names of all hardware, software, and firmware components as documented in VE10.07.01 to verify" +
					" that the relationship between the finite state model and the design specification can be determined.";
				string TE011501 = "The tester verified that the documentation specifies all security-related information, including secret and private cryptographic" +
					" keys(both plaintext and encrypted), authentication data(e.g., passwords, PINs), CSPs, and other protected information (e.g., audited events, " +
					"audit data) whose disclosure or modification can compromise the security of the cryptographic module.";
				string TE011601 = "The tester reviewed the nonproprietary security policy provided by the vendor. The tester determined that the nonproprietary security policy meets the requirements specified in Appendix C of FIPS PUB 140-2.";


				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0101   + "'  WHERE VendorTester = 'AS' and Section = " + 1 + " and Requirement = " + 1 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0102   + "'  WHERE VendorTester = 'AS' and Section = " + 1 + " and Requirement = " + 2 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010301 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 3 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010302 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 3 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0105   + "'  WHERE VendorTester = 'AS' and Section = " + 1 + " and Requirement = " + 5 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010601 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 6 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010602 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 6 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010603 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 6 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0101   + "'  WHERE VendorTester = 'AS' and Section = " + 1 + " and Requirement = " + 7 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010801 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 8 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010802 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 8 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010803 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 8 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010804 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 8 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010805 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 8 + "  and SequenceNo = " + 5 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010806 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 8 + "  and SequenceNo = " + 6 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010807 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 8 + "  and SequenceNo = " + 7 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010808 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 8 + "  and SequenceNo = " + 8 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010809 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 8 + "  and SequenceNo = " + 9 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010810 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 8 + "  and SequenceNo = " + 10 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010811 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 8 + "  and SequenceNo = " + 11 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010812 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 8 + "  and SequenceNo = " + 12 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010901 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 9 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010902 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 9 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0110   + "'  WHERE VendorTester = 'AS' and Section = " + 1 + " and Requirement = " + 10 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0110   + "'  WHERE VendorTester = 'AS' and Section = " + 1 + " and Requirement = " + 11 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE011201 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 12 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE011202 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 12 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE011203 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 12 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE011204 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 12 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE011301 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 13 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE011302 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 13 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE011303 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 13 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE011401 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 14 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE011501 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 15 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE011601 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 16 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();


				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populateSpecLevel34()
		{
			// start writing assertions for Level 3,4
			try
			{
				connection.Open();

				command.Connection = connection;

				string TE010401 = "The tester verified that the vendor provided nonproprietary security policy contains a description of the method used to indicate when a cryptographic module is in an Approved mode of operation.";
				string TE010402 = "The tester used the vendor provided instructions described in the non-proprietary security policy to obtain the Approved mode of operation indicator.";


				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010401 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 4 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE010402 + "'  WHERE VendorTester = 'TE' and Section = " + 1 + " and Requirement = " + 4 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
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
