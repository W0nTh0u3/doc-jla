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
    public partial class UrinStoolForm : Form
    {
        public string passID, type, gender, civilStat;


        private void SubmitCBC_Click(object sender, EventArgs e)
        {
            string sqlString, sqlString2;

            if (type == "Enter")
            {
                sqlString = "INSERT INTO dbo.Clinic_Microscopy (MacroColor, MacroTransparency, Leukocyte, Nitrite, Urobilinogen, Protein, PH, Blood,SpecificGravity, Ketone, Bilirubin, Glucose, MicroEpithelial, MucousThreads, AmorphousMaterial, PusCells, rbc, bacteria, ofw_id ) VALUES('" + colorBox.Text + "','" + transparencyBox.Text + "','" + leukocyteBox.Text + "','" + nitriteBox.Text + "','" + urobilinogenBox.Text + "','" + proteinBox.Text + "','" + phBox.Text + "','" + bloodBox.Text + "','" + specificGravityBox.Text + "','" + ketoneBox.Text + "','" + bilirubinBox.Text + "','" + glucoseBox.Text + "','" + epithelialCellsBox.Text + "','" + mucousThreadsBox.Text + "','" + amorphousMaterialBox.Text + "','" + pusCellsBox.Text + "','" + rbcBox.Text + "','" + bacteriaBox.Text + "', '" + passID + "')";
                string[] valueString = { colorBox.Text,transparencyBox.Text,leukocyteBox.Text,nitriteBox.Text,urobilinogenBox.Text,proteinBox.Text ,phBox.Text,bloodBox.Text,specificGravityBox.Text,ketoneBox.Text,bilirubinBox.Text,glucoseBox.Text,epithelialCellsBox.Text,mucousThreadsBox.Text,amorphousMaterialBox.Text,pusCellsBox.Text,rbcBox.Text,bacteriaBox.Text};
                string[] patientInfoValue = { idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat };
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue);
                verifyPopUp.Show();

                sqlString2 = "INSERT INTO dbo.Stool_Examination (color, consistency, pus, rbc, others, ofw_id) VALUES('" + colorStoolBox.Text + "','" + consistencyBox.Text + "','" + pusStoolBox.Text + "','" + rbcStoolBox.Text + "','" + othersBox.Text + "', '" + passID + "')";
                string[] valueString2 = {colorStoolBox.Text,consistencyBox.Text,pusStoolBox.Text,rbcStoolBox.Text,othersBox.Text};
                VerifyPopUp verifyPopUp2 = new VerifyPopUp(sqlString2, valueString2, patientInfoValue);
                verifyPopUp2.Show();
            }
            else if (type == "Save changes")
            {
                sqlString = "UPDATE dbo.Clinic_Microscopy SET MacroColor = '" + colorBox.Text + "', MacroTransparency = '" + transparencyBox.Text + "', Leukocyte = '" + leukocyteBox.Text + "', Nitrite = '" + nitriteBox.Text + "', Urobilinogen = '" + urobilinogenBox.Text + "', Protein = '" + proteinBox.Text + "', PH = '" + phBox.Text + "', Blood = '" + bloodBox.Text + "',SpecificGravity = '" + specificGravityBox.Text + "', Ketone = '" + ketoneBox.Text + "', Bilirubin = '"+ bilirubinBox.Text+ "', Glucose = '" + glucoseBox.Text + "', MicroEpithelial = '" + epithelialCellsBox.Text + "', MucousThreads = '" + mucousThreadsBox.Text + "', AmorphousMaterial = '" + amorphousMaterialBox.Text + "', PusCells = '" + pusCellsBox.Text + "', rbc = '" + rbcBox.Text + "', bacteria = '" + bacteriaBox.Text + "' WHERE ofw_id = '" + passID + "'";
                string[] valueString = { colorBox.Text, transparencyBox.Text, leukocyteBox.Text, nitriteBox.Text, urobilinogenBox.Text, proteinBox.Text, phBox.Text, bloodBox.Text, specificGravityBox.Text, ketoneBox.Text, bilirubinBox.Text, glucoseBox.Text, epithelialCellsBox.Text, mucousThreadsBox.Text, amorphousMaterialBox.Text, pusCellsBox.Text, rbcBox.Text, bacteriaBox.Text };
                string[] patientInfoValue = { idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat };
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue);
                verifyPopUp.Show();

                sqlString2 = "UPDATE dbo.Stool_Examination SET color= '" + colorStoolBox.Text + "', consistency= '" + consistencyBox.Text + "', pus= '" + pusStoolBox.Text + "', rbc= '" + rbcStoolBox.Text + "', others= '" + othersBox.Text + "' WHERE ofw_id = '" + passID + "'";
                string[] valueString2 = { colorStoolBox.Text, consistencyBox.Text, pusStoolBox.Text, rbcStoolBox.Text, othersBox.Text };
                VerifyPopUp verifyPopUp2 = new VerifyPopUp(sqlString2, valueString2, patientInfoValue);
                verifyPopUp2.Show();

            }
        }

        public UrinStoolForm(string uniqueID, string idPass, string type)
        {
            InitializeComponent();
            this.type = type;

            colorBox.Text = "";
            transparencyBox.Text = "";
            leukocyteBox.Text = "";
            nitriteBox.Text = "";
            urobilinogenBox.Text = "";
            proteinBox.Text = "";
            phBox.Text = "";
            bloodBox.Text = "";
            specificGravityBox.Text = "";
            ketoneBox.Text = "";
            bilirubinBox.Text = "";
            glucoseBox.Text = "";
            epithelialCellsBox.Text = "";
            mucousThreadsBox.Text = "";
            amorphousMaterialBox.Text = "";
            pusCellsBox.Text = "";
            rbcBox.Text = "";
            bacteriaBox.Text = "";
            colorStoolBox.Text = "";
            consistencyBox.Text = "";
            pusStoolBox.Text = "";
            rbcStoolBox.Text = "";
            othersBox.Text = "";

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
                SqlDataAdapter sdaFill = new SqlDataAdapter("SELECT * FROM dbo.Clinic_Microscopy WHERE ofw_id= '" + passID + "'", conn1);
                DataTable dt2 = new DataTable(); //this is creating a virtual table  
                sdaFill.Fill(dt2);


                //microscopy database
                colorBox.Text = dt2.Rows[0][1].ToString();
                transparencyBox.Text = dt2.Rows[0][2].ToString();
                leukocyteBox.Text = dt2.Rows[0][3].ToString();
                nitriteBox.Text = dt2.Rows[0][4].ToString();
                urobilinogenBox.Text = dt2.Rows[0][5].ToString();
                proteinBox.Text = dt2.Rows[0][6].ToString();
                phBox.Text = dt2.Rows[0][7].ToString();
                bloodBox.Text = dt2.Rows[0][8].ToString();
                specificGravityBox.Text = dt2.Rows[0][9].ToString();
                ketoneBox.Text = dt2.Rows[0][10].ToString();
                bilirubinBox.Text = dt2.Rows[0][11].ToString();
                glucoseBox.Text = dt2.Rows[0][12].ToString();
                epithelialCellsBox.Text = dt2.Rows[0][13].ToString();
                mucousThreadsBox.Text = dt2.Rows[0][14].ToString();
                amorphousMaterialBox.Text = dt2.Rows[0][15].ToString();
                pusCellsBox.Text = dt2.Rows[0][16].ToString();
                rbcBox.Text = dt2.Rows[0][17].ToString();
                bacteriaBox.Text = dt2.Rows[0][18].ToString();

                SqlConnection conn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
                SqlDataAdapter sdaFill2 = new SqlDataAdapter("SELECT * FROM dbo.Hematology WHERE ofw_id = '" + passID + "'", conn2);
                DataTable dt3 = new DataTable(); //this is creating a virtual table  
                sdaFill2.Fill(dt3);

                //stool database
                colorStoolBox.Text = dt3.Rows[0][1].ToString();
                consistencyBox.Text = dt3.Rows[0][2].ToString();
                pusStoolBox.Text = dt3.Rows[0][3].ToString();
                rbcStoolBox.Text = dt3.Rows[0][4].ToString();
                othersBox.Text = dt3.Rows[0][5].ToString();
            }
        }


    }
}
