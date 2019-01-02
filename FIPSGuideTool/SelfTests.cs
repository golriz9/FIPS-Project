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

namespace FIPSGuideTool
{
	public partial class SelfTests : Form
	{
		public static string GenPublicPrivateKeys;
		public static string AlgOutputVaries;
		public static string AsymAlg;
		public static string MessageDigestAlg;
		public static string IndpendImplementation;
		public static string KAT_TE092001;
		public static string CAT_TE092001;
		public static string ApprAuthenTech;
		public static string EDC;
		public static string txt_ApprovedTechnique;
		public static string txt_EDC;
		public static string DAC;
		//public static string DSA;
		public static string CriticalFunctions;
		public static string CalcVerifDSA;
		public static string SWFWLoad;
		public static string txt_ApprTechSWFWLoad;
		public static string ManualKeyEntry;
		public static string DuplicateEntry_KeyEntry;
		public static string EDC_KeyEntry;
		public static string RNG2;
		public static string RNG_Block_GT15;
		public static string RNG_Block_LT16;

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

		// AES Modes 
		public static string AES_ECB;
		public static string AES_CBC;
		public static string AES_OFB;
		public static string AES_CFB;
		public static string AES_CTR;
			   		 
		// AES Key Lengths
		public static string AES_ECB_128;
		public static string AES_ECB_192;
		public static string AES_ECB_256;
		public static string AES_ECB_128_En;
		public static string AES_ECB_128_De;
		public static string AES_ECB_192_En;
		public static string AES_ECB_192_De;
		public static string AES_ECB_256_En;
		public static string AES_ECB_256_De;


		public static string AES_CFB1_128;
		public static string AES_CFB1_192;
		public static string AES_CFB1_256;
		public static string AES_CFB1_128_En;
		public static string AES_CFB1_128_De;
		public static string AES_CFB1_192_En;
		public static string AES_CFB1_192_De;
		public static string AES_CFB1_256_En;
		public static string AES_CFB1_256_De;
		public static string AES_CFB8_128;
		public static string AES_CFB8_192;
		public static string AES_CFB8_256;
		public static string AES_CFB8_128_En;
		public static string AES_CFB8_128_De;
		public static string AES_CFB8_192_En;
		public static string AES_CFB8_192_De;
		public static string AES_CFB8_256_En;
		public static string AES_CFB8_256_De;
		public static string AES_CFB128_128;
		public static string AES_CFB128_192;
		public static string AES_CFB128_256;
		public static string AES_CFB128_128_En;
		public static string AES_CFB128_128_De;
		public static string AES_CFB128_192_En;
		public static string AES_CFB128_192_De;
		public static string AES_CFB128_256_En;
		public static string AES_CFB128_256_De;


		public static string AES_CBC_128;
		public static string AES_CBC_192;
		public static string AES_CBC_256;
		public static string AES_CBC_128_En;
		public static string AES_CBC_128_De;
		public static string AES_CBC_192_En;
		public static string AES_CBC_192_De;
		public static string AES_CBC_256_En;
		public static string AES_CBC_256_De;

		public static string AES_OFB_128;
		public static string AES_OFB_192;
		public static string AES_OFB_256;
		public static string AES_OFB_128_En;
		public static string AES_OFB_128_De;
		public static string AES_OFB_192_En;
		public static string AES_OFB_192_De;
		public static string AES_OFB_256_En;
		public static string AES_OFB_256_De;

		public static string AES_CTR_128;
		public static string AES_CTR_192;
		public static string AES_CTR_256;
		public static string AES_CTR_128_En;
		public static string AES_CTR_192_En;
		public static string AES_CTR_256_En;


		public static string SHA1;
		public static string SHA224;
		public static string SHA256;
		public static string SHA384;
		public static string SHA512;
		public static string SHA512_224;
		public static string SHA512_256;

		public static string GCM_en;
		public static string GCM_de;
		public static string GCM128;
		public static string GCM192;
		public static string GCM256;
		public static string GCM32_tag;
		public static string GCM64_tag;
		public static string GCM96_tag;
		public static string GCM104_tag;
		public static string GCM112_tag;
		public static string GCM120_tag;
		public static string GCM128_tag;

