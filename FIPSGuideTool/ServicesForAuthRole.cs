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
	public partial class ServicesForAuthRole : Form
	{
		public static string ServicesListForAuthRole;

		public ServicesForAuthRole()
		{
			InitializeComponent();
			ServicesListForAuthRole = Properties.Settings.Default.ServicesListForAuthRole.ToString();
		}

		private void ServicesForAuthRole_Load(object sender, EventArgs e)
		{
			ServicesListForAuthRole = Properties.Settings.Default.ServicesListForAuthRole.ToString();
			txtBox_ServicesListForAuthRole.Text = ServicesListForAuthRole;
		}

		private void ServicesForAuthRole_FormClosed(object sender, FormClosedEventArgs e)
		{
					
		}

		private void ServicesForAuthRole_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				RolesAndServices.ServicesListForAuthRole = txtBox_ServicesListForAuthRole.Text;
				ServicesListForAuthRole = txtBox_ServicesListForAuthRole.Text;
				Properties.Settings.Default.ServicesListForAuthRole = ServicesListForAuthRole;
				Properties.Settings.Default.Save();

				//SpecificationsAssertions f1 = new SpecificationsAssertions();
				//f1.populateSpecLevel1234();
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
