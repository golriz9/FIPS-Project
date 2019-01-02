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
	public partial class OFB_AES : Form
	{
		public static string OFB_128;
		public static string OFB_192;
		public static string OFB_256;
		public static string OFB_128_En;
		public static string OFB_128_De;
		public static string OFB_192_En;
		public static string OFB_192_De;
		public static string OFB_256_En;
		public static string OFB_256_De;

		public OFB_AES()
		{
			InitializeComponent();

			checkBox4.Visible = false;
			checkBox5.Visible = false;
			checkBox6.Visible = false;
			checkBox7.Visible = false;
			checkBox8.Visible = false;
			checkBox9.Visible = false;

			OFB_128    = Properties.Settings.Default.OFB_128.ToString();
			OFB_192    = Properties.Settings.Default.OFB_192.ToString();
			OFB_256    = Properties.Settings.Default.OFB_256.ToString();
			OFB_128_En = Properties.Settings.Default.OFB_128_En.ToString();
			OFB_128_De = Properties.Settings.Default.OFB_128_De.ToString();
			OFB_192_En = Properties.Settings.Default.OFB_192_En.ToString();
			OFB_192_De = Properties.Settings.Default.OFB_192_De.ToString();
			OFB_256_En = Properties.Settings.Default.OFB_256_En.ToString();
			OFB_256_De = Properties.Settings.Default.OFB_256_De.ToString();

			if (OFB_128 == "True")
			{
				checkBox1.Checked = true;
				checkBox4.Visible = true;
				checkBox5.Visible = true;
				if (OFB_128_En == "True")
				{
					checkBox4.Checked = true;
				}
				if (OFB_128_De == "True")
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

			if (OFB_192 == "True")
			{
				checkBox2.Checked = true;
				checkBox6.Visible = true;
				checkBox7.Visible = true;
				if (OFB_192_En == "True")
				{
					checkBox7.Checked = true;
				}
				if (OFB_192_De == "True")
				{
					checkBox6.Checked = true;
				}
			}
			else
			{
				checkBox2.Checked = false;
				checkBox6.Visible = false;
				checkBox7.Visible = false;
			}

			if (OFB_256 == "True")
			{
				checkBox3.Checked = true;
				checkBox8.Visible = true;
				checkBox9.Visible = true;
				if (OFB_256_En == "True")
				{
					checkBox9.Checked = true;
				}
				if (OFB_256_De == "True")
				{
					checkBox8.Checked = true;
				}
			}
			else
			{
				checkBox3.Checked = false;
				checkBox8.Visible = false;
				checkBox9.Visible = false;
			}

		}
		
		private void OFB_Load(object sender, EventArgs e)
		{

		}

		private void OFB_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
	MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				OFB_128 = checkBox1.Checked.ToString();
				Properties.Settings.Default.OFB_128 = OFB_128;
				OFB_192 = checkBox2.Checked.ToString();
				Properties.Settings.Default.OFB_192 = OFB_192;
				OFB_256 = checkBox3.Checked.ToString();
				Properties.Settings.Default.OFB_256 = OFB_256;
				OFB_128_En = checkBox4.Checked.ToString();
				Properties.Settings.Default.OFB_128_En = OFB_128_En;
				OFB_128_De = checkBox5.Checked.ToString();
				Properties.Settings.Default.OFB_128_De = OFB_128_De;
				OFB_192_En = checkBox7.Checked.ToString();
				Properties.Settings.Default.OFB_192_En = OFB_192_En;
				OFB_192_De = checkBox6.Checked.ToString();
				Properties.Settings.Default.OFB_192_De = OFB_192_De;
				OFB_256_En = checkBox9.Checked.ToString();
				Properties.Settings.Default.OFB_256_En = OFB_256_En;
				OFB_256_De = checkBox8.Checked.ToString();
				Properties.Settings.Default.OFB_256_De = OFB_256_De;
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

		private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
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

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked.ToString() == "True")
			{
				checkBox6.Visible = true;
				checkBox7.Visible = true;
			}
			else
			{
				checkBox6.Visible = false;
				checkBox7.Visible = false;
			}
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox3.Checked.ToString() == "True")
			{
				checkBox8.Visible = true;
				checkBox9.Visible = true;
			}
			else
			{
				checkBox8.Visible = false;
				checkBox9.Visible = false;
			}
		}
	}
}