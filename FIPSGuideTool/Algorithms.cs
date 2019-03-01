using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;

namespace FIPSGuideTool
{
	public partial class Algorithms : Form
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();
		OleDbDataReader dataSearch;

		// Algorithms Checkboxes 
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
		// Cert Numbers Strings
		public static string TDES_cert;
		public static string AES_cert;
		public static string SHS_cert;
		public static string SHA_3_cert;
		public static string DRBG_cert;
		public static string DSA_cert;
		public static string ECDSA_cert;
		public static string RSA_cert;
		public static string HMAC_cert;
		public static string CCM_cert;
		public static string CMAC_cert;
		public static string KAS_FFC_cert;
		public static string KAS_ECC_cert;
		public static string GCM_cert;
		public static string XTS_cert;
		public static string KDF_108_cert;
		public static string KDF_135_cert;
		public static string KeyWrap_cert;
		public static string CVL_cert;
		// Cert Numbers Strings for Cryptik
		public static string TDES_txt    = "Triple-DES (Cert. #" + TDES_cert + ")";
		public static string AES_txt     = "AES (Cert. #" + AES_cert + ")";
		public static string SHS_txt     = "SHS (Cert. #" + SHS_cert + ")";
		public static string SHA3_txt    = "SHA 3 (Cert. #" + SHA_3_cert + ")";
		public static string DRBG_txt    = "DRBG (Cert. #" + DRBG_cert + ")";
		public static string DSA2_txt    = "DSA 2 (Cert. #" + DSA_cert + ")";
		public static string ECDSA2_txt  = "ECDSA 2 (Cert. #" + ECDSA_cert + ")";
		public static string RSA2_txt    = "RSA 2 (Cert. #" + RSA_cert + ")";
		public static string HMAC_txt    = "HMAC (Cert. #" + HMAC_cert + ")";
		public static string CCM_txt     = "CCM (Cert. #" + CCM_cert + ")";
		public static string CMAC_txt    = "CMAC (Cert. #" + CMAC_cert + ")";
		public static string KAS_FFC_txt = "KAS FFC (Cert. #" + KAS_FFC_cert + ")";
		public static string KAS_ECC_txt = "KAS ECC (Cert. #" + KAS_ECC_cert + ")";
		public static string GCM_txt     = "GCM (Cert. #" + GCM_cert + ")";
		public static string XTS_txt     = "XTS (Cert. #" + XTS_cert + ")";
		public static string KDF_108_txt = "KDF (SP800-108) (Cert. #" + KDF_108_cert + ")";
		public static string KDF_135_txt = "KDF (SP800-135) (Cert. #" + KDF_135_cert + ")";
		public static string KeyWrap_txt = "Key Wrap (Cert. #" + KeyWrap_cert + ")";
		public static string CVL_txt     = "CVL (Cert. #" + CVL_cert + ")";

