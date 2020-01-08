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
    public partial class BillingForm : Form
    {
        MainMenu main = new MainMenu();
        public BillingForm()
        {
            InitializeComponent();
            SubPanelsHide();

        }
        public void SubPanelsHide()
        {
            MenuPanel1.Hide();
            MenuPanel2.Hide();
            MenuPanel3.Hide();
            MenuPanel4.Hide();
            MenuPanel5.Hide();
            MenuPanel6.Hide();
            MenuPanel7.Hide();
            MenuPanel8.Hide();
        }
        public void ShowSubPanel(Panel subPanel)
        {
            if (subPanel.Visible)
                subPanel.Hide();
            else
                subPanel.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GeneralClinicBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel1);
        }

        private void PhysicalBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel2);
        }

        private void PsychBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel3);
        }

        private void XrayBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel4);
        }

        private void AudiometBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel5);
        }

        private void LaborBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel6);
        }

        private void DrugTBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel7);
        }

        private void MisceBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel8);
        }

        private void MisceDictBtn_Click(object sender, EventArgs e)
        {
            DictionaryViewForm dictionaryViewForm = new DictionaryViewForm();
            ActiveForm.Hide();
            dictionaryViewForm.Show();
        }

        private void GenEntEdtResuBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            main.Show();
        }

        private void GenEditReqBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            main.Show();
        }

        private void GenEntEdtReqBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            main.Show();
        }

        private void GenEnterResuBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            main.Show();
        }

        private void GenEditResuBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            main.Show();
        }

        private void GenEnterReqBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            main.Show();
        }
    }
}
