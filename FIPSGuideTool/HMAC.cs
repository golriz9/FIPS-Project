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
	public partial class HMAC : Form
	{
		public static string HMAC_SHA1;
		public static string HMAC_SHA224;
		public static string HMAC_SHA256;
		public static string HMAC_SHA384;
		public static string HMAC_SHA512;
		public static string HMAC_SHA512_224;
		public static string HMAC_SHA512_256;

		public HMAC()
		{
			InitializeComponent();

			HMAC_SHA1   = Properties.Settings.Default.HMAC_SHA1.ToString();
			HMAC_SHA224 = Properties.Settings.Default.HMAC_SHA224.ToString();
			HMAC_SHA256 = Properties.Settings.Default.HMAC_SHA256.ToString();
			HMAC_SHA384 = Properties.Settings.Default.HMAC_SHA384.ToString();
			HMAC_SHA512 = Properties.Settings.Default.HMAC_SHA512.ToString();
			HMAC_SHA512_224 = Properties.Settings.Default.HMAC_SHA512_224.ToString();
			HMAC_SHA512_256 = Properties.Settings.Default.HMAC_SHA512_256.ToString();

			if (HMAC_SHA1 == "True")
			{
				checkBox1.Checked = true;
			}

			if (HMAC_SHA224 == "True")
			{
				checkBox2.Checked = true;
			}

			if (HMAC_SHA256 == "True")
			{
				checkBox3.Checked = true;
			}

			if (HMAC_SHA384 == "True")
			{
				checkBox4.Checked = true;
			}

			if (HMAC_SHA512 == "True")
			{
				checkBox5.Checked = true;
			}

			if (HMAC_SHA512_224 == "True")
			{
				checkBox6.Checked = true;
			}

			if (HMAC_SHA512_256 == "True")
			{
				checkBox7.Checked = true;
			}
		}

		private void HMAC_Load(object sender, EventArgs e)
		{

		}

		private void HMAC_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				HMAC_SHA1 = checkBox1.Checked.ToString();
				Properties.Settings.Default.HMAC_SHA1 = HMAC_SHA1;

				HMAC_SHA224 = checkBox2.Checked.ToString();
				Properties.Settings.Default.HMAC_SHA224 = HMAC_SHA224;

				HMAC_SHA256 = checkBox3.Checked.ToString();
				Properties.Settings.Default.HMAC_SHA256 = HMAC_SHA256;

				HMAC_SHA384 = checkBox4.Checked.ToString();
				Properties.Settings.Default.HMAC_SHA384 = HMAC_SHA384;

				HMAC_SHA512 = checkBox5.Checked.ToString();
				Properties.Settings.Default.HMAC_SHA512 = HMAC_SHA512;

				HMAC_SHA512_224 = checkBox6.Checked.ToString();
				Properties.Settings.Default.HMAC_SHA512_224 = HMAC_SHA512_224;

				HMAC_SHA512_256 = checkBox7.Checked.ToString();
				Properties.Settings.Default.HMAC_SHA512_256 = HMAC_SHA512_256;
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