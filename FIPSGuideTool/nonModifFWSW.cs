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
	public partial class nonModifFWSW : Form
	{
		public static string TE010802_NonMod_FWSW;
		public nonModifFWSW()
		{
			InitializeComponent();

			TE010802_NonMod_FWSW = Properties.Settings.Default.TE010802_NonMod_FWSW.ToString();
		}

		private void nonModifFWSW_FormClosed(object sender, FormClosedEventArgs e)
		{
			//ModuleSpecs.TE010802_NonMod_FWSW = txtBox_nonModFWSW.Text;
			//TE010802_NonMod_FWSW            = txtBox_nonModFWSW.Text;

			//Properties.Settings.Default.TE010802_NonMod_FWSW = TE010802_NonMod_FWSW;
			//Properties.Settings.Default.Save();

			//SpecificationsAssertions f1 = new SpecificationsAssertions();
			//f1.populateSpecLevel1234();
		}

		private void nonModifFWSW_Load(object sender, EventArgs e)
		{
			TE010802_NonMod_FWSW = Properties.Settings.Default.TE010802_NonMod_FWSW.ToString();
			txtBox_nonModFWSW.Text = TE010802_NonMod_FWSW;
		}

		private void nonModifFWSW_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				ModuleSpecs.TE010802_NonMod_FWSW = txtBox_nonModFWSW.Text;
				TE010802_NonMod_FWSW = txtBox_nonModFWSW.Text;

				Properties.Settings.Default.TE010802_NonMod_FWSW = TE010802_NonMod_FWSW;
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