		public Algorithms()
		{
			InitializeComponent();
			btn_CompVL.Visible = false;

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

			TDES_cert = Properties.Settings.Default.TDES_cert.ToString();
			AES_cert = Properties.Settings.Default.AES_cert.ToString();
			SHS_cert = Properties.Settings.Default.SHS_cert.ToString();
			SHA_3_cert = Properties.Settings.Default.SHA_3_cert.ToString();
			DRBG_cert = Properties.Settings.Default.DRBG_cert.ToString();
			DSA_cert = Properties.Settings.Default.DSA_cert.ToString();
			ECDSA_cert = Properties.Settings.Default.ECDSA_cert.ToString();
			RSA_cert = Properties.Settings.Default.RSA_cert.ToString();
			HMAC_cert = Properties.Settings.Default.HMAC_cert.ToString();
			CCM_cert = Properties.Settings.Default.CCM_cert.ToString();
			CMAC_cert = Properties.Settings.Default.CMAC_cert.ToString();
			KAS_FFC_cert = Properties.Settings.Default.KAS_FFC_cert.ToString();
			KAS_ECC_cert = Properties.Settings.Default.KAS_ECC_cert.ToString();
			GCM_cert = Properties.Settings.Default.GCM_cert.ToString();
			XTS_cert = Properties.Settings.Default.XTS_cert.ToString();
			KDF_108_cert = Properties.Settings.Default.KDF_108_cert.ToString();
			KDF_135_cert = Properties.Settings.Default.KDF_135_cert.ToString();
			KeyWrap_cert = Properties.Settings.Default.KeyWrap_cert.ToString();
			CVL_cert = Properties.Settings.Default.CVL_cert.ToString();

			textBox_certTDES.Text    = TDES_cert;
			textBox_certAES.Text     = AES_cert;
			textBox_certSHS.Text     = SHS_cert;
			textBox_certSHA3.Text    = SHA_3_cert;
			textBox_certDRBG.Text    = DRBG_cert;
			textBox_certDSA.Text     = DSA_cert;
			textBox_certECDSA.Text   = ECDSA_cert;
			textBox_certRSA.Text     = RSA_cert;
			textBox_certHMAC.Text    = HMAC_cert;
			textBox_certCCM.Text     = CCM_cert;
			textBox_certCMAC.Text    = CMAC_cert;
			textBox_certKASFFC.Text  = KAS_FFC_cert;
			textBox_certKASECC.Text  = KAS_ECC_cert;
			textBox_certGCM.Text     = GCM_cert;
			textBox_certXTS.Text     = XTS_cert;
			textBox_certKDF108.Text  = KDF_108_cert;
			textBox_certKDF135.Text  = KDF_135_cert;
			textBox_certKeyWrap.Text = KeyWrap_cert;
			textBox_certCVL.Text     = CVL_cert;

			if (TDES == "True")
			{
				checkBox_TDES.Checked    = true;
				textBox_certTDES.Visible = true;
				btn_TDES.Enabled = true;
			}
			else
			{
				textBox_certTDES.Visible = false;
				btn_TDES.Enabled = false;
			}

			if (AES == "True")
			{
				checkBox_AES.Checked    = true;
				textBox_certAES.Visible = true;
				btn_AES.Enabled = true;
			}
			else
			{
				textBox_certAES.Visible = false;
				btn_AES.Enabled = false;
			}
			if (SHS == "True")
			{
				checkBox_SHS.Checked = true;
				textBox_certSHS.Visible = true;
				btn_SHS.Enabled = true;
			}
			else
			{
				textBox_certSHS.Visible = false;
				btn_SHS.Enabled = false;
			}
			if (SHA_3 == "True")
			{
				checkBox_SHA3.Checked = true;
				textBox_certSHA3.Visible = true;
				btn_SHA.Enabled = true;
			}
			else
			{
				textBox_certSHA3.Visible = false;
				btn_SHA.Enabled = false;
			}
			if (DRBG == "True")
			{
				checkBox_DRBG.Checked = true;
				textBox_certDRBG.Visible = true;
				btn_DRBG.Enabled = true;
			}
			else
			{
				textBox_certDRBG.Visible = false;
				btn_DRBG.Enabled = false;
			}
			if (DSA == "True")
			{
				checkBox_DSA.Checked = true;
				textBox_certDSA.Visible = true;
				btn_DSA.Enabled = true;
			}
			else
			{
				textBox_certDSA.Visible = false;
				btn_DSA.Enabled = false;
			}
			if (ECDSA == "True")
			{
				checkBox_ECDSA.Checked = true;
				textBox_certECDSA.Visible = true;
				btn_ECDSA.Enabled = true;
			}
			else
			{
				textBox_certECDSA.Visible = false;
				btn_ECDSA.Enabled = false;
			}
			if (RSA == "True")
			{
				checkBox_RSA.Checked = true;
				textBox_certRSA.Visible = true;
				btn_RSA.Enabled = true;
			}
			else
			{
				textBox_certRSA.Visible = false;
				btn_RSA.Enabled = false;
			}
			if (HMAC == "True")
			{
				checkBox_HMAC.Checked = true;
				textBox_certHMAC.Visible = true;
				btn_HMAC.Enabled = true;
			}
			else
			{
				textBox_certHMAC.Visible = false;
				btn_HMAC.Enabled = false;
			}
			if (CCM == "True")
			{
				checkBox_CCM.Checked = true;
				textBox_certCCM.Visible = true;
				btn_CCM.Enabled = true;
			}
			else
			{
				textBox_certCCM.Visible = false;
				btn_CCM.Enabled = false;
			}
			if (CMAC == "True")
			{
				checkBox_CMAC.Checked = true;
				textBox_certCMAC.Visible = true;
				btn_CMAC.Enabled = true;
			}
			else
			{
				textBox_certCMAC.Visible = false;
				btn_CMAC.Enabled = false;
			}
			if (KAS_FFC == "True")
			{
				checkBox_KASFFC.Checked = true;
				textBox_certKASFFC.Visible = true;
				btn_FFC.Enabled = true;
			}
			else
			{
				textBox_certKASFFC.Visible = false;
				btn_FFC.Enabled = false;
			}
			if (KAS_ECC == "True")
			{
				checkBox_KASECC.Checked = true;
				textBox_certKASECC.Visible = true;
				btn_ECC.Enabled = true;
			}
			else
			{
				textBox_certKASECC.Visible = false;
				btn_ECC.Enabled = false;
			}
			if (GCM == "True")
			{
				checkBox_GCM.Checked = true;
				textBox_certGCM.Visible = true;
				btn_GCM.Enabled = true;
			}
			else
			{
				textBox_certGCM.Visible = false;
				btn_GCM.Enabled = false;
			}
			if (XTS == "True")
			{
				checkBox_XTS.Checked = true;
				textBox_certXTS.Visible = true;
				btn_XTS.Enabled = true;
			}
			else
			{
				textBox_certXTS.Visible = false;
				btn_XTS.Enabled = false;
			}
			if (KDF_108 == "True")
			{
				checkBox_KDF108.Checked = true;
				textBox_certKDF108.Visible = true;
				btn_KDF108.Enabled = true;
			}
			else
			{
				textBox_certKDF108.Visible = false;
				btn_KDF108.Enabled = false;
			}
			if (KDF_135 == "True")
			{
				checkBox_KDF135.Checked = true;
				textBox_certKDF135.Visible = true;
				btn_KDF135.Enabled = true;
			}
			else
			{
				textBox_certKDF135.Visible = false;
				btn_KDF135.Enabled = false;
			}
			if (KeyWrap == "True")
			{
				checkBox_KeyWrap.Checked = true;
				textBox_certKeyWrap.Visible = true;
				btn_KeyWrap.Enabled = true;
			}
			else
			{
				textBox_certKeyWrap.Visible = false;
				btn_KeyWrap.Enabled = false;
			}
			if (CVL == "True")
			{
				checkBox_CVL.Checked = true;
				textBox_certCVL.Visible = true;
				btn_CompVL.Enabled = true;
			}
			else
			{
				textBox_certCVL.Visible = false;
				btn_CompVL.Enabled = false;
			}

			string temp = textBox_Algs.Text;
			if (temp == "")
			{

			}
			else
			{
				string[] tempVec = temp.Split(';');
				string newtemp1;
				int i = 0;
				foreach (string temp1 in tempVec)
				{
					char[] tempChar = temp1.ToCharArray();

					if (tempChar[0] == 32)
					{
						newtemp1 = temp1.TrimStart(tempChar[0]);
						//string s = new string(tempChar);		
						tempVec[i] = newtemp1;
					}
					i = i + 1;
				}
				List<string> algs = AlphabetizeAlgs(tempVec);

				StringBuilder builder = new StringBuilder();
				for (int i1 = 0; i1 < tempVec.Length; i1++)
				{
					if (i1 == tempVec.Length - 1)
					{
						builder.Append(algs[i1]);
					}
					else
					{
						builder.Append(algs[i1]).Append("; ");
					}
				}
				string temp2 = builder.ToString(); // Get string from StringBuilder

				textBox_Algs.Text = "";
				textBox_Algs.Text = temp2;

				connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
				connection.Open();
				command.Connection = connection;

				command.CommandText = "SELECT * FROM GeneralVendorInfo";
				dataSearch = command.ExecuteReader();

				string OtherAlgs;

				while (dataSearch.Read())
				{
					OtherAlgs = dataSearch.GetValue(11).ToString();
					txtBox_OtherAlgs.Text = OtherAlgs;
				}
				dataSearch.Close();
				//txtBox_OtherAlgs.Text = OtherAlgs;

				connection.Close();
			}
		}

		private void Algorithms_Load(object sender, EventArgs e)
		{

		}

		private void saveCertNoToSettings()
		{
			TDES_cert = textBox_certTDES.Text.ToString();
			Properties.Settings.Default.TDES_cert = TDES_cert;

			AES_cert = textBox_certAES.Text.ToString();
			Properties.Settings.Default.AES_cert = AES_cert;

			SHS_cert = textBox_certSHS.Text.ToString();
			Properties.Settings.Default.SHS_cert = SHS_cert;

			SHA_3_cert = textBox_certSHA3.Text.ToString();
			Properties.Settings.Default.SHA_3_cert = SHA_3_cert;

			DRBG_cert = textBox_certDRBG.Text.ToString();
			Properties.Settings.Default.DRBG_cert = DRBG_cert;

			DSA_cert = textBox_certDSA.Text.ToString();
			Properties.Settings.Default.DSA_cert = DSA_cert;

			ECDSA_cert = textBox_certECDSA.Text.ToString();
			Properties.Settings.Default.ECDSA_cert = ECDSA_cert;

			RSA_cert = textBox_certRSA.Text.ToString();
			Properties.Settings.Default.RSA_cert = RSA_cert;

			HMAC_cert = textBox_certHMAC.Text.ToString();
			Properties.Settings.Default.HMAC_cert = HMAC_cert;

			CCM_cert = textBox_certCCM.Text.ToString();
			Properties.Settings.Default.CCM_cert = CCM_cert;

			CMAC_cert = textBox_certCMAC.Text.ToString();
			Properties.Settings.Default.CMAC_cert = CMAC_cert;

			KAS_FFC_cert = textBox_certKASFFC.Text.ToString();
			Properties.Settings.Default.KAS_FFC_cert = KAS_FFC_cert;

			KAS_ECC_cert = textBox_certKASECC.Text.ToString();
			Properties.Settings.Default.KAS_ECC_cert = KAS_ECC_cert;

			GCM_cert = textBox_certGCM.Text.ToString();
			Properties.Settings.Default.GCM_cert = GCM_cert;

			XTS_cert = textBox_certXTS.Text.ToString();
			Properties.Settings.Default.XTS_cert = XTS_cert;

			KDF_108_cert = textBox_certKDF108.Text.ToString();
			Properties.Settings.Default.KDF_108_cert = KDF_108_cert;

			KDF_135_cert = textBox_certKDF135.Text.ToString();
			Properties.Settings.Default.KDF_135_cert = KDF_135_cert;

			KeyWrap_cert = textBox_certKeyWrap.Text.ToString();
			Properties.Settings.Default.KeyWrap_cert = KeyWrap_cert;

			CVL_cert = textBox_certCVL.Text.ToString();
			Properties.Settings.Default.CVL_cert = CVL_cert;
			Properties.Settings.Default.Save();

		}

