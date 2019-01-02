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
	public partial class RAM : Form
	{
		public static string TE010802_RAM;
		public RAM()
		{
			InitializeComponent();

			TE010802_RAM = Properties.Settings.Default.TE010802_RAM.ToString();
		}

		private void RAM_Load(object sender, EventArgs e)
		{
			TE010802_RAM    = Properties.Settings.Default.TE010802_RAM.ToString();
			txtBox_RAM.Text = TE010802_RAM;
		}

		private void RAM_FormClosed(object sender, FormClosedEventArgs e)
		{			
			ModuleSpecs.TE010802_RAM = txtBox_RAM.Text;
			TE010802_RAM            = txtBox_RAM.Text;

			Properties.Settings.Default.TE010802_RAM = TE010802_RAM;
			Properties.Settings.Default.Save();

			SpecificationsAssertions f1 = new SpecificationsAssertions();
			f1.populateSpecLevel1234();
		}
	}
}
