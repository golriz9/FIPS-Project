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
	public partial class CtrlInputPorts : Form
	{
		public static string CtrlIn;
		public static string TE020701_1;
		public static string TE020701_2;
		public static string TE020701_3;
		public static string ExtCtrlDevice;
		public static string ExtCtrlYesNo;

		public CtrlInputPorts()
		{
			InitializeComponent();
			label4.Visible = false;
			txt_ExtCtrlDevice.Visible = false;

			CtrlIn        = Properties.Settings.Default.CtrlIn.ToString();
			TE020701_1    = Properties.Settings.Default.TE020701_1.ToString();
			TE020701_2    = Properties.Settings.Default.TE020701_2.ToString();
			TE020701_3    = Properties.Settings.Default.TE020701_3.ToString();
			ExtCtrlDevice = Properties.Settings.Default.ExtCtrlDevice;
			ExtCtrlYesNo  = Properties.Settings.Default.ExtCtrlYesNo;

		}

		private void CtrlInputPorts_Load(object sender, EventArgs e)
		{
			comboBox1.SelectedItem = ExtCtrlYesNo;
			txt_CtrlIn.Text = CtrlIn;
			txt_ExtCtrlDevice.Text = ExtCtrlDevice;

			if (TE020701_1 == "True")
			{
				checkBox1.Checked = true;
			}

			if (TE020701_2 == "True")
			{
				checkBox2.Checked = true;
			}

			if (TE020701_3 == "True")
			{
				checkBox3.Checked = true;
			}		
		}

		private void CtrlInputPorts_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				CtrlIn = txt_CtrlIn.Text;
				Properties.Settings.Default.CtrlIn = CtrlIn;

				TE020701_1 = checkBox1.Checked.ToString();
				Properties.Settings.Default.TE020701_1 = TE020701_1;

				TE020701_2 = checkBox2.Checked.ToString();
				Properties.Settings.Default.TE020701_2 = TE020701_2;

				TE020701_3 = checkBox3.Checked.ToString();
				Properties.Settings.Default.TE020701_3 = TE020701_3;

				ExtCtrlDevice = txt_ExtCtrlDevice.Text;
				Properties.Settings.Default.ExtCtrlDevice = ExtCtrlDevice;

				ExtCtrlYesNo = comboBox1.SelectedItem.ToString();
				Properties.Settings.Default.ExtCtrlYesNo = ExtCtrlYesNo;
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

		//private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//	if (comboBox1.SelectedItem.ToString() == "Yes")
		//	{
		//		label4.Visible = true;
		//		txt_ExtCtrlDevice.Visible = true;
		//		txt_ExtCtrlDevice.Text = "";
		//	}
		//	else
		//	{
		//		label4.Visible = false;
		//		txt_ExtCtrlDevice.Visible = false;

		//		txt_ExtCtrlDevice.Text = "N/A";
		//	}
		//}

		private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem.ToString() == "Yes")
			{
				label4.Visible = true;
				txt_ExtCtrlDevice.Visible = true;
				txt_ExtCtrlDevice.Text = "";
			}
			else
			{
				label4.Visible = false;
				txt_ExtCtrlDevice.Visible = false;

				txt_ExtCtrlDevice.Text = "N/A";
			}
		}
	}
}