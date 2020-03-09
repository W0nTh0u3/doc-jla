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
        DataTable patients,Hematology, urineStool, xray,ecg,fbs,counter,dt;
        int ei;
        public ReportsForm()
        {
            InitializeComponent();
        }
/*
        private void generateBtn_Click1(object sender, EventArgs e)
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
            sda.Fill(patients);
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


            dataGrid.DataSource = patients;
            exportBtn.Enabled = true;


        }
        */
        private void generateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
            dt = new DataTable();
            #region 
            //patient info
            dt.Columns.Add("Form No.");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Name");
            dt.Columns.Add("M.I.");
            dt.Columns.Add("Age");
            dt.Columns.Add("Birthdate");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Civil Status");
            dt.Columns.Add("Address");
            dt.Columns.Add("Date Registered");
            dt.Columns.Add("Package");
            dt.Columns.Add("Payment Status");
            dt.Columns.Add("Agency");
            dt.Columns.Add("Account");
            //CBC - Hematology
            dt.Columns.Add("WBC");
            dt.Columns.Add("RBC");
            dt.Columns.Add("HGB");
            dt.Columns.Add("HCT");
            dt.Columns.Add("Platelets");
            dt.Columns.Add("Neutrophil");
            dt.Columns.Add("Lymphocytes");
            dt.Columns.Add("Monocyte");
            //Clinical Microscopy - Urine Stool
            dt.Columns.Add("Urine Color");
            dt.Columns.Add("Urine Transparency");
            dt.Columns.Add("Leukocyte");
            dt.Columns.Add("Nitrite");
            dt.Columns.Add("Urobilinogen");
            dt.Columns.Add("Protein");
            dt.Columns.Add("PH");
            dt.Columns.Add("Blood");
            dt.Columns.Add("Specific Gravity");
            dt.Columns.Add("Ketone");
            dt.Columns.Add("Bilirubin");
            dt.Columns.Add("Glucose");
            dt.Columns.Add("Epithelial Cells");
            dt.Columns.Add("Mucous Threads");
            dt.Columns.Add("Amorphous Meterial");
            dt.Columns.Add("PUS Cells");
            dt.Columns.Add("Urine RBC");
            dt.Columns.Add("Bacteria");
            dt.Columns.Add("Stool Color");
            dt.Columns.Add("Stool Consistency");
            dt.Columns.Add("Stool PUS");
            dt.Columns.Add("Stool RBC");
            dt.Columns.Add("Others");
            //Xray
            dt.Columns.Add("Xray Status");
            dt.Columns.Add("Xray Impression");
            //ECG
            dt.Columns.Add("ECG Status");
            dt.Columns.Add("ECG Impression");
            //FBS
            dt.Columns.Add("FBS");
            dt.Columns.Add("Total Cholesterol");
            #endregion

            string sqlstring = "SELECT COUNT(*) FROM dbo.ofw";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, conn);
            counter = new DataTable(); //this is creating a virtual table  
            sda.Fill(counter);

            int count = Int32.Parse(counter.Rows[0][0].ToString()),rowTracker;
            string IDtracker;
             for (int i = 1; i <= count; i++)
             {
                 sqlstring = "SELECT patientID,lastName,givenName,middleName,age,birthDate,gender,civilStatus,address,dateFiled,package,paid,agency,account   FROM dbo.ofw ";
                 sda = new SqlDataAdapter(sqlstring, conn);
                 patients = new DataTable(); //this is creating a virtual table  
                 sda.Fill(patients);
                 IDtracker = patients.Rows[i-1][0].ToString();
                 


                dt.Rows.Add();

                 for (ei = 0; ei < 14; ei++)
                 {
                     dt.Rows[i - 1][ei] = patients.Rows[i - 1][ei];
                 }
                patients.Clear();
                //transfer Hematology to dt
                sqlstring = "SELECT wbc,rbc,hgb,hct,platelets,neutrophil,lymphocytes,monocyte FROM dbo.Hematology WHERE ofw_id ="+IDtracker;
                 sda = new SqlDataAdapter(sqlstring, conn);
                 Hematology = new DataTable(); //this is creating a virtual table  
                 sda.Fill(Hematology);
                Console.WriteLine(i);
                 rowTracker = Hematology.Rows.Count;
                 addToDT(rowTracker, Hematology,8,i);
                  Hematology.Clear();
                 //transfer Clinical Microscopy - Urine Stool to dt
                 sqlstring = "SELECT MacroColor,MacroTransparency,Leukocyte,Nitrite,Urobilinogen,Protein,PH,Blood,SpecificGravity,Ketone,Bilirubin,Glucose,MicroEpithelial,MucousThreads,AmorphousMaterial,PusCells,rbcU,bacteria,color,consistency,pus,rbcS,others FROM dbo.urineStool WHERE ofw_id =" + IDtracker;
                 sda = new SqlDataAdapter(sqlstring, conn);
                 urineStool = new DataTable(); //this is creating a virtual table  
                 sda.Fill(urineStool);
    
                rowTracker = urineStool.Rows.Count;
                 addToDT(rowTracker, urineStool, 23, i);
                urineStool.Clear();

                //transfer xray to dt
                sqlstring = "SELECT status,impression   FROM dbo.xray WHERE ofw_id =" + IDtracker;
                 sda = new SqlDataAdapter(sqlstring, conn);
                 xray = new DataTable(); //this is creating a virtual table  
                 sda.Fill(xray);

                 rowTracker = xray.Rows.Count;
                 addToDT(rowTracker, xray, 2, i);
                xray.Clear();

                //transfer ECG to dt
                sqlstring = "SELECT ecgStatus,ecgImpression   FROM dbo.ecg WHERE ofw_id =" + IDtracker;
                 sda = new SqlDataAdapter(sqlstring, conn);
                 ecg = new DataTable(); //this is creating a virtual table  
                 sda.Fill(ecg);
                 dataGrid.DataSource = dt;
                 rowTracker = ecg.Rows.Count;
                 addToDT(rowTracker, ecg, 2, i);
                ecg.Clear();

                //transfer FBS to dt
                sqlstring = "SELECT fbs,totalCholesterol   FROM dbo.Blood_Chemistrty WHERE ofw_id =" + IDtracker;
                 sda = new SqlDataAdapter(sqlstring, conn);
                 fbs = new DataTable(); //this is creating a virtual table  
                 sda.Fill(fbs);

                 rowTracker = fbs.Rows.Count;
                 addToDT(rowTracker, fbs, 2, i);
                fbs.Clear();

            }


            dataGrid.DataSource = dt;


        }
        // tracker is number of columns
        // cl is number of columns on the table to be added
        // i is number of row
        private void addToDT(int tracker, DataTable table, int cl, int i)
        {
            int clnow = 0;
            if (tracker == 1)
            {
                for (; clnow < cl; clnow++)
                {
                    dt.Rows[i - 1][ei] = table.Rows[0][clnow].ToString();
                    ei++;
                }
            }
            else
            {
                ei = ei + cl;
            }
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
