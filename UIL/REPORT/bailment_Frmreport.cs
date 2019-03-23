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
    public partial class bailment_Frmreport : Form
    {
        public ReportDocument rd = new ReportDocument();
        public bailment_Frmreport()
        {
            InitializeComponent();
        }

        private void bailment_Frmreport_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = rd;
            crystalReportViewer1.Show();

        }
    }
}