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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            MainMenuTree.BackColor = Color.Transparent;
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

    }
}
