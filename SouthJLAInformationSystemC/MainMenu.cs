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
    public partial class MainMenu : Form
    {
        public string uniquePass = "";
        public string idPass = "";
        public string userClass = "";
        public bool userEnter = false;
        public bool userEdit = false;
        public bool userSuper = false;
        public string terminal = System.Environment.MachineName;
        public static string statusCbc = "", statusUrineStool = "", statusMed = "", statusXray = "", statusEcg = "", statusFbs = "", statusPaps = "";
        public MainMenu(string type)
        {
            InitializeComponent();

            Console.WriteLine("terminal: " + terminal);

            MenuClickedLabel.Text = "";
            SubMenuLabelClicked.Text = "";            userClass = type;            Console.WriteLine("User classification type: " + userClass);            if (type == "3")
            {
                userEnter = true;
                userEdit = true;
                userSuper = true;
            }            else if (type == "2")
            {
                userEnter = false;
                userEdit = true;
                userSuper = false;
            }            else if (type == "1")
            {
                userEnter = true;
                userEdit = false;
                userSuper = false;
            }
            dateFiledBox.Value = DateTime.Now;

            clearAll.Enabled = false;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection  
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT packageName FROM dbo.Packages", conn);
            DataTable dt = new DataTable(); //this is creating a virtual table 
            sda.Fill(dt);

            for (int i = 0; i < 1; i++)
            {
                packageBox.Items.Add(dt.Rows[i][0].ToString());
            }
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
            SubMenuPanel1.Hide();
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
            DisableAllBoxes();
            ContentPanel.Show();
            GenClinicPanel.Show();
            CloseChildForm();
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
            ContentPanel.Show();
            GenClinicPanel.Hide();
            SidePanel.Dock = DockStyle.Left;
            ShowSubPanel(MenuPanel8);
            MenuClickedLabel.Text = MisceBtn.Text;
        }
        #endregion
        #region SubMenuGeneralClinic
        private void GenEnterReqBtn_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            GenClinicPanel.Show();
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
            EnableOnlyPatientInfo();
            PatientIDPanel.Enabled = false;

            clearAllfields();

            submit.Text = "Enter";
            submit.Enabled = true;
        }

        private void GenEditReqBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CloseChildForm();
                GenClinicPanel.Show();
                Button btn = sender as Button;
                MenuClickedLabel.Text = GeneralClinicBtn.Text;
                SubMenuLabelClicked.Text = btn.Text;
                EnableOnlyPatientInfo();

                clearAllfields();

                submit.Text = "Save changes";
                Console.WriteLine("edit req");

                submit.Enabled = false;
            }
            catch (Exception en)
            {
                Console.WriteLine(en.Message);
            }

        }

        private void GenEntEdtReqBtn_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            GenClinicPanel.Show();
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
            EnableOnlyPatientInfo();

            clearAllfields();

            submit.Text = "Enter";
        }

        private void GenEnterResuBtn_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            GenClinicPanel.Show();
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
            EnableOnlyPatientResults();

            clearAllfields();

        }

        private void GenEditResuBtn_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            GenClinicPanel.Show();
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
            EnableOnlyPatientResults();

            clearAllfields();
        }

        private void GenEntEdtResuBtn_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            GenClinicPanel.Show();
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
            EnableOnlyPatientResults();

            clearAllfields();

            submit.Enabled = true;
        }

        private void GenRepsBtn_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
        }

        private void GenBillBtn_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
        }

        private void GenQualBtn_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text;
            SubMenuLabelClicked.Text = btn.Text;
        }
        private void OffsiteBtn_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text + " (" + btn.Text + ")";
            SubMenuLabelClicked.Text = String.Empty;
            GenClinicPanel.Hide();
            ShowSubPanel(SubMenuPanel1);
        }
        #endregion
        #region SubSubMenuOffsite
        private void OffsiteEntEdtReq_Click(object sender, EventArgs e)
        {
            GenClinicPanel.Hide();
            OpenChildForm(new OffsiteEntEdtForm());
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text + " (" + OffsiteBtn.Text + ")";
            SubMenuLabelClicked.Text = btn.Text;
        }

        private void OffsiteReps_Click(object sender, EventArgs e)
        {
            GenClinicPanel.Hide();
            OpenChildForm(new OffsiteReportsForm());
            Button btn = sender as Button;
            MenuClickedLabel.Text = GeneralClinicBtn.Text + " (" + OffsiteBtn.Text + ")";
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
        #region SubMenuMisc
        private void MisceDictBtn_Click(object sender, EventArgs e)
        {
            //DictionaryViewForm  DictionaryViewForm = new DictionaryViewForm();
            //ActiveForm.Hide();
            //DictionaryViewForm.Show();
            GenClinicPanel.Hide();
            OpenChildForm(new DictionaryForm());
            MenuClickedLabel.Text = MisceBtn.Text;
            SubMenuLabelClicked.Text = MisceDictBtn.Text;
        }

        private void MisceBillBtn_Click(object sender, EventArgs e)
        {
            //BillingForm BillingForm = new BillingForm();
            //ActiveForm.Hide();
            //BillingForm.Show();
            GenClinicPanel.Hide();
            OpenChildForm(new BillingForm());
            MenuClickedLabel.Text = MisceBtn.Text;
            SubMenuLabelClicked.Text = MisceBillBtn.Text;
        }
        #endregion
        #region labelsclickGenClinic


        private void CBCClickableLabel_Click(object sender, EventArgs e)
        {
            try
            {
                CBCForm cBC = new CBCForm(uniquePass, idPass, submit.Text);

                cBC.Show();
            }
            catch (Exception en)
            {
                MessageBox.Show("No existing record to edit.");
                Console.WriteLine(en.Message);
            }


        }

        private void UriClickableLabel_Click(object sender, EventArgs e)
        {            try
            {
                UrinStoolForm urinStoolForm = new UrinStoolForm(uniquePass, idPass, submit.Text);

                urinStoolForm.Show();
            }
            catch (Exception en)
            {
                MessageBox.Show("No existing record to edit.");
                Console.WriteLine(en.Message);
            }


        }

        private void MedExClickableLabel_Click(object sender, EventArgs e)
        {            try
            {

                MedExamForm medExamForm = new MedExamForm(uniquePass, idPass, submit.Text);
                medExamForm.Show();
            }
            catch (Exception en)
            {
                MessageBox.Show("No existing record to edit.");
                Console.WriteLine(en.Message);
            }

        }

        private void XrayClickableLabel_Click(object sender, EventArgs e)
        {            try
            {
                XrayForm xrayForm = new XrayForm(uniquePass, idPass, submit.Text);

                xrayForm.Show();
            }
            catch (Exception en)
            {
                MessageBox.Show("No existing record to edit.");
                Console.WriteLine(en.Message);
            }


        }

        private void ECGClickableLabel_Click(object sender, EventArgs e)
        {            try
            {
                ECGForm eCGForm = new ECGForm(uniquePass, idPass, submit.Text);

                eCGForm.Show();
            }
            catch (Exception en)
            {
                MessageBox.Show("No existing record to edit.");
                Console.WriteLine(en.Message);
            }


        }

        private void FBSClickableLabel_Click(object sender, EventArgs e)
        {            try
            {
                FBSCholeForm fBSCholeForm = new FBSCholeForm(uniquePass, idPass, submit.Text);

                fBSCholeForm.Show();
            }
            catch (Exception en)
            {
                MessageBox.Show("No existing record to edit.");
                Console.WriteLine(en.Message);
            }


        }





        private void PAPSClickedLabel_Click(object sender, EventArgs e)
        {
            PAPForm pAPForm = new PAPForm();
            pAPForm.Show();
        }
        #endregion
        private void DisableAllBoxes()
        {
            MajorelPanel.Enabled = false;
            PatientInfoPanel.Enabled = false;
            PatientIDPanel.Enabled = false;
        }
        private void EnableOnlyPatientInfo()
        {                PatientInfoPanel.Enabled = true;
            PatientIDPanel.Enabled = true;         
            MajorelPanel.Enabled = false;
        }
        private void EnableOnlyPatientResults()
        {
            MajorelPanel.Enabled = true;
            PatientInfoPanel.Enabled = false;
            PatientIDPanel.Enabled = true;
        }
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

        private void clearAllfields()
        {
            lastBox.Text = String.Empty;            firstBox.Text = String.Empty;            middleBox.Text = String.Empty;            ageBox.Text = String.Empty;            addressBox.Text = String.Empty;            civilBox.SelectedIndex = -1;            genderBox.SelectedIndex = -1;
            searchBox.Text = String.Empty;
            bdayBox.Value = DateTime.Now;
            packageBox.SelectedIndex = -1;
            companyBox.Text = String.Empty;
            accBox.Text = String.Empty;
            paymentStatusBox.SelectedIndex = -1;

        }


        
        


        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
                SqlDataAdapter sdaSearch = new SqlDataAdapter("SELECT * FROM dbo.ofw WHERE patientID = '" + searchBox.Text + "'", conn);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sdaSearch.Fill(dt);

                DateTime date1 = Convert.ToDateTime(dt.Rows[0][5].ToString());

                lastBox.Text = dt.Rows[0][1].ToString();
                firstBox.Text = dt.Rows[0][2].ToString();
                middleBox.Text = dt.Rows[0][3].ToString();
                ageBox.Text = dt.Rows[0][4].ToString();
                addressBox.Text = dt.Rows[0][8].ToString();
                genderBox.SelectedItem = dt.Rows[0][6].ToString();
                civilBox.SelectedItem = dt.Rows[0][7].ToString();
                uniquePass = dt.Rows[0][11].ToString();
                idPass = dt.Rows[0][0].ToString();
                bdayBox.Value = date1;
                packageBox.SelectedItem = dt.Rows[0][10].ToString();
                paymentStatusBox.SelectedItem = dt.Rows[0][12].ToString();
                companyBox.Text = dt.Rows[0][14].ToString();
                accBox.Text = dt.Rows[0][15].ToString();

                submit.Text = "Save changes";
                if (SubMenuLabelClicked.Text == "Enter Results")
                    submit.Text = "Enter";

                clearAll.Enabled = true;

                submit.Enabled = true;
            }
            catch (Exception en)
            {
                MessageBox.Show("No matching record found.");
                Console.WriteLine(en.Message);
            }

        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            clearAllfields();
            submit.Text = "Enter";
            clearAll.Enabled = false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (submit.Text == "Enter")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
                SqlCommand sda = new SqlCommand("INSERT INTO dbo.ofw (lastName, givenName, middleName, age, address, civilStatus, gender, dateFiled, paid, terminal, package, agency, account, birthDate) VALUES('" + lastBox.Text + "','" + firstBox.Text + "','" + middleBox.Text + "','" + ageBox.Text + "','" + addressBox.Text + "','" + civilBox.SelectedItem + "','" + genderBox.SelectedItem + "','" + dateFiledBox.Value.ToString("MM-dd-yyyy") + "','" + paymentStatusBox.SelectedItem + "','" + terminal + "','" + packageBox.SelectedItem + "','" + companyBox.Text + "','" + accBox.Text + "', '" + bdayBox.Value.Date.ToString() + "')", conn);
                conn.Open();
                sda.ExecuteNonQuery();
                conn.Close();

                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT MAX(id) FROM dbo.ofw", conn);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda1.Fill(dt);
                string patientID = dateFiledBox.Value.ToString("MM") + dateFiledBox.Value.ToString("dd");
                string unique = "MJRL-" + dt.Rows[0][0].ToString();

                Console.WriteLine("unique id:" + unique);

                SqlCommand sda2 = new SqlCommand("UPDATE dbo.ofw SET patientID = '" + unique + "' WHERE id = '" + dt.Rows[0][0].ToString() + "'", conn);
                conn.Open();
                sda2.ExecuteNonQuery();
                conn.Close();

                System.Diagnostics.Debug.WriteLine("okay na");
                lastBox.Text = String.Empty;
                firstBox.Text = String.Empty;
                middleBox.Text = String.Empty;
                ageBox.Text = String.Empty;
                addressBox.Text = String.Empty;
                civilBox.SelectedIndex = -1;
                genderBox.SelectedIndex = -1;
                MessageBox.Show("Successful! This is your Patient ID: " + unique);
            }            else if (submit.Text == "Save" || submit.Text == "Save changes")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
                SqlCommand sda = new SqlCommand("UPDATE dbo.ofw  SET lastName = '" + lastBox.Text + "',  givenName =   '" + firstBox.Text + "', middleName = '" + middleBox.Text + "', age = '" + ageBox.Text + "', gender = '" + genderBox.SelectedItem + "', civilStatus = '" + civilBox.SelectedItem + "', address = '" + addressBox.Text + "',  agency =   '" + companyBox.Text + "',  paid =   '" + paymentStatusBox.SelectedItem + "',  terminal =   '" + terminal + "',  package =   '" + packageBox.SelectedItem + "',  account =   '" + accBox.Text + "',  birthDate =   '" + bdayBox.Value.Date.ToString() + "' WHERE id = '" + idPass + "'", conn);
                conn.Open();
                sda.ExecuteNonQuery();
                Console.WriteLine("Nagsave na");
                conn.Close();
                MessageBox.Show("Edit Successful!");
            }
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchButton_Click(this, new EventArgs());
        }
        private Form activeSubForm = null;
        private void OpenChildForm(Form childForm)
        {
            CloseChildForm();
            activeSubForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            ChildContentPanel.Controls.Add(childForm);
            ChildContentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CloseChildForm()
        {
            if (activeSubForm != null)
                activeSubForm.Close();
        }


    }
}


/* for combining databases
  SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"); // making connection   
  SqlDataAdapter sdaSearch = new SqlDataAdapter("SELECT * FROM dbo.ofw WHERE patientID = '" + searchBox.Text + "'", conn);

    string tableNames[] = 
    string columnNames[] = 
    string dbTarget,dbSource;

        *****NEEDS TO PING OTHER DEVICE FIRST AND ALLOCATE WHICH IS dbTarget and dbSource********** #ComNet4Lyfe

    for (int counter=0;counter<10;counter++)
   {  SqlDataAdapter sdaSearch = new SqlDataAdapter("MERGE "+dbTarget+".dbo."+tableNames[counter]+" T USING "dbSource".dbo."+tableNames[counter]+" S ON (S.* = T.*) WHEN NOT MATCHED BY TARGET THEN INSERT INTO "+tableNames[counter]+"", conn);
     
}
    *******END PINGING HERE********

     
     */
