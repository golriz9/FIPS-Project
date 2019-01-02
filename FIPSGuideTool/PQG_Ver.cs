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
	public partial class PQG_Ver : Form
	{
		public static string PQG_V_SHA1_N160;
		public static string PQG_V_SHA224_N160;
		public static string PQG_V_SHA256_N160;
		public static string PQG_V_SHA384_N160;
		public static string PQG_V_SHA512_N160;
		public static string PQG_V_SHA512_224_N160;
		public static string PQG_V_SHA512_256_N160;
		public static string PQ_V_Prob_N160;
		public static string PQ_V_Prov_N160;
		public static string G_V_Unver_N160;
		public static string G_V_Cann_N160;

		public static string PQG_V_SHA224_N224;
		public static string PQG_V_SHA256_N224;
		public static string PQG_V_SHA384_N224;
		public static string PQG_V_SHA512_N224;
		public static string PQG_V_SHA512_224_N224;
		public static string PQG_V_SHA512_256_N224;
		public static string PQ_V_Prob_N224;
		public static string PQ_V_Prov_N224;
		public static string G_V_Unver_N224;
		public static string G_V_Cann_N224;

		public static string PQG_V_SHA256_N256;
		public static string PQG_V_SHA384_N256;
		public static string PQG_V_SHA512_N256;
		public static string PQG_V_SHA512_256_N256;
		public static string PQ_V_Prob_N256;
		public static string PQ_V_Prov_N256;
		public static string G_V_Unver_N256;
		public static string G_V_Cann_N256;

		public static string PQG_V_SHA256_L3072;
		public static string PQG_V_SHA384_L3072;
		public static string PQG_V_SHA512_L3072;
		public static string PQG_V_SHA512_256_L3072;
		public static string PQ_V_Prob_L3072;
		public static string PQ_V_Prov_L3072;
		public static string G_V_Unver_L3072;
		public static string G_V_Cann_L3072;


		public PQG_Ver()
		{
			InitializeComponent();

			PQG_V_SHA1_N160       = Properties.Settings.Default.PQG_V_SHA1_N160.ToString();
			PQG_V_SHA224_N160     = Properties.Settings.Default.PQG_V_SHA224_N160.ToString();
			PQG_V_SHA256_N160     = Properties.Settings.Default.PQG_V_SHA256_N160.ToString();
			PQG_V_SHA384_N160     = Properties.Settings.Default.PQG_V_SHA384_N160.ToString();
			PQG_V_SHA512_N160     = Properties.Settings.Default.PQG_V_SHA512_N160.ToString();
			PQG_V_SHA512_224_N160 = Properties.Settings.Default.PQG_V_SHA512_224_N160.ToString();
			PQG_V_SHA512_256_N160 = Properties.Settings.Default.PQG_V_SHA512_256_N160.ToString();
			PQ_V_Prob_N160        = Properties.Settings.Default.PQ_V_Prob_N160.ToString();
			PQ_V_Prov_N160        = Properties.Settings.Default.PQ_V_Prov_N160.ToString();
			G_V_Unver_N160        = Properties.Settings.Default.G_V_Unver_N160.ToString();
			G_V_Cann_N160         = Properties.Settings.Default.G_V_Cann_N160.ToString();

			if (PQG_V_SHA1_N160 == "True")
			{
				checkBox27.Checked = true;
			}

			if (PQG_V_SHA224_N160 == "True")
			{
				checkBox2.Checked = true;
			}

			if (PQG_V_SHA256_N160 == "True")
			{
				checkBox3.Checked = true;
			}

			if (PQG_V_SHA384_N160 == "True")
			{
				checkBox4.Checked = true;
			}

			if (PQG_V_SHA512_N160 == "True")
			{
				checkBox5.Checked = true;
			}

			if (PQG_V_SHA512_224_N160 == "True")
			{
				checkBox6.Checked = true;
			}

			if (PQG_V_SHA512_256_N160 == "True")
			{
				checkBox7.Checked = true;
			}

			if (PQ_V_Prob_N160 == "True")
			{
				checkBox18.Checked = true;
			}

			if (PQ_V_Prov_N160 == "True")
			{
				checkBox17.Checked = true;
			}

			if (G_V_Unver_N160 == "True")
			{
				checkBox16.Checked = true;
			}

			if (G_V_Cann_N160 == "True")
			{
				checkBox15.Checked = true;
			}

			PQG_V_SHA224_N224     = Properties.Settings.Default.PQG_V_SHA224_N224.ToString();
			PQG_V_SHA256_N224     = Properties.Settings.Default.PQG_V_SHA256_N224.ToString();
			PQG_V_SHA384_N224     = Properties.Settings.Default.PQG_V_SHA384_N224.ToString();
			PQG_V_SHA512_N224     = Properties.Settings.Default.PQG_V_SHA512_N224.ToString();
			PQG_V_SHA512_224_N224 = Properties.Settings.Default.PQG_V_SHA512_224_N224.ToString();
			PQG_V_SHA512_256_N224 = Properties.Settings.Default.PQG_V_SHA512_256_N224.ToString();
			PQ_V_Prob_N224        = Properties.Settings.Default.PQ_V_Prob_N224.ToString();
			PQ_V_Prov_N224        = Properties.Settings.Default.PQ_V_Prov_N224.ToString();
			G_V_Unver_N224        = Properties.Settings.Default.G_V_Unver_N224.ToString();
			G_V_Cann_N224         = Properties.Settings.Default.G_V_Cann_N224.ToString();

			if (PQG_V_SHA224_N224 == "True")
			{
				checkBox30.Checked = true;
			}

			if (PQG_V_SHA256_N224 == "True")
			{
				checkBox29.Checked = true;
			}

			if (PQG_V_SHA384_N224 == "True")
			{
				checkBox28.Checked = true;
			}

			if (PQG_V_SHA512_N224 == "True")
			{
				checkBox11.Checked = true;
			}

			if (PQG_V_SHA512_224_N224 == "True")
			{
				checkBox10.Checked = true;
			}

			if (PQG_V_SHA512_256_N224 == "True")
			{
				checkBox9.Checked = true;
			}

			if (PQ_V_Prob_N224 == "True")
			{
				checkBox22.Checked = true;
			}

			if (PQ_V_Prov_N224 == "True")
			{
				checkBox21.Checked = true;
			}

			if (G_V_Unver_N224 == "True")
			{
				checkBox20.Checked = true;
			}

			if (G_V_Cann_N224 == "True")
			{
				checkBox19.Checked = true;
			}

			PQG_V_SHA256_N256     = Properties.Settings.Default.PQG_V_SHA256_N256.ToString();
			PQG_V_SHA384_N256     = Properties.Settings.Default.PQG_V_SHA384_N256.ToString();
			PQG_V_SHA512_N256     = Properties.Settings.Default.PQG_V_SHA512_N256.ToString();
			PQG_V_SHA512_256_N256 = Properties.Settings.Default.PQG_V_SHA512_256_N256.ToString();
			PQ_V_Prob_N256        = Properties.Settings.Default.PQ_V_Prob_N256.ToString();
			PQ_V_Prov_N256        = Properties.Settings.Default.PQ_V_Prov_N256.ToString();
			G_V_Unver_N256        = Properties.Settings.Default.G_V_Unver_N256.ToString();
			G_V_Cann_N256         = Properties.Settings.Default.G_V_Cann_N256.ToString();

			if (PQG_V_SHA256_N256 == "True")
			{
				checkBox14.Checked = true;
			}

			if (PQG_V_SHA384_N256 == "True")
			{
				checkBox13.Checked = true;
			}

			if (PQG_V_SHA512_N256 == "True")
			{
				checkBox12.Checked = true;
			}

			if (PQG_V_SHA512_256_N256 == "True")
			{
				checkBox8.Checked = true;
			}

			if (PQ_V_Prob_N256 == "True")
			{
				checkBox26.Checked = true;
			}

			if (PQ_V_Prov_N256 == "True")
			{
				checkBox25.Checked = true;
			}

			if (G_V_Unver_N256 == "True")
			{
				checkBox24.Checked = true;
			}

			if (G_V_Cann_N256 == "True")
			{
				checkBox23.Checked = true;
			}
			
			PQG_V_SHA256_L3072     = Properties.Settings.Default.PQG_V_SHA256_L3072.ToString();
			PQG_V_SHA384_L3072     = Properties.Settings.Default.PQG_V_SHA384_L3072.ToString();
			PQG_V_SHA512_L3072     = Properties.Settings.Default.PQG_V_SHA512_L3072.ToString();
			PQG_V_SHA512_256_L3072 = Properties.Settings.Default.PQG_V_SHA512_256_L3072.ToString();
			PQ_V_Prob_L3072        = Properties.Settings.Default.PQ_V_Prob_L3072.ToString();
			PQ_V_Prov_L3072        = Properties.Settings.Default.PQ_V_Prov_L3072.ToString();
			G_V_Unver_L3072        = Properties.Settings.Default.G_V_Unver_L3072.ToString();
			G_V_Cann_L3072         = Properties.Settings.Default.G_V_Cann_L3072.ToString();

			if (PQG_V_SHA256_L3072 == "True")
			{
				checkBox37.Checked = true;
			}

			if (PQG_V_SHA384_L3072 == "True")
			{
				checkBox36.Checked = true;
			}

			if (PQG_V_SHA512_L3072 == "True")
			{
				checkBox35.Checked = true;
			}

			if (PQG_V_SHA512_256_L3072 == "True")
			{
				checkBox34.Checked = true;
			}

			if (PQ_V_Prob_L3072 == "True")
			{
				checkBox33.Checked = true;
			}

			if (PQ_V_Prov_L3072 == "True")
			{
				checkBox32.Checked = true;
			}

			if (G_V_Unver_L3072 == "True")
			{
				checkBox31.Checked = true;
			}

			if (G_V_Cann_L3072 == "True")
			{
				checkBox1.Checked = true;
			}

		}

		private void PQG_Ver_Load(object sender, EventArgs e)
		{

		}

		private void PQG_Ver_FormClosing(object sender, FormClosingEventArgs e)
		{
		
		}

		private void PQG_Ver_FormClosing_1(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				PQG_V_SHA1_N160 = checkBox27.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA1_N160 = PQG_V_SHA1_N160;

				PQG_V_SHA224_N160 = checkBox2.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA224_N160 = PQG_V_SHA224_N160;

				PQG_V_SHA256_N160 = checkBox3.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA256_N160 = PQG_V_SHA256_N160;

				PQG_V_SHA384_N160 = checkBox4.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA384_N160 = PQG_V_SHA384_N160;

				PQG_V_SHA512_N160 = checkBox5.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA512_N160 = PQG_V_SHA512_N160;

				PQG_V_SHA512_224_N160 = checkBox6.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA512_224_N160 = PQG_V_SHA512_224_N160;

				PQG_V_SHA512_256_N160 = checkBox7.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA512_256_N160 = PQG_V_SHA512_256_N160;

				PQ_V_Prob_N160 = checkBox18.Checked.ToString();
				Properties.Settings.Default.PQ_V_Prob_N160 = PQ_V_Prob_N160;

				PQ_V_Prov_N160 = checkBox17.Checked.ToString();
				Properties.Settings.Default.PQ_V_Prov_N160 = PQ_V_Prov_N160;

				G_V_Unver_N160 = checkBox16.Checked.ToString();
				Properties.Settings.Default.G_V_Unver_N160 = G_V_Unver_N160;

				G_V_Cann_N160 = checkBox15.Checked.ToString();
				Properties.Settings.Default.G_V_Cann_N160 = G_V_Cann_N160;

				PQG_V_SHA224_N224 = checkBox30.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA224_N224 = PQG_V_SHA224_N224;

				PQG_V_SHA256_N224 = checkBox29.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA256_N224 = PQG_V_SHA256_N224;

				PQG_V_SHA384_N224 = checkBox28.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA384_N224 = PQG_V_SHA384_N224;

				PQG_V_SHA512_N224 = checkBox11.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA512_N224 = PQG_V_SHA512_N224;

				PQG_V_SHA512_224_N224 = checkBox10.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA512_224_N224 = PQG_V_SHA512_224_N224;

				PQG_V_SHA512_256_N224 = checkBox9.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA512_256_N224 = PQG_V_SHA512_256_N224;

				PQ_V_Prob_N224 = checkBox22.Checked.ToString();
				Properties.Settings.Default.PQ_V_Prob_N224 = PQ_V_Prob_N224;

				PQ_V_Prov_N224 = checkBox21.Checked.ToString();
				Properties.Settings.Default.PQ_V_Prov_N224 = PQ_V_Prov_N224;

				G_V_Unver_N224 = checkBox20.Checked.ToString();
				Properties.Settings.Default.G_V_Unver_N224 = G_V_Unver_N224;

				G_V_Cann_N224 = checkBox19.Checked.ToString();
				Properties.Settings.Default.G_V_Cann_N224 = G_V_Cann_N224;

				PQG_V_SHA256_N256 = checkBox14.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA256_N256 = PQG_V_SHA256_N256;

				PQG_V_SHA384_N256 = checkBox13.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA384_N256 = PQG_V_SHA384_N256;

				PQG_V_SHA512_N256 = checkBox12.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA512_N256 = PQG_V_SHA512_N256;

				PQG_V_SHA512_256_N256 = checkBox8.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA512_256_N256 = PQG_V_SHA512_256_N256;

				PQ_V_Prob_N256 = checkBox26.Checked.ToString();
				Properties.Settings.Default.PQ_V_Prob_N256 = PQ_V_Prob_N256;

				PQ_V_Prov_N256 = checkBox25.Checked.ToString();
				Properties.Settings.Default.PQ_V_Prov_N256 = PQ_V_Prov_N256;

				G_V_Unver_N256 = checkBox24.Checked.ToString();
				Properties.Settings.Default.G_V_Unver_N256 = G_V_Unver_N256;

				G_V_Cann_N256 = checkBox23.Checked.ToString();
				Properties.Settings.Default.G_V_Cann_N256 = G_V_Cann_N256;

				PQG_V_SHA256_L3072 = checkBox37.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA256_L3072 = PQG_V_SHA256_L3072;

				PQG_V_SHA384_L3072 = checkBox36.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA384_L3072 = PQG_V_SHA384_L3072;

				PQG_V_SHA512_L3072 = checkBox35.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA512_L3072 = PQG_V_SHA512_L3072;

				PQG_V_SHA512_256_L3072 = checkBox34.Checked.ToString();
				Properties.Settings.Default.PQG_V_SHA512_256_L3072 = PQG_V_SHA512_256_L3072;

				PQ_V_Prob_L3072 = checkBox33.Checked.ToString();
				Properties.Settings.Default.PQ_V_Prob_L3072 = PQ_V_Prob_L3072;

				PQ_V_Prov_L3072 = checkBox32.Checked.ToString();
				Properties.Settings.Default.PQ_V_Prov_L3072 = PQ_V_Prov_L3072;

				G_V_Unver_L3072 = checkBox31.Checked.ToString();
				Properties.Settings.Default.G_V_Unver_L3072 = G_V_Unver_L3072;

				G_V_Cann_L3072 = checkBox1.Checked.ToString();
				Properties.Settings.Default.G_V_Cann_L3072 = G_V_Cann_L3072;
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