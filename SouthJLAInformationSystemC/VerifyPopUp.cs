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
    public partial class VerifyPopUp : Form
    {
        public string thisSql;
        public string[] valuesTest, patientInfoValue;
        public VerifyPopUp(string thisSqlpass, string[] valuesTest, string[] patientInfoValue)
        {
            InitializeComponent();
            thisSql = thisSqlpass;
            Console.WriteLine(thisSql);
            this.valuesTest = valuesTest;
            this.patientInfoValue = patientInfoValue;
        }

        private void FileBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(thisSql);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True"); // making connection   
            SqlCommand sda = new SqlCommand(thisSql, conn);
            conn.Open();
            sda.ExecuteNonQuery();
            conn.Close();
        }

        private void ExtPrintBtn_Click(object sender, EventArgs e)
        {

        }

        private void IntPrintBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
