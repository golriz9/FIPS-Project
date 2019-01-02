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
	public partial class SHA : Form
	{
		public static string SHA3_224;
		public static string SHA3_256;
		public static string SHA3_384;
		public static string SHA3_512;
		public static string HASH_ByteOrient_SHA3;
		public static string NoNull_SHA3;

		public SHA()
		{
			InitializeComponent();

			SHA3_224             = Properties.Settings.Default.SHA3_224.ToString();
			SHA3_256             = Properties.Settings.Default.SHA3_256.ToString();
			SHA3_384             = Properties.Settings.Default.SHA3_384.ToString();
			SHA3_512             = Properties.Settings.Default.SHA3_512.ToString();
			HASH_ByteOrient_SHA3 = Properties.Settings.Default.HASH_ByteOrient_SHA3.ToString();
			NoNull_SHA3          = Properties.Settings.Default.NoNull_SHA3.ToString();


			if (SHA3_224 == "True")
			{
				checkBox2.Checked = true;
			}

			if (SHA3_256 == "True")
			{
				checkBox3.Checked = true;
			}

			if (SHA3_384 == "True")
			{
				checkBox4.Checked = true;
			}

			if (SHA3_512 == "True")
			{
				checkBox5.Checked = true;
			}

			if (HASH_ByteOrient_SHA3 == "True")
			{
				radioButton1.Checked = true;
			}

			if (NoNull_SHA3 == "True")
			{
				radioButton2.Checked = true;
			}

		}

			private void SHA_Load(object sender, EventArgs e)
		{

		}

		private void SHA_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				SHA3_224 = checkBox2.Checked.ToString();
				Properties.Settings.Default.SHA3_224 = SHA3_224;

				SHA3_256 = checkBox3.Checked.ToString();
				Properties.Settings.Default.SHA3_256 = SHA3_256;

				SHA3_384 = checkBox4.Checked.ToString();
				Properties.Settings.Default.SHA3_384 = SHA3_384;

				SHA3_512 = checkBox5.Checked.ToString();
				Properties.Settings.Default.SHA3_512 = SHA3_512;

				HASH_ByteOrient_SHA3 = radioButton1.Checked.ToString();
				Properties.Settings.Default.HASH_ByteOrient_SHA3 = HASH_ByteOrient_SHA3;

				NoNull_SHA3 = radioButton2.Checked.ToString();
				Properties.Settings.Default.NoNull_SHA3 = NoNull_SHA3;
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