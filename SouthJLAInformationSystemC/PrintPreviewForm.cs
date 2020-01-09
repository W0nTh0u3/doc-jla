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
        private readonly string[] values,patientInfoValue;
        public PrintPreviewForm(string[] values, string[] patientInfoValue)
        {
            InitializeComponent();
            this.patientInfoValue = patientInfoValue;
            this.values = values;
        }

        private void PrintPreviewForm_Load(object sender, EventArgs e)
        {
            if (patientInfoValue[0] == "CBCForm")
                CBCFormPreview();
            else if (patientInfoValue[0] == "UrinStoolForm")
                UrinStoolFormPreview();
        }
        private void CBCFormPreview()
        {
            CBCFormDoc cBCFormDoc = new CBCFormDoc();
            cBCFormDoc.SetParameterValue("IDVal", patientInfoValue[1]);
            //cBCFormDoc.SetParameterValue("LastNameVal", patientInfoValue[1]);
            //cBCFormDoc.SetParameterValue("FirstNameVal", patientInfoValue[2]);
            //cBCFormDoc.SetParameterValue("MiddleNameVal", patientInfoValue[3]);
            cBCFormDoc.SetParameterValue("FullNameVal", patientInfoValue[2] + " ," + patientInfoValue[3] + " " + patientInfoValue[4] + ".");
            cBCFormDoc.SetParameterValue("AgeVal", patientInfoValue[5]);
            cBCFormDoc.SetParameterValue("GenderVal", patientInfoValue[6]);
            cBCFormDoc.SetParameterValue("CivilVal", patientInfoValue[7]);
            cBCFormDoc.SetParameterValue("FormNVal", patientInfoValue[8]);
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
        private void UrinStoolFormPreview()
        {
            UriStoolFormDoc uriStoolFormDoc = new UriStoolFormDoc();
            uriStoolFormDoc.SetParameterValue("IDVal", patientInfoValue[1]);
            //uriStoolFormDoc.SetParameterValue("LastNameVal", patientInfoValue[1]);
            //uriStoolFormDoc.SetParameterValue("FirstNameVal", patientInfoValue[2]);
            //uriStoolFormDoc.SetParameterValue("MiddleNameVal", patientInfoValue[3]);
            uriStoolFormDoc.SetParameterValue("FullNameVal", patientInfoValue[2] + " ," + patientInfoValue[3] + " " + patientInfoValue[4] + ".");
            uriStoolFormDoc.SetParameterValue("AgeVal", patientInfoValue[5]);
            uriStoolFormDoc.SetParameterValue("GenderVal", patientInfoValue[6]);
            uriStoolFormDoc.SetParameterValue("CivilVal", patientInfoValue[7]);
            uriStoolFormDoc.SetParameterValue("FormNVal", patientInfoValue[8]);

            uriStoolFormDoc.SetParameterValue("MacroColor",values[0]);
            uriStoolFormDoc.SetParameterValue("MacroTransparency", values[1]);
            uriStoolFormDoc.SetParameterValue("Leukocyte", values[2]);
            uriStoolFormDoc.SetParameterValue("Nitrite", values[3]);
            uriStoolFormDoc.SetParameterValue("Urobilinogen", values[4]);
            uriStoolFormDoc.SetParameterValue("Protein", values[5]);
            uriStoolFormDoc.SetParameterValue("PH", values[6]);
            uriStoolFormDoc.SetParameterValue("Blood", values[7]);
            uriStoolFormDoc.SetParameterValue("SpecificGravity", values[8]);
            uriStoolFormDoc.SetParameterValue("Ketone", values[9]);
            uriStoolFormDoc.SetParameterValue("Bilirubin", values[10]);
            uriStoolFormDoc.SetParameterValue("Glucose", values[11]);
            uriStoolFormDoc.SetParameterValue("MicroEpithelial", values[12]);
            uriStoolFormDoc.SetParameterValue("MucousThreads", values[13]);
            uriStoolFormDoc.SetParameterValue("AmorphousMaterial", values[14]);
            uriStoolFormDoc.SetParameterValue("PusCells", values[15]);
            uriStoolFormDoc.SetParameterValue("rbcU", values[16]);
            uriStoolFormDoc.SetParameterValue("bacteria", values[17]);
            uriStoolFormDoc.SetParameterValue("color", values[18]);
            uriStoolFormDoc.SetParameterValue("consistency", values[19]);
            uriStoolFormDoc.SetParameterValue("pus", values[20]);
            uriStoolFormDoc.SetParameterValue("rbcS", values[21]);
            uriStoolFormDoc.SetParameterValue("others", values[22]);



            crystalReportViewer1.ReportSource = uriStoolFormDoc;
            crystalReportViewer1.Refresh();
        }
    }
}
