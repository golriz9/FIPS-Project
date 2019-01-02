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
	public partial class RSA_LegacyTests : Form
	{
		public static string SigVer931_1024;
		public static string SigVer931_1536;
		public static string SigVer931_2048;
		public static string SigVer931_3072;
		public static string SigVer931_4096;
		public static string SigVer931_SHA1;
		public static string SigVer931_SHA256;
		public static string SigVer931_SHA384;
		public static string SigVer931_SHA512;

		public static string SigVerPKCS15_1024;
		public static string SigVerPKCS15_1536;
		public static string SigVerPKCS15_2048;
		public static string SigVerPKCS15_3072;
		public static string SigVerPKCS15_4096;
		public static string SigVerPKCS15_SHA1;
		public static string SigVerPKCS15_SHA224;
		public static string SigVerPKCS15_SHA256;
		public static string SigVerPKCS15_SHA384;
		public static string SigVerPKCS15_SHA512;

		public static string SigVerPSS_1024;
		public static string SigVerPSS_1536;
		public static string SigVerPSS_2048;
		public static string SigVerPSS_3072;
		public static string SigVerPSS_4096;
		public static string SigVerPSS_SHA1;
		public static string SigVerPSS_SHA224;
		public static string SigVerPSS_SHA256;
		public static string SigVerPSS_SHA384;
		public static string SigVerPSS_SHA512;
		
		public RSA_LegacyTests()
		{
			InitializeComponent();

			SigVer931_1024 = Properties.Settings.Default.SigVer931_1024.ToString();
			SigVer931_1536 = Properties.Settings.Default.SigVer931_1536.ToString();
			SigVer931_2048 = Properties.Settings.Default.SigVer931_2048.ToString();
			SigVer931_3072 = Properties.Settings.Default.SigVer931_3072.ToString();
			SigVer931_4096 = Properties.Settings.Default.SigVer931_4096.ToString();
			SigVer931_SHA1 = Properties.Settings.Default.SigVer931_SHA1.ToString();
			SigVer931_SHA256 = Properties.Settings.Default.SigVer931_SHA256.ToString();
			SigVer931_SHA384 = Properties.Settings.Default.SigVer931_SHA384.ToString();
			SigVer931_SHA512 = Properties.Settings.Default.SigVer931_SHA512.ToString();

			if (SigVer931_1024 == "True")
			{
				checkBox2.Checked = true;
			}
			if (SigVer931_1536 == "True")
			{
				checkBox3.Checked = true;
			}
			if (SigVer931_2048 == "True")
			{
				checkBox4.Checked = true;
			}
			if (SigVer931_3072 == "True")
			{
				checkBox5.Checked = true;
			}
			if (SigVer931_4096 == "True")
			{
				checkBox6.Checked = true;
			}
			if (SigVer931_SHA1 == "True")
			{
				checkBox18.Checked = true;
			}
			if (SigVer931_SHA256 == "True")
			{
				checkBox16.Checked = true;
			}
			if (SigVer931_SHA384 == "True")
			{
				checkBox15.Checked = true;
			}
			if (SigVer931_SHA512 == "True")
			{
				checkBox7.Checked = true;
			}
			
			SigVerPKCS15_1024 = Properties.Settings.Default.SigVerPKCS15_1024.ToString();
			SigVerPKCS15_1536 = Properties.Settings.Default.SigVerPKCS15_1536.ToString();
			SigVerPKCS15_2048 = Properties.Settings.Default.SigVerPKCS15_2048.ToString();
			SigVerPKCS15_3072 = Properties.Settings.Default.SigVerPKCS15_3072.ToString();
			SigVerPKCS15_4096 = Properties.Settings.Default.SigVerPKCS15_4096.ToString();
			SigVerPKCS15_SHA1 = Properties.Settings.Default.SigVerPKCS15_SHA1.ToString();
			SigVerPKCS15_SHA224 = Properties.Settings.Default.SigVerPKCS15_SHA224.ToString();
			SigVerPKCS15_SHA256 = Properties.Settings.Default.SigVerPKCS15_SHA256.ToString();
			SigVerPKCS15_SHA384 = Properties.Settings.Default.SigVerPKCS15_SHA384.ToString();
			SigVerPKCS15_SHA512 = Properties.Settings.Default.SigVerPKCS15_SHA512.ToString();

			if (SigVerPKCS15_1024 == "True")
			{
				checkBox22.Checked = true;
			}
			if (SigVerPKCS15_1536 == "True")
			{
				checkBox21.Checked = true;
			}
			if (SigVerPKCS15_2048 == "True")
			{
				checkBox20.Checked = true;
			}
			if (SigVerPKCS15_3072 == "True")
			{
				checkBox19.Checked = true;
			}
			if (SigVerPKCS15_4096 == "True")
			{
				checkBox17.Checked = true;
			}
			if (SigVerPKCS15_SHA1 == "True")
			{
				checkBox11.Checked = true;
			}
			if (SigVerPKCS15_SHA224 == "True")
			{
				checkBox28.Checked = true;
			}
			if (SigVerPKCS15_SHA256 == "True")
			{
				checkBox10.Checked = true;
			}
			if (SigVerPKCS15_SHA384 == "True")
			{
				checkBox9.Checked = true;
			}
			if (SigVerPKCS15_SHA512 == "True")
			{
				checkBox1.Checked = true;
			}

			SigVerPSS_1024 = Properties.Settings.Default.SigVerPSS_1024.ToString();
			SigVerPSS_1536 = Properties.Settings.Default.SigVerPSS_1536.ToString();
			SigVerPSS_2048 = Properties.Settings.Default.SigVerPSS_2048.ToString();
			SigVerPSS_3072 = Properties.Settings.Default.SigVerPSS_3072.ToString();
			SigVerPSS_4096 = Properties.Settings.Default.SigVerPSS_4096.ToString();
			SigVerPSS_SHA1 = Properties.Settings.Default.SigVerPSS_SHA1.ToString();
			SigVerPSS_SHA224 = Properties.Settings.Default.SigVerPSS_SHA224.ToString();
			SigVerPSS_SHA256 = Properties.Settings.Default.SigVerPSS_SHA256.ToString();
			SigVerPSS_SHA384 = Properties.Settings.Default.SigVerPSS_SHA384.ToString();
			SigVerPSS_SHA512 = Properties.Settings.Default.SigVerPSS_SHA512.ToString();
			
			if (SigVerPSS_1024 == "True")
			{
				checkBox27.Checked = true;
			}
			if (SigVerPSS_1536 == "True")
			{
				checkBox26.Checked = true;
			}
			if (SigVerPSS_2048 == "True")
			{
				checkBox25.Checked = true;
			}
			if (SigVerPSS_3072 == "True")
			{
				checkBox24.Checked = true;
			}
			if (SigVerPSS_4096 == "True")
			{
				checkBox23.Checked = true;
			}
			if (SigVerPSS_SHA1 == "True")
			{
				checkBox14.Checked = true;
			}
			if (SigVerPSS_SHA224 == "True")
			{
				checkBox29.Checked = true;
			}
			if (SigVerPSS_SHA256 == "True")
			{
				checkBox13.Checked = true;
			}
			if (SigVerPSS_SHA384 == "True")
			{
				checkBox12.Checked = true;
			}
			if (SigVerPSS_SHA512 == "True")
			{
				checkBox8.Checked = true;
			}
		}

		private void RSA_LegacyTests_Load(object sender, EventArgs e)
		{

		}

		private void groupBox6_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox5_Enter(object sender, EventArgs e)
		{

		}

		private void RSA_LegacyTests_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				SigVer931_1024 = checkBox2.Checked.ToString();
				Properties.Settings.Default.SigVer931_1024 = SigVer931_1024;

				SigVer931_1536 = checkBox3.Checked.ToString();
				Properties.Settings.Default.SigVer931_1536 = SigVer931_1536;

				SigVer931_2048 = checkBox4.Checked.ToString();
				Properties.Settings.Default.SigVer931_2048 = SigVer931_2048;

				SigVer931_3072 = checkBox5.Checked.ToString();
				Properties.Settings.Default.SigVer931_3072 = SigVer931_3072;

				SigVer931_4096 = checkBox6.Checked.ToString();
				Properties.Settings.Default.SigVer931_4096 = SigVer931_4096;

				SigVer931_SHA1 = checkBox18.Checked.ToString();
				Properties.Settings.Default.SigVer931_SHA1 = SigVer931_SHA1;

				SigVer931_SHA256 = checkBox16.Checked.ToString();
				Properties.Settings.Default.SigVer931_SHA256 = SigVer931_SHA256;

				SigVer931_SHA384 = checkBox15.Checked.ToString();
				Properties.Settings.Default.SigVer931_SHA384 = SigVer931_SHA384;

				SigVer931_SHA512 = checkBox7.Checked.ToString();
				Properties.Settings.Default.SigVer931_SHA512 = SigVer931_SHA512;

				SigVerPKCS15_1024 = checkBox22.Checked.ToString();
				Properties.Settings.Default.SigVerPKCS15_1024 = SigVerPKCS15_1024;

				SigVerPKCS15_1536 = checkBox21.Checked.ToString();
				Properties.Settings.Default.SigVerPKCS15_1536 = SigVerPKCS15_1536;

				SigVerPKCS15_2048 = checkBox20.Checked.ToString();
				Properties.Settings.Default.SigVerPKCS15_2048 = SigVerPKCS15_2048;

				SigVerPKCS15_3072 = checkBox19.Checked.ToString();
				Properties.Settings.Default.SigVerPKCS15_3072 = SigVerPKCS15_3072;

				SigVerPKCS15_4096 = checkBox17.Checked.ToString();
				Properties.Settings.Default.SigVerPKCS15_4096 = SigVerPKCS15_4096;

				SigVerPKCS15_SHA1 = checkBox11.Checked.ToString();
				Properties.Settings.Default.SigVerPKCS15_SHA1 = SigVerPKCS15_SHA1;

				SigVerPKCS15_SHA224 = checkBox28.Checked.ToString();
				Properties.Settings.Default.SigVerPKCS15_SHA224 = SigVerPKCS15_SHA224;

				SigVerPKCS15_SHA256 = checkBox10.Checked.ToString();
				Properties.Settings.Default.SigVerPKCS15_SHA256 = SigVerPKCS15_SHA256;

				SigVerPKCS15_SHA384 = checkBox9.Checked.ToString();
				Properties.Settings.Default.SigVerPKCS15_SHA384 = SigVerPKCS15_SHA384;

				SigVerPKCS15_SHA512 = checkBox1.Checked.ToString();
				Properties.Settings.Default.SigVerPKCS15_SHA512 = SigVerPKCS15_SHA512;

				SigVerPSS_1024 = checkBox27.Checked.ToString();
				Properties.Settings.Default.SigVerPSS_1024 = SigVerPSS_1024;

				SigVerPSS_1536 = checkBox26.Checked.ToString();
				Properties.Settings.Default.SigVerPSS_1536 = SigVerPSS_1536;

				SigVerPSS_2048 = checkBox25.Checked.ToString();
				Properties.Settings.Default.SigVerPSS_2048 = SigVerPSS_2048;

				SigVerPSS_3072 = checkBox24.Checked.ToString();
				Properties.Settings.Default.SigVerPSS_3072 = SigVerPSS_3072;

				SigVerPSS_4096 = checkBox23.Checked.ToString();
				Properties.Settings.Default.SigVerPSS_4096 = SigVerPSS_4096;

				SigVerPSS_SHA1 = checkBox14.Checked.ToString();
				Properties.Settings.Default.SigVerPSS_SHA1 = SigVerPSS_SHA1;

				SigVerPSS_SHA224 = checkBox29.Checked.ToString();
				Properties.Settings.Default.SigVerPSS_SHA224 = SigVerPSS_SHA224;

				SigVerPSS_SHA256 = checkBox13.Checked.ToString();
				Properties.Settings.Default.SigVerPSS_SHA256 = SigVerPSS_SHA256;

				SigVerPSS_SHA384 = checkBox12.Checked.ToString();
				Properties.Settings.Default.SigVerPSS_SHA384 = SigVerPSS_SHA384;

				SigVerPSS_SHA512 = checkBox8.Checked.ToString();
				Properties.Settings.Default.SigVerPSS_SHA512 = SigVerPSS_SHA512;
							   
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
	}
}