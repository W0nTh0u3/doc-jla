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
    public partial class PrintPreviewForm : Form
    {
        private string[] values,patientInfoValue;
        public PrintPreviewForm(string[] values, string[] patientInfoValue)
        {
            InitializeComponent();
            this.patientInfoValue = patientInfoValue;
            this.values = values;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CBCFormDoc cBCFormDoc = new CBCFormDoc();
            cBCFormDoc.SetParameterValue("IDVal", patientInfoValue[0]);
            cBCFormDoc.SetParameterValue("LastNameVal", patientInfoValue[1]);
            cBCFormDoc.SetParameterValue("FirstNameVal", patientInfoValue[2]);
            cBCFormDoc.SetParameterValue("MiddleNameVal", patientInfoValue[3]);
            cBCFormDoc.SetParameterValue("AgeVal", patientInfoValue[4]);
            cBCFormDoc.SetParameterValue("GenderVal", patientInfoValue[5]);
            cBCFormDoc.SetParameterValue("CivilVal", patientInfoValue[6]);
            cBCFormDoc.SetParameterValue("WBCVal", values[0]);
            cBCFormDoc.SetParameterValue("RBCVal", values[1]);
            cBCFormDoc.SetParameterValue("HGBVal", values[2]);
            cBCFormDoc.SetParameterValue("HCTVal", values[3]);
            cBCFormDoc.SetParameterValue("PLATELETVal", values[4]);
            cBCFormDoc.SetParameterValue("NEUTROPHILVal", values[5]);
            cBCFormDoc.SetParameterValue("LYMPHOCYTESVal", values[6]);
            cBCFormDoc.SetParameterValue("MONOCYTEVal", values[7]);
            crystalReportViewer1.ReportSource = cBCFormDoc;
            crystalReportViewer1.Refresh();
        }
    }
}
