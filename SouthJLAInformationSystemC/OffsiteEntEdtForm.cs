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
            {                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
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
                idPass = dt.Rows[0][0].ToString();



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
        }
    }
}
