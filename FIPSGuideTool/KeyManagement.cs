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
	public partial class KeyManagement : Form
	{
		public static string KeyEntryOutput;
		public static string KeyGen;
		public static string RNG_employment;
		public static string KeyEstablishment;
		public static string KeyStorage;
		public static string KeyZeroization;
		public static string OTAR;
		public static string SplitKnowledge;
		public static string CSPProtcStratg;  
		public static string PubKeyProtect;
		public static string PubKeyEntry;
		public static string CryptKeyList;
		public static string AppRNGFunc;
		public static string SeedLength;
		public static string SeedKeyLength;
		public static string nonAppRNGFunc;
		public static string KeyGenSecurity;
		public static string AppKeyEstab;
		public static string KeyEstabSecurity;		
		public static string ManualKeyEntry;		
		public static string ManualKeyEntry_enc;		
		public static string ManualKeyEntry_spltKnlg;		
		public static string AutoKeyEntry;		

		public KeyManagement()
		{
			InitializeComponent();

			KeyEntryOutput   = Properties.Settings.Default.KeyEntryOutput.ToString();
			ManualKeyEntry   = Properties.Settings.Default.ManualKeyEntry.ToString();
			ManualKeyEntry_enc      = Properties.Settings.Default.ManualKeyEntry_enc.ToString();
			ManualKeyEntry_spltKnlg = Properties.Settings.Default.ManualKeyEntry_spltKnlg.ToString();
			AutoKeyEntry     = Properties.Settings.Default.AutoKeyEntry.ToString();
			KeyGen           = Properties.Settings.Default.KeyGen.ToString();
			RNG_employment   = Properties.Settings.Default.RNG_employment.ToString();
			KeyEstablishment = Properties.Settings.Default.KeyEstablishment.ToString();
			KeyStorage       = Properties.Settings.Default.KeyStorage.ToString();
			KeyZeroization   = Properties.Settings.Default.KeyZeroization.ToString();
			CSPProtcStratg   = Properties.Settings.Default.CSPProtcStratg.ToString();
			PubKeyProtect    = Properties.Settings.Default.PubKeyProtect.ToString();
			PubKeyEntry      = Properties.Settings.Default.PubKeyEntry.ToString();
			CryptKeyList     = Properties.Settings.Default.CryptKeyList.ToString();
			AppRNGFunc       = Properties.Settings.Default.AppRNGFunc.ToString();
			SeedLength       = Properties.Settings.Default.SeedLength.ToString();
			SeedKeyLength    = Properties.Settings.Default.SeedKeyLength.ToString();
			nonAppRNGFunc    = Properties.Settings.Default.nonAppRNGFunc.ToString();
			KeyGenSecurity   = Properties.Settings.Default.KeyGenSecurity.ToString();
			AppKeyEstab      = Properties.Settings.Default.AppKeyEstab.ToString();
			KeyEstabSecurity = Properties.Settings.Default.KeyEstabSecurity.ToString();
			OTAR             = Properties.Settings.Default.OTAR.ToString();
			SplitKnowledge   = Properties.Settings.Default.SplitKnowledge.ToString();

			if (KeyEntryOutput == "True")
			{
				checkBox_KeyEntryOutput.Checked = true;

				if (ManualKeyEntry == "True")
				{
					checkBox_ManuKeyEntry.Checked = true;
					checkBox_ManuKeyEntry.Visible = true;
					checkBox_ManuEnt_SpltKnlg.Visible = true;
					checkBox_ManuEnt_encrp.Visible = true;

					if (ManualKeyEntry_enc == "True")
					{
						checkBox_ManuEnt_encrp.Checked = true;
					}
					else
					{
						checkBox_ManuEnt_encrp.Checked = false;
					}


					if (ManualKeyEntry_spltKnlg == "True")
					{
						checkBox_ManuEnt_SpltKnlg.Checked = true;
					}
					else
					{
						checkBox_ManuEnt_SpltKnlg.Checked = false;
					}
				}
				else
				{
					checkBox_ManuKeyEntry.Checked = false;
					checkBox_ManuKeyEntry.Visible = true;
					checkBox_AutoMethod.Checked = false;
					checkBox_AutoMethod.Visible = true;
				}

				if (AutoKeyEntry == "True")
				{
					checkBox_AutoMethod.Checked = true;
					checkBox_AutoMethod.Visible = true;
				}
				else
				{
					checkBox_ManuKeyEntry.Checked = false;
					checkBox_ManuKeyEntry.Visible = true;
					checkBox_AutoMethod.Checked = false;
					checkBox_AutoMethod.Visible = true;
				}
			}
			else
			{
				checkBox_ManuKeyEntry.Visible = false;
				checkBox_AutoMethod.Visible = false;
			}



			if (KeyGen == "True")
			{
				checkBox_KeyGen.Checked = true;
			}

			if (RNG_employment == "True")
			{
				checkBox_RNG.Checked = true;
			}

			if (KeyEstablishment == "True")
			{
				checkBox_KeyEstablishment.Checked = true;
			}

			if (KeyStorage == "True")
			{
				checkBox_KeyStorage.Checked = true;
			}

			if (KeyZeroization == "True")
			{
				checkBox_KeyZeroization.Checked = true;
			}

			if (OTAR == "True")
			{
				checkBox_OTAR.Checked = true;
			}

			if (SplitKnowledge == "True")
			{
				checkBox_Split_Knowledge.Checked = true;
			}
		}
	
		private void KeyManagement_Load(object sender, EventArgs e)
		{			
		}

		private void KeyManagement_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				RNG_employment = checkBox_RNG.Checked.ToString();
				Properties.Settings.Default.RNG_employment = RNG_employment;

				KeyEntryOutput = checkBox_KeyEntryOutput.Checked.ToString();
				Properties.Settings.Default.KeyEntryOutput = KeyEntryOutput;

				ManualKeyEntry = checkBox_ManuKeyEntry.Checked.ToString();
				Properties.Settings.Default.ManualKeyEntry = ManualKeyEntry;

				ManualKeyEntry_enc = checkBox_ManuEnt_encrp.Checked.ToString();
				Properties.Settings.Default.ManualKeyEntry_enc = ManualKeyEntry_enc;

				ManualKeyEntry_spltKnlg = checkBox_ManuEnt_SpltKnlg.Checked.ToString();
				Properties.Settings.Default.ManualKeyEntry_spltKnlg = ManualKeyEntry_spltKnlg;

				AutoKeyEntry = checkBox_AutoMethod.Checked.ToString();
				Properties.Settings.Default.AutoKeyEntry = AutoKeyEntry;

				KeyGen = checkBox_KeyGen.Checked.ToString();
				Properties.Settings.Default.KeyGen = KeyGen;

				KeyEstablishment = checkBox_KeyEstablishment.Checked.ToString();
				Properties.Settings.Default.KeyEstablishment = KeyEstablishment;

				KeyStorage = checkBox_KeyStorage.Checked.ToString();
				Properties.Settings.Default.KeyStorage = KeyStorage;

				KeyZeroization = checkBox_KeyZeroization.Checked.ToString();
				Properties.Settings.Default.KeyZeroization = KeyZeroization;

				OTAR  = checkBox_OTAR.Checked.ToString();
				Properties.Settings.Default.OTAR = OTAR;

				SplitKnowledge = checkBox_Split_Knowledge.Checked.ToString();
				Properties.Settings.Default.SplitKnowledge = SplitKnowledge;

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
			}
		}

		private void btn_protectionStratg_Click(object sender, EventArgs e)
		{
			KeyProtStratg f1 = new KeyProtStratg();
			f1.ShowDialog();
		}

		private void btn_PubKeyProtec_Click(object sender, EventArgs e)
		{
			PubKeyProtection f1 = new PubKeyProtection();
			f1.ShowDialog();
		}

		private void btn_TE070101_Click(object sender, EventArgs e)
		{
			txtBox_TE070101.Visible = true;
			txtBox_TE070201.Visible = false;
			txtBox_TE070202.Visible = false;
			txtBox_TE070301.Visible = false;
			txtBox_TE070801.Visible = false;
			txtBox_TE070802.Visible = false;
			txtBox_TE070901.Visible = false;
			txtBox_TE071001.Visible = false;
			txtBox_TE071301.Visible = false;
			txtBox_TE071701.Visible = false;
			txtBox_TE071702.Visible = false;
			txtBox_TE071901.Visible = false;

			KeyManagementAssertions f2 = new KeyManagementAssertions();
			f2.populateKeyManagementLevel1234();

			txtBox_TE070101.Text = KeyManagementAssertions.TE070101;	
		}

		private void btn_TE070201_Click(object sender, EventArgs e)
		{
			txtBox_TE070101.Visible = false;
			txtBox_TE070201.Visible = true;
			txtBox_TE070202.Visible = false;
			txtBox_TE070301.Visible = false;
			txtBox_TE070801.Visible = false;
			txtBox_TE070802.Visible = false;
			txtBox_TE070901.Visible = false;
			txtBox_TE071001.Visible = false;
			txtBox_TE071301.Visible = false;
			txtBox_TE071701.Visible = false;
			txtBox_TE071702.Visible = false;
			txtBox_TE071901.Visible = false;
			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();

			txtBox_TE070201.Text = KeyManagementAssertions.TE070201;
		}

		private void txtBox_TE070801_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_TE070202_Click(object sender, EventArgs e)
		{
			txtBox_TE070101.Visible = false;
			txtBox_TE070201.Visible = false;
			txtBox_TE070202.Visible = true;
			txtBox_TE070301.Visible = false;
			txtBox_TE070801.Visible = false;
			txtBox_TE070802.Visible = false;
			txtBox_TE070901.Visible = false;
			txtBox_TE071001.Visible = false;
			txtBox_TE071301.Visible = false;
			txtBox_TE071701.Visible = false;
			txtBox_TE071702.Visible = false;
			txtBox_TE071901.Visible = false;

			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();

			txtBox_TE070202.Text = KeyManagementAssertions.TE070202;
		}

		private void btn_TE070301_Click(object sender, EventArgs e)
		{
			txtBox_TE070101.Visible = false;
			txtBox_TE070201.Visible = false;
			txtBox_TE070202.Visible = false;
			txtBox_TE070301.Visible = true;
			txtBox_TE070801.Visible = false;
			txtBox_TE070802.Visible = false;
			txtBox_TE070901.Visible = false;
			txtBox_TE071001.Visible = false;
			txtBox_TE071301.Visible = false;
			txtBox_TE071701.Visible = false;
			txtBox_TE071702.Visible = false;
			txtBox_TE071901.Visible = false;

			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();

			txtBox_TE070301.Text = KeyManagementAssertions.TE070301;
		}

		private void btn_TE070801_Click(object sender, EventArgs e)
		{
			txtBox_TE070101.Visible = false;
			txtBox_TE070201.Visible = false;
			txtBox_TE070202.Visible = false;
			txtBox_TE070301.Visible = false;
			txtBox_TE070801.Visible = true;
			txtBox_TE070802.Visible = false;
			txtBox_TE070901.Visible = false;
			txtBox_TE071001.Visible = false;
			txtBox_TE071301.Visible = false;
			txtBox_TE071701.Visible = false;
			txtBox_TE071702.Visible = false;
			txtBox_TE071901.Visible = false;

			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();

			txtBox_TE070801.Text = KeyManagementAssertions.TE070801;
		}

		private void btn_TE070802_Click(object sender, EventArgs e)
		{
			txtBox_TE070101.Visible = false;
			txtBox_TE070201.Visible = false;
			txtBox_TE070202.Visible = false;
			txtBox_TE070301.Visible = false;
			txtBox_TE070801.Visible = false;
			txtBox_TE070802.Visible = true;
			txtBox_TE070901.Visible = false;
			txtBox_TE071001.Visible = false;
			txtBox_TE071301.Visible = false;
			txtBox_TE071701.Visible = false;
			txtBox_TE071702.Visible = false;
			txtBox_TE071901.Visible = false;

			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();

			txtBox_TE070802.Text = KeyManagementAssertions.TE070802;
		}

		private void btn_TE070901_Click(object sender, EventArgs e)
		{
			txtBox_TE070101.Visible = false;
			txtBox_TE070201.Visible = false;
			txtBox_TE070202.Visible = false;
			txtBox_TE070301.Visible = false;
			txtBox_TE070801.Visible = false;
			txtBox_TE070802.Visible = false;
			txtBox_TE070901.Visible = true;
			txtBox_TE071001.Visible = false;
			txtBox_TE071301.Visible = false;
			txtBox_TE071701.Visible = false;
			txtBox_TE071702.Visible = false;
			txtBox_TE071901.Visible = false;

			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();

			txtBox_TE070901.Text = KeyManagementAssertions.TE070901;
		}

		private void btn_TE071001_Click(object sender, EventArgs e)
		{
			txtBox_TE070101.Visible = false;
			txtBox_TE070201.Visible = false;
			txtBox_TE070202.Visible = false;
			txtBox_TE070301.Visible = false;
			txtBox_TE070801.Visible = false;
			txtBox_TE070802.Visible = false;
			txtBox_TE070901.Visible = false;
			txtBox_TE071001.Visible = true;
			txtBox_TE071301.Visible = false;
			txtBox_TE071701.Visible = false;
			txtBox_TE071702.Visible = false;
			txtBox_TE071901.Visible = false;

			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();

			txtBox_TE071001.Text = KeyManagementAssertions.TE071001;
		}

		private void btn_TE071301_Click(object sender, EventArgs e)
		{
			txtBox_TE070101.Visible = false;
			txtBox_TE070201.Visible = false;
			txtBox_TE070202.Visible = false;
			txtBox_TE070301.Visible = false;
			txtBox_TE070801.Visible = false;
			txtBox_TE070802.Visible = false;
			txtBox_TE070901.Visible = false;
			txtBox_TE071001.Visible = false;
			txtBox_TE071301.Visible = true;
			txtBox_TE071701.Visible = false;
			txtBox_TE071702.Visible = false;
			txtBox_TE071901.Visible = false;

			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();

			txtBox_TE071301.Text = KeyManagementAssertions.TE071301;
		}

		private void btn_TE071701_Click(object sender, EventArgs e)
		{
			txtBox_TE070101.Visible = false;
			txtBox_TE070201.Visible = false;
			txtBox_TE070202.Visible = false;
			txtBox_TE070301.Visible = false;
			txtBox_TE070801.Visible = false;
			txtBox_TE070802.Visible = false;
			txtBox_TE070901.Visible = false;
			txtBox_TE071001.Visible = false;
			txtBox_TE071301.Visible = false;
			txtBox_TE071701.Visible = true;
			txtBox_TE071702.Visible = false;
			txtBox_TE071901.Visible = false;

			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();

			txtBox_TE071701.Text = KeyManagementAssertions.TE071701;
		}

		private void btn_TE071702_Click(object sender, EventArgs e)
		{
			txtBox_TE070101.Visible = false;
			txtBox_TE070201.Visible = false;
			txtBox_TE070202.Visible = false;
			txtBox_TE070301.Visible = false;
			txtBox_TE070801.Visible = false;
			txtBox_TE070802.Visible = false;
			txtBox_TE070901.Visible = false;
			txtBox_TE071001.Visible = false;
			txtBox_TE071301.Visible = false;
			txtBox_TE071701.Visible = false;
			txtBox_TE071702.Visible = true;
			txtBox_TE071901.Visible = false;

			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();

			txtBox_TE071702.Text = KeyManagementAssertions.TE071702;
		}

		private void btn_TE071901_Click(object sender, EventArgs e)
		{
			txtBox_TE070101.Visible = false;
			txtBox_TE070201.Visible = false;
			txtBox_TE070202.Visible = false;
			txtBox_TE070301.Visible = false;
			txtBox_TE070801.Visible = false;
			txtBox_TE070802.Visible = false;
			txtBox_TE070901.Visible = false;
			txtBox_TE071001.Visible = false;
			txtBox_TE071301.Visible = false;
			txtBox_TE071701.Visible = false;
			txtBox_TE071702.Visible = false;
			txtBox_TE071901.Visible = true;

			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();

			txtBox_TE071901.Text = KeyManagementAssertions.TE071901;
		}

		private void btn_PubKeyEntryMethod_Click(object sender, EventArgs e)
		{
			PubKeyEntryMethod f1 = new PubKeyEntryMethod();
			f1.ShowDialog();
		}

		private void btn_CryptKeysList_Click(object sender, EventArgs e)
		{
			KeyList f1 = new KeyList();
			f1.ShowDialog();
		}

		private void btn_ApprovedRNG_Click(object sender, EventArgs e)
		{
			ApprovedRNG f1 = new ApprovedRNG();
			f1.ShowDialog();
		}

		private void btn_Seed_Click(object sender, EventArgs e)
		{
			Seed_SeedKey f1 = new Seed_SeedKey();
			f1.ShowDialog();
		}

		private void btn_nonAppRNG_Click(object sender, EventArgs e)
		{
			nonApprovedRNG f1 = new nonApprovedRNG();
			f1.ShowDialog();
		}

		private void btn_KeyGenSec_Click(object sender, EventArgs e)
		{
			KeyGenSec f1 = new KeyGenSec();
			f1.ShowDialog();
		}

		private void btn_AppKeyEstab_Click(object sender, EventArgs e)
		{
			AppKeyEstablishment f1 = new AppKeyEstablishment();
			f1.ShowDialog();
		}

		private void btn_KeyEstbSec_Click(object sender, EventArgs e)
		{
			KeyEstabSec f1 = new KeyEstabSec();
			f1.ShowDialog();
		}


		private void checkBox_KeyEntry_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_KeyEntryOutput.Checked == true)
			{
				KeyEntryOutput = "True";
				checkBox_ManuKeyEntry.Visible = true;
				checkBox_AutoMethod.Visible = true;
			}
			else
			{
				KeyEntryOutput = "False";
				checkBox_ManuKeyEntry.Visible = false;
				checkBox_AutoMethod.Visible = false;
			}
		}

		private void checkBox_ManuKeyEntry_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_ManuKeyEntry.Checked)
			{
				ManualKeyEntry_enc = "True";
				checkBox_ManuEnt_SpltKnlg.Visible = true;
				checkBox_ManuEnt_encrp.Visible = true;
			}
			else
			{
				ManualKeyEntry_enc = "False";
				checkBox_ManuEnt_SpltKnlg.Visible = false;
				checkBox_ManuEnt_encrp.Visible = false;
			}
		}

		private void checkBox_RNG_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_RNG.Checked)
			{
				RNG_employment = "True";
			}
			else
			{
				RNG_employment = "False";
			}
		}

		private void checkBox_OTAR_CheckedChanged(object sender, EventArgs e)
		{		
			if (checkBox_OTAR.Checked)
			{
				OTAR = "True";
			}
			else
			{
				OTAR = "False";
			}
		}

		private void checkBox_KeyZeroization_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_KeyZeroization.Checked)
			{
				KeyZeroization = "True";
			}
			else
			{
				KeyZeroization = "False";
			}
		}

		private void checkBox_KeyStorage_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_KeyStorage.Checked)
			{
				KeyStorage = "True";
			}
			else
			{
				KeyStorage = "False";
			}
		}

		private void checkBox_KeyEstablishment_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_KeyEstablishment.Checked)
			{
				KeyEstablishment = "True";
			}
			else
			{
				KeyEstablishment = "False";
			}
		}

		private void checkBox_Split_Knowledge_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_Split_Knowledge.Checked)
			{
				SplitKnowledge = "True";
			}
			else
			{
				SplitKnowledge = "False";
			}
		}

		private void checkBox_KeyGen_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_KeyGen.Checked)
			{
				KeyGen = "True";
			}
			else
			{
				KeyGen = "False";
			}
		}

		private void checkBox_AutoMethod_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_AutoMethod.Checked)
			{
				AutoKeyEntry = "True";
			}
			else
			{
				AutoKeyEntry = "False";
			}
		}

		private void checkBox_ManuEnt_encrp_CheckedChanged(object sender, EventArgs e)
		{			
			if (checkBox_ManuEnt_encrp.Checked)
			{
				ManualKeyEntry_enc = "True";
			}
			else
			{
				ManualKeyEntry_enc = "False";
			}
		}

		private void checkBox_ManuEnt_SpltKnlg_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_ManuEnt_SpltKnlg.Checked)
			{
				ManualKeyEntry_spltKnlg = "True";
			}
			else
			{
				ManualKeyEntry_spltKnlg = "False";
			}
		}

		private void btn_Entropy_Click(object sender, EventArgs e)
		{
			Entropy f4 = new Entropy();
			f4.ShowDialog();
		}
	}
}