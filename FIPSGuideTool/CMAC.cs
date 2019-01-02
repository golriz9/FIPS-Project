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
	public partial class CMAC : Form
	{
		public static string Gen_CMAC_AES;
		public static string Gen_CMAC_AES128;
		public static string Gen_CMAC_AES192;
		public static string Gen_CMAC_AES256;
		public static string Ver_CMAC_AES;
		public static string Ver_CMAC_AES128;
		public static string Ver_CMAC_AES192;
		public static string Ver_CMAC_AES256;
		public static string Gen_CMAC_TDES;
		public static string Gen_CMAC_TDES3Key;
		public static string Ver_CMAC_TDES;
		public static string Ver_CMAC_TDES2Key;
		public static string Ver_CMAC_TDES3Key;

		public CMAC()
		{
			InitializeComponent();

			Gen_CMAC_AES      = Properties.Settings.Default.Gen_CMAC_AES.ToString();
			Gen_CMAC_AES128   = Properties.Settings.Default.Gen_CMAC_AES128.ToString();
			Gen_CMAC_AES192   = Properties.Settings.Default.Gen_CMAC_AES192.ToString();
			Gen_CMAC_AES256   = Properties.Settings.Default.Gen_CMAC_AES256.ToString();
			Ver_CMAC_AES      = Properties.Settings.Default.Ver_CMAC_AES.ToString();
			Ver_CMAC_AES128   = Properties.Settings.Default.Ver_CMAC_AES128.ToString();
			Ver_CMAC_AES192   = Properties.Settings.Default.Ver_CMAC_AES192.ToString();
			Ver_CMAC_AES256   = Properties.Settings.Default.Ver_CMAC_AES256.ToString();
			Gen_CMAC_TDES     = Properties.Settings.Default.Gen_CMAC_TDES.ToString();
			Gen_CMAC_TDES3Key = Properties.Settings.Default.Gen_CMAC_TDES3Key.ToString();
			Ver_CMAC_TDES     = Properties.Settings.Default.Ver_CMAC_TDES.ToString();
			Ver_CMAC_TDES2Key = Properties.Settings.Default.Ver_CMAC_TDES2Key.ToString();
			Ver_CMAC_TDES3Key = Properties.Settings.Default.Ver_CMAC_TDES3Key.ToString();

			if (Gen_CMAC_AES == "True")
			{
				checkBox21.Checked = true;
			}

			if (Ver_CMAC_AES == "True")
			{
				checkBox20.Checked = true;
			}

			if (Gen_CMAC_TDES == "True")
			{
				checkBox7.Checked = true;
			}

			if (Ver_CMAC_TDES == "True")
			{
				checkBox8.Checked = true;
			}

			if (Gen_CMAC_AES128 == "True")
			{
				checkBox1.Checked = true;
			}

			if (Gen_CMAC_AES192 == "True")
			{
				checkBox2.Checked = true;
			}

			if (Gen_CMAC_AES256 == "True")
			{
				checkBox3.Checked = true;
			}

			if (Ver_CMAC_AES128 == "True")
			{
				checkBox6.Checked = true;
			}

			if (Ver_CMAC_AES192 == "True")
			{
				checkBox5.Checked = true;
			}

			if (Ver_CMAC_AES256 == "True")
			{
				checkBox4.Checked = true;
			}

			if (Gen_CMAC_TDES3Key == "True")
			{
				checkBox18.Checked = true;
			}

			if (Ver_CMAC_TDES2Key == "True")
			{
				checkBox10.Checked = true;
			}

			if (Ver_CMAC_TDES3Key == "True")
			{
				checkBox9.Checked = true;
			}
		}

		private void CMAC_Load(object sender, EventArgs e)
		{

		}

		private void checkBox21_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox21.Checked == true)
			{
				CMAC_tabs.SelectedTab = Gen_CMAC_AES_Tab;
			}
		}

		private void checkBox20_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox20.Checked == true)
			{
				CMAC_tabs.SelectedTab = Ver_CMAC_AES_Tab;
			}
		}

		private void checkBox7_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox7.Checked == true)
			{
				CMAC_tabs.SelectedTab = Gen_CMAC_TDES_Tab;
			}
		}

		private void checkBox8_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox8.Checked == true)
			{
				CMAC_tabs.SelectedTab = Ver_CMAC_TDES_Tab;
			}
		}

		private void CMAC_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				Gen_CMAC_AES = checkBox21.Checked.ToString();
				Properties.Settings.Default.Gen_CMAC_AES = Gen_CMAC_AES;
				Ver_CMAC_AES = checkBox20.Checked.ToString();
				Properties.Settings.Default.Ver_CMAC_AES = Ver_CMAC_AES;
				Gen_CMAC_TDES = checkBox7.Checked.ToString();
				Properties.Settings.Default.Gen_CMAC_TDES = Gen_CMAC_TDES;
				Ver_CMAC_TDES = checkBox8.Checked.ToString();
				Properties.Settings.Default.Ver_CMAC_TDES = Ver_CMAC_TDES;
				Gen_CMAC_AES128 = checkBox1.Checked.ToString();
				Properties.Settings.Default.Gen_CMAC_AES128 = Gen_CMAC_AES128;
				Gen_CMAC_AES192 = checkBox2.Checked.ToString();
				Properties.Settings.Default.Gen_CMAC_AES192 = Gen_CMAC_AES192;
				Gen_CMAC_AES256 = checkBox3.Checked.ToString();
				Properties.Settings.Default.Gen_CMAC_AES256 = Gen_CMAC_AES256;
				Ver_CMAC_AES128 = checkBox6.Checked.ToString();
				Properties.Settings.Default.Ver_CMAC_AES128 = Ver_CMAC_AES128;
				Ver_CMAC_AES192 = checkBox5.Checked.ToString();
				Properties.Settings.Default.Ver_CMAC_AES192 = Ver_CMAC_AES192;
				Ver_CMAC_AES256 = checkBox4.Checked.ToString();
				Properties.Settings.Default.Ver_CMAC_AES256 = Ver_CMAC_AES256;
				Gen_CMAC_TDES3Key = checkBox18.Checked.ToString();
				Properties.Settings.Default.Gen_CMAC_TDES3Key = Gen_CMAC_TDES3Key;
				Ver_CMAC_TDES2Key = checkBox10.Checked.ToString();
				Properties.Settings.Default.Ver_CMAC_TDES2Key = Ver_CMAC_TDES2Key;
				Ver_CMAC_TDES3Key = checkBox9.Checked.ToString();
				Properties.Settings.Default.Ver_CMAC_TDES3Key = Ver_CMAC_TDES3Key;
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



