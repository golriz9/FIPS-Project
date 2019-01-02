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
	public partial class KeyProtStratg : Form
	{
		public static string CSPProtcStratg;

		public KeyProtStratg()
		{
			InitializeComponent();

			CSPProtcStratg = Properties.Settings.Default.CSPProtcStratg.ToString();
		}

		private void KeyProtStratg_Load(object sender, EventArgs e)
		{
			CSPProtcStratg = Properties.Settings.Default.CSPProtcStratg.ToString();
			txtBox_CSPProtcStratg.Text = CSPProtcStratg;
		}

		private void KeyProtStratg_FormClosing(object sender, FormClosingEventArgs e)
		{
			
		}

		private void KeyProtStratg_FormClosed(object sender, FormClosedEventArgs e)
		{
			KeyManagement.CSPProtcStratg = txtBox_CSPProtcStratg.Text;
			CSPProtcStratg = txtBox_CSPProtcStratg.Text;
		
			Properties.Settings.Default.CSPProtcStratg = CSPProtcStratg;
			Properties.Settings.Default.Save();

			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();
		}
	}
}