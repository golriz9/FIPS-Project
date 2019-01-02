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
	public partial class StatusOutputPorts : Form
	{
		public static string StatusOut;
		public static string TE020801_1;
		public static string TE020801_2;
		public static string TE020801_3;


		public StatusOutputPorts()
		{
			InitializeComponent();

			StatusOut = Properties.Settings.Default.StatusOut.ToString();
			TE020801_1 = Properties.Settings.Default.TE020801_1.ToString();
			TE020801_2 = Properties.Settings.Default.TE020801_2.ToString();
			TE020801_3 = Properties.Settings.Default.TE020801_3.ToString();
		}

		private void StatusOutputPorts_Load(object sender, EventArgs e)
		{
			txt_StatusOut.Text = StatusOut;
			if (TE020801_1 == "True")
			{
				checkBox1.Checked = true;
			}

			if (TE020801_2 == "True")
			{
				checkBox2.Checked = true;
			}

			if (TE020801_3 == "True")
			{
				checkBox3.Checked = true;
			}			

		}

		private void StatusOutputPorts_FormClosing(object sender, FormClosingEventArgs e)
		{			
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				StatusOut = txt_StatusOut.Text;
				Properties.Settings.Default.StatusOut = StatusOut;

				TE020801_1 = checkBox1.Checked.ToString();
				Properties.Settings.Default.TE020801_1 = TE020801_1;

				TE020801_2 = checkBox2.Checked.ToString();
				Properties.Settings.Default.TE020801_2 = TE020801_2;

				TE020801_3 = checkBox3.Checked.ToString();
				Properties.Settings.Default.TE020801_3 = TE020801_3;
				Properties.Settings.Default.Save();

				//PortsInterfacesAssertions f1 = new PortsInterfacesAssertions();
				//f1.populatePortInterfaceLevel1234();
				//f1.populatePortInterfaceLevel34();
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