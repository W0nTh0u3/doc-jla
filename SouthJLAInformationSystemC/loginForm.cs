using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SouthJLAInformationSystemC
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
            WrongLabel.Hide();
        }

        private void Btn_signin_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text == "admin" && TextBox3.Text == "admin")
            {
                MainMenu mainMenu = new MainMenu();
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
