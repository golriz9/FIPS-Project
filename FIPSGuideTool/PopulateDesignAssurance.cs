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
	public partial class PopulateDesignAssurance : Form
	{
		public static string color_DesAssur;

		public PopulateDesignAssurance()
		{
			InitializeComponent();
			color_DesAssur = Properties.Settings.Default.color_DesAssur.ToString();
		}

		private void PopulateDesignAssurance_Load(object sender, EventArgs e)
		{
			if (color_DesAssur == "True")
			{
				btn_DesAssurTEs.BackColor = Color.Green;
			}
			else if (color_DesAssur == "False")
			{
				btn_DesAssurTEs.BackColor = Color.Gray;
			}
		}

		public void UpdateFormColor(string color_spec)
		{
			color_DesAssur = Properties.Settings.Default.color_DesAssur.ToString();

			if (color_DesAssur == "True")
			{
				btn_DesAssurTEs.BackColor = Color.Green;
			}
			else if (color_DesAssur == "False")
			{
				btn_DesAssurTEs.BackColor = Color.Gray;
			}
		}

		private void btn_DesAssurTEs_Click(object sender, EventArgs e)
		{
			DesignAssuranceAS_TE f1 = new DesignAssuranceAS_TE();
			f1.ShowDialog();
			UpdateFormColor(color_DesAssur);
		}
	}
}
