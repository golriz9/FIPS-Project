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
	public partial class Seed_SeedKey : Form
	{
		public static string SeedLength;
		public static string SeedKeyLength;

		public Seed_SeedKey()
		{
			InitializeComponent();

			SeedLength    = Properties.Settings.Default.SeedLength.ToString();
			textBox_Seed.Text = SeedLength;
			SeedKeyLength = Properties.Settings.Default.SeedKeyLength.ToString();
			textBox_SeedKey.Text = SeedKeyLength;
		}

		private void Seed_SeedKey_Load(object sender, EventArgs e)
		{
			SeedLength           = Properties.Settings.Default.SeedLength.ToString();
			SeedKeyLength        = Properties.Settings.Default.SeedKeyLength.ToString();
			textBox_Seed.Text    = SeedLength;
			textBox_SeedKey.Text = SeedKeyLength;
		}

		private void Seed_SeedKey_FormClosed(object sender, FormClosedEventArgs e)
		{
			KeyManagement.SeedLength    = textBox_Seed.Text;
			SeedLength                  = textBox_Seed.Text;
			KeyManagement.SeedKeyLength = textBox_SeedKey.Text;
			SeedKeyLength                  = textBox_SeedKey.Text;

			Properties.Settings.Default.SeedLength      = SeedLength;
			Properties.Settings.Default.SeedKeyLength   = SeedKeyLength;
			Properties.Settings.Default.Save();

			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();
		}
	}
}