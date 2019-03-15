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
	public partial class nonApprovedRNG : Form
	{
		public static string nonAppRNGFunc;

		public nonApprovedRNG()
		{
			InitializeComponent();
			nonAppRNGFunc = Properties.Settings.Default.nonAppRNGFunc.ToString();
		}

		private void nonApprovedRNG_Load(object sender, EventArgs e)
		{
			nonAppRNGFunc = Properties.Settings.Default.nonAppRNGFunc.ToString();
			textBox_nonAppRNGFunc.Text = nonAppRNGFunc;
		}

		private void nonApprovedRNG_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		private void nonApprovedRNG_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				KeyManagement.nonAppRNGFunc = textBox_nonAppRNGFunc.Text;
				nonAppRNGFunc = textBox_nonAppRNGFunc.Text;

				Properties.Settings.Default.nonAppRNGFunc = nonAppRNGFunc;
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