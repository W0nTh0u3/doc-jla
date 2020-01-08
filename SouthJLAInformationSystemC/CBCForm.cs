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
        public string passID, gender, civilStat;
        public CBCForm(string uniqueID, string idPass)
        {
            InitializeComponent();

            wbcTextBox.Text = "";
            rbcTextBox.Text = "";
            hgbTextBox.Text = "";
            hctTextBox.Text = "";
            plateletsTextBox.Text = "";
            neutrophilTextBox.Text = "";
            monocyteTextBox.Text = "";

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

            passID = idPass;

            

        }

        private void hematologyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hematologyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void CBCForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Hematology' table. You can move, or remove it, as needed.
            this.hematologyTableAdapter.Fill(this.databaseDataSet.Hematology);
        }

        private void SubmitCBC_Click(object sender, EventArgs e)
        {
            string sqlString = "INSERT INTO dbo.Hematology (wbc, rbc, hgb, hct, platelets, neutrophil, lymphocytes, monocyte, ofw_id) VALUES('" + wbcTextBox.Text + "','" + rbcTextBox.Text + "','" + hgbTextBox.Text + "','" + hctTextBox.Text + "','" + plateletsTextBox.Text + "','" + neutrophilTextBox.Text + "','" + lymphocytesTextBox.Text + "','" + monocyteTextBox.Text + "','" + passID + "')";
            string[] patientInfoValue = { idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat };
            string[] valueString = { wbcTextBox.Text, rbcTextBox.Text, hgbTextBox.Text, hctTextBox.Text, plateletsTextBox.Text, neutrophilTextBox.Text, lymphocytesTextBox.Text ,monocyteTextBox.Text };
            VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue);
            verifyPopUp.Show();
        }
    }
}