		public static string XTS128;
		public static string XTS128_En;
		public static string XTS128_De;
		public static string XTS256;
		public static string XTS256_En;
		public static string XTS256_De;

		// TDES Modes 
		public static string TDES_ECB;
		public static string TDES_CBC;
		public static string TDES_OFB;
		public static string TDES_CFB;
		public static string TDES_CTR;

		// TDES Key Lengths
		public static string TDES_ECB_En;
		public static string TDES_ECB_De;

		public static string TDES_CBC_En;
		public static string TDES_CBC_De;

		public static string TDES_OFB_En;
		public static string TDES_OFB_De;

		public static string TDES_CTR_En;

		public static string TDES_CFB_1;
		public static string TDES_CFB_1_En;
		public static string TDES_CFB_1_De;
		public static string TDES_CFB_8;
		public static string TDES_CFB_8_En;
		public static string TDES_CFB_8_De;
		public static string TDES_CFB_64;
		public static string TDES_CFB_64_En;
		public static string TDES_CFB_64_De;

		public static string TDES_CFB_P_1;
		public static string TDES_CFB_P_1_En;
		public static string TDES_CFB_P_1_De;
		public static string TDES_CFB_P_8;
		public static string TDES_CFB_P_8_En;
		public static string TDES_CFB_P_8_De;
		public static string TDES_CFB_P_64;
		public static string TDES_CFB_P_64_En;
		public static string TDES_CFB_P_64_De;


		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();
		OleDbDataReader dataSearch;
		DataTable DT = new DataTable();

		public static int VectorLength = 1000;
		string[] VendorTesterAll = new string[VectorLength];
		string[] AssessmentAll = new string[VectorLength];
		string[] Section = new string[VectorLength];
		string[] RequirementAll = new string[VectorLength];
		string[] SequenceNoAll = new string[VectorLength];
		//int NoAlgs;

		public SelfTests()
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

			AES_ECB = Properties.Settings.Default.ECB.ToString();
			AES_CBC = Properties.Settings.Default.CBC.ToString();
			AES_OFB = Properties.Settings.Default.OFB.ToString();
			AES_CFB = Properties.Settings.Default.CFB.ToString();
			AES_CTR = Properties.Settings.Default.CTR.ToString();

			AES_ECB_128 = Properties.Settings.Default.ECB_128.ToString();
			AES_ECB_192 = Properties.Settings.Default.ECB_192.ToString();
			AES_ECB_256 = Properties.Settings.Default.ECB_256.ToString();
			AES_ECB_128_En = Properties.Settings.Default.ECB_128_En.ToString();
			AES_ECB_128_De = Properties.Settings.Default.ECB_128_De.ToString();
			AES_ECB_192_En = Properties.Settings.Default.ECB_192_En.ToString();
			AES_ECB_192_De = Properties.Settings.Default.ECB_192_De.ToString();
			AES_ECB_256_En = Properties.Settings.Default.ECB_256_En.ToString();
			AES_ECB_256_De = Properties.Settings.Default.ECB_256_De.ToString();

			AES_CFB1_128 = Properties.Settings.Default.CFB1_128.ToString();
			AES_CFB1_192 = Properties.Settings.Default.CFB1_192.ToString();
			AES_CFB1_256 = Properties.Settings.Default.CFB1_256.ToString();
			AES_CFB1_128_En = Properties.Settings.Default.CFB1_128_En.ToString();
			AES_CFB1_128_De = Properties.Settings.Default.CFB1_128_De.ToString();
			AES_CFB1_192_En = Properties.Settings.Default.CFB1_192_En.ToString();
			AES_CFB1_192_De = Properties.Settings.Default.CFB1_192_De.ToString();
			AES_CFB1_256_En = Properties.Settings.Default.CFB1_256_En.ToString();
			AES_CFB1_256_De = Properties.Settings.Default.CFB1_256_De.ToString();

