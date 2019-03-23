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
    
    public partial class album_Frmreport : Form
    {

        public ReportDocument rd = new ReportDocument();        
        public album_Frmreport()
        {
            InitializeComponent();
        }

        private void album_Frmreport_Load(object sender, EventArgs e)
        {                        
            //rd.SetDataSource(ac.Search());
            crystalReportViewer1.ReportSource = rd;
            crystalReportViewer1.Show();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}