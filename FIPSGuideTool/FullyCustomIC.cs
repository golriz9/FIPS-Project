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
	public partial class FullyCustomIC : Form
	{
		public static string TE010802_FullCustomIC;
		public FullyCustomIC()
		{
			InitializeComponent();
			TE010802_FullCustomIC = Properties.Settings.Default.TE010802_FullCustomIC.ToString();

		}

		private void FullyCustomIC_FormClosed(object sender, FormClosedEventArgs e)
		{
			//ModuleSpecs.TE010802_FullCustomIC = txtBox_FullyCustomIC.Text;
			//TE010802_FullCustomIC = txtBox_FullyCustomIC.Text;

			//Properties.Settings.Default.TE010802_FullCustomIC = txtBox_FullyCustomIC.Text;
			//Properties.Settings.Default.Save();

			//SpecificationsAssertions f1 = new SpecificationsAssertions();
			//f1.populateSpecLevel1234();
		}

		private void FullyCustomIC_Load(object sender, EventArgs e)
		{
			TE010802_FullCustomIC = Properties.Settings.Default.TE010802_FullCustomIC.ToString();
			txtBox_FullyCustomIC.Text = TE010802_FullCustomIC;

		}

		private void FullyCustomIC_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				ModuleSpecs.TE010802_FullCustomIC = txtBox_FullyCustomIC.Text;
				TE010802_FullCustomIC = txtBox_FullyCustomIC.Text;

				Properties.Settings.Default.TE010802_FullCustomIC = txtBox_FullyCustomIC.Text;
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

