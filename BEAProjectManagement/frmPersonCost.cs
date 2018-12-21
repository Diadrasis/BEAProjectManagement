using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmPersonCost : BEAProjectManagement.frmTemplate
    {

        public int personID;
        DataGridView dgv;
        BindingNavigator bnv;
        int CurrentRow;


        public frmPersonCost()
        {
            InitializeComponent();
        }

        private void tblPersonCostBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPersonCostBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

        }

       

        private void frmPersonCost_Load(object sender, EventArgs e)
        {
            try
            {
                this.tblPersonCostTableAdapter.Fill(this.beaDBDataSet.tblPersonCost, personID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            dgv = this.tblPersonCostDataGridView;
            bnv = this.tblPersonCostBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);

            this.Text = "Κόστος Εργαζόμενου";
            this.lblCurrentPerson.Text = bea.currentPerson;
            this.lblCurrentPerson.Location = new Point(320, 110);

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;
            dgv.Columns["dataGridViewTextBoxColumn2"].Visible = false;

            dgv.Columns["From"].HeaderText = "";
            dgv.Columns["From"].Width = 50;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Από";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 80;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["dataGridViewTextBoxColumn3"].Index);

            dgv.Columns["To"].HeaderText = "";
            dgv.Columns["To"].Width = 50;
            dgv.Columns["To"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Έως";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 80;
            dgv.Columns["dataGridViewTextBoxColumn4"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn5"].HeaderText = "Ημερήσιο Κόστος";
            dgv.Columns["dataGridViewTextBoxColumn5"].Width = 150;
            dgv.Columns["dataGridViewTextBoxColumn5"].Visible = false;

            dgv.Columns["personcostMonthSalary"].HeaderText = "Μισθός";
            dgv.Columns["personcostMonthSalary"].Width = 75;

            dgv.Columns["personcostMonthContributions"].HeaderText = "Εισφορές";
            dgv.Columns["personcostMonthContributions"].Width = 75;

            dgv.Columns["personcostMonth"].HeaderText = "Μηνιαίο";
            dgv.Columns["personcostMonth"].Width = 75;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["personcostMonth"].Index);

            dgv.Columns["personcostYear"].HeaderText = "Ετήσιο";
            dgv.Columns["personcostYear"].Width = 75;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["personcostYear"].Index);

            dgv.Columns["personcostDay"].HeaderText = "Ημερήσιο";
            dgv.Columns["personcostDay"].Width = 75;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["personcostDay"].Index);

            dgv.Columns["personcostHour"].HeaderText = "Ωριαίο";
            dgv.Columns["personcostHour"].Width = 75;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["personcostHour"].Index);

        }

        private void tblPersonCostDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value = this.personID;
            }

            /*
            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value == System.DBNull.Value)
            {
                MessageBox.Show("Πρέπει να καταχωρήσετε ημερομηνία!");
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value = new DateTime(2015 ,1,1);
              }
              */

            if (dgv.Rows[e.RowIndex].Cells["personcostMonthSalary"].Value == System.DBNull.Value)
            {
                //MessageBox.Show("Πρέπει να καταχωρήσετε την μηνιαίο μισθό!");
                dgv.Rows[e.RowIndex].Cells["personcostMonthSalary"].Value = 0;
            }

            if (dgv.Rows[e.RowIndex].Cells["personcostMonthContributions"].Value == System.DBNull.Value)
            {
                //MessageBox.Show("Πρέπει να καταχωρήσετε τις μηνιαίες εργοδοτικές εισφορές!");
                dgv.Rows[e.RowIndex].Cells["personcostMonthContributions"].Value = 0;
            }

        }

        private void tblPersonCostDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                CurrentRow = e.RowIndex;
                if (e.ColumnIndex == dgv.Columns["From"].Index && this.monthCalendar1.Visible == false)
                {
                    this.monthCalendar1.Visible = true;
                    this.monthCalendar1.Location = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                    if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value != System.DBNull.Value)
                    {
                        this.monthCalendar1.SetDate(Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value));
                    }
                }
            }

            }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn3"].Value = this.monthCalendar1.SelectionStart;
            this.monthCalendar1.Visible = false;
        }
    }
}
