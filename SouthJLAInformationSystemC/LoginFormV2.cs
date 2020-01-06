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
    public partial class LoginFormV2 : Form
    {
        public LoginFormV2()
        {
            InitializeComponent();
            WrongLabel.Hide();
            AcceptButton = SignInBtn;
        }

        private void UsernameBox_Click(object sender, EventArgs e)
        {
            UsernameBox.Clear();
        }

        private void PasswordBox_Click(object sender, EventArgs e)
        {
            PasswordBox.Clear();
        }

        private void UsernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            WrongLabel.Hide();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            //if (UsernameBox.Text == "admin" && PasswordBox.Text == "admin")
            //{
            //    MainMenuV2 mainMenu = new MainMenuV2();
            //    Hide();
            //    mainMenu.Show();
            //}
            //else
            //{
            //    WrongLabel.Show();
            //}
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Repos\doc-jla\App_Data\Database.mdf;Integrated Security=True"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM dbo.adminJLA WHERE username = '" + UsernameBox.Text + "' AND pass = '" + PasswordBox.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            System.Diagnostics.Debug.WriteLine("username: " + UsernameBox.Text);
            System.Diagnostics.Debug.WriteLine("password: " + PasswordBox.Text);
            System.Diagnostics.Debug.WriteLine("cell 0,0: " + dt.Rows[0][0].ToString());
            if (dt.Rows[0][0].ToString() == "1")
            {
                MainMenuV2 mainMenu = new MainMenuV2();
                Hide();
                mainMenu.Show();
            }
            else
            {
                WrongLabel.Show();
            }
        }
    }
}