		private void ReadCertNo()
		{
			TDES_cert = Properties.Settings.Default.TDES_cert.ToString();
			AES_cert = Properties.Settings.Default.AES_cert.ToString();
			SHS_cert = Properties.Settings.Default.SHS_cert.ToString();
			SHA_3_cert = Properties.Settings.Default.SHA_3_cert.ToString();
			DRBG_cert = Properties.Settings.Default.DRBG_cert.ToString();
			DSA_cert = Properties.Settings.Default.DSA_cert.ToString();
			ECDSA_cert = Properties.Settings.Default.ECDSA_cert.ToString();
			RSA_cert = Properties.Settings.Default.RSA_cert.ToString();
			HMAC_cert = Properties.Settings.Default.HMAC_cert.ToString();
			CCM_cert = Properties.Settings.Default.CCM_cert.ToString();
			CMAC_cert = Properties.Settings.Default.CMAC_cert.ToString();
			KAS_FFC_cert = Properties.Settings.Default.KAS_FFC_cert.ToString();
			KAS_ECC_cert = Properties.Settings.Default.KAS_ECC_cert.ToString();
			GCM_cert = Properties.Settings.Default.GCM_cert.ToString();
			XTS_cert = Properties.Settings.Default.XTS_cert.ToString();
			KDF_108_cert = Properties.Settings.Default.KDF_108_cert.ToString();
			KDF_135_cert = Properties.Settings.Default.KDF_135_cert.ToString();
			KeyWrap_cert = Properties.Settings.Default.KeyWrap_cert.ToString();
			CVL_cert = Properties.Settings.Default.CVL_cert.ToString();

		}
		private void SetCertTexts()
		{
			saveCertNoToSettings();
			ReadCertNo();

			TDES_txt    = "Triple-DES (Cert. #" + TDES_cert + ")";
			AES_txt     = "AES (Cert. #" + AES_cert + ")";
			SHS_txt     = "SHS (Cert. #" + SHS_cert + ")";
			SHA3_txt    = "SHA 3 (Cert. #" + SHA_3_cert + ")";
			DRBG_txt    = "DRBG (Cert. #" + DRBG_cert + ")";
			DSA2_txt    = "DSA 2 (Cert. #" + DSA_cert + ")";
			ECDSA2_txt  = "ECDSA 2 (Cert. #" + ECDSA_cert + ")";
			RSA2_txt    = "RSA 2 (Cert. #" + RSA_cert + ")";
			HMAC_txt    = "HMAC (Cert. #" + HMAC_cert + ")";
			CCM_txt     = "CCM (Cert. #" + CCM_cert + ")";
			CMAC_txt    = "CMAC (Cert. #" + CMAC_cert + ")";
			KAS_FFC_txt = "KAS FFC (Cert. #" + KAS_FFC_cert + ")";
			KAS_ECC_txt = "KAS ECC (Cert. #" + KAS_ECC_cert + ")";
			GCM_txt     = "GCM (Cert. #" + GCM_cert + ")";
			XTS_txt     = "XTS (Cert. #" + XTS_cert + ")";
			KDF_108_txt = "KDF (SP800-108) (Cert. #" + KDF_108_cert + ")";			
			KDF_135_txt = "KDF (SP800-135) (Cert. #" + KDF_135_cert + ")";
			KeyWrap_txt = "Key Wrap (Cert. #" + KeyWrap_cert + ")";
			CVL_txt     = "CVL (Cert. #" + CVL_cert + ")";
		}

		private void btn_refresh_Click_1(object sender, EventArgs e)
		{
			SetCertTexts();

			string temp = textBox_Algs.Text;
			if (temp != "")
			{
				string[] tempVec = temp.Split(';');
				string newtemp1;
				int i = 0;
				foreach (string temp1 in tempVec)
				{
					char[] tempChar = temp1.ToCharArray();

					if (tempChar[0] == 32)
					{
						newtemp1 = temp1.TrimStart(tempChar[0]);
						//string s = new string(tempChar);		
						tempVec[i] = newtemp1;
					}
					i = i + 1;
				}

				for (int i1 = 0; i1 < tempVec.Length; i1++)
				{
					string[] tempVec2 = tempVec[i1].Split(' ');
					if (tempVec2[0].Equals("Triple-DES"))
					{
						tempVec[i1] = TDES_txt;
					}
					else if (tempVec2[0].Equals("AES"))
					{
						tempVec[i1] = AES_txt;
					}
					else if (tempVec2[0].Equals("SHS"))
					{
						tempVec[i1] = SHS_txt;
					}
					else if (tempVec2[0].Equals("SHA"))
					{
						tempVec[i1] = SHA3_txt;
					}
					else if (tempVec2[0].Equals("DRBG"))
					{
						tempVec[i1] = DRBG_txt;
					}
					else if (tempVec2[0].Equals("DSA"))
					{
						tempVec[i1] = DSA2_txt;
					}
					else if (tempVec2[0].Equals("ECDSA"))
					{
						tempVec[i1] = ECDSA2_txt;
					}
					else if (tempVec2[0].Equals("RSA"))
					{
						tempVec[i1] = RSA2_txt;
					}
					else if (tempVec2[0].Equals("HMAC"))
					{
						tempVec[i1] = HMAC_txt;
					}
					else if (tempVec2[0].Equals("CCM"))
					{
						tempVec[i1] = CCM_txt;
					}
					else if (tempVec2[0].Equals("CMAC"))
					{
						tempVec[i1] = CMAC_txt;
					}
					else if (tempVec2[1].Equals("FFC"))
					{
						tempVec[i1] = KAS_FFC_txt;
					}
					else if (tempVec2[1].Equals("ECC"))
					{
						tempVec[i1] = KAS_ECC_txt;
					}
					else if (tempVec2[0].Equals("GCM"))
					{
						tempVec[i1] = GCM_txt;
					}
					else if (tempVec2[0].Equals("XTS"))
					{
						tempVec[i1] = XTS_txt;
					}
					else if (tempVec2[0].Equals("KDF"))
					{
						if (tempVec2[1].Equals("(SP800-108)"))
						{
							tempVec[i1] = KDF_108_txt;
						}
						else if (tempVec2[1].Equals("(SP800-135)"))
						{
							tempVec[i1] = KDF_135_txt;
						}
					}
					//else if (tempVec2[1].Equals("(SP800-135)"))
					//{
					//	tempVec[i1] = KDF_135_txt;
					//}
					else if (tempVec2[0].Equals("Key"))
					{
						tempVec[i1] = KeyWrap_txt;
					}
					else if (tempVec2[0].Equals("CVL"))
					{
						tempVec[i1] = CVL_txt;
					}
				}

				//// List of algorithms
				//List<string> algs = new List<string>();

				//for (int i1 = 0; i1 < tempVec.Length; i1++)
				//{
				//	algs.Add(tempVec[i1]);
				//}

				//algs.Sort();      // alphabetize

				List<string> algs = AlphabetizeAlgs(tempVec);

				StringBuilder builder = new StringBuilder();
				for (int i1 = 0; i1 < tempVec.Length; i1++)
				{
					if (i1 == tempVec.Length - 1)
					{
						builder.Append(algs[i1]);
					}
					else
					{
						builder.Append(algs[i1]).Append("; ");
					}
				}
				string temp2 = builder.ToString(); // Get string from StringBuilder

				textBox_Algs.Text = "";
				textBox_Algs.Text = temp2;
			}
			else
			{

			}

		}

