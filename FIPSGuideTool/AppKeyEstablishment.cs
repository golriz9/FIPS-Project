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
	public partial class AppKeyEstablishment : Form
	{
		public static string AppKeyEstab;

		public AppKeyEstablishment()
		{
			InitializeComponent();
			AppKeyEstab = Properties.Settings.Default.AppKeyEstab.ToString();
		}

		private void AppKeyEstablishment_Load(object sender, EventArgs e)
		{
			AppKeyEstab = Properties.Settings.Default.AppKeyEstab.ToString();
			textBox_AppKeyEstab.Text = AppKeyEstab;
		}

		private void AppKeyEstablishment_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		private void AppKeyEstablishment_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				KeyManagement.AppKeyEstab = textBox_AppKeyEstab.Text;
				AppKeyEstab = textBox_AppKeyEstab.Text;

				Properties.Settings.Default.AppKeyEstab = AppKeyEstab;
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