using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SouthJLAInformationSystemC
{
    public partial class MainMenuV2 : Form
    {
        public MainMenuV2()
        {
            InitializeComponent();
            MenuClickedLabel.Text = "";
            SubMenuLabelClicked.Text = "";
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
        private void MainMenuV2_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            SidePanel.Dock = DockStyle.Fill;
            SubPanelsHide();
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
            SubMenuLabelClicked.Text = "";
            if (subPanel.Visible)
                subPanel.Hide();
            else
                subPanel.Show();
        }
        #region MainMenuPanel
        private void GeneralClinicBtn_Click(object sender, EventArgs e)
        {
            ContentPanel.Show();
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel1);
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
        }

        private void PhysicalBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel2);
            MenuClickedLabel.Text = PhysicalBtn.Text;
        }

        private void PsychBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel3);
            MenuClickedLabel.Text = PsychBtn.Text;
        }

        private void XrayBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel4);
            MenuClickedLabel.Text = XrayBtn.Text;
        }

        private void AudiometBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel5);
            MenuClickedLabel.Text = AudiometBtn.Text;
        }

        private void LaborBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel6);
            MenuClickedLabel.Text = LaborBtn.Text;
        }

        private void DrugTBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel7);
            MenuClickedLabel.Text = DrugTBtn.Text;
        }

        private void MisceBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel8);
            MenuClickedLabel.Text = MisceBtn.Text;
        }
        #endregion
        #region SubMenuGeneralClinic
        private void GenEnterReqBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
        }

        private void GenEditReqBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
        }

        private void GenEntEdtReqBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
        }

        private void GenEnterResuBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
        }

        private void GenEditResuBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
        }

        private void GenEntEdtResuBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
        }

        private void GenRepsBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
        }

        private void GenBillBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
        }

        private void GenQualBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
        }
        #endregion
        #region SubMenuPhysical
        private void PhysicalEntResBtn_Click(object sender, EventArgs e)
        {
            MenuClickedLabel.Text = PhysicalBtn.Text;
        }

        private void PhysicalEntEdtResBtn_Click(object sender, EventArgs e)
        {
            MenuClickedLabel.Text = PhysicalBtn.Text;
        }

        private void PhysicalRepsBtn_Click(object sender, EventArgs e)
        {
            MenuClickedLabel.Text = PhysicalBtn.Text;
        }
        #endregion

        private void MainMenuV2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
                GeneralClinicBtn.PerformClick();
            if (e.KeyCode == Keys.NumPad2)
                PhysicalBtn.PerformClick();
            if (e.KeyCode == Keys.NumPad3)
                PsychBtn.PerformClick();
            if (e.KeyCode == Keys.NumPad4)
                XrayBtn.PerformClick();
            if (e.KeyCode == Keys.NumPad5)
                AudiometBtn.PerformClick();
            if (e.KeyCode == Keys.NumPad6)
                LaborBtn.PerformClick();
            if (e.KeyCode == Keys.NumPad7)
                DrugTBtn.PerformClick();
            if (e.KeyCode == Keys.NumPad8)
                MisceBtn.PerformClick();
        }
    }
}
