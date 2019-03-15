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
	public partial class PubKeyProtection : Form
	{
		public static string PubKeyProtect;

		public PubKeyProtection()
		{
			InitializeComponent();
			PubKeyProtect = Properties.Settings.Default.PubKeyProtect.ToString();
		}

		private void PubKeyProtection_Load(object sender, EventArgs e)
		{
			PubKeyProtect = Properties.Settings.Default.PubKeyProtect.ToString();
			txtBox_PubKeyProtect.Text = PubKeyProtect;
		}

		private void PubKeyProtection_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		private void PubKeyProtection_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				PubKeyProtect = txtBox_PubKeyProtect.Text;
				KeyManagement.PubKeyProtect = txtBox_PubKeyProtect.Text;

				Properties.Settings.Default.PubKeyProtect = PubKeyProtect;
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