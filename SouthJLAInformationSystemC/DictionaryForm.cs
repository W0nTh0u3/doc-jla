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
    public partial class DictionaryForm : Form
    {

        public DictionaryForm()
        {
            InitializeComponent();
            HideAllPanel();
        }
        private void HideAllPanel()
        {
            ViewDictPanel.Hide();
            EditDictPanel.Hide();
            ViewPackPanel.Hide();
            AddPackPanel.Hide();
        }
        private void ViewDicBtn_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            ViewDictPanel.Dock = DockStyle.Fill;
            ViewDictPanel.Show();
        }

        private void EditDicBtn_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            EditDictPanel.Dock = DockStyle.Fill;
            EditDictPanel.Show();
        }

        private void ViewPacBtn_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            ViewPackPanel.Dock = DockStyle.Fill;
            ViewPackPanel.Show();
        }

        private void EditPacBtn_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            AddPackPanel.Dock = DockStyle.Fill;
            AddPackPanel.Show();
        }
    }
}
