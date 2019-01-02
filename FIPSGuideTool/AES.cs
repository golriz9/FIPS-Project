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
	public partial class AES : Form
	{
		public static string ECB;
		public static string CBC;
		public static string OFB;
		public static string CFB;
		public static string CTR;

		public AES()
		{
			InitializeComponent();

			ECB = Properties.Settings.Default.ECB.ToString();
			CBC = Properties.Settings.Default.CBC.ToString();
			OFB = Properties.Settings.Default.OFB.ToString();
			CFB = Properties.Settings.Default.CFB.ToString();
			CTR = Properties.Settings.Default.CTR.ToString();

			if (ECB == "True")
			{
				checkBox_ECB.Checked = true;
				btn_ECB.Enabled = true;
			}
			else
			{
				btn_ECB.Enabled = false;
			}
			
			if (CBC == "True")
			{
				checkBox_CBC.Checked = true;
				btn_CBC.Enabled = true;
			}
			else
			{
				btn_CBC.Enabled = false;
			}

			if (OFB == "True")
			{
				checkBox_OFB.Checked = true;
				btn_OFB.Enabled = true;
			}
			else
			{
				btn_OFB.Enabled = false;
			}

			if (CFB == "True")
			{
				checkBox_CFB.Checked = true;
				btn_CFB.Enabled = true;
			}
			else
			{
				btn_CFB.Enabled = false;
			}

			if (CTR == "True")
			{
				checkBox_CTR.Checked = true;
				btn_CTR.Enabled = true;
			}
			else
			{
				btn_CTR.Enabled = false;
			}
		}

		private void btn_ECB_Click(object sender, EventArgs e)
		{
			ECB_AES f1 = new ECB_AES();
			f1.ShowDialog();
		}

		private void btn_CBC_Click(object sender, EventArgs e)
		{
			CBC_AES f1 = new CBC_AES();
			f1.ShowDialog();
		}

		private void btn_OFB_Click(object sender, EventArgs e)
		{
			OFB_AES f1 = new OFB_AES();
			f1.ShowDialog();
		}

		private void btn_CFB_Click(object sender, EventArgs e)
		{
			CFB_AES f1 = new CFB_AES();
			f1.ShowDialog();
		}

		private void btn_CTR_Click(object sender, EventArgs e)
		{
			CTR_AES f1 = new CTR_AES();
			f1.ShowDialog();
		}

		private void AES_Load(object sender, EventArgs e)
		{

		}

		private void AES_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
		MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				ECB = checkBox_ECB.Checked.ToString();
				Properties.Settings.Default.ECB = ECB;

				CBC = checkBox_CBC.Checked.ToString();
				Properties.Settings.Default.CBC = CBC;

				OFB = checkBox_OFB.Checked.ToString();
				Properties.Settings.Default.OFB = OFB;

				CFB = checkBox_CFB.Checked.ToString();
				Properties.Settings.Default.CFB = CFB;

				CTR = checkBox_CTR.Checked.ToString();
				Properties.Settings.Default.CTR = CTR;

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
