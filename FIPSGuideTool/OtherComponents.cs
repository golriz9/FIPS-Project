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
	public partial class OtherComponents : Form
	{
		public static string TE010802_otherComponents;

		public OtherComponents()
		{
			InitializeComponent();

			TE010802_otherComponents = Properties.Settings.Default.TE010802_otherComponents.ToString();
		}

		private void OtherComponents_Load(object sender, EventArgs e)
		{
			TE010802_otherComponents = Properties.Settings.Default.TE010802_otherComponents.ToString();
			txtBox_otherComponents.Text = TE010802_otherComponents;
		}

		private void OtherComponents_FormClosing(object sender, FormClosingEventArgs e)
		{
			ModuleSpecs.TE010802_otherComponents = txtBox_otherComponents.Text;
			TE010802_otherComponents = txtBox_otherComponents.Text;

			Properties.Settings.Default.TE010802_otherComponents = TE010802_otherComponents;
			Properties.Settings.Default.Save();

			SpecificationsAssertions f1 = new SpecificationsAssertions();
			f1.populateSpecLevel1234();
		}
	}
}