		public List<string> AlphabetizeAlgs(string[]  tempVec)
		{
			// List of algorithms
			List<string> algs = new List<string>();

			for (int i1 = 0; i1 < tempVec.Length; i1++)
			{
				algs.Add(tempVec[i1]);
			}

			algs.Sort();      // alphabetize

			return algs;

		}


		private void Algorithms_FormClosing_1(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				TDES = checkBox_TDES.Checked.ToString();
				Properties.Settings.Default.TDES = TDES;

				AES = checkBox_AES.Checked.ToString();
				Properties.Settings.Default.AES = AES;

				SHS = checkBox_SHS.Checked.ToString();
				Properties.Settings.Default.SHS = SHS;

				SHA_3 = checkBox_SHA3.Checked.ToString();
				Properties.Settings.Default.SHA_3 = SHA_3;

				DRBG = checkBox_DRBG.Checked.ToString();
				Properties.Settings.Default.DRBG = DRBG;

				DSA = checkBox_DSA.Checked.ToString();
				Properties.Settings.Default.DSA = DSA;

				ECDSA = checkBox_ECDSA.Checked.ToString();
				Properties.Settings.Default.ECDSA = ECDSA;

				RSA = checkBox_RSA.Checked.ToString();
				Properties.Settings.Default.RSA = RSA;

				HMAC = checkBox_HMAC.Checked.ToString();
				Properties.Settings.Default.HMAC = HMAC;

				CCM = checkBox_CCM.Checked.ToString();
				Properties.Settings.Default.CCM = CCM;

				CMAC = checkBox_CMAC.Checked.ToString();
				Properties.Settings.Default.CMAC = CMAC;

				KAS_FFC = checkBox_KASFFC.Checked.ToString();
				Properties.Settings.Default.KAS_FFC = KAS_FFC;

				KAS_ECC = checkBox_KASECC.Checked.ToString();
				Properties.Settings.Default.KAS_ECC = KAS_ECC;

				GCM = checkBox_GCM.Checked.ToString();
				Properties.Settings.Default.GCM = GCM;

				XTS = checkBox_XTS.Checked.ToString();
				Properties.Settings.Default.XTS = XTS;

				KDF_108 = checkBox_KDF108.Checked.ToString();
				Properties.Settings.Default.KDF_108 = KDF_108;

				KDF_135 = checkBox_KDF135.Checked.ToString();
				Properties.Settings.Default.KDF_135 = KDF_135;

				KeyWrap = checkBox_KeyWrap.Checked.ToString();
				Properties.Settings.Default.KeyWrap = KeyWrap;

				CVL = checkBox_CVL.Checked.ToString();
				Properties.Settings.Default.CVL = CVL;

				TDES_cert = textBox_certTDES.Text.ToString();
				Properties.Settings.Default.TDES_cert = TDES_cert;

				AES_cert = textBox_certAES.Text.ToString();
				Properties.Settings.Default.AES_cert = AES_cert;

				SHS_cert = textBox_certSHS.Text.ToString();
				Properties.Settings.Default.SHS_cert = SHS_cert;

				SHA_3_cert = textBox_certSHA3.Text.ToString();
				Properties.Settings.Default.SHA_3_cert = SHA_3_cert;

				DRBG_cert = textBox_certDRBG.Text.ToString();
				Properties.Settings.Default.DRBG_cert = DRBG_cert;

				DSA_cert = textBox_certDSA.Text.ToString();
				Properties.Settings.Default.DSA_cert = DSA_cert;

				ECDSA_cert = textBox_certECDSA.Text.ToString();
				Properties.Settings.Default.ECDSA_cert = ECDSA_cert;

				RSA_cert = textBox_certRSA.Text.ToString();
				Properties.Settings.Default.RSA_cert = RSA_cert;

				HMAC_cert = textBox_certHMAC.Text.ToString();
				Properties.Settings.Default.HMAC_cert = HMAC_cert;

				CCM_cert = textBox_certCCM.Text.ToString();
				Properties.Settings.Default.CCM_cert = CCM_cert;

				CMAC_cert = textBox_certCMAC.Text.ToString();
				Properties.Settings.Default.CMAC_cert = CMAC_cert;

				KAS_FFC_cert = textBox_certKASFFC.Text.ToString();
				Properties.Settings.Default.KAS_FFC_cert = KAS_FFC_cert;

				KAS_ECC_cert = textBox_certKASECC.Text.ToString();
				Properties.Settings.Default.KAS_ECC_cert = KAS_ECC_cert;

				GCM_cert = textBox_certGCM.Text.ToString();
				Properties.Settings.Default.GCM_cert = GCM_cert;

				XTS_cert = textBox_certXTS.Text.ToString();
				Properties.Settings.Default.XTS_cert = XTS_cert;

				KDF_108_cert = textBox_certKDF108.Text.ToString();
				Properties.Settings.Default.KDF_108_cert = KDF_108_cert;

				KDF_135_cert = textBox_certKDF135.Text.ToString();
				Properties.Settings.Default.KDF_135_cert = KDF_135_cert;

				KeyWrap_cert = textBox_certKeyWrap.Text.ToString();
				Properties.Settings.Default.KeyWrap_cert = KeyWrap_cert;

				CVL_cert = textBox_certCVL.Text.ToString();
				Properties.Settings.Default.CVL_cert = CVL_cert;

				connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
				connection.Open();
				command.Connection = connection;
				string Algs_txt = textBox_Algs.Text;
				if (Algs_txt == "")
				{}
				else
				{
					command.CommandText = "UPDATE GeneralVendorInfo SET FIPSAlgorithms='" + Algs_txt + "'";
					command.ExecuteNonQuery();
				}				

				string AllowedAlgs_txt = txtBox_OtherAlgs.Text;
				if (AllowedAlgs_txt == "")
				{ }
				else
				{
					command.CommandText = "UPDATE GeneralVendorInfo SET OtherAlgorithms='" + AllowedAlgs_txt + "'";
					command.ExecuteNonQuery();
				}

				connection.Close();

				Properties.Settings.Default.Save();
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

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btn_KDF_Click(object sender, EventArgs e)
		{

		}
		
		private void btn_KeyWrap_Click(object sender, EventArgs e)
		{

		}

		private void btn_TDES_Click(object sender, EventArgs e)
		{
			Triple_DES f1 = new Triple_DES();
			f1.ShowDialog();
		}

		private void btn_AES_Click(object sender, EventArgs e)
		{
			AES f1 = new AES();
			f1.ShowDialog();
		}

		private void btn_GCM_Click(object sender, EventArgs e)
		{
			GCM f1 = new GCM();
			f1.ShowDialog();
		}

		private void btn_SHS_Click(object sender, EventArgs e)
		{
			SHS f1 = new SHS();
			f1.ShowDialog();
		}

		private void btn_SHA_Click_1(object sender, EventArgs e)
		{
			SHA f1 = new SHA();
			f1.Show();
		}

		private void btn_DRBG_Click(object sender, EventArgs e)
		{
			DRBG f1 = new DRBG();
			f1.ShowDialog();
		}

		private void btn_DSA_Click(object sender, EventArgs e)
		{
			DSA f1 = new DSA();
			f1.ShowDialog();
		}

		private void btn_ECDSA_Click(object sender, EventArgs e)
		{
			ECDSA f1 = new ECDSA();
			f1.ShowDialog();
		}

		private void btn_RSA_Click(object sender, EventArgs e)
		{
			RSA f1 = new RSA();
			f1.ShowDialog();
		}

		private void btn_XTS_Click(object sender, EventArgs e)
		{
			XTS f1 = new XTS();
			f1.ShowDialog();
		}

		private void btn_HMAC_Click(object sender, EventArgs e)
		{
			HMAC f1 = new HMAC();
			f1.ShowDialog();
		}

		private void btn_CCM_Click(object sender, EventArgs e)
		{
			CCM f1 = new CCM();
			f1.ShowDialog();
		}

		private void btn_CMAC_Click(object sender, EventArgs e)
		{
			CMAC f1 = new CMAC();
			f1.ShowDialog();
		}

		private void btn_FFC_Click(object sender, EventArgs e)
		{

		}

		private void btn_ECC_Click(object sender, EventArgs e)
		{
			KASECC f1 = new KASECC();
			f1.ShowDialog();
		}

		private void btn_KDF_Click_1(object sender, EventArgs e)
		{

		}

		private void btn_CVL_Click(object sender, EventArgs e)
		{

		}

		private void checkBox_TDES_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			TDES_cert = textBox_certTDES.Text.ToString();
			Properties.Settings.Default.TDES_cert = TDES_cert;
			Properties.Settings.Default.Save();
			TDES_txt = "Triple-DES (Cert. #" + TDES_cert + ")";

			if (checkBox_TDES.Checked == true)
			{
				btn_TDES.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = TDES_txt;
				}
				else
				{
					string alg = TDES_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; Triple-DES (Cert. #" + TDES_cert + ")";
					}
				}
				textBox_certTDES.Visible = true;
			}
			else
			{
				btn_TDES.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = TDES_txt;
				}
				else
				{
					string alg = TDES_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certTDES.Text = "";
				//TDES_cert = textBox_certTDES.Text.ToString();
				//Properties.Settings.Default.TDES_cert = TDES_cert;
				//Properties.Settings.Default.Save();
				textBox_certTDES.Visible = false;
			}
		}

		private void checkBox_AES_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			AES_cert = textBox_certAES.Text.ToString();
			Properties.Settings.Default.AES_cert = AES_cert;
			Properties.Settings.Default.Save();
			AES_txt = "AES (Cert. #" + AES_cert + ")";

			if (checkBox_AES.Checked == true)
			{
				btn_AES.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = AES_txt;
				}
				else
				{
					string alg = AES_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; AES (Cert. #" + AES_cert + ")";
					}
				}
				textBox_certAES.Text = AES_cert;
				textBox_certAES.Visible = true;
			}
			else
			{
				btn_AES.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = AES_txt;
				}
				else
				{
					string alg = AES_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certAES.Text = "";
				//AES_cert = textBox_certAES.Text.ToString();
				//Properties.Settings.Default.AES_cert = AES_cert;
				//Properties.Settings.Default.Save();
				textBox_certAES.Visible = false;
			}
		}

		private void checkBox_GCM_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			GCM_cert = textBox_certGCM.Text.ToString();
			Properties.Settings.Default.GCM_cert = GCM_cert;
			Properties.Settings.Default.Save();
			GCM_txt = "GCM (Cert. #" + GCM_cert + ")";

			if (checkBox_GCM.Checked == true)
			{
				btn_GCM.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = GCM_txt;
				}
				else
				{
					string alg = GCM_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; GCM (Cert. #" + GCM_cert + ")";
					}
				}
				textBox_certGCM.Text = GCM_cert;
				textBox_certGCM.Visible = true;
			}
			else
			{
				btn_GCM.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = GCM_txt;
				}
				else
				{
					string alg = GCM_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certGCM.Text = "";
				//GCM_cert = textBox_certGCM.Text.ToString();
				//Properties.Settings.Default.GCM_cert = GCM_cert;
				//Properties.Settings.Default.Save();
				textBox_certGCM.Visible = false;
			}
		}

		private void checkBox_XTS_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			XTS_cert = textBox_certXTS.Text.ToString();
			Properties.Settings.Default.XTS_cert = XTS_cert;
			Properties.Settings.Default.Save();
			XTS_txt = "XTS (Cert. #" + XTS_cert + ")";

			if (checkBox_XTS.Checked == true)
			{
				btn_XTS.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = XTS_txt;
				}
				else
				{
					string alg = XTS_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; XTS (Cert. #" + XTS_cert + ")";
					}
				}
				textBox_certXTS.Text = XTS_cert;
				textBox_certXTS.Visible = true;
			}
			else
			{
				btn_XTS.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = XTS_txt;
				}
				else
				{
					string alg = XTS_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certXTS.Text = "";
				//XTS_cert = textBox_certXTS.Text.ToString();
				//Properties.Settings.Default.XTS_cert = XTS_cert;
				//Properties.Settings.Default.Save();
				textBox_certXTS.Visible = false;
			}
		}

		private void checkBox_SHS_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			SHS_cert = textBox_certSHS.Text.ToString();
			Properties.Settings.Default.SHS_cert = SHS_cert;
			Properties.Settings.Default.Save();
			SHS_txt = "SHS (Cert. #" + SHS_cert + ")";

			if (checkBox_SHS.Checked == true)
			{
				btn_SHS.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = SHS_txt;
				}
				else
				{
					string alg = SHS_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; SHS (Cert. #" + SHS_cert + ")";
					}
				}
				textBox_certSHS.Text = SHS_cert;
				textBox_certSHS.Visible = true;
			}
			else
			{
				btn_SHS.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = SHS_txt;
				}
				else
				{
					string alg = SHS_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certSHS.Text = "";
				//SHS_cert = textBox_certSHS.ToString();
				//Properties.Settings.Default.SHS_cert = SHS_cert;
				//Properties.Settings.Default.Save();
				textBox_certSHS.Visible = false;
			}
		}

		private void checkBox_SHA3_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			SHA_3_cert = textBox_certSHA3.Text.ToString();
			Properties.Settings.Default.SHA_3_cert = SHA_3_cert;
			Properties.Settings.Default.Save();
			SHA3_txt = "SHA 3 (Cert. #" + SHA_3_cert + ")";

			if (checkBox_SHA3.Checked == true)
			{
				btn_SHA.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = SHA3_txt;
				}
				else
				{
					string alg = SHA3_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; SHA 3 (Cert. #" + SHA_3_cert + ")";
					}
				}
				textBox_certSHA3.Text = SHA_3_cert;
				textBox_certSHA3.Visible = true;
			}
			else
			{
				btn_SHA.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = SHA3_txt;
				}
				else
				{
					string alg = SHA3_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certSHA3.Text = "";
				//SHA_3_cert = textBox_certSHA3.Text.ToString();
				//Properties.Settings.Default.SHA_3_cert = SHA_3_cert;
				//Properties.Settings.Default.Save();
				textBox_certSHA3.Visible = false;
			}
		}

		private void checkBox_DRBG_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			DRBG_cert = textBox_certDRBG.Text.ToString();
			Properties.Settings.Default.DRBG_cert = DRBG_cert;
			Properties.Settings.Default.Save();
			DRBG_txt = "DRBG (Cert. #" + DRBG_cert + ")";

			if (checkBox_DRBG.Checked == true)
			{
				btn_DRBG.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = DRBG_txt;
				}
				else
				{
					string alg = DRBG_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; DRBG (Cert. #" + DRBG_cert + ")";
					}
				}
				textBox_certDRBG.Text = DRBG_cert;
				textBox_certDRBG.Visible = true;
			}
			else
			{
				btn_DRBG.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = DRBG_txt;
				}
				else
				{
					string alg = DRBG_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certDRBG.Text = "";
				//DRBG_cert = textBox_certDRBG.Text.ToString();
				//Properties.Settings.Default.DRBG_cert = DRBG_cert;
				//Properties.Settings.Default.Save();
				textBox_certDRBG.Visible = false;
			}
		}

		private void checkBox_DSA2_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			DSA_cert = textBox_certDSA.Text.ToString();
			Properties.Settings.Default.DSA_cert = DSA_cert;
			Properties.Settings.Default.Save();
			DSA2_txt = "DSA 2 (Cert. #" + DSA_cert + ")";

			if (checkBox_DSA.Checked == true)
			{
				btn_DSA.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = DSA2_txt;
				}
				else
				{
					string alg = DSA2_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; DSA 2 (Cert. #" + DSA_cert + ")";
					}
				}
				textBox_certDSA.Text = DSA_cert;
				textBox_certDSA.Visible = true;
			}
			else
			{
				btn_DSA.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = DSA2_txt;
				}
				else
				{
					string alg = DSA2_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certDSA2.Text = "";
				//DSA_cert = textBox_certDSA2.Text.ToString();
				//Properties.Settings.Default.DSA_cert = DSA_cert;
				//Properties.Settings.Default.Save();
				textBox_certDSA.Visible = false;
			}
		}

		private void checkBox_ECDSA2_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			ECDSA_cert = textBox_certECDSA.Text.ToString();
			Properties.Settings.Default.ECDSA_cert = ECDSA_cert;
			Properties.Settings.Default.Save();
			ECDSA2_txt = "ECDSA 2 (Cert. #" + ECDSA_cert + ")";

			if (checkBox_ECDSA.Checked == true)
			{
				btn_ECDSA.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = ECDSA2_txt;
				}
				else
				{
					string alg = ECDSA2_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; ECDSA 2 (Cert. #" + ECDSA_cert + ")";
					}
				}
				textBox_certECDSA.Text = ECDSA_cert;
				textBox_certECDSA.Visible = true;
			}
			else
			{
				btn_ECDSA.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = ECDSA2_txt;
				}
				else
				{
					string alg = ECDSA2_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certECDSA2.Text = "";
				//ECDSA_cert = textBox_certECDSA2.Text.ToString();
				//Properties.Settings.Default.ECDSA_cert = ECDSA_cert;
				//Properties.Settings.Default.Save();
				textBox_certECDSA.Visible = false;
			}
		}

		private void checkBox_RSA2_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			RSA_cert = textBox_certRSA.Text.ToString();
			Properties.Settings.Default.RSA_cert = RSA_cert;
			Properties.Settings.Default.Save();
			RSA2_txt = "RSA 2 (Cert. #" + RSA_cert + ")";

			if (checkBox_RSA.Checked == true)
			{
				btn_RSA.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = RSA2_txt;
				}
				else
				{
					string alg = RSA2_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; RSA 2 (Cert. #" + RSA_cert + ")";
					}
				}
				textBox_certRSA.Text = RSA_cert;
				textBox_certRSA.Visible = true;
			}
			else
			{
				btn_RSA.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = RSA2_txt;
				}
				else
				{
					string alg = RSA2_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certRSA2.Text = "";
				//RSA_cert = textBox_certRSA2.Text.ToString();
				//Properties.Settings.Default.RSA_cert = RSA_cert;
				//Properties.Settings.Default.Save();
				textBox_certRSA.Visible = false;
			}
		}

		private void textBox_certHMAC_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox_certCCM_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox_certCMAC_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox_certKASFFC_TextChanged(object sender, EventArgs e)
		{

		}

		private void checkBox_HMAC_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			HMAC_cert = textBox_certHMAC.Text.ToString();
			Properties.Settings.Default.HMAC_cert = HMAC_cert;
			Properties.Settings.Default.Save();
			HMAC_txt = "HMAC (Cert. #" + HMAC_cert + ")";

			if (checkBox_HMAC.Checked == true)
			{
				btn_HMAC.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = HMAC_txt;
				}
				else
				{
					string alg = HMAC_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; HMAC (Cert. #" + HMAC_cert + ")";
					}
				}
				textBox_certHMAC.Text = HMAC_cert;
				textBox_certHMAC.Visible = true;
			}
			else
			{
				btn_HMAC.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = HMAC_txt;
				}
				else
				{
					string alg = HMAC_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certHMAC.Text = "";
				//HMAC_cert = textBox_certHMAC.Text.ToString();
				//Properties.Settings.Default.HMAC_cert = HMAC_cert;
				//Properties.Settings.Default.Save();
				textBox_certHMAC.Visible = false;
			}
		}

		private void checkBox_CMAC_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			CMAC_cert = textBox_certCMAC.Text.ToString();
			Properties.Settings.Default.CMAC_cert = CMAC_cert;
			Properties.Settings.Default.Save();
			CMAC_txt = "CMAC (Cert. #" + CMAC_cert + ")";

			if (checkBox_CMAC.Checked == true)
			{
				btn_CMAC.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = CMAC_txt;
				}
				else
				{
					string alg = CMAC_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; CMAC (Cert. #" + CMAC_cert + ")";
					}
				}
				textBox_certCMAC.Text = CMAC_cert;
				textBox_certCMAC.Visible = true;
			}
			else
			{
				btn_CMAC.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = CMAC_txt;
				}
				else
				{
					string alg = CMAC_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certCMAC.Text = "";
				//CMAC_cert = textBox_certCMAC.Text.ToString();
				//Properties.Settings.Default.CMAC_cert = CMAC_cert;
				//Properties.Settings.Default.Save();
				textBox_certCMAC.Visible = false;
			}
		}

		private void checkBox_CCM_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			CCM_cert = textBox_certCCM.Text.ToString();
			Properties.Settings.Default.CCM_cert = CCM_cert;
			Properties.Settings.Default.Save();
			CCM_txt = "CCM (Cert. #" + CCM_cert + ")";

			if (checkBox_CCM.Checked == true)
			{
				btn_CCM.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = CCM_txt;
				}
				else
				{
					string alg = CCM_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; CCM (Cert. #" + CCM_cert + ")";
					}
				}
				textBox_certCCM.Text = CCM_cert;
				textBox_certCCM.Visible = true;
			}
			else
			{
				btn_CCM.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = CCM_txt;
				}
				else
				{
					string alg = CCM_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certCCM.Text = "";
				//CCM_cert = textBox_certCCM.Text.ToString();
				//Properties.Settings.Default.CCM_cert = CCM_cert;
				//Properties.Settings.Default.Save();
				textBox_certCCM.Visible = false;
			}
		}

		private void checkBox_KASFFC_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			KAS_FFC_cert = textBox_certKASFFC.Text.ToString();
			Properties.Settings.Default.KAS_FFC_cert = KAS_FFC_cert;
			Properties.Settings.Default.Save();
			KAS_FFC_txt = "KAS FFC (Cert. #" + KAS_FFC_cert + ")";

			if (checkBox_KASFFC.Checked == true)
			{
				btn_FFC.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KAS_FFC_txt;
				}
				else
				{
					string alg = KAS_FFC_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}
					
					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; KAS FFC (Cert. #" + KAS_FFC_cert + ")";
					}
				}
				textBox_certKASFFC.Text = KAS_FFC_cert;
				textBox_certKASFFC.Visible = true;
			}
			else
			{
				btn_FFC.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KAS_FFC_txt;
				}
				else
				{
					string alg = KAS_FFC_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certKASFFC.Text = "";
				//KAS_FFC_cert = textBox_certKASFFC.Text.ToString();
				//Properties.Settings.Default.KAS_FFC_cert = KAS_FFC_cert;
				//Properties.Settings.Default.Save();
				textBox_certKASFFC.Visible = false;
			}
		}

		private void checkBox_KASECC_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			KAS_ECC_cert = textBox_certKASECC.Text.ToString();
			Properties.Settings.Default.KAS_ECC_cert = KAS_ECC_cert;
			Properties.Settings.Default.Save();
			KAS_ECC_txt = "KAS ECC (Cert. #" + KAS_ECC_cert + ")";

			if (checkBox_KASECC.Checked == true)
			{
				btn_ECC.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KAS_ECC_txt;
				}
				else
				{
					string alg = KAS_ECC_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; KAS ECC (Cert. #" + KAS_ECC_cert + ")";
					}
				}
				textBox_certKASECC.Text = KAS_ECC_cert;
				textBox_certKASECC.Visible = true;
			}
			else
			{
				btn_ECC.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KAS_ECC_txt;
				}
				else
				{
					string alg = KAS_ECC_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certKASECC.Text = "";
				//KAS_ECC_cert = textBox_certKASECC.Text.ToString();
				//Properties.Settings.Default.KAS_ECC_cert = KAS_ECC_cert;
				//Properties.Settings.Default.Save();
				textBox_certKASECC.Visible = false;
			}
		}

		private void checkBox_KDF108_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			KDF_108_cert = textBox_certKDF108.Text.ToString();
			Properties.Settings.Default.KDF_108_cert = KDF_108_cert;
			Properties.Settings.Default.Save();
			KDF_108_txt = "KDF (SP800-108) (Cert. #" + KDF_108_cert + ")";
			
			if (checkBox_KDF108.Checked == true)
			{
				btn_KDF108.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KDF_108_txt;
				}
				else
				{
					string alg = KDF_108_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; KDF (SP800-108) (Cert. #" + KDF_108_cert + ")";
					}
				}
				textBox_certKDF108.Text = KDF_108_cert;
				textBox_certKDF108.Visible = true;
			}
			else
			{
				btn_KDF108.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KDF_108_txt;
				}
				else
				{
					string alg = KDF_108_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certKDF108.Text = "";
				//KDF_108_cert = textBox_certKDF108.Text.ToString();
				//Properties.Settings.Default.KDF_108_cert = KDF_108_cert;
				//Properties.Settings.Default.Save();
				textBox_certKDF108.Visible = false;
			}
		}

		private void checkBox_KDF135_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			KDF_135_cert = textBox_certKDF135.Text.ToString();
			Properties.Settings.Default.KDF_135_cert = KDF_135_cert;
			Properties.Settings.Default.Save();
			KDF_135_txt = "KDF (SP800-135) (Cert. #" + KDF_135_cert + ")";

			if (checkBox_KDF135.Checked == true)
			{
				btn_KDF108.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KDF_135_txt;
				}
				else
				{
					string alg = KDF_135_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}
					
					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; KDF (SP800-135) (Cert. #" + KDF_135_cert + ")";
					}
				}
				textBox_certKDF135.Text = KDF_135_cert;
				textBox_certKDF135.Visible = true;
			}
			else
			{
				btn_KDF108.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KDF_135_txt;
				}
				else
				{
					string alg = KDF_135_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certKDF135.Text = "";
				//KDF_135_cert = textBox_certKDF135.Text.ToString();
				//Properties.Settings.Default.KDF_135_cert = KDF_135_cert;
				//Properties.Settings.Default.Save();
				textBox_certKDF135.Visible = false;
			}
		}

		private void checkBox_KeyWrap_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			KeyWrap_cert = textBox_certKeyWrap.Text.ToString();
			Properties.Settings.Default.KeyWrap_cert = KeyWrap_cert;
			Properties.Settings.Default.Save();
			KeyWrap_txt = "Key Wrap (Cert. #" + KeyWrap_cert + ")";

			if (checkBox_KeyWrap.Checked == true)
			{
				btn_KeyWrap.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KeyWrap_txt;
				}
				else
				{
					string alg = KeyWrap_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; Key Wrap (Cert. #" + KeyWrap_cert + ")";
					}
				}

				textBox_certKeyWrap.Text    = KeyWrap_cert;
				textBox_certKeyWrap.Visible = true;
			}
			else
			{
				btn_KeyWrap.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KeyWrap_txt;
				}
				else
				{
					string alg = KeyWrap_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certKeyWrap.Text = "";
				//KeyWrap_cert = textBox_certKeyWrap.Text.ToString();
				//Properties.Settings.Default.KeyWrap_cert = KeyWrap_cert;
				//Properties.Settings.Default.Save();
				textBox_certKeyWrap.Visible = false;
			}
		}

		private void checkBox_CVL_CheckedChanged(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			CVL_cert = textBox_certCVL.Text.ToString();
			Properties.Settings.Default.CVL_cert = CVL_cert;
			Properties.Settings.Default.Save();
			CVL_txt = "CVL (Cert. #" + CVL_cert + ")";

			if (checkBox_CVL.Checked == true)
			{
				btn_CompVL.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = CVL_txt;
				}
				else
				{
					string alg = CVL_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}
						
					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; CVL (Cert. #" + CVL_cert + ")";
					}

				}
				textBox_certCVL.Text = CVL_cert;
				textBox_certCVL.Visible = true;
			}
			else
			{
				btn_CompVL.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = CVL_txt;
				}
				else
				{
					string alg = CVL_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				//textBox_certCVL.Text = "";
				//CVL_cert = textBox_certCVL.Text.ToString();
				//Properties.Settings.Default.CVL_cert = CVL_cert;
				//Properties.Settings.Default.Save();
				textBox_certCVL.Visible = false;
			}
		}

		private void textBox_certKDF108_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void btn_CVL_Click_1(object sender, EventArgs e)
		{
			
		}

		private void btn_KDF_Click_2(object sender, EventArgs e)
		{
			KDF108 f1 = new KDF108();
			f1.ShowDialog();
		}

		private void btn_KDF135_Click(object sender, EventArgs e)
		{
			KDF135 f1 = new KDF135();
			f1.ShowDialog();
		}

		private void btn_KeyWrap_Click_1(object sender, EventArgs e)
		{
			KeyWrap f1 = new KeyWrap();
			f1.ShowDialog();
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void textBox_Algs_TextChanged(object sender, EventArgs e)
		{

		}

		private void checkBox_KDF108_CheckedChanged_1(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			KDF_108_cert = textBox_certKDF108.Text.ToString();
			Properties.Settings.Default.KDF_108_cert = KDF_108_cert;
			Properties.Settings.Default.Save();
			KDF_108_txt = "KDF (SP800-108) (Cert. #" + KDF_108_cert + ")";

			if (checkBox_KDF108.Checked == true)
			{
				btn_KDF108.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KDF_108_txt;
				}
				else
				{
					string alg = KDF_108_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; KDF (SP800-108) (Cert. #" + KDF_108_cert + ")";
					}
				}
				textBox_certKDF108.Text = KDF_108_cert;
				textBox_certKDF108.Visible = true;
			}
			else
			{
				btn_KDF108.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KDF_108_txt;
				}
				else
				{
					string alg = KDF_108_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
		
				textBox_certKDF108.Visible = false;
			}
		}

		private void textBox_certKASECC_TextChanged(object sender, EventArgs e)
		{

		}

		private void checkBox_KDF135_CheckedChanged_1(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			KDF_135_cert = textBox_certKDF135.Text.ToString();
			Properties.Settings.Default.KDF_135_cert = KDF_135_cert;
			Properties.Settings.Default.Save();
			KDF_135_txt = "KDF (SP800-135) (Cert. #" + KDF_135_cert + ")";

			if (checkBox_KDF135.Checked == true)
			{
				btn_KDF135.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KDF_135_txt;
				}
				else
				{
					string alg = KDF_135_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; KDF (SP800-135) (Cert. #" + KDF_135_cert + ")";
					}
				}
				textBox_certKDF135.Text = KDF_135_cert;
				textBox_certKDF135.Visible = true;
			}
			else
			{
				btn_KDF135.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KDF_135_txt;
				}
				else
				{
					string alg = KDF_135_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}
				textBox_certKDF135.Visible = false;
			}
		}

		private void checkBox_KeyWrap_CheckedChanged_1(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			KeyWrap_cert = textBox_certKeyWrap.Text.ToString();
			Properties.Settings.Default.KeyWrap_cert = KeyWrap_cert;
			Properties.Settings.Default.Save();
			KeyWrap_txt = "Key Wrap (Cert. #" + KeyWrap_cert + ")";

			if (checkBox_KeyWrap.Checked == true)
			{
				btn_KeyWrap.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KeyWrap_txt;
				}
				else
				{
					string alg = KeyWrap_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; Key Wrap (Cert. #" + KeyWrap_cert + ")";
					}
				}
				textBox_certKeyWrap.Text = KeyWrap_cert;
				textBox_certKeyWrap.Visible = true;
			}
			else
			{
				btn_KeyWrap.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = KeyWrap_txt;
				}
				else
				{
					string alg = KeyWrap_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}

				textBox_certKeyWrap.Visible = false;
			}
		}

		private void textBox_certCVL_TextChanged(object sender, EventArgs e)
		{
		}

		private void checkBox_CVL_CheckedChanged_1(object sender, EventArgs e)
		{
			//saveCertNoToSettings();
			CVL_cert = textBox_certCVL.Text.ToString();
			Properties.Settings.Default.CVL_cert = CVL_cert;
			Properties.Settings.Default.Save();
			CVL_txt = "CVL (Cert. #" + CVL_cert + ")";

			if (checkBox_CVL.Checked == true)
			{
				btn_CompVL.Enabled = true;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = CVL_txt;
				}
				else
				{
					string alg = CVL_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					int c0 = 0;
					foreach (string temp1 in tempVec)
					{
						if (alg.Equals(temp1))
						{
							c0 = 1;
						}
					}

					if (c0 == 0)
					{
						textBox_Algs.Text = temp + "; CVL (Cert. #" + CVL_cert + ")";
					}
				}
				textBox_certCVL.Text = CVL_cert;
				textBox_certCVL.Visible = true;
			}
			else
			{
				btn_CompVL.Enabled = false;
				string temp = textBox_Algs.Text;
				if (temp == "")
				{
					textBox_Algs.Text = CVL_txt;
				}
				else
				{
					string alg = CVL_txt;
					string[] tempVec = temp.Split(';');
					string newtemp1;
					int i = 0;
					foreach (string temp1 in tempVec)
					{
						char[] tempChar = temp1.ToCharArray();

						if (tempChar[0] == 32)
						{
							newtemp1 = temp1.TrimStart(tempChar[0]);
							//string s = new string(tempChar);		
							tempVec[i] = newtemp1;
						}
						i = i + 1;
					}

					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (alg.Equals(tempVec[i1]))
						{
							tempVec[i1] = null;
						}
					}

					string temp2 = null;
					for (int i1 = 0; i1 < tempVec.Length; i1++)
					{
						if (i1 == tempVec.Length - 1)
						{
							temp2 = temp2 + tempVec[i1];
						}
						else
						{
							if (tempVec[i1] != null)
							{
								if ((tempVec[i1 + 1] == null) && i1 + 1 == tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1];
								}
								else if ((tempVec[i1 + 1] == null) && i1 + 1 != tempVec.Length - 1)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
								else if (tempVec[i1 + 1] != null)
								{
									temp2 = temp2 + tempVec[i1] + "; ";
								}
							}
							else
							{
								temp2 = temp2 + tempVec[i1];
							}
						}
					}
					textBox_Algs.Text = temp2;
				}

				textBox_certCVL.Visible = false;
			}
		}

		private void groupBox7_Enter(object sender, EventArgs e)
		{

		}

		private void textBox_certKDF108_TextChanged_1(object sender, EventArgs e)
		{

		}
	}
}


