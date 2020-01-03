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
    public partial class UrinalysisForm : Form
    {
        public UrinalysisForm()
        {
            InitializeComponent();
        }

        private void clinic_MicroscopyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clinic_MicroscopyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void UrinalysisForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Clinic_Microscopy' table. You can move, or remove it, as needed.
            this.clinic_MicroscopyTableAdapter.Fill(this.databaseDataSet.Clinic_Microscopy);

        }

      
    }
}
