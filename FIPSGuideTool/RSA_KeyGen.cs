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
	public partial class RSA_KeyGen : Form
	{
		public static string RSA_KG_186_4;
		public static string RSA_KG_186_2;

		public RSA_KeyGen()
		{
			InitializeComponent();

			RSA_KG_186_4 = Properties.Settings.Default.RSA_KG_186_4.ToString();
			RSA_KG_186_2 = Properties.Settings.Default.RSA_KG_186_2.ToString();

			if (RSA_KG_186_4 == "True")
			{
				checkBox1.Checked = true;
			}

			if (RSA_KG_186_2 == "True")
			{
				checkBox2.Checked = true;
			}
		}

		private void RSA_KeyGen_Load(object sender, EventArgs e)
		{

		}

		private void RSA_KeyGen_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				RSA_KG_186_4 = checkBox1.Checked.ToString();
				Properties.Settings.Default.RSA_KG_186_4 = RSA_KG_186_4;

				RSA_KG_186_2 = checkBox2.Checked.ToString();
				Properties.Settings.Default.RSA_KG_186_2 = RSA_KG_186_2;

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
			}
		}
	}
}