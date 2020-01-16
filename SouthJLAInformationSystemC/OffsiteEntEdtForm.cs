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
            Console.WriteLine("terminal: " + terminal);

        }

        private void cbcStatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
                SqlDataAdapter sdaSearch = new SqlDataAdapter("SELECT * FROM dbo.mjrl2020 WHERE patientID = '" + searchBox.Text + "'", conn);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sdaSearch.Fill(dt);

                DateTime date1 = Convert.ToDateTime(dt.Rows[0][5].ToString());

                lastBox.Text = dt.Rows[0][1].ToString();
                firstBox.Text = dt.Rows[0][2].ToString();
                middleBox.Text = dt.Rows[0][3].ToString();
                ageBox.Text = dt.Rows[0][4].ToString();
                addressBox.Text = dt.Rows[0][8].ToString();
                genderBox.SelectedItem = dt.Rows[0][6].ToString();
                civilBox.SelectedItem = dt.Rows[0][7].ToString();
                uniquePass = dt.Rows[0][11].ToString();
                idPass = dt.Rows[0][0].ToString();
                bdayBox.Value = date1;
                packageBox.SelectedItem = dt.Rows[0][10].ToString();
                paymentStatusBox.SelectedItem = dt.Rows[0][12].ToString();
                companyBox.Text = dt.Rows[0][14].ToString();
                accBox.Text = dt.Rows[0][15].ToString();


                clearAll.Enabled = true;

                submit.Enabled = true;
            }
            catch (Exception en)
            {
                MessageBox.Show("No matching record found.");
                Console.WriteLine(en.Message);
            }
        }
    }
}
