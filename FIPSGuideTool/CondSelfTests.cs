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
	public partial class CondSelfTests : Form
	{
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

		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();
		DataTable DT = new DataTable();

		public CondSelfTests()
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
		}

		private void CondSelfTests_Load(object sender, EventArgs e)
		{
			// add columns
			DT.Columns.Add("Algorithm", typeof(string));
			DT.Columns.Add("Conditional Self-Test Type", typeof(string));
			DT.Columns.Add("Key Lengths, Curves or Moduli", typeof(string));
			DT.Columns.Add("Error Cause", typeof(string));
			DT.Columns.Add("Error State", typeof(string));
			DT.Columns.Add("Error Indicator", typeof(string));
			DT.Columns.Add("Error Resolution", typeof(string));
			DT.Columns.Add("Test Notes", typeof(string));

			if (AES == "True")
			{
				//DT.Rows.Add("AES", "", "", "", "", "", "", "");
			}

			if (CCM == "True")
			{
				//DT.Rows.Add("CCM", "", "", "", "", "", "", "");
			}

			if (CMAC == "True")
			{
				//DT.Rows.Add("CMAC", "", "", "", "", "", "", "");
			}

			if (CVL == "True")
			{
				DT.Rows.Add("CVL", "56A (per IG 9.6): DH or ECDH" + Environment.NewLine +
					"- Conditional Tests for Assurances(as relevant):" + Environment.NewLine +
					"• Assurances of Domain Parameter Validity(SP 800-56A, rev 1: 5.5.2)" + Environment.NewLine +
					"• Assurances of Arithmetic Validity of a Public Key(56A, rev 1: 5.6.2)" + Environment.NewLine +
					"• Assurances of Possession of a Static Private Key(56A, rev 1: 5.6.3)" + Environment.NewLine +
					"- PWCT on each prerequisite(that is not tested elsewhere)(56A, rev3, 5.6.2.1.4)", "", "", "", "", "", "");
			}

			if (DRBG == "True")
			{
				DT.Rows.Add("DRBG", "NDRNG Continuous Health Tests:" + Environment.NewLine +
					"• 90B Compliant(before conditioning):" + Environment.NewLine +
					"- Repetition Count Test" + Environment.NewLine +
					"- Adaptive Proportion Test" + Environment.NewLine +
					"- Or developer-defined tests that meet 90B section 4" + Environment.NewLine +
					"• IG 7.15 compliant" + Environment.NewLine +
					"- Continuous Random Number Generator Test(CRNGT, AS09.42-3)" + Environment.NewLine +
					"- Or Repetition Count Test(IG 9.8)", " ", "", "", "", "", "");
			}

			if (DSA == "True")
			{
				DT.Rows.Add("DSA", "Pairwise Consistency Test (PWCT)" + Environment.NewLine +
					"- For digital signatures, per AS.09.33" + Environment.NewLine +
					"- For key transport, per AS.09.31", "", "", "", "", "", "");
			}

			if (ECDSA == "True")
			{
				DT.Rows.Add("ECDSA", "Pairwise Consistency Test (PWCT)" + Environment.NewLine +
					"- For digital signatures, per AS.09.33" + Environment.NewLine +
					"- For key transport, per AS.09.31", "", "", "", "", "", "");
			}

			if (GCM == "True")
			{
				DT.Rows.Add("GCM", "Module must meet IG A.5 uniqueness requirements", "", "", "", "", "", "");
			}

			if (HMAC == "True")
			{
				//DT.Rows.Add("HMAC", "", "", "", "", "", "", "");
			}

			if (KAS_ECC == "True")
			{
				//DT.Rows.Add("KAS ECC", "", "", "", "", "", "", "");
			}

			if (KAS_FFC == "True")
			{
				//DT.Rows.Add("KAS FFC", "", "", "", "", "", "", "");
			}

			if (KDF_108 == "True")
			{
				DT.Rows.Add("KDF SP800-108", "56A (per IG 9.6): DH or ECDH" + Environment.NewLine +
					"- Conditional Tests for Assurances(as relevant):" + Environment.NewLine +
					"• Assurances of Domain Parameter Validity(SP 800-56A, rev 1: 5.5.2)" + Environment.NewLine +
					"• Assurances of Arithmetic Validity of a Public Key(56A, rev 1: 5.6.2)" + Environment.NewLine +
					"• Assurances of Possession of a Static Private Key(56A, rev 1: 5.6.3)" + Environment.NewLine +
					"- PWCT on each prerequisite(that is not tested elsewhere)(56A, rev3, 5.6.2.1.4)", "", "", "", "", "", "");
			}

			if (KDF_135 == "True")
			{
				DT.Rows.Add("KDF SP800-135", "56A (per IG 9.6): DH or ECDH" + Environment.NewLine +
					"- Conditional Tests for Assurances(as relevant):" + Environment.NewLine +
					"• Assurances of Domain Parameter Validity(SP 800-56A, rev 1: 5.5.2)" + Environment.NewLine +
					"• Assurances of Arithmetic Validity of a Public Key(56A, rev 1: 5.6.2)" + Environment.NewLine +
					"• Assurances of Possession of a Static Private Key(56A, rev 1: 5.6.3)" + Environment.NewLine +
					"- PWCT on each prerequisite(that is not tested elsewhere)(56A, rev3, 5.6.2.1.4)", "", "", "", "", "", "");
			}

			if (KeyWrap == "True")
			{
				DT.Rows.Add("Key Wrap", "56A (per IG 9.6): DH or ECDH" + Environment.NewLine +
					"- Conditional Tests for Assurances(as relevant):" + Environment.NewLine +
					"• Assurances of Domain Parameter Validity(SP 800-56A, rev 1: 5.5.2)" + Environment.NewLine +
					"• Assurances of Arithmetic Validity of a Public Key(56A, rev 1: 5.6.2)" + Environment.NewLine +
					"• Assurances of Possession of a Static Private Key(56A, rev 1: 5.6.3)" + Environment.NewLine +
					"- PWCT on each prerequisite(that is not tested elsewhere)(56A, rev3, 5.6.2.1.4)", "", "", "", "", "", "");
			}

			if (RSA == "True")
			{
				DT.Rows.Add("RSA", "Pairwise Consistency Test (PWCT)" + Environment.NewLine +
					"- For digital signatures, per AS.09.33" + Environment.NewLine +
					"- For key transport, per AS.09.31", "", "", "", "", "", "");
			}

			if (SHA_3 == "True")
			{
				//DT.Rows.Add("SHA-3", "", "", "", "", "", "", "");
			}

			if (SHS == "True")
			{
				//DT.Rows.Add("SHS", "", "", "", "", "", "", "");
			}

			if (TDES == "True")
			{
				DT.Rows.Add("TDES", "Module must enforce Triple-DES encryption limit per IG A.13 item 4", "", "", "", "", "", "");
			}

			if (XTS == "True")
			{
				DT.Rows.Add("XTS", "XTS-AES Key1=/=Key2 conditional test per IG A.9", "", "", "", "", "", "");
			}

			dataGridView_CondSelftests.DataSource = DT;

			dataGridView_CondSelftests.Columns[0].Width = 250;
			dataGridView_CondSelftests.Columns[1].Width = 460;
			dataGridView_CondSelftests.Columns[2].Width = 250;
			dataGridView_CondSelftests.Columns[3].Width = 250;
			dataGridView_CondSelftests.Columns[4].Width = 250;
			dataGridView_CondSelftests.Columns[5].Width = 250;
			dataGridView_CondSelftests.Columns[6].Width = 250;
			dataGridView_CondSelftests.Columns[7].Width = 250;

			dataGridView_CondSelftests.Dock = DockStyle.Fill;
			dataGridView_CondSelftests.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dataGridView_CondSelftests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}