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
    public partial class rptProjectReview : Form
    {
        public int projectID;
        public rptProjectReview()
        {
            InitializeComponent();
        }

        private void rptProjectReview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.rptProjectReview' table. You can move, or remove it, as needed.
            this.rptProjectReviewTableAdapter.Fill(this.beaDBDataSet.rptProjectReview, projectID);
            this.reportViewer1.RefreshReport();
            this.Text = "Αναφορά Έργου";
        }
    }
}
