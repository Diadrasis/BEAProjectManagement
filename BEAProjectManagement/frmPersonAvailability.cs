using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmPersonAvailability : BEAProjectManagement.frmTemplate
    {
        public int personID;
        DataGridView dgv;
        BindingNavigator bnv;
        int CurrentRow;

        public frmPersonAvailability()
        {
            InitializeComponent();
        }

       

        private void frmPersonAvailability_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.vAvailability' table. You can move, or remove it, as needed.
            this.vAvailabilityTableAdapter.Fill(this.beaDBDataSet.vAvailability);
            // TODO: This line of code loads data into the 'beaDBDataSet.tblPersonAvailability' table. You can move, or remove it, as needed.
            this.tblPersonAvailabilityTableAdapter.Fill(this.beaDBDataSet.tblPersonAvailability, personID);

            dgv = this.tblPersonAvailabilityDataGridView;
            bnv = this.tblPersonAvailabilityBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);
            this.monthCalendar1.Visible = false;
            this.monthCalendar2.Visible = false;

            this.Text = "Μη διαθεσιμότητα";
            this.lblPersonel.Text = bea.currentPerson;
            this.lblPersonel.Location = new Point(320, 110);

            dgv.Width = 700;
            dgv.Height = 300;

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn2"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn6"].HeaderText = "Αιτία";
            dgv.Columns["dataGridViewTextBoxColumn6"].Width = 250;

            dgv.Columns["fromDate"].HeaderText = "";
            dgv.Columns["fromDate"].Width = 75;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Από";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 100;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["dataGridViewTextBoxColumn3"].Index);

            dgv.Columns["toDate"].HeaderText = "";
            dgv.Columns["toDate"].Width = 75;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Έως";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 100;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["dataGridViewTextBoxColumn4"].Index);

            dgv.Columns["dataGridViewTextBoxColumn5"].Visible = false;

        }

      

        private void tblPersonAvailabilityBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPersonAvailabilityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

        }

        private void tblPersonAvailabilityDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value = this.personID;
            }
        }

        private void tblPersonAvailabilityDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                CurrentRow = e.RowIndex;
                if (e.ColumnIndex == dgv.Columns["fromDate"].Index && this.monthCalendar1.Visible == false)
                {
                    this.monthCalendar1.Visible = true;
                    if (CurrentRow > 7)
                    {
                        this.monthCalendar1.Location = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y-210);
                    } else {
                        this.monthCalendar1.Location = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                    }
                    if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value != System.DBNull.Value)
                    {
                        this.monthCalendar1.SetDate(Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value));
                    }
                }

                if (e.ColumnIndex == dgv.Columns["toDate"].Index && this.monthCalendar2.Visible == false)
                {
                    this.monthCalendar2.Visible = true;
                    if (CurrentRow > 7)
                    {
                        this.monthCalendar2.Location = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y-210);

                    }
                    else
                    {
                        this.monthCalendar2.Location = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                    }
                    if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value != System.DBNull.Value)
                    {
                        this.monthCalendar2.SetDate(Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value));
                    }
                }
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn3"].Value = this.monthCalendar1.SelectionStart;
            dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn4"].Value = this.monthCalendar1.SelectionStart;
            this.monthCalendar1.Visible = false;
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn4"].Value = this.monthCalendar2.SelectionStart;
            this.monthCalendar2.Visible = false;
        }
    }
}
