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
	public partial class ECDSA_SigVer : Form
	{
		public static string SV_PCurve_SHA1_192;
		public static string SV_PCurve_SHA224_192;
		public static string SV_PCurve_SHA256_192;
		public static string SV_PCurve_SHA384_192;
		public static string SV_PCurve_SHA512_192;
		public static string SV_PCurve_SHA512_224_192;
		public static string SV_PCurve_SHA512_256_192;
		public static string SV_PCurve_SHA1_224;
		public static string SV_PCurve_SHA224_224;
		public static string SV_PCurve_SHA256_224;
		public static string SV_PCurve_SHA384_224;
		public static string SV_PCurve_SHA512_224;
		public static string SV_PCurve_SHA512_224_224;
		public static string SV_PCurve_SHA512_256_224;
		public static string SV_PCurve_SHA1_256;
		public static string SV_PCurve_SHA224_256;
		public static string SV_PCurve_SHA256_256;
		public static string SV_PCurve_SHA384_256;
		public static string SV_PCurve_SHA512_256;
		public static string SV_PCurve_SHA512_224_256;
		public static string SV_PCurve_SHA512_256_256;
		public static string SV_PCurve_SHA1_384;
		public static string SV_PCurve_SHA224_384;
		public static string SV_PCurve_SHA256_384;
		public static string SV_PCurve_SHA384_384;
		public static string SV_PCurve_SHA512_384;
		public static string SV_PCurve_SHA512_224_384;
		public static string SV_PCurve_SHA512_256_384;
		public static string SV_PCurve_SHA1_521;
		public static string SV_PCurve_SHA224_521;
		public static string SV_PCurve_SHA256_521;
		public static string SV_PCurve_SHA384_521;
		public static string SV_PCurve_SHA512_521;
		public static string SV_PCurve_SHA512_224_521;
		public static string SV_PCurve_SHA512_256_521;

		public static string SV_KCurve_SHA1_163;
		public static string SV_KCurve_SHA224_163;
		public static string SV_KCurve_SHA256_163;
		public static string SV_KCurve_SHA384_163;
		public static string SV_KCurve_SHA512_163;
		public static string SV_KCurve_SHA512_224_163;
		public static string SV_KCurve_SHA512_256_163;
		public static string SV_KCurve_SHA1_233;
		public static string SV_KCurve_SHA224_233;
		public static string SV_KCurve_SHA256_233;
		public static string SV_KCurve_SHA384_233;
		public static string SV_KCurve_SHA512_233;
		public static string SV_KCurve_SHA512_224_233;
		public static string SV_KCurve_SHA512_256_233;
		public static string SV_KCurve_SHA1_283;
		public static string SV_KCurve_SHA224_283;
		public static string SV_KCurve_SHA256_283;
		public static string SV_KCurve_SHA384_283;
		public static string SV_KCurve_SHA512_283;
		public static string SV_KCurve_SHA512_224_283;
		public static string SV_KCurve_SHA512_256_283;
		public static string SV_KCurve_SHA1_409;
		public static string SV_KCurve_SHA224_409;
		public static string SV_KCurve_SHA256_409;
		public static string SV_KCurve_SHA384_409;
		public static string SV_KCurve_SHA512_409;
		public static string SV_KCurve_SHA512_224_409;
		public static string SV_KCurve_SHA512_256_409;
		public static string SV_KCurve_SHA1_571;
		public static string SV_KCurve_SHA224_571;
		public static string SV_KCurve_SHA256_571;
		public static string SV_KCurve_SHA384_571;
		public static string SV_KCurve_SHA512_571;
		public static string SV_KCurve_SHA512_224_571;
		public static string SV_KCurve_SHA512_256_571;

		public static string SV_BCurve_SHA1_163;
		public static string SV_BCurve_SHA224_163;
		public static string SV_BCurve_SHA256_163;
		public static string SV_BCurve_SHA384_163;
		public static string SV_BCurve_SHA512_163;
		public static string SV_BCurve_SHA512_224_163;
		public static string SV_BCurve_SHA512_256_163;
		public static string SV_BCurve_SHA1_233;
		public static string SV_BCurve_SHA224_233;
		public static string SV_BCurve_SHA256_233;
		public static string SV_BCurve_SHA384_233;
		public static string SV_BCurve_SHA512_233;
		public static string SV_BCurve_SHA512_224_233;
		public static string SV_BCurve_SHA512_256_233;
		public static string SV_BCurve_SHA1_283;
		public static string SV_BCurve_SHA224_283;
		public static string SV_BCurve_SHA256_283;
		public static string SV_BCurve_SHA384_283;
		public static string SV_BCurve_SHA512_283;
		public static string SV_BCurve_SHA512_224_283;
		public static string SV_BCurve_SHA512_256_283;
		public static string SV_BCurve_SHA1_409;
		public static string SV_BCurve_SHA224_409;
		public static string SV_BCurve_SHA256_409;
		public static string SV_BCurve_SHA384_409;
		public static string SV_BCurve_SHA512_409;
		public static string SV_BCurve_SHA512_224_409;
		public static string SV_BCurve_SHA512_256_409;
		public static string SV_BCurve_SHA1_571;
		public static string SV_BCurve_SHA224_571;
		public static string SV_BCurve_SHA256_571;
		public static string SV_BCurve_SHA384_571;
		public static string SV_BCurve_SHA512_571;
		public static string SV_BCurve_SHA512_224_571;
		public static string SV_BCurve_SHA512_256_571;

		public static string SV_PCurve;
		public static string SV_KCurve;
		public static string SV_BCurve;

		public ECDSA_SigVer()
		{
			InitializeComponent();

			SV_PCurve = Properties.Settings.Default.SV_PCurve.ToString();
			SV_KCurve = Properties.Settings.Default.SV_KCurve.ToString();
			SV_BCurve = Properties.Settings.Default.SV_BCurve.ToString();


			SV_PCurve_SHA1_192 = Properties.Settings.Default.SV_PCurve_SHA1_192.ToString();
			SV_PCurve_SHA224_192 = Properties.Settings.Default.SV_PCurve_SHA224_192.ToString();
			SV_PCurve_SHA256_192 = Properties.Settings.Default.SV_PCurve_SHA256_192.ToString();
			SV_PCurve_SHA384_192 = Properties.Settings.Default.SV_PCurve_SHA384_192.ToString();
			SV_PCurve_SHA512_192 = Properties.Settings.Default.SV_PCurve_SHA512_192.ToString();
			SV_PCurve_SHA512_224_192 = Properties.Settings.Default.SV_PCurve_SHA512_224_192.ToString();
			SV_PCurve_SHA512_256_192 = Properties.Settings.Default.SV_PCurve_SHA512_256_192.ToString();
			SV_PCurve_SHA1_224   = Properties.Settings.Default.SV_PCurve_SHA1_224.ToString();
			SV_PCurve_SHA224_224 = Properties.Settings.Default.SV_PCurve_SHA224_224.ToString();
			SV_PCurve_SHA256_224 = Properties.Settings.Default.SV_PCurve_SHA256_224.ToString();
			SV_PCurve_SHA384_224 = Properties.Settings.Default.SV_PCurve_SHA384_224.ToString();
			SV_PCurve_SHA512_224 = Properties.Settings.Default.SV_PCurve_SHA512_224.ToString();
			SV_PCurve_SHA512_224_224 = Properties.Settings.Default.SV_PCurve_SHA512_224_224.ToString();
			SV_PCurve_SHA512_256_224 = Properties.Settings.Default.SV_PCurve_SHA512_256_224.ToString();
			SV_PCurve_SHA1_256 = Properties.Settings.Default.SV_PCurve_SHA1_256.ToString();
			SV_PCurve_SHA224_256 = Properties.Settings.Default.SV_PCurve_SHA224_256.ToString();
			SV_PCurve_SHA256_256 = Properties.Settings.Default.SV_PCurve_SHA256_256.ToString();
			SV_PCurve_SHA384_256 = Properties.Settings.Default.SV_PCurve_SHA384_256.ToString();
			SV_PCurve_SHA512_256 = Properties.Settings.Default.SV_PCurve_SHA512_256.ToString();
			SV_PCurve_SHA512_224_256 = Properties.Settings.Default.SV_PCurve_SHA512_224_256.ToString();
			SV_PCurve_SHA512_256_256 = Properties.Settings.Default.SV_PCurve_SHA512_256_256.ToString();
			SV_PCurve_SHA1_384 = Properties.Settings.Default.SV_PCurve_SHA1_384.ToString();
			SV_PCurve_SHA224_384 = Properties.Settings.Default.SV_PCurve_SHA224_384.ToString();
			SV_PCurve_SHA256_384 = Properties.Settings.Default.SV_PCurve_SHA256_384.ToString();
			SV_PCurve_SHA384_384 = Properties.Settings.Default.SV_PCurve_SHA384_384.ToString();
			SV_PCurve_SHA512_384 = Properties.Settings.Default.SV_PCurve_SHA512_384.ToString();
			SV_PCurve_SHA512_224_384 = Properties.Settings.Default.SV_PCurve_SHA512_224_384.ToString();
			SV_PCurve_SHA512_256_384 = Properties.Settings.Default.SV_PCurve_SHA512_256_384.ToString();
			SV_PCurve_SHA1_521 = Properties.Settings.Default.SV_PCurve_SHA1_521.ToString();
			SV_PCurve_SHA224_521 = Properties.Settings.Default.SV_PCurve_SHA224_521.ToString();
			SV_PCurve_SHA256_521 = Properties.Settings.Default.SV_PCurve_SHA256_521.ToString();
			SV_PCurve_SHA384_521 = Properties.Settings.Default.SV_PCurve_SHA384_521.ToString();
			SV_PCurve_SHA512_521 = Properties.Settings.Default.SV_PCurve_SHA512_521.ToString();
			SV_PCurve_SHA512_224_521 = Properties.Settings.Default.SV_PCurve_SHA512_224_521.ToString();
			SV_PCurve_SHA512_256_521 = Properties.Settings.Default.SV_PCurve_SHA512_256_521.ToString();

			if (SV_PCurve == "True")
			{
				checkBox27.Checked = true;
			}

			if (SV_KCurve == "True")
			{
				checkBox2.Checked = true;
			}

			if (SV_BCurve == "True")
			{
				checkBox3.Checked = true;
			}

			if (SV_PCurve_SHA1_192 == "True")
			{
				checkBox94.Checked = true;
			}

			if (SV_PCurve_SHA224_192 == "True")
			{
				checkBox93.Checked = true;
			}

			if (SV_PCurve_SHA256_192 == "True")
			{
				checkBox92.Checked = true;
			}

			if (SV_PCurve_SHA384_192 == "True")
			{
				checkBox91.Checked = true;
			}

			if (SV_PCurve_SHA512_192 == "True")
			{
				checkBox90.Checked = true;
			}

			if (SV_PCurve_SHA512_224_192 == "True")
			{
				checkBox89.Checked = true;
			}

			if (SV_PCurve_SHA512_256_192 == "True")
			{
				checkBox88.Checked = true;
			}

			if (SV_PCurve_SHA1_224 == "True")
			{
				checkBox1.Checked = true;
			}

			if (SV_PCurve_SHA224_224 == "True")
			{
				checkBox4.Checked = true;
			}

			if (SV_PCurve_SHA256_224 == "True")
			{
				checkBox5.Checked = true;
			}

			if (SV_PCurve_SHA384_224 == "True")
			{
				checkBox6.Checked = true;
			}

			if (SV_PCurve_SHA512_224 == "True")
			{
				checkBox7.Checked = true;
			}

			if (SV_PCurve_SHA512_224_224 == "True")
			{
				checkBox8.Checked = true;
			}

			if (SV_PCurve_SHA512_256_224 == "True")
			{
				checkBox9.Checked = true;
			}

			if (SV_PCurve_SHA1_256 == "True")
			{
				checkBox16.Checked = true;
			}

			if (SV_PCurve_SHA224_256 == "True")
			{
				checkBox15.Checked = true;
			}

			if (SV_PCurve_SHA256_256 == "True")
			{
				checkBox14.Checked = true;
			}

			if (SV_PCurve_SHA384_256 == "True")
			{
				checkBox13.Checked = true;
			}

			if (SV_PCurve_SHA512_256 == "True")
			{
				checkBox12.Checked = true;
			}

			if (SV_PCurve_SHA512_224_256 == "True")
			{
				checkBox11.Checked = true;
			}

			if (SV_PCurve_SHA512_256_256 == "True")
			{
				checkBox10.Checked = true;
			}

			if (SV_PCurve_SHA1_384 == "True")
			{
				checkBox23.Checked = true;
			}

			if (SV_PCurve_SHA224_384 == "True")
			{
				checkBox22.Checked = true;
			}

			if (SV_PCurve_SHA256_384 == "True")
			{
				checkBox21.Checked = true;
			}

			if (SV_PCurve_SHA384_384 == "True")
			{
				checkBox20.Checked = true;
			}

			if (SV_PCurve_SHA512_384 == "True")
			{
				checkBox19.Checked = true;
			}

			if (SV_PCurve_SHA512_224_384 == "True")
			{
				checkBox18.Checked = true;
			}

			if (SV_PCurve_SHA512_256_384 == "True")
			{
				checkBox17.Checked = true;
			}

			if (SV_PCurve_SHA1_521 == "True")
			{
				checkBox31.Checked = true;
			}

			if (SV_PCurve_SHA224_521 == "True")
			{
				checkBox30.Checked = true;
			}

			if (SV_PCurve_SHA256_521 == "True")
			{
				checkBox29.Checked = true;
			}

			if (SV_PCurve_SHA384_521 == "True")
			{
				checkBox28.Checked = true;
			}

			if (SV_PCurve_SHA512_521 == "True")
			{
				checkBox26.Checked = true;
			}

			if (SV_PCurve_SHA512_224_521 == "True")
			{
				checkBox25.Checked = true;
			}

			if (SV_PCurve_SHA512_256_521 == "True")
			{
				checkBox24.Checked = true;
			}

			SV_KCurve_SHA1_163 = Properties.Settings.Default.SV_KCurve_SHA1_163.ToString();
			SV_KCurve_SHA224_163 = Properties.Settings.Default.SV_KCurve_SHA224_163.ToString();
			SV_KCurve_SHA256_163 = Properties.Settings.Default.SV_KCurve_SHA256_163.ToString();
			SV_KCurve_SHA384_163 = Properties.Settings.Default.SV_KCurve_SHA384_163.ToString();
			SV_KCurve_SHA512_163 = Properties.Settings.Default.SV_KCurve_SHA512_163.ToString();
			SV_KCurve_SHA512_224_163 = Properties.Settings.Default.SV_KCurve_SHA512_224_163.ToString();
			SV_KCurve_SHA512_256_163 = Properties.Settings.Default.SV_KCurve_SHA512_256_163.ToString();
			SV_KCurve_SHA1_233 = Properties.Settings.Default.SV_KCurve_SHA1_233.ToString();
			SV_KCurve_SHA224_233 = Properties.Settings.Default.SV_KCurve_SHA224_233.ToString();
			SV_KCurve_SHA256_233 = Properties.Settings.Default.SV_KCurve_SHA256_233.ToString();
			SV_KCurve_SHA384_233 = Properties.Settings.Default.SV_KCurve_SHA384_233.ToString();
			SV_KCurve_SHA512_233 = Properties.Settings.Default.SV_KCurve_SHA512_233.ToString();
			SV_KCurve_SHA512_224_233 = Properties.Settings.Default.SV_KCurve_SHA512_224_233.ToString();
			SV_KCurve_SHA512_256_233 = Properties.Settings.Default.SV_KCurve_SHA512_256_233.ToString();
			SV_KCurve_SHA1_283 = Properties.Settings.Default.SV_KCurve_SHA1_283.ToString();
			SV_KCurve_SHA224_283 = Properties.Settings.Default.SV_KCurve_SHA224_283.ToString();
			SV_KCurve_SHA256_283 = Properties.Settings.Default.SV_KCurve_SHA256_283.ToString();
			SV_KCurve_SHA384_283 = Properties.Settings.Default.SV_KCurve_SHA384_283.ToString();
			SV_KCurve_SHA512_283 = Properties.Settings.Default.SV_KCurve_SHA512_283.ToString();
			SV_KCurve_SHA512_224_283 = Properties.Settings.Default.SV_KCurve_SHA512_224_283.ToString();
			SV_KCurve_SHA512_256_283 = Properties.Settings.Default.SV_KCurve_SHA512_256_283.ToString();
			SV_KCurve_SHA1_409 = Properties.Settings.Default.SV_KCurve_SHA1_409.ToString();
			SV_KCurve_SHA224_409 = Properties.Settings.Default.SV_KCurve_SHA224_409.ToString();
			SV_KCurve_SHA256_409 = Properties.Settings.Default.SV_KCurve_SHA256_409.ToString();
			SV_KCurve_SHA384_409 = Properties.Settings.Default.SV_KCurve_SHA384_409.ToString();
			SV_KCurve_SHA512_409 = Properties.Settings.Default.SV_KCurve_SHA512_409.ToString();
			SV_KCurve_SHA512_224_409 = Properties.Settings.Default.SV_KCurve_SHA512_224_409.ToString();
			SV_KCurve_SHA512_256_409 = Properties.Settings.Default.SV_KCurve_SHA512_256_409.ToString();
			SV_KCurve_SHA1_571 = Properties.Settings.Default.SV_KCurve_SHA1_571.ToString();
			SV_KCurve_SHA224_571 = Properties.Settings.Default.SV_KCurve_SHA224_571.ToString();
			SV_KCurve_SHA256_571 = Properties.Settings.Default.SV_KCurve_SHA256_571.ToString();
			SV_KCurve_SHA384_571 = Properties.Settings.Default.SV_KCurve_SHA384_571.ToString();
			SV_KCurve_SHA512_571 = Properties.Settings.Default.SV_KCurve_SHA512_571.ToString();
			SV_KCurve_SHA512_224_571 = Properties.Settings.Default.SV_KCurve_SHA512_224_571.ToString();
			SV_KCurve_SHA512_256_571 = Properties.Settings.Default.SV_KCurve_SHA512_256_571.ToString();

			if (SV_KCurve_SHA1_163 == "True")
			{
				checkBox101.Checked = true;
			}

			if (SV_KCurve_SHA224_163 == "True")
			{
				checkBox100.Checked = true;
			}

			if (SV_KCurve_SHA256_163 == "True")
			{
				checkBox99.Checked = true;
			}

			if (SV_KCurve_SHA384_163 == "True")
			{
				checkBox98.Checked = true;
			}

			if (SV_KCurve_SHA512_163 == "True")
			{
				checkBox97.Checked = true;
			}

			if (SV_KCurve_SHA512_224_163 == "True")
			{
				checkBox96.Checked = true;
			}

			if (SV_KCurve_SHA512_256_163 == "True")
			{
				checkBox95.Checked = true;
			}

			if (SV_KCurve_SHA1_233 == "True")
			{
				checkBox59.Checked = true;
			}

			if (SV_KCurve_SHA224_233 == "True")
			{
				checkBox58.Checked = true;
			}

			if (SV_KCurve_SHA256_233 == "True")
			{
				checkBox57.Checked = true;
			}

			if (SV_KCurve_SHA384_233 == "True")
			{
				checkBox56.Checked = true;
			}

			if (SV_KCurve_SHA512_233 == "True")
			{
				checkBox55.Checked = true;
			}

			if (SV_KCurve_SHA512_224_233 == "True")
			{
				checkBox54.Checked = true;
			}

			if (SV_KCurve_SHA512_256_233 == "True")
			{
				checkBox53.Checked = true;
			}

			if (SV_KCurve_SHA1_283 == "True")
			{
				checkBox52.Checked = true;
			}

			if (SV_KCurve_SHA224_283 == "True")
			{
				checkBox51.Checked = true;
			}

			if (SV_KCurve_SHA256_283 == "True")
			{
				checkBox50.Checked = true;
			}

			if (SV_KCurve_SHA384_283 == "True")
			{
				checkBox49.Checked = true;
			}

			if (SV_KCurve_SHA512_283 == "True")
			{
				checkBox48.Checked = true;
			}

			if (SV_KCurve_SHA512_224_283 == "True")
			{
				checkBox47.Checked = true;
			}

			if (SV_KCurve_SHA512_256_283 == "True")
			{
				checkBox46.Checked = true;
			}

			if (SV_KCurve_SHA1_409 == "True")
			{
				checkBox45.Checked = true;
			}

			if (SV_KCurve_SHA224_409 == "True")
			{
				checkBox44.Checked = true;
			}

			if (SV_KCurve_SHA256_409 == "True")
			{
				checkBox43.Checked = true;
			}

			if (SV_KCurve_SHA384_409 == "True")
			{
				checkBox42.Checked = true;
			}

			if (SV_KCurve_SHA512_409 == "True")
			{
				checkBox41.Checked = true;
			}

			if (SV_KCurve_SHA512_224_409 == "True")
			{
				checkBox40.Checked = true;
			}

			if (SV_KCurve_SHA512_256_409 == "True")
			{
				checkBox39.Checked = true;
			}

			if (SV_KCurve_SHA1_571 == "True")
			{
				checkBox38.Checked = true;
			}

			if (SV_KCurve_SHA224_571 == "True")
			{
				checkBox37.Checked = true;
			}

			if (SV_KCurve_SHA256_571 == "True")
			{
				checkBox36.Checked = true;
			}

			if (SV_KCurve_SHA384_571 == "True")
			{
				checkBox35.Checked = true;
			}

			if (SV_KCurve_SHA512_571 == "True")
			{
				checkBox34.Checked = true;
			}

			if (SV_KCurve_SHA512_224_571 == "True")
			{
				checkBox33.Checked = true;
			}

			if (SV_KCurve_SHA512_256_571 == "True")
			{
				checkBox32.Checked = true;
			}

			SV_BCurve_SHA1_163 = Properties.Settings.Default.SV_BCurve_SHA1_163.ToString();
			SV_BCurve_SHA224_163 = Properties.Settings.Default.SV_BCurve_SHA224_163.ToString();
			SV_BCurve_SHA256_163 = Properties.Settings.Default.SV_BCurve_SHA256_163.ToString();
			SV_BCurve_SHA384_163 = Properties.Settings.Default.SV_BCurve_SHA384_163.ToString();
			SV_BCurve_SHA512_163 = Properties.Settings.Default.SV_BCurve_SHA512_163.ToString();
			SV_BCurve_SHA512_224_163 = Properties.Settings.Default.SV_BCurve_SHA512_224_163.ToString();
			SV_BCurve_SHA512_256_163 = Properties.Settings.Default.SV_BCurve_SHA512_256_163.ToString();
			SV_BCurve_SHA1_233 = Properties.Settings.Default.SV_BCurve_SHA1_233.ToString();
			SV_BCurve_SHA224_233 = Properties.Settings.Default.SV_BCurve_SHA224_233.ToString();
			SV_BCurve_SHA256_233 = Properties.Settings.Default.SV_BCurve_SHA256_233.ToString();
			SV_BCurve_SHA384_233 = Properties.Settings.Default.SV_BCurve_SHA384_233.ToString();
			SV_BCurve_SHA512_233 = Properties.Settings.Default.SV_BCurve_SHA512_233.ToString();
			SV_BCurve_SHA512_224_233 = Properties.Settings.Default.SV_BCurve_SHA512_224_233.ToString();
			SV_BCurve_SHA512_256_233 = Properties.Settings.Default.SV_BCurve_SHA512_256_233.ToString();
			SV_BCurve_SHA1_283 = Properties.Settings.Default.SV_BCurve_SHA1_283.ToString();
			SV_BCurve_SHA224_283 = Properties.Settings.Default.SV_BCurve_SHA224_283.ToString();
			SV_BCurve_SHA256_283 = Properties.Settings.Default.SV_BCurve_SHA256_283.ToString();
			SV_BCurve_SHA384_283 = Properties.Settings.Default.SV_BCurve_SHA384_283.ToString();
			SV_BCurve_SHA512_283 = Properties.Settings.Default.SV_BCurve_SHA512_283.ToString();
			SV_BCurve_SHA512_224_283 = Properties.Settings.Default.SV_BCurve_SHA512_224_283.ToString();
			SV_BCurve_SHA512_256_283 = Properties.Settings.Default.SV_BCurve_SHA512_256_283.ToString();
			SV_BCurve_SHA1_409 = Properties.Settings.Default.SV_BCurve_SHA1_409.ToString();
			SV_BCurve_SHA224_409 = Properties.Settings.Default.SV_BCurve_SHA224_409.ToString();
			SV_BCurve_SHA256_409 = Properties.Settings.Default.SV_BCurve_SHA256_409.ToString();
			SV_BCurve_SHA384_409 = Properties.Settings.Default.SV_BCurve_SHA384_409.ToString();
			SV_BCurve_SHA512_409 = Properties.Settings.Default.SV_BCurve_SHA512_409.ToString();
			SV_BCurve_SHA512_224_409 = Properties.Settings.Default.SV_BCurve_SHA512_224_409.ToString();
			SV_BCurve_SHA512_256_409 = Properties.Settings.Default.SV_BCurve_SHA512_256_409.ToString();
			SV_BCurve_SHA1_571 = Properties.Settings.Default.SV_BCurve_SHA1_571.ToString();
			SV_BCurve_SHA224_571 = Properties.Settings.Default.SV_BCurve_SHA224_571.ToString();
			SV_BCurve_SHA256_571 = Properties.Settings.Default.SV_BCurve_SHA256_571.ToString();
			SV_BCurve_SHA384_571 = Properties.Settings.Default.SV_BCurve_SHA384_571.ToString();
			SV_BCurve_SHA512_571 = Properties.Settings.Default.SV_BCurve_SHA512_571.ToString();
			SV_BCurve_SHA512_224_571 = Properties.Settings.Default.SV_BCurve_SHA512_224_571.ToString();
			SV_BCurve_SHA512_256_571 = Properties.Settings.Default.SV_BCurve_SHA512_256_571.ToString();


			if (SV_BCurve_SHA1_163 == "True")
			{
				checkBox108.Checked = true;
			}

			if (SV_BCurve_SHA224_163 == "True")
			{
				checkBox107.Checked = true;
			}

			if (SV_BCurve_SHA256_163 == "True")
			{
				checkBox106.Checked = true;
			}

			if (SV_BCurve_SHA384_163 == "True")
			{
				checkBox105.Checked = true;
			}

			if (SV_BCurve_SHA512_163 == "True")
			{
				checkBox104.Checked = true;
			}

			if (SV_BCurve_SHA512_224_163 == "True")
			{
				checkBox103.Checked = true;
			}

			if (SV_BCurve_SHA512_256_163 == "True")
			{
				checkBox102.Checked = true;
			}

			if (SV_BCurve_SHA1_233 == "True")
			{
				checkBox87.Checked = true;
			}

			if (SV_BCurve_SHA224_233 == "True")
			{
				checkBox86.Checked = true;
			}

			if (SV_BCurve_SHA256_233 == "True")
			{
				checkBox85.Checked = true;
			}

			if (SV_BCurve_SHA384_233 == "True")
			{
				checkBox84.Checked = true;
			}

			if (SV_BCurve_SHA512_233 == "True")
			{
				checkBox83.Checked = true;
			}

			if (SV_BCurve_SHA512_224_233 == "True")
			{
				checkBox82.Checked = true;
			}

			if (SV_BCurve_SHA512_256_233 == "True")
			{
				checkBox81.Checked = true;
			}

			if (SV_BCurve_SHA1_283 == "True")
			{
				checkBox80.Checked = true;
			}

			if (SV_BCurve_SHA224_283 == "True")
			{
				checkBox79.Checked = true;
			}

			if (SV_BCurve_SHA256_283 == "True")
			{
				checkBox78.Checked = true;
			}

			if (SV_BCurve_SHA384_283 == "True")
			{
				checkBox77.Checked = true;
			}

			if (SV_BCurve_SHA512_283 == "True")
			{
				checkBox76.Checked = true;
			}

			if (SV_BCurve_SHA512_224_283 == "True")
			{
				checkBox75.Checked = true;
			}

			if (SV_BCurve_SHA512_256_283 == "True")
			{
				checkBox74.Checked = true;
			}

			if (SV_BCurve_SHA1_409 == "True")
			{
				checkBox73.Checked = true;
			}

			if (SV_BCurve_SHA224_409 == "True")
			{
				checkBox72.Checked = true;
			}

			if (SV_BCurve_SHA256_409 == "True")
			{
				checkBox71.Checked = true;
			}

			if (SV_BCurve_SHA384_409 == "True")
			{
				checkBox70.Checked = true;
			}

			if (SV_BCurve_SHA512_409 == "True")
			{
				checkBox69.Checked = true;
			}

			if (SV_BCurve_SHA512_224_409 == "True")
			{
				checkBox68.Checked = true;
			}

			if (SV_BCurve_SHA512_256_409 == "True")
			{
				checkBox67.Checked = true;
			}

			if (SV_BCurve_SHA1_571 == "True")
			{
				checkBox66.Checked = true;
			}

			if (SV_BCurve_SHA224_571 == "True")
			{
				checkBox65.Checked = true;
			}

			if (SV_BCurve_SHA256_571 == "True")
			{
				checkBox64.Checked = true;
			}

			if (SV_BCurve_SHA384_571 == "True")
			{
				checkBox63.Checked = true;
			}

			if (SV_BCurve_SHA512_571 == "True")
			{
				checkBox62.Checked = true;
			}

			if (SV_BCurve_SHA512_224_571 == "True")
			{
				checkBox61.Checked = true;
			}

			if (SV_BCurve_SHA512_256_571 == "True")
			{
				checkBox60.Checked = true;
			}

		}

		private void ECDSA_SigVer_Load(object sender, EventArgs e)
		{

		}

		private void ECDSA_SigGen_PCurve_Click(object sender, EventArgs e)
		{

		}

		private void checkBox73_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void ECDSA_SigVer_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				SV_PCurve = checkBox27.Checked.ToString();
				Properties.Settings.Default.SV_PCurve = SV_PCurve;

				SV_KCurve = checkBox2.Checked.ToString();
				Properties.Settings.Default.SV_KCurve = SV_KCurve;

				SV_BCurve = checkBox3.Checked.ToString();
				Properties.Settings.Default.SV_BCurve = SV_BCurve;

				SV_PCurve_SHA1_192 = checkBox94.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA1_192 = SV_PCurve_SHA1_192;

				SV_PCurve_SHA224_192 = checkBox93.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA224_192 = SV_PCurve_SHA224_192;

				SV_PCurve_SHA256_192 = checkBox92.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA256_192 = SV_PCurve_SHA256_192;

				SV_PCurve_SHA384_192 = checkBox91.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA384_192 = SV_PCurve_SHA384_192;

				SV_PCurve_SHA512_192 = checkBox90.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA512_192 = SV_PCurve_SHA512_192;

				SV_PCurve_SHA512_224_192 = checkBox89.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA512_224_192 = SV_PCurve_SHA512_224_192;

				SV_PCurve_SHA512_256_192 = checkBox88.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA512_256_192 = SV_PCurve_SHA512_256_192;

				SV_PCurve_SHA1_224 = checkBox1.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA1_224 = SV_PCurve_SHA1_224;

				SV_PCurve_SHA224_224 = checkBox4.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA224_224 = SV_PCurve_SHA224_224;

				SV_PCurve_SHA256_224 = checkBox5.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA256_224 = SV_PCurve_SHA256_224;

				SV_PCurve_SHA384_224 = checkBox6.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA384_224 = SV_PCurve_SHA384_224;

				SV_PCurve_SHA512_224 = checkBox7.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA512_224 = SV_PCurve_SHA512_224;

				SV_PCurve_SHA512_224_224 = checkBox8.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA512_224_224 = SV_PCurve_SHA512_224_224;

				SV_PCurve_SHA512_256_224 = checkBox9.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA512_256_224 = SV_PCurve_SHA512_256_224;

				SV_PCurve_SHA1_256 = checkBox16.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA1_256 = SV_PCurve_SHA1_256;

				SV_PCurve_SHA224_256 = checkBox15.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA224_256 = SV_PCurve_SHA224_256;

				SV_PCurve_SHA256_256 = checkBox14.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA256_256 = SV_PCurve_SHA256_256;

				SV_PCurve_SHA384_256 = checkBox13.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA384_256 = SV_PCurve_SHA384_256;

				SV_PCurve_SHA512_256 = checkBox12.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA512_256 = SV_PCurve_SHA512_256;

				SV_PCurve_SHA512_224_256 = checkBox11.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA512_224_256 = SV_PCurve_SHA512_224_256;

				SV_PCurve_SHA512_256_256 = checkBox10.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA512_256_256 = SV_PCurve_SHA512_256_256;

				SV_PCurve_SHA1_384 = checkBox23.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA1_384 = SV_PCurve_SHA1_384;

				SV_PCurve_SHA224_384 = checkBox22.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA224_384 = SV_PCurve_SHA224_384;

				SV_PCurve_SHA256_384 = checkBox21.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA256_384 = SV_PCurve_SHA256_384;

				SV_PCurve_SHA384_384 = checkBox20.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA384_384 = SV_PCurve_SHA384_384;

				SV_PCurve_SHA512_384 = checkBox19.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA512_384 = SV_PCurve_SHA512_384;

				SV_PCurve_SHA512_224_384 = checkBox18.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA512_224_384 = SV_PCurve_SHA512_224_384;

				SV_PCurve_SHA512_256_384 = checkBox17.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA512_256_384 = SV_PCurve_SHA512_256_384;

				SV_PCurve_SHA1_521 = checkBox31.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA1_521 = SV_PCurve_SHA1_521;

				SV_PCurve_SHA224_521 = checkBox30.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA224_521 = SV_PCurve_SHA224_521;

				SV_PCurve_SHA256_521 = checkBox29.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA256_521 = SV_PCurve_SHA256_521;

				SV_PCurve_SHA384_521 = checkBox28.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA384_521 = SV_PCurve_SHA384_521;

				SV_PCurve_SHA512_521 = checkBox26.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA512_521 = SV_PCurve_SHA512_521;

				SV_PCurve_SHA512_224_521 = checkBox25.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA512_224_521 = SV_PCurve_SHA512_224_521;

				SV_PCurve_SHA512_256_521 = checkBox24.Checked.ToString();
				Properties.Settings.Default.SV_PCurve_SHA512_256_521 = SV_PCurve_SHA512_256_521;

				SV_KCurve_SHA1_163 = checkBox101.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA1_163 = SV_KCurve_SHA1_163;

				SV_KCurve_SHA224_163 = checkBox100.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA224_163 = SV_KCurve_SHA224_163;

				SV_KCurve_SHA256_163 = checkBox99.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA256_163 = SV_KCurve_SHA256_163;

				SV_KCurve_SHA384_163 = checkBox98.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA384_163 = SV_KCurve_SHA384_163;

				SV_KCurve_SHA512_163 = checkBox97.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA512_163 = SV_KCurve_SHA512_163;

				SV_KCurve_SHA512_224_163 = checkBox96.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA512_224_163 = SV_KCurve_SHA512_224_163;

				SV_KCurve_SHA512_256_163 = checkBox95.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA512_256_163 = SV_KCurve_SHA512_256_163;

				SV_KCurve_SHA1_233 = checkBox59.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA1_233 = SV_KCurve_SHA1_233;

				SV_KCurve_SHA224_233 = checkBox58.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA224_233 = SV_KCurve_SHA224_233;

				SV_KCurve_SHA256_233 = checkBox57.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA256_233 = SV_KCurve_SHA256_233;

				SV_KCurve_SHA384_233 = checkBox56.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA384_233 = SV_KCurve_SHA384_233;

				SV_KCurve_SHA512_233 = checkBox55.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA512_233 = SV_KCurve_SHA512_233;

				SV_KCurve_SHA512_224_233 = checkBox54.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA512_224_233 = SV_KCurve_SHA512_224_233;

				SV_KCurve_SHA512_256_233 = checkBox53.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA512_256_233 = SV_KCurve_SHA512_256_233;

				SV_KCurve_SHA1_283 = checkBox52.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA1_283 = SV_KCurve_SHA1_283;

				SV_KCurve_SHA224_283 = checkBox51.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA224_283 = SV_KCurve_SHA224_283;

				SV_KCurve_SHA256_283 = checkBox50.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA256_283 = SV_KCurve_SHA256_283;

				SV_KCurve_SHA384_283 = checkBox49.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA384_283 = SV_KCurve_SHA384_283;

				SV_KCurve_SHA512_283 = checkBox48.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA512_283 = SV_KCurve_SHA512_283;

				SV_KCurve_SHA512_224_283 = checkBox47.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA512_224_283 = SV_KCurve_SHA512_224_283;

				SV_KCurve_SHA512_256_283 = checkBox46.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA512_256_283 = SV_KCurve_SHA512_256_283;

				SV_KCurve_SHA1_409 = checkBox45.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA1_409 = SV_KCurve_SHA1_409;

				SV_KCurve_SHA224_409 = checkBox44.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA224_409 = SV_KCurve_SHA224_409;

				SV_KCurve_SHA256_409 = checkBox43.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA256_409 = SV_KCurve_SHA256_409;

				SV_KCurve_SHA384_409 = checkBox42.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA384_409 = SV_KCurve_SHA384_409;

				SV_KCurve_SHA512_409 = checkBox41.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA512_409 = SV_KCurve_SHA512_409;

				SV_KCurve_SHA512_224_409 = checkBox40.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA512_224_409 = SV_KCurve_SHA512_224_409;

				SV_KCurve_SHA512_256_409 = checkBox39.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA512_256_409 = SV_KCurve_SHA512_256_409;

				SV_KCurve_SHA1_571 = checkBox38.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA1_571 = SV_KCurve_SHA1_571;

				SV_KCurve_SHA224_571 = checkBox37.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA224_571 = SV_KCurve_SHA224_571;

				SV_KCurve_SHA256_571 = checkBox36.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA256_571 = SV_KCurve_SHA256_571;

				SV_KCurve_SHA384_571 = checkBox35.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA384_571 = SV_KCurve_SHA384_571;

				SV_KCurve_SHA512_571 = checkBox34.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA512_571 = SV_KCurve_SHA512_571;

				SV_KCurve_SHA512_224_571 = checkBox33.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA512_224_571 = SV_KCurve_SHA512_224_571;

				SV_KCurve_SHA512_256_571 = checkBox32.Checked.ToString();
				Properties.Settings.Default.SV_KCurve_SHA512_256_571 = SV_KCurve_SHA512_256_571;

				SV_BCurve_SHA1_163 = checkBox108.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA1_163 = SV_BCurve_SHA1_163;

				SV_BCurve_SHA224_163 = checkBox107.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA224_163 = SV_BCurve_SHA224_163;

				SV_BCurve_SHA256_163 = checkBox106.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA256_163 = SV_BCurve_SHA256_163;

				SV_BCurve_SHA384_163 = checkBox105.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA384_163 = SV_BCurve_SHA384_163;

				SV_BCurve_SHA512_163 = checkBox104.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA512_163 = SV_BCurve_SHA512_163;

				SV_BCurve_SHA512_224_163 = checkBox103.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA512_224_163 = SV_BCurve_SHA512_224_163;

				SV_BCurve_SHA512_256_163 = checkBox102.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA512_256_163 = SV_BCurve_SHA512_256_163;

				SV_BCurve_SHA1_233 = checkBox87.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA1_233 = SV_BCurve_SHA1_233;

				SV_BCurve_SHA224_233 = checkBox86.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA224_233 = SV_BCurve_SHA224_233;

				SV_BCurve_SHA256_233 = checkBox85.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA256_233 = SV_BCurve_SHA256_233;

				SV_BCurve_SHA384_233 = checkBox84.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA384_233 = SV_BCurve_SHA384_233;

				SV_BCurve_SHA512_233 = checkBox83.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA512_233 = SV_BCurve_SHA512_233;

				SV_BCurve_SHA512_224_233 = checkBox82.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA512_224_233 = SV_BCurve_SHA512_224_233;

				SV_BCurve_SHA512_256_233 = checkBox81.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA512_256_233 = SV_BCurve_SHA512_256_233;

				SV_BCurve_SHA1_283 = checkBox80.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA1_283 = SV_BCurve_SHA1_283;

				SV_BCurve_SHA224_283 = checkBox79.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA224_283 = SV_BCurve_SHA224_283;

				SV_BCurve_SHA256_283 = checkBox78.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA256_283 = SV_BCurve_SHA256_283;

				SV_BCurve_SHA384_283 = checkBox77.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA384_283 = SV_BCurve_SHA384_283;

				SV_BCurve_SHA512_283 = checkBox76.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA512_283 = SV_BCurve_SHA512_283;

				SV_BCurve_SHA512_224_283 = checkBox75.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA512_224_283 = SV_BCurve_SHA512_224_283;

				SV_BCurve_SHA512_256_283 = checkBox74.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA512_256_283 = SV_BCurve_SHA512_256_283;

				SV_BCurve_SHA1_409 = checkBox73.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA1_409 = SV_BCurve_SHA1_409;

				SV_BCurve_SHA224_409 = checkBox72.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA224_409 = SV_BCurve_SHA224_409;

				SV_BCurve_SHA256_409 = checkBox71.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA256_409 = SV_BCurve_SHA256_409;

				SV_BCurve_SHA384_409 = checkBox70.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA384_409 = SV_BCurve_SHA384_409;

				SV_BCurve_SHA512_409 = checkBox69.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA512_409 = SV_BCurve_SHA512_409;

				SV_BCurve_SHA512_224_409 = checkBox68.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA512_224_409 = SV_BCurve_SHA512_224_409;

				SV_BCurve_SHA512_256_409 = checkBox67.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA512_256_409 = SV_BCurve_SHA512_256_409;

				SV_BCurve_SHA1_571 = checkBox66.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA1_571 = SV_BCurve_SHA1_571;

				SV_BCurve_SHA224_571 = checkBox65.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA224_571 = SV_BCurve_SHA224_571;

				SV_BCurve_SHA256_571 = checkBox64.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA256_571 = SV_BCurve_SHA256_571;

				SV_BCurve_SHA384_571 = checkBox63.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA384_571 = SV_BCurve_SHA384_571;

				SV_BCurve_SHA512_571 = checkBox62.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA512_571 = SV_BCurve_SHA512_571;

				SV_BCurve_SHA512_224_571 = checkBox61.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA512_224_571 = SV_BCurve_SHA512_224_571;

				SV_BCurve_SHA512_256_571 = checkBox60.Checked.ToString();
				Properties.Settings.Default.SV_BCurve_SHA512_256_571 = SV_BCurve_SHA512_256_571;

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

		private void checkBox27_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox27.Checked == true)
			{
				tabControl1.SelectedTab = ECDSA_SigGen_PCurve;
			}
			else if (checkBox27.Checked == false)
			{				
				checkBox27.Checked = false;
				checkBox2.Checked = false;		
				checkBox3.Checked = false;
				checkBox94.Checked = false;			
				checkBox93.Checked = false;				
				checkBox92.Checked = false;			
				checkBox91.Checked = false;			
				checkBox90.Checked = false;		
				checkBox89.Checked = false;				
				checkBox88.Checked = false;				
				checkBox1.Checked = false;			
				checkBox4.Checked = false;				
				checkBox5.Checked = false;				
				checkBox6.Checked = false;
				checkBox7.Checked = false;
				checkBox8.Checked = false;			
				checkBox9.Checked = false;			
				checkBox16.Checked = false;				
				checkBox15.Checked = false;				
				checkBox14.Checked = false;				
				checkBox13.Checked = false;
				checkBox12.Checked = false;			
				checkBox11.Checked = false;
				checkBox10.Checked = false;			
				checkBox23.Checked = false;				
				checkBox22.Checked = false;				
				checkBox21.Checked = false;					
				checkBox20.Checked = false;
				checkBox19.Checked = false;		
				checkBox18.Checked = false;				
				checkBox17.Checked = false;
				checkBox31.Checked = false;			
				checkBox30.Checked = false;
				checkBox29.Checked = false;
				checkBox28.Checked = false;			
				checkBox26.Checked = false;
				checkBox25.Checked = false;			
				checkBox24.Checked = false;				
			}
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked == true)
			{
				tabControl1.SelectedTab = ECDSA_SigGen_KCurve;
			}
			else if (checkBox2.Checked == false)
			{
				checkBox101.Checked = false;				
				checkBox100.Checked = false;			
				checkBox99.Checked = false;				
				checkBox98.Checked = false;				
				checkBox97.Checked = false;			
				checkBox96.Checked = false;			
				checkBox95.Checked = false;			
				checkBox59.Checked = false;			
				checkBox58.Checked = false;			
				checkBox57.Checked = false;			
				checkBox56.Checked = false;			
				checkBox55.Checked = false;			
				checkBox54.Checked = false;			
				checkBox53.Checked = false;			
				checkBox52.Checked = false;			
				checkBox51.Checked = false;			
				checkBox50.Checked = false;			
				checkBox49.Checked = false;			
				checkBox48.Checked = false;			
				checkBox47.Checked = false;			
				checkBox46.Checked = false;				
				checkBox45.Checked = false;			
				checkBox44.Checked = false;			
				checkBox43.Checked = false;			
				checkBox42.Checked = false;				
				checkBox41.Checked = false;			
				checkBox40.Checked = false;		
				checkBox39.Checked = false;
				checkBox38.Checked = false;			
				checkBox37.Checked = false;			
				checkBox36.Checked = false;			
				checkBox35.Checked = false;			
				checkBox34.Checked = false;			
				checkBox33.Checked = false;			
				checkBox32.Checked = false;
			}
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox3.Checked == true)
			{
				tabControl1.SelectedTab = ECDSA_SigGen_BCurve;
			}
			else if (checkBox3.Checked == false)
			{				
				checkBox108.Checked = false;				
				checkBox107.Checked = false;			
				checkBox106.Checked = false;			
				checkBox105.Checked = false;			
				checkBox104.Checked = false;			
				checkBox103.Checked = false;				
				checkBox102.Checked = false;			
				checkBox87.Checked = false;				
				checkBox86.Checked = false;				
				checkBox85.Checked = false;				
				checkBox84.Checked = false;				
				checkBox83.Checked = false;				
				checkBox82.Checked = false;				
				checkBox81.Checked = false;				
				checkBox80.Checked = false;				
				checkBox79.Checked = false;				
				checkBox78.Checked = false;				
				checkBox77.Checked = false;			
				checkBox76.Checked = false;
				checkBox75.Checked = false;				
				checkBox74.Checked = false;			
				checkBox73.Checked = false;				
				checkBox72.Checked = false;				
				checkBox71.Checked = false;			
				checkBox70.Checked = false;				
				checkBox69.Checked = false;			
				checkBox68.Checked = false;				
				checkBox67.Checked = false;			
				checkBox66.Checked = false;			
				checkBox65.Checked = false;				
				checkBox64.Checked = false;				
				checkBox63.Checked = false;				
				checkBox62.Checked = false;				
				checkBox61.Checked = false;				
				checkBox60.Checked = false;				
			}
		}
	}
}