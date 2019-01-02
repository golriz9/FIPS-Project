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
	public partial class PwrInputPorts : Form
	{
		public static string PwrIn;
		public static string TE020901_1;
		public static string TE020901_2;

		public PwrInputPorts()
		{
			InitializeComponent();

			PwrIn = Properties.Settings.Default.PwrIn.ToString();
			TE020901_1 = Properties.Settings.Default.TE020901_1.ToString();
			TE020901_2 = Properties.Settings.Default.TE020901_2.ToString();

		}

		private void PwrInputPorts_Load(object sender, EventArgs e)
		{
			txt_PwrIn.Text = PwrIn;
			
			if (TE020901_1 == "True")
			{
				checkBox1.Checked = true;
			}

			if (TE020901_2 == "True")
			{
				checkBox2.Checked = true;
			}		
		}

		private void PwrInputPorts_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				PwrIn = txt_PwrIn.Text;
				Properties.Settings.Default.PwrIn = PwrIn;

				TE020901_1 = checkBox1.Checked.ToString();
				Properties.Settings.Default.TE020901_1 = TE020901_1;

				TE020901_2 = checkBox2.Checked.ToString();
				Properties.Settings.Default.TE020901_2 = TE020901_2;
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