using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FIPSGuideTool
{
	class SelfTestsAssertions
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();

		string GenPublicPrivateKeys    = SelfTests.GenPublicPrivateKeys;
		string AlgOutputVaries         = SelfTests.AlgOutputVaries;
		string AsymAlg                 = SelfTests.AsymAlg;
		string MessageDigestAlg        = SelfTests.MessageDigestAlg;
		string IndpendImplementation   = SelfTests.IndpendImplementation;
		string KAT_TE092001            = SelfTests.KAT_TE092001;
		string CAT_TE092001            = SelfTests.CAT_TE092001;
		string ApprAuthenTech          = SelfTests.ApprAuthenTech;
		string EDC                     = SelfTests.EDC;
		string txt_ApprovedTechnique   = SelfTests.txt_ApprovedTechnique;
		string txt_EDC                 = SelfTests.txt_EDC;
		string DAC                     = SelfTests.DAC;
		string DSA                     = SelfTests.DSA;
		string CriticalFunctions       = SelfTests.CriticalFunctions;
		string CalcVerifDSA            = SelfTests.CalcVerifDSA;
		string SWFWLoad                = SelfTests.SWFWLoad;
		string txt_ApprTechSWFWLoad    = SelfTests.txt_ApprTechSWFWLoad;
		string ManualKeyEntry          = SelfTests.ManualKeyEntry;
		string DuplicateEntry_KeyEntry = SelfTests.DuplicateEntry_KeyEntry;
		string EDC_KeyEntry            = SelfTests.EDC_KeyEntry;
		string RNG2                    = SelfTests.RNG2;
		string RNG_Block_GT15          = SelfTests.RNG_Block_GT15;
		string RNG_Block_LT16          = SelfTests.RNG_Block_LT16;
		string BypassCapability        = RolesAndServices.BypassCapability;

		public SelfTestsAssertions()
		{
			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
			connection.Open();

			command.Connection = connection;
			connection.Close();
		}


		public void populateSelfTestsLevel1234()
		{
			// start writing assertions for Level 1,2,3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				string AS0901   = "This assertion is tested as part of AS09.07.";
				string TE090401 = "The tester inspected the vendor documentation, and checked that it listed every error state that the module entered upon failure of a self-test, and " +
					"indicated the error indicator associated with each error state. The tester compared the list of error states to those defined in the finite state model and " +
					"verified that they agreed.";
				string TE090402 = "The tester verified that the vendor documentation specified how each self-test handled errors, the tester verified that: " + Environment.NewLine +
					"1. The module entered an error state upon failing a self-test. " + Environment.NewLine +
					"2. The error state was consistent with the documentation and the finite state model. " + Environment.NewLine +
					"3. The module outputted an error indicator. " + Environment.NewLine +
					"4. The error indicator was consistent with the documented error indicator.";

				string TE090403 = "The tester ran self-tests and caused the module to enter every error state. The tester compared the observed error indicator with the indicator " +
					"specified in the vendor documentation and verified that they were the same.";
				string TE090501 = "Tester verification of the inhibition of output was performed under TE02.06.01 and TE02.06.02. The results of the verification indicated" +
					" that the module inhibited all data output when the module was in an error state.";
				string TE090502 = "The tester verified that vendor documentation specified that cryptographic functions were inhibited while the module was in an error state. " +
					"Cryptographic functions included the following: " + Environment.NewLine +
					"1. Encryption " + Environment.NewLine +
					"2. Decryption " + Environment.NewLine +
					"3. Secure message hashing " + Environment.NewLine +
					"4. Digital signature creation and verification " + Environment.NewLine +
					"5. Other operations that require the use of cryptography";

				string TE090503 = "The tester put the module in the error state and verified that any cryptographic operations that the tester attempted to initiate were prevented.";
				string TE090601 = "Tester verification of the inhibition of output was performed under TE02.06.01 and TE02.06.02. The results of the verification indicated that the vendor " +
					"documentation showed that all data outputted via the data output interface was inhibited whenever the module was in an error state.";
				string TE090602 = "The tester put the module in an error state and verified that all data outputted via the data output interface was inhibited when an error state existed.";

				string txt_TE090701;
				if (GenPublicPrivateKeys == "True") { txt_TE090701 = ""; } else { txt_TE090701 = "N/A"; }

				string TE090701 = "The tester inspected the list of self-tests and verified that it included the following: " +
					"1. Power-up tests:" + Environment.NewLine +
					"-Cryptographic algorithm test" + Environment.NewLine +
					"-Random number generator test" + Environment.NewLine +
					"-Software/firmware test" + Environment.NewLine +
					"-Critical functions test" + Environment.NewLine +
					"-Other self-tests that are performed at power-up and on demand" + Environment.NewLine +
					"2. Conditional tests:" + Environment.NewLine +
					"-Pairwise consistency test" + txt_TE090701 + Environment.NewLine +
					"-Software/firmware load test" + Environment.NewLine +
					"-Manual key entry test" + Environment.NewLine +
					"-Continuous random number generator test" + Environment.NewLine +
					"-Bypass test" + Environment.NewLine +
					"-Other conditional tests";

				string TE090702 = "The tester checked that the information provided above was specified for each error condition.";
				string TE090703 = "The tester caused each error condition to occur and attempted to clear the error condition. The tester verified that actions necessary to clear " +
					"the error condition were consistent with the vendor documentation.";

				string AS0908   = "This assertion is tested as part of AS09.09.";
				string TE090901 = "The tester verified that the vendor documentation required that the running of power-up self-tests did not involve any inputs from or actions by the operator.";
				string TE090902 = "The tester powered up the module and verified that the module performed the power-up self-tests without requiring any operator intervention.";
				string TE091001 = "The tester verified that the vendor documentation specified an indicator that was outputted from the status output interface upon successful completion" +
					" of the power-up self-tests.";
				string TE091002 = "The tester powered up the module and monitored the status output interface. The expected indicator from the status output interface was consistent" +
					" with the documented indicator.";
				string AS0911   = "This assertion is tested as part of AS02.06.";
				string TE091201 = "The tester inspected the vendor documentation and verified that initiation of power-up self-tests on demand was specified for all of the power-up" +
					" self-tests.";
				string TE091202 = "The tester initiated the power-up on demand self-tests and verified that the initiation of the power-up self-tests on demand was consistent with" +
					" vendor documentation.";
				string TE091301 = "Verification of the documented list of power-up self-tests was performed under TE09.07.01.";
				string TE091302 = "Verification that the module performed the self-tests as documented was done under validation requirements for AS09.16-AS09.28.";
				string AS0914   = "There are no requirements for this assertion number.";
				string TE091601 = "By inspecting the vendor documentation, the tester verified that a known answer test was associated with all cryptographic functions of each Approved" +
					" cryptographic algorithm implemented by the cryptographic module as indicated in AS01.12.";
				string TE091602 = "The tester verified that the documentation was consistent with the implementation of the cryptographic module.";
				string TE091702 = "This is tested under TE09.04.01, TE09.04.02, and TE09.04.03.";

				string TE091801; 
				string TE091802;
				string TE091803;
				if (AlgOutputVaries == "True" && AsymAlg == "True")
				{
					TE091801 = TE091602;
					TE091802 = "By inspecting the vendor documentation, the tester verified if either a known-answer test or a pair-wise consistency test was associated with the" +
						" cryptographic function.";
					TE091803 = "Pair-wise consistency was tested in AS09.31 (encryption), AS09.32 (key agreement) and AS09.33 (digital signature creation and verification).";

				}
				else
				{
					TE091801 = "The tester verified that the module does not support asymmetric algorithms.";
					TE091802 = TE091801;
					TE091803 = TE091801;
				}

				string TE091901;
				string TE091902;
				string TE091903;
				if (MessageDigestAlg == "True")
				{
					TE091901 = TE091602;
					TE091902 = "The tester determined that the module implemented a message digest algorithm. The tester verified that the vendor " +
						"documentation specified whether the message digest algorithm has its own known answer test or whether it is included " +
						"in the known answer test of another algorithm.";
					TE091903 = "By checking the code listing and/or design documentation, the tester verified that the module used either a " +
						"separate known answer test or the known answer test of an algorithm in order to test a message digest algorithm.";
				}
				else
				{
					TE091901 = "N/A";
					TE091902 = TE091901;
					TE091903 = TE091901;

				}

				string TE092001;
				string TE092002;
				string TE092003;
				if (IndpendImplementation == "True")
				{
					if (KAT_TE092001 == "True")
					{
						TE092001 = "The tester determined from the vendor documentation that a known answer test was used to test the module''s cryptographic algorithm.";
					}
					else 
					{
						TE092001 = "The tester determined from the vendor documentation that a compared answer test was used to test the module''s cryptographic" +
						" algorithm. The tester determined that the documentation of the compared answer test included: " + Environment.NewLine +
						"1.Use of two independent cryptographic algorithm implementations " + Environment.NewLine +
						"2.Continual comparison of the outputs of the algorithm implementation " + Environment.NewLine +
						"3.Transition into an error state and output of an error indicator when the two outputs are not equal";
					}
										
					TE092002 = "By checking the code and/or design documentation, the tester verified that the module implemented the documented steps for performing a compared answer test.";
					TE092003 = "Validation of whether the module entered the error state and outputted an error indicator upon failure of the self-test was performed under TE09.04.01, " +
						"TE09.04.02, and TE09.04.03.";
				}
				else
				{
					TE092001 = "N/A";
					TE092002 = TE092001;
					TE092003 = TE092001;
				}

				string AS0921   = "This assertion is tested as part of AS09.20.";

				string TE092201;
				string TE092202;
				string TE092203;
				string TE092204;
				string TE092205;
				string TE092401;

				
				if (ApprAuthenTech == "True")
				{
					TE092201 = "The tester determined from the vendor supplied documentation which technique was used for the software/firmware components integrity test." + Environment.NewLine +
						"Approved authentication technique: " + txt_ApprovedTechnique;
					TE092202 = "The tester verified that an Approved authentication technique was implemented, and the vendor documentation either included requirements in TE01.12.01 " +
						"or in the absence of a CMVP algorithm validation certificate issuing process, the vendor organization provided a written affirmation of conformance.";
					TE092203 = "N/A";
					TE092401 = TE092203;				
				}
				else
				{
					TE092201 = "The tester determined from the vendor supplied documentation that Error Detection Code (EDC) was used for the software/firmware components integrity test." + Environment.NewLine +
						"Error detection code: " + txt_EDC;
					TE092202 = "N/A";
					TE092203 = "The tester verified that the module implements EDCs for software/firmware integrity, and the vendor documentation" +
						" of the software/firmware test includes: " + Environment.NewLine +
						"1. Description of EDC algorithm. " + Environment.NewLine +
						"2. Identification of software and firmware that is protected using EDCs." + Environment.NewLine +
						"3. Calculation of the EDCs when the software and firmware is installed." + Environment.NewLine +
						"4. Recalculation of the EDCs when the self-test is initiated." + Environment.NewLine +
						"5. Comparison of the stored EDC against the recalculated EDC. " + Environment.NewLine +
						"6. Failure of the self - test when the two EDCs are not equal.";

					TE092401 = "The tester verified that the implemented EDCs were at least 16 bits in length.";
				}

				if (DAC == "True")
				{
					TE092204 = "The tester verified that the vendor documentation of the software/firmware test fully described the process " +
						"by which the DAC was calculated and verified.";
				}
				else
				{
					TE092204 = "N/A";
				}

				if (DSA == "True")
				{
					TE092205 = "The tester verified that the vendor documentation of the software/firmware test included the following: " + Environment.NewLine +
						"1.Specify the Approved digital signature algorithm implemented. " + Environment.NewLine +
						"2.Identification of software and firmware that is protected using the Approved digital signatures. " + Environment.NewLine +
						"3. Calculation of the Approved digital signatures when the software and firmware is installed. " + Environment.NewLine +
						"4. Verification of the Approved digital signature when the self-test is initiated. " + Environment.NewLine +
						"5. Failure of the self-test upon failure of the Approved digital signature verification."; 
				}
				else
				{
					TE092205 = "N/A";
				}

				string TE092206 = "By checking the code and/or design documentation, the tester verified that the implementation of the " +
					"software/firmware test was consistent with TE09.22.01, TE09.22.02, TE09.22.03, or TE09.22.04.";
				string TE092207 = "The tester tested the module by modifying the stored software, firmware, or the implemented integrity" +
					" mechanism and initiated the self-tests, and observed the output from the status output interface. The module was observed" +
					" to transition into a fatal error state in which the module could not be recovered.";
				string AS0923   = "This assertion is tested as part of AS09.22.";
				string AS0925   = "This assertion is tested as part of AS09.27.";

				string TE092701 = "The tester reviewed the vendor provided documentation of the critical functions and the self-tests that were" +
					" designed to test them. This documentation included the following: " + Environment.NewLine +
					 "1.Identification and description of all critical functions " + Environment.NewLine +
					 "2.Identification of at least one self - test for every critical function";

				string TE092702;
				if (CriticalFunctions == "True")
				{
					TE092702 = "By checking the code and/or design documentation, the tester verified that the module performed the specified" +
						" self-tests for each critical function.";
				}
				else
				{
					TE092702 = "N/A";
				}

				string AS0928   = "There are no requirements for this assertion number.";
				string AS0929   = "This assertion is not separately tested.";

				string AS0930;
				string TE093101;
				string TE093301;
				

				if (GenPublicPrivateKeys == "True")
				{
					AS0930   = "This assertion is tested as part of AS09.31 and AS09.33.";
					TE093101 = "The tester verified that the implementation of the pairwise consistency check, as defined in AS09.31, was " +
						"consistent with the vendor documentation by checking the code and/or design documentation.";

					if (CalcVerifDSA == "True")
					{
						TE093301 = "The tester verified that the implementation of the pairwise consistency check as defined in AS09.33 was" +
							" consistent with the vendor documentation by checking the code and/or design documentation.";
					}
					else
					{
						TE093301 = "N/A";
					}
					
				}
				else
				{
					AS0930   = "N/A";
					TE093101 = AS0930;
					TE093301 = AS0930;
				}


				string AS0934;
				string TE093501;
				string TE093502;
				string TE093503;
				string TE093504;
				string TE093505;
				string AS0936;

				if (SWFWLoad == "True")
				{
					AS0934   = "This assertion is tested as part of AS09.34, AS09.35, and AS09.36.";
					TE093501 = "The tester determined from the vendor supplied documentation that the following Approved authentication technique was" +
						" used for the software/firmware load test." + Environment.NewLine + txt_ApprTechSWFWLoad;
					TE093502 = "The tester verified that the vendor documentation either included requirements in TE01.12.01 or in the absence of " +
						"a CMVP algorithm validation certificate issuing process, the vendor organization provided a written affirmation of " +
						"conformance.";
					TE093503 = "The tester verified that the vendor documentation of the software/firmware load test included:" + Environment.NewLine +
						"1. The Approved authentication technique implemented. " + Environment.NewLine +
						"2. Identification of software and firmware that is protected using the Approved authentication technique. " + Environment.NewLine +
						"3. Calculation of the Approved authentication technique when the software and firmware is loaded. " + Environment.NewLine +
						"4. Verification of the Approved authentication technique when the load test is initiated. " + Environment.NewLine +
						"5. Failure of the self-test upon failure of the Approved authentication technique verification.";
					TE093504 = "By checking the code and/or design documentation, the tester verified that the implementation of the " +
						"software/firmware load test was consistent with TE09.35.01, TE09.35.02 and TE09.35.03.";
					TE093505 = "The tester tested the module by modifying the software or firmware to be loaded, or the implemented authentication" +
						" mechanism and initiated the self-tests, and observed the output from the status output interface. The module was observed" +
						" to transition into a fatal error state in which the module could not be recovered.";
					AS0936   = "This assertion is tested as part of AS09.35.";	
					
				}
				else
				{
					AS0934   = "N/A";
					TE093501 = AS0934;
					TE093502 = AS0934;
					TE093503 = AS0934;
					TE093504 = AS0934;
					TE093505 = AS0934;
					AS0936   = AS0934;
				}

				string AS0937;
				string AS0938;
				string AS0939;
				string TE094001;
				string TE094002;
				string TE094003;


				if (ManualKeyEntry == "True")
				{
					AS0937 = "This assertion is not separately tested.";
					AS0938 = "This assertion is tested as part of AS09.40.";

					if (EDC_KeyEntry == "True")
					{
						AS0939   = "This assertion is tested as part of AS09.40.";
						TE094002 = "The tester determined from the vendor documentation that Error Detection Code was used for the manual key entry test." +
							"The vendor documentation, code, and design documentation specified the implementation of the manual key entry test and" +
							" included following information:" + Environment.NewLine +
							"- Key format for all manually-entered keys, including fields for EDCs (see AS07.03)" + Environment.NewLine +
							"- Description of EDC algorithm " + Environment.NewLine +
							"- Description of EDC verification process " + Environment.NewLine +
							"- All expected outputs for success or failure of the test";

						TE094003 = "The tester performed the following tests: " + Environment.NewLine +
							"1. The tester entered every manually entered key and verified that the procedure used to enter each key was in " +
							"accordance with the documented procedure, including the form that the keys were in when they were entered. "+ Environment.NewLine +
						   "2.The tester entered each type of manually-entered key without any errors and observed the status output interface." +
							" The indicator was detected, and matched the documented indicator for the success of the manual key entry test. " + Environment.NewLine +
							"3. The tester attempted to perform cryptographic operations with each entered key and verified that it was entered " +
							"correctly. " + Environment.NewLine +
							"4. The tester changed the EDC associated with each manually-entered key or the key itself and entered them" +
							" into the module. The tester observed the indicator that was output from the status output interface wich matched" +
							" the documented indicator for the failure of the manual key entry test. " + Environment.NewLine +
							"5. The tester attempted to perform cryptographic operations with each key that was not successfully entered." +
							" Each operation using each key failed, verifying that the key was not entered.";
					}
					else
					{
						AS0939 = AS0938;
						TE094002 = "The tester determined from the vendor documentation that duplicate key entries was used for the manual key entry" +
							" test. The vendor documentation, code, and design documentation specified the implementation of the manual key entry " +
							"test and included the following information:" + Environment.NewLine +
							"- Duplicate key entries for all manually-entered keys " + Environment.NewLine +
							"- Description of duplicate key, entry verification process " + Environment.NewLine +
							"- All expected outputs for success or failure of the test";

						TE094003 = "The tester performed the following tests: " + Environment.NewLine +
							"1. The tester entered each type of manually-entered key without any errors and observed the status output interface." +
							" THe indicator was detected, and matched the documented indicator for the success of the manual key entry test. " + Environment.NewLine +
							"2. The tester attempted to perform cryptographic operations with each entered key and verified that it was entered " +
							"correctly. " + Environment.NewLine +
							"3. The tester altered the accuracy of one of the manually entered keys, either the first or second duplicate entry, " +
							"and entered them into the module. The tester observed the indicator that was output from the status output interface; " +
							"output was detected, and the indicator matched the documented indicator for the failure of the manual key entry test. " + Environment.NewLine +
							"4. The tester attempted to perform cryptographic operations with each key that was not successfully entered. Each " +
							"operation using each key failed, verifying that the key was not entered.";
					}

					TE094001 = "Verification of vendor documentation is performed under TE07.28.01.";
				}
				else
				{
					AS0937   = "N/A";
					AS0938   = AS0937;
					AS0939   = AS0937;
					TE094001 = AS0937;
					TE094002 = AS0937;
					TE094003 = AS0937;
				}

				string AS0941;
				string TE094201;
				string TE094301;

				if (RNG2 == "True")
				{
					AS0941   = "This assertion is tested as part of AS09.42 and AS09.43.";
	
					if (RNG_Block_GT15 == "True")
					{
						TE094201 = "The tester checked the documentation, code and design documentation that specified the continuous random number " +
						"generator test and verified that it implemented the specifics of the test. Since the generator generated blocks of n bits, " +
						"where n > 15, the tester verified that the implementation of the test included: " + Environment.NewLine +
						"1. Storage of first block for comparison against the next block " + Environment.NewLine +
						"2. Comparison of each subsequently generated block against the previously generated block " + Environment.NewLine +
						"3. Failure of the test if two compared blocks are equal";

						TE094301 = "The tester verified that the generator generates block sizes greater than 15 bits. " +
							"The tester verified that the implementation of the test included: " + Environment.NewLine +
							"1.Storage of first block for comparison against the next block " + Environment.NewLine +
							"2.Comparison of each subsequently generated block against the previously generated block " + Environment.NewLine +
							"3.Failure of the test if two compared blocks are equal";
					}
					else
					{
						TE094201 = "The tester checked the documentation, code and design documentation that specified the continuous random number " +
						"generator test and verified that it implemented the specifics of the test. Since the generator consistently generated fewer than 16 bits, the tester verified that the implementation of the test" +
						" included the following: " + Environment.NewLine +
						"1. Storage of the first n bits, where n > 15, for comparison against the next n generated bits " + Environment.NewLine +
						"2. Comparison of each subsequently generated n bits against the previously generated n bits " + Environment.NewLine +
						"3. Failure of the test if two compared n-bit sequences are equal";

						TE094301 = "The tester verified that the generator generates block sizes less than 16 bits. " +
							"The tester verified that the implementation of the test included: " + Environment.NewLine +
							"1.Storage of the first n bits, where n > 15, for comparison against the next n generated bits " + Environment.NewLine +
							"2.Comparison of each subsequently generated n bits against the previously generated n bits " + Environment.NewLine +
							"3.Failure of the test if two compared n-bit sequences are equal";
					}

				}
				else
				{
					AS0941   = "N/A";
					TE094201 = AS0941;
					TE094301 = AS0941;
				}


				string AS0944;
				string TE094501;
				string TE094502;
				string TE094503;
				string TE094601;
				string TE094602;
				string TE094603;
				string AS0947;


				if (BypassCapability == "True" || BypassCapability == "Checked")
				{
					AS0944   = "This assertion is not separately tested.";
					TE094501 = "The tester verified that the module implemented a bypass test to verify the correct operation of the cryptographic service when a switch took " +
						"place between an exclusive bypass service and an exclusive cryptographic service.";
					TE094502 = "The tester verified that the vendor documentation was consistent with the bypass test implementation through a review of the source code and documentation.";
					TE094503 = "The tester switched the module from the exclusive bypass service to the exclusive cryptographic service and verified that plaintext information was not output.";
					TE094601 = "The tester verified that the module implemented a bypass test to verify the correct operation of the cryptographic service when the mechanism governing the " +
						"switching procedure was modified.";
					TE094602 = "The tester verified that the vendor was consistent with the bypass test implementation through the review of the source code and design documentation.";
					TE094603 = "The tester verified the correct operation of the bypass test by: " + Environment.NewLine +
						"1.Verifying that the mechanism governing the switching procedure checks to ensure that no alteration of the mechanism has taken place since the last modification. " +
						"The tester documented the method used." + Environment.NewLine +
						"2.Modifying the mechanism governing the switching procedure in order to verify the correct operation of the mechanism and to verify the correct operation of the " +
						"cryptographic service by verifying that the plaintext information is not output.";
					AS0947   = "This assertion is tested as part of AS09.45 and AS09.46.";
				}
				else
				{
					AS0944   = "N/A";					;
					TE094501 = AS0944;
					TE094502 = AS0944;
					TE094503 = AS0944;
					TE094601 = AS0944;
					TE094602 = AS0944;
					TE094603 = AS0944;
					AS0947   = AS0944;

					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 44 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 45 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 45 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 45 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 45 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 46 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 46 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 46 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 46 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 47 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
					command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 48 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					command.ExecuteNonQuery();
				}


				//string Query = "UPDATE ValidationInfo SET Assessment= (@Value)";
				//OleDbCommand cmd = new OleDbCommand(Query, connection);
				//cmd.Parameters.Add(new OleDbParameter("@Value", AS0901));
				//cmd.ExecuteNonQuery();
								
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0901 + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 1 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0901   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 2 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0901   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 3 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE090401 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 4 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE090402 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 4 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE090403 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 4 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE090501 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 5 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE090502 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 5 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE090503 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 5 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE090601 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 6 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE090602 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 6 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE090701 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 7 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE090702 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 7 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE090703 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 7 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0908   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 8 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE090901 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 9 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE090902 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 9 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091001 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 10 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091002 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 10 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0911   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 11 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091201 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 12 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091202 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 12 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091301 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 13 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091302 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 13 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0914   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 14 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0914   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 15 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091601 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 16 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091602 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 16 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091602 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 17 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091702 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 17 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091801 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 18 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091802 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 18 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091803 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 18 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091901 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 19 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091902 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 19 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE091903 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 19 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE092001 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 20 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE092002 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 20 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE092003 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 20 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0921   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 21 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE092201 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 22 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE092202 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 22 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE092203 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 22 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE092204 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 22 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE092205 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 22 + "  and SequenceNo = " + 5 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE092206 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 22 + "  and SequenceNo = " + 6 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE092207 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 22 + "  and SequenceNo = " + 7 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0923   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 23 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE092401 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 24 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0925   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 25 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0925   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 26 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE092701 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 27 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE092702 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 27 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0928   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 28 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0929   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 29 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0930   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 30 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE093101 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 31 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0928   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 32 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE093301 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 33 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0934   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 34 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE093501 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 35 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE093502 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 35 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE093503 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 35 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE093504 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 35 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE093505 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 35 + "  and SequenceNo = " + 5 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0937   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 37 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0938   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 38 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0939   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 39 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE094001 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 40 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE094002 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 40 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE094003 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 40 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0941   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 41 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE094201 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 42 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE094301 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 43 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0944   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 44 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE094501 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 45 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE094502 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 45 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE094503 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 45 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE094601 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 46 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE094602 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 46 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE094603 + "'  WHERE VendorTester = 'TE' and Section = " + 9 + " and Requirement = " + 46 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0947   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 47 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0947   + "'  WHERE VendorTester = 'AS' and Section = " + 9 + " and Requirement = " + 48 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
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