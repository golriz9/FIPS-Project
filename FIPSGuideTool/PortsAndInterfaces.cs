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
	public partial class PortsAndInterfaces : Form
	{
		public static string TE021302;
		public static string txt_TE021302;
		public static string AS0216;
		public static string AS0217;
		public static string PortsInterfacesSecurityLevel;

		public PortsAndInterfaces()
		{
			InitializeComponent();
			label1.Visible = false;
			textBox_TE021302.Visible = false;

			TE021302 = Properties.Settings.Default.TE021302.ToString();
			txt_TE021302 = Properties.Settings.Default.txt_TE021302.ToString();
			PortsInterfacesSecurityLevel = Properties.Settings.Default.PortsInterfacesSecurityLevel.ToString();
			AS0216 = Properties.Settings.Default.AS0216.ToString();
			AS0217 = Properties.Settings.Default.AS0217.ToString();

			if (PortsInterfacesSecurityLevel == "Level 3" || PortsInterfacesSecurityLevel == "Level 4")
			{
				radioButton1.Visible = true;
				radioButton2.Visible = true;
			}
			else
			{
				radioButton1.Visible = false;
				radioButton2.Visible = false;
			}
		
		}

		private void btn_DataInputPorts_Click(object sender, EventArgs e)
		{
			DataInputPorts f1 = new DataInputPorts();
			f1.ShowDialog();
		}

		private void btn_DataOutputPorts_Click(object sender, EventArgs e)
		{
			DataOutputPorts f1 = new DataOutputPorts();
			f1.ShowDialog();
		}

		private void btn_CtrlInput_Click(object sender, EventArgs e)
		{
			CtrlInputPorts f1 = new CtrlInputPorts();
			f1.ShowDialog();
		}

		private void btn_StatusOut_Click(object sender, EventArgs e)
		{
			StatusOutputPorts f1 = new StatusOutputPorts();
			f1.ShowDialog();
		}

		private void PortsAndInterfaces_Load(object sender, EventArgs e)
		{
			textBox_TE021302.Text = txt_TE021302;

			if (TE021302 == "True")
			{
				checkBox1.Checked = true;
			}
			
			if (AS0216 == "True")
			{
				radioButton1.Checked = true;
			}

			if (AS0217 == "True")
			{
				radioButton2.Checked = true;
			}
		}

		private void btn_PwrIn_Click(object sender, EventArgs e)
		{
			PwrInputPorts f1 = new PwrInputPorts();
			f1.ShowDialog();
		}

		private void PortsAndInterfaces_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				TE021302 = checkBox1.Checked.ToString();
				Properties.Settings.Default.TE021302 = TE021302;

				txt_TE021302 = textBox_TE021302.Text;
				Properties.Settings.Default.txt_TE021302 = txt_TE021302;

				AS0216 = radioButton1.Checked.ToString();
				Properties.Settings.Default.AS0216 = AS0216;

				AS0217 = radioButton2.Checked.ToString();
				Properties.Settings.Default.AS0217 = AS0217;
				Properties.Settings.Default.Save();


				PortsInterfacesAssertions f1 = new PortsInterfacesAssertions();
				f1.populatePortInterfaceLevel1234();
				f1.populatePortInterfaceLevel34();
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


		private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			if (checkBox1.Checked.ToString() == "True")
			{
				label1.Visible = true;
				textBox_TE021302.Visible = true;

				//textBox_TE021302.Text = "";
			}
			else
			{
				label1.Visible = false;
				textBox_TE021302.Visible = false;

				textBox_TE021302.Text = "N/A";
			}
		}
	}
}
