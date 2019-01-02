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
	public partial class ApprovedRNG : Form
	{
		public static string AppRNGFunc;

		public ApprovedRNG()
		{
			InitializeComponent();
			AppRNGFunc = Properties.Settings.Default.AppRNGFunc.ToString();
		}

		private void ApprovedRNG_Load(object sender, EventArgs e)
		{
			AppRNGFunc = Properties.Settings.Default.AppRNGFunc.ToString();
			textBox_AppRNGFunction.Text = AppRNGFunc;
		}

		private void ApprovedRNG_FormClosed(object sender, FormClosedEventArgs e)
		{
			KeyManagement.AppRNGFunc = textBox_AppRNGFunction.Text;
			AppRNGFunc = textBox_AppRNGFunction.Text;

			Properties.Settings.Default.AppRNGFunc = AppRNGFunc;
			Properties.Settings.Default.Save();

			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();
		}
	}
}