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
	public partial class KASFFC : Form
	{
		public static string dhHybrid1;
		public static string dhHybridOneFlow;
		public static string MQV1;
		public static string MQV2;
		public static string dhEphem;
		public static string dhOneFlow;
		public static string dhStatic;

		public KASFFC()
		{
			InitializeComponent();

			dhHybrid1       = Properties.Settings.Default.dhHybrid1.ToString();
			dhHybridOneFlow = Properties.Settings.Default.dhHybridOneFlow.ToString();
			MQV1            = Properties.Settings.Default.MQV1.ToString();
			MQV2            = Properties.Settings.Default.MQV2.ToString();
			dhEphem         = Properties.Settings.Default.dhEphem.ToString();
			dhOneFlow       = Properties.Settings.Default.dhOneFlow.ToString();
			dhStatic        = Properties.Settings.Default.dhStatic.ToString();

			if (dhHybrid1 == "True")
			{
				checkBox1.Checked = true;
			}

			if (MQV2 == "True")
			{
				checkBox2.Checked = true;
			}

			if (dhEphem == "True")
			{
				checkBox3.Checked = true;
			}

			if (dhHybridOneFlow == "True")
			{
				checkBox4.Checked = true;
			}

			if (MQV1 == "True")
			{
				checkBox5.Checked = true;
			}

			if (dhOneFlow == "True")
			{
				checkBox6.Checked = true;
			}

			if (dhStatic == "True")
			{
				checkBox7.Checked = true;
			}

		}

		private void KASFFC_Load(object sender, EventArgs e)
		{

		}

		private void KASFFC_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				dhHybrid1 = checkBox1.Checked.ToString();
				Properties.Settings.Default.dhHybrid1 = dhHybrid1;

				MQV2 = checkBox2.Checked.ToString();
				Properties.Settings.Default.MQV2 = MQV2;

				dhEphem = checkBox3.Checked.ToString();
				Properties.Settings.Default.dhEphem = dhEphem;

				dhHybridOneFlow = checkBox4.Checked.ToString();
				Properties.Settings.Default.dhHybridOneFlow = dhHybridOneFlow;

				MQV1 = checkBox5.Checked.ToString();
				Properties.Settings.Default.MQV1 = MQV1;

				dhOneFlow = checkBox6.Checked.ToString();
				Properties.Settings.Default.dhOneFlow = dhOneFlow;

				dhStatic = checkBox7.Checked.ToString();
				Properties.Settings.Default.dhStatic = dhStatic;
				Properties.Settings.Default.Save();

				e.Cancel = false;
			}
			else if (result == DialogResult.No)
			{
				e.Cancel = false;
			}
			else if (result == DialogResult.Cancel)
			{
				e.Cancel = true;

				//e.Cancel = (result == DialogResult.No);
			}
		}
	}
}