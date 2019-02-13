using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmTimeSheet2 : BEAProjectManagement.frmTemplate
    {
        public int personID;
        public DateTime dateFrom;
        public List<string> projects;
        public List<int> projectIDs;
        private SqlConnection con;
        private SqlCommand com;
        public DateTime selectedDate;

        public frmTimeSheet2()
        {
            InitializeComponent();
        }

        private void frmTimeSheet2_Load(object sender, EventArgs e)
        {
            this.Text = "Καταγραφή Ωρών";
            this.button1.Enabled = false;
            this.lblCurrentPerson.Text = bea.currentPerson;

            this.Font = new Font("Century Gothic", 10);
            this.monthCalendar1.MaxSelectionCount = 7;           
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = this.monthCalendar1.SelectionStart;
            SelectCalendarDate(selectedDate);           
        }

        private void SelectCalendarDate(DateTime dt)
        {
            CultureInfo greek = new CultureInfo("el-GR");            
            if ((int)dt.DayOfWeek != 0)
            {
                dateFrom = dt.AddDays(-(int)dt.DayOfWeek + 1);
            }
            else
            {
                dateFrom = dt.AddDays(-6);
            }
            this.monthCalendar1.SelectionStart = dateFrom ;
            this.monthCalendar1.SelectionEnd = dateFrom.AddDays(6);
            
            GetProjects(dateFrom);
            this.button1.Enabled = true;
        }

        private void GetProjects(DateTime dt)
        {
            projects = new List<string>();
            projectIDs = new List<int>();

            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.beaDBConnectionString;

            com = new SqlCommand();
            com.CommandText = "pGetPersonProjects";
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter pPersonID = new SqlParameter();
            pPersonID = com.Parameters.Add("@personID", SqlDbType.Int);
            pPersonID.Direction = ParameterDirection.Input;
            pPersonID.Value = this.personID;

            SqlParameter pDateFrom = new SqlParameter();
            pDateFrom = com.Parameters.Add("@dateFrom", SqlDbType.Date);
            pDateFrom.Direction = ParameterDirection.Input;
            pDateFrom.Value = dt;

            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Η σύνδεση με τη βάση δεδομένων δεν είναι δυνατή...");
                MessageBox.Show("Execute error: " + ex.Message);
                con.Close();
            }

            try
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        projects.Add(reader.GetString(0));
                        projectIDs.Add(reader.GetInt32(1));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("απέτυχε η προσπάθεια... ");
                MessageBox.Show(ex.Message);
                con.Close();

            }
           
            if (projects.Count > 0)
            {
                DesignGrid(dateFrom, projects);
                GetWeekWorkedHours();
            }
            else
            {
                MessageBox.Show("Δεν υπάρχουν την επιλεγμένη περίοδο έργα για τον εργαζόμενο!");
                //con.Close();
            }
            con.Close();

        }

        private void DesignGrid(DateTime dt, List<string> projects)
        {
            Point startLocation = new Point(200, 200); // This take the location in form . We have added a label with no text just to take the location and under it to add fields.
            int a = startLocation.X + 80;//The coordinate X of the label we give to the int variable a
            int b = startLocation.Y;//The coordinate Y

            int n = 7;// Take the value N -Rows
            int m = projects.Count; // Take the value M-Columns

            int i, j;
            int[,] matrix = new int[n, m];

            //create project labels
            for (j = 0; j < m; j++)
            {
                //clear previous Label lbl=new Label();
                if (this.Controls.Find("Project" + j.ToString(), false).Length > 0)
                {
                    Label lbl = (Label)this.Controls.Find("Project" + j.ToString(), false)[0];
                    lbl.Text = projects[j];
                }
                else
                {
                    Label label = new Label();
                    label.Name = "Project" + j.ToString();
                    label.AutoSize = false;
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.Location = new Point(startLocation.X + 250 + j * 270, startLocation.Y - 40);
                    //label.Width = 200;
                    this.Controls.Add(label);
                    label.Text = projects[j];
                }
            }

            for (i = 0; i < n; i++)
            {
                //create date labels
                //clear previous Label lbl=new Label();
                if (this.Controls.Find("Date" + i.ToString(), false).Length > 0)
                {
                    Label lbl = (Label)this.Controls.Find("Date" + i.ToString(), false)[0];
                    lbl.Text = dateFrom.AddDays(i).ToString("dddd") + " " + dateFrom.AddDays(i).ToString("dd/MM/yy");
                }
                else
                {
                    Label label = new Label();
                    label.Name = "Date" + i.ToString();
                    label.AutoSize = false;
                    label.TextAlign = ContentAlignment.MiddleRight;
                    label.Location = new Point(startLocation.X, startLocation.Y + i * 30);
                    label.Width = 200;
                    this.Controls.Add(label);
                    label.Text = dateFrom.AddDays(i).ToString("dddd") + " " + dateFrom.AddDays(i).ToString("dd/MM/yy");
                }

               

                for (j = 0; j < m; j++)
                {

                    if (this.Controls.Find("txt" + i.ToString()+j.ToString(), false).Length > 0)
                    {
                        TextBox tb = (TextBox)this.Controls.Find("txt" + i.ToString() + j.ToString(), false)[0];
                        tb.Text = "";
                        if (i > 4)
                        {
                            tb.Enabled = false;
                        }

                    }
                    else
                    {
                        TextBox textbox = new TextBox();
                        //  it create the new //textbox field, the creating fields will continue while as we have the //columns and rows.
                        string boxName = "txt" + i.ToString() + j.ToString();//We set the name for textbox
                        textbox.Name = boxName; //give name to textbox                                      
                        textbox.Width = 25;
                        textbox.Height = 25;
                        textbox.Location = new Point(startLocation.X + 250 + 200 + j * (250), startLocation.Y + i * 30);//Now the field take the location where it will be pasted.
                        this.Controls.Add(textbox);

                    }

                    if (this.Controls.Find("cmb" + i.ToString() + j.ToString(), false).Length > 0)
                    {
                        ComboBox cb = (ComboBox)this.Controls.Find("cmb" + i.ToString() + j.ToString(), false)[0];
                        cb.Items.Clear();
                    }
                    else
                    {
                        ComboBox combobox = new ComboBox();
                        string comboName = "cmb" + i.ToString() + j.ToString();
                        combobox.Name = comboName;
                        combobox.Width = 95;
                        combobox.Height = 25;
                        combobox.Location = new Point(startLocation.X + 250 + j * 250, startLocation.Y + i * 30);//Now the field take the location where it will be pasted.
                        this.Controls.Add(combobox);                       

                    }

                    //check works comboboxes
                    if (this.Controls.Find("cmbwork" + i.ToString() + j.ToString(), false).Length > 0)
                    {
                        ComboBox cb = (ComboBox)this.Controls.Find("cmbwork" + i.ToString() + j.ToString(), false)[0];
                        cb.Items.Clear();
                    }
                    else
                    {
                        ComboBox combobox = new ComboBox();
                        string comboName = "cmbwork" + i.ToString() + j.ToString();
                        combobox.Name = comboName;
                        combobox.Width = 95;
                        combobox.Height = 25;
                        combobox.Location = new Point(startLocation.X + 250 + 100 + j * 250, startLocation.Y + i * 30);//Now the field take the location where it will be pasted.
                        this.Controls.Add(combobox); 
                    }
                }
                
                if (i>4 || CheckPersonAvailability(dateFrom.AddDays(i)) == 1)
                {
                    this.Controls.Find("Date" + i.ToString(), false)[0].Enabled = false;
                    for (j = 0; j < m; j++)
                    {
                        this.Controls.Find("txt" + i.ToString() + j.ToString(), false)[0].Enabled = false;
                        this.Controls.Find("cmb" + i.ToString() + j.ToString(), false)[0].Enabled = false;
                        this.Controls.Find("cmbwork" + i.ToString() + j.ToString(), false)[0].Enabled = false;
                    }
                }
                else
                {
                    this.Controls.Find("Date" + i.ToString(), false)[0].Enabled = true;
                    for (j = 0; j < m; j++)
                    {
                        this.Controls.Find("txt" + i.ToString() + j.ToString(), false)[0].Enabled = true;
                        this.Controls.Find("cmb" + i.ToString() + j.ToString(), false)[0].Enabled = true;
                        this.Controls.Find("cmbwork" + i.ToString() + j.ToString(), false)[0].Enabled = true;
                    }
                }
            }

            PopulateActivityComboBoxes();
            PopulateWorkComboBoxes();
        }

        public class ComboboxItem
        {
            public ComboboxItem(string t, string v)
            {
                Text = t;
                Value = v;
            }
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }

            public override bool Equals(object obj)
            {
                ComboboxItem item = obj as ComboboxItem;
                if (item == null)
                {
                    return false;
                }
                return item.Value == this.Value;
            }

            public override int GetHashCode()
            {
                if (this.Value == null)
                {
                    return 0;
                }
                return this.Value.GetHashCode();
            }
        }

        private void PopulateActivityComboBoxes()
        {
            List<Tuple<string, string>> activities = new List<Tuple<string, string>>();

                       
            com.CommandText = "pGetPersonProjectActivites";           
            com.Parameters.Clear();
            

            SqlParameter pPersonID = new SqlParameter();
            pPersonID = com.Parameters.Add("@person", SqlDbType.Int);
            pPersonID.Direction = ParameterDirection.Input;
            pPersonID.Value = personID;

            SqlParameter pProjectID = new SqlParameter();
            pProjectID = com.Parameters.Add("@project", SqlDbType.Int);
            pProjectID.Direction = ParameterDirection.Input;

            ComboboxItem defaultCbI = new ComboboxItem("-", "0");
            for (int j = 0; j < projects.Count; j++)
            {


                pProjectID.Value = projectIDs[j];
                for (int i = 0; i < 7; i++)
                {
                    ComboBox cmb = (ComboBox)this.Controls.Find("cmb" + i.ToString() + j.ToString(), false)[0];
                    cmb.Items.Add(defaultCbI);
                    cmb.DisplayMember = "Text";
                    cmb.ValueMember = "Value";
                    cmb.SelectedIndex = 0;

                    try
                    {
                        using (SqlDataReader reader = com.ExecuteReader())
                        {
                            while (reader.Read())
                            {                               
                                cmb.Items.Add(new ComboboxItem(reader.GetString(1), reader.GetInt32(0).ToString()));
                            }
                            reader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("απέτυχε η προσπάθεια... ");
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
        }

        private void PopulateWorkComboBoxes()
        {
            List<Tuple<string, string>> activities = new List<Tuple<string, string>>();

            com.CommandText = "pGetPersonProjectActivitesWorks";
            com.Parameters.Clear();

            SqlParameter pPersonID = new SqlParameter();
            pPersonID = com.Parameters.Add("@person", SqlDbType.Int);
            pPersonID.Direction = ParameterDirection.Input;
            pPersonID.Value = personID;

            SqlParameter pProjectID = new SqlParameter();
            pProjectID = com.Parameters.Add("@project", SqlDbType.Int);
            pProjectID.Direction = ParameterDirection.Input;

            ComboboxItem defaultCbI = new ComboboxItem("-", "0");
            for (int j = 0; j < projects.Count; j++)
            {
                pProjectID.Value = projectIDs[j];
                for (int i = 0; i < 7; i++)
                {
                    ComboBox cmb = (ComboBox)this.Controls.Find("cmbwork" + i.ToString() + j.ToString(), false)[0];
                    cmb.Items.Add(defaultCbI);
                    cmb.DisplayMember = "Text";
                    cmb.ValueMember = "Value";
                    cmb.SelectedIndex = 0;

                    try
                    {
                        using (SqlDataReader reader = com.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //ComboBox cmb = (ComboBox)this.Controls.Find("cmb" + i.ToString() + column.ToString(), false)[0];
                                cmb.Items.Add(new ComboboxItem(reader.GetString(1), reader.GetInt32(0).ToString()));
                            }
                            reader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("απέτυχε η προσπάθεια... ");
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
        }

        private void GetWeekWorkedHours()
        {
            GetDateWorkedHours();
        }

        private void GetDateWorkedHours()
        {
            com.CommandText = "GetPersonDateWorkedActivityWorkHours";          
            com.Parameters.Clear();
            SqlParameter pPersonID = new SqlParameter();
            pPersonID = com.Parameters.Add("@person", SqlDbType.Int);
            pPersonID.Direction = ParameterDirection.Input;
            pPersonID.Value = personID;

            SqlParameter pDate = new SqlParameter();
            pDate = com.Parameters.Add("@date", SqlDbType.Date);
            pDate.Direction = ParameterDirection.Input;
                    

            for (int j = 0; j < projects.Count; j++)
            {
                for (int i = 0; i < 7; i++)
                {

                    pDate.Value = dateFrom.AddDays(i);
                    try
                    {
                        using (SqlDataReader reader = com.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ComboboxItem cbi = new ComboboxItem(reader.GetString(1), reader.GetInt32(0).ToString());                                
                                ComboBox cmb = (ComboBox)this.Controls.Find("cmb" + i.ToString() + j.ToString(), false)[0];

                                ComboboxItem cbiwork = new ComboboxItem(reader.GetString(4), reader.GetInt32(3).ToString());
                                ComboBox cmbwork = (ComboBox)this.Controls.Find("cmbwork" + i.ToString() + j.ToString(), false)[0];

                                for (int k = 0; k < cmb.Items.Count; k++)
                                {
                                    if (((ComboboxItem)cmb.Items[k]).Text == cbi.Text)
                                    {
                                        cmb.SelectedIndex = k;
                                        TextBox txt = (TextBox)this.Controls.Find("txt" + i.ToString() + j.ToString(), false)[0];
                                        txt.Text = reader.GetInt32(2).ToString();
                                        break;
                                    }                                   
                                }

                                for (int k = 0; k < cmbwork.Items.Count; k++)
                                {
                                    if (((ComboboxItem)cmbwork.Items[k]).Text == cbiwork.Text)
                                    {
                                        cmbwork.SelectedIndex = k;
                                        break;
                                    }
                                }                               
                            }
                            reader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("απέτυχε η προσπάθεια... ");
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetDateWorkedHours();
        }

        private void SetDateWorkedHours()
        {
            com.CommandText = "SetPersonDateWorkedActivityHours";          
            com.Parameters.Clear();

            SqlParameter pPerson = new SqlParameter();
            pPerson = com.Parameters.Add("@person", SqlDbType.Int);
            pPerson.Direction = ParameterDirection.Input;

            SqlParameter pDate = new SqlParameter();
            pDate = com.Parameters.Add("@date", SqlDbType.Date);
            pDate.Direction = ParameterDirection.Input;

            SqlParameter pActivity = new SqlParameter();
            pActivity = com.Parameters.Add("@activity", SqlDbType.Int);
            pActivity.Direction = ParameterDirection.Input;

            SqlParameter pWork = new SqlParameter();
            pWork = com.Parameters.Add("@work", SqlDbType.Int);
            pWork.Direction = ParameterDirection.Input;

            SqlParameter pProject = new SqlParameter();
            pProject = com.Parameters.Add("@project", SqlDbType.Int);
            pProject.Direction = ParameterDirection.Input;

            SqlParameter pHours = new SqlParameter();
            pHours = com.Parameters.Add("@hours", SqlDbType.Int);
            pHours.Direction = ParameterDirection.Input;

            //parameters           
            pPerson.Value = personID;
            
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Η σύνδεση με τη βάση δεδομένων δεν είναι δυνατή...");
                MessageBox.Show("Execute error: " + ex.Message);
                con.Close();
            }

            //MessageBox.Show("writing");
            for (int j = 0; j < projects.Count; j++)
            {
                pProject.Value = projectIDs[j];
                for (int i = 0; i < 7; i++)
                {
                    ComboBox cmb = (ComboBox)this.Controls.Find("cmb" + i.ToString() + j.ToString(), false)[0];
                    ComboboxItem selectedItem = (ComboboxItem)cmb.SelectedItem;
                    string selectedValue = (string)selectedItem.Value;

                    ComboBox cmbwork = (ComboBox)this.Controls.Find("cmbwork" + i.ToString() + j.ToString(), false)[0];
                    ComboboxItem selectedworkItem = (ComboboxItem)cmbwork.SelectedItem;
                   
                    
                    if (!String.IsNullOrEmpty(selectedValue))
                    {
                        DateTime date = dateFrom.AddDays(i);
                        pDate.Value = date;

                        int activity = int.Parse(selectedValue);
                        pActivity.Value = activity;

                        int work = int.Parse((string)selectedworkItem.Value);
                        pWork.Value = work;
                        
                        TextBox txt = (TextBox)this.Controls.Find("txt" + i.ToString() + j.ToString(), false)[0];
                        if (!String.IsNullOrEmpty(txt.Text))
                        {
                            int hours;
                            if (int.TryParse(txt.Text, out hours)){
                                pHours.Value = hours;
                            }
                            else
                            {
                                MessageBox.Show(txt.Text.ToString() + " δεν είναι αριθμός!");
                                pHours.Value = 0;
                            }                            

                            try
                            {
                                com.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("απέτυχε η προσπάθεια... ");
                                MessageBox.Show(ex.Message);
                                con.Close();
                            }
                        }                           
                    }
                }
            }
            con.Close();
           
            MessageBox.Show("H καταχώρηση των ωρών της εβδομάδας " + dateFrom.ToString("dd /MM") + " έως " + dateFrom.AddDays(6).ToString("dd/MM") + " έγινε με επιτυχία!");
            SelectCalendarDate(selectedDate);
        }

        private int CheckPersonAvailability(DateTime day)
        {
            int availability = -1;
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = Properties.Settings.Default.beaDBConnectionString;

            //SqlCommand command = new SqlCommand();
            com.CommandText = "pCheckPersonAvailability";
            //command.Connection = conn;
            //command.CommandType = CommandType.StoredProcedure;
            com.Parameters.Clear();

            SqlParameter pPerson = new SqlParameter();
            pPerson = com.Parameters.Add("@person", SqlDbType.Int);
            pPerson.Direction = ParameterDirection.Input;

            SqlParameter pDate = new SqlParameter();
            pDate = com.Parameters.Add("@date", SqlDbType.Date);
            pDate.Direction = ParameterDirection.Input;

            SqlParameter pAvailability = new SqlParameter();
            pAvailability = com.Parameters.Add("@available", SqlDbType.Int);
            pAvailability.Direction = ParameterDirection.Output;

            //parameters           
            pPerson.Value = personID;
            pDate.Value = day;
            try
            {
                //con.Open();
                try
                {
                    com.ExecuteNonQuery();
                    availability = (int)pAvailability.Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("απέτυχε η προσπάθεια... ");
                    MessageBox.Show(ex.Message);
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Η σύνδεση με τη βάση δεδομένων δεν είναι δυνατή...");
                MessageBox.Show("Execute error: " + ex.Message);
                con.Close();
            }

            //con.Close();
            return availability;
        }
    }
           
       
        
}
