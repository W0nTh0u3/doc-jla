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
using System.IO;
namespace SouthJLAInformationSystemC
{
    public partial class OffsiteReportsForm : Form
    {
        DataTable dt;
        public OffsiteReportsForm()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
            string sqlstring = "SELECT Form_No, Employee_Number, lastName, givenName, middleName, gender, age, Date_Registered, VITAL_SIGNS, CBC, FBS, Cholesterol, Physical_Examination, ECG, PAP_Smear, Eye_Check_up, Chest_Xray, Urine_Exam, Stool_Exam, Remarks, Date_Completed  FROM dbo.mjrl2020";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, conn);
            dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            dt.Columns[0].ColumnName = "Form No.";
            dt.Columns[1].ColumnName = "Employee Number";
            dt.Columns[2].ColumnName = "Surname";
            dt.Columns[3].ColumnName = "Name";
            dt.Columns[4].ColumnName = "M.I.";
            dt.Columns[5].ColumnName = "Gender";
            dt.Columns[6].ColumnName = "Age";
            dt.Columns[7].ColumnName = "Date Registered";
            dt.Columns[8].ColumnName = "Vital Signs";
            dt.Columns[9].ColumnName = "CBC";
            dt.Columns[10].ColumnName = "FBS";
            dt.Columns[11].ColumnName = "Cholesterol";
            dt.Columns[12].ColumnName = "Physical Examination";
            dt.Columns[13].ColumnName = "ECG";
            dt.Columns[14].ColumnName = "PAP Smear";
            dt.Columns[15].ColumnName = "Eye Check Up";
            dt.Columns[16].ColumnName = "Chest X-Ray";
            dt.Columns[17].ColumnName = "Urine Exam";
            dt.Columns[18].ColumnName = "Stool Exam";
            dt.Columns[19].ColumnName = "Remarks";
            dt.Columns[20].ColumnName = "Date Completed";
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
                dt.ToCSV(savefile.FileName);
            }
            catch
            {
                
            } 
        }
    }
    public static class CSVUtlity
    {
        public static void ToCSV(this DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers  
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
    }
}
