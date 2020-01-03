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
    public partial class CBCForm : Form
    {
        public CBCForm()
        {
            InitializeComponent();
        }

        private void hematologyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hematologyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void CBCForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Hematology' table. You can move, or remove it, as needed.
            this.hematologyTableAdapter.Fill(this.databaseDataSet.Hematology);
        }

        private void SubmitCBC_Click(object sender, EventArgs e)
        {
            
        }
    }
}
