using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SouthJLAInformationSystemC
{
    public partial class PrintPreviewForm : Form
    {
        private readonly string[] values,patientInfoValue, vMin, vMax, vUnits;
        public PrintPreviewForm(string[] values, string[] patientInfoValue, string[] vMin, string[] vMax, string[] vUnits)
        {
            InitializeComponent();
            this.patientInfoValue = patientInfoValue;
            this.values = values;
            this.vMin = vMin;
            this.vMax = vMax;
            this.vUnits = vUnits;
            //Ultimate Cheat para sa image nung resource!:
            //Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug\\","\\Resources\\Signature"));
        }

        private void PrintPreviewForm_Load(object sender, EventArgs e)
        {
            /*if (patientInfoValue[0] == "CBCForm")
                CBCFormPreview();
            else if (patientInfoValue[0] == "UrinStoolForm")
                UrinStoolFormPreview();
            else if (patientInfoValue[0] == "XrayForm")
                XrayFormPreview();
            else if (patientInfoValue[0] == "ECGForm")
                ECGFormPreview();
            else if (patientInfoValue[0] == "FBSCholeForm")
                FBSChloreFormPreview();
            else if (patientInfoValue[0] == "MedExamForm")
                MedExamFormPreview();
            else
                MessageBox.Show("Work in Progress");*/
            this.TestReportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            this.TestReportViewer.RefreshReport();
        }

        /*private void CBCFormPreview()
        {
            CBCFormDoc cBCFormDoc = new CBCFormDoc();
            cBCFormDoc.SetParameterValue("IDVal", patientInfoValue[1]);
            cBCFormDoc.SetParameterValue("FullNameVal", patientInfoValue[2] + " ," + patientInfoValue[3] + " " + patientInfoValue[4] + ".");
            cBCFormDoc.SetParameterValue("AgeVal", patientInfoValue[5]);
            cBCFormDoc.SetParameterValue("GenderVal", patientInfoValue[6]);
            cBCFormDoc.SetParameterValue("CivilVal", patientInfoValue[7]);
            cBCFormDoc.SetParameterValue("PackageVal", patientInfoValue[8]);
            cBCFormDoc.SetParameterValue("CompanyVal", patientInfoValue[9]);
            cBCFormDoc.SetParameterValue("AccountVal", patientInfoValue[10]);
            cBCFormDoc.SetParameterValue("DateVal", patientInfoValue[11]);
            cBCFormDoc.SetParameterValue("FormNVal", patientInfoValue[12]);
            
            cBCFormDoc.SetParameterValue("WBCVal", values[0]);
            cBCFormDoc.SetParameterValue("RBCVal", values[1]);
            cBCFormDoc.SetParameterValue("HGBVal", values[2]);
            cBCFormDoc.SetParameterValue("HCTVal", values[3]);
            cBCFormDoc.SetParameterValue("PLATELETVal", values[4]);
            cBCFormDoc.SetParameterValue("NEUTROPHILVal", values[5]);
            cBCFormDoc.SetParameterValue("LYMPHOCYTESVal", values[6]);
            cBCFormDoc.SetParameterValue("MONOCYTEVal", values[7]);

            cBCFormDoc.SetParameterValue("WBCUnit", vUnits[0]);
            cBCFormDoc.SetParameterValue("RBCUnit", vUnits[1]);
            cBCFormDoc.SetParameterValue("HGBUnit", vUnits[2]);
            cBCFormDoc.SetParameterValue("HCTUnit", vUnits[3]);
            cBCFormDoc.SetParameterValue("PLATELETUnit", vUnits[4]);
            cBCFormDoc.SetParameterValue("NEUTROPHILUnit", vUnits[5]);
            cBCFormDoc.SetParameterValue("LYMPHOCYTESUnit", vUnits[6]);
            cBCFormDoc.SetParameterValue("MONOCYTEUnit", vUnits[7]);

            cBCFormDoc.SetParameterValue("WBCMin", vMin[0]);
            cBCFormDoc.SetParameterValue("RBCMin", vMin[1]);
            cBCFormDoc.SetParameterValue("HGBMin", vMin[2]);
            cBCFormDoc.SetParameterValue("HCTMin", vMin[3]);
            cBCFormDoc.SetParameterValue("PLATELETMin", vMin[4]);
            cBCFormDoc.SetParameterValue("NEUTROPHILMin", vMin[5]);
            cBCFormDoc.SetParameterValue("LYMPHOCYTESMin", vMin[6]);
            cBCFormDoc.SetParameterValue("MONOCYTEMin", vMin[7]);

            cBCFormDoc.SetParameterValue("WBCMax", vMax[0]);
            cBCFormDoc.SetParameterValue("RBCMax", vMax[1]);
            cBCFormDoc.SetParameterValue("HGBMax", vMax[2]);
            cBCFormDoc.SetParameterValue("HCTMax", vMax[3]);
            cBCFormDoc.SetParameterValue("PLATELETMax", vMax[4]);
            cBCFormDoc.SetParameterValue("NEUTROPHILMax", vMax[5]);
            cBCFormDoc.SetParameterValue("LYMPHOCYTESMax", vMax[6]);
            cBCFormDoc.SetParameterValue("MONOCYTEMax", vMax[7]);

            cBCFormDoc.SetParameterValue("WBCRange", "(" + vMin[0] + " - " + vMax[0] + ")");
            cBCFormDoc.SetParameterValue("RBCRange", "(" + vMin[1] + " - " + vMax[1] + ")");
            cBCFormDoc.SetParameterValue("HGBRange", "(" + vMin[2] + " - " + vMax[2] + ")");
            cBCFormDoc.SetParameterValue("HCTRange", "(" + vMin[3] + " - " + vMax[3] + ")");
            cBCFormDoc.SetParameterValue("PLATELETRange", "(" + vMin[4] + " - " + vMax[4] + ")");
            cBCFormDoc.SetParameterValue("NEUTROPHILRange", "(" + vMin[5] + " - " + vMax[5] + ")");
            cBCFormDoc.SetParameterValue("LYMPHOCYTESRange", "(" + vMin[6] + " - " + vMax[6] + ")");
            cBCFormDoc.SetParameterValue("MONOCYTERange", "(" + vMin[7] + " - " + vMax[7] + ")");


            InternalPrintViewer.ReportSource = cBCFormDoc;
            InternalPrintViewer.Refresh();
        }

        private void UrinStoolFormPreview()
        {
            UrinStoolFormDoc uriStoolFormDoc = new UrinStoolFormDoc();
            uriStoolFormDoc.SetParameterValue("IDVal", patientInfoValue[1]);
            uriStoolFormDoc.SetParameterValue("FullNameVal", patientInfoValue[2] + " ," + patientInfoValue[3] + " " + patientInfoValue[4] + ".");
            uriStoolFormDoc.SetParameterValue("AgeVal", patientInfoValue[5]);
            uriStoolFormDoc.SetParameterValue("GenderVal", patientInfoValue[6]);
            uriStoolFormDoc.SetParameterValue("CivilVal", patientInfoValue[7]);
            uriStoolFormDoc.SetParameterValue("PackageVal", patientInfoValue[8]);
            uriStoolFormDoc.SetParameterValue("CompanyVal", patientInfoValue[9]);
            uriStoolFormDoc.SetParameterValue("AccountVal", patientInfoValue[10]);
            uriStoolFormDoc.SetParameterValue("DateVal", patientInfoValue[11]);
            uriStoolFormDoc.SetParameterValue("FormNVal", patientInfoValue[12]);

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

            uriStoolFormDoc.SetParameterValue("LeukocyteRange", vUnits[0]);
            uriStoolFormDoc.SetParameterValue("NitriteRange", vUnits[1]);
            uriStoolFormDoc.SetParameterValue("UrobilinogenRange", vUnits[2]);
            uriStoolFormDoc.SetParameterValue("ProteinRange", vUnits[3]);
            uriStoolFormDoc.SetParameterValue("BloodRange", vUnits[4]);
            uriStoolFormDoc.SetParameterValue("KetoneRange", vUnits[5]);
            uriStoolFormDoc.SetParameterValue("BilirubinRange", vUnits[6]);
            uriStoolFormDoc.SetParameterValue("GlucoseRange", vUnits[7]);
            uriStoolFormDoc.SetParameterValue("PusCellsRange", vUnits[8]);
            uriStoolFormDoc.SetParameterValue("rbcURange", vUnits[9]);

            InternalPrintViewer.ReportSource = uriStoolFormDoc;
            InternalPrintViewer.Refresh();
        }
        private void XrayFormPreview()
        {
            XrayFormDoc xrayFormDoc = new XrayFormDoc();
            xrayFormDoc.SetParameterValue("IDVal", patientInfoValue[1]);
            xrayFormDoc.SetParameterValue("FullNameVal", patientInfoValue[2] + " ," + patientInfoValue[3] + " " + patientInfoValue[4] + ".");
            xrayFormDoc.SetParameterValue("AgeVal", patientInfoValue[5]);
            xrayFormDoc.SetParameterValue("GenderVal", patientInfoValue[6]);
            xrayFormDoc.SetParameterValue("CivilVal", patientInfoValue[7]);
            xrayFormDoc.SetParameterValue("PackageVal", patientInfoValue[8]);
            xrayFormDoc.SetParameterValue("CompanyVal", patientInfoValue[9]);
            xrayFormDoc.SetParameterValue("AccountVal", patientInfoValue[10]);
            xrayFormDoc.SetParameterValue("DateVal", patientInfoValue[11]);
            xrayFormDoc.SetParameterValue("FormNVal", patientInfoValue[12]);

            xrayFormDoc.SetParameterValue("viewPA", values[0]);
            xrayFormDoc.SetParameterValue("impression", values[1]);

            InternalPrintViewer.ReportSource = xrayFormDoc;
            InternalPrintViewer.Refresh();
        }

        private void ECGFormPreview()
        {
            ECGFormDoc eCGFormDoc = new ECGFormDoc();
            eCGFormDoc.SetParameterValue("IDVal", patientInfoValue[1]);
            eCGFormDoc.SetParameterValue("FullNameVal", patientInfoValue[2] + " ," + patientInfoValue[3] + " " + patientInfoValue[4] + ".");
            eCGFormDoc.SetParameterValue("AgeVal", patientInfoValue[5]);
            eCGFormDoc.SetParameterValue("GenderVal", patientInfoValue[6]);
            eCGFormDoc.SetParameterValue("CivilVal", patientInfoValue[7]);
            eCGFormDoc.SetParameterValue("PackageVal", patientInfoValue[8]);
            eCGFormDoc.SetParameterValue("CompanyVal", patientInfoValue[9]);
            eCGFormDoc.SetParameterValue("AccountVal", patientInfoValue[10]);
            eCGFormDoc.SetParameterValue("DateVal", patientInfoValue[11]);
            eCGFormDoc.SetParameterValue("FormNVal", patientInfoValue[12]);

            eCGFormDoc.SetParameterValue("impression", values[0]);

            InternalPrintViewer.ReportSource = eCGFormDoc;
            InternalPrintViewer.Refresh();
        }

        private void FBSChloreFormPreview()
        {
            FBSCholeFormDoc fBSCholeFormDoc = new FBSCholeFormDoc();
            fBSCholeFormDoc.SetParameterValue("IDVal", patientInfoValue[1]);
            fBSCholeFormDoc.SetParameterValue("FullNameVal", patientInfoValue[2] + " ," + patientInfoValue[3] + " " + patientInfoValue[4] + ".");
            fBSCholeFormDoc.SetParameterValue("AgeVal", patientInfoValue[5]);
            fBSCholeFormDoc.SetParameterValue("GenderVal", patientInfoValue[6]);
            fBSCholeFormDoc.SetParameterValue("CivilVal", patientInfoValue[7]);
            fBSCholeFormDoc.SetParameterValue("PackageVal", patientInfoValue[8]);
            fBSCholeFormDoc.SetParameterValue("CompanyVal", patientInfoValue[9]);
            fBSCholeFormDoc.SetParameterValue("AccountVal", patientInfoValue[10]);
            fBSCholeFormDoc.SetParameterValue("DateVal", patientInfoValue[11]);
            fBSCholeFormDoc.SetParameterValue("FormNVal", patientInfoValue[12]);

            fBSCholeFormDoc.SetParameterValue("fbsUnit", vUnits[0]);
            fBSCholeFormDoc.SetParameterValue("totalCholesterolUnit", vUnits[1]);

            fBSCholeFormDoc.SetParameterValue("fbs", values[0]);
            fBSCholeFormDoc.SetParameterValue("totalCholesterol", values[1]);

            fBSCholeFormDoc.SetParameterValue("fbsMin", vMin[0]);
            fBSCholeFormDoc.SetParameterValue("fbsMax", vMax[0]);
            fBSCholeFormDoc.SetParameterValue("totalCholesterolMin", vMin[1]);
            fBSCholeFormDoc.SetParameterValue("totalCholesterolMax", vMax[1]);

            fBSCholeFormDoc.SetParameterValue("fbsRange", "(" + vMin[0] + " - " + vMax[0] + ")");
            fBSCholeFormDoc.SetParameterValue("totalCholesterolRange", "(" + vMin[1] + " - " + vMax[1] + ")");

            InternalPrintViewer.ReportSource = fBSCholeFormDoc;
            InternalPrintViewer.Refresh();
        }

        private void MedExamFormPreview()
        {
            MedExamFormDoc medExamFormDoc = new MedExamFormDoc();
            medExamFormDoc.SetParameterValue("IDVal", patientInfoValue[1]);
            medExamFormDoc.SetParameterValue("FullNameVal", patientInfoValue[2] + " ," + patientInfoValue[3] + " " + patientInfoValue[4] + ".");
            medExamFormDoc.SetParameterValue("AgeVal", patientInfoValue[5]);
            medExamFormDoc.SetParameterValue("GenderVal", patientInfoValue[6]);
            medExamFormDoc.SetParameterValue("CivilVal", patientInfoValue[7]);
            medExamFormDoc.SetParameterValue("PackageVal", patientInfoValue[8]);
            medExamFormDoc.SetParameterValue("CompanyVal", patientInfoValue[9]);
            medExamFormDoc.SetParameterValue("AccountVal", patientInfoValue[10]);
            medExamFormDoc.SetParameterValue("DateVal", patientInfoValue[11]);
            medExamFormDoc.SetParameterValue("FormNVal", patientInfoValue[12]);

            medExamFormDoc.SetParameterValue("child", values[1]);
            medExamFormDoc.SetParameterValue("past", values[2]);
            medExamFormDoc.SetParameterValue("present1", values[3]);
            medExamFormDoc.SetParameterValue("present2", values[4]);
            medExamFormDoc.SetParameterValue("surgeries", values[5]);
            medExamFormDoc.SetParameterValue("hospitalizations", values[6]);
            medExamFormDoc.SetParameterValue("smoke", values[7]);
            medExamFormDoc.SetParameterValue("alcohol", values[8]);
            medExamFormDoc.SetParameterValue("mens", values[9]);
            medExamFormDoc.SetParameterValue("lasting", values[10]);
            medExamFormDoc.SetParameterValue("others", values[11]);
            medExamFormDoc.SetParameterValue("eyes", values[12]);
            medExamFormDoc.SetParameterValue("mouth", values[13]);
            medExamFormDoc.SetParameterValue("cardio", values[14]);
            medExamFormDoc.SetParameterValue("respiratory", values[15]);
            medExamFormDoc.SetParameterValue("gastro", values[16]);
            medExamFormDoc.SetParameterValue("genitourinary", values[17]);
            medExamFormDoc.SetParameterValue("muskoskeleta", values[18]);
            medExamFormDoc.SetParameterValue("skin", values[19]);
            medExamFormDoc.SetParameterValue("neurological", values[20]);
            medExamFormDoc.SetParameterValue("endocrine", values[21]);
            medExamFormDoc.SetParameterValue("hema", values[22]);
            medExamFormDoc.SetParameterValue("others2", values[23]);
            medExamFormDoc.SetParameterValue("height", values[24]);
            medExamFormDoc.SetParameterValue("bp", values[25]);
            medExamFormDoc.SetParameterValue("weight", values[26]);
            medExamFormDoc.SetParameterValue("pr", values[27]);
            medExamFormDoc.SetParameterValue("pmi", values[28]);
            medExamFormDoc.SetParameterValue("rr", values[29]);
            medExamFormDoc.SetParameterValue("rightE", values[30]);
            medExamFormDoc.SetParameterValue("leftE", values[31]);
            medExamFormDoc.SetParameterValue("general", values[32]);
            medExamFormDoc.SetParameterValue("reviewSkin", values[33]);
            medExamFormDoc.SetParameterValue("headNeck", values[34]);
            medExamFormDoc.SetParameterValue("EEN", values[35]);
            medExamFormDoc.SetParameterValue("mouthThroat", values[36]);
            medExamFormDoc.SetParameterValue("chestLungs", values[37]);
            medExamFormDoc.SetParameterValue("breast", values[38]);
            medExamFormDoc.SetParameterValue("back", values[39]);
            medExamFormDoc.SetParameterValue("heartReview", values[40]);
            medExamFormDoc.SetParameterValue("abdomen", values[41]);
            medExamFormDoc.SetParameterValue("extremities", values[42]);
            medExamFormDoc.SetParameterValue("neurologicalReview", values[43]);
            medExamFormDoc.SetParameterValue("rectal", values[44]);
            medExamFormDoc.SetParameterValue("genitalia", values[45]);
            medExamFormDoc.SetParameterValue("impression", values[46]);
            medExamFormDoc.SetParameterValue("recommendations", values[47]);
            medExamFormDoc.SetParameterValue("physician", values[48]);

            for (int i = 0; i < values[0].Length; i++)
            {
                medExamFormDoc.SetParameterValue("yn" + (i + 1).ToString(), CheckBinary(i)) ;
            }

            InternalPrintViewer.ReportSource = medExamFormDoc;
            InternalPrintViewer.Refresh();
        }

        private string CheckBinary(int i)
        {
            if (values[0][i] == '1')
                return "Y";
            else if (values[0][i] == '0')
                return "N";
            else
                return ""; 
        }*/

    }
}
