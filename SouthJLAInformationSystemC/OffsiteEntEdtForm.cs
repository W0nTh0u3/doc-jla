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

        public OffsiteEntEdtForm()
        {
            InitializeComponent();
            InitializeDropDowns();
            Console.WriteLine("terminal: " + terminal);

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
                genderBox.SelectedItem = dt.Rows[0][7].ToString();
                civilBox.SelectedItem = dt.Rows[0][6].ToString();
                uniquePass = dt.Rows[0][15].ToString();
                idPass = dt.Rows[0][0].ToString();
                //        bdayBox.Value = date1;
                packageBox.SelectedItem = checkerNull(dt.Rows[0][11].ToString());
                paymentStatusBox.SelectedItem = checkerNull(dt.Rows[0][9].ToString());
                companyBox.Text = checkerNull(dt.Rows[0][12].ToString());
                accBox.Text = checkerNull(dt.Rows[0][13].ToString());                vitalSignStatusBox.SelectedItem = checkerNull(dt.Rows[0][17].ToString());                cbcStatusBox.SelectedItem = checkerNull(dt.Rows[0][18].ToString());                fbsStatusBox.SelectedItem = checkerNull(dt.Rows[0][19].ToString());
                medStatusBox.SelectedItem = checkerNull(dt.Rows[0][20].ToString());
                ecgStatusBox.SelectedItem = checkerNull(dt.Rows[0][21].ToString());
                papsStatusBox.SelectedItem = checkerNull(dt.Rows[0][22].ToString());
                eyeStatusBox.SelectedItem = checkerNull(dt.Rows[0][22].ToString());
                xrayStatusBox.SelectedItem = checkerNull(dt.Rows[0][23].ToString());
                UriStatusBox.SelectedItem = checkerNull(dt.Rows[0][24].ToString());
                StoolStatusBox.SelectedItem = checkerNull(dt.Rows[0][25].ToString());

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
            string sqlString;
            sqlString = "UPDATE dbo.mjrl2020 set VITAL_SIGNS = '"+vitalSignStatusBox.SelectedItem+ "',CBC = '" + cbcStatusBox.SelectedItem + "',FBS = '" + fbsStatusBox.SelectedItem + "',Cholesterol = '" + fbsStatusBox.SelectedItem + "',Physical_Examination = '" + medStatusBox.SelectedItem + "', ECG = '" + ecgStatusBox.SelectedItem + "', PAP_Smear = '" + papsStatusBox.SelectedItem + "',Eye_Check_up = '" + eyeStatusBox.SelectedItem + "', Chest_Xray = '" + xrayStatusBox.SelectedItem + "',Urine_Exam = '" + UriStatusBox.SelectedItem + "',Stool_Exam = '" + StoolStatusBox.SelectedItem + "'       WHERE id = '" + idPass + "'";
           Console.WriteLine(sqlString);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True"); // making connection   
            SqlCommand sda = new SqlCommand(sqlString, conn);
            conn.Open();
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Saved succesfully!");

        }

        private string checkerNull(string stringValue)
        {
            if (stringValue == "" || stringValue == null)
                return ("PENDING");
            else
                return (stringValue);
        }
    }
}
