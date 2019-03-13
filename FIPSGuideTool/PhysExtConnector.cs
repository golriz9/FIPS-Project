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
	public partial class PhysExtConnector : Form
	{
		public static string TE010802_phyExtConnect;

		public PhysExtConnector()
		{
			InitializeComponent();

			TE010802_phyExtConnect = Properties.Settings.Default.TE010802_phyExtConnect.ToString();
		}

		private void PhysExtConnector_FormClosed(object sender, FormClosedEventArgs e)
		{
			//ModuleSpecs.TE010802_phyExtConnect = txtBox_PhysExtConnector.Text;
			//TE010802_phyExtConnect            = txtBox_PhysExtConnector.Text;
			
			//Properties.Settings.Default.TE010802_phyExtConnect = TE010802_phyExtConnect;
			//Properties.Settings.Default.Save();

			//SpecificationsAssertions f1 = new SpecificationsAssertions();
			//f1.populateSpecLevel1234();
		}

		private void PhysExtConnector_Load(object sender, EventArgs e)
		{
			TE010802_phyExtConnect = Properties.Settings.Default.TE010802_phyExtConnect.ToString();
			txtBox_PhysExtConnector.Text = TE010802_phyExtConnect;
		}

		private void PhysExtConnector_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				ModuleSpecs.TE010802_phyExtConnect = txtBox_PhysExtConnector.Text;
				TE010802_phyExtConnect = txtBox_PhysExtConnector.Text;

				Properties.Settings.Default.TE010802_phyExtConnect = TE010802_phyExtConnect;
				Properties.Settings.Default.Save();

				SpecificationsAssertions f1 = new SpecificationsAssertions();
				f1.populateSpecLevel1234();
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
