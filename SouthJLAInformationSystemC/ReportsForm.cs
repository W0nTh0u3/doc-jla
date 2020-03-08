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
        DataTable patients;
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
            string sqlstring = "SELECT patientID,lastName,givenName,middleName,age,birthDate,gender,civilStatus,address,dateFiled,package,paid,agency,account   FROM dbo.ofw";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, conn);
            patients = new DataTable(); //this is creating a virtual table  
            sda.Fill(patients);
            
            patients.Columns[0].ColumnName = "Form No.";
            patients.Columns[1].ColumnName = "Surname";
            patients.Columns[2].ColumnName = "Name";
            patients.Columns[3].ColumnName = "M.I.";
            patients.Columns[4].ColumnName = "Age";
            patients.Columns[5].ColumnName = "Birthdate";
            patients.Columns[6].ColumnName = "Gender";
            patients.Columns[7].ColumnName = "Civil Status";
            patients.Columns[8].ColumnName = "Address";
            patients.Columns[9].ColumnName = "Date Registered";
            patients.Columns[10].ColumnName = "Package";
            patients.Columns[11].ColumnName = "Payment Status";
            patients.Columns[12].ColumnName = "Agency";
            patients.Columns[13].ColumnName = "Account";
            dataGrid.DataSource = patients;
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
