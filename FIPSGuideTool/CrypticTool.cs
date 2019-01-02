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
	public partial class CrypticTool : Form
	{
		public static string color_spec;
		public static string color_PortInter;
		public static string color_Roles;
		public static string color_FSM;
		public static string color_PhySec;
		public static string color_OpEnv;
		public static string color_KeyManag;
		public static string color_EMI;
		public static string color_SelfTest;
		public static string color_DesAssur;
		public static string color_Mitig;


		public CrypticTool()
		{
			InitializeComponent();

			color_spec      = Properties.Settings.Default.color_spec.ToString();
			color_PortInter = Properties.Settings.Default.color_PortInter.ToString();
			color_FSM       = Properties.Settings.Default.color_FSM.ToString();
			color_Roles     = Properties.Settings.Default.color_Roles.ToString();
			color_PhySec    = Properties.Settings.Default.color_PhySec.ToString();
			color_OpEnv     = Properties.Settings.Default.color_OpEnv.ToString();
			color_KeyManag  = Properties.Settings.Default.color_KeyManag.ToString();
			color_EMI       = Properties.Settings.Default.color_EMI.ToString();
			color_SelfTest  = Properties.Settings.Default.color_SelfTest.ToString();
			color_DesAssur  = Properties.Settings.Default.color_DesAssur.ToString();
			color_Mitig     = Properties.Settings.Default.color_Mitig.ToString();
		}

		private void CrypticTool_Load(object sender, EventArgs e)
		{
			if (color_spec == "True")
			{
				btn_SpecTEs.BackColor = Color.Green;
			}
			else if (color_spec == "False")
			{
				btn_SpecTEs.BackColor = Color.Gray;
			}

			if (color_PortInter == "True")
			{
				btn_PortsInterfacesTEs.BackColor = Color.Green;
			}
			else if (color_PortInter == "False")
			{
				btn_PortsInterfacesTEs.BackColor = Color.Gray;
			}

			if (color_Roles == "True")
			{
				btn_RoleServiceTEs.BackColor = Color.Green;
			}
			else if (color_Roles == "False")
			{
				btn_RoleServiceTEs.BackColor = Color.Gray;
			}

			if (color_FSM == "True")
			{
				btn_FSMTEs.BackColor = Color.Green;
			}
			else if (color_FSM == "False")
			{
				btn_FSMTEs.BackColor = Color.Gray;
			}

			if (color_PhySec == "True")
			{
				btn_PhySecTEs.BackColor = Color.Green;
			}
			else if (color_PhySec == "False")
			{
				btn_PhySecTEs.BackColor = Color.Gray;
			}

			if (color_OpEnv == "True")
			{
				btn_OpEnvTEs.BackColor = Color.Green;
			}
			else if (color_OpEnv == "False")
			{
				btn_OpEnvTEs.BackColor = Color.Gray;
			}

			if (color_KeyManag == "True")
			{
				btn_KeyManagTEs.BackColor = Color.Green;
			}
			else if (color_KeyManag == "False")
			{
				btn_KeyManagTEs.BackColor = Color.Gray;
			}

			if (color_EMI == "True")
			{
				btn_EMI_EMC_TEs.BackColor = Color.Green;
			}
			else if (color_EMI == "False")
			{
				btn_EMI_EMC_TEs.BackColor = Color.Gray;
			}

			if (color_SelfTest == "True")
			{
				btn_SelfTestTEs.BackColor = Color.Green;
			}
			else if (color_SelfTest == "False")
			{
				btn_SelfTestTEs.BackColor = Color.Gray;
			}

			if (color_DesAssur == "True")
			{
				btn_DesAssurTEs.BackColor = Color.Green;
			}
			else if (color_DesAssur == "False")
			{
				btn_DesAssurTEs.BackColor = Color.Gray;
			}

			if (color_Mitig == "True")
			{
				btn_MitOtherAttackTEs.BackColor = Color.Green;
			}
			else if (color_Mitig == "False")
			{
				btn_MitOtherAttackTEs.BackColor = Color.Gray;
			}

			//UpdateFormColor(color_spec);
			//UpdateFormColor(color_FSM);
			//UpdateFormColor(color_KeyManag);
			//UpdateFormColor(color_DesAssur);
			//UpdateFormColor(color_PortInter);
			//UpdateFormColor(color_PhySec);
			//UpdateFormColor(color_EMI);
			//UpdateFormColor(color_Mitig);
			//UpdateFormColor(color_Roles);
			//UpdateFormColor(color_OpEnv);
			//UpdateFormColor(color_SelfTest);
		}

		private void btn_SpecTEs_Click(object sender, EventArgs e)
		{
			SpecificationsAS_TE f1 = new SpecificationsAS_TE();
			f1.ShowDialog();
			UpdateFormColor(color_spec);
		}

		private void btn_FSMTEs_Click(object sender, EventArgs e)
		{
			FSM_AS_TE f1 = new FSM_AS_TE();
			f1.ShowDialog();
			UpdateFormColor(color_FSM);
		}

		private void btn_KeyManagTEs_Click(object sender, EventArgs e)
		{
			KeyManagementAS_TE f1 = new KeyManagementAS_TE();
			f1.ShowDialog();
			UpdateFormColor(color_KeyManag);
		}

		private void btn_DesAssurTEs_Click(object sender, EventArgs e)
		{
			DesignAssuranceAS_TE f1 = new DesignAssuranceAS_TE();
			f1.ShowDialog();
			UpdateFormColor(color_DesAssur);
		}

		private void btn_PortsInterfacesTEs_Click(object sender, EventArgs e)
		{
			PortsInterfacesAS_TE f1 = new PortsInterfacesAS_TE();
			f1.ShowDialog();
			UpdateFormColor(color_PortInter);
		}

		private void btn_PhySecTEs_Click(object sender, EventArgs e)
		{
			PhysicalSecurityAS_TE f1 = new PhysicalSecurityAS_TE();
			f1.ShowDialog();
			UpdateFormColor(color_PhySec);
		}

		private void btn_EMI_EMC_TEs_Click(object sender, EventArgs e)
		{
			EMI_EMC_AS_TE f1 = new EMI_EMC_AS_TE();
			f1.ShowDialog();
			UpdateFormColor(color_EMI);
		}

		private void btn_MitOtherAttackTEs_Click(object sender, EventArgs e)
		{
			MitigationAttacksAS_TE f1 = new MitigationAttacksAS_TE();
			f1.ShowDialog();
			UpdateFormColor(color_Mitig);
		}

		private void btn_RoleServiceTEs_Click(object sender, EventArgs e)
		{
			RolesServicesAS_TE f1 = new RolesServicesAS_TE();
			f1.ShowDialog();
			UpdateFormColor(color_Roles);
		}

		private void btn_OpEnvTEs_Click(object sender, EventArgs e)
		{
			OpEnvironmentAS_TE f1 = new OpEnvironmentAS_TE();
			f1.ShowDialog();
			UpdateFormColor(color_OpEnv);
		}

		private void btn_SelfTestTEs_Click(object sender, EventArgs e)
		{
			SelfTestsAS_TE f1 = new SelfTestsAS_TE();
			f1.ShowDialog();
			UpdateFormColor(color_SelfTest);
		}

		public void UpdateFormColor(string color_spec)
		{
			//btn_SpecTEs.BackColor = Color.Green;
			color_spec      = Properties.Settings.Default.color_spec.ToString();
			color_PortInter = Properties.Settings.Default.color_PortInter.ToString();
			color_FSM       = Properties.Settings.Default.color_FSM.ToString();
			color_Roles     = Properties.Settings.Default.color_Roles.ToString();
			color_PhySec    = Properties.Settings.Default.color_PhySec.ToString();
			color_OpEnv     = Properties.Settings.Default.color_OpEnv.ToString();
			color_KeyManag  = Properties.Settings.Default.color_KeyManag.ToString();
			color_EMI       = Properties.Settings.Default.color_EMI.ToString();
			color_SelfTest  = Properties.Settings.Default.color_SelfTest.ToString();
			color_DesAssur  = Properties.Settings.Default.color_DesAssur.ToString();
			color_Mitig     = Properties.Settings.Default.color_Mitig.ToString();

			if (color_spec == "True")
			{
				btn_SpecTEs.BackColor = Color.Green;
			}
			else if (color_spec == "False")
			{
				btn_SpecTEs.BackColor = Color.Gray;
			}

			if (color_PortInter == "True")
			{
				btn_PortsInterfacesTEs.BackColor = Color.Green;
			}
			else if (color_PortInter == "False")
			{
				btn_PortsInterfacesTEs.BackColor = Color.Gray;
			}

			if (color_Roles == "True")
			{
				btn_RoleServiceTEs.BackColor = Color.Green;
			}
			else if (color_Roles == "False")
			{
				btn_RoleServiceTEs.BackColor = Color.Gray;
			}

			if (color_FSM == "True")
			{
				btn_FSMTEs.BackColor = Color.Green;
			}
			else if (color_FSM == "False")
			{
				btn_FSMTEs.BackColor = Color.Gray;
			}

			if (color_PhySec == "True")
			{
				btn_PhySecTEs.BackColor = Color.Green;
			}
			else if (color_PhySec == "False")
			{
				btn_PhySecTEs.BackColor = Color.Gray;
			}

			if (color_OpEnv == "True")
			{
				btn_OpEnvTEs.BackColor = Color.Green;
			}
			else if (color_OpEnv == "False")
			{
				btn_OpEnvTEs.BackColor = Color.Gray;
			}

			if (color_KeyManag == "True")
			{
				btn_KeyManagTEs.BackColor = Color.Green;
			}
			else if (color_KeyManag == "False")
			{
				btn_KeyManagTEs.BackColor = Color.Gray;
			}

			if (color_EMI == "True")
			{
				btn_EMI_EMC_TEs.BackColor = Color.Green;
			}
			else if (color_EMI == "False")
			{
				btn_EMI_EMC_TEs.BackColor = Color.Gray;
			}

			if (color_SelfTest == "True")
			{
				btn_SelfTestTEs.BackColor = Color.Green;
			}
			else if (color_SelfTest == "False")
			{
				btn_SelfTestTEs.BackColor = Color.Gray;
			}

			if (color_DesAssur == "True")
			{
				btn_DesAssurTEs.BackColor = Color.Green;
			}
			else if (color_DesAssur == "False")
			{
				btn_DesAssurTEs.BackColor = Color.Gray;
			}

			if (color_Mitig == "True")
			{
				btn_MitOtherAttackTEs.BackColor = Color.Green;
			}
			else if (color_Mitig == "False")
			{
				btn_MitOtherAttackTEs.BackColor = Color.Gray;
			}
		}
	}
}