			AES_CFB8_128 = Properties.Settings.Default.CFB8_128.ToString();
			AES_CFB8_192 = Properties.Settings.Default.CFB8_192.ToString();
			AES_CFB8_256 = Properties.Settings.Default.CFB8_256.ToString();
			AES_CFB8_128_En = Properties.Settings.Default.CFB8_128_En.ToString();
			AES_CFB8_128_De = Properties.Settings.Default.CFB8_128_De.ToString();
			AES_CFB8_192_En = Properties.Settings.Default.CFB8_192_En.ToString();
			AES_CFB8_192_De = Properties.Settings.Default.CFB8_192_De.ToString();
			AES_CFB8_256_En = Properties.Settings.Default.CFB8_256_En.ToString();
			AES_CFB8_256_De = Properties.Settings.Default.CFB8_256_De.ToString();

			AES_CFB128_128 = Properties.Settings.Default.CFB128_128.ToString();
			AES_CFB128_192 = Properties.Settings.Default.CFB128_192.ToString();
			AES_CFB128_256 = Properties.Settings.Default.CFB128_256.ToString();
			AES_CFB128_128_En = Properties.Settings.Default.CFB128_128_En.ToString();
			AES_CFB128_128_De = Properties.Settings.Default.CFB128_128_De.ToString();
			AES_CFB128_192_En = Properties.Settings.Default.CFB128_192_En.ToString();
			AES_CFB128_192_De = Properties.Settings.Default.CFB128_192_De.ToString();
			AES_CFB128_256_En = Properties.Settings.Default.CFB128_256_En.ToString();
			AES_CFB128_256_De = Properties.Settings.Default.CFB128_256_De.ToString();

			AES_CBC_128 = Properties.Settings.Default.CBC_128.ToString();
			AES_CBC_192 = Properties.Settings.Default.CBC_192.ToString();
			AES_CBC_256 = Properties.Settings.Default.CBC_256.ToString();
			AES_CBC_128_En = Properties.Settings.Default.CBC_128_En.ToString();
			AES_CBC_128_De = Properties.Settings.Default.CBC_128_De.ToString();
			AES_CBC_192_En = Properties.Settings.Default.CBC_192_En.ToString();
			AES_CBC_192_De = Properties.Settings.Default.CBC_192_De.ToString();
			AES_CBC_256_En = Properties.Settings.Default.CBC_256_En.ToString();
			AES_CBC_256_De = Properties.Settings.Default.CBC_256_De.ToString();


			AES_OFB_128 = Properties.Settings.Default.OFB_128.ToString();
			AES_OFB_192 = Properties.Settings.Default.OFB_192.ToString();
			AES_OFB_256 = Properties.Settings.Default.OFB_256.ToString();
			AES_OFB_128_En = Properties.Settings.Default.OFB_128_En.ToString();
			AES_OFB_128_De = Properties.Settings.Default.OFB_128_De.ToString();
			AES_OFB_192_En = Properties.Settings.Default.OFB_192_En.ToString();
			AES_OFB_192_De = Properties.Settings.Default.OFB_192_De.ToString();
			AES_OFB_256_En = Properties.Settings.Default.OFB_256_En.ToString();
			AES_OFB_256_De = Properties.Settings.Default.OFB_256_De.ToString();

			AES_CTR_128 = Properties.Settings.Default.CBC_128.ToString();
			AES_CTR_192 = Properties.Settings.Default.CBC_192.ToString();
			AES_CTR_256 = Properties.Settings.Default.CBC_256.ToString();
			AES_CTR_128_En = Properties.Settings.Default.CBC_128_En.ToString();
			AES_CTR_192_En = Properties.Settings.Default.CBC_192_En.ToString();
			AES_CTR_256_En = Properties.Settings.Default.CBC_256_En.ToString();

			TDES_ECB = Properties.Settings.Default.TDES_ECB.ToString();
			TDES_CBC = Properties.Settings.Default.TDES_CBC.ToString();
			TDES_OFB = Properties.Settings.Default.TDES_OFB.ToString();
			TDES_CFB = Properties.Settings.Default.TDES_CFB.ToString();
			TDES_CTR = Properties.Settings.Default.TDES_CTR.ToString();

			TDES_ECB_En = Properties.Settings.Default.TDES_ECB_En.ToString();
			TDES_ECB_De = Properties.Settings.Default.TDES_ECB_De.ToString();

			TDES_CBC_En = Properties.Settings.Default.TDES_CBC_En.ToString();
			TDES_CBC_De = Properties.Settings.Default.TDES_CBC_De.ToString();

