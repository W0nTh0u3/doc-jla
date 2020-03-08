using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SouthJLAInformationSystemC
{
    public partial class ReportsForm : Form
    {
        DataTable patients,Hematology, urineStool, xray,ecg,fbs;
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
            DataTable dt = new DataTable("");


            //transfer Patient Info to dt
            string sqlstring = "SELECT patientID,lastName,givenName,middleName,age,birthDate,gender,civilStatus,address,dateFiled,package,paid,agency,account   FROM dbo.ofw";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, conn);
            patients = new DataTable(); //this is creating a virtual table  
            sda.Fill(patients);

            dt.Merge(patients);
           //transfer Hematology to dt
            sqlstring = "SELECT wbc,rbc,hgb,hct,platelets,neutrophil,lymphocytes,monocyte   FROM dbo.Hematology";
            sda = new SqlDataAdapter(sqlstring, conn);
            Hematology = new DataTable(); //this is creating a virtual table  
            sda.Fill(Hematology);
            dt.Merge(Hematology);

            //transfer Clinical Microscopy - Urine Stool to dt
            sqlstring = "SELECT MacroColor,MacroTransparency,Leukocyte,Nitrite,Urobilinogen,Protein,PH,Blood,SpecificGravity,Ketone,Bilirubin,Glucose,MicroEpithelial,MucousThreads,AmorphousMaterial,PusCells,rbcU,bacteria,color,consistency,pus,rbcS,others FROM dbo.urineStool";
            sda = new SqlDataAdapter(sqlstring, conn);
            urineStool = new DataTable(); //this is creating a virtual table  
            sda.Fill(urineStool);
            dt.Merge(urineStool);
            //transfer xray to dt
            sqlstring = "SELECT status,impression   FROM dbo.xray";
            sda = new SqlDataAdapter(sqlstring, conn);
            xray = new DataTable(); //this is creating a virtual table  
            sda.Fill(xray);
            dt.Merge(xray);
            //transfer ECG to dt
            sqlstring = "SELECT ecgStatus,ecgImpression   FROM dbo.ecg";
            sda = new SqlDataAdapter(sqlstring, conn);
            ecg = new DataTable(); //this is creating a virtual table  
            sda.Fill(ecg);
            dt.Merge(ecg);
            //transfer FBS to dt
            sqlstring = "SELECT fbs,totalCholesterol   FROM dbo.Blood_Chemistrty";
            sda = new SqlDataAdapter(sqlstring, conn);
            fbs = new DataTable(); //this is creating a virtual table  
            sda.Fill(fbs);
            dt.Merge(fbs);

            //Column Names
            #region 
            //patient info
          dt.Columns[0].ColumnName = "Form No.";
            dt.Columns[1].ColumnName = "Surname";
            dt.Columns[2].ColumnName = "Name";
            dt.Columns[3].ColumnName = "M.I.";
            dt.Columns[4].ColumnName = "Age";
            dt.Columns[5].ColumnName = "Birthdate";
            dt.Columns[6].ColumnName = "Gender";
            dt.Columns[7].ColumnName = "Civil Status";
            dt.Columns[8].ColumnName = "Address";
            dt.Columns[9].ColumnName = "Date Registered";
            dt.Columns[10].ColumnName = "Package";
            dt.Columns[11].ColumnName = "Payment Status";
            dt.Columns[12].ColumnName = "Agency";
            dt.Columns[13].ColumnName = "Account";
            //CBC - Hematology
            dt.Columns[14].ColumnName = "WBC";
            dt.Columns[15].ColumnName = "RBC";
            dt.Columns[16].ColumnName = "HGB";
            dt.Columns[17].ColumnName = "HCT";
            dt.Columns[18].ColumnName = "Platelets";
            dt.Columns[19].ColumnName = "Neutrophil";
            dt.Columns[20].ColumnName = "Lymphocytes";
            dt.Columns[21].ColumnName = "Monocyte";
              //Clinical Microscopy - Urine Stool
              dt.Columns[22].ColumnName = "Urine Color";
              dt.Columns[23].ColumnName = "Urine Transparency";
              dt.Columns[24].ColumnName = "Leukocyte";
              dt.Columns[25].ColumnName = "Nitrite";
              dt.Columns[26].ColumnName = "Urobilinogen";
              dt.Columns[27].ColumnName = "Protein";
              dt.Columns[28].ColumnName = "PH";
              dt.Columns[29].ColumnName = "Blood";
              dt.Columns[30].ColumnName = "Specific Gravity";
              dt.Columns[31].ColumnName = "Ketone";
              dt.Columns[32].ColumnName = "Bilirubin";
              dt.Columns[33].ColumnName = "Glucose";
              dt.Columns[34].ColumnName = "Epithelial Cells";
              dt.Columns[35].ColumnName = "Mucous Threads";
              dt.Columns[36].ColumnName = "Amorphous Meterial";
              dt.Columns[37].ColumnName = "PUS Cells";
              dt.Columns[38].ColumnName = "RBC";
              dt.Columns[39].ColumnName = "Bacteria";
              dt.Columns[40].ColumnName = "Stool Color";
              dt.Columns[41].ColumnName = "Stool Consistency";
              dt.Columns[42].ColumnName = "Stool PUS";
              dt.Columns[43].ColumnName = "Stool RBC";
              dt.Columns[44].ColumnName = "Others";
              //Xray
              dt.Columns[45].ColumnName = "Xray Status";
              dt.Columns[46].ColumnName = "Xray Impression";
              //ECG
              dt.Columns[47].ColumnName = "ECG Status";
              dt.Columns[48].ColumnName = "ECG Impression";
              //FBS
              dt.Columns[49].ColumnName = "FBS";
              dt.Columns[50].ColumnName = "Total Cholesterol";
            #endregion


            dataGrid.DataSource = dt;
            exportBtn.Enabled = true;


        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "CSV Custom JLA File|*.csv";
            savefile.ShowDialog();
            try
            {
                patients.ToCSV(savefile.FileName);
            }
            catch
            {

            }
        }


        }
}
