using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FIPSGuideTool
{
	class PortsInterfacesAssertions
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();

		public static string CoverDoor;
		public static string ContainsDoorCover;
		string PhySecLevel = ModuleSpecs.PhysicalSecurityLevel;
		string Embodiment = PhysicalSecurity.Embodiment;
		string MaintenanceRole_SC  = Properties.Settings.Default.MaintenanceRole_SC.ToString();
		string MaintenanceRole_MCE = Properties.Settings.Default.MaintenanceRole_MCE.ToString();
		string MaintenanceRole_MCS = Properties.Settings.Default.MaintenanceRole_MCS.ToString();
		string ContainsHoleSlit_SC   = Properties.Settings.Default.ContainsHoleSlit_SC.ToString();
		string ContainsHoleSlit_MCE  = Properties.Settings.Default.ContainsHoleSlit_MCE.ToString();
		string ContainsHoleSlit_MCS  = Properties.Settings.Default.ContainsHoleSlit_MCS.ToString();
		string CoatingType = PhysicalSecurity.CoatingType;
		string ContainsDoorCover_SC = PhysicalSecurity.ContainsDoorCover_SC;
		string ContainsDoorCover_MCE = PhysicalSecurity.ContainsDoorCover_MCE;
		string ContainsDoorCover_MCS = PhysicalSecurity.ContainsDoorCover_MCS;
		string ContainsCoating_SC = PhysicalSecurity.ContainsCoating_SC;
		string ContainsCoating_MCE = PhysicalSecurity.ContainsCoating_MCE;
		string ContainsCoating_MCS = PhysicalSecurity.ContainsCoating_MCS;
		string enclosureAS0529 = PhysicalSecurity.enclosureAS0529;
		string enclosureAS0537 = PhysicalSecurity.enclosureAS0537;
		string enclosureAS0553 = PhysicalSecurity.enclosureAS0553;
		string DataIn = DataInputPorts.DataIn;
		string DataOut = DataOutputPorts.DataOut;
		string CtrlIn = CtrlInputPorts.CtrlIn;
		string PwrIn = PwrInputPorts.PwrIn;
		string TE020401_1 = DataInputPorts.TE020401_1;
		string TE020401_2 = DataInputPorts.TE020401_2;
		string TE020401_3 = DataInputPorts.TE020401_3;
		string TE020401_4 = DataInputPorts.TE020401_4;
		string TE020401_5 = DataInputPorts.TE020401_5;
		string ExtInputDevice = DataInputPorts.ExtInputDevice;
		string TE020501_1 = DataOutputPorts.TE020501_1;
		string TE020501_2 = DataOutputPorts.TE020501_2;
		string TE020501_3 = DataOutputPorts.TE020501_3;
		string TE020501_4 = DataOutputPorts.TE020501_4;
		string ExtOutputDevice = DataOutputPorts.ExtOutputDevice;
		string TE020701_1 = CtrlInputPorts.TE020701_1;
		string TE020701_2 = CtrlInputPorts.TE020701_2;
		string TE020701_3 = CtrlInputPorts.TE020701_3;
		string ExtCtrlDevice = CtrlInputPorts.ExtCtrlDevice;
		string StatusOut = StatusOutputPorts.StatusOut;
		string TE020801_1 = StatusOutputPorts.TE020801_1;
		string TE020801_2 = StatusOutputPorts.TE020801_2;
		string TE020801_3 = StatusOutputPorts.TE020801_3;
		string TE020901_1 = PwrInputPorts.TE020901_1;
		string TE020901_2 = PwrInputPorts.TE020901_2;
		string txt_TE021302 = PortsAndInterfaces.TE021302;
		string txt_AS0216 = PortsAndInterfaces.AS0216;
		string txt_AS0217 = PortsAndInterfaces.AS0217;

		public PortsInterfacesAssertions()
		{
			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
			connection.Open();

			command.Connection = connection;
			//command.CommandText = "UPDATE ValidationInfo SET Assessment='" + null + "' ";
			//command.ExecuteNonQuery();
			connection.Close();
		}

		public void populatePortInterfaceLevel1234()
		{
			// start writing assertions for Level 1,2,3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				CoatingType = CoatingType.Replace("'", "\''");
				DataIn = DataIn.Replace("'", "\''");
				DataOut = DataOut.Replace("'", "\''");
				CtrlIn = CtrlIn.Replace("'", "\''");
				PwrIn = PwrIn.Replace("'", "\''");
				TE020401_1 = TE020401_1.Replace("'", "\''");
				TE020401_2 = TE020401_2.Replace("'", "\''");
				TE020401_3 = TE020401_3.Replace("'", "\''");
				TE020401_4 = TE020401_4.Replace("'", "\''");
				TE020401_5 = TE020401_5.Replace("'", "\''");
				ExtInputDevice = ExtInputDevice.Replace("'", "\''");
				TE020501_1 = TE020501_1.Replace("'", "\''");
				TE020501_2 = TE020501_2.Replace("'", "\''");
				TE020501_3 = TE020501_3.Replace("'", "\''");
				TE020501_4 = TE020501_4.Replace("'", "\''");
				ExtOutputDevice = ExtOutputDevice.Replace("'", "\''");
				TE020701_1 = TE020701_1.Replace("'", "\''");
				TE020701_2 = TE020701_2.Replace("'", "\''");
				TE020701_3 = TE020701_3.Replace("'", "\''");
				ExtCtrlDevice = ExtCtrlDevice.Replace("'", "\''");
				StatusOut = StatusOut.Replace("'", "\''");
				TE020801_1 = TE020801_1.Replace("'", "\''");
				TE020801_2 = TE020801_2.Replace("'", "\''");
				TE020801_3 = TE020801_3.Replace("'", "\''");
				TE020901_1 = TE020901_1.Replace("'", "\''");
				TE020901_2 = TE020901_2.Replace("'", "\''");
				txt_TE021302 = txt_TE021302.Replace("'", "\''");
				txt_AS0216 = txt_AS0216.Replace("'", "\''");
				txt_AS0217 = txt_AS0217.Replace("'", "\''");

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

				
				if (ContainsDoorCover == "Checked")
				{
					CoverDoor = "Physical covers, doors, or openings, including their physical location within the cryptographic module, and the components or functions that can be accessed and/or modified via each cover/door/opening";
				}
				else
				{
					CoverDoor = "N/A";
				}

				string txt_TE020401_1;
				string txt_TE020401_2;
				string txt_TE020401_3;
				string txt_TE020401_4;
				string txt_TE020401_5;

				if (TE020401_1 == "False") { txt_TE020401_1 = "N/A"; } else { txt_TE020401_1 = null; }
				if (TE020401_2 == "False") { txt_TE020401_2 = "N/A"; } else { txt_TE020401_2 = null; }
				if (TE020401_3 == "False") { txt_TE020401_3 = "N/A"; } else { txt_TE020401_3 = null; }
				if (TE020401_4 == "False") { txt_TE020401_4 = "N/A"; } else { txt_TE020401_4 = null; }
				if (TE020401_5 == "False") { txt_TE020401_5 = "N/A"; } else { txt_TE020401_5 = null; }


				string txt_TE020501_1;
				string txt_TE020501_2;
				string txt_TE020501_3;
				string txt_TE020501_4;

				if (TE020501_1 == "False") { txt_TE020501_1 = "N/A"; } else { txt_TE020501_1 = null; }
				if (TE020501_2 == "False") { txt_TE020501_2 = "N/A"; } else { txt_TE020501_2 = null; }
				if (TE020501_3 == "False") { txt_TE020501_3 = "N/A"; } else { txt_TE020501_3 = null; }
				if (TE020501_4 == "False") { txt_TE020501_4 = "N/A"; } else { txt_TE020501_4 = null; }


				string txt_TE020701_1;
				string txt_TE020701_2;
				string txt_TE020701_3;

				if (TE020701_1 == "False") { txt_TE020701_1 = "N/A"; } else { txt_TE020701_1 = null; }
				if (TE020701_2 == "False") { txt_TE020701_2 = "N/A"; } else { txt_TE020701_2 = null; }
				if (TE020701_3 == "False") { txt_TE020701_3 = "N/A"; } else { txt_TE020701_3 = null; }


				string txt_TE020801_1;
				string txt_TE020801_2;
				string txt_TE020801_3;

				if (TE020801_1 == "False") { txt_TE020801_1 = "N/A"; } else { txt_TE020801_1 = null; }
				if (TE020801_2 == "False") { txt_TE020801_2 = "N/A"; } else { txt_TE020801_2 = null; }
				if (TE020801_3 == "False") { txt_TE020801_3 = "N/A"; } else { txt_TE020801_3 = null; }


				string TE020101 = "The tester verified that vendor documentation specifies each of the physical ports and logical interfaces of the cryptographic " +
					"module including:" + Environment.NewLine + "1. Physical input and output ports:" + Environment.NewLine + "Input ports: " + DataIn + Environment.NewLine + "Output ports: " + DataOut + Environment.NewLine +
					"2. Physical covers, doors, or openings:" + Environment.NewLine + CoverDoor + Environment.NewLine + "3. Logical input and output interfaces:" + Environment.NewLine + "Input ports: " + DataIn + Environment.NewLine + "Output ports: " + DataOut + Environment.NewLine +
					"4. Manual controls:" + Environment.NewLine + CtrlIn + Environment.NewLine + "5. Physical status indicators:" + Environment.NewLine + StatusOut + Environment.NewLine + "6. A mapping of the logical input and output interfaces to the physical input and output ports, " +
					"Manual controls, and physical status indicators of the cryptographic module " + Environment.NewLine + "7. Physical, logical, and electrical characteristics";
				string TE020102 = "The tester verified that vendor documentation specifies all information flows and physical access points of the cryptographic module, by examining the block" +
					" diagrams, design specifications and/or source code and schematics provided in Sections 1 and 10, and any other documentation provided by the vendor.The documentation specified" +
					" the relationship of the information flows and physical access points to the physical ports and logical interfaces of the cryptographic module.The tester compared the above" +
					" information with the information provided under assertions AS01.08, AS01.10, and AS01.13 and verified that there are no inconsistencies in the description of components" +
					" and physical layout for the input/output ports.";
				string TE020103 = "The tester verified that for each physical or logical input to the cryptographic module, or physical and logical output from the module, vendor documentation specified" +
					" the logical interface to which the physical input or output belongs, and the physical entry/exit port.The specifications provided were consistent with the specifications of the " +
					"cryptographic module components provided under sections 1 and 10, and the specifications of the logical interfaces provided in assertions AS02.03 to AS02.09.";
				string TE020104 = "The tester verified, by inspection of the cryptographic module, that all the above specifications provided by vendor documentation are consistent with the actual design of the cryptographic module.";
				string TE020201 = "The tester verified, from vendor documentation and by inspection of the cryptographic module, that the module interfaces are logically distinct and isolated.";
				string TE020202 = "The tester verified that vendor documentation provides a mapping of each category of logical interface to a physical port of the cryptographic module. If two or more interfaces shared" +
					" the same physical port, the tester verified that vendor documentation specified how the information flows for the input, output, control, and status interfaces are kept logically separate.";
				string TE020301 = "The tester verified that vendor documentation specifies that the four logical interfaces have been designed within the cryptographic module. It was verified that the logical interfaces" +
					" within the cryptographic module function as specified in AS02.04, AS02.05, AS02.07, and AS02.08.";
				string TE020401 = "The tester verified, by inspection, that the cryptographic module includes a data input interface, and that the data input interface functions as specified.The tester verified that" +
					" all data(except control data entered via the control input interface) that is to be input to and processed by the cryptographic module entered via the data input interface, including:" + Environment.NewLine +
					"1. Plaintext data that is to be encrypted or signed by the cryptographic module. " + txt_TE020401_1 + Environment.NewLine +
					"2.Ciphertext or signed data that is to be decrypted or verified by the module. " + txt_TE020401_2 + Environment.NewLine +
					"3.Plaintext or encrypted cryptographic keys and other key management data that are input into and used by the cryptographic module, including initialization data and vectors, split key information, and/or key accounting information. " + txt_TE020401_3 + Environment.NewLine +
					"4.Plaintext or encrypted authentication data that is input into the cryptographic module, including passwords, PINs, and/or biometric information. " + txt_TE020401_4 + Environment.NewLine +
					"5.Status information from external sources." + txt_TE020401_5 + Environment.NewLine +
					"6.Any other information that is input into the cryptographic module for processing or storage, except for control information that is covered separately in AS02.07.";

				string TE020402;
				if (ExtInputDevice == "N/A")
				{
					TE020402 = "N/A";
				}
				else
				{
					TE020402 = "The module uses the following external input devices:" + Environment.NewLine +
						ExtInputDevice + Environment.NewLine + "The tester verified that vendor documentation specified any external input devices to be used with the cryptographic module for" +
					" the entry of data into the data input interface.The tester entered data into the data input interface using the identified external input device(s), and verified that entry of data using the external input device functions as specified.";
				}

				string TE020501 = "The tester verified, by inspection, that the cryptographic module includes a data output interface, and that the data output interface functions as specified." +
					"The tester verified that all data that has been processed and is to be output by the module exits via the data output interface, including:" + Environment.NewLine +
					"1. Plaintext data that has been decrypted by the cryptographic module. " + txt_TE020501_1 + Environment.NewLine +
					"2. Ciphertext data that has been encrypted, and digital signatures that have been generated by the cryptographic module. " + txt_TE020501_2 + Environment.NewLine +
					"3. Plaintext or encrypted cryptographic keys and other key management data that have been internally generated and output from the module. " + txt_TE020501_3 + Environment.NewLine +
					"4. Control information sent outside the cryptographic module to external targets. " + txt_TE020501_4 + Environment.NewLine +
					"5. Any other information that is output from the cryptographic module after processing or storage except for status information that is covered separately in AS02.08.";

				string TE020502;
				if (ExtOutputDevice == "N/A")
				{
					TE020502 = "N/A";
				}
				else
				{
					TE020502 = "The module uses the following external output devices:" + Environment.NewLine +
						ExtOutputDevice + Environment.NewLine + "The tester verified that the vendor documentation specifies any external output devices used with the cryptographic module" +
							" for the output of data from the data input interface. The tester did output data from the data output interface using the identified external output device(s)," +
							" and verified that output of data using the external output device functions as specified.";
				}
				string TE020601 = "The tester verified that vendor documentation specifies that all data output via the data output interface is inhibited whenever the cryptographic module" +
					" is in an error state. The tester verified from vendor documentation that once an error condition is detected and the error state is entered, all data output via the data" +
					" output interface is inhibited, until error recovery occurs. The tester also verified that the error states specified in response to this assertion are identical to the " +
					"error states specified under AS.04.06.";
				string TE020602 = "";  // Op testing
				string TE020603 = "The tester verified that vendor documentation specifies that all data output via the data output interface is inhibited whenever the cryptographic module" +
					" is in a self-test condition. The tester verified from vendor documentation that once self-tests are being performed, all data output via the data output interface is " +
					"inhibited, until the self-tests are completed. The tester verified that the self-test conditions are identical to the self tests specified under AS09.08.";
				string TE020604 = "During operational testing, the tester commanded the module to perform self-tests and verified that all data output via the data output interface was inhibited.";
				string TE020605 = "The tester verified that vendor documentation specifies how the cryptographic module ensures that all data output via the data output interface is to be " +
					"inhibited during error states or self-test conditions. The tester verified, by inspection of the design of the cryptographic module, that the data output interface is, " +
					"in fact, logically or physically inhibited under these conditions. During self-test conditions, the module will not support any service requests, which ensures " +
					"that no data will be output.";
				string TE020701 = "The tester verified, by inspection, that the cryptographic module included a control input interface, and that the control input interface functioned " +
					"as specified. The tester verified that all commands, signals, and control data used to control the operation of the cryptographic module entered via the control input interface, including: " + Environment.NewLine +
					"1. Commands input logically via an API. " + txt_TE020701_1 + Environment.NewLine +
					"2. Signals input logically or physically via one or more physical ports. " + txt_TE020701_2 + Environment.NewLine +
					"3. Manual control inputs. " + txt_TE020701_3 + Environment.NewLine +
					"4. Any other input control data";

				string TE020702;
				if (ExtOutputDevice == "N/A")
				{
					TE020702 = "N/A";
				}
				else
				{
					TE020702 = "The module uses the following external control input devices:" + Environment.NewLine +
						ExtCtrlDevice + Environment.NewLine + "The tester verified if vendor documentation specified any external input devices to be used with the cryptographic module for the entry of commands, " +
						"signals, and control data into the control input interface, such as smart cards, tokens, or keypads.The tester entered commands via the control input interface using" +
						" the identified external output device(s), and verify that input of commands using the external output device functions as specified.";
				}
				string TE020801 = "The tester verified by inspection, that the cryptographic module included a status output interface, and that the status output interface functions as specified." +
					"The tester verified that all status information, signals, logical indicators, and physical indicators used to indicate or display the status of the module exited via the status" +
					" output interface, including: " + Environment.NewLine +
					"1. Status information output logically via an API. " + txt_TE020801_1 + Environment.NewLine +
					"2. Signals output logically or physically via one or more physical ports. " + txt_TE020801_2 + Environment.NewLine +
					"3. Manual status outputs. " + txt_TE020801_3 + Environment.NewLine +
					"4. Any other output status information";

				string txt_TE020901_1;
				string txt_TE020901_2;

				if (TE020901_1 == "False") { txt_TE020901_1 = "N/A"; } else { txt_TE020901_1 = "Module requires external power input."; }
				if (TE020901_2 == "False") { txt_TE020901_2 = "N/A"; } else { txt_TE020901_2 = "Module provides power to other external devices."; }

				string TE020901 = "The tester verified that the vendor documentation specified whether the cryptographic module requires or provides power to/from other devices external to the cryptographic " +
					"boundary. The tester verified that vendor documentation specified a power interface and a corresponding physical port." + Environment.NewLine +
					txt_TE020901_1 + Environment.NewLine +
					txt_TE020901_2 + Environment.NewLine;
				string TE020902 = "The tester verified by inspection of the cryptographic module, that all power entering or exiting the module to/from other " +
					"devices external to the cryptographic boundary passes through the specified power interface.";
				string TE021001 = "The tester verified that vendor documentation specified how the cryptographic module distinguished between data and control for input" +
					" and data and status for output. Input data entered from the data input interface, and control information entered from the control input interface were" +
					" logically or physically distinguished from output data exiting to the output data interface and status information exiting to the status output interface.";
				string TE021002 = "The tester verified that vendor documentation specified how the physical and logical paths used by the input data and control information" +
					" were logically or physically disconnected from the physical and logical paths used by the output data and status information.If the physical and logical paths" +
					" used by the input data and control information and the output data and status information were physically shared, the tester verified that vendor documentation specified " +
					"how logical separation was enforced by the cryptographic module.";
				string TE021003 = "The tester verified, by inspection, the consistency of the vendor documentation, and that the cryptographic module distinguished between " +
					"data and control for input and data and status for output, and that the physical and logical paths followed by the input data and control " +
					"information entering the module via the applicable input interfaces were logically or physically disconnected from the physical and logical paths followed by the output " +
					"data and status information exiting the module via the applicable output interfaces.";
				string TE021101 = "The tester verified that vendor documentation specified the physical and logical paths used by all major categories of input data entering the cryptographic " +
					"module via the data input interface. The tester verified that the paths were documented in the specification. The input data paths were specified in sufficient detail " +
					 "for the tester to determine which type of data passed through each applicable physical port.";
				string TE021102 = "The tester verified from vendor documentation and by inspection of the cryptographic module, that all input data entering the module via the data " +
					"input interface and applicable physical ports only used the specified paths. The tester examined all logical and physical information flows and verified " +
					"that the specification of the paths used by the input data was consistent with the design and operation of the cryptographic module. The tester verified that there " +
					"were no conflicts between the applicable paths that could lead to the compromise of CSPs, plaintext data, or other information.";
				string TE021201 = "The tester verfied that vendor documentation specified the physical and logical paths used by all major categories of output data exiting the cryptographic" +
					" module via the data output interface. The tester verified that the paths were documented in the specification. The output data paths were specified " +
					"in sufficient detail for the tester to determine which type of data passed through each applicable physical port.";
				string TE021202 = "The tester verified from vendor documentation and by inspection of the cryptographic module, that all output data exiting the module via the data output " +
					"interface and applicable physical ports only used the specified paths. The tester examined all logical and physical information flows and verified that the " +
					"specification of the paths used by the output data was consistent with the design and operation of the cryptographic module. The tester verified that there were no conflicts" +
					" between the applicable paths that could lead to the comproise of CSPs, plaintext data, or other information.";
				string TE021301 = "The tester verified that vendor documentation specified how the physical and logical paths used by all major categories of output data exiting the " +
					"cryptographic module were logically or physically disconnected from the processes performing key generation, manual key entry, and zeroization of cryptographic keys and CSPs.";

				string TE021302;
				if (txt_TE021302 == "N/A")
				{
					TE021302 = "The tester verified that vendor documentation specified that the module does not support the output of CSPs.";
				}
				else
				{
					TE021302 = "The tester verified that vendor documentation specified how the cryptographic module enforces logical " +
						"separation of the output data and key/CSP information." + Environment.NewLine + txt_TE021302;
				}



				string TE021303 = "The tester verified that the output data path was logically or physically disconnected from the processes performing key generation, manual key entry, and" +
					" zeroization of cryptographic keys and CSPs by recording or observing the output data interface and the applicable physical ports and verifying that no key or " +
					"CSP information was released.";
				string TE021401 = "The tester determined whether the cryptographic module allows plaintext cryptographic key components or other unprotected CSPs to be output on " +
					"one or more physical ports.The tester verified that vendor documentation specified the two independent internal actions performed by " +
					"the cryptographic module before the plaintext cryptographic key components or other unprotected CSPs may be output.The tester" +
					" verified that vendor documentation specified how the two independent internal actions protected against the inadvertent release of the plaintext " +
					"cryptographic key components or other unprotected CSPs.";
				string TE021402 = "The tester caused the output of cryptographic key components or other unprotected CSPs on one or more physical ports, and verified that " +
					"the two independent internal actions function as specified. If any software or firmware components were executed in the process of outputting plaintext" +
					" cryptographic key components or other unprotected CSPs, the tester examined the applicable source code listings to ensure that the " +
					"software or firmware components supported the requirement for two independent internal actions before the output of any plaintext cryptographic key " +
					"components or other unprotected CSPs occured.";
				string AS0215 = "This assertion is not separately tested. Verification of vendor documentation is performed under assertions AS02.01 to AS02.14 and AS02.16 to AS02.18.";

				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020101 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 1 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020102 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 1 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020103 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 1 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020104 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 1 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020201 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 2 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020202 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 2 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020301 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 3 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020401 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 4 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020402 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 4 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020501 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 5 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020502 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 5 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020601 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 6 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020603 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 6 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020604 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 6 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020605 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 6 + "  and SequenceNo = " + 5 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020701 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 7 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020702 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 7 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020801 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 8 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020901 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 9 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE020902 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 9 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021001 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 10 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021002 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 10 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021003 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 10 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021101 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 11 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021102 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 11 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021201 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 12 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021202 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 12 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021301 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 13 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021302 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 13 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021303 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 13 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021401 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 14 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021402 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 14 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0215 + "'  WHERE VendorTester = 'AS' and Section = " + 2 + " and Requirement = " + 15 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();




				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populatePortInterfaceLevel34()
		{
			// start writing assertions for Level 3,4
			try
			{
				connection.Open();
				command.Connection = connection;


				string TE021601;
				string TE021602;
				string TE021701;
				string TE021702;
				string TE021801;

				if (txt_AS0216 == "True")
				{
					TE021601 = "The tester verified that vendor documentation specified that the cryptographic module inputs or outputs plaintext cryptographic " +
						   "key components, plaintext authentication data, or other unprotected CSPs. The tester verified from vendor documentation and also by" +
						   " inspection of the physical ports on the cryptographic module, that the applicable physical ports used for the input and output of plaintext cryptographic" +
						   " key components, plaintext authentication data, or other unprotected CSPs were physically separated from all other physical ports of the module.";

					TE021602 = "The tester verified that only plaintext cryptographic keys, plaintext authentication data, or other unprotected CSPs entered" +
						" or exited the module through the applicable physical ports, and that no other data, plaintext or encrypted, entered or exited the " +
						"module via the applicable physical ports.";

					TE021701 = "AS02.16 is satisfied";
					TE021702 = TE021701;
				}
				else if (txt_AS0217 == "True")
				{
					TE021601 = "AS02.17 is satisfied";
					TE021602 = TE021601;

					TE021701 = "The tester verified that vendor documentation specified the module inputs or outputs plaintext cryptographic key components, plaintext" +
						" authentication data, or other unprotected CSPs. The tester verified from vendor documentation and also by inspection of the cryptographic" +
						" module, that the applicable logical ports used for the input and output of plaintext cryptographic key components, plaintext authentication data, or other " +
						"unprotected CSPs were logically separated from all other logical interfaces of the module using a trusted path";

					TE021702 = "The tester verified that only plaintext cryptographic keys, plaintext authentication data, or other unprotected CSPs entered or exited the module" +
					" through the applicable logical interface using the trusted path, and that no other data, plaintext or encrypted, entered or exited the module via the " +
					"applicable logical interface using the trusted path.";
				}
				else
				{
					TE021601 = "N/A";
					TE021602 = TE021601;
					TE021701 = TE021601;
					TE021702 = TE021601;
				}

				if (txt_AS0216 == "True" || txt_AS0217 == "True")
				{
					TE021801 = "The tester verified from vendor documentation and also by inspection of the physical ports and the cryptographic boundary, that the physical ports used" +
						" for the input of these parameters were directly connected to the cryptographic boundary of the cryptographic module without passing through any intervening" +
						" systems, processors, circuitry, or other areas outside the cryptographic boundary.";
				}
				else
				{
					TE021801 = "N/A";
				}

				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021601 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 16 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021602 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 16 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021701 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 17 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021702 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 17 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE021801 + "'  WHERE VendorTester = 'TE' and Section = " + 2 + " and Requirement = " + 18 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
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






