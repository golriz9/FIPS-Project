using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FIPSGuideTool
{
	class KeyManagementAssertions
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();

		public static string NoBitsGenNDRNG;
		public static string NoBitsEntropyInput;
		public static string NoBitsNonce;
		public static string NoBitsAdditInput;
		public static string NoBitsPersonalStr;
		public static string AlgDRBGDepends;
		public static string DRBGOutputLength;
		public static string MinEntropy;
		public static string MaxEntropy;
		public static string DRBG_Type;
		public static string DerivFunc;
		public static string StandardEntropy;
		public static string FullEntropyOutput;
		public static string TE071301_txt;

		string CSPProtcStratg = KeyManagement.CSPProtcStratg;
		string PubKeyProtect = KeyManagement.PubKeyProtect;
		string PubKeyEntry = KeyManagement.PubKeyEntry;
		string CryptKeyList = KeyManagement.CryptKeyList;
		string RNG_employment = KeyManagement.RNG_employment;
		string AppRNGFunc = KeyManagement.AppRNGFunc;
		string SeedLength = KeyManagement.SeedLength;
		string SeedKeyLength = KeyManagement.SeedKeyLength;
		string nonAppRNGFunc = KeyManagement.nonAppRNGFunc;
		string KeyGenSecurity = KeyManagement.KeyGenSecurity;
		string AppKeyEstab = KeyManagement.AppKeyEstab;
		string KeyEstabSecurity = KeyManagement.KeyEstabSecurity;
		string KeyEntryOutput = KeyManagement.KeyEntryOutput;
		string KeyGen = KeyManagement.KeyGen;
		string KeyEstablishment = KeyManagement.KeyEstablishment;
		string KeyStorage = KeyManagement.KeyStorage;
		string KeyZeroization = KeyManagement.KeyZeroization;
		string OTAR = KeyManagement.OTAR;
		string ManualKeyEntry = KeyManagement.ManualKeyEntry;
		string AutoKeyEntry = KeyManagement.AutoKeyEntry;
		string ManualKeyEntry_enc = KeyManagement.ManualKeyEntry_enc;
		string ManualKeyEntry_spltKnlg = KeyManagement.ManualKeyEntry_spltKnlg;
		string SplitKnowledge = KeyManagement.SplitKnowledge;

		public static string TE070101;
		public static string TE070201;
		public static string TE070202;
		public static string TE070301;
		public static string TE070801;
		public static string TE070802;
		public static string TE070901;
		public static string TE070902;
		public static string TE071001;
		public static string TE071301;
		public static string TE071701;
		public static string TE071702;
		public static string TE071901;
		public static string TE071101;
		public static string TE071102;
		string TE071302;
		string AS0715;
		string TE071501;
		string TE071502;
		string TE071503;
		string TE071504;
		string TE071601;
		string TE071602;
		string TE071801;
		string TE071802;
		string TE071902;
		string TE072101;
		string TE072102;
		string TE072301;
		string TE072302;
		string TE072401;
		string TE072402;
		string TE072501;
		string TE072502;
		string TE072701;
		string TE072702;
		string TE072801;
		string TE072802;
		string TE072901;
		string TE072902;
		string AS0720 = "This assertion is tested as part of AS07.23-AS07.30.";
		string AS0722 = "This assertion is tested in AS07.28.";
		string AS0712;



		public KeyManagementAssertions()
		{
			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
			connection.Open();

			command.Connection = connection;
			connection.Close();
		}

		public void populateKeyManagementLevel1234()
		{
			// start writing assertions for Level 1,2,3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				NoBitsGenNDRNG = Properties.Settings.Default.NoBitsGenNDRNG.ToString();
				NoBitsEntropyInput = Properties.Settings.Default.NoBitsEntropyInput.ToString();
				NoBitsNonce = Properties.Settings.Default.NoBitsNonce.ToString();
				NoBitsAdditInput = Properties.Settings.Default.NoBitsAdditInput.ToString();
				NoBitsPersonalStr = Properties.Settings.Default.NoBitsPersonalStr.ToString();
				AlgDRBGDepends = Properties.Settings.Default.AlgDRBGDepends.ToString();
				DRBGOutputLength = Properties.Settings.Default.DRBGOutputLength.ToString();
				MinEntropy = Properties.Settings.Default.MinEntropy.ToString();
				MaxEntropy = Properties.Settings.Default.MaxEntropy.ToString();
				DRBG_Type = Properties.Settings.Default.DRBG_Type.ToString();
				DerivFunc = Properties.Settings.Default.DerivFunc.ToString();
				StandardEntropy = Properties.Settings.Default.StandardEntropy.ToString();
				FullEntropyOutput = Properties.Settings.Default.FullEntropyOutput.ToString();

				TE070101 = "The tester verified that the vendor documentation describes the protection of its secret keys and CSPs." +
				" The documentation describes how these keys and CSPs are protected with logical and physical security mechanisms that" +
				" prevent unauthorized disclosure, unauthorized modification, and unauthorized substitution. These protections include:"
				+ Environment.NewLine + Environment.NewLine + CSPProtcStratg;

				if (CSPProtcStratg != null)
				{
					CSPProtcStratg = CSPProtcStratg.Replace("'", "\''");
				}			
				
				TE070201 = "It was verified that vendor documentation describes how the public keys are protected from unauthorized" +
					" modification and unauthorized substitution:" + Environment.NewLine + Environment.NewLine + PubKeyProtect;

				if (PubKeyProtect != null)
				{
					PubKeyProtect = PubKeyProtect.Replace("'", "\''");
				}				

				TE070202 = "Upon performing operational testing and inspection of the module’s source code and review of " +
				"proprietary and nonproprietary documentation, the tester identified the public keys entered into and stored within " +
				"the module as follows:" + Environment.NewLine + Environment.NewLine + PubKeyEntry +
				Environment.NewLine + Environment.NewLine + "The tester asserts that the public key cannot be substituted or modified " +
				"due to implemented protection mechanisms.  During operational testing, the tester modified one byte of the public keys " +
				"during the re-key process (e.g. RenewPKMCertService, RenewPKMService) and attempted to load them into the module. The " +
				"module indicated that the verification of the public key loading failed, and returned an error indicating that the " +
				"service failed.";
				if (PubKeyEntry != null)
				{
					PubKeyEntry = PubKeyEntry.Replace("'", "\''");
				}

				TE070301 = "The vendor documentation was reviewed and verified that it provided a list all cryptographic keys, " +
				"cryptographic key components, and CSPs used by the module:" + Environment.NewLine + Environment.NewLine + CryptKeyList;
				
				if (CryptKeyList != null)
				{
					CryptKeyList = CryptKeyList.Replace("'", "\''");
				}

				if (RNG_employment != null)
				{
					RNG_employment = RNG_employment.Replace("'", "\''");
				}

				if (AppRNGFunc != null)
				{
					AppRNGFunc = AppRNGFunc.Replace("'", "\''");
				}

				if (nonAppRNGFunc != null)
				{
					nonAppRNGFunc = nonAppRNGFunc.Replace("'", "\''");
				}

				if (KeyGenSecurity != null)
				{
					KeyGenSecurity = KeyGenSecurity.Replace("'", "\''");
				}

				if (AppKeyEstab != null)
				{
					AppKeyEstab = AppKeyEstab.Replace("'", "\''");
				}

				if (KeyEstabSecurity != null)
				{
					KeyEstabSecurity = KeyEstabSecurity.Replace("'", "\''");
				}

				if (KeyEntryOutput != null)
				{
					KeyEntryOutput = KeyEntryOutput.Replace("'", "\''");
				}

				if (KeyGen != null)
				{
					KeyGen = KeyGen.Replace("'", "\''");
				}

				if (KeyEstablishment != null)
				{
					KeyEstablishment = KeyEstablishment.Replace("'", "\''");
				}

				if (KeyStorage != null)
				{
					KeyStorage = KeyStorage.Replace("'", "\''");
				}

				if (KeyZeroization != null)
				{
					KeyZeroization = KeyZeroization.Replace("'", "\''");
				}

				if (ManualKeyEntry != null)
				{
					ManualKeyEntry = ManualKeyEntry.Replace("'", "\''");
				}

				if (AutoKeyEntry != null)
				{
					AutoKeyEntry = AutoKeyEntry.Replace("'", "\''");
				}

				if (ManualKeyEntry_enc != null)
				{
					ManualKeyEntry_enc = ManualKeyEntry_enc.Replace("'", "\''");
				}

				if (ManualKeyEntry_spltKnlg != null)
				{
					ManualKeyEntry_spltKnlg = ManualKeyEntry_spltKnlg.Replace("'", "\''");
				}

				if (SplitKnowledge != null)
				{
					SplitKnowledge = SplitKnowledge.Replace("'", "\''");
				}				

				string TE070101_1 = "The tester verified that the vendor documentation describes the protection of its secret keys and CSPs." +
					" The documentation describes how these keys and CSPs are protected with logical and physical security mechanisms that" +
					" prevent unauthorized disclosure, unauthorized modification, and unauthorized substitution. These protections include:"
					+ Environment.NewLine + Environment.NewLine + CSPProtcStratg;

				string TE070102 = "Upon inspection of the module''s source code and review of proprietary and non-proprietary documentation," +
					" the tester attempted to circumvent documented access methods to the module''s secret keys, private keys, and CSPs and" +
					" concluded that the module denies access, thus meeting the intent of this requirement.";

				string TE070201_1 = "It was verified that vendor documentation describes how the public keys are protected from unauthorized" +
					" modification and unauthorized substitution:" + Environment.NewLine + Environment.NewLine + PubKeyProtect;

				string TE070202_1 = "Upon performing operational testing and inspection of the module’s source code and review of " +
					"proprietary and nonproprietary documentation, the tester identified the public keys entered into and stored within " +
					"the module as follows:" + Environment.NewLine + Environment.NewLine + PubKeyEntry +
					Environment.NewLine + Environment.NewLine + "The tester asserts that the public key cannot be substituted or modified " +
					"due to implemented protection mechanisms.  During operational testing, the tester modified one byte of the public keys " +
					"during the re-key process (e.g. RenewPKMCertService, RenewPKMService) and attempted to load them into the module. The " +
					"module indicated that the verification of the public key loading failed, and returned an error indicating that the " +
					"service failed.";

				string TE070301_1 = "The vendor documentation was reviewed and verified that it provided a list all cryptographic keys, " +
					"cryptographic key components, and CSPs used by the module:" + Environment.NewLine + Environment.NewLine + CryptKeyList;

				string AS0704 = "This assertion is tested in AS09.41-AS09.43.";
				string AS0705 = "There are no requirements for this assertion number.";
				string AS0706 = "This assertion is tested in AS09.13.";
				string AS0707 = "This assertion is not separately tested.";

				if (RNG_employment == "True")
				{
					TE070801 = "The tester verified by documentation review that the module generates cryptographic keys using its Approved" +
						" security functions." + Environment.NewLine + Environment.NewLine + AppRNGFunc;


					TE070802 = "The tester reviewed the vendor documentation and verified that the implemented RNG matches the " +
					"specified Approved RNG." + Environment.NewLine + Environment.NewLine + AppRNGFunc;

					TE070901 = "The tester verified that the vendor provided documentation shows how the seed and seed key cannot assume the " +
					"same value. The seed (" + SeedLength + " bits) and seed key (" + SeedKeyLength + " bits) are different lengths; " +
					"therefore it is impossible for them to assume the same value.";

					TE070902 = "The tester verified that the vendor provided documentation matches the implementation.";

					TE071001 = "The tester reviewed vendor documentation and verified that the information specified in VE.07.10.01 is " +
						"included. The module includes:" + Environment.NewLine + nonAppRNGFunc;		
				}
				else
				{
					TE070801 = "The tester verified by documentation review that the module does not use RNGs";
					TE070802 = TE070801;
					TE070901 = TE070801;
					TE070902 = TE070801;
					TE071001 = TE070801;
				}





				if (KeyGen == "True")
				{
					TE071101 = "The tester verified through review of vendor documentation that the cryptographic keys are generated by" +
					" an Approved DRBG as specified in SP 800-90. The output of the DRBG is used as keying material.";

					TE071102 = "The tester reviewed the vendor documentation and verified that the implemented key generation matches" +
					" the specified Approved key generation method.";

					TE071301 = "The tester verified that the vendor provided documentation provides rationale stating how compromising the" +
						" security of the key generation method (e.g., guessing the seed value to initialize the DRBG) shall require as " +
						"least as many operations as determining the value of the generated key." + Environment.NewLine + Environment.NewLine +
						"The vendor has provided documentation that explicitly details the architecture of the module's NDRNG. The NDRNG generates " + NoBitsGenNDRNG +
						" bits to provide a " + NoBitsEntropyInput + "-bit entropy input, and " + NoBitsNonce + " bits for the nonce, " + NoBitsAdditInput +
						" bits for the additional input, and " + NoBitsPersonalStr + " bits for the personalization string. This input is used to instantiate a "
						+ AlgDRBGDepends + " " + DRBG_Type + "-DRBG " + DerivFunc + ", which is used to produce a " + DRBGOutputLength + "-bit output. Based on the " +
						"vendor''s entropy claim and Penumbra''s assessment of the NDRNG output per " + StandardEntropy  + ", the output of the NDRNG is between "
						+ MinEntropy + " and " + MaxEntropy + " bits of entropy. The output of the DRBG is " + FullEntropyOutput + " entropic: " + DRBGOutputLength + " bit of entropy are " +
						"output. Guessing the values of the output of the " + DRBGOutputLength + "-bit DRBG requires 2^" + DRBGOutputLength + " operations. The " + NoBitsEntropyInput + 
						"-bit seed has at least " + MinEntropy + 
						" bits of entropy, therefore guessing the seed value requires 2^" + MinEntropy + " operations. " + Environment.NewLine +
						"Please refer to the Penumbra generated Entropy Rationale document provided with this FIPS 140-2 report submission for further details.";

					TE071301_txt = TE071301;

					TE071302 = "The tester determined the accuracy of the rationale provided by the vendor and agrees that compromising" +
					" the security of the key generation method (e.g., guessing the seed value to initialize the DRBG) will require as " +
					"least as many operations as determining the value of the generated key. Please refer to the Penumbra generated " +
					"Entropy Rationale document provided with this FIPS 140 - 2 report submission for further details.";


					AS0712 = "This assertion is tested as part of AS07.04-AS07.08 and AS07.10.";

					TE071301 = "It was verified that the vendor provided documentation indicates how compromising the security of the key " +
					"generation method requires at least as many operations as determining the value of the generated key." + Environment.NewLine +
					KeyGenSecurity;
							

					TE071601 = "The tester verified that the vendor provided documentation describes the key generation method. The" +
					" module implements an Approved DRBG in the key generation process. The output of the DRBG is used as key material. " +
					"Please see TE.07.11.01.";

					TE071602 = "The tester verified that the vendor provided documentation describes the key generation method. " +
					"The module implements an Approved DRBG in the key generation process. The output of the DRBG is used as key " +
					"material. Please see TE.07.11.01.";
				}
				else
				{
					TE071101 = "The module does not support key generation.";
					TE071102 = TE071101;
					TE071301 = TE071101;
					TE071302 = TE071101;
					TE071601 = TE071101;
					TE071602 = TE071101;
				}

				AS0712 = "This assertion is tested as part of AS07.04-AS07.08 and AS07.10.";
				string AS0714 = "This assertion is tested as part of AS07.23.";




				if (KeyEstablishment == "True")
				{	
					AS0715 = "No intermediate key or values are output from the module.";
					TE071501 = "No intermediate key or values are output from the module.";
					TE071502 = "No intermediate key or values are output from the module.";
					TE071503 = "No intermediate key or values are output from the module.";
					TE071504 = "No intermediate key or values are output from the module.";


					TE071601 = "The tester verified that the vendor provided documentation describes the key generation method. The" +
						" module implements an Approved DRBG in the key generation process. The output of the DRBG is used as key material. " +
						"Please see TE.07.11.01.";

					TE071602 = "The tester verified that the vendor provided documentation describes the key generation method. " +
						"The module implements an Approved DRBG in the key generation process. The output of the DRBG is used as key " +
						"material. Please see TE.07.11.01.";

					TE071701 = "The tester verified that the vendor provided documentation asserting that the key establishment techniques " +
						"used are found in Annex D of FIPS 140-2.  The module uses the following Approved key establishment techniques:" + 

					Environment.NewLine + AppKeyEstab;

					TE071702 = "The tester reviewed the vendor provided documentation and verified that the implemented key establishment " +
					"techniques match the specified key establishment techniques." + Environment.NewLine + AppKeyEstab;


			

					TE071801 = "The module is not a radio.";
					TE071802 = "The module is not a radio.";


					TE071901 = "The tester verified that the vendor provided documentation provides rationale stating how compromising the" +
					" security of the key establishment method requires as many operations as determining the value of the cryptographic" +
					" key being transported or agreed upon." + Environment.NewLine + Environment.NewLine + KeyEstabSecurity;

					TE071902 = "The tester verified that the rationale provided by the vendor is accurate.";

					TE072101 = "The tester verified that the vendor provided documentation asserting that the key establishment " +
					"techniques used are found in Annex D of FIPS 140-2.  The module implements the following:" + Environment.NewLine +
					AppKeyEstab;

					TE072102 = "The tester reviewed the vendor provided documentation and verified that the implemented key " +
						"establishment techniques match the specified Approved key establishment techniques.";
				}
				else
				{
					TE071701 = "The module does not support key establishment.";
					TE071702 = TE071701;
					TE071901 = TE071701;
					TE071902 = TE071701;
					TE072101 = TE071701;
					TE072102 = TE071701;
				}


				if (OTAR == "True")
				{
					TE071801 = "";
					TE071802 = "";
				}
				else
				{
					TE071801 = "The module is not a radio.";
					TE071802 = TE071801;
				}


				

				if (KeyEntryOutput == "True")
				{
					AS0715 = "";
					TE071501 = "";
					TE071502 = "";
					TE071503 = "";
					TE071504 = "";

					TE072301 = "";
					TE072302 = "";
					TE072401 = "The tester verified that the vendor supplied documentation specifies the Approved algorithm used to encrypt CSPs" +
						" entered into and output from the cryptographic module.";
					TE072402 = "The tester reviewed the vendor provided documentation and verified that the implemented Approved algorithm used" +
						" to encrypt CSPs entered into or output from the cryptographic module matches the specified encryption method.";
					TE072501 = "The tester reviewed the documented key entry/output procedures and verified that the procedures address how an " +
						"entered or output key is associated with the correct entity included.";
					TE072502 = "";
					TE072801 = "The tester reviewed the vendor provided documentation and verified that the key entry and output methods employed " +
						"by the module are specified.";

					if (AutoKeyEntry == "True")
					{
						TE072901 = "The tester verified that the vendor provided documentation asserts that secret and private keys established using" +
							" automated methods are entered into and output from the cryptographic module in encrypted form.";

						TE072902 = "The tester verified that the keys are entered into and output from the cryptographic module in encrypted form.";
					}
					else
					{
						TE072901 = TE072401;
						TE072902 = TE072401;
					}

					if (ManualKeyEntry == "True")
					{
						TE072701 = "The tester reviewed the documented key entry procedures and verified that the display of plaintext keys resulting" +
							" from the entry of encrypted keys or key components is not allowed during the key entry process.";

						TE072702 = "The tester entered all encrypted cryptographic keys and key components and monitored the output interface of the" +
							" module and verified that any resulting plaintext key material is not displayed.";

						TE072802 = "The tester entered and outputted each of the manually entered keys and verified that they are entered and/or outputted" +
							"according to the documentation.";
					}
					else
					{
						TE072701 = "The module does not support manual key entry.";
						TE072702 = TE072701;
						TE072802 = TE072701;
					}

				}
				else
				{
					AS0715 = "No intermediate key or values are output from the module.";
					TE071501 = AS0715;
					TE071502 = AS0715;
					TE071503 = AS0715;
					TE071504 = AS0715;

					TE072301 = "The module does not support the entry of seed keys.";
					TE072302 = TE072301;
					TE072401 = "The module does not support the entry or output of keys.";
					TE072402 = TE072401;
					TE072501 = TE072401;
					TE072502 = TE072401;
					TE072801 = TE072401;

				}

				string AS0726 = "This assertion is tested as part of AS09.40.";
				string AS0737 = "This assertion is tested under AS07.40.";
				string AS0738 = "This assertion is tested under AS07.01.";
				string TE073901;
				string TE073902;
				string TE074001;
				string TE074101;
				string TE074102;
				string TE074103;
				string TE074104;
				string AS0742 = "This assertion is tested under AS07.41.";

				if (KeyStorage == "True")
				{
					TE073901 = "The tester reviewed the documentation on key storage and verified that the procedures address how a stored key is " +
						"associated with the correct entity.";

					TE073902 = "The tester altered the association of key and entity and then attempted to perform cryptographic functions as one of " +
						"the entities and verified that these functions failed.";

					TE074001 = "The tester reviewed the vendor documentation and verified that the information specified in VE07.40.01 is included.";
				}
				else
				{
					TE073901 = "The module does not support key storage.";
					TE073902 = TE073901;
					TE074001 = TE073901;
				}


				if (KeyZeroization == "True")
				{
					TE074101 = "The tester reviewed the vendor documentation and verified that the information specified in VE07.41.01 is included." +
						" The tester determined the accuracy of any rationale provided by the vendor.";

					TE074102 = "The tester noted which keys are present in the module and initiate the zeroize command. Following the completion of the " +
						"zeroize command, the tester attempted to perform cryptographic operations using each of the plaintext secret and private " +
						"cryptographic keys and CSPs that were stored in the module. The tester verified that each plaintext secret and private " +
						"cryptographic keys and CSPs cannot be accessed.";

					TE074103 = "During operational testing, the tester initiated zeroization and verified that the key destruction method was performed " +
						"in a time that was insufficient for an attacker to access plaintext secret and private cryptographic keys and other unprotected " +
						"CSPs. Zeroization was performed in less than one second.";

					TE074104 = "The tester verified that the module zeroizes all plaintext CSPs contained within the module.";
				}
				else
				{
					TE074101 = "N/A";
					TE074102 = TE074101;
					TE074103 = TE074101;
					TE074104 = TE074101;
				}

				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE070101_1 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 1 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE070102 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 1 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE070201_1 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 2 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE070202_1 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 2 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE070301_1 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 3 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0704 + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 4 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0705 + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 5 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0704   + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 4 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0705   + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 5 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0706 + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 6 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0707 + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 7 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE070801 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 8 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE070802 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 8 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE070901 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 9 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071001 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 10 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE070902 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 9 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071101 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 11 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071102 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 11 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0712 + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 12 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071301 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 13 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071302 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 13 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0714 + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 14 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0715 + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 15 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071501 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 15 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071502 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 15 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071503 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 15 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071504 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 15 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071701 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 17 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071702 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 17 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071901 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 19 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071601 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 16 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071602 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 16 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071801 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 18 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071802 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 18 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE071902 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 19 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0720 + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 20 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE072102 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 21 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0722 + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 22 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE072301 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 23 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE072302 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 23 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE072401 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 24 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE072402 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 24 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE072501 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 25 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE072502 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 25 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0726 + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 26 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE072701 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 27 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE072702 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 27 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE072801 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 28 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE072802 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 28 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE072901 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 29 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE072902 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 29 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0737   + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 37 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0738   + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 38 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE073901 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 39 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE073902 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 39 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE074001 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 40 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE074101 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 41 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE074102 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 41 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE074103 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 41 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE074104 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 41 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0742   + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 42 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}


		public void populateKeyManagementLevel34()
		{
			// start writing assertions for Level 1,2,3,4
			try
			{
				connection.Open();
				command.Connection = connection;

				CSPProtcStratg = CSPProtcStratg.Replace("'", "\''");
				PubKeyProtect = PubKeyProtect.Replace("'", "\''");
				PubKeyEntry = PubKeyEntry.Replace("'", "\''");
				CryptKeyList = CryptKeyList.Replace("'", "\''");
				RNG_employment = RNG_employment.Replace("'", "\''");
				AppRNGFunc = AppRNGFunc.Replace("'", "\''");
				nonAppRNGFunc = nonAppRNGFunc.Replace("'", "\''");
				KeyGenSecurity = KeyGenSecurity.Replace("'", "\''");
				AppKeyEstab = AppKeyEstab.Replace("'", "\''");
				KeyEstabSecurity = KeyEstabSecurity.Replace("'", "\''");
				KeyEntryOutput = KeyEntryOutput.Replace("'", "\''");
				KeyGen = KeyGen.Replace("'", "\''");
				KeyEstablishment = KeyEstablishment.Replace("'", "\''");
				KeyStorage = KeyStorage.Replace("'", "\''");
				KeyZeroization = KeyZeroization.Replace("'", "\''");
				ManualKeyEntry = ManualKeyEntry.Replace("'", "\''");
				AutoKeyEntry = AutoKeyEntry.Replace("'", "\''");
				ManualKeyEntry_enc = ManualKeyEntry_enc.Replace("'", "\''");
				ManualKeyEntry_spltKnlg = ManualKeyEntry_spltKnlg.Replace("'", "\''");
				SplitKnowledge = SplitKnowledge.Replace("'", "\''");


				string AS0730;
				string TE073101 = "Verification of the vendor documentation was performed under TE07.27.01.";
				string TE073102;
				string TE073103;
				string TE073104;
				string TE073201;
				string TE073202;
				string TE073203;
				string AS0733;
				string TE073401;
				string TE073402;
				string TE073501;
				string TE073502;
				string TE073601;

				AS0733 = "This assertion is tested as part of AS02.18.";

				if (KeyEntryOutput == "True")
				{
					if (AutoKeyEntry == "True")
					{
						AS0730 = "This assertion is tested as part of AS07.29.";
					}
					else
					{
						AS0730 = "N/A";
					}

					string automatedMethod = "";
					if (ManualKeyEntry_enc == "True")
					{
						automatedMethod = "In encrypted form";
					}

					if (ManualKeyEntry_spltKnlg == "True")
					{
						automatedMethod = "Using split knowldege procedures";
					}
					TE073101 = "Verification of the vendor documentation was performed under TE07.27.01.";
					TE073102 = "The tester verified that the vendor has provided documentation asserting that secret and private keys established" +
						" using manual methods are entered into or output from the cryptographic module:" + Environment.NewLine + automatedMethod;

					TE073103 = "The tester verified that the established keys are entered into the cryptographic module:" + Environment.NewLine + 
						automatedMethod;

					TE073104 = "The tester verified that the established keys are output from the cryptographic module:" + Environment.NewLine +
						automatedMethod;

					if (SplitKnowledge == "True")
					{
						TE073201 = "The tester checked that authentication is performed for each key component and that the authentication is in" +
							" accordance with the documented key entry and output procedures.";

						TE073202 = "The tester entered each key component using split knowledge procedures and verified that each operator entering" +
							" a key component is authenticated.";

						TE073203 = "The tester outputted each key component using split knowledge procedures and verified that each operator outputting" +
							" a key component is authenticated.";

						TE073401 = "The tester reviewed the vendor documentation and verified that the entry of manually established secret or private" +
							" keys entered under split knowledge procedures requires at least two components to construct the original key.";

						TE073402 = "The tester reviewed the vendor documentation and verified that the output of manually establishment secret or private" +
							" keys output under split knowledge procedures does not result in the output of a single key component that can be used to" +
							" construct the original key.";

						TE073501 = "The tester verified that the vendor provided documentation provides rationale stating if n key components are required" +
							" to construct the original key, then knowledge of any n–1 key components provides no information about the original key " +
							"other than the length.";

						TE073502 = "The tester determined the accuracy of any rationale provided by the vendor.";

						TE073601 = "The tester verified that the documentation matches the implementation.";
					}
					else
					{
						TE073201 = "N/A";
						TE073202 = TE073201;
						TE073203 = TE073201;
						TE073401 = TE073201;
						TE073402 = TE073201;
						TE073501 = TE073201;
						TE073502 = TE073201;
						TE073601 = TE073201;
					}
				}				
				else
				{
					AS0730   = "The module does not support the entry or output of keys.";
					TE073101 = "The module does not support the entry or output of keys.";
					TE073102 = TE073101;
					TE073103 = TE073101;
					TE073104 = TE073101;
					TE073201 = TE073101;
					TE073202 = TE073101;
					TE073203 = TE073101;
					TE073401 = TE073101;
					TE073402 = TE073101;
					TE073501 = TE073101;
					TE073502 = TE073101;
					TE073601 = TE073101;				
				}

				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0730   + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 30 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE073101 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 31 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE073102 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 31 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE073103 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 31 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE073104 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 31 + "  and SequenceNo = " + 4 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE073201 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 32 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE073202 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 32 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE073203 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 32 + "  and SequenceNo = " + 3 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + AS0733   + "'  WHERE VendorTester = 'AS' and Section = " + 7 + " and Requirement = " + 33 + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE073401 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 34 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE073402 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 34 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE073501 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 35 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE073502 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 35 + "  and SequenceNo = " + 2 + " and SubSeq = " + 0 + " ";
				command.ExecuteNonQuery();
				command.CommandText = "UPDATE ValidationInfo SET Assessment='" + TE073601 + "'  WHERE VendorTester = 'TE' and Section = " + 7 + " and Requirement = " + 36 + "  and SequenceNo = " + 1 + " and SubSeq = " + 0 + " ";
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


