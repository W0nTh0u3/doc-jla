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
        public string passID, type, gender, civilStat, bday;
        public string[] vUnits;

        private void SubmitCBC_Click(object sender, EventArgs e)
        {
            string sqlString;
            vUnits = new string[] { leukoLabel.Text, nitriteLabel.Text, uroLabel.Text, proteinLabel.Text, bloodLabel.Text, ketoneLabel.Text, bilirLabel.Text, glucoseLabel.Text, pusCellsLabel.Text, rbcLabel.Text};
            checkStatus();
            if (type == "Enter")
            {
                sqlString = "INSERT INTO dbo.urineStool (MacroColor, MacroTransparency, Leukocyte, Nitrite, Urobilinogen, Protein, PH, Blood,SpecificGravity, Ketone, Bilirubin, Glucose, MicroEpithelial, MucousThreads, AmorphousMaterial, PusCells, rbcU, bacteria,color,consistency,pus,rbcS,others, status,ofw_id ) VALUES('" + colorBox.Text + "','" + transparencyBox.Text + "','" + leukocyteBox.Text + "','" + nitriteBox.Text + "','" + urobilinogenBox.Text + "','" + proteinBox.Text + "','" + phBox.Text + "','" + bloodBox.Text + "','" + specificGravityBox.Text + "','" + ketoneBox.Text + "','" + bilirubinBox.Text + "','" + glucoseBox.Text + "','" + epithelialCellsBox.Text + "','" + mucousThreadsBox.Text + "','" + amorphousMaterialBox.Text + "','" + pusCellsBox.Text + "','" + rbcBox.Text + "','" + bacteriaBox.Text + "','" + colorStoolBox.Text + "','" + consistencyBox.Text + "','" + pusStoolBox.Text + "','" + rbcStoolBox.Text + "','" + othersBox.Text + "', '"+MainMenu.statusUrineStool+"', '" + passID + "')";
                string[] vMin = { "" };
                string[] vMax = { "" };
                string[] valueString = { colorBox.Text, transparencyBox.Text, leukocyteBox.Text, nitriteBox.Text, urobilinogenBox.Text, proteinBox.Text, phBox.Text, bloodBox.Text, specificGravityBox.Text, ketoneBox.Text, bilirubinBox.Text, glucoseBox.Text, epithelialCellsBox.Text, mucousThreadsBox.Text, amorphousMaterialBox.Text, pusCellsBox.Text, rbcBox.Text, bacteriaBox.Text, colorStoolBox.Text, consistencyBox.Text, pusStoolBox.Text, rbcStoolBox.Text, othersBox.Text };
                string[] patientInfoValue = { Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat, packageBox.Text, companyBox.Text, accBox.Text, DateBox.Text, FormNBox.Text };
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue, vMin, vMax, vUnits);
                verifyPopUp.Show();
            }
            else if (type == "Save changes")
            {
                sqlString = "UPDATE dbo.urineStool SET MacroColor = '" + colorBox.Text + "', MacroTransparency = '" + transparencyBox.Text + "', Leukocyte = '" + leukocyteBox.Text + "', Nitrite = '" + nitriteBox.Text + "', Urobilinogen = '" + urobilinogenBox.Text + "', Protein = '" + proteinBox.Text + "', PH = '" + phBox.Text + "', Blood = '" + bloodBox.Text + "',SpecificGravity = '" + specificGravityBox.Text + "', Ketone = '" + ketoneBox.Text + "', Bilirubin = '" + bilirubinBox.Text + "', Glucose = '" + glucoseBox.Text + "', MicroEpithelial = '" + epithelialCellsBox.Text + "', MucousThreads = '" + mucousThreadsBox.Text + "', AmorphousMaterial = '" + amorphousMaterialBox.Text + "', PusCells = '" + pusCellsBox.Text + "', rbcU = '" + rbcBox.Text + "', bacteria = '" + bacteriaBox.Text + "', color = '"+ colorStoolBox.Text+"', consistency = '"+ consistencyBox.Text+"', pus = '"+pusStoolBox.Text+"', rbcS = '"+ rbcStoolBox.Text+"', others = '"+othersBox.Text+"', status = '"+MainMenu.statusUrineStool+"' WHERE ofw_id = '" + passID + "'";
                string[] vMin = { "" };
                string[] vMax = { "" };
                string[] valueString = { colorBox.Text, transparencyBox.Text, leukocyteBox.Text, nitriteBox.Text, urobilinogenBox.Text, proteinBox.Text, phBox.Text, bloodBox.Text, specificGravityBox.Text, ketoneBox.Text, bilirubinBox.Text, glucoseBox.Text, epithelialCellsBox.Text, mucousThreadsBox.Text, amorphousMaterialBox.Text, pusCellsBox.Text, rbcBox.Text, bacteriaBox.Text, colorStoolBox.Text, consistencyBox.Text, pusStoolBox.Text, rbcStoolBox.Text, othersBox.Text };
                string[] patientInfoValue = { Name, idBox.Text, lastBox.Text, firstBox.Text, middleBox.Text, ageBox.Text, gender, civilStat, packageBox.Text, companyBox.Text, accBox.Text, DateBox.Text, FormNBox.Text };
                VerifyPopUp verifyPopUp = new VerifyPopUp(sqlString, valueString, patientInfoValue, vMin, vMax, vUnits);
                verifyPopUp.Show();
            }

        }

        public UrinStoolForm(string uniqueID, string idPass, string type)
        {
            InitializeComponent();
            this.type = type;
            MainMenu.statusUrineStool = "ENT";
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
            /*
            RadioButton tbx = this.Controls.Find("idBox", true).FirstOrDefault() as RadioButton;
            if (tbx.Checked == true)
            */
            passID = idPass;

            if (type == "Save changes")
            {
                SqlConnection conn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
                SqlDataAdapter sdaFill = new SqlDataAdapter("SELECT * FROM dbo.urineStool WHERE ofw_id= '" + passID + "'", conn1);
                DataTable dt2 = new DataTable(); //this is creating a virtual table  
                sdaFill.Fill(dt2);


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
                colorStoolBox.Text = dt2.Rows[0][19].ToString();
                consistencyBox.Text = dt2.Rows[0][20].ToString();
                pusStoolBox.Text = dt2.Rows[0][21].ToString();
                rbcStoolBox.Text = dt2.Rows[0][22].ToString();
                othersBox.Text = dt2.Rows[0][23].ToString();                MainMenu.statusUrineStool = dt2.Rows[0][24].ToString();
            }
        }

        private void checkStatus()
        {
            if (colorBox.Text != "" && transparencyBox.Text != "" && leukocyteBox.Text != "" && nitriteBox.Text != "" && urobilinogenBox.Text != "" && proteinBox.Text != "" && phBox.Text != "" && bloodBox.Text != "" && specificGravityBox.Text != "" && ketoneBox.Text != "" && bilirubinBox.Text != "" && glucoseBox.Text != "" && epithelialCellsBox.Text != "" && mucousThreadsBox.Text != "" && amorphousMaterialBox.Text != "" && pusCellsBox.Text != "" && rbcBox.Text != "" && bacteriaBox.Text != "" && colorStoolBox.Text != "" && consistencyBox.Text != "" && pusStoolBox.Text != "" && rbcStoolBox.Text != "" && othersBox.Text != "")
                MainMenu.statusUrineStool = "COM";
            else if (colorBox.Text != "" || transparencyBox.Text != "" || leukocyteBox.Text != "" || nitriteBox.Text != "" || urobilinogenBox.Text != "" || proteinBox.Text != "" || phBox.Text != "" || bloodBox.Text != "" || specificGravityBox.Text != "" || ketoneBox.Text != "" || bilirubinBox.Text != "" || glucoseBox.Text != "" || epithelialCellsBox.Text != "" || mucousThreadsBox.Text != "" || amorphousMaterialBox.Text != "" || pusCellsBox.Text != "" || rbcBox.Text != "" || bacteriaBox.Text != "" || colorStoolBox.Text != "" || consistencyBox.Text != "" || pusStoolBox.Text != "" || rbcStoolBox.Text != "" || othersBox.Text != "")
                MainMenu.statusUrineStool = "RES";
            else
                MainMenu.statusUrineStool = "ENT";
        }
    }
}
