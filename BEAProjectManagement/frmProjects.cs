using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmProjects : BEAProjectManagement.frmTemplate
    {
        DataGridView dgv;
        BindingNavigator bnv;

        int CurrentRow;

        public frmProjects()
        {
            InitializeComponent();
        }

        private void tblProjectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

        }

        private void frmProjects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.tblProjects' table. You can move, or remove it, as needed.
            this.tblProjectsTableAdapter.Fill(this.beaDBDataSet.tblProjects);

            dgv = this.tblProjectsDataGridView;
            bnv = this.tblProjectsBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);

            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Height = 25;
            }
            dgv.RowTemplate.Height = 25;

            //MessageBox.Show(dgv.RowTemplate.Height.ToString());
            this.monthCalendar1.Visible = false;
            this.monthCalendar2.Visible = false;

            //this.WindowState = FormWindowState.Maximized;

            this.Text = "Έργα";
            this.labelUser.Text = bea.userFullName;

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn2"].HeaderText = "Τίτλος";
            dgv.Columns["dataGridViewTextBoxColumn2"].Width = 200;

            dgv.Columns["dataGridViewTextBoxColumn3"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Έναρξη";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 90;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["dataGridViewTextBoxColumn4"].Index);

            dgv.Columns["projStart"].HeaderText = "";
            dgv.Columns["projStart"].Width = 50;

            dgv.Columns["dataGridViewTextBoxColumn5"].HeaderText = "Λήξη";
            dgv.Columns["dataGridViewTextBoxColumn5"].Width = 90;
            DesignHelper.InactivateColumn(dgv, 6);

            dgv.Columns["projFinish"].HeaderText = "";
            dgv.Columns["projFinish"].Width = 50;

            

            dgv.Columns["projTotalBudget"].HeaderText = "Συνολικός ΠΥ";
            dgv.Columns["projTotalBudget"].Width = 110;


            dgv.Columns["projBudget"].HeaderText = "ΠΥ Προσωπικού";
            dgv.Columns["projBudget"].Width = 130;
            
            dgv.Columns["dataGridViewTextBoxColumn6"].HeaderText = "Απασχόληση";
            dgv.Columns["dataGridViewTextBoxColumn6"].Width = 130;
            dgv.Columns["dataGridViewTextBoxColumn6"].Visible = false;

            dgv.Columns["projActivities"].HeaderText = "Δραστηριότητες";
            dgv.Columns["projActivities"].Width = 110;

            dgv.Columns["projTeam"].HeaderText = "Ομάδα Έργου";
            dgv.Columns["projTeam"].Width = 100;

        }

        private void tblProjectsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //pick calendar...
            if (e.RowIndex > -1)            {
                CurrentRow = e.RowIndex;
                if (e.ColumnIndex == dgv.Columns["projStart"].Index && this.monthCalendar2.Visible==false)
                {
                    this.monthCalendar1.Visible = true;
                    this.monthCalendar1.Location = new Point(MousePosition.X-this.Location.X, MousePosition.Y-this.Location.Y);
                    if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value!= System.DBNull.Value)
                    {
                        this.monthCalendar1.SetDate(Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value));
                    }
                }

                if (e.ColumnIndex == dgv.Columns["projFinish"].Index && this.monthCalendar1.Visible==false)
                {
                    this.monthCalendar2.Visible = true;
                    this.monthCalendar2.Location = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                    if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value != System.DBNull.Value)
                    {
                        this.monthCalendar2.SetDate(Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value));
                    }
                }

                if (e.ColumnIndex == dgv.Columns["projActivities"].Index)
                {
                    frmProjectActivities frm = new frmProjectActivities();                    
                    frm.projectID =Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                    frm.projStart = Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value);
                    frm.projFinish = Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value);
                    bea.currentProject = bea.GetCurrentProject(frm.projectID);
                    frm.Show();
                }

                if (e.ColumnIndex == dgv.Columns["projTeam"].Index)
                {
                    frmProjectTeam frm = new frmProjectTeam();
                    frm.projectID = Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                    bea.currentProject = bea.GetCurrentProject(frm.projectID);                    
                    frm.Show();
                }
            }           
        }


        

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn4"].Value = this.monthCalendar1.SelectionStart;
            this.monthCalendar1.Visible = false; 
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn5"].Value = this.monthCalendar2.SelectionStart;
            this.monthCalendar2.Visible = false;
        }
          

        private void tblProjectsDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value == System.DBNull.Value)
            {
                MessageBox.Show("To έργο πρέπει να έχει ημερομηνία έναρξης!");
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value = DateTime.Now.ToString();
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value == System.DBNull.Value)
            {
                MessageBox.Show("To έργο πρέπει να έχει ημερομηνία λήξης!");
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value = DateTime.Now.ToString();
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value !=null  & dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value != null)
            {
                if (Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value) > Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value))
                {
                    MessageBox.Show("H έναρξη του έργου δεν μπορεί να είναι αργότερα από τη λήξη!");
                    dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value = dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn5"].Value;
                }
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value == System.DBNull.Value)
            {
                MessageBox.Show("To έργο πρέπει να έχει όνομα!");
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value = "Έργο";
            }

            if (dgv.Rows[e.RowIndex].Cells["projBudget"].Value == System.DBNull.Value)                
            {
                MessageBox.Show("To έργο πρέπει να έχει προυπολογισμό!");
                dgv.Rows[e.RowIndex].Cells["projBudget"].Value = 0;
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value == System.DBNull.Value)
            {
                MessageBox.Show("To έργο πρέπει να έχει προυπολογισμό ωρών!");
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value = 0;
            }
            */
        }        
    }
}
