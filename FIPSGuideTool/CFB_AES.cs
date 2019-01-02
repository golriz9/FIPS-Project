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
	public partial class CFB_AES : Form
	{
		public static string CFB1_128;
		public static string CFB1_192;
		public static string CFB1_256;
		public static string CFB1_128_En;
		public static string CFB1_128_De;
		public static string CFB1_192_En;
		public static string CFB1_192_De;
		public static string CFB1_256_En;
		public static string CFB1_256_De;
		public static string CFB8_128;
		public static string CFB8_192;
		public static string CFB8_256;
		public static string CFB8_128_En;
		public static string CFB8_128_De;
		public static string CFB8_192_En;
		public static string CFB8_192_De;
		public static string CFB8_256_En;
		public static string CFB8_256_De;
		public static string CFB128_128;
		public static string CFB128_192;
		public static string CFB128_256;
		public static string CFB128_128_En;
		public static string CFB128_128_De;
		public static string CFB128_192_En;
		public static string CFB128_192_De;
		public static string CFB128_256_En;
		public static string CFB128_256_De;
		public static string CFB1_AES;
		public static string CFB8_AES;
		public static string CFB128_AES;


		public CFB_AES()
		{
			InitializeComponent();
			checkBox4.Visible = false;
			checkBox5.Visible = false;
			checkBox6.Visible = false;
			checkBox7.Visible = false;
			checkBox8.Visible = false;
			checkBox9.Visible = false;

			CFB1_AES   = Properties.Settings.Default.CFB1_AES.ToString();
			CFB8_AES   = Properties.Settings.Default.CFB8_AES.ToString();
			CFB128_AES = Properties.Settings.Default.CFB128_AES.ToString();

			CFB1_128    = Properties.Settings.Default.CFB1_128.ToString();
			CFB1_192    = Properties.Settings.Default.CFB1_192.ToString();
			CFB1_256    = Properties.Settings.Default.CFB1_256.ToString();
			CFB1_128_En = Properties.Settings.Default.CFB1_128_En.ToString();
			CFB1_128_De = Properties.Settings.Default.CFB1_128_De.ToString();
			CFB1_192_En = Properties.Settings.Default.CFB1_192_En.ToString();
			CFB1_192_De = Properties.Settings.Default.CFB1_192_De.ToString();
			CFB1_256_En = Properties.Settings.Default.CFB1_256_En.ToString();
			CFB1_256_De = Properties.Settings.Default.CFB1_256_De.ToString();

			CFB8_128    = Properties.Settings.Default.CFB8_128.ToString();
			CFB8_192    = Properties.Settings.Default.CFB8_192.ToString();
			CFB8_256    = Properties.Settings.Default.CFB8_256.ToString();
			CFB8_128_En = Properties.Settings.Default.CFB8_128_En.ToString();
			CFB8_128_De = Properties.Settings.Default.CFB8_128_De.ToString();
			CFB8_192_En = Properties.Settings.Default.CFB8_192_En.ToString();
			CFB8_192_De = Properties.Settings.Default.CFB8_192_De.ToString();
			CFB8_256_En = Properties.Settings.Default.CFB8_256_En.ToString();
			CFB8_256_De = Properties.Settings.Default.CFB8_256_De.ToString();

			CFB128_128    = Properties.Settings.Default.CFB128_128.ToString();
			CFB128_192    = Properties.Settings.Default.CFB128_192.ToString();
			CFB128_256    = Properties.Settings.Default.CFB128_256.ToString();
			CFB128_128_En = Properties.Settings.Default.CFB128_128_En.ToString();
			CFB128_128_De = Properties.Settings.Default.CFB128_128_De.ToString();
			CFB128_192_En = Properties.Settings.Default.CFB128_192_En.ToString();
			CFB128_192_De = Properties.Settings.Default.CFB128_192_De.ToString();
			CFB128_256_En = Properties.Settings.Default.CFB128_256_En.ToString();
			CFB128_256_De = Properties.Settings.Default.CFB128_256_De.ToString();

			if (CFB1_AES == "True")
			{
				checkBox10.Checked = true;
				CFB_tabs.SelectedTab = CFB1;
			}
			else
			{
				checkBox10.Checked = false;
			}

			if (CFB8_AES == "True")
			{
				checkBox11.Checked = true;
				CFB_tabs.SelectedTab = CFB8;
			}
			else
			{
				checkBox11.Checked = false;
			}

			if (CFB128_AES == "True")
			{
				checkBox12.Checked = true;
				CFB_tabs.SelectedTab = CFB128;
			}
			else
			{
				checkBox12.Checked = false;
			}

			if (CFB1_128 == "True")
			{
				checkBox1.Checked = true;
				checkBox4.Visible = true;
				checkBox5.Visible = true;
				if (CFB1_128_En == "True")
				{
					checkBox4.Checked = true;
				}
				if (CFB1_128_De == "True")
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

			if (CFB1_192 == "True")
			{
				checkBox2.Checked = true;
				checkBox6.Visible = true;
				checkBox7.Visible = true;
				if (CFB1_192_En == "True")
				{
					checkBox7.Checked = true;
				}
				if (CFB1_192_De == "True")
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

			if (CFB1_256 == "True")
			{
				checkBox3.Checked = true;
				checkBox8.Visible = true;
				checkBox9.Visible = true;
				if (CFB1_256_En == "True")
				{
					checkBox9.Checked = true;
				}
				if (CFB1_256_De == "True")
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



			if (CFB8_128 == "True")
			{
				checkBox13.Checked = true;
				checkBox19.Visible = true;
				checkBox21.Visible = true;
				if (CFB8_128_En == "True")
				{
					checkBox19.Checked = true;
				}
				if (CFB8_128_De == "True")
				{
					checkBox21.Checked = true;
				}
			}
			else
			{
				checkBox13.Checked = false;
				checkBox19.Visible = false;
				checkBox21.Visible = false;
			}

			if (CFB8_192 == "True")
			{
				checkBox15.Checked = true;
				checkBox20.Visible = true;
				checkBox18.Visible = true;
				if (CFB8_192_En == "True")
				{
					checkBox20.Checked = true;
				}
				if (CFB8_192_De == "True")
				{
					checkBox18.Checked = true;
				}
			}
			else
			{
				checkBox15.Checked = false;
				checkBox20.Visible = false;
				checkBox18.Visible = false;
			}

			if (CFB8_256 == "True")
			{
				checkBox17.Checked = true;
				checkBox16.Visible = true;
				checkBox14.Visible = true;
				if (CFB8_256_En == "True")
				{
					checkBox16.Checked = true;
				}
				if (CFB8_256_De == "True")
				{
					checkBox14.Checked = true;
				}
			}
			else
			{
				checkBox17.Checked = false;
				checkBox16.Visible = false;
				checkBox14.Visible = false;
			}



			if (CFB128_128 == "True")
			{
				checkBox22.Checked = true;
				checkBox28.Visible = true;
				checkBox30.Visible = true;
				if (CFB128_128_En == "True")
				{
					checkBox28.Checked = true;
				}
				if (CFB128_128_De == "True")
				{
					checkBox30.Checked = true;
				}
			}
			else
			{
				checkBox22.Checked = false;
				checkBox28.Visible = false;
				checkBox30.Visible = false;
			}

			if (CFB128_192 == "True")
			{
				checkBox24.Checked = true;
				checkBox29.Visible = true;
				checkBox27.Visible = true;
				if (CFB128_192_En == "True")
				{
					checkBox29.Checked = true;
				}
				if (CFB128_192_De == "True")
				{
					checkBox27.Checked = true;
				}
			}
			else
			{
				checkBox24.Checked = false;
				checkBox29.Visible = false;
				checkBox27.Visible = false;
			}

			if (CFB128_256 == "True")
			{
				checkBox26.Checked = true;
				checkBox25.Visible = true;
				checkBox23.Visible = true;
				if (CFB128_256_En == "True")
				{
					checkBox25.Checked = true;
				}
				if (CFB128_256_De == "True")
				{
					checkBox23.Checked = true;
				}
			}
			else
			{
				checkBox26.Checked = false;
				checkBox25.Visible = false;
				checkBox23.Visible = false;
			}

		}

		private void CFB_Load(object sender, EventArgs e)
		{

		}

		private void CFB_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
	MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				CFB1_128 = checkBox1.Checked.ToString();
				Properties.Settings.Default.CFB1_128 = CFB1_128;

				CFB1_192 = checkBox2.Checked.ToString();
				Properties.Settings.Default.CFB1_192 = CFB1_192;

				CFB1_256 = checkBox3.Checked.ToString();
				Properties.Settings.Default.CFB1_256 = CFB1_256;

				CFB1_128_En = checkBox4.Checked.ToString();
				Properties.Settings.Default.CFB1_128_En = CFB1_128_En;

				CFB1_128_De = checkBox5.Checked.ToString();
				Properties.Settings.Default.CFB1_128_De = CFB1_128_De;

				CFB1_192_En = checkBox7.Checked.ToString();
				Properties.Settings.Default.CFB1_192_En = CFB1_192_En;

				CFB1_192_De = checkBox6.Checked.ToString();
				Properties.Settings.Default.CFB1_192_De = CFB1_192_De;

				CFB1_256_En = checkBox9.Checked.ToString();
				Properties.Settings.Default.CFB1_256_En = CFB1_256_En;

				CFB1_256_De = checkBox8.Checked.ToString();
				Properties.Settings.Default.CFB1_256_De = CFB1_256_De;

				CFB8_128 = checkBox13.Checked.ToString();
				Properties.Settings.Default.CFB8_128 = CFB8_128;

				CFB8_192 = checkBox15.Checked.ToString();
				Properties.Settings.Default.CFB8_192 = CFB8_192;

				CFB8_256 = checkBox17.Checked.ToString();
				Properties.Settings.Default.CFB8_256 = CFB8_256;

				CFB8_128_En = checkBox19.Checked.ToString();
				Properties.Settings.Default.CFB8_128_En = CFB8_128_En;

				CFB8_128_De = checkBox21.Checked.ToString();
				Properties.Settings.Default.CFB8_128_De = CFB8_128_De;

				CFB8_192_En = checkBox20.Checked.ToString();
				Properties.Settings.Default.CFB8_192_En = CFB8_192_En;

				CFB8_192_De = checkBox18.Checked.ToString();
				Properties.Settings.Default.CFB8_192_De = CFB8_192_De;

				CFB8_256_En = checkBox16.Checked.ToString();
				Properties.Settings.Default.CFB8_256_En = CFB8_256_En;

				CFB8_256_De = checkBox14.Checked.ToString();
				Properties.Settings.Default.CFB8_256_De = CFB8_256_De;

				CFB128_128 = checkBox22.Checked.ToString();
				Properties.Settings.Default.CFB128_128 = CFB128_128;

				CFB128_192 = checkBox24.Checked.ToString();
				Properties.Settings.Default.CFB128_192 = CFB128_192;

				CFB128_256 = checkBox26.Checked.ToString();
				Properties.Settings.Default.CFB128_256 = CFB128_256;

				CFB128_128_En = checkBox28.Checked.ToString();
				Properties.Settings.Default.CFB128_128_En = CFB128_128_En;

				CFB128_128_De = checkBox30.Checked.ToString();
				Properties.Settings.Default.CFB128_128_De = CFB128_128_De;

				CFB128_192_En = checkBox29.Checked.ToString();
				Properties.Settings.Default.CFB128_192_En = CFB128_192_En;

				CFB128_192_De = checkBox27.Checked.ToString();
				Properties.Settings.Default.CFB128_192_De = CFB128_192_De;

				CFB128_256_En = checkBox25.Checked.ToString();
				Properties.Settings.Default.CFB128_256_En = CFB128_256_En;

				CFB128_256_De = checkBox23.Checked.ToString();
				Properties.Settings.Default.CFB128_256_De = CFB128_256_De;

				CFB1_AES = checkBox10.Checked.ToString();
				Properties.Settings.Default.CFB1_AES = CFB1_AES;

				CFB8_AES = checkBox11.Checked.ToString();
				Properties.Settings.Default.CFB8_AES = CFB8_AES;

				CFB128_AES = checkBox12.Checked.ToString();
				Properties.Settings.Default.CFB128_AES = CFB128_AES;

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
		
		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void checkBox10_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox10.Checked == true)
			{
				CFB_tabs.SelectedTab = CFB1;
			}
		}

		private void checkBox11_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox11.Checked == true)
			{
				CFB_tabs.SelectedTab = CFB8;
			}
		}

		private void checkBox12_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox12.Checked == true)
			{
				CFB_tabs.SelectedTab = CFB128;
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

		private void checkBox13_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox13.Checked.ToString() == "True")
			{
				checkBox19.Visible = true;
				checkBox21.Visible = true;
			}
			else
			{
				checkBox19.Visible = false;
				checkBox21.Visible = false;
			}
		}

		private void checkBox15_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox15.Checked.ToString() == "True")
			{
				checkBox18.Visible = true;
				checkBox20.Visible = true;
			}
			else
			{
				checkBox18.Visible = false;
				checkBox20.Visible = false;
			}
		}

		private void checkBox17_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox17.Checked.ToString() == "True")
			{
				checkBox14.Visible = true;
				checkBox16.Visible = true;
			}
			else
			{
				checkBox14.Visible = false;
				checkBox16.Visible = false;
			}
		}

		private void checkBox22_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox22.Checked.ToString() == "True")
			{
				checkBox28.Visible = true;
				checkBox30.Visible = true;
			}
			else
			{
				checkBox28.Visible = false;
				checkBox30.Visible = false;
			}
		}

		private void checkBox24_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox24.Checked.ToString() == "True")
			{
				checkBox27.Visible = true;
				checkBox29.Visible = true;
			}
			else
			{
				checkBox27.Visible = false;
				checkBox29.Visible = false;
			}
		}

		private void checkBox26_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox26.Checked.ToString() == "True")
			{
				checkBox23.Visible = true;
				checkBox25.Visible = true;
			}
			else
			{
				checkBox23.Visible = false;
				checkBox25.Visible = false;
			}
		}
	}
}
