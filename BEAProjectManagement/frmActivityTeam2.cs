using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmActivityTeam2 : BEAProjectManagement.frmTemplate
    {
        //public int projID;
        public int practID;

        public frmActivityTeam2()
        {
            InitializeComponent();
        }

        private void tblActivityTeamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblActivityTeamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblActivityTeamTableAdapter.Fill(this.beaDBDataSet.tblActivityTeam, new System.Nullable<int>(((int)(System.Convert.ChangeType(practIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void frmActivityTeam2_Load(object sender, EventArgs e)
        {
            try
            {
                this.tblActivityTeamTableAdapter.Fill(this.beaDBDataSet.tblActivityTeam,this.practID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
