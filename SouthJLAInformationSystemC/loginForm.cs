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
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
            WrongLabel.Hide();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        private void Btn_signin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Repos\doc-jla\App_Data\Database.mdf;Integrated Security=True"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM dbo.adminJLA WHERE username = '"+ userBox.Text +"' AND pass = '"+ passBox.Text +"'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            System.Diagnostics.Debug.WriteLine("username: " + userBox.Text); 
            System.Diagnostics.Debug.WriteLine("password: " + passBox.Text);
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

        private void TextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            WrongLabel.Hide();
        }

        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            WrongLabel.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            AcceptButton = Btn_signin;
        }
    }
}
