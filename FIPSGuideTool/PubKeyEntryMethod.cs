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
	public partial class PubKeyEntryMethod : Form
	{
		public static string PubKeyEntry;

		public PubKeyEntryMethod()
		{
			InitializeComponent();
			PubKeyEntry = Properties.Settings.Default.PubKeyEntry.ToString();
		}

		private void PubKeyEntryMethod_Load(object sender, EventArgs e)
		{
			PubKeyEntry = Properties.Settings.Default.PubKeyEntry.ToString();
			txtBox_PubKeyEntryMethod.Text = PubKeyEntry;
		}

		private void PubKeyEntryMethod_FormClosed(object sender, FormClosedEventArgs e)
		{
			PubKeyEntry = txtBox_PubKeyEntryMethod.Text;
			KeyManagement.PubKeyEntry = txtBox_PubKeyEntryMethod.Text;

			Properties.Settings.Default.PubKeyEntry = PubKeyEntry;
			Properties.Settings.Default.Save();

			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();

		}
	}
}