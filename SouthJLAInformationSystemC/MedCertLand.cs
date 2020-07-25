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
using System.Web.UI.WebControls;

namespace SouthJLAInformationSystemC
{
    public partial class MedCertLand : Form
    {
        public string passID, type, gender, civilStat, bday;

        private void SubmitCBC_Click(object sender, EventArgs e)
        {
            string sqlString;
            checkStatus();

            if (type == "Enter")
            {
                sqlString = "INSERT INTO dbo.MedCertLand (nationality,passport,position,contact,religion,destination,agency,hearing,sight," +
                    "colorVision,psych,medCondition,fit,physician,date,director,issuance,expiration,status, ofw_id) " +
                    "VALUES('" + nationalityBox.Text + "','" + passportBox.Text + "','" + positionBox.Text + "'," +
                    "'" + contactBox.Text + "','" + religionBox.Text + "','" + destinationBox.Text + "','" + agencyBox.Text + "'," +
                    "'" + hearingRadio.Checked + "','" + sightRadio.Checked + "','" + colorRadio.Checked + "','" + psychRadio.Checked + "'," +
                    "'" + medConditionRadio.Checked + "','" + fitRadio.Checked + "','" + physicianBox.Text + "'," +
                    "'" + examDate.Text + "','" + directorBox.Text + "','" + issuanceDate.Text + "','" + expirationDate.Text + "'," +
                    "'" + MainMenu.statusMedCertLand + "','" + passID + "')";
                string[] vMin = { "" };
                string[] vMax = { "" };
                string[] vUnits = { "" };
                string[] valueString = { nationalityBox.Text, passportBox.Text, positionBox.Text, contactBox.Text, 
                    religionBox.Text, destinationBox.Text, agencyBox.Text, hearingRadio.Checked.ToString(), sightRadio.Checked.ToString(), 
                    colorRadio.Checked.ToString(), psychRadio.Checked.ToString(), medConditionRadio.Checked.ToString(), fitRadio.Checked.ToString(), physicianBox.Text, 
                    examDate.Text, directorBox.Text, issuanceDate.Text, expirationDate.Text };
                string[] patientInfoValue = { Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat, packageBox.Text, companyBox.Text, accBox.Text, DateBox.Text, FormNBox.Text };
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue, vMin, vMax, vUnits);
                verifyPopUp.Show();
            }
            else if (type == "Save changes")
            {
                sqlString = "UPDATE dbo.MedCertLand SET nationality = '" + nationalityBox.Text + "',passport = '" + passportBox.Text + "'," +
                    "position = '" + positionBox.Text + "',contact = '" + contactBox.Text + "',religion = '" + religionBox.Text + "'," +
                    "destination = '" + destinationBox.Text + "',agency = '" + agencyBox.Text + "',hearing = '" + hearingRadio.Checked + "',sight = '" + sightRadio.Checked + "'," +
                    "colorVision = '" + colorRadio.Checked + "',psych = '" + psychRadio.Checked + "',medCondition = '" + medConditionRadio.Checked + "'," +
                    "fit = '" + fitRadio.Checked + "',physician = '" + physicianBox.Text + "',date = '" + examDate.Text + "'," +
                    "director = '" + directorBox.Text + "',issuance = '" + issuanceDate.Text + "',expiration = '" + expirationDate.Text + "'," +
                    "status = '" + MainMenu.statusMedCertLand + "' WHERE ofw_id = '" + passID + "'";
                string[] vMin = { "" };
                string[] vMax = { "" };
                string[] vUnits = { "" };
                string[] valueString = { nationalityBox.Text, passportBox.Text, positionBox.Text, contactBox.Text,
                    religionBox.Text, destinationBox.Text, agencyBox.Text, hearingRadio.Checked.ToString(), sightRadio.Checked.ToString(),
                    colorRadio.Checked.ToString(), psychRadio.Checked.ToString(), medConditionRadio.Checked.ToString(), fitRadio.Checked.ToString(), physicianBox.Text,
                    examDate.Text, directorBox.Text, issuanceDate.Text, expirationDate.Text };
                string[] patientInfoValue = { Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat, packageBox.Text, companyBox.Text, accBox.Text, DateBox.Text, FormNBox.Text };
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue, vMin, vMax, vUnits);
                verifyPopUp.Show();
            }


        }

        public MedCertLand(string uniqueID, string idPass, string type)
        {
            InitializeComponent();

            this.type = type;
            MainMenu.statusMedCertLand = "ENT";

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
                SqlDataAdapter sdaFill = new SqlDataAdapter("SELECT * FROM dbo.MedCertland WHERE ofw_id = '" + passID + "'", conn1);
                DataTable dt2 = new DataTable(); //this is creating a virtual table  
                sdaFill.Fill(dt2);

                nationalityBox.Text = dt2.Rows[0][1].ToString();
                passportBox.Text = dt2.Rows[0][2].ToString();
                positionBox.Text = dt2.Rows[0][3].ToString();
                contactBox.Text = dt2.Rows[0][4].ToString();
                religionBox.Text = dt2.Rows[0][5].ToString();
                destinationBox.Text = dt2.Rows[0][6].ToString();
                agencyBox.Text = dt2.Rows[0][7].ToString();

                hearingRadio.Checked = (bool)dt2.Rows[0][8];
                sightRadio.Checked = (bool)dt2.Rows[0][9];
                colorRadio.Checked = (bool)dt2.Rows[0][10];
                psychRadio.Checked = (bool)dt2.Rows[0][11];
                medConditionRadio.Checked = (bool)dt2.Rows[0][12];
                fitRadio.Checked = (bool)dt2.Rows[0][13];

                falseHearing.Checked = !(bool)dt2.Rows[0][8];
                falseSight.Checked = !(bool)dt2.Rows[0][9];
                falseColor.Checked = !(bool)dt2.Rows[0][10];
                falsePsych.Checked = !(bool)dt2.Rows[0][11];
                falseMed.Checked = !(bool)dt2.Rows[0][12];
                falseFit.Checked = !(bool)dt2.Rows[0][13];

                physicianBox.Text = dt2.Rows[0][14].ToString();
                examDate.Text = dt2.Rows[0][15].ToString();
                directorBox.Text = dt2.Rows[0][16].ToString();
                issuanceDate.Text = dt2.Rows[0][17].ToString();
                expirationDate.Text = dt2.Rows[0][18].ToString();
                MainMenu.statusMedCertLand = dt2.Rows[0][19].ToString();
            }
        }

        private void checkStatus()
        {
            if (nationalityBox.Text != "")
                MainMenu.statusMedCertLand = "COM";
            else
                MainMenu.statusMedCertLand = "ENT";
        }
    }
}
