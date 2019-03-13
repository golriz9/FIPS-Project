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
	public partial class PwrSupply : Form
	{
		public static string TE010802_pwr;

		public PwrSupply()
		{
			InitializeComponent();

			TE010802_pwr = Properties.Settings.Default.TE010802_pwr.ToString();
		}

		private void PwrSupply_FormClosed(object sender, FormClosedEventArgs e)
		{
			//ModuleSpecs.TE010802_pwr = txtBox_PwrSupply.Text;
			//TE010802_pwr            = txtBox_PwrSupply.Text;

			//Properties.Settings.Default.TE010802_pwr = TE010802_pwr;
			//Properties.Settings.Default.Save();

			//SpecificationsAssertions f1 = new SpecificationsAssertions();
			//f1.populateSpecLevel1234();
		}

		private void PwrSupply_Load(object sender, EventArgs e)
		{
			TE010802_pwr          = Properties.Settings.Default.TE010802_pwr.ToString();
			txtBox_PwrSupply.Text = TE010802_pwr;
		}

		private void PwrSupply_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				ModuleSpecs.TE010802_pwr = txtBox_PwrSupply.Text;
				TE010802_pwr = txtBox_PwrSupply.Text;

				Properties.Settings.Default.TE010802_pwr = TE010802_pwr;
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
