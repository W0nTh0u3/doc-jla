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
            Label13.Parent = pictureBox2;
            Label13.BackColor = Color.Transparent;
            Label14.Parent = pictureBox2;
            Label14.BackColor = Color.Transparent;
            Label15.Parent = pictureBox2;
            Label15.BackColor = Color.Transparent;
            Label16.Parent = pictureBox2;
            Label16.BackColor = Color.Transparent;
            Label17.Parent = pictureBox2;
            Label17.BackColor = Color.Transparent;

        }

        private void MainMenuTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lbl_title.Text = MainMenuTree.SelectedNode.Text;
        }
    }
}
