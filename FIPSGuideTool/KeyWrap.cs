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
	public partial class KeyWrap : Form
	{
		public static string AES_KW;
		public static string AES_KWP;
		public static string TDEA_KW;

		public KeyWrap()
		{
			InitializeComponent();

			AES_KW = Properties.Settings.Default.AES_KW.ToString();
			AES_KWP = Properties.Settings.Default.AES_KWP.ToString();
			TDEA_KW = Properties.Settings.Default.TDEA_KW.ToString();

			if (AES_KW == "True")
			{
				checkBox1.Checked = true;
			}

			if (AES_KWP == "True")
			{
				checkBox2.Checked = true;
			}

			if (TDEA_KW == "True")
			{
				checkBox3.Checked = true;
			}
		}

		private void KeyWrap_Load(object sender, EventArgs e)
		{

		}

		private void KeyWrap_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				AES_KW = checkBox1.Checked.ToString();
				Properties.Settings.Default.AES_KW = AES_KW;

				AES_KWP = checkBox2.Checked.ToString();
				Properties.Settings.Default.AES_KWP = AES_KWP;

				TDEA_KW = checkBox3.Checked.ToString();
				Properties.Settings.Default.TDEA_KW = TDEA_KW;

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