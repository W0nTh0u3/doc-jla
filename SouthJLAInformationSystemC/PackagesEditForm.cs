﻿using System;
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
    public partial class PackagesEditForm : Form
    {
        MainMenu main = new MainMenu();
        public PackagesEditForm()
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

        private void MisceBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel8);
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
            ShowSubPanel(MenuPanel8);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditPacBtn_Click(object sender, EventArgs e)
        {
            PackagesEditForm PackagesEditForm = new PackagesEditForm();
            ActiveForm.Hide();
            PackagesEditForm.Show();
        }

        private void EditDicBtn_Click(object sender, EventArgs e)
        {
            DictionaryEditForm DictionaryEditForm = new DictionaryEditForm();
            ActiveForm.Hide();
            DictionaryEditForm.Show();
        }

        private void ViewPacBtn_Click(object sender, EventArgs e)
        {
            PackagesViewForm PackagesViewForm = new PackagesViewForm();
            ActiveForm.Hide();
            PackagesViewForm.Show();
        }

        private void ViewDicBtn_Click(object sender, EventArgs e)
        {
            DictionaryViewForm DictionaryViewForm = new DictionaryViewForm();
            ActiveForm.Hide();
            DictionaryViewForm.Show();
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
