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
    public partial class MainMenuV2 : Form
    {
        public MainMenuV2()
        {
            InitializeComponent();
        }

        private void GeneralClinicBtn_Click(object sender, EventArgs e)
        {
            ContentPanel.Show();
            SidePanel.Dock = DockStyle.Left;
            if (!MenuPanel1.Visible)
                MenuPanel1.Show();
            else
                MenuPanel1.Hide();
        }

        private void PhysicalBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            if (!MenuPanel2.Visible)
                MenuPanel2.Show();
            else
                MenuPanel2.Hide();
        }

        private void PsychBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            if (!MenuPanel3.Visible)
                MenuPanel3.Show();
            else
                MenuPanel3.Hide();
        }

        private void XrayBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            if (!MenuPanel4.Visible)
                MenuPanel4.Show();
            else
                MenuPanel4.Hide();
        }

        private void AudiometBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            if (!MenuPanel5.Visible)
                MenuPanel5.Show();
            else
                MenuPanel5.Hide();
        }

        private void LaborBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            if (!MenuPanel6.Visible)
                MenuPanel6.Show();
            else
                MenuPanel6.Hide();
        }

        private void DrugTBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            if (!MenuPanel7.Visible)
                MenuPanel7.Show();
            else
                MenuPanel7.Hide();
        }

        private void MisceBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            if (!MenuPanel8.Visible)
                MenuPanel8.Show();
            else
                MenuPanel8.Hide();
        }

        private void MainMenuV2_Load(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Fill;
            MenuPanel1.Hide();
            MenuPanel2.Hide();
            MenuPanel3.Hide();
            MenuPanel4.Hide();
            MenuPanel5.Hide();
            MenuPanel6.Hide();
            MenuPanel7.Hide();
            MenuPanel8.Hide();
            ContentPanel.Hide();
        }

        private void MainMenuV2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
