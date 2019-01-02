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
	public partial class KeyGenSec : Form
	{
		public static string KeyGenSecurity;

		public KeyGenSec()
		{
			InitializeComponent();
			KeyGenSecurity = Properties.Settings.Default.KeyGenSecurity.ToString();
		}

		private void KeyGenSec_Load(object sender, EventArgs e)
		{
			KeyGenSecurity = Properties.Settings.Default.KeyGenSecurity.ToString();
			textBox_KeyGenSecurity.Text = KeyGenSecurity;
		}

		private void KeyGenSec_FormClosed(object sender, FormClosedEventArgs e)
		{
			KeyManagement.KeyGenSecurity = textBox_KeyGenSecurity.Text;
			KeyGenSecurity = textBox_KeyGenSecurity.Text;

			Properties.Settings.Default.KeyGenSecurity = KeyGenSecurity;
			Properties.Settings.Default.Save();

			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();
		}
	}
}