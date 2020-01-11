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
        public string passID, type, gender, civilStat,medHolder;
        public string med;

        private void weightBox_TextChanged(object sender, EventArgs e)
        {
            if (weightBox.Text != "" && heightBox.Text != "")
            {
                float height = Int64.Parse(heightBox.Text);
                float weight = Int64.Parse(weightBox.Text);
                double bmi;
                if (height >= 100)
                {
                    height = height / 100;
                    bmi = weight / Math.Pow(height, 2);
                }
                else
                    bmi = 0;
                bmiBox.Text = Convert.ToString(Math.Round(bmi, 1));


            }
        }

        private void heightBox_TextChanged(object sender, EventArgs e)
        {
            if (weightBox.Text != "" && heightBox.Text != "")
            {
                float height = Int64.Parse(heightBox.Text);
                float weight = Int64.Parse(weightBox.Text);
                double bmi;
                if (height >= 100)
                {
                    height = height / 100;
                    bmi = weight / Math.Pow(height, 2);
                }
                else
                    bmi = 0;

                bmiBox.Text = Convert.ToString(Math.Round(bmi,1));
            }
        }

        private void SubmitCBC_Click(object sender, EventArgs e)
        {
            string sqlString;

            if (type == "Enter")
            {
                EncodeBinary();
                medHolder = med;           
                sqlString = "INSERT INTO dbo.history (med,child,past,present1,present2,surgeries,hospitizations,smoke,alcohol,mens,last,others,eyes,mouth,cardio,respiratory,gastro,genitourinary,muskoskeletal,skin, neurological, endocrine,hema,others2,height,bp, weight,pr,pmi,rr,rightE,leftE,general,reviewSkin, headNeck,EEN,mouthThroat,chestLungs,breast,back,heartReview,abdomen,extremities, neurologicalReview,rectal,genitalia,impression,recommendations, physician, ofw_id) VALUES('" + med + "','" +childBox.Text + "','" + pastBox.Text + "','" + presentBox1.Text+ "','" + presentBox2.Text + "','" + surgeriesBox.Text + "', '"+hospitizationsBox.Text+"','" + smokeBox.Text + "','" + alcoholBox.Text + "','" + mensBox.Text + "','" +lastingBox.Text+ "','"+othersBox.Text+ "','"+eyesBox.Text+ "','"+mouthBox.Text+ "','"+cardioBox.Text+ "','"+respiratoryBox.Text+ "','"+gastroBox.Text+"','"+genitourinaryBox.Text+ "','"+musculoskeletalBox.Text+ "', '"+skinBox.Text+"','"+neurologicalBox.Text+ "','"+endocrineBox.Text+ "','"+hemaBox.Text+ "','"+othersBox2.Text+ "','"+heightBox.Text+ "','"+bpBox.Text+ "','"+weightBox.Text+ "','"+prBox.Text+ "','"+bmiBox.Text+ "','"+rrBox.Text+ "','"+rightBox.Text+ "','"+leftBox.Text+ "','"+generalBox.Text+ "','"+reviewSkinBox.Text+ "','"+headNeckBox.Text+ "','"+EENBox.Text+ "','"+mouthThroatBox.Text+ "','"+chestLungsBox.Text+ "','"+breastBox.Text+ "','"+backBox.Text+ "','"+heartReviewBox.Text+ "','"+abdomenBox.Text+ "','"+extremitiesBox.Text+ "','"+neurlogicalReviewBox.Text+ "','"+rectalBox.Text+ "','"+genitaliaBox.Text+ "','"+impressionBox.Text+ "','"+recommendationBox.Text+ "','"+ physicianBox.Text + "','"+passID+"')";
                string[] vMin = { "" };
                string[] vMax = { "" };
                string[] vUnits = { "" };
                string[] valueString = { medHolder , childBox.Text , pastBox.Text , presentBox1.Text , presentBox2.Text , surgeriesBox.Text,hospitizationsBox.Text , smokeBox.Text , alcoholBox.Text , mensBox.Text , lastingBox.Text , othersBox.Text , eyesBox.Text , mouthBox.Text , cardioBox.Text , respiratoryBox.Text ,gastroBox.Text, genitourinaryBox.Text , musculoskeletalBox.Text, skinBox.Text , neurologicalBox.Text , endocrineBox.Text , endocrineBox.Text , hemaBox.Text , othersBox2.Text , heightBox.Text , bpBox.Text , weightBox.Text , prBox.Text , bmiBox.Text , rrBox.Text , rightBox.Text , leftBox.Text , generalBox.Text , reviewSkinBox.Text , headNeckBox.Text , EENBox.Text , mouthThroatBox.Text , chestLungsBox.Text , breastBox.Text , backBox.Text , heartReviewBox.Text , abdomenBox.Text , extremitiesBox.Text , neurlogicalReviewBox.Text , rectalBox.Text , genitaliaBox.Text , impressionBox.Text , recommendationBox.Text, physicianBox.Text};
                string[] patientInfoValue = { Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat, FormNBox.Text };
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue, vMin, vMax, vUnits);
                verifyPopUp.Show();
            }
            else if (type == "Save changes")
            {
                EncodeBinary();
                medHolder = med;
                sqlString = "UPDATE dbo.history SET med='" + medHolder+ "',child='" + childBox.Text + "',past='" + pastBox.Text + "',present1='" + presentBox1.Text + "',present2='" + presentBox2.Text + "',surgeries='" + surgeriesBox.Text + "',hospitizations='" + hospitizationsBox.Text + "',smoke='" + smokeBox.Text + "',alcohol='" + alcoholBox.Text + "',mens='" + mensBox.Text + "',last='" + lastingBox.Text + "',others='" + othersBox.Text + "',eyes='" + eyesBox.Text + "',mouth='" + mouthBox.Text + "',cardio='" + cardioBox.Text + "',respiratory='" + respiratoryBox.Text + "',gastro='"+gastroBox.Text+"',genitourinary='" + genitourinaryBox.Text + "',muskoskeletal='" + musculoskeletalBox.Text + "',skin='" + skinBox.Text + "',neurological='" + neurologicalBox.Text + "',endocrine='" + endocrineBox.Text + "',hema='" + hemaBox.Text + "',others2='" + othersBox2.Text + "',height='" + heightBox.Text + "',bp='" + bpBox.Text + "',weight='" + weightBox.Text + "',pr='" + prBox.Text + "',pmi='" + bmiBox.Text + "',rr='" + rrBox.Text + "',rightE='" + rightBox.Text + "',leftE='" + leftBox.Text + "',general='" + generalBox.Text + "',reviewSkin='" + reviewSkinBox.Text + "',headNeck='" + headNeckBox.Text + "',EEN='" + EENBox.Text + "',mouthThroat='" + mouthThroatBox.Text + "',chestLungs='" + chestLungsBox.Text + "',breast='" + breastBox.Text + "',back='" + backBox.Text + "',heartReview='" + heartReviewBox.Text + "',abdomen='" + abdomenBox.Text + "',extremities='" + extremitiesBox.Text + "',neurologicalReview='" + neurlogicalReviewBox.Text + "',rectal='" + rectalBox.Text + "',genitalia='" + genitaliaBox.Text + "',impression='" + impressionBox.Text + "',recommendations='" + recommendationBox.Text + "',physician='"+ physicianBox.Text+ "'  WHERE ofw_id='" + passID + "'";
                string[] vMin = { "" };
                string[] vMax = { "" };
                string[] vUnits = { "" };
                string[] valueString = { medHolder, childBox.Text, pastBox.Text, presentBox1.Text, presentBox2.Text, surgeriesBox.Text, hospitizationsBox.Text, smokeBox.Text, alcoholBox.Text, mensBox.Text, lastingBox.Text, othersBox.Text, eyesBox.Text, mouthBox.Text, cardioBox.Text, respiratoryBox.Text, gastroBox.Text, genitourinaryBox.Text, musculoskeletalBox.Text, skinBox.Text, neurologicalBox.Text, endocrineBox.Text, endocrineBox.Text, hemaBox.Text, othersBox2.Text, heightBox.Text, bpBox.Text, weightBox.Text, prBox.Text, bmiBox.Text, rrBox.Text, rightBox.Text, leftBox.Text, generalBox.Text, reviewSkinBox.Text, headNeckBox.Text, EENBox.Text, mouthThroatBox.Text, chestLungsBox.Text, breastBox.Text, backBox.Text, heartReviewBox.Text, abdomenBox.Text, extremitiesBox.Text, neurlogicalReviewBox.Text, rectalBox.Text, genitaliaBox.Text, impressionBox.Text, recommendationBox.Text };
                string[] patientInfoValue = { Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat, FormNBox.Text };
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue, vMin, vMax, vUnits);
                verifyPopUp.Show();
            }
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
            lastingBox.Text = "";
            othersBox.Text = "";
            eyesBox.Text = "";
            mouthBox.Text = "";
            cardioBox.Text = "";
            respiratoryBox.Text = "";
            gastroBox.Text = "";
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
            physicianBox.Text = "";

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

                medHolder = dt2.Rows[0][1].ToString();
                Console.Write("ito na oh ");
                Console.Write(med);
                DecryptBinary();
                childBox.Text = dt2.Rows[0][2].ToString();
                pastBox.Text = dt2.Rows[0][3].ToString();
                presentBox1.Text = dt2.Rows[0][4].ToString();
                presentBox2.Text = dt2.Rows[0][5].ToString();
                surgeriesBox.Text = dt2.Rows[0][6].ToString();
                hospitizationsBox.Text = dt2.Rows[0][7].ToString();
                smokeBox.Text = dt2.Rows[0][8].ToString();
                alcoholBox.Text = dt2.Rows[0][9].ToString();
                mensBox.Text = dt2.Rows[0][10].ToString();
                lastingBox.Text = dt2.Rows[0][11].ToString();
                othersBox.Text = dt2.Rows[0][12].ToString();
                eyesBox.Text = dt2.Rows[0][13].ToString();
                mouthBox.Text = dt2.Rows[0][14].ToString();
                cardioBox.Text = dt2.Rows[0][15].ToString();
                respiratoryBox.Text = dt2.Rows[0][16].ToString();
                gastroBox.Text = dt2.Rows[0][17].ToString();
                genitourinaryBox.Text = dt2.Rows[0][18].ToString();
                musculoskeletalBox.Text = dt2.Rows[0][19].ToString();
                skinBox.Text = dt2.Rows[0][20].ToString();
                neurologicalBox.Text = dt2.Rows[0][21].ToString();
                endocrineBox.Text = dt2.Rows[0][22].ToString();
                hemaBox.Text = dt2.Rows[0][23].ToString();
                othersBox2.Text = dt2.Rows[0][24].ToString();
                heightBox.Text = dt2.Rows[0][25].ToString();
                bpBox.Text = dt2.Rows[0][26].ToString();
                weightBox.Text = dt2.Rows[0][27].ToString();
                prBox.Text = dt2.Rows[0][28].ToString();
                bmiBox.Text = dt2.Rows[0][29].ToString();
                rrBox.Text = dt2.Rows[0][30].ToString();
                rightBox.Text = dt2.Rows[0][31].ToString();
                leftBox.Text = dt2.Rows[0][32].ToString();
                generalBox.Text = dt2.Rows[0][33].ToString();
                reviewSkinBox.Text = dt2.Rows[0][34].ToString();
                headNeckBox.Text = dt2.Rows[0][35].ToString();
                EENBox.Text = dt2.Rows[0][36].ToString();
                mouthThroatBox.Text = dt2.Rows[0][37].ToString();
                chestLungsBox.Text = dt2.Rows[0][38].ToString();
                breastBox.Text = dt2.Rows[0][39].ToString();
                backBox.Text = dt2.Rows[0][40].ToString();
                heartReviewBox.Text = dt2.Rows[0][41].ToString();
                abdomenBox.Text = dt2.Rows[0][42].ToString();
                extremitiesBox.Text = dt2.Rows[0][43].ToString();
                neurlogicalReviewBox.Text = dt2.Rows[0][44].ToString();
                rectalBox.Text = dt2.Rows[0][45].ToString();
                genitaliaBox.Text = dt2.Rows[0][46].ToString();
                impressionBox.Text = dt2.Rows[0][47].ToString();
                recommendationBox.Text = dt2.Rows[0][48].ToString();
                physicianBox.Text = dt2.Rows[0][49].ToString();

            }

        }

        private void DecryptBinary()
        {
            for (int x = 0; x < medHolder.Length; x++)
            {
                    string holder = $"y{(x + 1).ToString()}";
                    string holder2 = $"n{(x + 1).ToString()}";
                    if (medHolder[x] == '1')
                    {
                        RadioButton tbx = this.Controls.Find(holder, true).FirstOrDefault() as RadioButton;
                        tbx.Checked = true;
                    }
                    else if (medHolder[x] == '0')
                    {
                        RadioButton tbx = this.Controls.Find(holder2, true).FirstOrDefault() as RadioButton;
                        tbx.Checked = true;
                    }
            }
            /*
RadioButton tbx = this.Controls.Find("idBox", true).FirstOrDefault() as RadioButton;
if (tbx.Checked == true)
*/
        }


        
        private void EncodeBinary()
        {
            char[] medS = new char[35];
            for (int i = 0; i < 35; i++)
            {
                string holderY = $"y{(i + 1).ToString()}";
                string holderN = $"n{(i + 1).ToString()}";
                RadioButton tbxY = this.Controls.Find(holderY, true).FirstOrDefault() as RadioButton;
                RadioButton tbxN = this.Controls.Find(holderN, true).FirstOrDefault() as RadioButton;
                if (tbxY.Checked == true)
                    medS[i] = '1';
                else if (tbxN.Checked == true)
                    medS[i] = '0';
            }
            med = new string(medS);
        }

    } 
}
