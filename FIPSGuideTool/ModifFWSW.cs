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
	public partial class ModifFWSW : Form
	{
		public static string TE010802_ModFWSW;

		public ModifFWSW()
		{
			InitializeComponent();

			TE010802_ModFWSW = Properties.Settings.Default.TE010802_ModFWSW.ToString();
		}

		private void ModifFWSW_FormClosed(object sender, FormClosedEventArgs e)
		{
			//ModuleSpecs.TE010802_ModFWSW = txtBox_ModFWSW.Text;
			//TE010802_ModFWSW = txtBox_ModFWSW.Text;			

			//Properties.Settings.Default.TE010802_ModFWSW = TE010802_ModFWSW;
			//Properties.Settings.Default.Save();

			//SpecificationsAssertions f1 = new SpecificationsAssertions();
			//f1.populateSpecLevel1234();
		}

		private void txtBox_ModFWSW_TextChanged(object sender, EventArgs e)
		{

		}

		private void ModifFWSW_Load(object sender, EventArgs e)
		{
			TE010802_ModFWSW = Properties.Settings.Default.TE010802_ModFWSW.ToString();
			txtBox_ModFWSW.Text = TE010802_ModFWSW;
		}

		private void ModifFWSW_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				ModuleSpecs.TE010802_ModFWSW = txtBox_ModFWSW.Text;
				TE010802_ModFWSW = txtBox_ModFWSW.Text;

				Properties.Settings.Default.TE010802_ModFWSW = TE010802_ModFWSW;
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
