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
	public partial class MajorStates : Form
	{
		public static string TE040508_MajorStates;

		public MajorStates()
		{
			InitializeComponent();
			TE040508_MajorStates = Properties.Settings.Default.TE040508_MajorStates.ToString();
		}

		private void MajorStates_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				TE040508_MajorStates = MjrStates.Text;

				Properties.Settings.Default.TE040508_MajorStates = TE040508_MajorStates;
				Properties.Settings.Default.Save();

				FSMAssertions f1 = new FSMAssertions();
				f1.populateFSMLevel1234();
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

		private void MajorStates_Load(object sender, EventArgs e)
		{
			TE040508_MajorStates = Properties.Settings.Default.TE040508_MajorStates.ToString();
			MjrStates.Text = TE040508_MajorStates;
		}
	}
}