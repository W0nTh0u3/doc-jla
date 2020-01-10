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
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
            dateFiledBox.Value = DateTime.Now;
        }

        private void dailyBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.ofw", conn);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);

            dataGrid.DataSource = dt;
        }
    }
}
