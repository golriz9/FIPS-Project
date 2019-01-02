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
	public partial class DSA_KeyPair : Form
	{
		public static string KeyPairL2048_N224;
		public static string KeyPairL2048_N256;
		public static string KeyPairL3072_N256;

		public DSA_KeyPair()
		{
			InitializeComponent();

			KeyPairL2048_N224 = Properties.Settings.Default.KeyPairL2048_N224.ToString();
			KeyPairL2048_N256 = Properties.Settings.Default.KeyPairL2048_N256.ToString();
			KeyPairL3072_N256 = Properties.Settings.Default.KeyPairL3072_N256.ToString();

			if (KeyPairL2048_N224 == "True")
			{
				checkBox1.Checked = true;
			}

			if (KeyPairL2048_N256 == "True")
			{
				checkBox2.Checked = true;
			}

			if (KeyPairL3072_N256 == "True")
			{
				checkBox3.Checked = true;
			}



		}

		private void DSA_KeyPair_Load(object sender, EventArgs e)
		{

		}

		private void DSA_KeyPair_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				KeyPairL2048_N224 = checkBox1.Checked.ToString();
				Properties.Settings.Default.KeyPairL2048_N224 = KeyPairL2048_N224;

				KeyPairL2048_N256 = checkBox2.Checked.ToString();
				Properties.Settings.Default.KeyPairL2048_N256 = KeyPairL2048_N256;

				KeyPairL3072_N256 = checkBox3.Checked.ToString();
				Properties.Settings.Default.KeyPairL3072_N256 = KeyPairL3072_N256;
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