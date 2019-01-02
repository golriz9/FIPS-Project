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
	public partial class SHS : Form
	{
		public static string SHA1;
		public static string SHA224;
		public static string SHA256;
		public static string SHA384;
		public static string SHA512;
		public static string SHA512_224;
		public static string SHA512_256;
		public static string HASH_ByteOrient;
		public static string NoNull;

		public SHS()
		{
			InitializeComponent();

			SHA1       = Properties.Settings.Default.SHA1.ToString();
			SHA224     = Properties.Settings.Default.SHA224.ToString();
			SHA256     = Properties.Settings.Default.SHA256.ToString();
			SHA384     = Properties.Settings.Default.SHA384.ToString();
			SHA512     = Properties.Settings.Default.SHA512.ToString();
			SHA512_224 = Properties.Settings.Default.SHA512_224.ToString();
			SHA512_256      = Properties.Settings.Default.SHA512_256.ToString();
			HASH_ByteOrient = Properties.Settings.Default.HASH_ByteOrient.ToString();
			NoNull          = Properties.Settings.Default.NoNull.ToString();

			if (SHA1 == "True")
			{
				checkBox1.Checked = true;		
			}

			if (SHA224 == "True")
			{
				checkBox2.Checked = true;
			}

			if (SHA256 == "True")
			{
				checkBox3.Checked = true;
			}

			if (SHA384 == "True")
			{
				checkBox4.Checked = true;
			}

			if (SHA512 == "True")
			{
				checkBox5.Checked = true;
			}

			if (SHA512_224 == "True")
			{
				checkBox6.Checked = true;
			}

			if (SHA512_256 == "True")
			{
				checkBox7.Checked = true;
			}

			if (HASH_ByteOrient == "True")
			{
				radioButton1.Checked = true;
			}

			if (NoNull == "True")
			{
				radioButton2.Checked = true;
			}			
		}

		private void SHS_Load(object sender, EventArgs e)
		{

		}

		private void SHS_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
	MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				SHA1 = checkBox1.Checked.ToString();
				Properties.Settings.Default.SHA1 = SHA1;

				SHA224 = checkBox2.Checked.ToString();
				Properties.Settings.Default.SHA224 = SHA224;

				SHA256 = checkBox3.Checked.ToString();
				Properties.Settings.Default.SHA256 = SHA256;

				SHA384 = checkBox4.Checked.ToString();
				Properties.Settings.Default.SHA384 = SHA384;

				SHA512 = checkBox5.Checked.ToString();
				Properties.Settings.Default.SHA512 = SHA512;

				SHA512_224 = checkBox6.Checked.ToString();
				Properties.Settings.Default.SHA512_224 = SHA512_224;

				SHA512_256 = checkBox7.Checked.ToString();
				Properties.Settings.Default.SHA512_256 = SHA512_256;

				HASH_ByteOrient = radioButton1.Checked.ToString();
				Properties.Settings.Default.HASH_ByteOrient = HASH_ByteOrient;

				NoNull = radioButton2.Checked.ToString();
				Properties.Settings.Default.NoNull = NoNull;
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