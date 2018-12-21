using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmProjectTeam : BEAProjectManagement.frmTemplate
    {
        public int projectID;        
        DataGridView dgv;
        BindingNavigator bnv;

        public frmProjectTeam()
        {
            InitializeComponent();
        }

        private void tblProjectTeamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProjectTeamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

            this.lblBudget.Text = GetProjectBudget(projectID).Item1.ToString("C", CultureInfo.CurrentCulture);
            this.lblRemainingBudget.Text = GetProjectBudget(projectID).Item2.ToString("C", CultureInfo.CurrentCulture);
        }

        private void frmProjectTeam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.vPersons' table. You can move, or remove it, as needed.
            this.vPersonsTableAdapter.Fill(this.beaDBDataSet.vPersons);
            try
            {
                this.tblProjectTeamTableAdapter.Fill(this.beaDBDataSet.tblProjectTeam, this.projectID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            dgv = this.tblProjectTeamDataGridView;
            bnv = this.tblProjectTeamBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);

            this.Text = "Ομάδα Έργου";

            this.lblCurrentProject.Text = bea.currentProject;
            this.lblCurrentProject.Location = new Point(310, 110);
            this.lblBudget.Text = GetProjectBudget(projectID).Item1.ToString("C", CultureInfo.CurrentCulture);
            this.lblRemainingBudget.Text = GetProjectBudget(projectID).Item2.ToString("C", CultureInfo.CurrentCulture);


            this.label2.Text = "Προυπολογισμός:";
            this.label4.Text = "Αδιάθετα:";

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;
            dgv.Columns["dataGridViewTextBoxColumn2"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Εργαζόμενος";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 250;

            dgv.Columns["prteamRole"].HeaderText = "Ρόλος";
            dgv.Columns["prteamRole"].Width = 150;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Απασχόληση - ΑΗ";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 140;

            dgv.Columns["prteamBudget"].HeaderText = "Κόστος";
            dgv.Columns["prteamBudget"].Width = 100;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["prteamBudget"].Index);

            dgv.Columns["availabilityIcon"].HeaderText = "";
            dgv.Columns["availabilityIcon"].Width = 70;

            dgv.Columns["availability"].HeaderText = "Διαθέσιμες ΑΗ";
            dgv.Columns["availability"].Width = 120;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["availability"].Index);

        }

        private void tblProjectTeamDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value = this.projectID;
            }
            this.lblBudget.Text = GetProjectBudget(projectID).Item1.ToString("C", CultureInfo.CurrentCulture);
            this.lblRemainingBudget.Text = GetProjectBudget(projectID).Item2.ToString("C", CultureInfo.CurrentCulture);
        }

        static public Tuple<int, int> GetProjectBudget(int projectID)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.beaDBConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "pGetProjectRemainingBudget";
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param = command.Parameters.Add("@project", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = projectID;

            SqlParameter pBudget = new SqlParameter();
            pBudget = command.Parameters.Add("@budget", SqlDbType.Int);
            pBudget.Direction = ParameterDirection.Output;
            pBudget.Value = 0;

            SqlParameter pRemainingBudget = new SqlParameter();
            pRemainingBudget = command.Parameters.Add("@remainingBudget", SqlDbType.Int);
            pRemainingBudget.Direction = ParameterDirection.Output;
            pRemainingBudget.Value = 0;
            
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Η σύνδεση με τη βάση δεδομένων δεν είναι δυνατή...");
                MessageBox.Show("Execute error: " + ex.Message);
                conn.Close();
            }

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("απέτυχε η προσπάθεια... ");
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            conn.Close();
            return Tuple.Create((int)pBudget.Value, (int)pRemainingBudget.Value);
        }

        

        private void tblProjectTeamDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
               
                foreach ( DataGridViewRow row in dgv.Rows){
                    row.Cells["availability"].Value = "";
                }

                if (e.ColumnIndex == dgv.Columns["availabilityIcon"].Index)
                {
                    dgv.Rows[e.RowIndex].Cells["availability"].Value = bea.GetPersonAvailableProjectWorkdays(projectID, (int)dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value).ToString();
                }
            }
        }
    }
}
