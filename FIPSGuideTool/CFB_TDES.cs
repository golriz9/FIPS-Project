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
	public partial class CFB_TDES : Form
	{
		public static string TDES_CFB_1;
		public static string TDES_CFB_1_De;
		public static string TDES_CFB_1_En;
		public static string TDES_CFB_8;
		public static string TDES_CFB_8_En;
		public static string TDES_CFB_8_De;
		public static string TDES_CFB_64;
		public static string TDES_CFB_64_En;
		public static string TDES_CFB_64_De;

		public static string TDES_CFB_P_1;
		public static string TDES_CFB_P_1_En;
		public static string TDES_CFB_P_1_De;
		public static string TDES_CFB_P_8;
		public static string TDES_CFB_P_8_En;
		public static string TDES_CFB_P_8_De;
		public static string TDES_CFB_P_64;
		public static string TDES_CFB_P_64_En;
		public static string TDES_CFB_P_64_De;

		public static string CFBTDES;
		public static string TDES_CFB_P;


		public CFB_TDES()
		{
			InitializeComponent();

			checkBox4.Visible = false;
			checkBox5.Visible = false;
			checkBox6.Visible = false;
			checkBox7.Visible = false;
			checkBox8.Visible = false;
			checkBox9.Visible = false;

			checkBox14.Visible = false;
			checkBox16.Visible = false;
			checkBox18.Visible = false;
			checkBox19.Visible = false;
			checkBox20.Visible = false;
			checkBox21.Visible = false;

			TDES_CFB_1 = Properties.Settings.Default.TDES_CFB_1.ToString();
			TDES_CFB_1_En = Properties.Settings.Default.TDES_CFB_1_En.ToString();
			TDES_CFB_1_De = Properties.Settings.Default.TDES_CFB_1_De.ToString();
			TDES_CFB_8 = Properties.Settings.Default.TDES_CFB_8.ToString();
			TDES_CFB_8_En = Properties.Settings.Default.TDES_CFB_8_En.ToString();
			TDES_CFB_8_De = Properties.Settings.Default.TDES_CFB_8_De.ToString();
			TDES_CFB_64 = Properties.Settings.Default.TDES_CFB_64.ToString();		
			TDES_CFB_64_En = Properties.Settings.Default.TDES_CFB_64_En.ToString();
			TDES_CFB_64_De = Properties.Settings.Default.TDES_CFB_64_De.ToString();
			CFBTDES        = Properties.Settings.Default.CFBTDES.ToString();
			TDES_CFB_P = Properties.Settings.Default.TDES_CFB_P.ToString();
			TDES_CFB_P_1 = Properties.Settings.Default.TDES_CFB_P_1.ToString();
			TDES_CFB_P_1_En = Properties.Settings.Default.TDES_CFB_P_1_En.ToString();
			TDES_CFB_P_1_De = Properties.Settings.Default.TDES_CFB_P_1_De.ToString();
			TDES_CFB_P_8 = Properties.Settings.Default.TDES_CFB_P_8.ToString();
			TDES_CFB_P_8_En = Properties.Settings.Default.TDES_CFB_P_8_En.ToString();
			TDES_CFB_P_8_De = Properties.Settings.Default.TDES_CFB_P_8_De.ToString();
			TDES_CFB_P_64 = Properties.Settings.Default.TDES_CFB_P_64.ToString();
			TDES_CFB_P_64_En = Properties.Settings.Default.TDES_CFB_P_64_En.ToString();
			TDES_CFB_P_64_De = Properties.Settings.Default.TDES_CFB_P_64_De.ToString();

			if (CFBTDES == "True")
			{
				checkBox10.Checked = true;
				CFB_tabs.SelectedTab = CFB;
			}
			else
			{
				checkBox10.Checked = false;
			}

			if (TDES_CFB_P == "True")
			{
				checkBox11.Checked = true;
				CFB_tabs.SelectedTab = CFB_P;
			}
			else
			{
				checkBox11.Checked = false;
			}

			if (TDES_CFB_1 == "True")
			{
				checkBox1.Checked = true;
				checkBox4.Visible = true;
				checkBox5.Visible = true;
				if (TDES_CFB_1_En == "True")
				{
					checkBox4.Checked = true;
				}
				if (TDES_CFB_1_De == "True")
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


			if (TDES_CFB_P_1 == "True")
			{
				checkBox13.Checked = true;
				checkBox19.Visible = true;
				checkBox21.Visible = true;
				if (TDES_CFB_P_1_En == "True")
				{
					checkBox19.Checked = true;
				}
				if (TDES_CFB_P_1_De == "True")
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


			if (TDES_CFB_8 == "True")
			{
				checkBox2.Checked = true;
				checkBox6.Visible = true;
				checkBox7.Visible = true;
				if (TDES_CFB_8_En == "True")
				{
					checkBox7.Checked = true;
				}
				if (TDES_CFB_8_De == "True")
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

			if (TDES_CFB_P_8 == "True")
			{
				checkBox15.Checked = true;
				checkBox20.Visible = true;
				checkBox18.Visible = true;
				if (TDES_CFB_P_8_En == "True")
				{
					checkBox20.Checked = true;
				}
				if (TDES_CFB_P_8_De == "True")
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

			if (TDES_CFB_64 == "True")
			{
				checkBox3.Checked = true;
				checkBox8.Visible = true;
				checkBox9.Visible = true;
				if (TDES_CFB_64_En == "True")
				{
					checkBox9.Checked = true;
				}
				if (TDES_CFB_64_De == "True")
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

			if (TDES_CFB_P_64 == "True")
			{
				checkBox17.Checked = true;
				checkBox16.Visible = true;
				checkBox14.Visible = true;
				if (TDES_CFB_P_64_En == "True")
				{
					checkBox16.Checked = true;
				}
				if (TDES_CFB_P_64_De == "True")
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
		}

		private void CFB_TDES_Load(object sender, EventArgs e)
		{

		}

		private void CFB_TDES_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				TDES_CFB_1 = checkBox1.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_1 = TDES_CFB_1;

				TDES_CFB_8 = checkBox2.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_8 = TDES_CFB_8;

				TDES_CFB_64 = checkBox3.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_64 = TDES_CFB_64;

				TDES_CFB_1_En = checkBox4.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_1_En = TDES_CFB_1_En;

				TDES_CFB_1_De = checkBox5.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_1_De = TDES_CFB_1_De;

				TDES_CFB_8_En = checkBox7.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_8_En = TDES_CFB_8_En;

				TDES_CFB_8_De = checkBox6.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_8_De = TDES_CFB_8_De;

				TDES_CFB_64_En = checkBox9.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_64_En = TDES_CFB_64_En;

				TDES_CFB_64_De = checkBox8.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_64_De = TDES_CFB_64_De;

				CFBTDES = checkBox10.Checked.ToString();
				Properties.Settings.Default.CFBTDES = CFBTDES;

				TDES_CFB_P = checkBox11.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_P = TDES_CFB_P;

				TDES_CFB_P_1 = checkBox13.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_P_1 = TDES_CFB_P_1;

				TDES_CFB_P_1_En = checkBox19.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_P_1_En = TDES_CFB_P_1_En;

				TDES_CFB_P_1_De = checkBox21.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_P_1_De = TDES_CFB_P_1_De;

				TDES_CFB_P_8 = checkBox15.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_P_8 = TDES_CFB_P_8;

				TDES_CFB_P_8_En = checkBox20.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_P_8_En = TDES_CFB_P_8_En;

				TDES_CFB_P_8_De = checkBox18.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_P_8_De = TDES_CFB_P_8_De;

				TDES_CFB_P_64 = checkBox17.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_P_64 = TDES_CFB_P_64;

				TDES_CFB_P_64_En = checkBox16.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_P_64_En = TDES_CFB_P_64_En;

				TDES_CFB_P_64_De = checkBox14.Checked.ToString();
				Properties.Settings.Default.TDES_CFB_P_64_De = TDES_CFB_P_64_De;

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

		private void checkBox10_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox10.Checked == true)
			{
				CFB_tabs.SelectedTab = CFB;
			}
		}

		private void checkBox11_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox11.Checked == true)
			{
				CFB_tabs.SelectedTab = CFB_P;
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
	}
}