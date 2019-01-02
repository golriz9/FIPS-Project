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
	public partial class CTR_AES : Form
	{
		public static string CTR_128;
		public static string CTR_192;
		public static string CTR_256;
		public static string CTR_128_En;
		public static string CTR_192_En;
		public static string CTR_256_En;

		public CTR_AES()
		{
			InitializeComponent();

			CTR_128 = Properties.Settings.Default.CTR_128.ToString();
			CTR_192 = Properties.Settings.Default.CTR_192.ToString();
			CTR_256 = Properties.Settings.Default.CTR_256.ToString();
			CTR_128_En = Properties.Settings.Default.CTR_128_En.ToString();
			CTR_192_En = Properties.Settings.Default.CTR_192_En.ToString();
			CTR_256_En = Properties.Settings.Default.CTR_256_En.ToString();
		}

		private void CTR_Load(object sender, EventArgs e)
		{

			if (CTR_128 == "True")
			{
				checkBox_128en.Checked = true;
			}
			else
			{
				checkBox_128en.Checked = false;
			}

			if (CTR_192 == "True")
			{
				checkBox_192en.Checked = true;
			}
			else
			{
				checkBox_192en.Checked = false;
			}

			if (CTR_256 == "True")
			{
				checkBox_256en.Checked = true;
			}
			else
			{
				checkBox_256en.Checked = false;
			}

		}

		private void CTR_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				Properties.Settings.Default.CBC_256 = CTR_256;
				CTR_128_En = checkBox_128en.Checked.ToString();
				Properties.Settings.Default.CBC_128_En = CTR_128_En;
				CTR_192_En = checkBox_128en.Checked.ToString();
				Properties.Settings.Default.CBC_192_En = CTR_192_En;
				CTR_256 = checkBox_256en.Checked.ToString();
				Properties.Settings.Default.CBC_256_En = CTR_256_En;
	

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