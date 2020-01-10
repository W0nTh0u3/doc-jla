﻿using System;
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
        public string passID, type, gender, civilStat;

        private void SubmitCBC_Click(object sender, EventArgs e)
        {
            string sqlString;

            if (type == "Enter")
            {
                sqlString = "INSERT INTO dbo.xray ( viewPA, impression, ofw_id) VALUES('" + viewBox.Text + "', '" + remarksBox.Text + "', '" + passID + "')";
                string[] valueString = { viewBox.Text, remarksBox.Text };
                string[] patientInfoValue = {Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat, FormNBox.Text };
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue);
                verifyPopUp.Show();
            }
            else if (type == "Save changes")
            {
                sqlString = "UPDATE dbo.xray SET viewPA = '" + viewBox.Text + "', impression = '" + remarksBox.Text + "' WHERE ofw_id = '" + passID + "'";
                string[] valueString = { viewBox.Text, remarksBox.Text };
                string[] patientInfoValue = {Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat, FormNBox.Text};
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue);
                verifyPopUp.Show();
            }
        }

        public XrayForm(string uniqueID, string idPass, string type)
        {
            InitializeComponent();

            this.type = type;

            viewBox.Text = "";
            remarksBox.Text = "";

            string idUnique = uniqueID;
            Console.WriteLine("patient unique ID: " + idUnique);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
            SqlDataAdapter sdaSearch = new SqlDataAdapter("SELECT * FROM dbo.ofw WHERE patientID = '" + idUnique + "'", conn);
            DataTable dt1 = new DataTable(); //this is creating a virtual table  
            sdaSearch.Fill(dt1);

            idBox.Text = dt1.Rows[0][19].ToString();
            lastBox.Text = dt1.Rows[0][1].ToString();
            firstBox.Text = dt1.Rows[0][2].ToString();
            middleBox.Text = dt1.Rows[0][3].ToString();
            ageBox.Text = dt1.Rows[0][4].ToString();
            addressBox.Text = dt1.Rows[0][10].ToString();
            gender = dt1.Rows[0][7].ToString();
            civilStat = dt1.Rows[0][8].ToString();


            gender = dt1.Rows[0][7].ToString();
            civilStat = dt1.Rows[0][8].ToString();

            passID = idPass;

            if (type == "Save changes")
            {
                SqlConnection conn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
                SqlDataAdapter sdaFill = new SqlDataAdapter("SELECT * FROM dbo.xray WHERE ofw_id = '" + passID + "'", conn1);
                DataTable dt2 = new DataTable(); //this is creating a virtual table  
                sdaFill.Fill(dt2);

                viewBox.Text = dt2.Rows[0][1].ToString();
                remarksBox.Text = dt2.Rows[0][2].ToString();
            }
        }
    }
}
