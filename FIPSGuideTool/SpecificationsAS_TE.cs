using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
//using System.Windows.Controls;
//using System.Windows;
//using MessageBox = System.Windows.Forms.MessageBox;

namespace FIPSGuideTool
{
	public partial class SpecificationsAS_TE : Form
	{
		private OleDbConnection connection = new OleDbConnection();
		OleDbCommand command = new OleDbCommand();
		OleDbDataReader dataSearch;
		public static string SpecSecurityLevel;
		public static int VectorLength = 1000;
		public static string color_spec;
		int sectionNo = 1;
		string[] text = new string[VectorLength];
		string[] text1 = new string[VectorLength];
		string[] VendorTester = new string[VectorLength];
		string[] VendorTesterAll = new string[VectorLength];
		string[] Assessment = new string[VectorLength];
		string[] AssessmentAll = new string[VectorLength];
		string[] Assessment1 = new string[VectorLength];
		string[] Section = new string[VectorLength];
		string[] Section1 = new string[VectorLength];
		string[] Requirement = new string[VectorLength];
		string[] RequirementAll = new string[VectorLength];
		string[] SequenceNo = new string[VectorLength];
		string[] SequenceNoAll = new string[VectorLength];
		string[] TestNo = new string[VectorLength];
		string[] ModAssessment = new string[VectorLength];
		string[] SubSeq = new string[VectorLength];
		string[] SubSeqAll = new string[VectorLength];
		string[] eval_NA = new string[VectorLength];
		string[] eval_pass = new string[VectorLength];
		string[] eval1_split;
		string[] eval2_split;
		string[] eval3_split;
		string[] evaluationResultsAll = new string[VectorLength];
		string[] evaluationResults = new string[VectorLength];
		int[] NoComp_NA = new int[VectorLength];
		int[] NoInComp_NA = new int[VectorLength];
		int[] NoComp_pass = new int[VectorLength];
		int[] NoInComp_pass = new int[VectorLength];
		int[] ij3 = new int[VectorLength];

		// create table dynamically
		DataTable DT = new DataTable();

		public SpecificationsAS_TE()
		{
			InitializeComponent();
			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FIPSGuideTool.strfilepath + ";Persist Security Info=False;";
			connection.Open();
			command.Connection = connection;
			connection.Close();
			SpecSecurityLevel = Properties.Settings.Default.SpecSecurityLevel.ToString();
			color_spec        = Properties.Settings.Default.color_spec.ToString();
		}

