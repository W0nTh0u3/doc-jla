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
    public partial class MedExamForm : Form
    {
        public string passID, type, gender, civilStat;
        public string med1,med2, holder;
        public int med;
       

        private void SubmitCBC_Click(object sender, EventArgs e)
        {
            string sqlString;

            if (type == "Enter")
            {
   //             sqlString = "INSERT INTO dbo.Hematology (wbc, rbc, hgb, hct, platelets, neutrophil, lymphocytes, monocyte, ofw_id) VALUES('" + wbcTextBox.Text + "','" + rbcTextBox.Text + "','" + hgbTextBox.Text + "','" + hctTextBox.Text + "','" + plateletsTextBox.Text + "','" + neutrophilTextBox.Text + "','" + lymphocytesTextBox.Text + "','" + monocyteTextBox.Text + "','" + passID + "')";
   //             string[] valueString = { wbcTextBox.Text, rbcTextBox.Text, hgbTextBox.Text, hctTextBox.Text, plateletsTextBox.Text, neutrophilTextBox.Text, lymphocytesTextBox.Text, monocyteTextBox.Text };
    //            string[] patientInfoValue = { idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat };
    //            VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue);
     //           verifyPopUp.Show();
            }
            else if (type == "Save changes")
            {
     //           sqlString = "UPDATE dbo.Hematology SET wbc = '" + wbcTextBox.Text + "', rbc = '" + rbcTextBox.Text + "', hgb = '" + hgbTextBox.Text + "', hct = '" + hctTextBox.Text + "', platelets = '" + plateletsTextBox.Text + "', neutrophil = '" + neutrophilTextBox.Text + "', lymphocytes = '" + lymphocytesTextBox.Text + "', monocyte = '" + monocyteTextBox.Text + "' WHERE ofw_id = '" + passID + "'";
     //           string[] valueString = { wbcTextBox.Text, rbcTextBox.Text, hgbTextBox.Text, hctTextBox.Text, plateletsTextBox.Text, neutrophilTextBox.Text, lymphocytesTextBox.Text, monocyteTextBox.Text };
     //           string[] patientInfoValue = { idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat };
     //           VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue);
    //            verifyPopUp.Show();
            }
        }

        private static bool ComputeCondition(string value)
        {
            using (DataTable dt = new DataTable())
            {
                return(bool)(dt.Compute(value, null));
            }
        }
       
        private void encodeBinary()
        {
        
            for (int i=1;i<36;i++)
            {
                holder = $"y{i.ToString()}.Checked == true";
                if (ComputeCondition(holder))
                {
                    med += 10 ^ (i-1);
                }
            }

            /*        if (y1.Checked == true) med += 1;
             if (y2.Checked == true) med += 1;
 if (y3.Checked == true) med += 10;
 if (y4.Checked == true) med += 100;
 if (y5.Checked == true) med += 1000;
 if (y6.Checked == true) med += 10000;
 if (y7.Checked == true) med += 100000;
  if (y8.Checked == true) med += 1;
 if (y9.Checked == true) med += 1;
 if (y10.Checked == true) med += 1;
 if (y11.Checked == true) med += 1;
 if (y12.Checked == true) med += 1;
 if (y13.Checked == true) med += 1;
 if (y14.Checked == true) med += 1;
 if (y15.Checked == true) med += 1;
 if (y16.Checked == true) med += 1;
 if (y17.Checked == true) med += 1;
if (y18.Checked == true) med += 1;
 if (y19.Checked == true) med += 1;
 if (y20.Checked == true) med += 1;
 if (y21.Checked == true) med += 1;
 if (y22.Checked == true) med += 1;
  if (y23.Checked == true) med += 1;
 if (y24.Checked == true) med += 1;
 if (y25.Checked == true) med += 1;
 if (y26.Checked == true) med += 1;
  if (y27.Checked == true) med += 1;
 if (y28.Checked == true) med += 1;
 if (y29.Checked == true) med += 1;
 if (y30.Checked == true) med += 1;
 if (y31.Checked == true) med += 1;
 if (y32.Checked == true) med += 1;
 if (y33.Checked == true) med += 1;
 if (y34.Checked == true) med += 1;
 if (y35.Checked == true) med += 1;

            */
        }

        private void decryptBinary()
        {

        }

        public MedExamForm(string uniqueID, string idPass, string type)
        {
            InitializeComponent();

            this.type = type;
            
            childBox.Text = "";
            pastBox.Text = "";
            presentBox1.Text = "";
            presentBox2.Text = "";
            surgeriesBox.Text = "";
            hospitizationsBox.Text = "";
            smokeBox.Text = "";
            alcoholBox.Text = "";
            mensBox.Text = "";
            lastBox.Text = "";
            othersBox.Text = "";
            eyesBox.Text = "";
            mouthBox.Text = "";
            cardioBox.Text = "";
            respiratoryBox.Text = "";
            genitourinaryBox.Text = "";
            musculoskeletalBox.Text = "";
            skinBox.Text = "";
            neurologicalBox.Text = "";
            endocrineBox.Text = "";
            hemaBox.Text = "";
            othersBox2.Text = "";
            heightBox.Text = "";
            bpBox.Text = "";
            weightBox.Text = "";
            prBox.Text = "";
            bmiBox.Text = "";
            rrBox.Text = "";
            rightBox.Text = "";
            leftBox.Text = "";
            generalBox.Text = "";
            reviewSkinBox.Text = "";
            headNeckBox.Text = "";
            EENBox.Text = "";
            mouthThroatBox.Text = "";
            chestLungsBox.Text = "";
            breastBox.Text = "";
            backBox.Text = "";
            heartReviewBox.Text = "";
            abdomenBox.Text = "";
            extremitiesBox.Text = "";
            neurlogicalReviewBox.Text = "";
            rectalBox.Text = "";
            genitaliaBox.Text = "";
            impressionBox.Text = "";
            recommendationBox.Text = "";

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
                SqlDataAdapter sdaFill = new SqlDataAdapter("SELECT * FROM dbo.history WHERE ofw_id = '" + passID + "'", conn1);
                DataTable dt2 = new DataTable(); //this is creating a virtual table  
                sdaFill.Fill(dt2);

      //          med1 = dt2.Rows[0][1].ToString;
       //         med2 = dt2.Rows[0][2].ToString;
                impressionBox.Text = dt2.Rows[0][3].ToString();
                recommendationBox.Text = dt2.Rows[0][4].ToString();
                heightBox.Text = dt2.Rows[0][5].ToString();
                weightBox.Text = dt2.Rows[0][6].ToString();

                respiratoryBox.Text = dt2.Rows[0][11].ToString();
                bmiBox.Text = dt2.Rows[0][12].ToString();

                skinBox.Text = dt2.Rows[0][25].ToString();

                eyesBox.Text = dt2.Rows[0][27].ToString();

                mouthBox.Text = dt2.Rows[0][31].ToString();



                childBox.Text = dt2.Rows[0][1].ToString();
                pastBox.Text = dt2.Rows[0][1].ToString();
                presentBox1.Text = dt2.Rows[0][1].ToString();
                presentBox2.Text = dt2.Rows[0][1].ToString();
                surgeriesBox.Text = dt2.Rows[0][1].ToString();
                hospitizationsBox.Text = dt2.Rows[0][1].ToString();
                smokeBox.Text = dt2.Rows[0][1].ToString();
                alcoholBox.Text = dt2.Rows[0][1].ToString();
                mensBox.Text = dt2.Rows[0][1].ToString();
                lastBox.Text = dt2.Rows[0][1].ToString();
                othersBox.Text = dt2.Rows[0][1].ToString();
                cardioBox.Text = dt2.Rows[0][1].ToString();
                genitourinaryBox.Text = dt2.Rows[0][1].ToString();
                musculoskeletalBox.Text = dt2.Rows[0][1].ToString();
                neurologicalBox.Text = dt2.Rows[0][1].ToString();
                endocrineBox.Text = dt2.Rows[0][1].ToString();
                hemaBox.Text = dt2.Rows[0][1].ToString();
                othersBox2.Text = dt2.Rows[0][1].ToString();
                bpBox.Text = dt2.Rows[0][1].ToString();
                prBox.Text = dt2.Rows[0][1].ToString();
                rrBox.Text = dt2.Rows[0][1].ToString();
                rightBox.Text = dt2.Rows[0][1].ToString();
                leftBox.Text = dt2.Rows[0][1].ToString();
                generalBox.Text = dt2.Rows[0][1].ToString();
                reviewSkinBox.Text = dt2.Rows[0][1].ToString();
                headNeckBox.Text = dt2.Rows[0][1].ToString();
                EENBox.Text = dt2.Rows[0][1].ToString();
                mouthThroatBox.Text = dt2.Rows[0][1].ToString();
                chestLungsBox.Text = dt2.Rows[0][1].ToString();
                breastBox.Text = dt2.Rows[0][1].ToString();
                backBox.Text = dt2.Rows[0][1].ToString();
                heartReviewBox.Text = dt2.Rows[0][1].ToString();
                abdomenBox.Text = dt2.Rows[0][1].ToString();
                extremitiesBox.Text = dt2.Rows[0][1].ToString();
                neurlogicalReviewBox.Text = dt2.Rows[0][1].ToString();
                rectalBox.Text = dt2.Rows[0][1].ToString();
                genitaliaBox.Text = dt2.Rows[0][1].ToString();


            }

        }


    }
}
