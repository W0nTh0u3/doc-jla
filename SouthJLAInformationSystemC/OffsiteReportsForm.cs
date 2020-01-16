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
            dataGrid.DataSource = dt;

        }

        private void exportBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
