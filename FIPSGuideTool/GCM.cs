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
	public partial class GCM : Form
	{
		public static string GCM_en;
		public static string GCM_de;
		public static string GCM128;
		public static string GCM192;
		public static string GCM256;
		public static string GCM32_tag;
		public static string GCM64_tag;
		public static string GCM96_tag;
		public static string GCM104_tag;
		public static string GCM112_tag;
		public static string GCM120_tag;
		public static string GCM128_tag;


		public GCM()
		{
			InitializeComponent();

			GCM_en = Properties.Settings.Default.GCM_en.ToString();
			GCM_de = Properties.Settings.Default.GCM_de.ToString();
			GCM128 = Properties.Settings.Default.GCM128.ToString();
			GCM192 = Properties.Settings.Default.GCM192.ToString();
			GCM256 = Properties.Settings.Default.GCM256.ToString();
			GCM32_tag  = Properties.Settings.Default.GCM32_tag.ToString();
			GCM64_tag  = Properties.Settings.Default.GCM64_tag.ToString();
			GCM96_tag  = Properties.Settings.Default.GCM96_tag.ToString();
			GCM104_tag = Properties.Settings.Default.GCM104_tag.ToString();
			GCM112_tag = Properties.Settings.Default.GCM112_tag.ToString();
			GCM120_tag = Properties.Settings.Default.GCM120_tag.ToString();
			GCM128_tag = Properties.Settings.Default.GCM128_tag.ToString();

			if (GCM_en == "True")
			{
				checkBox9.Checked = true;
			}

			if (GCM_de == "True")
			{
				checkBox8.Checked = true;
			}

			if (GCM128 == "True")
			{
				checkBox1.Checked = true;
			}

			if (GCM192 == "True")
			{
				checkBox2.Checked = true;
			}

			if (GCM256 == "True")
			{
				checkBox3.Checked = true;
			}

			if (GCM32_tag == "True")
			{
				checkBox12.Checked = true;
			}

			if (GCM64_tag == "True")
			{
				checkBox11.Checked = true;
			}

			if (GCM96_tag == "True")
			{
				checkBox10.Checked = true;
			}

			if (GCM104_tag == "True")
			{
				checkBox4.Checked = true;
			}

			if (GCM112_tag == "True")
			{
				checkBox7.Checked = true;
			}

			if (GCM120_tag == "True")
			{
				checkBox6.Checked = true;
			}

			if (GCM128_tag == "True")
			{
				checkBox5.Checked = true;
			}
		}

		private void GCM_Load(object sender, EventArgs e)
		{

		}

		private void GCM_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
		{
		}

		private void GCM_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				GCM_en = checkBox9.Checked.ToString();
				Properties.Settings.Default.GCM_en = GCM_en;

				GCM_de = checkBox8.Checked.ToString();
				Properties.Settings.Default.GCM_de = GCM_de;

				GCM128 = checkBox1.Checked.ToString();
				Properties.Settings.Default.GCM128 = GCM128;

				GCM192 = checkBox2.Checked.ToString();
				Properties.Settings.Default.GCM192 = GCM192;

				GCM256 = checkBox3.Checked.ToString();
				Properties.Settings.Default.GCM256 = GCM256;

				GCM32_tag = checkBox12.Checked.ToString();
				Properties.Settings.Default.GCM32_tag = GCM32_tag;

				GCM64_tag = checkBox11.Checked.ToString();
				Properties.Settings.Default.GCM64_tag = GCM64_tag;

				GCM96_tag = checkBox10.Checked.ToString();
				Properties.Settings.Default.GCM96_tag = GCM96_tag;

				GCM104_tag = checkBox4.Checked.ToString();
				Properties.Settings.Default.GCM104_tag = GCM104_tag;

				GCM112_tag = checkBox7.Checked.ToString();
				Properties.Settings.Default.GCM112_tag = GCM112_tag;

				GCM128_tag = checkBox5.Checked.ToString();
				Properties.Settings.Default.GCM128_tag = GCM128_tag;

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

