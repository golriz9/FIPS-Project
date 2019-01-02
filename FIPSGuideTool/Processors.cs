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
	public partial class Processors : Form
	{
		public static string TE010802_processor;
		public Processors()
		{
			InitializeComponent();

			TE010802_processor = Properties.Settings.Default.TE010802_processor.ToString();
		}

		private void txtBox_processors_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void Processors_FormClosing(object sender, FormClosingEventArgs e)
		{

		}

		private void Processors_FormClosed(object sender, FormClosedEventArgs e)
		{
			ModuleSpecs.TE010802_processor = txtBox_processors.Text;
			TE010802_processor             = txtBox_processors.Text;

			Properties.Settings.Default.TE010802_processor = TE010802_processor;
			Properties.Settings.Default.Save();

			SpecificationsAssertions f1 = new SpecificationsAssertions();
			f1.populateSpecLevel1234();
		}

		private void Processors_Load(object sender, EventArgs e)
		{
			TE010802_processor = Properties.Settings.Default.TE010802_processor.ToString();
			txtBox_processors.Text = TE010802_processor;
		}
	}
}
