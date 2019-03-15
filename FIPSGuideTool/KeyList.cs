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
	public partial class KeyList : Form
	{
		public static string CryptKeyList;

		public KeyList()
		{
			InitializeComponent();
			CryptKeyList = Properties.Settings.Default.CryptKeyList.ToString();
		}

		private void KeyList_Load(object sender, EventArgs e)
		{
			CryptKeyList = Properties.Settings.Default.CryptKeyList.ToString();
			textBox_KeyList.Text = CryptKeyList;
		}

		private void KeyList_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		private void KeyList_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				CryptKeyList = textBox_KeyList.Text;
				KeyManagement.CryptKeyList = textBox_KeyList.Text;

				Properties.Settings.Default.CryptKeyList = CryptKeyList;
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