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
	public partial class PQG_Gen : Form
	{
		public static string PQG_G_SHA224_N224;
		public static string PQG_G_SHA256_N224;
		public static string PQG_G_SHA384_N224;
		public static string PQG_G_SHA512_N224;
		public static string PQG_G_SHA512_224_N224;
		public static string PQG_G_SHA512_256_N224;
		public static string PQ_G_Prob_N224;
		public static string PQ_G_Prov_N224;
		public static string G_G_Unver_N224;
		public static string G_G_Cann_N224;

		public static string PQG_G_SHA256_N256;
		public static string PQG_G_SHA384_N256;
		public static string PQG_G_SHA512_N256;
		public static string PQG_G_SHA512_256_N256;
		public static string PQ_G_Prob_N256;
		public static string PQ_G_Prov_N256;
		public static string G_G_Unver_N256;
		public static string G_G_Cann_N256;

		public static string PQG_G_SHA256_L3072;
		public static string PQG_G_SHA384_L3072;
		public static string PQG_G_SHA512_L3072;
		public static string PQG_G_SHA512_256_L3072;
		public static string PQ_G_Prob_L3072;
		public static string PQ_G_Prov_L3072;
		public static string G_G_Unver_L3072;
		public static string G_G_Cann_L3072;

		public PQG_Gen()
		{
			InitializeComponent();

			PQG_G_SHA224_N224     = Properties.Settings.Default.PQG_G_SHA224_N224.ToString();
			PQG_G_SHA256_N224     = Properties.Settings.Default.PQG_G_SHA256_N224.ToString();
			PQG_G_SHA384_N224     = Properties.Settings.Default.PQG_G_SHA384_N224.ToString();
			PQG_G_SHA512_N224     = Properties.Settings.Default.PQG_G_SHA512_N224.ToString();
			PQG_G_SHA512_224_N224 = Properties.Settings.Default.PQG_G_SHA512_224_N224.ToString();
			PQG_G_SHA512_256_N224 = Properties.Settings.Default.PQG_G_SHA512_256_N224.ToString();
			PQ_G_Prob_N224        = Properties.Settings.Default.PQ_G_Prob_N224.ToString();
			PQ_G_Prov_N224        = Properties.Settings.Default.PQ_G_Prov_N224.ToString();
			G_G_Unver_N224        = Properties.Settings.Default.G_G_Unver_N224.ToString();
			G_G_Cann_N224         = Properties.Settings.Default.G_G_Cann_N224.ToString();

			if (PQG_G_SHA224_N224 == "True")
			{
				checkBox2.Checked = true;
			}

			if (PQG_G_SHA256_N224 == "True")
			{
				checkBox3.Checked = true;
			}

			if (PQG_G_SHA384_N224 == "True")
			{
				checkBox4.Checked = true;
			}

			if (PQG_G_SHA512_N224 == "True")
			{
				checkBox5.Checked = true;
			}

			if (PQG_G_SHA512_224_N224 == "True")
			{
				checkBox6.Checked = true;
			}

			if (PQG_G_SHA512_256_N224 == "True")
			{
				checkBox7.Checked = true;
			}

			if (PQ_G_Prob_N224 == "True")
			{
				checkBox18.Checked = true;
			}

			if (PQ_G_Prov_N224 == "True")
			{
				checkBox17.Checked = true;
			}

			if (G_G_Unver_N224 == "True")
			{
				checkBox16.Checked = true;
			}

			if (G_G_Cann_N224 == "True")
			{
				checkBox15.Checked = true;
			}

			PQG_G_SHA256_N256     = Properties.Settings.Default.PQG_G_SHA256_N256.ToString();
			PQG_G_SHA384_N256     = Properties.Settings.Default.PQG_G_SHA384_N256.ToString();
			PQG_G_SHA512_N256     = Properties.Settings.Default.PQG_G_SHA512_N256.ToString();
			PQG_G_SHA512_256_N256 = Properties.Settings.Default.PQG_G_SHA512_256_N256.ToString();
			PQ_G_Prob_N256        = Properties.Settings.Default.PQ_G_Prob_N256.ToString();
			PQ_G_Prov_N256        = Properties.Settings.Default.PQ_G_Prov_N256.ToString();
			G_G_Unver_N256        = Properties.Settings.Default.G_G_Unver_N256.ToString();
			G_G_Cann_N256         = Properties.Settings.Default.G_G_Cann_N256.ToString();

			if (PQG_G_SHA256_N256 == "True")
			{
				checkBox11.Checked = true;
			}

			if (PQG_G_SHA384_N256 == "True")
			{
				checkBox10.Checked = true;
			}

			if (PQG_G_SHA512_N256 == "True")
			{
				checkBox9.Checked = true;
			}

			if (PQG_G_SHA512_256_N256 == "True")
			{
				checkBox1.Checked = true;
			}

			if (PQ_G_Prob_N256 == "True")
			{
				checkBox22.Checked = true;
			}

			if (PQ_G_Prov_N256 == "True")
			{
				checkBox21.Checked = true;
			}

			if (G_G_Unver_N256 == "True")
			{
				checkBox20.Checked = true;
			}

			if (G_G_Cann_N256 == "True")
			{
				checkBox19.Checked = true;
			}

			PQG_G_SHA256_L3072     = Properties.Settings.Default.PQG_G_SHA256_L3072.ToString();
			PQG_G_SHA384_L3072     = Properties.Settings.Default.PQG_G_SHA384_L3072.ToString();
			PQG_G_SHA512_L3072     = Properties.Settings.Default.PQG_G_SHA512_L3072.ToString();
			PQG_G_SHA512_256_L3072 = Properties.Settings.Default.PQG_G_SHA512_256_L3072.ToString();
			PQ_G_Prob_L3072        = Properties.Settings.Default.PQ_G_Prob_L3072.ToString();
			PQ_G_Prov_L3072        = Properties.Settings.Default.PQ_G_Prov_L3072.ToString();
			G_G_Unver_L3072        = Properties.Settings.Default.G_G_Unver_L3072.ToString();
			G_G_Cann_L3072         = Properties.Settings.Default.G_G_Cann_L3072.ToString();

			if (PQG_G_SHA256_L3072 == "True")
			{
				checkBox14.Checked = true;
			}

			if (PQG_G_SHA384_L3072 == "True")
			{
				checkBox13.Checked = true;
			}

			if (PQG_G_SHA512_L3072 == "True")
			{
				checkBox12.Checked = true;
			}

			if (PQG_G_SHA512_256_L3072 == "True")
			{
				checkBox8.Checked = true;
			}

			if (PQ_G_Prob_L3072 == "True")
			{
				checkBox26.Checked = true;
			}

			if (PQ_G_Prov_L3072 == "True")
			{
				checkBox25.Checked = true;
			}

			if (G_G_Unver_L3072 == "True")
			{
				checkBox24.Checked = true;
			}

			if (G_G_Cann_L3072 == "True")
			{
				checkBox23.Checked = true;
			}
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void PQG_Gen_Load(object sender, EventArgs e)
		{

		}

		private void PQG_Gen_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				PQG_G_SHA224_N224 = checkBox2.Checked.ToString();
				Properties.Settings.Default.PQG_G_SHA224_N224 = PQG_G_SHA224_N224;

				PQG_G_SHA256_N224 = checkBox3.Checked.ToString();
				Properties.Settings.Default.PQG_G_SHA256_N224 = PQG_G_SHA256_N224;

				PQG_G_SHA384_N224 = checkBox4.Checked.ToString();
				Properties.Settings.Default.PQG_G_SHA384_N224 = PQG_G_SHA384_N224;

				PQG_G_SHA512_N224 = checkBox5.Checked.ToString();
				Properties.Settings.Default.PQG_G_SHA512_N224 = PQG_G_SHA512_N224;

				PQG_G_SHA512_224_N224 = checkBox6.Checked.ToString();
				Properties.Settings.Default.PQG_G_SHA512_224_N224 = PQG_G_SHA512_224_N224;

				PQG_G_SHA512_256_N224 = checkBox7.Checked.ToString();
				Properties.Settings.Default.PQG_G_SHA512_256_N224 = PQG_G_SHA512_256_N224;

				PQ_G_Prob_N224 = checkBox18.Checked.ToString();
				Properties.Settings.Default.PQ_G_Prob_N224 = PQ_G_Prob_N224;

				PQ_G_Prov_N224 = checkBox17.Checked.ToString();
				Properties.Settings.Default.PQ_G_Prov_N224 = PQ_G_Prov_N224;

				G_G_Unver_N224 = checkBox16.Checked.ToString();
				Properties.Settings.Default.G_G_Unver_N224 = G_G_Unver_N224;

				G_G_Cann_N224 = checkBox15.Checked.ToString();
				Properties.Settings.Default.G_G_Cann_N224 = G_G_Cann_N224;

				PQG_G_SHA256_N256 = checkBox11.Checked.ToString();
				Properties.Settings.Default.PQG_G_SHA256_N256 = PQG_G_SHA256_N256;

				PQG_G_SHA384_N256 = checkBox10.Checked.ToString();
				Properties.Settings.Default.PQG_G_SHA384_N256 = PQG_G_SHA384_N256;

				PQG_G_SHA512_N256 = checkBox9.Checked.ToString();
				Properties.Settings.Default.PQG_G_SHA512_N256 = PQG_G_SHA512_N256;

				PQG_G_SHA512_256_N256 = checkBox1.Checked.ToString();
				Properties.Settings.Default.PQG_G_SHA512_256_N256 = PQG_G_SHA512_256_N256;

				PQ_G_Prob_N256 = checkBox22.Checked.ToString();
				Properties.Settings.Default.PQ_G_Prob_N256 = PQ_G_Prob_N256;

				PQ_G_Prov_N256 = checkBox21.Checked.ToString();
				Properties.Settings.Default.PQ_G_Prov_N256 = PQ_G_Prov_N256;

				G_G_Unver_N256 = checkBox20.Checked.ToString();
				Properties.Settings.Default.G_G_Unver_N256 = G_G_Unver_N256;

				G_G_Cann_N256 = checkBox19.Checked.ToString();
				Properties.Settings.Default.G_G_Cann_N256 = G_G_Cann_N256;

				PQG_G_SHA256_L3072 = checkBox14.Checked.ToString();
				Properties.Settings.Default.PQG_G_SHA256_L3072 = PQG_G_SHA256_L3072;

				PQG_G_SHA384_L3072 = checkBox13.Checked.ToString();
				Properties.Settings.Default.PQG_G_SHA384_L3072 = PQG_G_SHA384_L3072;

				PQG_G_SHA512_L3072 = checkBox12.Checked.ToString();
				Properties.Settings.Default.PQG_G_SHA512_L3072 = PQG_G_SHA512_L3072;

				PQG_G_SHA512_256_L3072 = checkBox8.Checked.ToString();
				Properties.Settings.Default.PQG_G_SHA512_256_L3072 = PQG_G_SHA512_256_L3072;

				PQ_G_Prob_L3072 = checkBox26.Checked.ToString();
				Properties.Settings.Default.PQ_G_Prob_L3072 = PQ_G_Prob_L3072;

				PQ_G_Prov_L3072 = checkBox25.Checked.ToString();
				Properties.Settings.Default.PQ_G_Prov_L3072 = PQ_G_Prov_L3072;

				G_G_Unver_L3072 = checkBox24.Checked.ToString();
				Properties.Settings.Default.G_G_Unver_L3072 = G_G_Unver_L3072;

				G_G_Cann_L3072 = checkBox23.Checked.ToString();
				Properties.Settings.Default.G_G_Cann_L3072 = G_G_Cann_L3072;
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