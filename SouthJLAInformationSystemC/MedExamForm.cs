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
        public float med;


        private void SubmitCBC_Click(object sender, EventArgs e)
        {
            string sqlString;

            if (type == "Enter")
            {
                encodeBinary();
                medHolder = $"{med}";           
                sqlString = "INSERT INTO dbo.history (med,child,past,present1,present2,surgeries,hospitizations,smoke,alcohol,mens,last,others,eyes,mouth,cardio,respiratory,genitourinary,muskoskeletal,skin, neurological, endocrine,hema,others2,height,bp, weight,pr,pmi,rr,rightE,leftE,general,reviewSkin, headNeck,EEN,mouthThroat,chestLungs,breast,back,heartReview,abdomen,extremities, neurologicalReview,rectal,genitalia,impression,recommendations, ofw_id) VALUES('" + med + "','" +childBox.Text + "','" + pastBox.Text + "','" + presentBox1.Text+ "','" + presentBox2.Text + "','" + surgeriesBox.Text + "', '"+hospitizationsBox.Text+"','" + smokeBox.Text + "','" + alcoholBox.Text + "','" + mensBox.Text + "','" +lastBox.Text+ "','"+othersBox.Text+ "','"+eyesBox.Text+ "','"+mouthBox.Text+ "','"+cardioBox.Text+ "','"+respiratoryBox.Text+ "','"+genitourinaryBox.Text+ "','"+musculoskeletalBox.Text+ "', '"+skinBox.Text+"','"+neurologicalBox.Text+ "','"+endocrineBox.Text+ "','"+hemaBox.Text+ "','"+othersBox2.Text+ "','"+heightBox.Text+ "','"+bpBox.Text+ "','"+weightBox.Text+ "','"+prBox.Text+ "','"+bmiBox.Text+ "','"+rrBox.Text+ "','"+rightBox.Text+ "','"+leftBox.Text+ "','"+generalBox.Text+ "','"+reviewSkinBox.Text+ "','"+headNeckBox.Text+ "','"+EENBox.Text+ "','"+mouthThroatBox.Text+ "','"+chestLungsBox.Text+ "','"+breastBox.Text+ "','"+backBox.Text+ "','"+heartReviewBox.Text+ "','"+abdomenBox.Text+ "','"+extremitiesBox.Text+ "','"+neurlogicalReviewBox.Text+ "','"+rectalBox.Text+ "','"+genitaliaBox.Text+ "','"+impressionBox.Text+ "','"+recommendationBox.Text+ "','"+passID+"')";
                             string[] valueString = { medHolder , childBox.Text , pastBox.Text , presentBox1.Text , presentBox2.Text , surgeriesBox.Text,hospitizationsBox.Text , smokeBox.Text , alcoholBox.Text , mensBox.Text , lastBox.Text , othersBox.Text , eyesBox.Text , mouthBox.Text , cardioBox.Text , respiratoryBox.Text , genitourinaryBox.Text , musculoskeletalBox.Text, skinBox.Text , neurologicalBox.Text , endocrineBox.Text , endocrineBox.Text , hemaBox.Text , othersBox2.Text , heightBox.Text , bpBox.Text , weightBox.Text , prBox.Text , bmiBox.Text , rrBox.Text , rightBox.Text , leftBox.Text , generalBox.Text , reviewSkinBox.Text , headNeckBox.Text , EENBox.Text , mouthThroatBox.Text , chestLungsBox.Text , breastBox.Text , backBox.Text , heartReviewBox.Text , abdomenBox.Text , extremitiesBox.Text , neurlogicalReviewBox.Text , rectalBox.Text , genitaliaBox.Text , impressionBox.Text , recommendationBox.Text};
                            string[] patientInfoValue = { idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat };
                            VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue);
                           verifyPopUp.Show();
            }
            else if (type == "Save changes")
            {
                encodeBinary();
                medHolder = $"{med}";
                sqlString = "UPDATE dbo.history SET med='" + med + "',child='" + childBox.Text + "',past='" + pastBox.Text + "',present1='" + presentBox1.Text + "',present2='" + presentBox2.Text + "',surgeries='" + surgeriesBox.Text + "',hospitizations='" + hospitizationsBox.Text + "',smoke='" + smokeBox.Text + "',alcohol='" + alcoholBox.Text + "',mens='" + mensBox.Text + "',last='" + lastBox.Text + "',others='" + othersBox.Text + "',eyes='" + eyesBox.Text + "',mouth='" + mouthBox.Text + "',cardio='" + cardioBox.Text + "',respiratory='" + respiratoryBox.Text + "',genitourinary='" + genitourinaryBox.Text + "',muskoskeletal='" + musculoskeletalBox.Text + "',skin='" + skinBox.Text + "',neurological='" + neurologicalBox.Text + "',endocrine='" + endocrineBox.Text + "',hema='" + hemaBox.Text + "',others2='" + othersBox2.Text + "',height='" + heightBox.Text + "',bp='" + bpBox.Text + "',weight='" + weightBox.Text + "',pr='" + prBox.Text + "',pmi='" + bmiBox.Text + "',rr='" + rrBox.Text + "',rightE='" + rightBox.Text + "',leftE='" + leftBox.Text + "',general='" + generalBox.Text + "',reviewSkin'" + reviewSkinBox.Text + "',headNeck'" + headNeckBox.Text + "',EEN='" + EENBox.Text + "',mouthThroat='" + mouthThroatBox.Text + "',chestLungs='" + chestLungsBox.Text + "',breast='" + breastBox.Text + "',back='" + backBox.Text + "',heartReview='" + heartReviewBox.Text + "',abdomen='" + abdomenBox.Text + "',extremities='" + extremitiesBox.Text + "',neurologicalReview='" + neurlogicalReviewBox.Text + "',rectal='" + rectalBox.Text + "',genitalia='" + genitaliaBox.Text + "',impression='" + impressionBox.Text + "',recommendations='" + recommendationBox.Text + "',ofw_id='" + passID + "'";
                string[] valueString = { medHolder, childBox.Text, pastBox.Text, presentBox1.Text, presentBox2.Text, surgeriesBox.Text, hospitizationsBox.Text, smokeBox.Text, alcoholBox.Text, mensBox.Text, lastBox.Text, othersBox.Text, eyesBox.Text, mouthBox.Text, cardioBox.Text, respiratoryBox.Text, genitourinaryBox.Text, musculoskeletalBox.Text, skinBox.Text, neurologicalBox.Text, endocrineBox.Text, endocrineBox.Text, hemaBox.Text, othersBox2.Text, heightBox.Text, bpBox.Text, weightBox.Text, prBox.Text, bmiBox.Text, rrBox.Text, rightBox.Text, leftBox.Text, generalBox.Text, reviewSkinBox.Text, headNeckBox.Text, EENBox.Text, mouthThroatBox.Text, chestLungsBox.Text, breastBox.Text, backBox.Text, heartReviewBox.Text, abdomenBox.Text, extremitiesBox.Text, neurlogicalReviewBox.Text, rectalBox.Text, genitaliaBox.Text, impressionBox.Text, recommendationBox.Text };
                string[] patientInfoValue = { idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat };
                           VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue);
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

            idBox.Text = dt1.Rows[0][0].ToString();
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
                med = float.Parse(medHolder);
                decryptBinary();
                childBox.Text = dt2.Rows[0][2].ToString();
                pastBox.Text = dt2.Rows[0][3].ToString();
                presentBox1.Text = dt2.Rows[0][4].ToString();
                presentBox2.Text = dt2.Rows[0][5].ToString();
                surgeriesBox.Text = dt2.Rows[0][6].ToString();
                hospitizationsBox.Text = dt2.Rows[0][7].ToString();
                smokeBox.Text = dt2.Rows[0][8].ToString();
                alcoholBox.Text = dt2.Rows[0][9].ToString();
                mensBox.Text = dt2.Rows[0][10].ToString();
                lastBox.Text = dt2.Rows[0][11].ToString();
                othersBox.Text = dt2.Rows[0][12].ToString();
                eyesBox.Text = dt2.Rows[0][13].ToString();
                mouthBox.Text = dt2.Rows[0][14].ToString();
                cardioBox.Text = dt2.Rows[0][15].ToString();
                respiratoryBox.Text = dt2.Rows[0][16].ToString();
                genitourinaryBox.Text = dt2.Rows[0][17].ToString();
                musculoskeletalBox.Text = dt2.Rows[0][18].ToString();
                skinBox.Text = dt2.Rows[0][19].ToString();
                neurologicalBox.Text = dt2.Rows[0][20].ToString();
                endocrineBox.Text = dt2.Rows[0][21].ToString();
                hemaBox.Text = dt2.Rows[0][22].ToString();
                othersBox2.Text = dt2.Rows[0][23].ToString();
                heightBox.Text = dt2.Rows[0][24].ToString();
                bpBox.Text = dt2.Rows[0][25].ToString();
                weightBox.Text = dt2.Rows[0][26].ToString();
                prBox.Text = dt2.Rows[0][27].ToString();
                bmiBox.Text = dt2.Rows[0][28].ToString();
                rrBox.Text = dt2.Rows[0][29].ToString();
                rightBox.Text = dt2.Rows[0][30].ToString();
                leftBox.Text = dt2.Rows[0][31].ToString();
                generalBox.Text = dt2.Rows[0][32].ToString();
                reviewSkinBox.Text = dt2.Rows[0][33].ToString();
                headNeckBox.Text = dt2.Rows[0][34].ToString();
                EENBox.Text = dt2.Rows[0][35].ToString();
                mouthThroatBox.Text = dt2.Rows[0][36].ToString();
                chestLungsBox.Text = dt2.Rows[0][37].ToString();
                breastBox.Text = dt2.Rows[0][38].ToString();
                backBox.Text = dt2.Rows[0][39].ToString();
                heartReviewBox.Text = dt2.Rows[0][40].ToString();
                abdomenBox.Text = dt2.Rows[0][41].ToString();
                extremitiesBox.Text = dt2.Rows[0][42].ToString();
                neurlogicalReviewBox.Text = dt2.Rows[0][43].ToString();
                rectalBox.Text = dt2.Rows[0][44].ToString();
                genitaliaBox.Text = dt2.Rows[0][45].ToString();
                impressionBox.Text = dt2.Rows[0][46].ToString();
                recommendationBox.Text = dt2.Rows[0][47].ToString();

            }

        }

        private void decryptBinary()
        {
            int[] medArray = new int[35];
            for (int counter = 35; counter > 0; counter--)
            {
                if (med >= Math.Pow(10, counter - 1))
                    medArray[counter - 1] = 1;
            }

            for (int counter2 = 0; counter2 < 35; counter2++)
            {
                if (medArray[counter2] == 1){y1.Checked = true;n1.Checked = false;}else{n1.Checked = true;y1.Checked = false;}
                if (medArray[counter2] == 1) { y2.Checked = true; n2.Checked = false; } else { n1.Checked = true; y1.Checked = false; }
                if (medArray[counter2] == 1) { y3.Checked = true; n3.Checked = false; } else { n2.Checked = true; y2.Checked = false; }
                if (medArray[counter2] == 1) { y4.Checked = true; n4.Checked = false; } else { n3.Checked = true; y3.Checked = false; }
                if (medArray[counter2] == 1) { y5.Checked = true; n5.Checked = false; } else { n4.Checked = true; y4.Checked = false; }
                if (medArray[counter2] == 1) { y6.Checked = true; n6.Checked = false; } else { n5.Checked = true; y5.Checked = false; }
                if (medArray[counter2] == 1) { y7.Checked = true; n7.Checked = false; } else { n6.Checked = true; y6.Checked = false; }
                if (medArray[counter2] == 1) { y8.Checked = true; n8.Checked = false; } else { n7.Checked = true; y7.Checked = false; }
                if (medArray[counter2] == 1) { y9.Checked = true; n9.Checked = false; } else { n8.Checked = true; y8.Checked = false; }
                if (medArray[counter2] == 1) { y10.Checked = true; n10.Checked = false; } else { n9.Checked = true; y9.Checked = false; }
                if (medArray[counter2] == 1) { y11.Checked = true; n11.Checked = false; } else { n10.Checked = true; y10.Checked = false; }
                if (medArray[counter2] == 1) { y12.Checked = true; n12.Checked = false; } else { n11.Checked = true; y11.Checked = false; }
                if (medArray[counter2] == 1) { y13.Checked = true; n13.Checked = false; } else { n12.Checked = true; y12.Checked = false; }
                if (medArray[counter2] == 1) { y14.Checked = true; n14.Checked = false; } else { n13.Checked = true; y13.Checked = false; }
                if (medArray[counter2] == 1) { y15.Checked = true; n15.Checked = false; } else { n14.Checked = true; y14.Checked = false; }
                if (medArray[counter2] == 1) { y16.Checked = true; n16.Checked = false; } else { n15.Checked = true; y15.Checked = false; }
                if (medArray[counter2] == 1) { y17.Checked = true; n17.Checked = false; } else { n16.Checked = true; y16.Checked = false; }
                if (medArray[counter2] == 1) { y18.Checked = true; n18.Checked = false; } else { n17.Checked = true; y17.Checked = false; }
                if (medArray[counter2] == 1) { y19.Checked = true; n19.Checked = false; } else { n18.Checked = true; y18.Checked = false; }
                if (medArray[counter2] == 1) { y20.Checked = true; n20.Checked = false; } else { n19.Checked = true; y19.Checked = false; }
                if (medArray[counter2] == 1) { y21.Checked = true; n21.Checked = false; } else { n20.Checked = true; y20.Checked = false; }
                if (medArray[counter2] == 1) { y22.Checked = true; n22.Checked = false; } else { n21.Checked = true; y21.Checked = false; }
                if (medArray[counter2] == 1) { y23.Checked = true; n23.Checked = false; } else { n22.Checked = true; y22.Checked = false; }
                if (medArray[counter2] == 1) { y24.Checked = true; n24.Checked = false; } else { n23.Checked = true; y23.Checked = false; }
                if (medArray[counter2] == 1) { y25.Checked = true; n25.Checked = false; } else { n24.Checked = true; y24.Checked = false; }
                if (medArray[counter2] == 1) { y26.Checked = true; n26.Checked = false; } else { n25.Checked = true; y25.Checked = false; }
                if (medArray[counter2] == 1) { y27.Checked = true; n27.Checked = false; } else { n26.Checked = true; y26.Checked = false; }
                if (medArray[counter2] == 1) { y28.Checked = true; n28.Checked = false; } else { n27.Checked = true; y27.Checked = false; }
                if (medArray[counter2] == 1) { y29.Checked = true; n29.Checked = false; } else { n28.Checked = true; y28.Checked = false; }
                if (medArray[counter2] == 1) { y30.Checked = true; n30.Checked = false; } else { n29.Checked = true; y29.Checked = false; }
                if (medArray[counter2] == 1) { y31.Checked = true; n31.Checked = false; } else { n30.Checked = true; y30.Checked = false; }
                if (medArray[counter2] == 1) { y32.Checked = true; n32.Checked = false; } else { n31.Checked = true; y31.Checked = false; }
                if (medArray[counter2] == 1) { y33.Checked = true; n33.Checked = false; } else { n32.Checked = true; y32.Checked = false; }
                if (medArray[counter2] == 1) { y34.Checked = true; n34.Checked = false; } else { n33.Checked = true; y33.Checked = false; }
                if (medArray[counter2] == 1) { y35.Checked = true; n35.Checked = false; } else { n34.Checked = true; y34.Checked = false; }

            }
        }
     

    private void encodeBinary()
        {
            /*
                for (int i=1;i<36;i++)
                {
                    holder = $"y{i.ToString()}.Checked == true";
                    if (ComputeCondition(holder))
                    {
                        med += 10 ^ (i-1);
                    }
                }
             To the future programmer: This is the logic for this function, all that is needed is the
             correct syntax and you can delete whats below
                */

            if (y1.Checked == true) med += 1;
            if (y2.Checked == true) med += 10;
            if (y3.Checked == true) med += 10 ^ 2;
            if (y4.Checked == true) med += 10 ^ 3;
            if (y5.Checked == true) med += 10 ^ 4;
            if (y6.Checked == true) med += 10 ^ 5;
            if (y7.Checked == true) med += 10 ^ 6;
            if (y8.Checked == true) med += 10 ^ 7;
            if (y9.Checked == true) med += 10 ^ 8;
            if (y10.Checked == true) med += 10 ^ 9;
            if (y11.Checked == true) med += 10 ^ 10;
            if (y12.Checked == true) med += 10 ^ 11;
            if (y13.Checked == true) med += 10 ^ 12;
            if (y14.Checked == true) med += 10 ^ 13;
            if (y15.Checked == true) med += 10 ^ 14;
            if (y16.Checked == true) med += 10 ^ 15;
            if (y17.Checked == true) med += 10 ^ 16;
            if (y18.Checked == true) med += 10 ^ 17;
            if (y19.Checked == true) med += 10 ^ 18;
            if (y20.Checked == true) med += 10 ^ 19;
            if (y21.Checked == true) med += 10 ^ 20;
            if (y22.Checked == true) med += 10 ^ 21;
            if (y23.Checked == true) med += 10 ^ 22;
            if (y24.Checked == true) med += 10 ^ 23;
            if (y25.Checked == true) med += 10 ^ 24;
            if (y26.Checked == true) med += 10 ^ 25;
            if (y27.Checked == true) med += 10 ^ 26;
            if (y28.Checked == true) med += 10 ^ 27;
            if (y29.Checked == true) med += 10 ^ 28;
            if (y30.Checked == true) med += 10 ^ 29;
            if (y31.Checked == true) med += 10 ^ 30;
            if (y32.Checked == true) med += 10 ^ 31;
            if (y33.Checked == true) med += 10 ^ 32;
            if (y34.Checked == true) med += 10 ^ 33;
            if (y35.Checked == true) med += 10 ^ 34;

        }
        /*  this is part of the encode binary without the correct syntax
         *  private static bool ComputeCondition(string value)
          {
              using (DataTable dt = new DataTable())
              {
                  return (bool)(dt.Compute(value, null));
              }
          }
          */

    } 
}