			TDES_OFB_De = Properties.Settings.Default.TDES_OFB_De.ToString();
			TDES_OFB_En = Properties.Settings.Default.TDES_OFB_En.ToString();

			TDES_CTR_En = Properties.Settings.Default.TDES_CTR_En.ToString();

			TDES_CFB_1 = Properties.Settings.Default.TDES_CFB_1.ToString();
			TDES_CFB_1_En = Properties.Settings.Default.TDES_CFB_1_En.ToString();
			TDES_CFB_1_De = Properties.Settings.Default.TDES_CFB_1_De.ToString();
			TDES_CFB_8 = Properties.Settings.Default.TDES_CFB_8.ToString();
			TDES_CFB_8_En = Properties.Settings.Default.TDES_CFB_8_En.ToString();
			TDES_CFB_8_De = Properties.Settings.Default.TDES_CFB_8_De.ToString();
			TDES_CFB_64 = Properties.Settings.Default.TDES_CFB_64.ToString();
			TDES_CFB_64_En = Properties.Settings.Default.TDES_CFB_64_En.ToString();
			TDES_CFB_64_De = Properties.Settings.Default.TDES_CFB_64_De.ToString();

			TDES_CFB_P_1 = Properties.Settings.Default.TDES_CFB_P_1.ToString();
			TDES_CFB_P_1_En = Properties.Settings.Default.TDES_CFB_P_1_En.ToString();
			TDES_CFB_P_1_De = Properties.Settings.Default.TDES_CFB_P_1_De.ToString();
			TDES_CFB_P_8 = Properties.Settings.Default.TDES_CFB_P_8.ToString();
			TDES_CFB_P_8_En = Properties.Settings.Default.TDES_CFB_P_8_En.ToString();
			TDES_CFB_P_8_De = Properties.Settings.Default.TDES_CFB_P_8_De.ToString();
			TDES_CFB_P_64 = Properties.Settings.Default.TDES_CFB_P_64.ToString();
			TDES_CFB_P_64_En = Properties.Settings.Default.TDES_CFB_P_64_En.ToString();
			TDES_CFB_P_64_De = Properties.Settings.Default.TDES_CFB_P_64_De.ToString();

			SHA1 = Properties.Settings.Default.SHA1.ToString();
			SHA224 = Properties.Settings.Default.SHA224.ToString();
			SHA256 = Properties.Settings.Default.SHA256.ToString();
			SHA384 = Properties.Settings.Default.SHA384.ToString();
			SHA512 = Properties.Settings.Default.SHA512.ToString();
			SHA512_224 = Properties.Settings.Default.SHA512_224.ToString();
			SHA512_256 = Properties.Settings.Default.SHA512_256.ToString();

			GCM_en = Properties.Settings.Default.GCM_en.ToString();
			GCM_de = Properties.Settings.Default.GCM_de.ToString();
			GCM128 = Properties.Settings.Default.GCM128.ToString();
			GCM192 = Properties.Settings.Default.GCM192.ToString();
			GCM256 = Properties.Settings.Default.GCM256.ToString();
			GCM32_tag = Properties.Settings.Default.GCM32_tag.ToString();
			GCM64_tag = Properties.Settings.Default.GCM64_tag.ToString();
			GCM96_tag = Properties.Settings.Default.GCM96_tag.ToString();
			GCM104_tag = Properties.Settings.Default.GCM104_tag.ToString();
			GCM112_tag = Properties.Settings.Default.GCM112_tag.ToString();
			GCM120_tag = Properties.Settings.Default.GCM120_tag.ToString();
			GCM128_tag = Properties.Settings.Default.GCM128_tag.ToString();

			XTS128 = Properties.Settings.Default.XTS128.ToString();
			XTS128_En = Properties.Settings.Default.XTS128_En.ToString();
			XTS128_De = Properties.Settings.Default.XTS128_De.ToString();
			XTS256 = Properties.Settings.Default.XTS256.ToString();
			XTS256_En = Properties.Settings.Default.XTS256_En.ToString();
			XTS256_De = Properties.Settings.Default.XTS256_De.ToString();
		}		

