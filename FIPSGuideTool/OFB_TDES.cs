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
	public partial class OFB_TDES : Form
	{
		public static string TDES_OFB_En;
		public static string TDES_OFB_De;

		public OFB_TDES()
		{
			InitializeComponent();

			TDES_OFB_En = Properties.Settings.Default.TDES_OFB_En.ToString();
			TDES_OFB_De = Properties.Settings.Default.TDES_OFB_De.ToString();


			if (TDES_OFB_En == "True")
			{
				checkBox4.Checked = true;
			}
			else
			{
				checkBox4.Checked = false;
			}

			if (TDES_OFB_De == "True")
			{
				checkBox5.Checked = true;
			}
			else
			{
				checkBox5.Checked = false;
			}
		}

		private void OFB_TDES_Load(object sender, EventArgs e)
		{

		}

		private void OFB_TDES_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				TDES_OFB_En = checkBox4.Checked.ToString();
				Properties.Settings.Default.TDES_OFB_En = TDES_OFB_En;
				TDES_OFB_De = checkBox5.Checked.ToString();
				Properties.Settings.Default.TDES_OFB_De = TDES_OFB_De;
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