		public void SpecificationsAS_TE_Load(object sender, EventArgs e)
		{
			// add columns
			DT.Columns.Add("N/A", System.Type.GetType("System.Boolean"));
			DT.Columns.Add("Pass", System.Type.GetType("System.Boolean"));
			DT.Columns.Add("#", typeof(string));
			DT.Columns.Add("Assertion/TE", typeof(string));
			DT.Columns.Add("Assessment", typeof(string));

			try
			{
				connection.Open();
				command.Connection  = connection;
				command.CommandText = "SELECT * FROM ValidationInfo";
				dataSearch          = command.ExecuteReader();

				int ii = 0;
				while (dataSearch.Read())
				{
					VendorTesterAll[ii] = dataSearch.GetValue(0).ToString();
					AssessmentAll[ii]   = dataSearch.GetValue(5).ToString();
					Section[ii]         = dataSearch.GetValue(1).ToString();
					RequirementAll[ii]  = dataSearch.GetValue(2).ToString();
					SequenceNoAll[ii]   = dataSearch.GetValue(3).ToString();
					SubSeqAll[ii]       = dataSearch.GetValue(4).ToString();
					evaluationResultsAll[ii] = dataSearch.GetValue(8).ToString();
					ii++;
				}
				dataSearch.Close();

				command.CommandText = "SELECT * FROM ValidationInfo";
				dataSearch = command.ExecuteReader();

				int ij = 0;
				int ij1 = 0;
				
				while (dataSearch.Read())
				{
					if ((Section[ij] == "1") && (VendorTesterAll[ij] == "AS" || (VendorTesterAll[ij] == "TE")))
					{
						if ((SpecSecurityLevel == "Level 1" || SpecSecurityLevel == "Level 2") && (RequirementAll[ij] == "4"))
						{
							VendorTester[ij1] = dataSearch.GetValue(0).ToString();
							Assessment[ij1]   = dataSearch.GetValue(5).ToString();
							Requirement[ij1]  = dataSearch.GetValue(2).ToString();
							SequenceNo[ij1]   = dataSearch.GetValue(3).ToString();
							SubSeq[ij1]       = dataSearch.GetValue(4).ToString();
							Section1[ij1]     = dataSearch.GetValue(1).ToString();
							evaluationResults[ij1] = dataSearch.GetValue(8).ToString();
							ij3[ij1]          = ij;
							ij1++;
						}
						else
						{
							VendorTester[ij1] = dataSearch.GetValue(0).ToString();
							Assessment[ij1]   = dataSearch.GetValue(5).ToString();
							Requirement[ij1]  = dataSearch.GetValue(2).ToString();
							SequenceNo[ij1]   = dataSearch.GetValue(3).ToString();
							SubSeq[ij1]       = dataSearch.GetValue(4).ToString();
							Section1[ij1]     = dataSearch.GetValue(1).ToString();
							evaluationResults[ij1] = dataSearch.GetValue(8).ToString();
							ij1++;
						}						
					}
					ij++;
				}
				dataSearch.Close();

				command.CommandText = "SELECT * FROM Requirements";
				dataSearch = command.ExecuteReader();

				int i = 0;
				int ij2 = 0;
				while (dataSearch.Read())
				{
					if (i >= 9)
					{
						text[ij2] = dataSearch.GetValue(9).ToString();
						ij2++;
					}
					i++;
				}
				dataSearch.Close();
				
				ij2 = 0;
				for (int i1 = 0; i1 < Section.Length; i1++)
				{
					if (Section[i1] == "1" && (VendorTesterAll[i1] == "AS" || (VendorTesterAll[i1] == "TE")))
					{
						text1[ij2] = text[i1];
						ij2++;
					}
				}
				
				// add rows
				for (int i1 = 0; i1 < Section.Length; i1++)
				{
					if (VendorTester[i1] == "AS")// && Section[i1] == "6")
					{
						if (evaluationResults[i1] == "3")
						{
							DT.Rows.Add(true, false, VendorTester[i1] + "." + Section1[i1] + "." + Requirement[i1], text1[i1], Assessment[i1]);
							eval_NA[i1] = VendorTester[i1] + "." + Section1[i1] + "." + Requirement[i1];
						}
						else if (evaluationResults[i1] == "1")
						{
							DT.Rows.Add(false, true, VendorTester[i1] + "." + Section1[i1] + "." + Requirement[i1], text1[i1], Assessment[i1]);
							eval_pass[i1] = VendorTester[i1] + "." + Section1[i1] + "." + Requirement[i1];
						}
						else
						{
							DT.Rows.Add(false, false, VendorTester[i1] + "." + Section1[i1] + "." + Requirement[i1], text1[i1], Assessment[i1]);
							//eval_NA[i1] = VendorTester[i1] + "." + Section1[i1] + "." + Requirement[i1];
							//eval_pass[i1] = VendorTester[i1] + "." + Section1[i1] + "." + Requirement[i1];
						}
					}

					if (VendorTester[i1] == "TE")// && Section[i1] == "6")
					{
						if (evaluationResults[i1] == "3")
						{
							DT.Rows.Add(true, false, VendorTester[i1] + "." + Section1[i1] + "." + Requirement[i1] + "." + SequenceNo[i1], text1[i1], Assessment[i1]);
							eval_NA[i1] = VendorTester[i1] + "." + Section1[i1] + "." + Requirement[i1] + "." + SequenceNo[i1];
						}
						else if (evaluationResults[i1] == "1")
						{
							DT.Rows.Add(false, true, VendorTester[i1] + "." + Section1[i1] + "." + Requirement[i1] + "." + SequenceNo[i1], text1[i1], Assessment[i1]);
							eval_pass[i1] = VendorTester[i1] + "." + Section1[i1] + "." + Requirement[i1] + "." + SequenceNo[i1];
						}
						else
						{
							DT.Rows.Add(false, false, VendorTester[i1] + "." + Section1[i1] + "." + Requirement[i1] + "." + SequenceNo[i1], text1[i1], Assessment[i1]);
							//eval_NA[i1] = VendorTester[i1] + "." + Section1[i1] + "." + Requirement[i1];
							//eval_pass[i1] = VendorTester[i1] + "." + Section1[i1] + "." + Requirement[i1];
						}
					}
				}
				dataGridView_ASTE.DataSource = DT;
				for (int i1 = 0; i1 < Section.Length; i1++)
				{
					if (ij3[i1] != 0)
					{
						dataGridView_ASTE.Rows[i1].Visible = false;
					}				
				}

				foreach (DataGridViewRow row in dataGridView_ASTE.Rows)
				{
					if (row.Cells[2].Value != null)
					{
						string AS_TE_str = row.Cells[2].Value.ToString();
						string[] AS_TE_vec = AS_TE_str.Split('.');
						if (AS_TE_vec[0] == "TE")
						{
							row.DefaultCellStyle.BackColor = Color.Aqua;
						}
					}
				}
				ResultStatusCheckBoxes();

				dataGridView_ASTE.Columns[0].Width = 70;
				dataGridView_ASTE.Columns[1].Width = 80;
				dataGridView_ASTE.Columns[2].Width = 150;
				dataGridView_ASTE.Columns[3].Width = 900;
				dataGridView_ASTE.Columns[4].Width = 900;

				dataGridView_ASTE.Dock = DockStyle.Fill;
				dataGridView_ASTE.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
				dataGridView_ASTE.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex);
			}
		}

