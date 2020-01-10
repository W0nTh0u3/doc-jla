using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SouthJLAInformationSystemC
{
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
            dateFiledBox.Value = DateTime.Now;


        }

        private void dailyBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(listCombo.SelectedItem.ToString());
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   

            if (typeCombo.SelectedItem.ToString() == "TESTS")
            {
                DataTable dt = CreateTestTable(conn);
                dataGrid.DataSource = dt;
            }
            else if (typeCombo.SelectedItem.ToString() == "PACKAGES")
            {
                DataTable dt = CreatePackageTable(conn);
                dataGrid.DataSource = dt;
            }



        }

        private DataTable CreatePackageTable(SqlConnection conn)
        {
            Console.WriteLine("package selected: " + listCombo.SelectedItem.ToString());
            string sqlstring = "SELECT patientID, lastName, givenName, middleName, dateFiled, package, paid FROM dbo.ofw WHERE package = '" + listCombo.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, conn);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            return dt;
        }

        private DataTable CreateTestTable(SqlConnection conn)
        {
            string tableName = "";
            if (listCombo.SelectedItem.ToString() == "XRAY")
            {
                tableName = "xray";
            }
            else if (listCombo.SelectedItem.ToString() == "ECG")
            {
                tableName = "ecg";
            }
            else if (listCombo.SelectedItem.ToString() == "Hematology")
            {
                tableName = "Hematology";
            }
            else if (listCombo.SelectedItem.ToString() == "Blood Chemistry")
            {
                tableName = "Blood_Chemistry";
            }
            else if (listCombo.SelectedItem.ToString() == "Stool Exam")
            {
                tableName = "urineStool";
            }
            else if (listCombo.SelectedItem.ToString() == "Urinalysis")
            {
                tableName = "urineStool";
            }

            Console.WriteLine(tableName);

            string sqlstring = "SELECT patientID, lastName, givenName, middleName, dateFiled, package, paid FROM dbo.ofw WHERE id IN (SELECT ofw_id from dbo." + tableName + " )";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, conn);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            return dt;
        }

        private void TypeChange(object sender, EventArgs e)
        {
            listCombo.Items.Clear();

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection  
            if (typeCombo.SelectedItem.ToString() == "TESTS")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT tests FROM dbo.tests", conn);
                DataTable dt = new DataTable(); //this is creating a virtual table 
                sda.Fill(dt);

                for (int i = 0; i < 6; i++)
                {
                    listCombo.Items.Add(dt.Rows[i][0].ToString());
                }
            }

            else if (typeCombo.SelectedItem.ToString() == "PACKAGES")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT packageName FROM dbo.Packages", conn);
                DataTable dt = new DataTable(); //this is creating a virtual table 
                sda.Fill(dt);

                for (int i = 0; i < 1; i++)
                {
                    listCombo.Items.Add(dt.Rows[i][0].ToString());
                }
            }
        }
    }
}
