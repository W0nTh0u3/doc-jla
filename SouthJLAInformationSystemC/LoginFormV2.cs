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
            if (UsernameBox.Text == "admin" && PasswordBox.Text == "admin")
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
