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
	public partial class ECDSA_KeyVal : Form
	{
		public static string ECDSA_PKV_P192;
		public static string ECDSA_PKV_P224;
		public static string ECDSA_PKV_P256;
		public static string ECDSA_PKV_P384;
		public static string ECDSA_PKV_P521;

		public static string ECDSA_PKV_K163;
		public static string ECDSA_PKV_K233;
		public static string ECDSA_PKV_K283;
		public static string ECDSA_PKV_K409;
		public static string ECDSA_PKV_K571;

		public static string ECDSA_PKV_B163;
		public static string ECDSA_PKV_B233;
		public static string ECDSA_PKV_B283;
		public static string ECDSA_PKV_B409;
		public static string ECDSA_PKV_B571;

		public ECDSA_KeyVal()
		{
			InitializeComponent();
			ECDSA_PKV_P192 = Properties.Settings.Default.ECDSA_PKV_P192.ToString();
			ECDSA_PKV_P224 = Properties.Settings.Default.ECDSA_PKV_P224.ToString();
			ECDSA_PKV_P256 = Properties.Settings.Default.ECDSA_PKV_P256.ToString();
			ECDSA_PKV_P384 = Properties.Settings.Default.ECDSA_PKV_P384.ToString();
			ECDSA_PKV_P521 = Properties.Settings.Default.ECDSA_PKV_P521.ToString();

			if (ECDSA_PKV_P192 == "True")
			{
				checkBox15.Checked = true;
			}

			if (ECDSA_PKV_P224 == "True")
			{
				checkBox12.Checked = true;
			}

			if (ECDSA_PKV_P256 == "True")
			{
				checkBox1.Checked = true;
			}

			if (ECDSA_PKV_P384 == "True")
			{
				checkBox2.Checked = true;
			}

			if (ECDSA_PKV_P521 == "True")
			{
				checkBox3.Checked = true;
			}

			ECDSA_PKV_K163 = Properties.Settings.Default.ECDSA_PKV_K163.ToString();
			ECDSA_PKV_K233 = Properties.Settings.Default.ECDSA_PKV_K233.ToString();
			ECDSA_PKV_K283 = Properties.Settings.Default.ECDSA_PKV_K283.ToString();
			ECDSA_PKV_K409 = Properties.Settings.Default.ECDSA_PKV_K409.ToString();
			ECDSA_PKV_K571 = Properties.Settings.Default.ECDSA_PKV_K571.ToString();

			if (ECDSA_PKV_K163 == "True")
			{
				checkBox14.Checked = true;
			}

			if (ECDSA_PKV_K233 == "True")
			{
				checkBox7.Checked = true;
			}

			if (ECDSA_PKV_K283 == "True")
			{
				checkBox6.Checked = true;
			}

			if (ECDSA_PKV_K409 == "True")
			{
				checkBox5.Checked = true;
			}

			if (ECDSA_PKV_K571 == "True")
			{
				checkBox4.Checked = true;
			}

			ECDSA_PKV_B163 = Properties.Settings.Default.ECDSA_PKV_B163.ToString();
			ECDSA_PKV_B233 = Properties.Settings.Default.ECDSA_PKV_B233.ToString();
			ECDSA_PKV_B283 = Properties.Settings.Default.ECDSA_PKV_B283.ToString();
			ECDSA_PKV_B409 = Properties.Settings.Default.ECDSA_PKV_B409.ToString();
			ECDSA_PKV_B571 = Properties.Settings.Default.ECDSA_PKV_B571.ToString();

			if (ECDSA_PKV_B163 == "True")
			{
				checkBox13.Checked = true;
			}

			if (ECDSA_PKV_B233 == "True")
			{
				checkBox11.Checked = true;
			}

			if (ECDSA_PKV_B283 == "True")
			{
				checkBox10.Checked = true;
			}

			if (ECDSA_PKV_B409 == "True")
			{
				checkBox9.Checked = true;
			}

			if (ECDSA_PKV_B571 == "True")
			{
				checkBox8.Checked = true;
			}
		}

		private void ECDSA_KeyVal_Load(object sender, EventArgs e)
		{

		}

		private void ECDSA_KeyVal_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				ECDSA_PKV_P192 = checkBox15.Checked.ToString();
				Properties.Settings.Default.ECDSA_PKV_P192 = ECDSA_PKV_P192;

				ECDSA_PKV_P224 = checkBox12.Checked.ToString();
				Properties.Settings.Default.ECDSA_PKV_P224 = ECDSA_PKV_P224;

				ECDSA_PKV_P256 = checkBox1.Checked.ToString();
				Properties.Settings.Default.ECDSA_PKV_P256 = ECDSA_PKV_P256;

				ECDSA_PKV_P384 = checkBox2.Checked.ToString();
				Properties.Settings.Default.ECDSA_PKV_P384 = ECDSA_PKV_P384;

				ECDSA_PKV_P521 = checkBox3.Checked.ToString();
				Properties.Settings.Default.ECDSA_PKV_P521 = ECDSA_PKV_P521;

				ECDSA_PKV_K163 = checkBox14.Checked.ToString();
				Properties.Settings.Default.ECDSA_PKV_K163 = ECDSA_PKV_K163;

				ECDSA_PKV_K233 = checkBox7.Checked.ToString();
				Properties.Settings.Default.ECDSA_PKV_K233 = ECDSA_PKV_K233;

				ECDSA_PKV_K283 = checkBox6.Checked.ToString();
				Properties.Settings.Default.ECDSA_PKV_K283 = ECDSA_PKV_K283;

				ECDSA_PKV_K409 = checkBox5.Checked.ToString();
				Properties.Settings.Default.ECDSA_PKV_K409 = ECDSA_PKV_K409;

				ECDSA_PKV_K571 = checkBox4.Checked.ToString();
				Properties.Settings.Default.ECDSA_PKV_K571 = ECDSA_PKV_K571;




				ECDSA_PKV_B163 = checkBox13.Checked.ToString();
				Properties.Settings.Default.ECDSA_PKV_B163 = ECDSA_PKV_B163;

				ECDSA_PKV_B233 = checkBox11.Checked.ToString();
				Properties.Settings.Default.ECDSA_PKV_B233 = ECDSA_PKV_B233;

				ECDSA_PKV_B283 = checkBox10.Checked.ToString();
				Properties.Settings.Default.ECDSA_PKV_B283 = ECDSA_PKV_B283;

				ECDSA_PKV_B409 = checkBox9.Checked.ToString();
				Properties.Settings.Default.ECDSA_PKV_B409 = ECDSA_PKV_B409;

				ECDSA_PKV_B571 = checkBox8.Checked.ToString();
				Properties.Settings.Default.ECDSA_PKV_B571 = ECDSA_PKV_B571;

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