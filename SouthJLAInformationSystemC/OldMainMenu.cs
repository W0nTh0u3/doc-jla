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
    public partial class OldMainMenu : Form
    {
        public OldMainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.ofw' table. You can move, or remove it, as needed.
            //this.ofwTableAdapter.Fill(this.databaseDataSet.ofw);
            //MainMenuTree.BackColor = Color.Transparent;
            //LabelsTransparent();
            Panel2.Location = new Point(442, 81);
            Panel5.Hide();
            
        }

        private void MainMenuTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lbl_title.Text = MainMenuTree.SelectedNode.Text;
            if (MainMenuTree.SelectedNode.Tag == "in")
            {
                Panel2.Location = new Point(0, 81);
                Panel5.Show();
            }
            else
            {
                Panel2.Location = new Point(447, 81);
                Panel5.Hide();
            }
                
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ofwBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {
            CBCForm cBC = new CBCForm();
            cBC.Show();
        }

        private void Label14_Click(object sender, EventArgs e)
        {
            UrinStoolForm urinalysisForm = new UrinStoolForm();
            urinalysisForm.Show();
        }

        private void Label15_Click(object sender, EventArgs e)
        {
            MedExamForm stoolForm = new MedExamForm();
            stoolForm.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Repos\doc-jla\App_Data\Database.mdf;Integrated Security=True"); // making connection   
            SqlCommand sda = new SqlCommand("INSERT INTO dbo.ofw (id, lastName, givenName, middleName, age, address) VALUES('2','" + lastBox.Text + "','" + firstBox.Text + "','" + middleBox.Text + "','" + ageBox.Text + "','" + addressTextbox.Text + "')", conn);
            conn.Open();
            sda.ExecuteNonQuery();
            conn.Close();
            System.Diagnostics.Debug.WriteLine("okay na");
        }
    }
}
