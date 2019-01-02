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
	public partial class PopulateMitigation : Form
	{
		public static string color_Mitig;

		public PopulateMitigation()
		{
			InitializeComponent();
			color_Mitig = Properties.Settings.Default.color_Mitig.ToString();
		}

		private void PopulateMitigation_Load(object sender, EventArgs e)
		{
			if (color_Mitig == "True")
			{
				btn_MitOtherAttackTEs.BackColor = Color.Green;
			}
			else if (color_Mitig == "False")
			{
				btn_MitOtherAttackTEs.BackColor = Color.Gray;
			}
		}

		public void UpdateFormColor(string color_spec)
		{
			color_Mitig = Properties.Settings.Default.color_Mitig.ToString();

			if (color_Mitig == "True")
			{
				btn_MitOtherAttackTEs.BackColor = Color.Green;
			}
			else if (color_Mitig == "False")
			{
				btn_MitOtherAttackTEs.BackColor = Color.Gray;
			}
		}

		private void btn_MitOtherAttackTEs_Click(object sender, EventArgs e)
		{
			MitigationAttacksAS_TE f1 = new MitigationAttacksAS_TE();
			f1.ShowDialog();
			UpdateFormColor(color_Mitig);
		}
	}
}