		private void SpecificationsAS_TE_FormClosed(object sender, FormClosedEventArgs e)
		{}

		private void SpecificationsAS_TE_FormClosing(object sender, FormClosingEventArgs e)
		{
			int ChangeFlag = 1;
			for (int rows = 0; rows < dataGridView_ASTE.Rows.Count - 1; rows++)
			{
				ModAssessment[rows] = dataGridView_ASTE.Rows[rows].Cells[4].Value.ToString();

				if (Assessment[rows] == null)
				{
					Assessment[rows] = "";
				}
			}

			if (ChangeFlag == 1)
			{
				DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning",
				MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					connection.Open();
					command.Connection = connection;
					int i4 = 0;
					for (int i1 = 0; i1 < VectorLength; i1++)
					{
						if (VendorTesterAll[i1] == "AS" && Section[i1] == "1")
						{
							string inputStr = ModAssessment[i4];
							// Check if the string contains a single quote
							if (inputStr != null)
							{
								if (inputStr.Contains("'"))
								{
									ModAssessment[i4] = inputStr.Replace("'", "\''");
								}
							}
							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + ModAssessment[i4] + "'  WHERE VendorTester = 'AS' and Section = " + Int32.Parse(Section[i1]) + " and Requirement = " + Int32.Parse(RequirementAll[i1]) + "  and SequenceNo = " + Int32.Parse(SequenceNoAll[i1]) + " and SubSeq = " + Int32.Parse(SubSeqAll[i1]) + " ";
							command.ExecuteNonQuery();
							i4++;
						}

						if (VendorTesterAll[i1] == "TE" && Section[i1] == "1")
						{
							string inputStr = ModAssessment[i4];
							// Check if the string contains a single quote
							if (inputStr != null)
							{
								if (inputStr.Contains("'"))
								{
									ModAssessment[i4] = inputStr.Replace("'", "\''");
								}
							}
							command.CommandText = "UPDATE ValidationInfo SET Assessment='" + ModAssessment[i4] + "'  WHERE VendorTester = 'TE' and Section = " + Int32.Parse(Section[i1]) + " and Requirement = " + Int32.Parse(RequirementAll[i1]) + "  and SequenceNo = " + Int32.Parse(SequenceNoAll[i1]) + " and SubSeq = " + Int32.Parse(SubSeqAll[i1]) + " ";
							command.ExecuteNonQuery();
							i4++;
						}
					}

					for (int i11 = 0; i11 < dataGridView_ASTE.Rows.Count; i11++)
					{
						if (eval_NA[i11] != null)
						{
							eval1_split = eval_NA[i11].Split('.');
							if (eval1_split[0] == "AS")
							{
								command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'AS' and Section = " + sectionNo + " and Requirement = " + eval1_split[2] + " ";
								command.ExecuteNonQuery();
							}

							if (eval1_split[0] == "TE")
							{
								command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = 'TE' and Section = " + sectionNo + " and Requirement = " + eval1_split[2] + "  and SequenceNo = " + eval1_split[3] + "";
								command.ExecuteNonQuery();
							}
						}
						else if (eval_pass[i11] != null)
						{
							eval2_split = eval_pass[i11].Split('.');
							if (eval2_split[0] == "AS")
							{
								command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 1 + "'  WHERE VendorTester = 'AS' and Section = " + sectionNo + " and Requirement = " + eval2_split[2] + " ";
								command.ExecuteNonQuery();
							}

							if (eval2_split[0] == "TE")
							{
								command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 1 + "'  WHERE VendorTester = 'TE' and Section = " + sectionNo + " and Requirement = " + eval2_split[2] + "  and SequenceNo = " + eval2_split[3] + "";
								command.ExecuteNonQuery();
							}
						}
						else if ((eval_NA[i11] == null) && eval_pass[i11] == null)
						{
							if (dataGridView_ASTE.Rows[i11].Cells[2].Value != null)
							{
								eval3_split = dataGridView_ASTE.Rows[i11].Cells[2].Value.ToString().Split('.');
								if (eval3_split[0] == "AS")
								{
									command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 0 + "'  WHERE VendorTester = 'AS' and Section = " + sectionNo + " and Requirement = " + eval3_split[2] + " ";
									command.ExecuteNonQuery();
								}

								if (eval3_split[0] == "TE")
								{
									command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 0 + "'  WHERE VendorTester = 'TE' and Section = " + sectionNo + " and Requirement = " + eval3_split[2] + "  and SequenceNo = " + eval3_split[3] + "";
									command.ExecuteNonQuery();
								}
							}
						}
					}

					color_spec = SectionProgress(ij3);
					Properties.Settings.Default.color_spec = color_spec;
					Properties.Settings.Default.Save();

					connection.Close();
				}
				else if (result == DialogResult.No)
				{
					e.Cancel = false;
				}
				else if (result == DialogResult.Cancel)
				{
					e.Cancel = true;
				}
			}
		}

		private void dataGridView_ASTE_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			connection.Open();
			command.Connection = connection;

			DataGridViewCheckBoxCell chk1 = (DataGridViewCheckBoxCell)dataGridView_ASTE.Rows[e.RowIndex].Cells[1];
			DataGridViewCheckBoxCell chk0 = (DataGridViewCheckBoxCell)dataGridView_ASTE.Rows[e.RowIndex].Cells[0];					   			 		  

			if (dataGridView_ASTE.Columns[e.ColumnIndex].Name == "N/A")
			{				 
				if (dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value != null)
				{
					string AS_TE_str = dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value.ToString();
					string[] AS_TE_vec = AS_TE_str.Split('.');

					if (AS_TE_vec[0] == "TE")
					{
						int SecNo = Int32.Parse(AS_TE_vec[1]);
						int ReqNo = Int32.Parse(AS_TE_vec[2]);
						int SeqNo = Int32.Parse(AS_TE_vec[3]);						
						command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = '" + AS_TE_vec[0] + "' and Section = " + SecNo + " and Requirement = " + ReqNo + "  and SequenceNo = " + SeqNo + " and SubSeq = " + 0 + " ";
					}


					if (AS_TE_vec[0] == "AS")
					{
						int SecNo = Int32.Parse(AS_TE_vec[1]);
						int ReqNo = Int32.Parse(AS_TE_vec[2]);
						command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = '" + AS_TE_vec[0] + "' and Section = " + SecNo + " and Requirement = " + ReqNo + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					}
						
					command.ExecuteNonQuery();
				}				
				
				if (chk1.Value.ToString() == "True")
				{
					chk1.Value = false;
					eval_pass[e.RowIndex] = null;
				}

				if (chk0.Value.ToString() == "False")
				{
					if (eval_NA[e.RowIndex] != null)
					{
						eval_NA[e.RowIndex] = null;
					}
					else
					{
						eval_NA[e.RowIndex] = dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value.ToString();
					}
				}
				else if (chk0.Value.ToString() == "True")
				{
					if (eval_NA[e.RowIndex] != null)
					{
						eval_NA[e.RowIndex] = null;
					}
					else
					{
						eval_NA[e.RowIndex] = dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value.ToString();
					}
				}
			}

			if (dataGridView_ASTE.Columns[e.ColumnIndex].Name == "Pass")
			{
				if (dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value != null)
				{
					string AS_TE_str = dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value.ToString();
					string[] AS_TE_vec = AS_TE_str.Split('.');

					if (AS_TE_vec[0] == "TE")
					{
						int SecNo = Int32.Parse(AS_TE_vec[1]);
						int ReqNo = Int32.Parse(AS_TE_vec[2]);
						int SeqNo = Int32.Parse(AS_TE_vec[3]);
						command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 1 + "'  WHERE VendorTester = '" + AS_TE_vec[0] + "' and Section = " + SecNo + " and Requirement = " + ReqNo + "  and SequenceNo = " + SeqNo + " and SubSeq = " + 0 + " ";
					}


					if (AS_TE_vec[0] == "AS")
					{
						int SecNo = Int32.Parse(AS_TE_vec[1]);
						int ReqNo = Int32.Parse(AS_TE_vec[2]);
						command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 1 + "'  WHERE VendorTester = '" + AS_TE_vec[0] + "' and Section = " + SecNo + " and Requirement = " + ReqNo + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
					}

					command.ExecuteNonQuery();
				}

				if (chk0.Value.ToString() == "True")
				{
					chk0.Value = false;
					eval_NA[e.RowIndex] = null;
				}

				if (chk1.Value.ToString() == "False")
				{
					if (eval_pass[e.RowIndex] != null)
					{
						eval_pass[e.RowIndex] = null;
					}
					else
					{
						eval_pass[e.RowIndex] = dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value.ToString();
					}
				}
				else if (chk1.Value.ToString() == "True")
				{
					if (eval_pass[e.RowIndex] != null)
					{
						eval_pass[e.RowIndex] = null;
					}
					else
					{
						eval_pass[e.RowIndex] = dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value.ToString();
					}
				}
			}
			connection.Close();
		}

		public string SectionProgress(int[] ij)
		{
			string color_spec = "True";

			for (int i11 = 0; i11 < dataGridView_ASTE.Rows.Count - 1; i11++)
			{			
				if (ij[i11] == 0)
				{
					if ((eval_pass[i11] == null) && (eval_NA[i11] == null))
					{
						color_spec = "False";
					}
				}
			}
			return color_spec;				
		}

		public void ResultStatusCheckBoxes()
		{
			//connection.Open();
			//command.Connection = connection;

			foreach (DataGridViewRow row in dataGridView_ASTE.Rows)
			{
				DataGridViewCheckBoxCell chk1 = (DataGridViewCheckBoxCell)row.Cells[1];
				DataGridViewCheckBoxCell chk0 = (DataGridViewCheckBoxCell)row.Cells[0];

				if (row.Cells[2].Value != null)
				{
					if ((Convert.ToBoolean(row.Cells[0].Value) == false) && (Convert.ToBoolean(row.Cells[1].Value) == false))
					{
						string AS_TE_str = row.Cells[2].Value.ToString();
						string[] AS_TE_vec = AS_TE_str.Split('.');

						if (AS_TE_vec[0] == "TE")
						{
							int SecNo = Int32.Parse(AS_TE_vec[1]);
							int ReqNo = Int32.Parse(AS_TE_vec[2]);
							int SeqNo = Int32.Parse(AS_TE_vec[3]);
							command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 0 + "'  WHERE VendorTester = '" + AS_TE_vec[0] + "' and Section = " + SecNo + " and Requirement = " + ReqNo + "  and SequenceNo = " + SeqNo + " and SubSeq = " + 0 + " ";
						}


						if (AS_TE_vec[0] == "AS")
						{
							int SecNo = Int32.Parse(AS_TE_vec[1]);
							int ReqNo = Int32.Parse(AS_TE_vec[2]);
							command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 0 + "'  WHERE VendorTester = '" + AS_TE_vec[0] + "' and Section = " + SecNo + " and Requirement = " + ReqNo + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
						}

						command.ExecuteNonQuery();
					}
				}
			}
		}

		private void dataGridView_ASTE_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				connection.Open();
				command.Connection = connection;

				DataGridViewCheckBoxCell chk1 = (DataGridViewCheckBoxCell)dataGridView_ASTE.Rows[e.RowIndex].Cells[1];
				DataGridViewCheckBoxCell chk0 = (DataGridViewCheckBoxCell)dataGridView_ASTE.Rows[e.RowIndex].Cells[0];

				if (dataGridView_ASTE.Columns[e.ColumnIndex].Name == "N/A")
				{
					if (dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value != null)
					{
						if (chk0.Value.ToString() == "True")
						{
							DialogResult dialogResult = MessageBox.Show("Currently, N/A is checked, would you like to uncheck it?", "Message", MessageBoxButtons.YesNo);

							if (dialogResult == DialogResult.Yes)
							{
								//uncheck							
								chk0.Value = false;

								string AS_TE_str = dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value.ToString();
								string[] AS_TE_vec = AS_TE_str.Split('.');
								if (AS_TE_vec[0] == "TE")
								{
									int SecNo = Int32.Parse(AS_TE_vec[1]);
									int ReqNo = Int32.Parse(AS_TE_vec[2]);

									int SeqNo = Int32.Parse(AS_TE_vec[3]);
									command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = '" + AS_TE_vec[0] + "' and Section = " + SecNo + " and Requirement = " + ReqNo + "  and SequenceNo = " + SeqNo + " and SubSeq = " + 0 + " ";
								}

								if (AS_TE_vec[0] == "AS")
								{
									int SecNo = Int32.Parse(AS_TE_vec[1]);
									int ReqNo = Int32.Parse(AS_TE_vec[2]);
									command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = '" + AS_TE_vec[0] + "' and Section = " + SecNo + " and Requirement = " + ReqNo + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
								}
								command.ExecuteNonQuery();
							}
							else if (dialogResult == DialogResult.No)
							{
								//do nothing
							}
						}
						else if (chk0.Value.ToString() == "False")
						{
							DialogResult dialogResult = MessageBox.Show("Currently, N/A is unchecked, would you like to check it?", "Message", MessageBoxButtons.YesNo);
							if (dialogResult == DialogResult.Yes)
							{
								//check							
								chk0.Value = true;
								if (chk1.Value.ToString() == "True")
								{
									chk1.Value = false;
								}

								string AS_TE_str = dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value.ToString();
								string[] AS_TE_vec = AS_TE_str.Split('.');
								if (AS_TE_vec[0] == "TE")
								{
									int SecNo = Int32.Parse(AS_TE_vec[1]);
									int ReqNo = Int32.Parse(AS_TE_vec[2]);
									int SeqNo = Int32.Parse(AS_TE_vec[3]);
									command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = '" + AS_TE_vec[0] + "' and Section = " + SecNo + " and Requirement = " + ReqNo + "  and SequenceNo = " + SeqNo + " and SubSeq = " + 0 + " ";
								}

								if (AS_TE_vec[0] == "AS")
								{
									int SecNo = Int32.Parse(AS_TE_vec[1]);
									int ReqNo = Int32.Parse(AS_TE_vec[2]);
									command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 3 + "'  WHERE VendorTester = '" + AS_TE_vec[0] + "' and Section = " + SecNo + " and Requirement = " + ReqNo + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
								}
								command.ExecuteNonQuery();
							}
							else if (dialogResult == DialogResult.No)
							{
								//do nothing
							}
						}
					}

					if (chk0.Value.ToString() == "False")
					{
						if (eval_NA[e.RowIndex] != null)
						{
							eval_NA[e.RowIndex] = null;
						}
						else
						{
							eval_NA[e.RowIndex] = dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value.ToString();
							eval_pass[e.RowIndex] = null;
						}
					}
					else if (chk0.Value.ToString() == "True")
					{
						if (eval_NA[e.RowIndex] != null)
						{
							eval_NA[e.RowIndex] = null;
						}
						else
						{
							eval_NA[e.RowIndex] = dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value.ToString();
							eval_pass[e.RowIndex] = null;
						}
					}
				}

				if (dataGridView_ASTE.Columns[e.ColumnIndex].Name == "Pass")
				{
					if (dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value != null)
					{
						if (chk1.Value.ToString() == "True")
						{
							DialogResult dialogResult = MessageBox.Show("Currently, Pass is checked, would you like to uncheck it?", "Message", MessageBoxButtons.YesNo);
							if (dialogResult == DialogResult.Yes)
							{
								//uncheck							
								chk1.Value = false;					

								string AS_TE_str = dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value.ToString();
								string[] AS_TE_vec = AS_TE_str.Split('.');
								if (AS_TE_vec[0] == "TE")
								{
									int SecNo = Int32.Parse(AS_TE_vec[1]);
									int ReqNo = Int32.Parse(AS_TE_vec[2]);

									int SeqNo = Int32.Parse(AS_TE_vec[3]);
									command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 1 + "'  WHERE VendorTester = '" + AS_TE_vec[0] + "' and Section = " + SecNo + " and Requirement = " + ReqNo + "  and SequenceNo = " + SeqNo + " and SubSeq = " + 0 + " ";
								}

								if (AS_TE_vec[0] == "AS")
								{
									int SecNo = Int32.Parse(AS_TE_vec[1]);
									int ReqNo = Int32.Parse(AS_TE_vec[2]);
									command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 1 + "'  WHERE VendorTester = '" + AS_TE_vec[0] + "' and Section = " + SecNo + " and Requirement = " + ReqNo + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
								}
								command.ExecuteNonQuery();
							}
							else if (dialogResult == DialogResult.No)
							{
								//do nothing
							}
						}
						else if (chk1.Value.ToString() == "False")
						{
							DialogResult dialogResult = MessageBox.Show("Currently, Pass is unchecked, would you like to check it?", "Message", MessageBoxButtons.YesNo);
							if (dialogResult == DialogResult.Yes)
							{
								//check							
								chk1.Value = true;
								if (chk0.Value.ToString() == "True")
								{
									chk0.Value = false;
								}

								string AS_TE_str = dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value.ToString();
								string[] AS_TE_vec = AS_TE_str.Split('.');
								if (AS_TE_vec[0] == "TE")
								{
									int SecNo = Int32.Parse(AS_TE_vec[1]);
									int ReqNo = Int32.Parse(AS_TE_vec[2]);
									int SeqNo = Int32.Parse(AS_TE_vec[3]);
									command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 1 + "'  WHERE VendorTester = '" + AS_TE_vec[0] + "' and Section = " + SecNo + " and Requirement = " + ReqNo + "  and SequenceNo = " + SeqNo + " and SubSeq = " + 0 + " ";
								}

								if (AS_TE_vec[0] == "AS")
								{
									int SecNo = Int32.Parse(AS_TE_vec[1]);
									int ReqNo = Int32.Parse(AS_TE_vec[2]);
									command.CommandText = "UPDATE ValidationInfo SET ResultsStatus='" + 1 + "'  WHERE VendorTester = '" + AS_TE_vec[0] + "' and Section = " + SecNo + " and Requirement = " + ReqNo + "  and SequenceNo = " + 0 + " and SubSeq = " + 0 + " ";
								}
								command.ExecuteNonQuery();
							}
							else if (dialogResult == DialogResult.No)
							{
								//do nothing
							}
						}
					}

					if (chk1.Value.ToString() == "False")
					{
						if (eval_pass[e.RowIndex] != null)
						{
							eval_pass[e.RowIndex] = null;
						}
						else
						{
							eval_pass[e.RowIndex] = dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value.ToString();
							eval_NA[e.RowIndex] = null;
						}
					}
					else if (chk1.Value.ToString() == "True")
					{
						if (eval_pass[e.RowIndex] != null)
						{
							eval_pass[e.RowIndex] = null;
						}
						else
						{
							eval_pass[e.RowIndex] = dataGridView_ASTE.Rows[e.RowIndex].Cells[2].Value.ToString();
							eval_NA[e.RowIndex] = null;
						}
					}	
				}
				connection.Close();
			}
		}
	}
}