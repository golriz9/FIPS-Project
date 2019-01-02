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
	public partial class PopulateFSM : Form
	{
		public static string color_FSM;

		public PopulateFSM()
		{
			InitializeComponent();
			color_FSM = Properties.Settings.Default.color_FSM.ToString();
		}

		private void PopulateFSM_Load(object sender, EventArgs e)
		{
			if (color_FSM == "True")
			{
				btn_FSMTEs.BackColor = Color.Green;
			}
			else if (color_FSM == "False")
			{
				btn_FSMTEs.BackColor = Color.Gray;
			}

		}

		public void UpdateFormColor(string color_spec)
		{
			color_FSM = Properties.Settings.Default.color_FSM.ToString();

			if (color_FSM == "True")
			{
				btn_FSMTEs.BackColor = Color.Green;
			}
			else if (color_FSM == "False")
			{
				btn_FSMTEs.BackColor = Color.Gray;
			}
		}

		private void btn_FSMTEs_Click(object sender, EventArgs e)
		{
			FSM_AS_TE f1 = new FSM_AS_TE();
			f1.ShowDialog();
			UpdateFormColor(color_FSM);
		}
	}
}
