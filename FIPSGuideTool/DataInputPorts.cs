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
	public partial class DataInputPorts : Form
	{
		public static string DataIn;
		public static string TE020401_1;
		public static string TE020401_2;
		public static string TE020401_3;
		public static string TE020401_4;
		public static string TE020401_5;
		public static string ExtInputDevice;
		public static string ExtInEntryYesNo;


		public DataInputPorts()
		{
			InitializeComponent();
			label3.Visible = false;
			txt_ExtInputDevice.Visible = false;

			DataIn = Properties.Settings.Default.DataIn.ToString();
			ExtInputDevice = Properties.Settings.Default.ExtInputDevice.ToString();
			TE020401_1 = Properties.Settings.Default.TE020401_1.ToString();
			TE020401_2 = Properties.Settings.Default.TE020401_2.ToString();
			TE020401_3 = Properties.Settings.Default.TE020401_3.ToString();
			TE020401_4 = Properties.Settings.Default.TE020401_4.ToString();
			TE020401_5 = Properties.Settings.Default.TE020401_5.ToString();
			ExtInEntryYesNo = Properties.Settings.Default.ExtInEntryYesNo;
		}

		private void DataInputPorts_Load(object sender, EventArgs e)
		{
			comboBox2.SelectedItem = ExtInEntryYesNo;
			txt_DataIn.Text = DataIn;
			txt_ExtInputDevice.Text = ExtInputDevice;
			if (TE020401_1 == "True")
			{
				checkBox1.Checked = true;
			}

			if (TE020401_2 == "True")
			{
				checkBox2.Checked = true;
			}

			if (TE020401_3 == "True")
			{
				checkBox3.Checked = true;
			}

			if (TE020401_4 == "True")
			{
				checkBox4.Checked = true;
			}

			if (TE020401_5 == "True")
			{
				checkBox5.Checked = true;
			}
		}


		private void DataInputPorts_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				DataIn = txt_DataIn.Text;
				Properties.Settings.Default.DataIn = DataIn;

				ExtInputDevice = txt_ExtInputDevice.Text;
				Properties.Settings.Default.ExtInputDevice = ExtInputDevice;

				TE020401_1 = checkBox1.Checked.ToString();
				Properties.Settings.Default.TE020401_1 = TE020401_1;

				TE020401_2 = checkBox2.Checked.ToString();
				Properties.Settings.Default.TE020401_2 = TE020401_2;

				TE020401_3 = checkBox3.Checked.ToString();
				Properties.Settings.Default.TE020401_3 = TE020401_3;

				TE020401_4 = checkBox4.Checked.ToString();
				Properties.Settings.Default.TE020401_4 = TE020401_4;

				TE020401_5 = checkBox5.Checked.ToString();
				Properties.Settings.Default.TE020401_5 = TE020401_5;

				ExtInEntryYesNo = comboBox2.SelectedItem.ToString();
				Properties.Settings.Default.ExtInEntryYesNo = ExtInEntryYesNo;
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

		//private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//	if (comboBox2.SelectedItem.ToString() == "Yes")
		//	{
		//		label3.Visible = true;
		//		txt_ExtInputDevice.Visible = true;

		//		txt_ExtInputDevice.Text = "";
		//	}
		//	else
		//	{
		//		label3.Visible = false;
		//		txt_ExtInputDevice.Visible = false;

		//		txt_ExtInputDevice.Text = "N/A";
		//	}
		//}

		private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (comboBox2.SelectedItem.ToString() == "Yes")
			{
				label3.Visible = true;
				txt_ExtInputDevice.Visible = true;

				txt_ExtInputDevice.Text = "";
			}
			else
			{
				label3.Visible = false;
				txt_ExtInputDevice.Visible = false;

				txt_ExtInputDevice.Text = "N/A";
			}
		}
	}
}