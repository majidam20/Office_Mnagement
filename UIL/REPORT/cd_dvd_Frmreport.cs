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
    public partial class cd_dvd_Frmreport : Form
    {
        public ReportDocument rd = new ReportDocument();
        public cd_dvd_Frmreport()
        {
            InitializeComponent();
        }

        private void cd_dvd_Frmreport_Load(object sender, EventArgs e)
        {
            //ReportDocument rd = new ReportDocument();
            //DataTable dt = new DataTable();
            //cd_dvdclass cc = new cd_dvdclass();
            //dt = cc.Search();
            
            crystalReportViewer1.ReportSource = rd;
            crystalReportViewer1.Show();
        }
    }
}