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
	public partial class KASECC : Form
	{
		public static string FullUnified;
		public static string FullMQV;
		public static string EphemUnified;
		public static string OnePassUnified;
		public static string OnePassMQV;		
		public static string OnePassDH;		
		public static string StaticUnified;
		public static string ECCCDHCompTest;

		public KASECC()
		{
			InitializeComponent();

			FullUnified    = Properties.Settings.Default.FullUnified.ToString();
			FullMQV        = Properties.Settings.Default.FullMQV.ToString();
			OnePassUnified = Properties.Settings.Default.OnePassUnified.ToString();
			OnePassMQV     = Properties.Settings.Default.OnePassMQV.ToString();
			EphemUnified   = Properties.Settings.Default.EphemUnified.ToString();
			OnePassDH      = Properties.Settings.Default.OnePassDH.ToString();
			ECCCDHCompTest = Properties.Settings.Default.ECCCDHCompTest.ToString();
			StaticUnified  = Properties.Settings.Default.StaticUnified.ToString();

			if (FullUnified == "True")
			{
				checkBox1.Checked = true;
			}

			if (FullMQV == "True")
			{
				checkBox2.Checked = true;
			}

			if (EphemUnified == "True")
			{
				checkBox3.Checked = true;
			}

			if (OnePassUnified == "True")
			{
				checkBox4.Checked = true;
			}

			if (OnePassMQV == "True")
			{
				checkBox5.Checked = true;
			}

			if (OnePassDH == "True")
			{
				checkBox6.Checked = true;
			}

			if (StaticUnified == "True")
			{
				checkBox7.Checked = true;
			}

			if (ECCCDHCompTest == "True")
			{
				checkBox8.Checked = true;
			}
		}

		private void KASECC_Load(object sender, EventArgs e)
		{

		}

		private void KASECC_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				FullUnified = checkBox1.Checked.ToString();
				Properties.Settings.Default.FullUnified = FullUnified;

				FullMQV = checkBox2.Checked.ToString();
				Properties.Settings.Default.FullMQV = FullMQV;

				EphemUnified = checkBox3.Checked.ToString();
				Properties.Settings.Default.EphemUnified = EphemUnified;

				OnePassUnified = checkBox4.Checked.ToString();
				Properties.Settings.Default.OnePassUnified = OnePassUnified;

				OnePassMQV = checkBox5.Checked.ToString();
				Properties.Settings.Default.OnePassMQV = OnePassMQV;

				OnePassDH = checkBox6.Checked.ToString();
				Properties.Settings.Default.OnePassDH = OnePassDH;

				StaticUnified = checkBox7.Checked.ToString();
				Properties.Settings.Default.StaticUnified = StaticUnified;

				ECCCDHCompTest = checkBox8.Checked.ToString();
				Properties.Settings.Default.ECCCDHCompTest = ECCCDHCompTest;

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