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
    public partial class frmLogin : BEAProjectManagement.frmTemplate
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Είσοδος";
            this.label4.Text = "ver. 1.0.0.52";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("H επικοινωνία με τη βάση δεδομένων είναι προσωρινά απενεργοποιημένη, λόγω συντήρησης του server. Δοκιμάστε αργότερα! ");

            //if (1 == 2)
            //{

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Properties.Settings.Default.beaDBConnectionString;

                SqlCommand command = new SqlCommand();
                command.CommandText = "pGetUserData";
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter pUserName = new SqlParameter();
                pUserName = command.Parameters.Add("@userName", SqlDbType.NVarChar, 50);
                pUserName.Direction = ParameterDirection.Input;
                pUserName.Value = this.textBox1.Text;

                SqlParameter pUserID = new SqlParameter();
                pUserID = command.Parameters.Add("@userID", SqlDbType.Int);
                pUserID.Direction = ParameterDirection.Output;

                SqlParameter pUserFirstName = new SqlParameter();
                pUserFirstName = command.Parameters.Add("@userFirstName", SqlDbType.NVarChar, 50);
                pUserFirstName.Direction = ParameterDirection.Output;

                SqlParameter pUserSurName = new SqlParameter();
                pUserSurName = command.Parameters.Add("@userSurname", SqlDbType.NVarChar, 50);
                pUserSurName.Direction = ParameterDirection.Output;

                SqlParameter pPassword = new SqlParameter();
                pPassword = command.Parameters.Add("@userPassword", SqlDbType.NVarChar, 50);
                pPassword.Direction = ParameterDirection.Output;

                SqlParameter pRole = new SqlParameter();
                pRole = command.Parameters.Add("@userRole", SqlDbType.Int);
                pRole.Direction = ParameterDirection.Output;


                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Η σύνδεση με τη βάση δεδομένων δεν είναι δυνατή...");
                    MessageBox.Show("Η επικοινωνία με το server γίνεται κανονικά, αλλά η βάση δεδομένων δεν ανταποκρίνεται...");
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

                if (this.textBox2.Text == pPassword.Value.ToString().Trim())
                {
                    bea.userID = (int)pUserID.Value;
                    bea.userRole = (int)pRole.Value;
                    bea.userFullName = pUserFirstName.Value.ToString() + " " + pUserSurName.Value.ToString();

                    frmMainMenu frm = new frmMainMenu();
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Λάθος Όνομα Χρήστη ή Κωδικός!");
                }
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Uri myUri = new Uri("mailto:info@diadrasis.gr?Subject=Τεχνικό%20Πρόβλημα%20Εφαρμογής%20ΒΕΑ&body=Περιγραφή");
            System.Diagnostics.Process.Start(myUri.AbsoluteUri);
        }
    }
}
