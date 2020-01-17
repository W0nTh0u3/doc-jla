using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SouthJLAInformationSystemC
{
    public partial class OffsiteEntEdtForm : Form
    {
        public string terminal = System.Environment.MachineName;
        public string idPass = "";
        public string uniquePass = "";
        public string remarks = "";
        public string[] statusHolder = new string[10];
    

        public OffsiteEntEdtForm()
        {
            InitializeComponent();
            InitializeDropDowns();
            Console.WriteLine("terminal: " + terminal);
            vitalSignStatusBox.SelectedItem = "PENDING";
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
           try
            {            
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
                SqlDataAdapter sdaSearch = new SqlDataAdapter("SELECT * FROM dbo.mjrl2020 WHERE id = '" + searchBox.Text + "'", conn);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sdaSearch.Fill(dt);
                //    DateTime date1 = Convert.ToDateTime(dt.Rows[0][14].ToString()); Not needed yet

                lastBox.Text = dt.Rows[0][1].ToString();
                firstBox.Text = dt.Rows[0][2].ToString();
                middleBox.Text = dt.Rows[0][3].ToString();
                ageBox.Text = dt.Rows[0][4].ToString();
                addressBox.Text = dt.Rows[0][5].ToString();
                genderBox.SelectedItem = dt.Rows[0][7].ToString().ToUpper();
                civilBox.SelectedItem = dt.Rows[0][6].ToString();
                uniquePass = dt.Rows[0][15].ToString();
                idPass = searchBox.Text = dt.Rows[0][0].ToString();
                employeeNum.Text = dt.Rows[0][16].ToString();
                packageBox.SelectedItem = dt.Rows[0][11].ToString();
                paymentStatusBox.SelectedItem = dt.Rows[0][9].ToString();
                companyBox.Text = dt.Rows[0][12].ToString();
                accBox.Text = dt.Rows[0][13].ToString();
                vitalSignStatusBox.SelectedItem = checkerNull(dt.Rows[0][17].ToString(), vitalSignStatusBox);                cbcStatusBox.SelectedItem = checkerNull(dt.Rows[0][18].ToString(), cbcStatusBox);                medStatusBox.SelectedItem = checkerNull(dt.Rows[0][20].ToString(), medStatusBox);
                eyeStatusBox.SelectedItem = checkerNull(dt.Rows[0][22].ToString(), eyeStatusBox);
                xrayStatusBox.SelectedItem = checkerNull(dt.Rows[0][23].ToString(), xrayStatusBox);
                UriStatusBox.SelectedItem = checkerNull(dt.Rows[0][24].ToString(), UriStatusBox);
                StoolStatusBox.SelectedItem = checkerNull(dt.Rows[0][25].ToString(), StoolStatusBox);
                /*if (vitalSignStatusBox.SelectedItem.ToString() == "DONE")
                {
                    dateVital.Enabled = false;
                    vitalSignStatusBox.Enabled = false;
                }

                if (cbcStatusBox.SelectedItem.ToString() == "DONE")
                {
                    dateCBC.Enabled = false;
                    cbcStatusBox.Enabled = false;
                }
                if (medStatusBox.SelectedItem.ToString() == "DONE")
                {
                    dateMedCert.Enabled = false;
                    medStatusBox.Enabled = false;
                }
                if (eyeStatusBox.SelectedItem.ToString() == "DONE")
                {
                    dateEye.Enabled = false;
                    eyeStatusBox.Enabled = false;
                }
                if (xrayStatusBox.SelectedItem.ToString() == "DONE")
                {
                    dateXRAY.Enabled = false;
                    xrayStatusBox.Enabled = false;
                }

                if (UriStatusBox.SelectedItem.ToString() == "DONE")
                {
                    dateUrine.Enabled = false;
                    UriStatusBox.Enabled = false;
                }
                if (StoolStatusBox.SelectedItem.ToString() == "DONE")
                {
                    dateStool.Enabled = false;
                    StoolStatusBox.Enabled = false;
                }
                */
                //        bdayBox.Value = date1;
                packageBox.SelectedItem = dt.Rows[0][11].ToString();
                paymentStatusBox.SelectedItem = dt.Rows[0][9].ToString();
                companyBox.Text = dt.Rows[0][12].ToString();
                accBox.Text = dt.Rows[0][13].ToString();                vitalSignStatusBox.SelectedItem = checkerNull(dt.Rows[0][17].ToString(),vitalSignStatusBox);                cbcStatusBox.SelectedItem = checkerNull(dt.Rows[0][18].ToString(),cbcStatusBox);                medStatusBox.SelectedItem = checkerNull(dt.Rows[0][21].ToString(),medStatusBox);
                eyeStatusBox.SelectedItem = checkerNull(dt.Rows[0][24].ToString(),eyeStatusBox);
                xrayStatusBox.SelectedItem = checkerNull(dt.Rows[0][25].ToString(),xrayStatusBox);
                UriStatusBox.SelectedItem = checkerNull(dt.Rows[0][26].ToString(),UriStatusBox);
                StoolStatusBox.SelectedItem = checkerNull(dt.Rows[0][27].ToString(),StoolStatusBox);

               
            if (Convert.ToInt32(ageBox.Text) < 30)
                    {
                    papsStatusBox.SelectedItem = "N/A";
                    papsStatusBox.Enabled = false;
                    fbsStatusBox.SelectedItem = "N/A";
                    fbsStatusBox.Enabled = false;
                    ecgStatusBox.SelectedItem = "N/A";
                    ecgStatusBox.Enabled = false;
                }
               else if (genderBox.SelectedItem.ToString().ToUpper() == "MALE")
                {
                    papsStatusBox.SelectedItem = "N/A";
                    papsStatusBox.Enabled = false;
                    fbsStatusBox.SelectedItem = checkerNull(dt.Rows[0][19].ToString(),fbsStatusBox);
                    fbsStatusBox.Enabled = true;
                    ecgStatusBox.SelectedItem = checkerNull(dt.Rows[0][21].ToString(),ecgStatusBox);
                    ecgStatusBox.Enabled = true;
                }
                else
                {
                    papsStatusBox.SelectedItem = checkerNull(dt.Rows[0][22].ToString(),papsStatusBox);
                    papsStatusBox.Enabled = true;
                    fbsStatusBox.SelectedItem = checkerNull(dt.Rows[0][19].ToString(),fbsStatusBox);
                    fbsStatusBox.Enabled = true;
                    ecgStatusBox.SelectedItem = checkerNull(dt.Rows[0][21].ToString(),ecgStatusBox);
                    ecgStatusBox.Enabled = true;

                }


                clearAll.Enabled = true;
                submit.Enabled = true;
            }
           catch (Exception en)
            {
                MessageBox.Show("No matching record found.");
                Console.WriteLine(en.Message);
            }
        }
           
        private void InitializeDropDowns()
        {
            vitalSignStatusBox.SelectedIndex = cbcStatusBox.SelectedIndex = fbsStatusBox.SelectedIndex = medStatusBox.SelectedIndex = ecgStatusBox.SelectedIndex = papsStatusBox.SelectedIndex = eyeStatusBox.SelectedIndex = xrayStatusBox.SelectedIndex = UriStatusBox.SelectedIndex = StoolStatusBox.SelectedIndex = 0;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            checkRemarks();
            string sqlString = "";
            sqlString = "UPDATE dbo.mjrl2020 set VITAL_SIGNS = '" + statusHolder[0] + "',CBC = '" + statusHolder[1] + "',FBS = '" + statusHolder[2] + "',Cholesterol = '" + statusHolder[0] + "',Physical_Examination = '" + statusHolder[3] + "', ECG = '" + statusHolder[4] + "', PAP_Smear = '" + statusHolder[5] + "',Eye_Check_up = '" + statusHolder[6] + "', Chest_Xray = '" + statusHolder[7] + "',Urine_Exam = '" + statusHolder[8] + "',Stool_Exam = '" + statusHolder[9] + "', Remarks = '" + remarks + "'       WHERE id = '" + idPass + "'";
            Console.WriteLine(sqlString);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True"); // making connection   
            SqlCommand sda = new SqlCommand(sqlString, conn);
            conn.Open();
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Saved succesfully!");
        }

        private void datePick(string date,ComboBox theBox)
        {
            DateTime dates = DateTime.ParseExact(date, "MM-dd-yyyy" ,null);
            if (theBox.Name == "vitalSignStatusBox")
                dateVital.Value = dates;
            else if (theBox.Name == "cbcStatusBox")
                dateCBC.Value = dates;
            else if (theBox.Name == "fbsStatusBox")
                dateFBS.Value = dates;
            else if (theBox.Name == "medStatusBox")
                dateMedCert.Value = dates;
            else if (theBox.Name == "ecgStatusBox")
                dateECG.Value = dates;
            else if (theBox.Name == "papsStatusBox")
                datePAPS.Value = dates;
            else if (theBox.Name == "eyeStatusBox")
                dateEye.Value = dates;
            else if (theBox.Name == "xrayStatusBox")
                dateXRAY.Value = dates;
            else if (theBox.Name == "UriStatusBox")
                dateUrine.Value = dates;
            else if (theBox.Name == "StoolStatusBox")
                dateStool.Value = dates;
        }

        private string checkerNull(string stringValue, ComboBox theBox)
        {
            if (stringValue == "" || stringValue == null)
                return ("PENDING");
            else if (stringValue.Contains("DONE"))
            {
               string[] s = stringValue.Split(' ');
               Console.WriteLine(s[1]);
                datePick(s[1], theBox);
                return ("DONE");
            }
            else
                return (stringValue);
        }

        private void checkRemarks()
        {
            if (vitalSignStatusBox.SelectedItem.ToString() == "PENDING" || cbcStatusBox.SelectedItem.ToString() == "PENDING" || fbsStatusBox.SelectedItem.ToString() == "PENDING" || medStatusBox.SelectedItem.ToString() == "PENDING" || ecgStatusBox.SelectedItem.ToString() == "PENDING" || papsStatusBox.SelectedItem.ToString() == "PENDING" || eyeStatusBox.SelectedItem.ToString() == "PENDING" || xrayStatusBox.SelectedItem.ToString() == "PENDING" || UriStatusBox.SelectedItem.ToString() == "PENDING" || StoolStatusBox.SelectedItem.ToString() == "PENDING")
            {
                remarks = "INCOMPLETE";
            }
            else
            { 
                remarks = "COMPLETE";
            }

        }

        private void OffsiteEntEdtForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
            SqlCommand sdaLast = new SqlCommand("SELECT lastName FROM dbo.mjrl2020", conn);
            SqlCommand sdaFirst = new SqlCommand("SELECT givenName FROM dbo.mjrl2020 WHERE lastName ='" + lastBox.Text + "'", conn);

            conn.Open();
            //last name
            SqlDataReader dr = sdaLast.ExecuteReader();

            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                Collection.Add(dr.GetString(0));
            }

            lastBox.AutoCompleteCustomSource = Collection;

            dr.Close();

            conn.Close();
        }

        private void lastBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
            SqlCommand sdaFirst = new SqlCommand("SELECT givenName FROM dbo.mjrl2020 WHERE lastName ='" + lastBox.Text + "'", conn);

            conn.Open();
            //guven name

            SqlDataReader dr1 = sdaFirst.ExecuteReader();

            AutoCompleteStringCollection Collection1 = new AutoCompleteStringCollection();

            while (dr1.Read())
            {
                Collection1.Add(dr1.GetString(0));
            }

            firstBox.AutoCompleteCustomSource = Collection1;

            dr1.Close();

            conn.Close();
        }

        private void MiddleInitialFill(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
            SqlDataAdapter sdaSearch = new SqlDataAdapter("SELECT * FROM dbo.mjrl2020 WHERE lastName = '" + lastBox.Text + "' AND givenName = '" + firstBox.Text + "'", conn);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sdaSearch.Fill(dt);
            //    DateTime date1 = Convert.ToDateTime(dt.Rows[0][14].ToString()); Not needed yet
            
            middleBox.Text = dt.Rows[0][3].ToString();
            ageBox.Text = dt.Rows[0][4].ToString();
            addressBox.Text = dt.Rows[0][5].ToString();
            genderBox.SelectedItem = dt.Rows[0][7].ToString().ToUpper();
            civilBox.SelectedItem = dt.Rows[0][6].ToString();
            uniquePass = dt.Rows[0][15].ToString();
            idPass = searchBox.Text = dt.Rows[0][0].ToString();
            employeeNum.Text = dt.Rows[0][16].ToString();
            packageBox.SelectedItem = dt.Rows[0][11].ToString();
            paymentStatusBox.SelectedItem = dt.Rows[0][9].ToString();
            companyBox.Text = dt.Rows[0][12].ToString();
            accBox.Text = dt.Rows[0][13].ToString();
            vitalSignStatusBox.SelectedItem = checkerNull(dt.Rows[0][17].ToString(), vitalSignStatusBox);
            cbcStatusBox.SelectedItem = checkerNull(dt.Rows[0][18].ToString(), cbcStatusBox);
            medStatusBox.SelectedItem = checkerNull(dt.Rows[0][21].ToString(), medStatusBox);
            eyeStatusBox.SelectedItem = checkerNull(dt.Rows[0][24].ToString(), eyeStatusBox);
            xrayStatusBox.SelectedItem = checkerNull(dt.Rows[0][25].ToString(), xrayStatusBox);
            UriStatusBox.SelectedItem = checkerNull(dt.Rows[0][26].ToString(), UriStatusBox);
            StoolStatusBox.SelectedItem = checkerNull(dt.Rows[0][27].ToString(), StoolStatusBox);

            /*if (vitalSignStatusBox.SelectedItem.ToString() == "DONE")
            {
                dateVital.Enabled = false;
                vitalSignStatusBox.Enabled = false;
            }

            if (cbcStatusBox.SelectedItem.ToString() == "DONE")
            {
                dateCBC.Enabled = false;
                cbcStatusBox.Enabled = false;
            }
            if (medStatusBox.SelectedItem.ToString() == "DONE")
            {
                dateMedCert.Enabled = false;
                medStatusBox.Enabled = false;
            }
            if (eyeStatusBox.SelectedItem.ToString() == "DONE")
            {
                dateEye.Enabled = false;
                eyeStatusBox.Enabled = false;
            }
            if (xrayStatusBox.SelectedItem.ToString() == "DONE")
            {
                dateXRAY.Enabled = false;
                xrayStatusBox.Enabled = false;
            }

            if (UriStatusBox.SelectedItem.ToString() == "DONE")
            {
                dateUrine.Enabled = false;
                UriStatusBox.Enabled = false;
            }
            if (StoolStatusBox.SelectedItem.ToString() == "DONE")
            {
                dateStool.Enabled = false;
                StoolStatusBox.Enabled = false;
            }
            */

            if (Convert.ToInt32(ageBox.Text) < 30)
            {
                papsStatusBox.SelectedItem = "N/A";
                papsStatusBox.Enabled = false;
                fbsStatusBox.SelectedItem = "N/A";
                fbsStatusBox.Enabled = false;
                ecgStatusBox.SelectedItem = "N/A";
                ecgStatusBox.Enabled = false;
            }
            else if (genderBox.SelectedItem.ToString().ToUpper() == "MALE")
            {
                papsStatusBox.SelectedItem = "N/A";
                papsStatusBox.Enabled = false;
                fbsStatusBox.SelectedItem = checkerNull(dt.Rows[0][19].ToString(), fbsStatusBox);
                fbsStatusBox.Enabled = true;
                ecgStatusBox.SelectedItem = checkerNull(dt.Rows[0][21].ToString(), ecgStatusBox);
                ecgStatusBox.Enabled = true;
            }
            else
            {
                papsStatusBox.SelectedItem = checkerNull(dt.Rows[0][22].ToString(), papsStatusBox);
                papsStatusBox.Enabled = true;
                fbsStatusBox.SelectedItem = checkerNull(dt.Rows[0][19].ToString(), fbsStatusBox);
                fbsStatusBox.Enabled = true;
                ecgStatusBox.SelectedItem = checkerNull(dt.Rows[0][21].ToString(), ecgStatusBox);
                ecgStatusBox.Enabled = true;

            }



        }

        private void firstBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                MiddleInitialFill(new object(), new EventArgs());
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            lastBox.Text = String.Empty;            firstBox.Text = String.Empty;            middleBox.Text = String.Empty;            ageBox.Text = String.Empty;            addressBox.Text = String.Empty;            civilBox.SelectedIndex = -1;            genderBox.SelectedIndex = -1;
            searchBox.Text = String.Empty;
            bdayBox.Value = DateTime.Now;
            packageBox.SelectedIndex = -1;
            companyBox.Text = String.Empty;
            accBox.Text = String.Empty;
            paymentStatusBox.SelectedIndex = -1;
            employeeNum.Text = String.Empty;
            searchBox.Text = String.Empty;
            InitializeDropDowns();
            papsStatusBox.Enabled = true;
            ecgStatusBox.Enabled = true;
            fbsStatusBox.Enabled = true;
        }

       /*  private void dateHolder()
        {
            if (vitalSignStatusBox.SelectedItem.ToString() == "DONE")
                statusHolder[0] = vitalSignStatusBox.SelectedItem.ToString() + dateVital.Value.Date.ToString();
            else
                statusHolder[0] = vitalSignStatusBox.SelectedItem.ToString();
            if (cbcStatusBox.SelectedItem.ToString() == "DONE")
                statusHolder[1] = cbcStatusBox.SelectedItem.ToString() + dateVital.Value.Date.ToString();
            else
                statusHolder[1] = cbcStatusBox.SelectedItem.ToString();
            if (fbsStatusBox.SelectedItem.ToString() == "DONE")
                statusHolder[2] = fbsStatusBox.SelectedItem.ToString() + dateVital.Value.Date.ToString();
            else
                statusHolder[2] = fbsStatusBox.SelectedItem.ToString();
            if (medStatusBox.SelectedItem.ToString() == "DONE")
                statusHolder[3] = medStatusBox.SelectedItem.ToString() + dateVital.Value.Date.ToString();
            else
                statusHolder[3] = medStatusBox.SelectedItem.ToString();
            if (ecgStatusBox.SelectedItem.ToString() == "DONE")
                statusHolder[4] = ecgStatusBox.SelectedItem.ToString() + dateVital.Value.Date.ToString();
            else
                statusHolder[4] = ecgStatusBox.SelectedItem.ToString();
            if (papsStatusBox.SelectedItem.ToString() == "DONE")
                statusHolder[5] = papsStatusBox.SelectedItem.ToString() + dateVital.Value.Date.ToString();
            else
                statusHolder[5] = papsStatusBox.SelectedItem.ToString();
            if (eyeStatusBox.SelectedItem.ToString() == "DONE")
                statusHolder[6] = eyeStatusBox.SelectedItem.ToString() + dateVital.Value.Date.ToString();
            else
                statusHolder[6] = eyeStatusBox.SelectedItem.ToString();
            if (xrayStatusBox.SelectedItem.ToString() == "DONE")
                statusHolder[7] = xrayStatusBox.SelectedItem.ToString() + dateVital.Value.Date.ToString();
            else
                statusHolder[7] = xrayStatusBox.SelectedItem.ToString();
            if (UriStatusBox.SelectedItem.ToString() == "DONE")
                statusHolder[8] = UriStatusBox.SelectedItem.ToString() + dateVital.Value.Date.ToString();
            else
                statusHolder[8] = UriStatusBox.SelectedItem.ToString();
            if (StoolStatusBox.SelectedItem.ToString() == "DONE")
                statusHolder[9] = StoolStatusBox.SelectedItem.ToString() + dateVital.Value.Date.ToString();
            else
                statusHolder[9] = StoolStatusBox.SelectedItem.ToString();



       }
     */
        private void dateEnablerEX(object sender, EventArgs e)
        {
            if (vitalSignStatusBox.Text.ToString() != "DONE")
            { statusHolder[0] = vitalSignStatusBox.Text.ToString();
                Console.WriteLine(statusHolder[0]);
                dateVital.Enabled = false; }
            else
            { dateVital.Enabled = true;
                statusHolder[0] = vitalSignStatusBox.Text.ToString() + " " + dateVital.Value.Date.ToString("MM-dd-yyyy"); }
            if (cbcStatusBox.Text.ToString() != "DONE")
            { dateCBC.Enabled = false;
                statusHolder[1] = cbcStatusBox.Text.ToString(); }
            else
            { dateCBC.Enabled = true;
                statusHolder[1] = cbcStatusBox.Text.ToString() + " " + dateCBC.Value.Date.ToString("MM-dd-yyyy"); }
            if (fbsStatusBox.Text.ToString() != "DONE")
            {
                dateFBS.Enabled = false;
                statusHolder[2] = fbsStatusBox.Text.ToString() ;
            }
            else
                {
                    dateFBS.Enabled = true;
                statusHolder[2] = fbsStatusBox.Text.ToString() + " " + dateFBS.Value.Date.ToString("MM-dd-yyyy");
            }
            if (medStatusBox.Text.ToString() != "DONE")
                    {
                        dateMedCert.Enabled = false;
            statusHolder[3] = medStatusBox.Text.ToString();
            }
            else
                        {
                            dateMedCert.Enabled = true;
            statusHolder[3] = medStatusBox.Text.ToString() + " " + dateMedCert.Value.Date.ToString("MM-dd-yyyy");

            }
            if (ecgStatusBox.Text.ToString() != "DONE")
                            {
                                dateECG.Enabled = false;
            statusHolder[4] = ecgStatusBox.Text.ToString();
            }
            else
                                {
                                    dateECG.Enabled = true;
            statusHolder[4] = ecgStatusBox.Text.ToString() + " " + dateECG.Value.Date.ToString("MM-dd-yyyy");

            }
            if (papsStatusBox.Text.ToString() != "DONE")
                                    {
                                        datePAPS.Enabled = false;
            statusHolder[5] = papsStatusBox.Text.ToString();
            }
            else
                                        {
                                            datePAPS.Enabled = true;
            statusHolder[5] = papsStatusBox.Text.ToString() + " " + datePAPS.Value.Date.ToString("MM-dd-yyyy");

            }
            if (eyeStatusBox.Text.ToString() != "DONE")
                                            {
                                                dateEye.Enabled = false;
            statusHolder[6] = eyeStatusBox.Text.ToString();
            }
            else
                                                {
                                                    dateEye.Enabled = true;
            statusHolder[6] = eyeStatusBox.Text.ToString() + " " + dateEye.Value.Date.ToString("MM-dd-yyyy");

            }
            if (xrayStatusBox.Text.ToString() != "DONE")
                                                    {
                                                        dateXRAY.Enabled = false;
                statusHolder[7] = xrayStatusBox.Text.ToString();
            }
            else
                                                        {
                                                            dateXRAY.Enabled = true;
            statusHolder[7] = xrayStatusBox.Text.ToString() + " " + dateXRAY.Value.Date.ToString("MM-dd-yyyy");

            }
            if (UriStatusBox.Text.ToString() != "DONE")
                                                            {
                                                                dateUrine.Enabled = false;
            statusHolder[8] = UriStatusBox.Text.ToString();
            }
            else
                                                                {
                                                                    dateUrine.Enabled = true;
            statusHolder[8] = UriStatusBox.Text.ToString() + " " + dateUrine.Value.Date.ToString("MM-dd-yyyy");
            }
            if (StoolStatusBox.Text.ToString() != "DONE")
                                                                    {
                                                                        dateStool.Enabled = false;
                statusHolder[9] = StoolStatusBox.Text.ToString();
            }
            else
                                                                        {
                                                                            dateStool.Enabled = true;
            statusHolder[9] = StoolStatusBox.Text.ToString() + " " + dateStool.Value.Date.ToString("MM-dd-yyyy");
            }




        }
    }
}
