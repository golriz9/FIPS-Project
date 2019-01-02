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
	public partial class RSA_ComponentTest : Form
	{
		public static string RSA_CompTest;
		public RSA_ComponentTest()
		{
			InitializeComponent();

			RSA_CompTest = Properties.Settings.Default.RSA_CompTest.ToString();

			if (RSA_CompTest == "True")
			{
				checkBox27.Checked = true;
			}
		}

		private void RSA_ComponentTest_Load(object sender, EventArgs e)
		{

		}

		private void RSA_ComponentTest_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				RSA_CompTest = checkBox27.Checked.ToString();
				Properties.Settings.Default.RSA_CompTest = RSA_CompTest;


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