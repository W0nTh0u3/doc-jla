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
    public partial class ECGForm : Form
    {
        public string passID, type, gender, civilStat, bday;

        private void SubmitCBC_Click(object sender, EventArgs e)
        {
            string sqlString;
            checkStatus();
            if (type == "Enter")
            {
                sqlString = "INSERT INTO dbo.ecg (impression,status, ofw_id) VALUES('" + ecgBox.Text + "','" +MainMenu.statusEcg +"','" + passID + "')";
                string[] vMin = { "" };
                string[] vMax = { "" };
                string[] vUnits = { "" };
                string[] valueString = { ecgBox.Text };
                string[] patientInfoValue = { Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat, packageBox.Text, companyBox.Text, accBox.Text, DateBox.Text, FormNBox.Text };
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue, vMin, vMax, vUnits);
                verifyPopUp.Show();
            }
            else if (type == "Save changes")
            {
                sqlString = "UPDATE dbo.ecg SET impression = '" + ecgBox.Text + "',status = '" + MainMenu.statusEcg + "' WHERE ofw_id = '" + passID + "'";
                string[] vMin = { "" };
                string[] vMax = { "" };
                string[] vUnits = { "" };
                string[] valueString = { ecgBox.Text };
                string[] patientInfoValue = { Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat, packageBox.Text, companyBox.Text, accBox.Text, DateBox.Text, FormNBox.Text };
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue, vMin, vMax, vUnits);
                verifyPopUp.Show();
            }
        }

        public ECGForm(string uniqueID, string idPass, string type)
        {
            InitializeComponent();

            this.type = type;
            MainMenu.statusEcg = "ENT";
            ecgBox.Text = "";

            string idUnique = uniqueID;
            Console.WriteLine("patient unique ID: " + idUnique);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
            SqlDataAdapter sdaSearch = new SqlDataAdapter("SELECT * FROM dbo.ofw WHERE patientID = '" + idUnique + "'", conn);
            DataTable dt1 = new DataTable(); //this is creating a virtual table  
            sdaSearch.Fill(dt1);

            idBox.Text = dt1.Rows[0][11].ToString();
            lastBox.Text = dt1.Rows[0][1].ToString();
            firstBox.Text = dt1.Rows[0][2].ToString();
            middleBox.Text = dt1.Rows[0][3].ToString();
            ageBox.Text = dt1.Rows[0][4].ToString();
            addressBox.Text = dt1.Rows[0][8].ToString();
            gender = dt1.Rows[0][6].ToString();
            civilStat = dt1.Rows[0][7].ToString();
            bday = dt1.Rows[0][5].ToString();

            packageBox.Items.Clear();
            packageBox.Items.Add(dt1.Rows[0][10].ToString());
            packageBox.SelectedItem = dt1.Rows[0][10].ToString();
            companyBox.Text = dt1.Rows[0][14].ToString();
            accBox.Text = dt1.Rows[0][15].ToString();
            DateBox.Text = dt1.Rows[0][9].ToString();

            passID = idPass;

            if (type == "Save changes")
            {
                SqlConnection conn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
                SqlDataAdapter sdaFill = new SqlDataAdapter("SELECT * FROM dbo.ecg WHERE ofw_id = '" + passID + "'", conn1);
                DataTable dt2 = new DataTable(); //this is creating a virtual table  
                sdaFill.Fill(dt2);

                ecgBox.Text = dt2.Rows[0][1].ToString();
                MainMenu.statusEcg = dt2.Rows[0][3].ToString();
            }
        }
        private void checkStatus()
        {
            if (ecgBox.Text != "")
                MainMenu.statusEcg = "COM";
            else
                MainMenu.statusEcg = "ENT";
        }
    }
}
