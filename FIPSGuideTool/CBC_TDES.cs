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
	public partial class CBC_TDES : Form
	{
		public static string TDES_CBC_En;
		public static string TDES_CBC_De;

		public CBC_TDES()
		{
			InitializeComponent();

			TDES_CBC_En = Properties.Settings.Default.TDES_CBC_En.ToString();
			TDES_CBC_De = Properties.Settings.Default.TDES_CBC_De.ToString();


			if (TDES_CBC_En == "True")
			{
				checkBox4.Checked = true;
			}
			else
			{
				checkBox4.Checked = false;
			}

			if (TDES_CBC_De == "True")
			{
				checkBox5.Checked = true;
			}
			else
			{
				checkBox5.Checked = false;
			}
		}

		private void CBC_TDES_Load(object sender, EventArgs e)
		{

		}

		private void CBC_TDES_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				TDES_CBC_En = checkBox4.Checked.ToString();
				Properties.Settings.Default.TDES_CBC_En = TDES_CBC_En;
				TDES_CBC_De = checkBox5.Checked.ToString();
				Properties.Settings.Default.TDES_CBC_De = TDES_CBC_De;
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