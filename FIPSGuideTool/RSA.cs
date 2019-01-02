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
	public partial class RSA : Form
	{
		public RSA()
		{
			InitializeComponent();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void RSA_Load(object sender, EventArgs e)
		{

		}

		private void btn_IFC_Key_Gen_Click(object sender, EventArgs e)
		{
			RSA_KeyGen f1 = new RSA_KeyGen();
			f1.ShowDialog();
		}

		private void btn_RSA_LegTests_Click(object sender, EventArgs e)
		{
			RSA_LegacyTests f1 = new RSA_LegacyTests();
			f1.ShowDialog();
		}

		private void btn_RSA_CompTest_Click(object sender, EventArgs e)
		{
			RSA_ComponentTest f1 = new RSA_ComponentTest();
			f1.ShowDialog();
		}

		private void btn_RSA_SigGen_Click(object sender, EventArgs e)
		{
			RSA_SigGen f1 = new RSA_SigGen();
			f1.ShowDialog();
		}

		private void btn_RSA_SigGenPKCS_Click(object sender, EventArgs e)
		{
			RSA_SigGen_PKCS f1 = new RSA_SigGen_PKCS();
			f1.ShowDialog();
		}

		private void btn_RSA_SigGenPSS_Click(object sender, EventArgs e)
		{
			RSA_SigGen_PSS f1 = new RSA_SigGen_PSS();
			f1.ShowDialog();
		}

		private void btn_RSA_SigVer_Click(object sender, EventArgs e)
		{
			RSA_SigVer f1 = new RSA_SigVer();
			f1.ShowDialog();
		}

		private void btn_RSA_SigVerPKCS_Click(object sender, EventArgs e)
		{
			RSA_SigVer_PKCS f1 = new RSA_SigVer_PKCS();
			f1.ShowDialog();
		}

		private void btn_RSA_SigVerPSS_Click(object sender, EventArgs e)
		{
			RSA_SigVer_PSS f1 = new RSA_SigVer_PSS();
			f1.ShowDialog();
		}
	}
}