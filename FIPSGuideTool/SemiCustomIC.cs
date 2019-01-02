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
	public partial class SemiCustomIC : Form
	{
		public static string TE010802_SemiCustomIC;

		public SemiCustomIC()
		{
			InitializeComponent();

			TE010802_SemiCustomIC = Properties.Settings.Default.TE010802_SemiCustomIC.ToString();
		}

		private void SemiCustomIC_FormClosed(object sender, FormClosedEventArgs e)
		{
			ModuleSpecs.TE010802_SemiCustomIC = txtBox_SemiCustomIC.Text;
			TE010802_SemiCustomIC = txtBox_SemiCustomIC.Text;

			Properties.Settings.Default.TE010802_SemiCustomIC = TE010802_SemiCustomIC;
			Properties.Settings.Default.Save();

			SpecificationsAssertions f1 = new SpecificationsAssertions();
			f1.populateSpecLevel1234();
		}

		private void SemiCustomIC_Load(object sender, EventArgs e)
		{
			TE010802_SemiCustomIC = Properties.Settings.Default.TE010802_SemiCustomIC.ToString();
			txtBox_SemiCustomIC.Text = TE010802_SemiCustomIC;
		}
	}
}
