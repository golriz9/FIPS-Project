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
	public partial class KeyEstabSec : Form
	{
		public static string KeyEstabSecurity;

		public KeyEstabSec()
		{
			InitializeComponent();
			KeyEstabSecurity = Properties.Settings.Default.KeyEstabSecurity.ToString();
		}

		private void KeyEstabSec_Load(object sender, EventArgs e)
		{
			KeyEstabSecurity = Properties.Settings.Default.KeyEstabSecurity.ToString();
			textBox_KeyEstabSecurity.Text = KeyEstabSecurity;
		}

		private void KeyEstabSec_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		private void KeyEstabSec_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				KeyManagement.KeyEstabSecurity = textBox_KeyEstabSecurity.Text;
				KeyEstabSecurity = textBox_KeyEstabSecurity.Text;

				Properties.Settings.Default.KeyEstabSecurity = KeyEstabSecurity;
				Properties.Settings.Default.Save();

				KeyManagementAssertions f1 = new KeyManagementAssertions();
				f1.populateKeyManagementLevel1234();
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