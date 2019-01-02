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
	public partial class ECDSA : Form
	{
		public ECDSA()
		{
			InitializeComponent();
		}

		//private void btn_KeyPairGen_Click(object sender, EventArgs e)
		//{
		//	ECDSA_KeyPair f1 = new ECDSA_KeyPair();
		//	f1.ShowDialog();
		//}

		private void ECDSA_Load(object sender, EventArgs e)
		{

		}

		private void btn_Sig_Gen_Click(object sender, EventArgs e)
		{
			ECDSA_SigGen f1 = new ECDSA_SigGen();
			f1.ShowDialog();
		}

		private void btn_KeyPairGen_Click_1(object sender, EventArgs e)
		{
			ECDSA_KeyPair f1 = new ECDSA_KeyPair();
			f1.ShowDialog();
		}

		private void btn_Sig_Ver_Click(object sender, EventArgs e)
		{
			ECDSA_SigVer f1 = new ECDSA_SigVer();
			f1.ShowDialog();
		}

		private void btn_PKV_Click(object sender, EventArgs e)
		{
			ECDSA_KeyVal f1 = new ECDSA_KeyVal();
			f1.ShowDialog();
		}
	}
}
