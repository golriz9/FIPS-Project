﻿using System;
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
	public partial class FWVersion : Form
	{
		public static string FWSVersion;

		public FWVersion()
		{
			InitializeComponent();

			FWSVersion = Properties.Settings.Default.FWSVersion.ToString();
		}

		private void FWVersion_FormClosed(object sender, FormClosedEventArgs e)
		{
			//ModuleSpecs.FWSVersion = txtBox_FWSVersion.Text;
			//FWSVersion            = txtBox_FWSVersion.Text;

			//Properties.Settings.Default.FWSVersion = FWSVersion;
			//Properties.Settings.Default.Save();

			//SpecificationsAssertions f1 = new SpecificationsAssertions();
			//f1.populateSpecLevel1234();
		}

		private void FWVersion_Load(object sender, EventArgs e)
		{
			FWSVersion             = Properties.Settings.Default.FWSVersion.ToString();
			txtBox_FWSVersion.Text = FWSVersion;
		}

		private void FWVersion_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				ModuleSpecs.FWSVersion = txtBox_FWSVersion.Text;
				FWSVersion = txtBox_FWSVersion.Text;

				Properties.Settings.Default.FWSVersion = FWSVersion;
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
