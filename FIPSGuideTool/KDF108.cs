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
	public partial class KDF108 : Form
	{
		public static string KDF_CTR_Mode;
		public static string KDF_FDBK_Mode;
		public static string KDF_DPI_Mode;

		public KDF108()
		{
			InitializeComponent();

			KDF_CTR_Mode = Properties.Settings.Default.KDF_CTR_Mode.ToString();
			KDF_FDBK_Mode = Properties.Settings.Default.KDF_FDBK_Mode.ToString();
			KDF_DPI_Mode = Properties.Settings.Default.KDF_DPI_Mode.ToString();

			if (KDF_CTR_Mode == "True")
			{
				checkBox1.Checked = true;
			}

			if (KDF_FDBK_Mode == "True")
			{
				checkBox2.Checked = true;
			}

			if (KDF_DPI_Mode == "True")
			{
				checkBox3.Checked = true;
			}
		}

		private void KDF108_Load(object sender, EventArgs e)
		{

		}

		private void KDF108_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				KDF_CTR_Mode = checkBox1.Checked.ToString();
				Properties.Settings.Default.KDF_CTR_Mode = KDF_CTR_Mode;

				KDF_FDBK_Mode = checkBox2.Checked.ToString();
				Properties.Settings.Default.KDF_FDBK_Mode = KDF_FDBK_Mode;

				KDF_DPI_Mode = checkBox3.Checked.ToString();
				Properties.Settings.Default.KDF_DPI_Mode = KDF_DPI_Mode;

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