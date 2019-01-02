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
	public partial class SigVer : Form
	{
		public static string Sig_V_SHA1_N160;
		public static string Sig_V_SHA224_N160;
		public static string Sig_V_SHA256_N160;
		public static string Sig_V_SHA384_N160;
		public static string Sig_V_SHA512_N160;
		public static string Sig_V_SHA512_224_N160;
		public static string Sig_V_SHA512_256_N160;

		public static string Sig_V_SHA1_N224;
		public static string Sig_V_SHA224_N224;
		public static string Sig_V_SHA256_N224;
		public static string Sig_V_SHA384_N224;
		public static string Sig_V_SHA512_N224;
		public static string Sig_V_SHA512_224_N224;
		public static string Sig_V_SHA512_256_N224;

		public static string Sig_V_SHA1_N256;
		public static string Sig_V_SHA224_N256;
		public static string Sig_V_SHA256_N256;
		public static string Sig_V_SHA384_N256;
		public static string Sig_V_SHA512_N256;
		public static string Sig_V_SHA512_224_N256;
		public static string Sig_V_SHA512_256_N256;

		public static string Sig_V_SHA1_L3072;
		public static string Sig_V_SHA224_L3072;
		public static string Sig_V_SHA256_L3072;
		public static string Sig_V_SHA384_L3072;
		public static string Sig_V_SHA512_L3072;
		public static string Sig_V_SHA512_224_L3072;
		public static string Sig_V_SHA512_256_L3072;

		public SigVer()
		{
			InitializeComponent();

			Sig_V_SHA1_N160       = Properties.Settings.Default.Sig_V_SHA1_N160.ToString();
			Sig_V_SHA224_N160     = Properties.Settings.Default.Sig_V_SHA224_N160.ToString();
			Sig_V_SHA256_N160     = Properties.Settings.Default.Sig_V_SHA256_N160.ToString();
			Sig_V_SHA384_N160     = Properties.Settings.Default.Sig_V_SHA384_N160.ToString();
			Sig_V_SHA512_N160     = Properties.Settings.Default.Sig_V_SHA512_N160.ToString();
			Sig_V_SHA512_224_N160 = Properties.Settings.Default.Sig_V_SHA512_224_N160.ToString();
			Sig_V_SHA512_256_N160 = Properties.Settings.Default.Sig_V_SHA512_256_N160.ToString();

			if (Sig_V_SHA1_N160 == "True")
			{
				checkBox27.Checked = true;
			}

			if (Sig_V_SHA224_N160 == "True")
			{
				checkBox2.Checked = true;
			}

			if (Sig_V_SHA256_N160 == "True")
			{
				checkBox3.Checked = true;
			}

			if (Sig_V_SHA384_N160 == "True")
			{
				checkBox4.Checked = true;
			}

			if (Sig_V_SHA512_N160 == "True")
			{
				checkBox5.Checked = true;
			}

			if (Sig_V_SHA512_224_N160 == "True")
			{
				checkBox6.Checked = true;
			}

			if (Sig_V_SHA512_256_N160 == "True")
			{
				checkBox7.Checked = true;
			}

			Sig_V_SHA1_N224       = Properties.Settings.Default.Sig_V_SHA1_N224.ToString();
			Sig_V_SHA224_N224     = Properties.Settings.Default.Sig_V_SHA224_N224.ToString();
			Sig_V_SHA256_N224     = Properties.Settings.Default.Sig_V_SHA256_N224.ToString();
			Sig_V_SHA384_N224     = Properties.Settings.Default.Sig_V_SHA384_N224.ToString();
			Sig_V_SHA512_N224     = Properties.Settings.Default.Sig_V_SHA512_N224.ToString();
			Sig_V_SHA512_224_N224 = Properties.Settings.Default.Sig_V_SHA512_224_N224.ToString();
			Sig_V_SHA512_256_N224 = Properties.Settings.Default.Sig_V_SHA512_256_N224.ToString();

			if (Sig_V_SHA1_N224 == "True")
			{
				checkBox9.Checked = true;
			}

			if (Sig_V_SHA224_N224 == "True")
			{
				checkBox18.Checked = true;
			}

			if (Sig_V_SHA256_N224 == "True")
			{
				checkBox17.Checked = true;
			}

			if (Sig_V_SHA384_N224 == "True")
			{
				checkBox16.Checked = true;
			}

			if (Sig_V_SHA512_N224 == "True")
			{
				checkBox15.Checked = true;
			}

			if (Sig_V_SHA512_224_N224 == "True")
			{
				checkBox11.Checked = true;
			}

			if (Sig_V_SHA512_256_N224 == "True")
			{
				checkBox10.Checked = true;
			}

			Sig_V_SHA1_N256       = Properties.Settings.Default.Sig_V_SHA1_N256.ToString();
			Sig_V_SHA224_N256     = Properties.Settings.Default.Sig_V_SHA224_N256.ToString();
			Sig_V_SHA256_N256     = Properties.Settings.Default.Sig_V_SHA256_N256.ToString();
			Sig_V_SHA384_N256     = Properties.Settings.Default.Sig_V_SHA384_N256.ToString();
			Sig_V_SHA512_N256     = Properties.Settings.Default.Sig_V_SHA512_N256.ToString();
			Sig_V_SHA512_224_N256 = Properties.Settings.Default.Sig_V_SHA512_224_N256.ToString();
			Sig_V_SHA512_256_N256 = Properties.Settings.Default.Sig_V_SHA512_256_N256.ToString();

			if (Sig_V_SHA1_N256 == "True")
			{
				checkBox8.Checked = true;
			}

			if (Sig_V_SHA224_N256 == "True")
			{
				checkBox21.Checked = true;
			}

			if (Sig_V_SHA256_N256 == "True")
			{
				checkBox20.Checked = true;
			}

			if (Sig_V_SHA384_N256 == "True")
			{
				checkBox19.Checked = true;
			}

			if (Sig_V_SHA512_N256 == "True")
			{
				checkBox14.Checked = true;
			}

			if (Sig_V_SHA512_224_N256 == "True")
			{
				checkBox13.Checked = true;
			}

			if (Sig_V_SHA512_256_N256 == "True")
			{
				checkBox12.Checked = true;
			}

			Sig_V_SHA1_L3072       = Properties.Settings.Default.Sig_V_SHA1_L3072.ToString();
			Sig_V_SHA224_L3072     = Properties.Settings.Default.Sig_V_SHA224_L3072.ToString();
			Sig_V_SHA256_L3072     = Properties.Settings.Default.Sig_V_SHA256_L3072.ToString();
			Sig_V_SHA384_L3072     = Properties.Settings.Default.Sig_V_SHA384_L3072.ToString();
			Sig_V_SHA512_L3072     = Properties.Settings.Default.Sig_V_SHA512_L3072.ToString();
			Sig_V_SHA512_224_L3072 = Properties.Settings.Default.Sig_V_SHA512_224_L3072.ToString();
			Sig_V_SHA512_256_L3072 = Properties.Settings.Default.Sig_V_SHA512_256_L3072.ToString();

			if (Sig_V_SHA1_L3072 == "True")
			{
				checkBox1.Checked = true;
			}

			if (Sig_V_SHA224_L3072 == "True")
			{
				checkBox28.Checked = true;
			}

			if (Sig_V_SHA256_L3072 == "True")
			{
				checkBox26.Checked = true;
			}

			if (Sig_V_SHA384_L3072 == "True")
			{
				checkBox25.Checked = true;
			}

			if (Sig_V_SHA512_L3072 == "True")
			{
				checkBox24.Checked = true;
			}

			if (Sig_V_SHA512_224_L3072 == "True")
			{
				checkBox23.Checked = true;
			}

			if (Sig_V_SHA512_256_L3072 == "True")
			{
				checkBox22.Checked = true;
			}
		}

		private void SigVer_Load(object sender, EventArgs e)
		{

		}

		private void SigVer_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				Sig_V_SHA1_N160 = checkBox27.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA1_N160 = Sig_V_SHA1_N160;

				Sig_V_SHA224_N160 = checkBox2.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA224_N160 = Sig_V_SHA224_N160;

				Sig_V_SHA256_N160 = checkBox3.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA256_N160 = Sig_V_SHA256_N160;

				Sig_V_SHA384_N160 = checkBox4.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA384_N160 = Sig_V_SHA384_N160;

				Sig_V_SHA512_N160 = checkBox5.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA512_N160 = Sig_V_SHA512_N160;

				Sig_V_SHA512_224_N160 = checkBox6.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA512_224_N160 = Sig_V_SHA512_224_N160;

				Sig_V_SHA512_256_N160 = checkBox7.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA512_256_N160 = Sig_V_SHA512_256_N160;

				Sig_V_SHA1_N224 = checkBox9.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA1_N224 = Sig_V_SHA1_N224;

				Sig_V_SHA224_N224 = checkBox18.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA224_N224 = Sig_V_SHA224_N224;

				Sig_V_SHA256_N224 = checkBox17.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA256_N224 = Sig_V_SHA256_N224;

				Sig_V_SHA384_N224 = checkBox16.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA384_N224 = Sig_V_SHA384_N224;

				Sig_V_SHA512_N224 = checkBox15.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA512_N224 = Sig_V_SHA512_N224;

				Sig_V_SHA512_224_N224 = checkBox11.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA512_224_N224 = Sig_V_SHA512_224_N224;

				Sig_V_SHA512_256_N224 = checkBox10.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA512_256_N224 = Sig_V_SHA512_256_N224;

				Sig_V_SHA1_N256 = checkBox8.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA1_N256 = Sig_V_SHA1_N256;

				Sig_V_SHA224_N256 = checkBox21.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA224_N256 = Sig_V_SHA224_N256;

				Sig_V_SHA256_N256 = checkBox20.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA256_N256 = Sig_V_SHA256_N256;

				Sig_V_SHA384_N256 = checkBox19.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA384_N256 = Sig_V_SHA384_N256;

				Sig_V_SHA512_N256 = checkBox14.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA512_N256 = Sig_V_SHA512_N256;

				Sig_V_SHA512_224_N256 = checkBox13.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA512_224_N256 = Sig_V_SHA512_224_N256;

				Sig_V_SHA512_256_N256 = checkBox12.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA512_256_N256 = Sig_V_SHA512_256_N256;

				Sig_V_SHA1_L3072 = checkBox1.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA1_L3072 = Sig_V_SHA1_L3072;

				Sig_V_SHA224_L3072 = checkBox28.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA224_L3072 = Sig_V_SHA224_L3072;

				Sig_V_SHA256_L3072 = checkBox26.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA256_L3072 = Sig_V_SHA256_L3072;

				Sig_V_SHA384_L3072 = checkBox25.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA384_L3072 = Sig_V_SHA384_L3072;

				Sig_V_SHA512_L3072 = checkBox24.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA512_L3072 = Sig_V_SHA512_L3072;

				Sig_V_SHA512_224_L3072 = checkBox23.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA512_224_L3072 = Sig_V_SHA512_224_L3072;

				Sig_V_SHA512_256_L3072 = checkBox22.Checked.ToString();
				Properties.Settings.Default.Sig_V_SHA512_256_L3072 = Sig_V_SHA512_256_L3072;
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

		public void StoreSigVerParam()
		{
			Sig_V_SHA1_N160   = checkBox27.Checked.ToString();
			Sig_V_SHA224_N160 = checkBox2.Checked.ToString();
			Sig_V_SHA256_N160 = checkBox3.Checked.ToString();
			Sig_V_SHA384_N160 = checkBox4.Checked.ToString();
			Sig_V_SHA512_N160 = checkBox5.Checked.ToString();
			Sig_V_SHA512_224_N160 = checkBox6.Checked.ToString();
			Sig_V_SHA512_256_N160 = checkBox7.Checked.ToString();
			Sig_V_SHA1_N224       = checkBox9.Checked.ToString();
			Sig_V_SHA224_N224     = checkBox18.Checked.ToString();
			Sig_V_SHA256_N224 = checkBox17.Checked.ToString();
			Sig_V_SHA384_N224 = checkBox16.Checked.ToString();
			Sig_V_SHA512_N224 = checkBox15.Checked.ToString();
			Sig_V_SHA512_224_N224 = checkBox11.Checked.ToString();
			Sig_V_SHA512_256_N224 = checkBox10.Checked.ToString();
			Sig_V_SHA1_N256 = checkBox8.Checked.ToString();
			Sig_V_SHA224_N256 = checkBox21.Checked.ToString();
			Sig_V_SHA256_N256 = checkBox20.Checked.ToString();
			Sig_V_SHA384_N256 = checkBox19.Checked.ToString();
			Sig_V_SHA512_N256 = checkBox14.Checked.ToString();
			Sig_V_SHA512_224_N256 = checkBox13.Checked.ToString();
			Sig_V_SHA512_256_N256 = checkBox12.Checked.ToString();
			Sig_V_SHA1_L3072 = checkBox1.Checked.ToString();
			Sig_V_SHA224_L3072 = checkBox28.Checked.ToString();
			Sig_V_SHA256_L3072 = checkBox26.Checked.ToString();
			Sig_V_SHA384_L3072 = checkBox25.Checked.ToString();
			Sig_V_SHA512_L3072 = checkBox24.Checked.ToString();
			Sig_V_SHA512_224_L3072 = checkBox23.Checked.ToString();
			Sig_V_SHA512_256_L3072 = checkBox22.Checked.ToString();
		}

		public void LoadSigVerParam()
		{

		}
	}
}