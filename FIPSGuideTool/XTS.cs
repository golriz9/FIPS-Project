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
	public partial class XTS : Form
	{
		public static string XTS128;
		public static string XTS128_En;
		public static string XTS128_De;
		public static string XTS256;
		public static string XTS256_En;
		public static string XTS256_De;
		
		public XTS()
		{
			InitializeComponent();

			XTS128    = Properties.Settings.Default.XTS128.ToString();
			XTS128_En = Properties.Settings.Default.XTS128_En.ToString();
			XTS128_De = Properties.Settings.Default.XTS128_De.ToString();
			XTS256    = Properties.Settings.Default.XTS256.ToString();
			XTS256_En = Properties.Settings.Default.XTS256_En.ToString();
			XTS256_De = Properties.Settings.Default.XTS256_De.ToString();

			if (XTS128 == "True")
			{
				checkBox1.Checked = true;
				checkBox4.Visible = true;
				checkBox5.Visible = true;

				if (XTS128_En == "True")
				{
					checkBox4.Checked = true;
				}
				if (XTS128_De == "True")
				{
					checkBox5.Checked = true;
				}
			}
			else
			{
				checkBox1.Checked = false;
				checkBox4.Visible = false;
				checkBox5.Visible = false;
			}

			if (XTS256 == "True")
			{
				checkBox3.Checked = true;
				checkBox9.Visible = true;
				checkBox8.Visible = true;

				if (XTS256_En == "True")
				{
					checkBox9.Checked = true;
				}
				if (XTS256_De == "True")
				{
					checkBox8.Checked = true;
				}
			}
			else
			{
				checkBox3.Checked = false;
				checkBox9.Visible = false;
				checkBox8.Visible = false;
			}
		}

		private void XTS_Load(object sender, EventArgs e)
		{

		}

		private void XTS_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				XTS128 = checkBox1.Checked.ToString();
				Properties.Settings.Default.XTS128 = XTS128;
				XTS128_En = checkBox4.Checked.ToString();
				Properties.Settings.Default.XTS128_En = XTS128_En;
				XTS128_De = checkBox5.Checked.ToString();
				Properties.Settings.Default.XTS128_De = XTS128_De;

				XTS256 = checkBox3.Checked.ToString();
				Properties.Settings.Default.XTS256 = XTS256;
				XTS256_En = checkBox9.Checked.ToString();
				Properties.Settings.Default.XTS256_En = XTS256_En;
				XTS256_De = checkBox8.Checked.ToString();
				Properties.Settings.Default.XTS256_De = XTS256_De;

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

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked.ToString() == "True")
			{
				checkBox4.Visible = true;
				checkBox5.Visible = true;
			}
			else
			{
				checkBox4.Visible = false;
				checkBox5.Visible = false;
			}
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox3.Checked.ToString() == "True")
			{
				checkBox9.Visible = true;
				checkBox8.Visible = true;
			}
			else
			{
				checkBox9.Visible = false;
				checkBox8.Visible = false;
			}
		}
	}
}