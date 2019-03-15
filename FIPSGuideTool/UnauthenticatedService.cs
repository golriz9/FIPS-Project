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
	public partial class UnauthenticatedService : Form
	{
		public static string UnauthorizedServices;

		public UnauthenticatedService()
		{
			InitializeComponent();
			UnauthorizedServices = Properties.Settings.Default.UnauthorizedServices.ToString();
		}

		private void UnauthenticatedService_Load(object sender, EventArgs e)
		{
			UnauthorizedServices = Properties.Settings.Default.UnauthorizedServices.ToString();
			txtBox_UnauthenticatedServices.Text = UnauthorizedServices;
		}

		private void UnauthenticatedService_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		private void UnauthenticatedService_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				RolesAndServices.UnauthorizedServices = txtBox_UnauthenticatedServices.Text;
				UnauthorizedServices = txtBox_UnauthenticatedServices.Text;
				Properties.Settings.Default.UnauthorizedServices = UnauthorizedServices;
				Properties.Settings.Default.Save();
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



