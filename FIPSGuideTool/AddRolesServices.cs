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
	public partial class AddRolesServices : Form
	{
		public static string RolesAndServicesList;
	
		

		public AddRolesServices()
		{
			InitializeComponent();
			RolesAndServicesList = Properties.Settings.Default.RolesAndServicesList.ToString();
		}

		private void AddRolesServices_Load(object sender, EventArgs e)
		{
			RolesAndServicesList = Properties.Settings.Default.RolesAndServicesList.ToString();
			txtBox_RolesServicesList.Text = RolesAndServicesList;
		}

		private void AddRolesServices_FormClosed(object sender, FormClosedEventArgs e)
		{
			RolesAndServices.RolesAndServicesList = txtBox_RolesServicesList.Text;
			RolesAndServicesList = txtBox_RolesServicesList.Text;
			Properties.Settings.Default.RolesAndServicesList = RolesAndServicesList;
			Properties.Settings.Default.Save();	

			//SpecificationsAssertions f1 = new SpecificationsAssertions();
			//f1.populateSpecLevel1234();
		}

		private void AddRolesServices_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				RolesAndServices.RolesAndServicesList = txtBox_RolesServicesList.Text;
				RolesAndServicesList = txtBox_RolesServicesList.Text;
				Properties.Settings.Default.RolesAndServicesList = RolesAndServicesList;
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