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
	public partial class ECB_AES : Form
	{
		public static string ECB_128;
		public static string ECB_192;
		public static string ECB_256;
		public static string ECB_128_En;
		public static string ECB_128_De;
		public static string ECB_192_En;
		public static string ECB_192_De;
		public static string ECB_256_En;
		public static string ECB_256_De;

		public ECB_AES()
		{
			InitializeComponent();
			checkBox4.Visible = false;
			checkBox5.Visible = false;
			checkBox6.Visible = false;
			checkBox7.Visible = false;
			checkBox8.Visible = false;
			checkBox9.Visible = false;

			ECB_128    = Properties.Settings.Default.ECB_128.ToString();
			ECB_192    = Properties.Settings.Default.ECB_192.ToString();
			ECB_256    = Properties.Settings.Default.ECB_256.ToString();
			ECB_128_En = Properties.Settings.Default.ECB_128_En.ToString();
			ECB_128_De = Properties.Settings.Default.ECB_128_De.ToString();
			ECB_192_En = Properties.Settings.Default.ECB_192_En.ToString();
			ECB_192_De = Properties.Settings.Default.ECB_192_De.ToString();
			ECB_256_En = Properties.Settings.Default.ECB_256_En.ToString();
			ECB_256_De = Properties.Settings.Default.ECB_256_De.ToString();

			if (ECB_128 == "True")
			{
				checkBox1.Checked = true;
				checkBox4.Visible = true;
				checkBox5.Visible = true;
				if (ECB_128_En == "True")
				{
					checkBox4.Checked = true;
				}
				if (ECB_128_De == "True")
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

			if (ECB_192 == "True")
			{
				checkBox2.Checked = true;
				checkBox6.Visible = true;
				checkBox7.Visible = true;
				if (ECB_192_En == "True")
				{
					checkBox7.Checked = true;
				}
				if (ECB_192_De == "True")
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

			if (ECB_256 == "True")
			{
				checkBox3.Checked = true;
				checkBox8.Visible = true;
				checkBox9.Visible = true;
				if (ECB_256_En == "True")
				{
					checkBox9.Checked = true;
				}
				if (ECB_256_De == "True")
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

		private void ECB_Load(object sender, EventArgs e)
		{

		}

		private void ECB_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
		MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				ECB_128 = checkBox1.Checked.ToString();
				Properties.Settings.Default.ECB_128 = ECB_128;
				ECB_192 = checkBox2.Checked.ToString();
				Properties.Settings.Default.ECB_192 = ECB_192;
				ECB_256 = checkBox3.Checked.ToString();
				Properties.Settings.Default.ECB_256 = ECB_256;
				ECB_128_En = checkBox4.Checked.ToString();
				Properties.Settings.Default.ECB_128_En = ECB_128_En;
				ECB_128_De = checkBox5.Checked.ToString();
				Properties.Settings.Default.ECB_128_De = ECB_128_De;
				ECB_192_En = checkBox7.Checked.ToString();
				Properties.Settings.Default.ECB_192_En = ECB_192_En;
				ECB_192_De = checkBox6.Checked.ToString();
				Properties.Settings.Default.ECB_192_De = ECB_192_De;
				ECB_256_En = checkBox9.Checked.ToString();
				Properties.Settings.Default.ECB_256_En = ECB_256_En;
				ECB_256_De = checkBox8.Checked.ToString();
				Properties.Settings.Default.ECB_256_De = ECB_256_De;
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
