using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
namespace e_archive.UIL.REPORT
{
    public partial class book_Frmreport : Form
    {
        public ReportDocument rd= new ReportDocument();
        public book_Frmreport()
        {
            InitializeComponent();
        }

        private void book_Frmreport_Load(object sender, EventArgs e)
        {
             //rd
            //DataTable dt = new DataTable();
            //bookclass bc = new bookclass();
            //dt = bc.Search();
            
            crystalReportViewer1.ReportSource = rd;
            crystalReportViewer1.Show();

        }
    }
}