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

        public OffsiteEntEdtForm()
        {
            InitializeComponent();
            Console.WriteLine("terminal: " + terminal);

        }

        private void cbcStatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (submit.Text == "Enter")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
                SqlCommand sda = new SqlCommand("INSERT INTO dbo.ofw (lastName, givenName, middleName, age, address, civilStatus, gender, dateFiled, paid, terminal, package, agency, account, birthDate) VALUES('" + lastBox.Text + "','" + firstBox.Text + "','" + middleBox.Text + "','" + ageBox.Text + "','" + addressBox.Text + "','" + civilBox.SelectedItem + "','" + genderBox.SelectedItem + "','" + dateFiledBox.Value.ToString("MM-dd-yyyy") + "','" + paymentStatusBox.SelectedItem + "','" + terminal + "','" + packageBox.SelectedItem + "','" + companyBox.Text + "','" + accBox.Text + "', '" + bdayBox.Value.Date.ToString() + "')", conn);
                conn.Open();
                sda.ExecuteNonQuery();
                conn.Close();

                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT MAX(id) FROM dbo.ofw", conn);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda1.Fill(dt);
                string patientID = dateFiledBox.Value.ToString("MM") + dateFiledBox.Value.ToString("dd");
                string unique = "MJRL-" + dt.Rows[0][0].ToString();

                Console.WriteLine("unique id:" + unique);

                SqlCommand sda2 = new SqlCommand("UPDATE dbo.ofw SET patientID = '" + unique + "' WHERE id = '" + dt.Rows[0][0].ToString() + "'", conn);
                conn.Open();
                sda2.ExecuteNonQuery();
                conn.Close();

                lastBox.Text = String.Empty;
                firstBox.Text = String.Empty;
                middleBox.Text = String.Empty;
                ageBox.Text = String.Empty;
                addressBox.Text = String.Empty;
                civilBox.SelectedIndex = -1;
                genderBox.SelectedIndex = -1;
                MessageBox.Show("Successful! This is your Patient ID: " + unique);
            }            else if (submit.Text == "Save" || submit.Text == "Save changes")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
                SqlCommand sda = new SqlCommand("UPDATE dbo.ofw  SET lastName = '" + lastBox.Text + "',  givenName =   '" + firstBox.Text + "', middleName = '" + middleBox.Text + "', age = '" + ageBox.Text + "', gender = '" + genderBox.SelectedItem + "', civilStatus = '" + civilBox.SelectedItem + "', address = '" + addressBox.Text + "',  agency =   '" + companyBox.Text + "',  paid =   '" + paymentStatusBox.SelectedItem + "',  terminal =   '" + terminal + "',  package =   '" + packageBox.SelectedItem + "',  account =   '" + accBox.Text + "',  birthDate =   '" + bdayBox.Value.Date.ToString() + "' WHERE id = '" + idPass + "'", conn);
                conn.Open();
                sda.ExecuteNonQuery();
                Console.WriteLine("Nagsave na");
                conn.Close();
                MessageBox.Show("Edit Successful!");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
