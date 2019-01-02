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
	public partial class SigGen : Form
	{
		public static string Sig_G_SHA1_N224;
		public static string Sig_G_SHA224_N224;
		public static string Sig_G_SHA256_N224;
		public static string Sig_G_SHA384_N224;
		public static string Sig_G_SHA512_N224;
		public static string Sig_G_SHA512_224_N224;
		public static string Sig_G_SHA512_256_N224;

		public static string Sig_G_SHA1_N256;
		public static string Sig_G_SHA224_N256;
		public static string Sig_G_SHA256_N256;
		public static string Sig_G_SHA384_N256;
		public static string Sig_G_SHA512_N256;
		public static string Sig_G_SHA512_224_N256;
		public static string Sig_G_SHA512_256_N256;

		public static string Sig_G_SHA1_L3072;
		public static string Sig_G_SHA224_L3072;
		public static string Sig_G_SHA256_L3072;
		public static string Sig_G_SHA384_L3072;
		public static string Sig_G_SHA512_L3072;
		public static string Sig_G_SHA512_224_L3072;
		public static string Sig_G_SHA512_256_L3072;


		public SigGen()
		{
			InitializeComponent();

			Sig_G_SHA1_N224       = Properties.Settings.Default.Sig_G_SHA1_N224.ToString();
			Sig_G_SHA224_N224     = Properties.Settings.Default.Sig_G_SHA224_N224.ToString();
			Sig_G_SHA256_N224     = Properties.Settings.Default.Sig_G_SHA256_N224.ToString();
			Sig_G_SHA384_N224     = Properties.Settings.Default.Sig_G_SHA384_N224.ToString();
			Sig_G_SHA512_N224     = Properties.Settings.Default.Sig_G_SHA512_N224.ToString();
			Sig_G_SHA512_224_N224 = Properties.Settings.Default.Sig_G_SHA512_224_N224.ToString();
			Sig_G_SHA512_256_N224 = Properties.Settings.Default.Sig_G_SHA512_256_N224.ToString();

			if (Sig_G_SHA1_N224 == "True")
			{
				checkBox2.Checked = true;
			}

			if (Sig_G_SHA224_N224 == "True")
			{
				checkBox30.Checked = true;
			}

			if (Sig_G_SHA256_N224 == "True")
			{
				checkBox29.Checked = true;
			}

			if (Sig_G_SHA384_N224 == "True")
			{
				checkBox28.Checked = true;
			}

			if (Sig_G_SHA512_N224 == "True")
			{
				checkBox11.Checked = true;
			}

			if (Sig_G_SHA512_224_N224 == "True")
			{
				checkBox10.Checked = true;
			}

			if (Sig_G_SHA512_256_N224 == "True")
			{
				checkBox9.Checked = true;
			}

			Sig_G_SHA1_N256       = Properties.Settings.Default.Sig_G_SHA1_N256.ToString();
			Sig_G_SHA224_N256     = Properties.Settings.Default.Sig_G_SHA224_N256.ToString();
			Sig_G_SHA256_N256     = Properties.Settings.Default.Sig_G_SHA256_N256.ToString();
			Sig_G_SHA384_N256     = Properties.Settings.Default.Sig_G_SHA384_N256.ToString();
			Sig_G_SHA512_N256     = Properties.Settings.Default.Sig_G_SHA512_N256.ToString();
			Sig_G_SHA512_224_N256 = Properties.Settings.Default.Sig_G_SHA512_224_N256.ToString();
			Sig_G_SHA512_256_N256 = Properties.Settings.Default.Sig_G_SHA512_256_N256.ToString();

			if (Sig_G_SHA1_N256 == "True")
			{
				checkBox3.Checked = true;
			}

			if (Sig_G_SHA224_N256 == "True")
			{
				checkBox12.Checked = true;
			}

			if (Sig_G_SHA256_N256 == "True")
			{
				checkBox8.Checked = true;
			}

			if (Sig_G_SHA384_N256 == "True")
			{
				checkBox7.Checked = true;
			}

			if (Sig_G_SHA512_N256 == "True")
			{
				checkBox6.Checked = true;
			}

			if (Sig_G_SHA512_224_N256 == "True")
			{
				checkBox5.Checked = true;
			}

			if (Sig_G_SHA512_256_N256 == "True")
			{
				checkBox4.Checked = true;
			}
			
			Sig_G_SHA1_L3072       = Properties.Settings.Default.Sig_G_SHA1_L3072.ToString();
			Sig_G_SHA224_L3072     = Properties.Settings.Default.Sig_G_SHA224_L3072.ToString();
			Sig_G_SHA256_L3072     = Properties.Settings.Default.Sig_G_SHA256_L3072.ToString();
			Sig_G_SHA384_L3072     = Properties.Settings.Default.Sig_G_SHA384_L3072.ToString();
			Sig_G_SHA512_L3072     = Properties.Settings.Default.Sig_G_SHA512_L3072.ToString();
			Sig_G_SHA512_224_L3072 = Properties.Settings.Default.Sig_G_SHA512_224_L3072.ToString();
			Sig_G_SHA512_256_L3072 = Properties.Settings.Default.Sig_G_SHA512_256_L3072.ToString();

			if (Sig_G_SHA1_L3072 == "True")
			{
				checkBox13.Checked = true;
			}

			if (Sig_G_SHA224_L3072 == "True")
			{
				checkBox27.Checked = true;
			}

			if (Sig_G_SHA256_L3072 == "True")
			{
				checkBox18.Checked = true;
			}

			if (Sig_G_SHA384_L3072 == "True")
			{
				checkBox17.Checked = true;
			}

			if (Sig_G_SHA512_L3072 == "True")
			{
				checkBox16.Checked = true;
			}

			if (Sig_G_SHA512_224_L3072 == "True")
			{
				checkBox15.Checked = true;
			}

			if (Sig_G_SHA512_256_L3072 == "True")
			{
				checkBox14.Checked = true;
			}
		}

		private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void SigGen_Load(object sender, EventArgs e)
		{

		}

		private void SigGen_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				Sig_G_SHA1_N224 = checkBox2.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA1_N224 = Sig_G_SHA1_N224 ;

				Sig_G_SHA224_N224 = checkBox30.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA224_N224 = Sig_G_SHA224_N224;

				Sig_G_SHA256_N224 = checkBox29.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA256_N224 = Sig_G_SHA256_N224;

				Sig_G_SHA384_N224 = checkBox28.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA384_N224 = Sig_G_SHA384_N224;

				Sig_G_SHA512_N224 = checkBox11.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA512_N224 = Sig_G_SHA512_N224;

				Sig_G_SHA512_224_N224 = checkBox10.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA512_224_N224 = Sig_G_SHA512_224_N224;

				Sig_G_SHA512_256_N224 = checkBox9.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA512_256_N224 = Sig_G_SHA512_256_N224;

				Sig_G_SHA1_N256 = checkBox3.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA1_N256 = Sig_G_SHA1_N256;

				Sig_G_SHA224_N256 = checkBox12.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA224_N256 = Sig_G_SHA224_N256;

				Sig_G_SHA256_N256 = checkBox8.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA256_N256 = Sig_G_SHA256_N256;

				Sig_G_SHA384_N256 = checkBox7.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA384_N256 = Sig_G_SHA384_N256;

				Sig_G_SHA512_N256 = checkBox6.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA512_N256 = Sig_G_SHA512_N256 ;

				Sig_G_SHA512_224_N256 = checkBox5.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA512_224_N256 = Sig_G_SHA512_224_N256;

				Sig_G_SHA512_256_N256 = checkBox4.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA512_256_N256 = Sig_G_SHA512_256_N256;

				Sig_G_SHA1_L3072 = checkBox13.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA1_L3072 = Sig_G_SHA1_L3072;

				Sig_G_SHA224_L3072 = checkBox27.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA224_L3072 = Sig_G_SHA224_L3072;

				Sig_G_SHA256_L3072 = checkBox18.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA256_L3072 = Sig_G_SHA256_L3072;

				Sig_G_SHA384_L3072 = checkBox17.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA384_L3072 = Sig_G_SHA384_L3072;

				Sig_G_SHA512_L3072 = checkBox16.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA512_L3072 = Sig_G_SHA512_L3072;

				Sig_G_SHA512_224_L3072 = checkBox15.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA512_224_L3072 = Sig_G_SHA512_224_L3072;

				Sig_G_SHA512_256_L3072 = checkBox14.Checked.ToString();
				Properties.Settings.Default.Sig_G_SHA512_256_L3072 = Sig_G_SHA512_256_L3072;
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