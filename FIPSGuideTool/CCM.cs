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
	public partial class CCM : Form
	{
		public static string CCM_128;
		public static string CCM_192;
		public static string CCM_256;

		public CCM()
		{
			InitializeComponent();

			CCM_128 = Properties.Settings.Default.CCM_128.ToString();
			CCM_192 = Properties.Settings.Default.CCM_192.ToString();
			CCM_256 = Properties.Settings.Default.CCM_256.ToString();

			if (CCM_128 == "True")
			{
				checkBox1.Checked = true;
			}

			if (CCM_192 == "True")
			{
				checkBox2.Checked = true;
			}

			if (CCM_256 == "True")
			{
				checkBox3.Checked = true;
			}
		}

		private void CCM_Load(object sender, EventArgs e)
		{

		}

		private void CCM_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				CCM_128 = checkBox1.Checked.ToString();
				Properties.Settings.Default.CCM_128 = CCM_128;

				CCM_192 = checkBox2.Checked.ToString();
				Properties.Settings.Default.CCM_192 = CCM_192;

				CCM_256 = checkBox3.Checked.ToString();
				Properties.Settings.Default.CCM_256 = CCM_256;

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