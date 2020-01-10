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
                viewTestCombo.Items.Add(dt.Rows[i][0].ToString());
                editTestCombo.Items.Add(dt.Rows[i][0].ToString());
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

        private void ChangeTestView(object sender, EventArgs e)
        {

            Console.WriteLine("Selected dictionary: " + viewTestCombo.SelectedItem);
            viewFieldCombo.Items.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection

            if (viewTestCombo.SelectedItem.ToString() == "Hematology")
            {
                string sqlprice = "SELECT price FROM dbo.tests WHERE tests = '" + viewTestCombo.SelectedItem.ToString() + "'";
                SqlDataAdapter sdaprice = new SqlDataAdapter(sqlprice, conn);
                DataTable dtP = new DataTable(); //this is creating a virtual table 
                sdaprice.Fill(dtP);

                testDic = "HematologyDictionary";
                Console.WriteLine("okay Hema");
                viewPriceLabel.Text = dtP.Rows[0][0].ToString();
                Console.WriteLine("Price: " + dtP.Rows[0][0].ToString());

                addFielditems(conn);
            }


            else if (viewTestCombo.SelectedItem.ToString() == "Blood Chemistry")
            {
                string sqlprice = "SELECT price FROM dbo.tests WHERE tests = '" + viewTestCombo.SelectedItem.ToString() + "'";
                SqlDataAdapter sdaprice = new SqlDataAdapter(sqlprice, conn);
                DataTable dtP = new DataTable(); //this is creating a virtual table 
                sdaprice.Fill(dtP);

                testDic = "BloodChemistryDictionary";
                Console.WriteLine("okay" + viewTestCombo.SelectedItem.ToString());
                viewPriceLabel.Text = dtP.Rows[0][0].ToString();
                Console.WriteLine("Price: " + dtP.Rows[0][0].ToString());

                addFielditems(conn);
            }

            else if (viewTestCombo.SelectedItem.ToString() == "Stool Exam")
            {
                string sqlprice = "SELECT price FROM dbo.tests WHERE tests = '" + viewTestCombo.SelectedItem.ToString() + "'";
                SqlDataAdapter sdaprice = new SqlDataAdapter(sqlprice, conn);
                DataTable dtP = new DataTable(); //this is creating a virtual table 
                sdaprice.Fill(dtP);

                testDic = "StoolDictionary";
                Console.WriteLine("okay" + viewTestCombo.SelectedItem.ToString());
                viewPriceLabel.Text = dtP.Rows[0][0].ToString();
                Console.WriteLine("Price: " + dtP.Rows[0][0].ToString());

                addFielditems(conn);
            }

            else if (viewTestCombo.SelectedItem.ToString() == "Urinalysis")
            {
                string sqlprice = "SELECT price FROM dbo.tests WHERE tests = '" + viewTestCombo.SelectedItem.ToString() + "'";
                SqlDataAdapter sdaprice = new SqlDataAdapter(sqlprice, conn);
                DataTable dtP = new DataTable(); //this is creating a virtual table 
                sdaprice.Fill(dtP);

                testDic = "MicroscopyDictionary";
                Console.WriteLine("okay " + viewTestCombo.SelectedItem.ToString());
                viewPriceLabel.Text = dtP.Rows[0][0].ToString();
                Console.WriteLine("Price: " + dtP.Rows[0][0].ToString());

                addFielditems(conn);
            }

            else if (viewTestCombo.SelectedItem.ToString() == "ECG")
            {
                string sqlprice = "SELECT price FROM dbo.tests WHERE tests = '" + viewTestCombo.SelectedItem.ToString() + "'";
                SqlDataAdapter sdaprice = new SqlDataAdapter(sqlprice, conn);
                DataTable dtP = new DataTable(); //this is creating a virtual table 
                sdaprice.Fill(dtP);
                viewPriceLabel.Text = dtP.Rows[0][0].ToString();
                Console.WriteLine("Price: " + dtP.Rows[0][0].ToString());
            }
            else if (viewTestCombo.SelectedItem.ToString() == "XRAY")
            {
                string sqlprice = "SELECT price FROM dbo.tests WHERE tests = '" + viewTestCombo.SelectedItem.ToString() + "'";
                SqlDataAdapter sdaprice = new SqlDataAdapter(sqlprice, conn);
                DataTable dtP = new DataTable(); //this is creating a virtual table 
                sdaprice.Fill(dtP);
                viewPriceLabel.Text = dtP.Rows[0][0].ToString();
                Console.WriteLine("Price: " + dtP.Rows[0][0].ToString());
            }

            

            viewFieldCombo.SelectedIndex = -1;

            viewValueBox.Clear();
            viewContentBox.Clear();

        }

        private void addFielditems(SqlConnection conn)
        {
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





            for (int i = 0; i < rows; i++)
            {
                viewFieldCombo.Items.Add(dt1.Rows[i][0].ToString());
            }
        }

        private void ChangeFieldView(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection
            string sqlstring = "SELECT field, units, age, gender, normal, min, max FROM dbo." + testDic + " WHERE field = '" + viewFieldCombo.SelectedItem + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, conn);
            DataTable dt = new DataTable(); //this is creating a virtual table 
            sda.Fill(dt);

            Console.WriteLine("field: " + dt.Rows[0][0].ToString());

            viewValueBox.Clear();

            for (int i = 0; i < 7; i++)
            {
                viewValueBox.AppendText(dt.Rows[0][i].ToString() + "\n");
            }

            string sqlstring1 = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + testDic + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlstring1, conn);
            DataTable dt1 = new DataTable(); //this is creating a virtual table 
            sda1.Fill(dt1);

            Console.WriteLine("field: " + dt1.Rows[0][0].ToString());

            viewContentBox.Clear();

            for (int i = 0; i < 7; i++)
            {
                viewContentBox.AppendText(dt1.Rows[i+1][0].ToString() + "\n");
            }
        }


        private void ChangeTestEdit(object sender, EventArgs e)
        {

            Console.WriteLine("Selected dictionary: " + editTestCombo.SelectedItem);

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection

            if (editTestCombo.SelectedItem.ToString() == "Hematology")
            {
                string sqlprice = "SELECT price FROM dbo.tests WHERE tests = '" + editTestCombo.SelectedItem.ToString() + "'";
                SqlDataAdapter sdaprice = new SqlDataAdapter(sqlprice, conn);
                DataTable dtP = new DataTable(); //this is creating a virtual table 
                sdaprice.Fill(dtP);

                testDic = "HematologyDictionary";
                Console.WriteLine("okay Hema");
                editPriceLabel.Text = dtP.Rows[0][0].ToString();
                Console.WriteLine("Price: " + dtP.Rows[0][0].ToString());

                addFieldsEdit(conn);
            }


            else if (editTestCombo.SelectedItem.ToString() == "Blood Chemistry")
            {
                string sqlprice = "SELECT price FROM dbo.tests WHERE tests = '" + editTestCombo.SelectedItem.ToString() + "'";
                SqlDataAdapter sdaprice = new SqlDataAdapter(sqlprice, conn);
                DataTable dtP = new DataTable(); //this is creating a virtual table 
                sdaprice.Fill(dtP);

                testDic = "BloodChemistryDictionary";
                Console.WriteLine("okay" + editTestCombo.SelectedItem.ToString());
                editPriceLabel.Text = dtP.Rows[0][0].ToString();
                Console.WriteLine("Price: " + dtP.Rows[0][0].ToString());

                addFieldsEdit(conn);
            }

            else if (editTestCombo.SelectedItem.ToString() == "Stool Exam")
            {
                string sqlprice = "SELECT price FROM dbo.tests WHERE tests = '" + editTestCombo.SelectedItem.ToString() + "'";
                SqlDataAdapter sdaprice = new SqlDataAdapter(sqlprice, conn);
                DataTable dtP = new DataTable(); //this is creating a virtual table 
                sdaprice.Fill(dtP);

                testDic = "StoolDictionary";
                Console.WriteLine("okay" + editTestCombo.SelectedItem.ToString());
                editPriceLabel.Text = dtP.Rows[0][0].ToString();
                Console.WriteLine("Price: " + dtP.Rows[0][0].ToString());

                addFieldsEdit(conn);
            }

            else if (editTestCombo.SelectedItem.ToString() == "Urinalysis")
            {
                string sqlprice = "SELECT price FROM dbo.tests WHERE tests = '" + editTestCombo.SelectedItem.ToString() + "'";
                SqlDataAdapter sdaprice = new SqlDataAdapter(sqlprice, conn);
                DataTable dtP = new DataTable(); //this is creating a virtual table 
                sdaprice.Fill(dtP);

                testDic = "MicroscopyDictionary";
                Console.WriteLine("okay " + editTestCombo.SelectedItem.ToString());
                editPriceLabel.Text = dtP.Rows[0][0].ToString();
                Console.WriteLine("Price: " + dtP.Rows[0][0].ToString());

                addFieldsEdit(conn);
            }

            else if (editTestCombo.SelectedItem.ToString() == "ECG")
            {
                string sqlprice = "SELECT price FROM dbo.tests WHERE tests = '" + editTestCombo.SelectedItem.ToString() + "'";
                SqlDataAdapter sdaprice = new SqlDataAdapter(sqlprice, conn);
                DataTable dtP = new DataTable(); //this is creating a virtual table 
                sdaprice.Fill(dtP);
                editPriceLabel.Text = dtP.Rows[0][0].ToString();
                Console.WriteLine("Price: " + dtP.Rows[0][0].ToString());
            }
            else if (editTestCombo.SelectedItem.ToString() == "XRAY")
            {
                string sqlprice = "SELECT price FROM dbo.tests WHERE tests = '" + editTestCombo.SelectedItem.ToString() + "'";
                SqlDataAdapter sdaprice = new SqlDataAdapter(sqlprice, conn);
                DataTable dtP = new DataTable(); //this is creating a virtual table 
                sdaprice.Fill(dtP);
                editPriceLabel.Text = dtP.Rows[0][0].ToString();
                Console.WriteLine("Price: " + dtP.Rows[0][0].ToString());
            }



            editFieldCombo.SelectedIndex = -1;

            editValueBox.Clear();
            editContentBox.Clear();

        }

        private void addFieldsEdit(SqlConnection conn)
        {
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



            editFieldCombo.Items.Clear();

            for (int i = 0; i < rows; i++)
            {
                editFieldCombo.Items.Add(dt1.Rows[i][0].ToString());
            }
        }

        private void ChangeFieldEdit(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection
            string sqlstring = "SELECT field, units, age, gender, normal, min, max FROM dbo." + testDic + " WHERE field = '" + editFieldCombo.SelectedItem + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, conn);
            DataTable dt = new DataTable(); //this is creating a virtual table 
            sda.Fill(dt);

            Console.WriteLine("field: " + dt.Rows[0][0].ToString());

            Console.WriteLine("laman: " + dt.Rows[0]);

            editValueBox.Clear();

            for (int i = 0; i < 7; i++)
            {
                editValueBox.AppendText(dt.Rows[0][i].ToString() + "\n");
            }

            string sqlstring1 = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + testDic + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlstring1, conn);
            DataTable dt1 = new DataTable(); //this is creating a virtual table 
            sda1.Fill(dt1);

            Console.WriteLine("field: " + dt1.Rows[0][0].ToString());

            editContentBox.Clear();

            for (int i = 0; i < 7; i++)
            {
                editContentBox.AppendText(dt1.Rows[i + 1][0].ToString() + "\n");
            }
        }

        private void modifyPrice_Click(object sender, EventArgs e)
        {
            editPriceLabel.Text = priceBox.Text;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True"); // making connection   

            //edit price
            if(priceBox.Text != "")
            {
                string sqlString = "UPDATE dbo.tests SET price = '" + editPriceLabel.Text + "'  WHERE tests = '" + editTestCombo.SelectedItem + "'";
                SqlCommand sda = new SqlCommand(sqlString, conn);
                conn.Open();
                sda.ExecuteNonQuery();
                conn.Close();
            }

            if(editFieldCombo.SelectedItem != "XRAY" ||  editFieldCombo.SelectedItem != "ECG")
            {
                //edit 
                string[] vs = editValueBox.Lines;

                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("vs[" + i + "]: " + vs[i]);
                }

                string sqlString1 = "UPDATE dbo." + testDic + " SET field = '" + vs[0] + "',  units = '" + vs[1] + "',  age = '" + vs[2] + "',  gender = '" + vs[3] + "',  normal = '" + vs[4] + "',  min = '" + vs[5] + "',  max = '" + vs[6] + "' WHERE field = '" + editFieldCombo.SelectedItem + "'";
                SqlCommand sda1 = new SqlCommand(sqlString1, conn);
                conn.Open();
                sda1.ExecuteNonQuery();
                conn.Close();
            }


            MessageBox.Show("Edit Successfully!");



        }
    }
}
