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
	public partial class DataOutputPorts : Form
	{
		public static string DataOut;
		public static string TE020501_1;
		public static string TE020501_2;
		public static string TE020501_3;
		public static string TE020501_4;
		public static string ExtOutputDevice;
		public static string ExtOutputYesNo;

		public DataOutputPorts()
		{
			InitializeComponent();
			label4.Visible = false;
			txt_ExtOutputDevice.Visible = false;
			
			DataOut = Properties.Settings.Default.DataOut.ToString();
			ExtOutputDevice = Properties.Settings.Default.ExtOutputDevice.ToString();
			TE020501_1 = Properties.Settings.Default.TE020501_1.ToString();
			TE020501_2 = Properties.Settings.Default.TE020501_2.ToString();
			TE020501_3 = Properties.Settings.Default.TE020501_3.ToString();
			TE020501_4 = Properties.Settings.Default.TE020501_4.ToString();
			ExtOutputYesNo = Properties.Settings.Default.ExtOutputYesNo;

		}

		private void DataOutputPorts_Load(object sender, EventArgs e)
		{ 
			comboBox1.SelectedItem = ExtOutputYesNo;
			txt_DataOut.Text = DataOut;
			txt_ExtOutputDevice.Text = ExtOutputDevice;
			if (TE020501_1 == "True")
			{
				checkBox1.Checked = true;
			}

			if (TE020501_2 == "True")
			{
				checkBox2.Checked = true;
			}

			if (TE020501_3 == "True")
			{
				checkBox3.Checked = true;
			}

			if (TE020501_4 == "True")
			{
				checkBox4.Checked = true;
			}
					
		}

		private void DataOutputPorts_FormClosing(object sender, FormClosingEventArgs e)
		{			
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				DataOut = txt_DataOut.Text;
				Properties.Settings.Default.DataOut = DataOut;

				TE020501_1 = checkBox1.Checked.ToString();
				Properties.Settings.Default.TE020501_1 = TE020501_1;

				TE020501_2 = checkBox2.Checked.ToString();
				Properties.Settings.Default.TE020501_2 = TE020501_2;

				TE020501_3 = checkBox3.Checked.ToString();
				Properties.Settings.Default.TE020501_3 = TE020501_3;

				TE020501_4 = checkBox4.Checked.ToString();
				Properties.Settings.Default.TE020501_4 = TE020501_4;

				ExtOutputDevice = txt_ExtOutputDevice.Text;
				Properties.Settings.Default.ExtOutputDevice = ExtOutputDevice;

				ExtOutputYesNo = comboBox1.SelectedItem.ToString();
				Properties.Settings.Default.ExtOutputYesNo = ExtOutputYesNo;
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

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{

		}

		//private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//	if (comboBox1.SelectedItem.ToString() == "Yes")
		//	{
		//		label4.Visible = true;
		//		txt_ExtOutputDevice.Visible = true;

		//		txt_ExtOutputDevice.Text = "";
		//	}
		//	else
		//	{
		//		label4.Visible = false;
		//		txt_ExtOutputDevice.Visible = false;

		//		txt_ExtOutputDevice.Text = "N/A";
		//	}

		//}

		private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem.ToString() == "Yes")
			{
				label4.Visible = true;
				txt_ExtOutputDevice.Visible = true;

				txt_ExtOutputDevice.Text = "";
			}
			else
			{
				label4.Visible = false;
				txt_ExtOutputDevice.Visible = false;

				txt_ExtOutputDevice.Text = "N/A";
			}
		}
	}
}

