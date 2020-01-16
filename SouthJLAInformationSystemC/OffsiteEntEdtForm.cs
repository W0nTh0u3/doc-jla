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
    public partial class OffsiteEntEdtForm : Form
    {
        public OffsiteEntEdtForm()
        {
            InitializeComponent();
            InitializeDropDowns();
        }
        private void InitializeDropDowns()
        {
            vitalSignStatusBox.SelectedIndex = cbcStatusBox.SelectedIndex = fbsStatusBox.SelectedIndex = medStatusBox.SelectedIndex = ecgStatusBox.SelectedIndex = papsStatusBox.SelectedIndex = eyeStatusBox.SelectedIndex = xrayStatusBox.SelectedIndex = UriStatusBox.SelectedIndex = StoolStatusBox.SelectedIndex = 0;
        }
    }
}
