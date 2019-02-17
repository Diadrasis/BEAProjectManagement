using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmChooseProject : Form
    {
        public frmChooseProject()
        {
            InitializeComponent();
        }

        private void frmChooseProject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.vProjects' table. You can move, or remove it, as needed.
            this.vProjectsTableAdapter.Fill(this.beaDBDataSet.vProjects);
            this.Text = "Επιλογή Έργου";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedValue != System.DBNull.Value)
            {
                //rptProjectChart frm = new rptProjectChart();
                rptProjectReview frm = new rptProjectReview();
                frm.projectID = (int)this.comboBox1.SelectedValue;
                frm.Show();
                //this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
