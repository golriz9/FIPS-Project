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
	public partial class ECB_TDES : Form
	{
		public static string TDES_ECB_En;
		public static string TDES_ECB_De;

		public ECB_TDES()
		{
			InitializeComponent();

			TDES_ECB_En = Properties.Settings.Default.TDES_ECB_En.ToString();
			TDES_ECB_De = Properties.Settings.Default.TDES_ECB_De.ToString();


			if (TDES_ECB_En == "True")
			{
				checkBox4.Checked = true;		
			}
			else
			{
				checkBox4.Checked = false;			
			}

			if (TDES_ECB_De == "True")
			{
				checkBox5.Checked = true;
			}
			else
			{
				checkBox5.Checked = false;
			}
		}

		private void ECB_TDES_Load(object sender, EventArgs e)
		{

		}
		
		private void ECB_TDES_FormClosing(object sender, FormClosingEventArgs e)
		{			
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				TDES_ECB_En = checkBox4.Checked.ToString();
				Properties.Settings.Default.TDES_ECB_En = TDES_ECB_En;
				TDES_ECB_De = checkBox5.Checked.ToString();
				Properties.Settings.Default.TDES_ECB_De = TDES_ECB_De;			
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