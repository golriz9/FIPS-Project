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
	public partial class KDF135 : Form
	{
		public static string IKEv1;
		public static string IKEv2;
		public static string TLS;
		public static string ANS_X9_63;
		public static string SSH;
		public static string SRTP;
		public static string SNMP;
		public static string TPM1_2;
		

		public KDF135()
		{
			InitializeComponent();

			IKEv1 = Properties.Settings.Default.IKEv1.ToString();
			IKEv2 = Properties.Settings.Default.IKEv2.ToString();
			TLS       = Properties.Settings.Default.TLS.ToString();
			ANS_X9_63 = Properties.Settings.Default.ANS_X9_63.ToString();
			SSH = Properties.Settings.Default.SSH.ToString();
			SRTP = Properties.Settings.Default.SRTP.ToString();
			SNMP = Properties.Settings.Default.SNMP.ToString();
			TPM1_2 = Properties.Settings.Default.TPM1_2.ToString();

			if (IKEv1 == "True")
			{
				checkBox1.Checked = true;
			}

			if (IKEv2 == "True")
			{
				checkBox2.Checked = true;
			}

			if (TLS == "True")
			{
				checkBox3.Checked = true;
			}

			if (ANS_X9_63 == "True")
			{
				checkBox4.Checked = true;
			}

			if (SSH == "True")
			{
				checkBox5.Checked = true;
			}

			if (SRTP == "True")
			{
				checkBox6.Checked = true;
			}

			if (SNMP == "True")
			{
				checkBox7.Checked = true;
			}

			if (TPM1_2 == "True")
			{
				checkBox8.Checked = true;
			}
		}

		private void KDF135_Load(object sender, EventArgs e)
		{

		}

		private void KDF135_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				IKEv1 = checkBox1.Checked.ToString();
				Properties.Settings.Default.IKEv1 = IKEv1;

				IKEv2 = checkBox2.Checked.ToString();
				Properties.Settings.Default.IKEv2 = IKEv2;

				TLS = checkBox3.Checked.ToString();
				Properties.Settings.Default.TLS = TLS;

				ANS_X9_63 = checkBox4.Checked.ToString();
				Properties.Settings.Default.ANS_X9_63 = ANS_X9_63;

				SSH = checkBox5.Checked.ToString();
				Properties.Settings.Default.SSH = SSH;

				SRTP = checkBox6.Checked.ToString();
				Properties.Settings.Default.SRTP = SRTP;

				SNMP = checkBox7.Checked.ToString();
				Properties.Settings.Default.SNMP = SNMP;

				TPM1_2 = checkBox8.Checked.ToString();
				Properties.Settings.Default.TPM1_2 = TPM1_2;

				Properties.Settings.Default.Save();

				e.Cancel = false;
			}
			else if (result == DialogResult.No)
			{
				e.Cancel = false;
			}
			else if (result == DialogResult.Cancel)
			{
				e.Cancel = true;

				//e.Cancel = (result == DialogResult.No);
			}
		}
	}
}