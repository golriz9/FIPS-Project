using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIPSGuideTool
{
	public partial class DRBG : Form
	{
		public static string HASH_DRBG_checkBox;
		public static string HASH_DRBG_SHA1;
		public static string HASH_DRBG_SHA224;
		public static string HASH_DRBG_SHA256;
		public static string HASH_DRBG_SHA384;
		public static string HASH_DRBG_SHA512;
		public static string HASH_DRBG_SHA512_224;
		public static string HASH_DRBG_SHA512_256;

		public static string HMAC_DRBG_checkBox;
		public static string HMAC_DRBG_SHA1;
		public static string HMAC_DRBG_SHA224;
		public static string HMAC_DRBG_SHA256;
		public static string HMAC_DRBG_SHA384;
		public static string HMAC_DRBG_SHA512;
		public static string HMAC_DRBG_SHA512_224;
		public static string HMAC_DRBG_SHA512_256;
		
		public static string CTR_DRBG_checkBox;
		public static string CTR_DRBG_3KeyTDEA;
		public static string CTR_DRBG_AES128;
		public static string CTR_DRBG_AES192;
		public static string CTR_DRBG_AES256;

		public DRBG()
		{
			InitializeComponent();

			HASH_DRBG_checkBox = Properties.Settings.Default.HASH_DRBG_checkBox.ToString();
			HASH_DRBG_SHA1     = Properties.Settings.Default.HASH_DRBG_SHA1.ToString();
			HASH_DRBG_SHA224   = Properties.Settings.Default.HASH_DRBG_SHA224.ToString();
			HASH_DRBG_SHA256   = Properties.Settings.Default.HASH_DRBG_SHA256.ToString();
			HASH_DRBG_SHA384   = Properties.Settings.Default.HASH_DRBG_SHA384.ToString();
			HASH_DRBG_SHA512   = Properties.Settings.Default.HASH_DRBG_SHA512.ToString();
			HASH_DRBG_SHA512_224 = Properties.Settings.Default.HASH_DRBG_SHA512_224.ToString();
			HASH_DRBG_SHA512_256 = Properties.Settings.Default.HASH_DRBG_SHA512_256.ToString();

			HMAC_DRBG_checkBox   = Properties.Settings.Default.HMAC_DRBG_checkBox.ToString();
			HMAC_DRBG_SHA1       = Properties.Settings.Default.HMAC_DRBG_SHA1.ToString();
			HMAC_DRBG_SHA224     = Properties.Settings.Default.HMAC_DRBG_SHA224.ToString();
			HMAC_DRBG_SHA256     = Properties.Settings.Default.HMAC_DRBG_SHA256.ToString();
			HMAC_DRBG_SHA384     = Properties.Settings.Default.HMAC_DRBG_SHA384.ToString();
			HMAC_DRBG_SHA512     = Properties.Settings.Default.HMAC_DRBG_SHA512.ToString();
			HMAC_DRBG_SHA512_224 = Properties.Settings.Default.HMAC_DRBG_SHA512_224.ToString();
			HMAC_DRBG_SHA512_256 = Properties.Settings.Default.HMAC_DRBG_SHA512_256.ToString();

			CTR_DRBG_checkBox  = Properties.Settings.Default.CTR_DRBG_checkBox.ToString();
			CTR_DRBG_3KeyTDEA  = Properties.Settings.Default.CTR_DRBG_3KeyTDEA.ToString();
			CTR_DRBG_AES128    = Properties.Settings.Default.CTR_DRBG_AES128.ToString();
			CTR_DRBG_AES192    = Properties.Settings.Default.CTR_DRBG_AES192.ToString();
			CTR_DRBG_AES256    = Properties.Settings.Default.CTR_DRBG_AES256.ToString();

			if (HASH_DRBG_checkBox == "True")
			{
				checkBox21.Checked = true;
			}

			if (HASH_DRBG_SHA1 == "True")
			{
				checkBox1.Checked = true;
			}

			if (HASH_DRBG_SHA224 == "True")
			{
				checkBox2.Checked = true;
			}

			if (HASH_DRBG_SHA256 == "True")
			{
				checkBox3.Checked = true;
			}

			if (HASH_DRBG_SHA384 == "True")
			{
				checkBox4.Checked = true;
			}

			if (HASH_DRBG_SHA512 == "True")
			{
				checkBox5.Checked = true;
			}

			if (HASH_DRBG_SHA512_224 == "True")
			{
				checkBox6.Checked = true;
			}

			if (HASH_DRBG_SHA512_256 == "True")
			{
				checkBox7.Checked = true;
			}


			if (HMAC_DRBG_checkBox == "True")
			{
				checkBox20.Checked = true;
			}

			if (HMAC_DRBG_SHA1 == "True")
			{
				checkBox14.Checked = true;
			}

			if (HMAC_DRBG_SHA224 == "True")
			{
				checkBox13.Checked = true;
			}

			if (HMAC_DRBG_SHA256 == "True")
			{
				checkBox12.Checked = true;
			}

			if (HMAC_DRBG_SHA384 == "True")
			{
				checkBox11.Checked = true;
			}

			if (HMAC_DRBG_SHA512 == "True")
			{
				checkBox10.Checked = true;
			}

			if (HMAC_DRBG_SHA512_224 == "True")
			{
				checkBox9.Checked = true;
			}

			if (HMAC_DRBG_SHA512_256 == "True")
			{
				checkBox8.Checked = true;
			}


			if (CTR_DRBG_checkBox == "True")
			{
				checkBox19.Checked = true;
			}

			if (CTR_DRBG_3KeyTDEA == "True")
			{
				checkBox18.Checked = true;
			}

			if (CTR_DRBG_AES128 == "True")
			{
				checkBox17.Checked = true;
			}

			if (CTR_DRBG_AES192 == "True")
			{
				checkBox16.Checked = true;
			}

			if (CTR_DRBG_AES256 == "True")
			{
				checkBox15.Checked = true;
			}

		}

		private void checkBox21_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox21.Checked == true)
			{
				DRBG_tabs.SelectedTab = HASH_DRBG;
			}
		}

		private void DRBG_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				HASH_DRBG_checkBox = checkBox21.Checked.ToString();
				Properties.Settings.Default.HASH_DRBG_checkBox = HASH_DRBG_checkBox;

				HASH_DRBG_SHA1 = checkBox1.Checked.ToString();
				Properties.Settings.Default.HASH_DRBG_SHA1 = HASH_DRBG_SHA1;

				HASH_DRBG_SHA224 = checkBox2.Checked.ToString();
				Properties.Settings.Default.HASH_DRBG_SHA224 = HASH_DRBG_SHA224;

				HASH_DRBG_SHA256 = checkBox3.Checked.ToString();
				Properties.Settings.Default.HASH_DRBG_SHA256 = HASH_DRBG_SHA256;

				HASH_DRBG_SHA384 = checkBox4.Checked.ToString();
				Properties.Settings.Default.HASH_DRBG_SHA384 = HASH_DRBG_SHA384;

				HASH_DRBG_SHA512 = checkBox5.Checked.ToString();
				Properties.Settings.Default.HASH_DRBG_SHA512 = HASH_DRBG_SHA512;

				HASH_DRBG_SHA512_224 = checkBox6.Checked.ToString();
				Properties.Settings.Default.HASH_DRBG_SHA512_224 = HASH_DRBG_SHA512_224;

				HASH_DRBG_SHA512_256 = checkBox7.Checked.ToString();
				Properties.Settings.Default.HASH_DRBG_SHA512_256 = HASH_DRBG_SHA512_256;

				HMAC_DRBG_checkBox = checkBox20.Checked.ToString();
				Properties.Settings.Default.HMAC_DRBG_checkBox = HMAC_DRBG_checkBox;

				HMAC_DRBG_SHA1 = checkBox14.Checked.ToString();
				Properties.Settings.Default.HMAC_DRBG_SHA1 = HMAC_DRBG_SHA1;

				HMAC_DRBG_SHA224 = checkBox13.Checked.ToString();
				Properties.Settings.Default.HMAC_DRBG_SHA224 = HMAC_DRBG_SHA224;

				HMAC_DRBG_SHA256 = checkBox12.Checked.ToString();
				Properties.Settings.Default.HMAC_DRBG_SHA256 = HMAC_DRBG_SHA256;

				HMAC_DRBG_SHA384 = checkBox11.Checked.ToString();
				Properties.Settings.Default.HMAC_DRBG_SHA384 = HMAC_DRBG_SHA384;

				HMAC_DRBG_SHA512 = checkBox10.Checked.ToString();
				Properties.Settings.Default.HMAC_DRBG_SHA512 = HMAC_DRBG_SHA512;

				HMAC_DRBG_SHA512_224 = checkBox9.Checked.ToString();
				Properties.Settings.Default.HMAC_DRBG_SHA512_224 = HMAC_DRBG_SHA512_224;

				HMAC_DRBG_SHA512_256 = checkBox8.Checked.ToString();
				Properties.Settings.Default.HMAC_DRBG_SHA512_256 = HMAC_DRBG_SHA512_256;

				CTR_DRBG_checkBox = checkBox19.Checked.ToString();
				Properties.Settings.Default.CTR_DRBG_checkBox = CTR_DRBG_checkBox;

				CTR_DRBG_3KeyTDEA = checkBox18.Checked.ToString();
				Properties.Settings.Default.CTR_DRBG_3KeyTDEA = CTR_DRBG_3KeyTDEA;

				CTR_DRBG_AES128 = checkBox17.Checked.ToString();
				Properties.Settings.Default.CTR_DRBG_AES128 = CTR_DRBG_AES128;

				CTR_DRBG_AES192 = checkBox16.Checked.ToString();
				Properties.Settings.Default.CTR_DRBG_AES192 = CTR_DRBG_AES192;

				CTR_DRBG_AES256 = checkBox15.Checked.ToString();
				Properties.Settings.Default.CTR_DRBG_AES256 = CTR_DRBG_AES256;
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

		private void checkBox20_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox20.Checked == true)
			{
				DRBG_tabs.SelectedTab = HMAC_DRBG;
			}
		}

		private void checkBox19_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox19.Checked == true)
			{
				DRBG_tabs.SelectedTab = CTR_DRBG;
			}
		}

		private void DRBG_Load(object sender, EventArgs e)
		{

		}
	}
}