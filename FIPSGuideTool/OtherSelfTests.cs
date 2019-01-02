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
	public partial class OtherSelfTests : Form
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

		public OtherSelfTests()
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

		private void OtherSelfTests_Load(object sender, EventArgs e)
		{
			// add columns
			DT.Columns.Add("Self-Test", typeof(string));
			DT.Columns.Add("Self-Test Type", typeof(string));
			DT.Columns.Add("Key Lengths, Curves or Moduli", typeof(string));
			DT.Columns.Add("Error Cause", typeof(string));
			DT.Columns.Add("Error State", typeof(string));
			DT.Columns.Add("Error Indicator", typeof(string));
			DT.Columns.Add("Error Resolution", typeof(string));
			DT.Columns.Add("Test Notes", typeof(string));

			DT.Rows.Add("Software/Firmware load test (as relevant and per IG 9.7 and FIPS 140-2 4.9.2)", "- Approved Authentication technique(MAC, signature, or HMAC)" + Environment.NewLine +
				"- OR CRC", "", "", "", "", "", "");

			DT.Rows.Add("Manual Key entry test (per FIPS 140-2 4.9.2)", "- EDC(16 - bit min)" + Environment.NewLine +
				"- OR entered using duplicate entries", "", "", "", "", "", "");

			DT.Rows.Add("Bypass test (per FIPS 140-2 4.9.2)", "- Conditional test when switching in and out of bypass" +
				"- Conditional test when the mechanism governing switching is modified", "", "", "", "", "", "");

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
				//DT.Rows.Add("CVL", "", "", "", "", "", "", "");
			}

			if (DRBG == "True")
			{
				//DT.Rows.Add("DRBG", "", " ", "", "", "", "", "");
			}

			if (DSA == "True")
			{
				//DT.Rows.Add("DSA", "", "", "", "", "", "", "");
			}

			if (ECDSA == "True")
			{
				//DT.Rows.Add("ECDSA", "", "", "", "", "", "", "");
			}

			if (GCM == "True")
			{
				//DT.Rows.Add("GCM", "", "", "", "", "", "", "");
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
				//DT.Rows.Add("KDF SP800-108", "", "", "", "", "", "", "");
			}

			if (KDF_135 == "True")
			{
				//DT.Rows.Add("KDF SP800-135", "", "", "", "", "", "", "");
			}

			if (KeyWrap == "True")
			{
				//DT.Rows.Add("Key Wrap", "", "", "", "", "", "", "");
			}

			if (RSA == "True")
			{
				//DT.Rows.Add("RSA", "", "", "", "", "", "", "");
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
				//DT.Rows.Add("TDES", "", "", "", "", "", "", "");
			}

			if (XTS == "True")
			{
				//DT.Rows.Add("XTS", "", "", "", "", "", "", "");
			}

			dataGridView_OtherSelftests.DataSource = DT;

			dataGridView_OtherSelftests.Columns[0].Width = 250;
			dataGridView_OtherSelftests.Columns[1].Width = 480;
			dataGridView_OtherSelftests.Columns[2].Width = 250;
			dataGridView_OtherSelftests.Columns[3].Width = 250;
			dataGridView_OtherSelftests.Columns[4].Width = 250;
			dataGridView_OtherSelftests.Columns[5].Width = 250;
			dataGridView_OtherSelftests.Columns[6].Width = 250;
			dataGridView_OtherSelftests.Columns[7].Width = 250;

			dataGridView_OtherSelftests.Dock = DockStyle.Fill;
			dataGridView_OtherSelftests.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dataGridView_OtherSelftests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		}
	}
}