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
    public partial class DictionaryForm : Form
    {
        public string testDic = "";

        public DictionaryForm()
        {
            InitializeComponent();
            HideAllPanel();

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection  
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT tests FROM dbo.tests", conn);
            DataTable dt = new DataTable(); //this is creating a virtual table 
            sda.Fill(dt);

            for (int i = 0; i < 6; i++)
            {
                testCombo.Items.Add(dt.Rows[i][0].ToString());
            }
        
        }
        private void HideAllPanel()
        {
            ViewDictPanel.Hide();
            EditDictPanel.Hide();
            ViewPackPanel.Hide();
            AddPackPanel.Hide();
        }
        private void ViewDicBtn_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            ViewDictPanel.Dock = DockStyle.Fill;
            ViewDictPanel.Show();
        }

        private void EditDicBtn_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            EditDictPanel.Dock = DockStyle.Fill;
            EditDictPanel.Show();
        }

        private void ViewPacBtn_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            ViewPackPanel.Dock = DockStyle.Fill;
            ViewPackPanel.Show();
        }

        private void EditPacBtn_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            AddPackPanel.Dock = DockStyle.Fill;
            AddPackPanel.Show();
        }

        private void ChangeTest(object sender, EventArgs e)
        {

            Console.WriteLine("Selected dictionary: "+ testCombo.SelectedItem);
            
            if( testCombo.SelectedItem.ToString() == "Hematology")
            {
                testDic = "HematologyDictionary";
                Console.WriteLine("okay Hema");
            }

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection
            string sqlstring = "SELECT DISTINCT field FROM dbo." + testDic;
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlstring, conn);
            DataTable dt1 = new DataTable(); //this is creating a virtual table 
            sda1.Fill(dt1);

            string sqlstring1 = "SELECT COUNT(field) FROM dbo." + testDic;
            SqlDataAdapter sda2 = new SqlDataAdapter(sqlstring1, conn);
            DataTable dt2 = new DataTable(); //this is creating a virtual table 
            sda2.Fill(dt2);
            string num = dt2.Rows[0][0].ToString();

            Console.WriteLine("No. of rows: " + dt2.Rows[0][0].ToString());

            int rows = System.Convert.ToInt32(num);

            fieldCombo.Items.Clear();

            for (int i = 0; i < rows; i++)
            {
                fieldCombo.Items.Add(dt1.Rows[i][0].ToString());
            }
        }

        private void ChangeField(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection
            string sqlstring = "SELECT field, units, age, gender, normal, min, max FROM dbo." + testDic + " WHERE field = '" + fieldCombo.SelectedItem + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, conn);
            DataTable dt = new DataTable(); //this is creating a virtual table 
            sda.Fill(dt);

            Console.WriteLine("field: " + dt.Rows[0][0].ToString());

            valuesBox.Clear();

            for (int i = 0; i < 7; i++)
            {
                valuesBox.AppendText(dt.Rows[0][i].ToString() + "\n");
            }

            string sqlstring1 = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + testDic + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlstring1, conn);
            DataTable dt1 = new DataTable(); //this is creating a virtual table 
            sda1.Fill(dt1);

            Console.WriteLine("field: " + dt1.Rows[0][0].ToString());

            contentBox.Clear();

            for (int i = 0; i < 7; i++)
            {
                contentBox.AppendText(dt1.Rows[i+1][0].ToString() + "\n");
            }

            



        }
    }
}
