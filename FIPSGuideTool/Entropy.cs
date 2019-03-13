using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;

namespace FIPSGuideTool
{
	public partial class Entropy : Form
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();
		OleDbDataReader dataSearch;

		public static string NoBitsGenNDRNG;
		public static string NoBitsEntropyInput;
		public static string NoBitsNonce;
		public static string NoBitsAdditInput;
		public static string NoBitsPersonalStr;
		public static string AlgDRBGDepends;
		public static string DRBGOutputLength;
		public static string MinEntropy;
		public static string MaxEntropy;
		public static string DRBG_Type;
		public static string DerivFunc;
		public static string StandardEntropy;
		public static string FullEntropyOutput;



		public Entropy()
		{
			InitializeComponent();
			//txt_ExComponents.Visible = false;
			//label24.Visible = false;
			label8.Visible = false;
			comboBox_DerivFunc.Visible = false;

			NoBitsGenNDRNG = Properties.Settings.Default.NoBitsGenNDRNG.ToString();
			NoBitsEntropyInput = Properties.Settings.Default.NoBitsEntropyInput.ToString();
			NoBitsNonce = Properties.Settings.Default.NoBitsNonce.ToString();
			NoBitsAdditInput = Properties.Settings.Default.NoBitsAdditInput.ToString();
			NoBitsPersonalStr = Properties.Settings.Default.NoBitsPersonalStr.ToString();
			AlgDRBGDepends = Properties.Settings.Default.AlgDRBGDepends.ToString();
			DRBGOutputLength = Properties.Settings.Default.DRBGOutputLength.ToString();
			MinEntropy = Properties.Settings.Default.MinEntropy.ToString();
			MaxEntropy = Properties.Settings.Default.MaxEntropy.ToString();
			DRBG_Type = Properties.Settings.Default.DRBG_Type.ToString();
			DerivFunc = Properties.Settings.Default.DerivFunc.ToString();
			StandardEntropy = Properties.Settings.Default.StandardEntropy.ToString();
			FullEntropyOutput = Properties.Settings.Default.FullEntropyOutput.ToString();

			txtBox_NoBitsGenNDRNG.Text = NoBitsGenNDRNG;
			txtBox_NoBitsEntropyInput.Text = NoBitsEntropyInput;
			txtBox_NoBitsNonce.Text = NoBitsNonce;
			txtBox_NoBitsAdditInput.Text = NoBitsAdditInput;
			txtBox_NoBitsPersonalStr.Text = NoBitsPersonalStr;
			txtBox_AlgDRBGDepends.Text = AlgDRBGDepends;
			txtBox_DRBGOutputLength.Text = DRBGOutputLength;
			txtBox_MinEntropy.Text = MinEntropy;
			txtBox_MaxEntropy.Text = MaxEntropy;
			
			comboBox_DRBG_Type.SelectedItem = DRBG_Type;
			comboBox_DerivFunc.SelectedItem = DerivFunc;
			comboBox_Standard.SelectedItem = StandardEntropy;
			comboBox_FullEntropyOutput.SelectedItem = FullEntropyOutput;

		}

		private void Entropy_Load(object sender, EventArgs e)
		{

		}

		private void comboBox_DRBG_Type_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox_DRBG_Type.SelectedItem.ToString() == "CTR")
			{
				label8.Visible = true;
				comboBox_DerivFunc.Visible = true;
			}
			else
			{
				label8.Visible = false;
				comboBox_DerivFunc.Visible = false;
			}
		}

		private void Entropy_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				//ModuleSpecs.TE010802_processor = txtBox_processors.Text;
				//TE010802_processor = txtBox_processors.Text;

				NoBitsGenNDRNG = txtBox_NoBitsGenNDRNG.Text;
				Properties.Settings.Default.NoBitsGenNDRNG = NoBitsGenNDRNG;
				
				NoBitsEntropyInput = txtBox_NoBitsEntropyInput.Text;
				Properties.Settings.Default.NoBitsEntropyInput = NoBitsEntropyInput;
				
				NoBitsNonce = txtBox_NoBitsNonce.Text;
				Properties.Settings.Default.NoBitsNonce = NoBitsNonce;

				NoBitsAdditInput = txtBox_NoBitsAdditInput.Text;
				Properties.Settings.Default.NoBitsAdditInput = NoBitsAdditInput;

				NoBitsPersonalStr = txtBox_NoBitsPersonalStr.Text;
				Properties.Settings.Default.NoBitsPersonalStr = NoBitsPersonalStr;

				AlgDRBGDepends = txtBox_AlgDRBGDepends.Text;
				Properties.Settings.Default.AlgDRBGDepends = AlgDRBGDepends;

				DRBGOutputLength = txtBox_DRBGOutputLength.Text;
				Properties.Settings.Default.DRBGOutputLength = DRBGOutputLength;

				MinEntropy = txtBox_MinEntropy.Text;
				Properties.Settings.Default.MinEntropy = MinEntropy;

				MaxEntropy = txtBox_MaxEntropy.Text;
				Properties.Settings.Default.MaxEntropy = MaxEntropy;

				if (comboBox_DRBG_Type.SelectedItem != null)
				{
					DRBG_Type = comboBox_DRBG_Type.SelectedItem.ToString();
					Properties.Settings.Default.DRBG_Type = DRBG_Type;
				}

				if (comboBox_DerivFunc.SelectedItem != null)
				{
					DerivFunc = comboBox_DerivFunc.SelectedItem.ToString();
					Properties.Settings.Default.DerivFunc = DerivFunc;
				}

				if (comboBox_Standard.SelectedItem != null)
				{
					StandardEntropy = comboBox_Standard.SelectedItem.ToString();
					Properties.Settings.Default.StandardEntropy = StandardEntropy;
				}

				if (comboBox_FullEntropyOutput.SelectedItem != null)
				{
					FullEntropyOutput = comboBox_FullEntropyOutput.SelectedItem.ToString();
					Properties.Settings.Default.FullEntropyOutput = FullEntropyOutput;
				}				
				
				Properties.Settings.Default.Save();

				KeyManagementAssertions f1 = new KeyManagementAssertions();
				f1.populateKeyManagementLevel1234();

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

		private void btn_TE071301_Click(object sender, EventArgs e)
		{
			textBoxTE071301.Visible = true;
			KeyManagementAssertions f1 = new KeyManagementAssertions();
			f1.populateKeyManagementLevel1234();

			textBoxTE071301.Text = KeyManagementAssertions.TE071301_txt;
		}

		private void comboBox_DerivFunc_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox_DerivFunc.SelectedItem.ToString() == "Yes")
			{
				DerivFunc = "with a derivation function";
			}
			else if (comboBox_DerivFunc.SelectedItem.ToString() == "No")
			{
				DerivFunc = "";
			}
		}

		private void comboBox_FullEntropyOutput_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox_FullEntropyOutput.SelectedItem.ToString() == "Fully")
			{
				FullEntropyOutput = "Fully";
			}
			else if (comboBox_FullEntropyOutput.SelectedItem.ToString() == "Partially")
			{
				FullEntropyOutput = "Partially";
			}
		}

		private void btn_refresh_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void textBoxTE071301_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}