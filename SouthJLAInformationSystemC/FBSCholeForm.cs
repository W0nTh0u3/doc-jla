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
    public partial class FBSCholeForm : Form
    {
        public string passID, type, gender, civilStat;
        private string[] vMin, vMax, vUnits;

        public FBSCholeForm(string uniqueID, string idPass, string type)
        {
            InitializeComponent();

            this.type = type;

            fbsBox.Text = "";
            cholBox.Text = "";

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

            //PULLOUT DICTIONARY
            SqlDataAdapter sdaDic = new SqlDataAdapter("SELECT units, min, max FROM dbo.BloodChemistryDictionary WHERE gender = '" + gender + "'", conn); //logic to find the right normal values
            DataTable dtDic = new DataTable(); //this is creating a virtual table  
            sdaDic.Fill(dtDic);

            passID = idPass;

            MinMaxStorage(dtDic);
            fbsUnit.Text = dtDic.Rows[0][0].ToString();
            //wbcRange.Text = "(" + dtDic.Rows[0][1].ToString() + " - " + dtDic.Rows[0][2].ToString() + ")";
            fbsRange.Text = "(" + vMin[0] + " - " + vMax[0] + ")";
            cholUnit.Text = dtDic.Rows[1][0].ToString();
            //rbcRange.Text = "(" + dtDic.Rows[1][1].ToString() + " - " + dtDic.Rows[1][2].ToString() + ")";
            cholRange.Text = "(" + vMin[1] + " - " + vMax[1] + ")";

            if (type == "Save changes")
            {
                SqlConnection conn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
                SqlDataAdapter sdaFill = new SqlDataAdapter("SELECT * FROM dbo.Blood_Chemistrty WHERE ofw_id = '" + passID + "'", conn1);
                DataTable dt2 = new DataTable(); //this is creating a virtual table  
                sdaFill.Fill(dt2);

                fbsBox.Text = dt2.Rows[0][2].ToString();
                cholBox.Text = dt2.Rows[0][5].ToString();
            }
        }

        private void SubmitCBC_Click(object sender, EventArgs e)
        {
            string sqlString;
            vUnits = new string[] { fbsUnit.Text, cholUnit.Text };
            if (type == "Enter")
            {
                sqlString = "INSERT INTO dbo.Blood_Chemistrty ( fbs, totalCholesterol, ofw_id) VALUES('" + fbsBox.Text + "', '" + cholBox.Text + "', '" + passID + "')";
                string[] valueString = { fbsBox.Text, cholBox.Text };
                string[] patientInfoValue = {Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat, FormNBox.Text };
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue, vMin, vMax, vUnits);
                verifyPopUp.Show();
            }
            else if (type == "Save changes")
            {
                sqlString = "UPDATE dbo.Blood_Chemistrty SET fbs = '" + fbsBox.Text + "', totalCholesterol = '" + cholBox.Text + "' WHERE ofw_id = '" + passID + "'";
                string[] valueString = { fbsBox.Text, cholBox.Text };
                string[] patientInfoValue = {Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat, FormNBox.Text };
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue, vMin, vMax, vUnits);
                verifyPopUp.Show();
            }
        }

        private void MinMaxStorage(DataTable dtDic)
        {
            int x = dtDic.Rows.Count;
            vMin = new string[x];
            vMax = new string[x];
            vMin[0] = dtDic.Rows[0][1].ToString();
            vMax[0] = dtDic.Rows[0][2].ToString();
            vMin[1] = dtDic.Rows[1][1].ToString();
            vMax[1] = dtDic.Rows[1][2].ToString();
        }
    }
}
