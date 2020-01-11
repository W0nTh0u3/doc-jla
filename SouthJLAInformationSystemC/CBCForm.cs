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
    public partial class CBCForm : Form
    {
        public string passID, type, gender, civilStat, bday;
        private string[] vMin, vMax, vUnits;
        public CBCForm(string uniqueID, string idPass, string type)
        {
            InitializeComponent();

            this.type = type;

            wbcTextBox.Text = "";
            rbcTextBox.Text = "";
            hgbTextBox.Text = "";
            hctTextBox.Text = "";
            plateletsTextBox.Text = "";
            neutrophilTextBox.Text = "";
            lymphocytesTextBox.Text = "";
            monocyteTextBox.Text = "";

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

            //PULLOUT DICTIONARY
            SqlDataAdapter sdaDic = new SqlDataAdapter("SELECT units, min, max FROM dbo.HematologyDictionary WHERE gender = '" + gender + "'", conn); //logic to find the right normal values
            DataTable dtDic = new DataTable(); //this is creating a virtual table  
            sdaDic.Fill(dtDic);

            passID = idPass;

            MinMaxStorage(dtDic);
            wbcUnit.Text = dtDic.Rows[0][0].ToString();
            //wbcRange.Text = "(" + dtDic.Rows[0][1].ToString() + " - " + dtDic.Rows[0][2].ToString() + ")";
            wbcRange.Text = "(" + vMin[0] + " - " + vMax[0] + ")";
            rbcUnit.Text = dtDic.Rows[1][0].ToString();
            //rbcRange.Text = "(" + dtDic.Rows[1][1].ToString() + " - " + dtDic.Rows[1][2].ToString() + ")";
            rbcRange.Text = "(" + vMin[1] + " - " + vMax[1] + ")";
            hgbUnit.Text = dtDic.Rows[2][0].ToString();
            //hgbRange.Text = "(" + dtDic.Rows[2][1].ToString() + " - " + dtDic.Rows[2][2].ToString() + ")"; 
            hgbRange.Text = "(" + vMin[2] + " - " + vMax[2] + ")";
            hctUnit.Text = dtDic.Rows[3][0].ToString();
            //hctRange.Text = "(" + dtDic.Rows[3][1].ToString() + " - " + dtDic.Rows[3][2].ToString() + ")"; 
            hctRange.Text = "(" + vMin[3] + " - " + vMax[3] + ")";
            plateletUnit.Text = dtDic.Rows[4][0].ToString();
            //plateletRange.Text = "(" + dtDic.Rows[4][1].ToString() + " - " + dtDic.Rows[4][2].ToString() + ")";
            plateletRange.Text = "(" + vMin[4] + " - " + vMax[4] + ")";
            neutrophilUnit.Text = dtDic.Rows[5][0].ToString();
            //neutrophilRange.Text = "(" + dtDic.Rows[5][1].ToString() + " - " + dtDic.Rows[5][2].ToString() + ")"; 
            neutrophilRange.Text = "(" + vMin[5] + " - " + vMax[5] + ")";
            lymphUnit.Text = dtDic.Rows[6][0].ToString();
            //lymphRange.Text = "(" + dtDic.Rows[6][1].ToString() + " - " + dtDic.Rows[6][2].ToString() + ")"; 
            lymphRange.Text = "(" + vMin[6] + " - " + vMax[6] + ")";
            monoUnit.Text = dtDic.Rows[7][0].ToString();
            //monoRange.Text = "(" + dtDic.Rows[7][1].ToString() + " - " + dtDic.Rows[7][2].ToString() + ")"; 
            monoRange.Text = "(" + vMin[7] + " - " + vMax[7] + ")";

            if (type == "Save changes")
            {
                SqlConnection conn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
                SqlDataAdapter sdaFill = new SqlDataAdapter("SELECT * FROM dbo.Hematology WHERE ofw_id = '" + passID + "'", conn1);
                DataTable dt2 = new DataTable(); //this is creating a virtual table  
                sdaFill.Fill(dt2);

                wbcTextBox.Text = dt2.Rows[0][1].ToString();
                rbcTextBox.Text = dt2.Rows[0][2].ToString();
                hgbTextBox.Text = dt2.Rows[0][3].ToString();
                hctTextBox.Text = dt2.Rows[0][4].ToString();
                plateletsTextBox.Text = dt2.Rows[0][5].ToString();
                neutrophilTextBox.Text = dt2.Rows[0][6].ToString();
                lymphocytesTextBox.Text = dt2.Rows[0][7].ToString();
                monocyteTextBox.Text = dt2.Rows[0][8].ToString();
            }


        }


        private void SubmitCBC_Click(object sender, EventArgs e)
        {
            string sqlString;
            vUnits = new string []{ wbcUnit.Text, rbcUnit.Text, hgbUnit.Text, hctUnit.Text, plateletUnit.Text, neutrophilUnit.Text, lymphUnit.Text, monoUnit.Text};
            if (type == "Enter")
            {
                sqlString = "INSERT INTO dbo.Hematology (wbc, rbc, hgb, hct, platelets, neutrophil, lymphocytes, monocyte, ofw_id) VALUES('" + wbcTextBox.Text + "','" + rbcTextBox.Text + "','" + hgbTextBox.Text + "','" + hctTextBox.Text + "','" + plateletsTextBox.Text + "','" + neutrophilTextBox.Text + "','" + lymphocytesTextBox.Text + "','" + monocyteTextBox.Text + "','" + passID + "')";
                string[] valueString = { wbcTextBox.Text, rbcTextBox.Text, hgbTextBox.Text, hctTextBox.Text, plateletsTextBox.Text, neutrophilTextBox.Text, lymphocytesTextBox.Text, monocyteTextBox.Text };
                string[] patientInfoValue = {Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat , FormNBox.Text};
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue, vMin, vMax, vUnits);
                verifyPopUp.Show();
            }
            else if (type == "Save changes")
            {
                sqlString = "UPDATE dbo.Hematology SET wbc = '" + wbcTextBox.Text + "', rbc = '" + rbcTextBox.Text + "', hgb = '" + hgbTextBox.Text + "', hct = '" + hctTextBox.Text + "', platelets = '" + plateletsTextBox.Text + "', neutrophil = '" + neutrophilTextBox.Text + "', lymphocytes = '" + lymphocytesTextBox.Text + "', monocyte = '" + monocyteTextBox.Text + "' WHERE ofw_id = '" + passID + "'";
                string[] valueString = { wbcTextBox.Text, rbcTextBox.Text, hgbTextBox.Text, hctTextBox.Text, plateletsTextBox.Text, neutrophilTextBox.Text, lymphocytesTextBox.Text, monocyteTextBox.Text };
                string[] patientInfoValue = {Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat , FormNBox.Text};
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
            vMin[2] = dtDic.Rows[2][1].ToString(); 
            vMax[2] = dtDic.Rows[2][2].ToString();
            vMin[3] = dtDic.Rows[3][1].ToString(); 
            vMax[3] = dtDic.Rows[3][2].ToString();
            vMin[4] = dtDic.Rows[4][1].ToString(); 
            vMax[4] = dtDic.Rows[4][2].ToString();
            vMin[5] = dtDic.Rows[5][1].ToString(); 
            vMax[5] = dtDic.Rows[5][2].ToString();
            vMin[6] = dtDic.Rows[6][1].ToString(); 
            vMax[6] = dtDic.Rows[6][2].ToString();
            vMin[7] = dtDic.Rows[7][1].ToString(); 
            vMax[7] = dtDic.Rows[7][2].ToString();
        }
    }
}
