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
    public partial class DictionaryViewForm : Form
    {
        MainMenu main = new MainMenu();
        public DictionaryViewForm()
        {
            main.SubPanelsHide();
            InitializeComponent();
        }
    }
}
