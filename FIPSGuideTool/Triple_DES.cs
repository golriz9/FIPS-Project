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
	public partial class Triple_DES : Form
	{
		public static string TDES_ECB;
		public static string TDES_CBC;
		public static string TDES_OFB;
		public static string TDES_CFB;
		public static string TDES_CTR;

		public Triple_DES()
		{
			InitializeComponent();

			TDES_ECB = Properties.Settings.Default.TDES_ECB.ToString();
			TDES_CBC = Properties.Settings.Default.TDES_CBC.ToString();
			TDES_OFB = Properties.Settings.Default.TDES_OFB.ToString();
			TDES_CFB = Properties.Settings.Default.TDES_CFB.ToString();
			TDES_CTR = Properties.Settings.Default.TDES_CTR.ToString();

			if (TDES_ECB == "True")
			{
				checkBox_ECB.Checked = true;
				btn_ECB.Enabled = true;
			}
			else
			{
				btn_ECB.Enabled = false;
			}

			if (TDES_CBC == "True")
			{
				checkBox_CBC.Checked = true;
				btn_CBC.Enabled = true;
			}
			else
			{
				btn_CBC.Enabled = false;
			}

			if (TDES_OFB == "True")
			{
				checkBox_OFB.Checked = true;
				btn_OFB.Enabled = true;
			}
			else
			{
				btn_OFB.Enabled = false;
			}

			if (TDES_CFB == "True")
			{
				checkBox_CFB.Checked = true;
				btn_CFB.Enabled = true;
			}
			else
			{
				btn_CFB.Enabled = false;
			}

			if (TDES_CTR == "True")
			{
				checkBox_CTR.Checked = true;
				btn_CTR.Enabled = true;
			}
			else
			{
				btn_CTR.Enabled = false;
			}

		}

		private void Triple_DES_Load(object sender, EventArgs e)
		{

		}

		private void btn_ECB_Click(object sender, EventArgs e)
		{
			ECB_TDES f1 = new ECB_TDES();
			f1.ShowDialog();
		}

		private void btn_CBC_Click(object sender, EventArgs e)
		{
			CBC_TDES f1 = new CBC_TDES();
			f1.ShowDialog();
		}

		private void btn_OFB_Click(object sender, EventArgs e)
		{
			OFB_TDES f1 = new OFB_TDES();
			f1.ShowDialog();
		}

		private void btn_CFB_Click(object sender, EventArgs e)
		{
			CFB_TDES f1 = new CFB_TDES();
			f1.ShowDialog();
		}

		private void btn_CTR_Click(object sender, EventArgs e)
		{
			CTR_TDES f1 = new CTR_TDES();
			f1.ShowDialog();
		}

		private void Triple_DES_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				TDES_ECB = checkBox_ECB.Checked.ToString();
				Properties.Settings.Default.TDES_ECB = TDES_ECB;

				TDES_CBC = checkBox_CBC.Checked.ToString();
				Properties.Settings.Default.TDES_CBC = TDES_CBC;

				TDES_OFB = checkBox_OFB.Checked.ToString();
				Properties.Settings.Default.TDES_OFB = TDES_OFB;

				TDES_CFB = checkBox_CFB.Checked.ToString();
				Properties.Settings.Default.TDES_CFB = TDES_CFB;

				TDES_CTR = checkBox_CTR.Checked.ToString();
				Properties.Settings.Default.TDES_CTR = TDES_CTR;

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

		private void checkBox_ECB_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_ECB.Checked == true)
			{
				btn_ECB.Enabled = true;
			}
			else
			{
				btn_ECB.Enabled = false;
			}
		}

		private void checkBox_CBC_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_CBC.Checked == true)
			{
				btn_CBC.Enabled = true;
			}
			else
			{
				btn_CBC.Enabled = false;
			}
		}

		private void checkBox_OFB_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_OFB.Checked == true)
			{
				btn_OFB.Enabled = true;
			}
			else
			{
				btn_OFB.Enabled = false;
			}
		}

		private void checkBox_CFB_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_CFB.Checked == true)
			{
				btn_CFB.Enabled = true;
			}
			else
			{
				btn_CFB.Enabled = false;
			}
		}

		private void checkBox_CTR_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_CTR.Checked == true)
			{
				btn_CTR.Enabled = true;
			}
			else
			{
				btn_CTR.Enabled = false;
			}
		}
	}
}