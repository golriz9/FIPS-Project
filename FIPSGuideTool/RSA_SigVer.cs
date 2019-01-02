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
	public partial class RSA_SigVer : Form
	{
		public static string RSA_SV_1024_SHA1;
		public static string RSA_SV_1024_SHA224;
		public static string RSA_SV_1024_SHA256;
		public static string RSA_SV_1024_SHA384;
		public static string RSA_SV_1024_SHA512;
		public static string RSA_SV_1024_SHA512_224;
		public static string RSA_SV_1024_SHA512_256;

		public static string RSA_SV_2048_SHA1;
		public static string RSA_SV_2048_SHA224;
		public static string RSA_SV_2048_SHA256;
		public static string RSA_SV_2048_SHA384;
		public static string RSA_SV_2048_SHA512;
		public static string RSA_SV_2048_SHA512_224;
		public static string RSA_SV_2048_SHA512_256;

		public static string RSA_SV_3072_SHA1;
		public static string RSA_SV_3072_SHA224;
		public static string RSA_SV_3072_SHA256;
		public static string RSA_SV_3072_SHA384;
		public static string RSA_SV_3072_SHA512;
		public static string RSA_SV_3072_SHA512_224;
		public static string RSA_SV_3072_SHA512_256;


		public RSA_SigVer()
		{
			InitializeComponent();

			RSA_SV_1024_SHA1       = Properties.Settings.Default.RSA_SV_1024_SHA1.ToString();
			RSA_SV_1024_SHA224     = Properties.Settings.Default.RSA_SV_1024_SHA224.ToString();
			RSA_SV_1024_SHA256     = Properties.Settings.Default.RSA_SV_1024_SHA256.ToString();
			RSA_SV_1024_SHA384     = Properties.Settings.Default.RSA_SV_1024_SHA384.ToString();
			RSA_SV_1024_SHA512     = Properties.Settings.Default.RSA_SV_1024_SHA512.ToString();
			RSA_SV_1024_SHA512_224 = Properties.Settings.Default.RSA_SV_1024_SHA512_224.ToString();
			RSA_SV_1024_SHA512_256 = Properties.Settings.Default.RSA_SV_1024_SHA512_256.ToString();


			if (RSA_SV_1024_SHA1 == "True")
			{
				checkBox27.Checked = true;
			}

			if (RSA_SV_1024_SHA224 == "True")
			{
				checkBox4.Checked = true;
			}

			if (RSA_SV_1024_SHA256 == "True")
			{
				checkBox5.Checked = true;
			}

			if (RSA_SV_1024_SHA384 == "True")
			{
				checkBox6.Checked = true;
			}

			if (RSA_SV_1024_SHA512 == "True")
			{
				checkBox7.Checked = true;
			}

			if (RSA_SV_1024_SHA512_224 == "True")
			{
				checkBox8.Checked = true;
			}

			if (RSA_SV_1024_SHA512_256 == "True")
			{
				checkBox9.Checked = true;
			}

			RSA_SV_2048_SHA1       = Properties.Settings.Default.RSA_SV_2048_SHA1.ToString();
			RSA_SV_2048_SHA224     = Properties.Settings.Default.RSA_SV_2048_SHA224.ToString();
			RSA_SV_2048_SHA256     = Properties.Settings.Default.RSA_SV_2048_SHA256.ToString();
			RSA_SV_2048_SHA384     = Properties.Settings.Default.RSA_SV_2048_SHA384.ToString();
			RSA_SV_2048_SHA512     = Properties.Settings.Default.RSA_SV_2048_SHA512.ToString();
			RSA_SV_2048_SHA512_224 = Properties.Settings.Default.RSA_SV_2048_SHA512_224.ToString();
			RSA_SV_2048_SHA512_256 = Properties.Settings.Default.RSA_SV_2048_SHA512_256.ToString();

			if (RSA_SV_2048_SHA1 == "True")
			{
				checkBox16.Checked = true;
			}

			if (RSA_SV_2048_SHA224 == "True")
			{
				checkBox15.Checked = true;
			}

			if (RSA_SV_2048_SHA256 == "True")
			{
				checkBox14.Checked = true;
			}

			if (RSA_SV_2048_SHA384 == "True")
			{
				checkBox13.Checked = true;
			}

			if (RSA_SV_2048_SHA512 == "True")
			{
				checkBox12.Checked = true;
			}

			if (RSA_SV_2048_SHA512_224 == "True")
			{
				checkBox11.Checked = true;
			}

			if (RSA_SV_2048_SHA512_256 == "True")
			{
				checkBox10.Checked = true;
			}

			RSA_SV_3072_SHA1       = Properties.Settings.Default.RSA_SV_3072_SHA1.ToString();
			RSA_SV_3072_SHA224     = Properties.Settings.Default.RSA_SV_3072_SHA224.ToString();
			RSA_SV_3072_SHA256     = Properties.Settings.Default.RSA_SV_3072_SHA256.ToString();
			RSA_SV_3072_SHA384     = Properties.Settings.Default.RSA_SV_3072_SHA384.ToString();
			RSA_SV_3072_SHA512     = Properties.Settings.Default.RSA_SV_3072_SHA512.ToString();
			RSA_SV_3072_SHA512_224 = Properties.Settings.Default.RSA_SV_3072_SHA512_224.ToString();
			RSA_SV_3072_SHA512_256 = Properties.Settings.Default.RSA_SV_3072_SHA512_256.ToString();

			if (RSA_SV_3072_SHA1 == "True")
			{
				checkBox1.Checked = true;
			}

			if (RSA_SV_3072_SHA224 == "True")
			{
				checkBox22.Checked = true;
			}

			if (RSA_SV_3072_SHA256 == "True")
			{
				checkBox21.Checked = true;
			}

			if (RSA_SV_3072_SHA384 == "True")
			{
				checkBox20.Checked = true;
			}

			if (RSA_SV_3072_SHA512 == "True")
			{
				checkBox19.Checked = true;
			}

			if (RSA_SV_3072_SHA512_224 == "True")
			{
				checkBox3.Checked = true;
			}

			if (RSA_SV_3072_SHA512_256 == "True")
			{
				checkBox2.Checked = true;
			}
		}

		private void RSA_SigVer_Load(object sender, EventArgs e)
		{

		}

		private void RSA_SigVer_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				RSA_SV_1024_SHA1 = checkBox27.Checked.ToString();
				Properties.Settings.Default.RSA_SV_1024_SHA1 = RSA_SV_1024_SHA1;

				RSA_SV_1024_SHA224 = checkBox4.Checked.ToString();
				Properties.Settings.Default.RSA_SV_1024_SHA224 = RSA_SV_1024_SHA224;

				RSA_SV_1024_SHA256 = checkBox5.Checked.ToString();
				Properties.Settings.Default.RSA_SV_1024_SHA256 = RSA_SV_1024_SHA256;

				RSA_SV_1024_SHA384 = checkBox6.Checked.ToString();
				Properties.Settings.Default.RSA_SV_1024_SHA384 = RSA_SV_1024_SHA384;

				RSA_SV_1024_SHA512 = checkBox7.Checked.ToString();
				Properties.Settings.Default.RSA_SV_1024_SHA512 = RSA_SV_1024_SHA512;

				RSA_SV_1024_SHA512_224 = checkBox8.Checked.ToString();
				Properties.Settings.Default.RSA_SV_1024_SHA512_224 = RSA_SV_1024_SHA512_224;

				RSA_SV_1024_SHA512_256 = checkBox9.Checked.ToString();
				Properties.Settings.Default.RSA_SV_1024_SHA512_256 = RSA_SV_1024_SHA512_256;

				RSA_SV_2048_SHA1 = checkBox16.Checked.ToString();
				Properties.Settings.Default.RSA_SV_2048_SHA1 = RSA_SV_2048_SHA1;

				RSA_SV_2048_SHA224 = checkBox15.Checked.ToString();
				Properties.Settings.Default.RSA_SV_2048_SHA224 = RSA_SV_2048_SHA224;

				RSA_SV_2048_SHA256 = checkBox14.Checked.ToString();
				Properties.Settings.Default.RSA_SV_2048_SHA256 = RSA_SV_2048_SHA256;

				RSA_SV_2048_SHA384 = checkBox13.Checked.ToString();
				Properties.Settings.Default.RSA_SV_2048_SHA384 = RSA_SV_2048_SHA384;

				RSA_SV_2048_SHA512 = checkBox12.Checked.ToString();
				Properties.Settings.Default.RSA_SV_2048_SHA512 = RSA_SV_2048_SHA512;

				RSA_SV_2048_SHA512_224 = checkBox11.Checked.ToString();
				Properties.Settings.Default.RSA_SV_2048_SHA512_224 = RSA_SV_2048_SHA512_224;

				RSA_SV_2048_SHA512_256 = checkBox10.Checked.ToString();
				Properties.Settings.Default.RSA_SV_2048_SHA512_256 = RSA_SV_2048_SHA512_256;

				RSA_SV_3072_SHA1 = checkBox1.Checked.ToString();
				Properties.Settings.Default.RSA_SV_3072_SHA1 = RSA_SV_3072_SHA1;

				RSA_SV_3072_SHA224 = checkBox22.Checked.ToString();
				Properties.Settings.Default.RSA_SV_3072_SHA224 = RSA_SV_3072_SHA224;

				RSA_SV_3072_SHA256 = checkBox21.Checked.ToString();
				Properties.Settings.Default.RSA_SV_3072_SHA256 = RSA_SV_3072_SHA256;

				RSA_SV_3072_SHA384 = checkBox20.Checked.ToString();
				Properties.Settings.Default.RSA_SV_3072_SHA384 = RSA_SV_3072_SHA384;

				RSA_SV_3072_SHA512 = checkBox19.Checked.ToString();
				Properties.Settings.Default.RSA_SV_3072_SHA512 = RSA_SV_3072_SHA512;

				RSA_SV_3072_SHA512_224 = checkBox3.Checked.ToString();
				Properties.Settings.Default.RSA_SV_3072_SHA512_224 = RSA_SV_3072_SHA512_224;

				RSA_SV_3072_SHA512_256 = checkBox2.Checked.ToString();
				Properties.Settings.Default.RSA_SV_3072_SHA512_256 = RSA_SV_3072_SHA512_256;

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
	}
}