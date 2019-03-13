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
	public partial class ROMFlash : Form
	{
		public static string TE010802_ROM;


		public ROMFlash()
		{
			InitializeComponent();

			TE010802_ROM = Properties.Settings.Default.TE010802_ROM.ToString();
		}

		private void ROMFlash_Load(object sender, EventArgs e)
		{
			TE010802_ROM = Properties.Settings.Default.TE010802_ROM.ToString();
			txtBox_ROMFlash.Text = TE010802_ROM;
		}

		private void ROMFlash_FormClosed(object sender, FormClosedEventArgs e)
		{
			//ModuleSpecs.TE010802_ROM = txtBox_ROMFlash.Text;
			//TE010802_ROM            = txtBox_ROMFlash.Text;			

			//Properties.Settings.Default.TE010802_ROM = TE010802_ROM;
			//Properties.Settings.Default.Save();

			//SpecificationsAssertions f1 = new SpecificationsAssertions();
			//f1.populateSpecLevel1234();
		}

		private void ROMFlash_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				ModuleSpecs.TE010802_ROM = txtBox_ROMFlash.Text;
				TE010802_ROM = txtBox_ROMFlash.Text;

				Properties.Settings.Default.TE010802_ROM = TE010802_ROM;
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