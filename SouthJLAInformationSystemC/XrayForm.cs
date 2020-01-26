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
    public partial class XrayForm : Form
    {
        public string passID, type, gender, civilStat, bday;

        private void SubmitCBC_Click(object sender, EventArgs e)
        {
            string sqlString;
            checkStatus();
            if (type == "Enter")
            {
                sqlString = "INSERT INTO dbo.xray ( viewPA, impression, status,ofw_id) VALUES('" + viewBox.Text + "', '" + remarksBox.Text + "','"+ MainMenu.statusXray + "', '" + passID + "')";
                string[] vMin = { "" };
                string[] vMax = { "" };
                string[] vUnits = { "" };
                string[] valueString = { viewBox.Text, remarksBox.Text };
                string[] patientInfoValue = { Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat, packageBox.Text, companyBox.Text, accBox.Text, DateBox.Text, FormNBox.Text }; 
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue, vMin, vMax, vUnits);
                verifyPopUp.Show();
            }
            else if (type == "Save changes")
            {
                sqlString = "UPDATE dbo.xray SET viewPA = '" + viewBox.Text + "', impression = '" + remarksBox.Text + "', status = '"+ MainMenu.statusXray + "' WHERE ofw_id = '" + passID + "'";
                string[] vMin = { "" };
                string[] vMax = { "" };
                string[] vUnits = { "" };
                string[] valueString = { viewBox.Text, remarksBox.Text };
                string[] patientInfoValue = { Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat, packageBox.Text, companyBox.Text, accBox.Text, DateBox.Text, FormNBox.Text }; 
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue, vMin, vMax, vUnits);
                verifyPopUp.Show();
            }
        }

        public XrayForm(string uniqueID, string idPass, string type)
        {
            InitializeComponent();

            this.type = type;

            //pullot physician
            physicianBox.Items.Clear();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection  
            SqlDataAdapter sda = new SqlDataAdapter("SELECT name, title FROM dbo.physician WHERE cbc = '1'", con);
            DataTable dt = new DataTable(); //this is creating a virtual table 
            sda.Fill(dt);

            string full = String.Empty;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                full = dt.Rows[i][0].ToString() + ", " + dt.Rows[i][1].ToString();
                physicianBox.Items.Add(full);
            }

            viewBox.Text = "";
            remarksBox.Text = "";
            MainMenu.statusXray = "ENT";
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
                SqlDataAdapter sdaFill = new SqlDataAdapter("SELECT * FROM dbo.xray WHERE ofw_id = '" + passID + "'", conn1);
                DataTable dt2 = new DataTable(); //this is creating a virtual table  
                sdaFill.Fill(dt2);

                viewBox.Text = dt2.Rows[0][1].ToString();
                remarksBox.Text = dt2.Rows[0][2].ToString();
                MainMenu.statusXray = dt2.Rows[0][4].ToString();
            }
        }
        private void checkStatus()
        {
            if (viewBox.Text != "" && remarksBox.Text != "")
                MainMenu.statusXray = "COM";
            else if (viewBox.Text != "" || remarksBox.Text != "")
                MainMenu.statusXray = "RES";
            else
                MainMenu.statusXray = "ENT";
        }
    }
}
