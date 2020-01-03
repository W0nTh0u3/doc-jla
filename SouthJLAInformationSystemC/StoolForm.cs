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
    public partial class StoolForm : Form
    {
        public StoolForm()
        {
            InitializeComponent();
        }

        private void stool_ExaminationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stool_ExaminationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void StoolForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Stool_Examination' table. You can move, or remove it, as needed.
            this.stool_ExaminationTableAdapter.Fill(this.databaseDataSet.Stool_Examination);

        }

        private void SubmitCBC_Click(object sender, EventArgs e)
        {
           
        }
    }
}
