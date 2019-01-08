using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmActivityTeam : BEAProjectManagement.frmTemplate
    {
        public int projID;
        public int practID;
        DataGridView dgv;
        BindingNavigator bnv;

        public frmActivityTeam()
        {
            InitializeComponent();
        }

        private void tblActivityTeamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblActivityTeamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

            this.lblBudget.Text = GetActivityWorkBudget(practID).Item1.ToString();
            this.lblRemainingBudget.Text = GetActivityWorkBudget(practID).Item2.ToString();

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblActivityTeamTableAdapter.Fill(this.beaDBDataSet.tblActivityTeam, this.practID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void frmActivityTeam2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.vPersons' table. You can move, or remove it, as needed.
            //this.vPersonsTableAdapter.Fill(this.beaDBDataSet.vPersons);
           
            try
            {
                this.tblActivityTeamTableAdapter.Fill(this.beaDBDataSet.tblActivityTeam, this.practID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                this.vProjectTeamTableAdapter.Fill(this.beaDBDataSet.vProjectTeam, this.projID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            dgv = this.tblActivityTeamDataGridView;
            bnv = this.tblActivityTeamBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);

            this.Text = "Ομάδα Δραστηριότητας";

            this.lblCurrentActivity.Text = bea.currentActivity;
            this.lblCurrentActivity.Location = new Point(300, 110);

            this.label2.Text = "Προυπολογισμός AH:";
            this.label4.Text = "Αδιάθετες ΑΗ:";
            this.lblBudget.Text = GetActivityWorkBudget(practID).Item1.ToString();
            this.lblRemainingBudget.Text = GetActivityWorkBudget(practID).Item2.ToString();

            // this.label1.Text = GetProjectAvailableHours(this.projID).ToString();
            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;
            dgv.Columns["dataGridViewTextBoxColumn4"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn2"].HeaderText = "Εργαζόμενος";
            dgv.Columns["dataGridViewTextBoxColumn2"].Width = 220;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Απασχόληση - ΑΗ";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 130;

            dgv.Columns["actteamBudget"].HeaderText = "Κόστος";
            dgv.Columns["actteamBudget"].Width = 90;
            dgv.Columns["actteamBudget"].Visible = false;

            dgv.Columns["availabilityIcon"].HeaderText = "";
            dgv.Columns["availabilityIcon"].Width = 70;

            dgv.Columns["availability"].HeaderText = "Διαθέσιμες ΑΗ";
            dgv.Columns["availability"].Width = 120;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["availability"].Index);

        }

        private int GetProjectAvailableHours(int proj)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.beaDBConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "pGetProjectAvailableHours";
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param = command.Parameters.Add("@projID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = proj;

            SqlParameter returnParameter = new SqlParameter();
            returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

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

            }

            return Convert.ToInt16(returnParameter.Value);
        }

        static public Tuple<int, int> GetActivityWorkBudget(int activityID)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.beaDBConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "pGetProjectActivityRemainingWorkBudget";
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param = command.Parameters.Add("@activity", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = activityID;

            SqlParameter pBudget = new SqlParameter();
            pBudget = command.Parameters.Add("@actWorkBudget", SqlDbType.Int);
            pBudget.Direction = ParameterDirection.Output;
            pBudget.Value = 0;

            SqlParameter pRemainingBudget = new SqlParameter();
            pRemainingBudget = command.Parameters.Add("@actRemainingWorkBudget", SqlDbType.Int);
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

        private void tblActivityTeamDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value = this.practID;
            }
        }

        private void tblActivityTeamDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Cells["availability"].Value = "";
                }

                if (e.ColumnIndex == dgv.Columns["availabilityIcon"].Index)
                {
                    dgv.Rows[e.RowIndex].Cells["availability"].Value = bea.GetPersonAvailableActivitiesWorkdays(projID, (int)dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value).ToString();
                }
            }
        }
    }
}
