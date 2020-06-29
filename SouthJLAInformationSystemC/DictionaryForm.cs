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

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                viewTestCombo.Items.Add(dt.Rows[i][0].ToString());
                editTestCombo.Items.Add(dt.Rows[i][0].ToString());
                pTestAddBox.Items.Add(dt.Rows[i][0].ToString());
            }


            SqlDataAdapter sdaP = new SqlDataAdapter("SELECT DISTINCT packageName FROM dbo.Packages", conn);
            DataTable dtP = new DataTable(); //this is creating a virtual table 
            sdaP.Fill(dtP);

            for (int p = 0; p < dtP.Rows.Count; p++)
            {
                packsViewComboBox.Items.Add(dtP.Rows[p][0].ToString());
                packsEditComboBox.Items.Add(dtP.Rows[p][0].ToString());
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


        private void ChangePTestEdit(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection
            string sqlpt = "SELECT price FROM dbo.tests WHERE tests = '" + pTestAddBox.Text.ToString() + "'";
            SqlDataAdapter sdapt = new SqlDataAdapter(sqlpt, conn);
            DataTable dtPT = new DataTable();
            sdapt.Fill(dtPT);
            
            aPriceText.Text = dtPT.Rows[0][0].ToString();
            if (testIncluded.Items.Contains(pTestAddBox.Text.ToString()))
            {
                removeFrom.Enabled = true;
                addTo.Enabled = false;
                priceModBtn.Enabled = false;
                mPriceBox.Enabled = false;


            }
            else
            {
                mPriceText.Text = dtPT.Rows[0][0].ToString();
                removeFrom.Enabled = false;
                addTo.Enabled = true;
                priceModBtn.Enabled = true;
                mPriceBox.Enabled = true;

            }

        }

        private void changePackView(object sender, EventArgs e)
        {
            testViewPacks.Items.Clear();
            priceViewPacks.Items.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection
            string sqlbill = "SELECT * FROM dbo.Packages WHERE packageName = '" + packsViewComboBox.Text.ToString() + "'";
            SqlDataAdapter sdabill = new SqlDataAdapter(sqlbill, conn);
            DataTable dtP = new DataTable();
            sdabill.Fill(dtP);
            viewPricePack.Text = dtP.Rows[0][2].ToString();
            int numTestPack = dtP.Columns.Count - 2;

            for (int cTest = 1; cTest < numTestPack; cTest++)
            {
                Console.WriteLine(dtP.Rows[0][cTest + 2].ToString());
                if (dtP.Rows[0][cTest + 2].ToString() != "")
                {

                    string sqltestName = "SELECT tests FROM dbo.tests WHERE id = '" + cTest + "'";
                    SqlDataAdapter sdaTN = new SqlDataAdapter(sqltestName, conn);
                    DataTable dtTN = new DataTable();
                    sdaTN.Fill(dtTN);

                    testViewPacks.Items.Add(dtTN.Rows[0][0].ToString());
                    priceViewPacks.Items.Add(dtP.Rows[0][cTest + 2].ToString());

                }
            }
        }
        private void ChangePackEdit(object sender, EventArgs e)
        {
            testIncluded.Items.Clear();
            priceIncluded.Items.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection

            int numPacks = packsEditComboBox.Items.Count, ifInside = 0;
            for (int pac = 0; pac < numPacks; pac++)
            {
                if (packsEditComboBox.Items.Contains(packsEditComboBox.Text))
                {
                    ifInside = 1;
                }
            }
            if(ifInside == 1)
            {
                savePack.Text = "Save";
                string sqlbill = "SELECT * FROM dbo.Packages WHERE packageName = '" + packsEditComboBox.Text.ToString() + "'";
                SqlDataAdapter sdabill = new SqlDataAdapter(sqlbill, conn);
                DataTable dtP = new DataTable(); 
                sdabill.Fill(dtP);
                packagePrice.Text = dtP.Rows[0][2].ToString();
                int numTestPack = dtP.Columns.Count - 2;
                int packBill = 0;
                for (int cTest = 1; cTest <numTestPack; cTest++)
                {
                    Console.WriteLine(dtP.Rows[0][cTest + 2].ToString());
                    if (dtP.Rows[0][cTest+2].ToString() != "")
                    {
                      
                        string sqltestName = "SELECT tests FROM dbo.tests WHERE id = '" + cTest + "'";
                        SqlDataAdapter sdaTN = new SqlDataAdapter(sqltestName, conn);
                        DataTable dtTN = new DataTable();
                        sdaTN.Fill(dtTN);
                      
                        testIncluded.Items.Add(dtTN.Rows[0][0].ToString());
                        priceIncluded.Items.Add(dtP.Rows[0][cTest+2].ToString());

                        if (dtP.Rows[0][2].ToString() == "" || dtP.Rows[0][2].ToString() == "0")
                        {
                            string adder = dtP.Rows[0][cTest + 2].ToString();
                            packBill += Int32.Parse(adder) ;
                            packagePrice.Text = packBill.ToString();
                        }
                        else
                        {
                            packagePrice.Text = dtP.Rows[0][2].ToString();
                        }


                    }
                }
          
            }
            else
            {
                savePack.Text = "Create Package";
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

            if(editFieldCombo.SelectedItem.ToString() != "XRAY" ||  editFieldCombo.SelectedItem.ToString() != "ECG")
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

        private void savePack_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection
            string sqlstring = "";
            if (savePack.Text == "Save") {
                sqlstring = "DELETE FROM dbo.Packages WHERE packageName = '"+packsEditComboBox.Text+"'";
                SqlCommand sda3 = new SqlCommand(sqlstring, conn);
                conn.Open();
                sda3.ExecuteNonQuery();
                conn.Close();
            }
            int counterTest = testIncluded.Items.Count;

            sqlstring = "INSERT INTO dbo.Packages (packageName,bill) VALUES ('" + packsEditComboBox.Text + "', '" + packagePrice.Text + "')";
            SqlCommand sda = new SqlCommand(sqlstring, conn);
            conn.Open();
            sda.ExecuteNonQuery();
            conn.Close();
            for (int cT = 0; cT<counterTest; cT++)
            {
                SqlCommand sda2 = new SqlCommand("UPDATE dbo.Packages SET " + testIncluded.Items[cT].ToString() +" = '"+priceIncluded.Items[cT].ToString()+"' WHERE packageName = '"+packsEditComboBox.Text+"'", conn);
                conn.Open();
                sda2.ExecuteNonQuery();
                conn.Close();
            }
            clearPackage();

        }

        private void priceModBtn_Click(object sender, EventArgs e)
        {
            if (mPriceBox.Text != "")
            { mPriceText.Text = mPriceBox.Text; }
        }

        private void addTo_Click(object sender, EventArgs e)
        {
            testIncluded.Items.Add(pTestAddBox.Text);
            priceIncluded.Items.Add(mPriceText.Text);
       
                removeFrom.Enabled = true;
                addTo.Enabled = false;
                priceModBtn.Enabled = false;
                mPriceBox.Enabled = false;
                mPriceText.Text = "";
                mPriceBox.Text = "";

            refreshPrice();
        }

        private void removeFrom_Click(object sender, EventArgs e)
        {
            int testIndex = testIncluded.Items.IndexOf(pTestAddBox.Text);
            testIncluded.Items.Remove(pTestAddBox.Text);
            priceIncluded.Items.RemoveAt(testIndex);

            mPriceText.Text = aPriceText.Text;
            mPriceBox.Text = "";
            removeFrom.Enabled = false;
            addTo.Enabled = true;
            priceModBtn.Enabled = true;
            mPriceBox.Enabled = true;
            refreshPrice();
        }
        private void refreshPrice()
        {
            int adder=0;
            for (int cPrices = 0; cPrices<priceIncluded.Items.Count; cPrices++)
            {
                adder += Int32.Parse(priceIncluded.Items[cPrices].ToString());
            }
            packagePrice.Text = adder.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearPackage();

        }
        private void clearPackage()
        {
            packsEditComboBox.Text = "";
            priceIncluded.Items.Clear();
            testIncluded.Items.Clear();
            packagePrice.Text = "";
            mPriceText.Text = aPriceText.Text;
            mPriceBox.Text = "";
            mPriceBox.Enabled = false;
            priceModBtn.Enabled = false;
            addTo.Enabled = true;
            removeFrom.Enabled = false;
        }
    }
}