		private void SelfTests_Load(object sender, EventArgs e)
		{
			// add columns
			DT.Columns.Add("Algorithm", typeof(string));
			DT.Columns.Add(" ", System.Type.GetType("System.Boolean"));
			DT.Columns.Add("Mode", typeof(string));
			DT.Columns.Add("Key Lengths, Curves or Moduli", typeof(string));
			DT.Columns.Add("  ", System.Type.GetType("System.Boolean"));			
			DT.Columns.Add("Known Answer Test Type", typeof(string));			
			//DT.Columns.Add("Error Cause", typeof(string));
			//DT.Columns.Add("Error State", typeof(string));
			//DT.Columns.Add("Error Indicator", typeof(string));
			//DT.Columns.Add("Error Resolution", typeof(string));
			//DT.Columns.Add("Test Notes", typeof(string));
			

			if (AES == "True" && AES_ECB == "True" && AES_ECB_128 == "True")
			{		
				DT.Rows.Add("AES", false, "ECB", "128", false, "Encryption");				
			}

			if (AES == "True" && AES_ECB == "True" && AES_ECB_128 == "True")
			{
				DT.Rows.Add("AES", false, "ECB", "128", false, "Decryption");
			}

			if (AES == "True" && AES_ECB == "True" && AES_ECB_192 == "True")
			{
				DT.Rows.Add("AES", false, "ECB", "192", false, "Encryption");
			}

			if (AES == "True" && AES_ECB == "True" && AES_ECB_192 == "True")
			{
				DT.Rows.Add("AES", false, "ECB", "192", false, "Decryption");
			}

			if (AES == "True" && AES_ECB == "True" && AES_ECB_256 == "True")
			{
				DT.Rows.Add("AES", false, "ECB", "256", false, "Encryption");
			}

			if (AES == "True" && AES_ECB == "True" && AES_ECB_256 == "True")
			{
				DT.Rows.Add("AES", false, "ECB", "256", false, "Decryption");
			}


			if (AES == "True" && AES_CBC == "True" && AES_CBC_128 == "True")
			{
				DT.Rows.Add("AES", false, "CBC", "128", false, "Encryption");
			}

			if (AES == "True" && AES_CBC == "True" && AES_CBC_128 == "True")
			{
				DT.Rows.Add("AES", false, "CBC", "128", false, "Decryption");
			}

			if (AES == "True" && AES_CBC == "True" && AES_CBC_192 == "True")
			{
				DT.Rows.Add("AES", false, "CBC", "192", false, "Encryption");
			}

			if (AES == "True" && AES_CBC == "True" && AES_CBC_192 == "True")
			{
				DT.Rows.Add("AES", false, "CBC", "192", false, "Decryption");
			}

			if (AES == "True" && AES_CBC == "True" && AES_CBC_256 == "True")
			{
				DT.Rows.Add("AES", false, "CBC", "256", false, "Encryption");
			}

			if (AES == "True" && AES_CBC == "True" && AES_CBC_256 == "True")
			{
				DT.Rows.Add("AES", false, "CBC", "256", false, "Decryption");
			}


			if (AES == "True" && AES_CFB == "True" && AES_CFB1_128 == "True")
			{
				DT.Rows.Add("AES", false, "CFB1", "128", false, "Encryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB1_128 == "True")
			{
				DT.Rows.Add("AES", false, "CFB1", "128", false, "Decryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB1_192 == "True")
			{
				DT.Rows.Add("AES", false, "CFB1", "192", false, "Encryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB1_192 == "True")
			{
				DT.Rows.Add("AES", false, "CFB1", "192", false, "Decryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB1_256 == "True")
			{
				DT.Rows.Add("AES", false, "CFB1", "256", false, "Encryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB1_256 == "True")
			{
				DT.Rows.Add("AES", false, "CFB1", "256", false, "Decryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB8_128 == "True")
			{
				DT.Rows.Add("AES", false, "CFB8", "128", false, "Encryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB8_128 == "True")
			{
				DT.Rows.Add("AES", false, "CFB8", "128", false, "Decryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB8_192 == "True")
			{
				DT.Rows.Add("AES", false, "CFB8", "192", false, "Encryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB8_192 == "True")
			{
				DT.Rows.Add("AES", false, "CFB8", "192", false, "Decryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB8_256 == "True")
			{
				DT.Rows.Add("AES", false, "CFB8", "256", false, "Encryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB8_256 == "True")
			{
				DT.Rows.Add("AES", false, "CFB8", "256", false, "Decryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB128_128 == "True")
			{
				DT.Rows.Add("AES", false, "CFB128", "128", false, "Encryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB128_128 == "True")
			{
				DT.Rows.Add("AES", false, "CFB128", "128", false, "Decryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB128_192 == "True")
			{
				DT.Rows.Add("AES", false, "CFB128", "192", false, "Encryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB128_192 == "True")
			{
				DT.Rows.Add("AES", false, "CFB128", "192", false, "Decryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB128_256 == "True")
			{
				DT.Rows.Add("AES", false, "CFB128", "256", false, "Encryption");
			}

			if (AES == "True" && AES_CFB == "True" && AES_CFB128_256 == "True")
			{
				DT.Rows.Add("AES", false, "CFB128", "256", false, "Decryption");
			}

			if (AES == "True" && AES_OFB == "True" && AES_OFB_128 == "True")
			{
				DT.Rows.Add("AES", false, "OFB", "128", false, "Encryption");
			}

			if (AES == "True" && AES_OFB == "True" && AES_OFB_128 == "True")
			{
				DT.Rows.Add("AES", false, "OFB", "128", false, "Decryption");
			}

			if (AES == "True" && AES_OFB == "True" && AES_OFB_192 == "True")
			{
				DT.Rows.Add("AES", false, "OFB", "192", false, "Encryption");
			}

			if (AES == "True" && AES_OFB == "True" && AES_OFB_192 == "True")
			{
				DT.Rows.Add("AES", false, "OFB", "192", false, "Decryption");
			}

			if (AES == "True" && AES_OFB == "True" && AES_OFB_256 == "True")
			{
				DT.Rows.Add("AES", false, "OFB", "256", false, "Encryption");
			}

			if (AES == "True" && AES_OFB == "True" && AES_OFB_256 == "True")
			{
				DT.Rows.Add("AES", false, "OFB", "256", false, "Decryption");
			}

			if (AES == "True" && AES_CTR == "True" && AES_CTR_128 == "True")
			{
				DT.Rows.Add("AES", false, "CTR", "128", false, "Encryption");
			}

			if (AES == "True" && AES_CTR == "True" && AES_CTR_192 == "True")
			{
				DT.Rows.Add("AES", false, "CTR", "192", false, "Encryption");
			}

			if (AES == "True" && AES_CTR == "True" && AES_CTR_256 == "True")
			{
				DT.Rows.Add("AES", false, "CTR", "256", false, "Encryption");
			}

			// TDES
			if (TDES == "True" && TDES_ECB == "True")
			{
				DT.Rows.Add("TDES", false, "ECB", "", false, "Encryption");
			}

			if (TDES == "True" && TDES_ECB == "True")
			{
				DT.Rows.Add("TDES", false, "ECB", "", false, "Decryption");
			}

			if (TDES == "True" && TDES_CBC == "True")
			{
				DT.Rows.Add("TDES", false, "CBC", "", false, "Encryption");
			}

			if (TDES == "True" && TDES_CBC == "True")
			{
				DT.Rows.Add("TDES", false, "CBC", "", false, "Decryption");
			}

			if (TDES == "True" && TDES_CFB == "True" && TDES_CFB_1 == "True")
			{
				DT.Rows.Add("TDES", false, "CFB", "1", false, "Encryption");
			}

			if (TDES == "True" && TDES_CFB == "True" && TDES_CFB_1 == "True")
			{
				DT.Rows.Add("TDES", false, "CFB", "1", false, "Decryption");
			}

			if (TDES == "True" && TDES_CFB == "True" && TDES_CFB_8 == "True")
			{
				DT.Rows.Add("TDES", false, "CFB", "8", false, "Encryption");
			}

			if (TDES == "True" && TDES_CFB == "True" && TDES_CFB_8 == "True")
			{
				DT.Rows.Add("TDES", false, "CFB", "8", false, "Decryption");
			}

			if (TDES == "True" && TDES_CFB == "True" && TDES_CFB_64 == "True")
			{
				DT.Rows.Add("TDES", false, "CFB", "64", false, "Encryption");
			}

			if (TDES == "True" && TDES_CFB == "True" && TDES_CFB_64 == "True")
			{
				DT.Rows.Add("TDES", false, "CFB", "64", false, "Decryption");
			}
					   			 		  
			if (TDES == "True" && TDES_CFB == "True" && TDES_CFB_P_1 == "True")
			{
				DT.Rows.Add("TDES", false, "CFB-P", "1", false, "Encryption");
			}

			if (TDES == "True" && TDES_CFB == "True" && TDES_CFB_P_1 == "True")
			{
				DT.Rows.Add("TDES", false, "CFB-P", "1", false, "Decryption");
			}

			if (TDES == "True" && TDES_CFB == "True" && TDES_CFB_P_8 == "True")
			{
				DT.Rows.Add("TDES", false, "CFB-P", "8", false, "Encryption");
			}

			if (TDES == "True" && TDES_CFB == "True" && TDES_CFB_P_8 == "True")
			{
				DT.Rows.Add("TDES", false, "CFB-P", "8", false, "Decryption");
			}

			if (TDES == "True" && TDES_CFB == "True" && TDES_CFB_P_64 == "True")
			{
				DT.Rows.Add("TDES", false, "CFB-P", "64", false, "Encryption");
			}

			if (TDES == "True" && TDES_CFB == "True" && TDES_CFB_P_64 == "True")
			{
				DT.Rows.Add("TDES", false, "CFB-P", "64", false, "Decryption");
			}

			if (TDES == "True" && TDES_OFB == "True")
			{
				DT.Rows.Add("TDES", false, "OFB", "", false, "Encryption");
			}

			if (TDES == "True" && TDES_OFB == "True")
			{
				DT.Rows.Add("TDES", false, "OFB", "", false, "Decryption");
			}

			if (TDES == "True" && TDES_CTR == "True")
			{
				DT.Rows.Add("TDES", false, "CTR", "", false, "Encryption");
			}

			//
			if (CCM == "True")
			{
				DT.Rows.Add("CCM", false, "", "", false, "");
			}

			if (CMAC == "True")
			{
				DT.Rows.Add("CMAC", false, "", "", false, "");
			}

			if (CVL == "True")
			{
				DT.Rows.Add("CVL", false, "Primitive “Z” computation", "", false, "");
			}

			if (DRBG == "True")
			{
				DT.Rows.Add("DRBG", false, "- Instantiate" + Environment.NewLine + "- Generate" + Environment.NewLine + "- Reseed (as relevant)", "", false, "");
			}

			if (DSA == "True")
			{
				DT.Rows.Add("DSA", false, "- Signature Generation" + Environment.NewLine + "- Signature Verification", "", false, "");
			}

			if (ECDSA == "True")
			{
				DT.Rows.Add("ECDSA", false, "- Signature Generation" + Environment.NewLine + "- Signature Verification", "", false, "");
			}

			if (GCM == "True")
			{
				DT.Rows.Add("GCM", false, "- Authenticated Encryption" + Environment.NewLine + "- Authenticated Decryption", "", false, "");
			}

			if (HMAC == "True")
			{
				DT.Rows.Add("HMAC", false, "", "", false, "");
			}

			if (KAS_ECC == "True")
			{
				DT.Rows.Add("KAS ECC", false, "- Primitive “Z” computation" + Environment.NewLine +
					"- KDF KAT(on SHS)" + Environment.NewLine + "- KATs on each prerequisite(that is not tested elsewhere)", "", false, "");
			}

			if (KAS_FFC == "True")
			{
				DT.Rows.Add("KAS FFC", false, "- Primitive “Z” computation" + Environment.NewLine +
					"- KDF KAT(on SHS)" + Environment.NewLine + "- KATs on each prerequisite(that is not tested elsewhere)", "", false, "");
			}

			if (KDF_108 == "True")
			{
				DT.Rows.Add("KDF SP800-108", false, "", "", false, "");
			}

			if (KDF_135 == "True")
			{
				DT.Rows.Add("KDF SP800-135", false, "", "", false, "");
			}

			if (KeyWrap == "True")
			{
				DT.Rows.Add("Key Wrap", false, "", "", false, "");
			}

			if (RSA == "True")
			{
				DT.Rows.Add("RSA", false, "- Signature Generation" + Environment.NewLine + "- Signature Verification", "", false, "");
			}

			if (SHA_3 == "True")
			{
				DT.Rows.Add("SHA-3", false, "", "", false, "");
			}

			//
			if (SHS == "True")
			{
				if (SHA1 == "True")
				{
					DT.Rows.Add("SHS", false, "", "1", false, "");
				}
				if (SHA224 == "True")
				{
					DT.Rows.Add("SHS", false, "", "224", false, "");
				}
				if (SHA256 == "True")
				{
					DT.Rows.Add("SHS", false, "", "256", false, "");
				}
				if (SHA384 == "True")
				{
					DT.Rows.Add("SHS", false, "", "384", false, "");
				}
				if (SHA512 == "True")
				{
					DT.Rows.Add("SHS", false, "", "512", false, "");
				}
				if (SHA512_224 == "True")
				{
					DT.Rows.Add("SHS", false, "", "512/224", false, "");
				}
				if (SHA512_256 == "True")
				{
					DT.Rows.Add("SHS", false, "", "512/256", false, "");
				}				
			}

			//if (TDES == "True")
			//{
			//	DT.Rows.Add("TDES", false, "- Encryption" + Environment.NewLine + "- Decryption", "", false, "");
			//}

			if (XTS == "True")
			{
				DT.Rows.Add("XTS", false, "", "", false, "");
			}

			XTS128 = Properties.Settings.Default.XTS128.ToString();
			XTS128_En = Properties.Settings.Default.XTS128_En.ToString();
			XTS128_De = Properties.Settings.Default.XTS128_De.ToString();
			XTS256 = Properties.Settings.Default.XTS256.ToString();
			XTS256_En = Properties.Settings.Default.XTS256_En.ToString();
			XTS256_De = Properties.Settings.Default.XTS256_De.ToString();

			dataGridView_SelfTests.DataSource = DT;

			dataGridView_SelfTests.Columns[0].Width = 250;
			dataGridView_SelfTests.Columns[1].Width = 50;
			dataGridView_SelfTests.Columns[2].Width = 400;
			dataGridView_SelfTests.Columns[3].Width = 250;
			dataGridView_SelfTests.Columns[4].Width = 50;
			dataGridView_SelfTests.Columns[5].Width = 250;

			dataGridView_SelfTests.Dock = DockStyle.Fill;
			dataGridView_SelfTests.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dataGridView_SelfTests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		}

		private void dataGridView_SelfTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{	
	
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Algorithms_Click(object sender, EventArgs e)
		{

		}

		private void Algorithms1_Click(object sender, EventArgs e)
		{

		}

		private void radioButton_RNG_Block_LT16_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton_RNG_Block_GT15_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox_RNG2_CheckedChanged_1(object sender, EventArgs e)
		{

		}

		private void radioButton_DuplicateEntry_KeyEntry_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton_EDC_KeyEntry_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox_ManualKeyEntry_CheckedChanged_1(object sender, EventArgs e)
		{

		}

		private void groupBox4_Enter(object sender, EventArgs e)
		{

		}

		private void radioButton_SWFWLoad_CheckedChanged_1(object sender, EventArgs e)
		{

		}

		private void textBox_ApprTechSWFWLoad_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void checkBox_CalcVerifDSA_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox_CriticalFunctions_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton_CAT_TE092001_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton_KAT_TE092001_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void radioButton_DSA_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton_DAC_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void textBox_EDC_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox_ApprovedTechnique_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void radioButton_ApprAuthenTech_CheckedChanged_1(object sender, EventArgs e)
		{

		}

		private void radioButton_EDC_CheckedChanged_1(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void checkBox_RNG1_CheckedChanged_1(object sender, EventArgs e)
		{

		}

		private void checkBox_Authent_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox_EncryDecryptn_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox_MessageDigestAlg_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox_AsymAlg_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox_OutputVaries_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox_IndpendImplementation_CheckedChanged_1(object sender, EventArgs e)
		{

		}

		private void checkBox_GenPublicPrivateKeys_CheckedChanged_1(object sender, EventArgs e)
		{

		}

		private void SelfTests_FormClosing(object sender, FormClosingEventArgs e)
		{

		}
	}
}