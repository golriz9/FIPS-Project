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
	public partial class ActiveComponents : Form
	{
		public static string TE010802_activeComp;
		public ActiveComponents()
		{
			InitializeComponent();

			TE010802_activeComp = Properties.Settings.Default.TE010802_activeComp.ToString();
		}

		private void ActiveComponents_Load(object sender, EventArgs e)
		{
			TE010802_activeComp = Properties.Settings.Default.TE010802_activeComp.ToString();
			txtBox_ActiveComponents.Text = TE010802_activeComp;
		}

		private void ActiveComponents_FormClosed(object sender, FormClosedEventArgs e)
		{
			ModuleSpecs.TE010802_activeComp = txtBox_ActiveComponents.Text;
			TE010802_activeComp            = txtBox_ActiveComponents.Text;			

			Properties.Settings.Default.TE010802_activeComp = txtBox_ActiveComponents.Text;
			Properties.Settings.Default.Save();

			SpecificationsAssertions f1 = new SpecificationsAssertions();
			f1.populateSpecLevel1234();
		}
	}
}
