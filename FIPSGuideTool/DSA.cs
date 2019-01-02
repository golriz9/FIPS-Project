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
	public partial class DSA : Form
	{
		public DSA()
		{
			InitializeComponent();
		}

		private void btn_PQG_Gen_Click(object sender, EventArgs e)
		{
			PQG_Gen f1 = new PQG_Gen();
			f1.ShowDialog();
		}

		private void btn_PQG_Ver_Click(object sender, EventArgs e)
		{
			PQG_Ver f1 = new PQG_Ver();
			f1.ShowDialog();
		}

		private void btn_KeyPairGen_Click(object sender, EventArgs e)
		{
			DSA_KeyPair f1 = new DSA_KeyPair();
			f1.ShowDialog();
		}

		private void btn_Sig_Gen_Click(object sender, EventArgs e)
		{
			SigGen f1 = new SigGen();
			f1.ShowDialog();
		}

		private void btn_Sig_Ver_Click(object sender, EventArgs e)
		{
			SigVer f1 = new SigVer();
			f1.ShowDialog();
		}

		private void DSA_Load(object sender, EventArgs e)
		{

		}
	}
}
