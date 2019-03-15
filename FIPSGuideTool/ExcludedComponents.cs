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
	public partial class ExcludedComponents : Form
	{
		public static string TE010808_excld;

		public ExcludedComponents()
		{
			InitializeComponent();
			TE010808_excld = Properties.Settings.Default.TE010808_excld.ToString();
		}

		private void ExcludedComponents_Load(object sender, EventArgs e)
		{
			TE010808_excld = Properties.Settings.Default.TE010808_excld.ToString();
			txtBox_ExComp.Text = TE010808_excld;
		}

		private void ExcludedComponents_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				ModuleSpecs.TE010808_excld = txtBox_ExComp.Text;
				TE010808_excld = txtBox_ExComp.Text;

				Properties.Settings.Default.TE010808_excld = TE010808_excld;
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