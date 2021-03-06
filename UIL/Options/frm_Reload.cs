using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL.Options
{
    public partial class frm_Reload : Form
    {
        public frm_Reload()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frm_Reload_Load(object sender, EventArgs e)
        {
            ReloadMode rm = new ReloadMode();
            DataTable dt = new DataTable();
            dt = rm.Search();

            chalbum.Checked = (bool)dt.Rows[0]["album"];
            chbook.Checked = (bool)dt.Rows[0]["book"];
            chloh11.Checked = (bool)dt.Rows[0]["cd_dvd"];
            chmagazine.Checked = (bool)dt.Rows[0]["magazine"];
            chreport.Checked = (bool)dt.Rows[0]["report"];
            chrepotery.Checked = (bool)dt.Rows[0]["repertory"];
            chmap.Checked = (bool)dt.Rows[0]["map"];

            chrezumeh.Checked = (bool)dt.Rows[0]["resume"];
            chzuncan.Checked = (bool)dt.Rows[0]["zuncan"];
            chcontention.Checked = (bool)dt.Rows[0]["convention"];

            checkBox1.Checked = (bool)dt.Rows[0]["users"];
            checkBox2.Checked = (bool)dt.Rows[0]["parts"];
 
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            ReloadMode rm = new ReloadMode();
            rm.Edit(chalbum.Checked, chbook.Checked, chloh11.Checked, chmagazine.Checked, chreport.Checked, chrepotery.Checked, chmap.Checked, chrezumeh.Checked, chzuncan.Checked, chcontention.Checked, checkBox1.Checked,checkBox2.Checked);
            MessageBox.Show("!ویرایش انجام شد ");
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}