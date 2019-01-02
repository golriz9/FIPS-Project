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
	public partial class CTR_TDES : Form
	{
		public static string CTR_En_TDES;

		public CTR_TDES()
		{
			InitializeComponent();

			CTR_En_TDES = Properties.Settings.Default.TDES_CTR_En.ToString();


			if (CTR_En_TDES == "True")
			{
				checkBox_CTR_En.Checked = true;
			}
			else
			{
				checkBox_CTR_En.Checked = false;
			}
		}

		private void CTR_TDES_Load(object sender, EventArgs e)
		{

		}

		private void CTR_TDES_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				CTR_En_TDES = checkBox_CTR_En.Checked.ToString();
				Properties.Settings.Default.TDES_CTR_En = CTR_En_TDES;
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