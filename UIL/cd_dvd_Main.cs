using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class cd_dvd_Main : Form
    {
        public int SearchFlag = 0;//0=reload,1=search
        public cd_dvd_Main()
        {
            InitializeComponent();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            cd_dvdclass c_d_c = new cd_dvdclass();
            DataTable dt = new DataTable();
            if ((dataGridView1.Rows.Count == 0) || (dataGridView1.CurrentRow.Index == -1))
            {
                MessageBox.Show("سطری انتخاب نشده است");
                return;
            }
            int cr = dataGridView1.CurrentRow.Index;

            if (cr >= 0)
            {
                string id = dataGridView1[0, cr].Value.ToString();
                dt = c_d_c.Search(id);
                if (dt.Rows.Count > 0)
                {
                    bool bailmented = (bool)dt.Rows[0]["bailmented"];
                    if (bailmented == false)
                    {
                
                DialogResult dr;
                dr = MessageBox.Show("آیا سطر انتخاب شده حذف گردد؟", "حذف سطر", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    c_d_c.Delete(id);
                    Reload(); 

                }
                if (dr == DialogResult.No)
                {
                    dataGridView1.Focus();
                }
            }//end bailmented
            else
            {
                MessageBox.Show("!زیرااین لوح فشرده در امانت است", "حذف امکان پذیر نیست");
            }
            return;
        }//end count
        else
        {
            MessageBox.Show("چنین سطری وجود ندارد");
        }
    }//end cr
}


        private void btnsave_Click(object sender, EventArgs e)
        {
            cd_dvd f = new cd_dvd();
            f.mode = type_mode.mode.insert;
            f.FormClosed += new FormClosedEventHandler(f_FormClosed);
            f.MdiParent = this.ParentForm;
            f.Show();

        }

        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataTable dt = new DataTable();
            ReloadMode rm = new ReloadMode();
            dt = rm.Search();
            if (((bool)(dt.Rows[0]["cd_dvd"])) == true)
            Reload();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            UIL.cd_dvd f = new UIL.cd_dvd();
            f.mode = type_mode.mode.edit;
            f.FormClosed+=new FormClosedEventHandler(f_FormClosed);
            f.MdiParent = this.ParentForm;
            

            cd_dvdclass c_d_c = new cd_dvdclass();
            DataTable dt = new DataTable();

            if ((dataGridView1.Rows.Count == 0) || (dataGridView1.CurrentRow.Index == -1))
            {
                MessageBox.Show("سطری انتخاب نشده است");
                return;
            }

            int cr = dataGridView1.CurrentRow.Index;
            if (cr >= 0)
            {
                
                f.txtid.Enabled = false;
                string id = dataGridView1[0, cr].Value.ToString();
                dt = c_d_c.Search(id);

                if (dt.Rows.Count > 0)
                {
                    f.txtid.Text = dt.Rows[0]["id"].ToString();
                    f.ch_cd.Checked = (bool)dt.Rows[0]["type_cd"];
                    f.ch_dvd.Checked = (bool)dt.Rows[0]["type_dvd"];
                    f.txttitle.Text = dt.Rows[0]["title_in_tablet"].ToString();
                    f.txtplace.Text = dt.Rows[0]["place_keeping"].ToString();
                    f.txtdescribe.Text = dt.Rows[0]["others_describetions"].ToString();

                    f.Show();
                }
                else
                {
                    MessageBox.Show("!این سطر حذف شده است، لطفا از دکمه بازآوری استفاده نمایید");
                }
                
            }
        }

        private void Main_cd_dvd_Load(object sender, EventArgs e)
        {

            partsclass pc = new partsclass();
            DataTable dt = new DataTable();
            dt = pc.Search();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbselect_part.Items.Add(dt.Rows[i]["part_name"].ToString());
            }
            cbselect_part.Items.Add("همه بخش ها");
            global g = new global();cbselect_part.SelectedIndex = cbselect_part.FindString(g.get_part_name_fk());
        }            

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            if (cbselect_part.Text == "")
            {
                MessageBox.Show("!لطفا نام بخش را انتخاب نمایید");
                cbselect_part.Focus();
                return;
            }

            cd_dvdclass c_d_c = new cd_dvdclass();
            DataTable dt = new DataTable();

            if (cbselect_part.Text == "همه بخش ها")
            {
                dt = c_d_c.Search_grid1();
                dataGridView1.DataSource = dt;
                SearchFlag = 0;
                return;
            }

            dt = c_d_c.Search_grid(cbselect_part.Text);
            dataGridView1.DataSource = dt;
            SearchFlag = 0;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            UIL.cd_dvd f = new UIL.cd_dvd();
            f.mode = type_mode.mode.view;
            f.MdiParent = this.ParentForm;
           

            cd_dvdclass c_d_c = new cd_dvdclass();
            DataTable dt = new DataTable();

            if ((dataGridView1.Rows.Count == 0) || (dataGridView1.CurrentRow.Index == -1))
            {
                MessageBox.Show("سطری انتخاب نشده است");
                return;
            }
            int cr = dataGridView1.CurrentRow.Index;
            if (cr >= 0)
            {

                f.btnsave.Enabled = false;
                string id = dataGridView1[0, cr].Value.ToString();
                dt = c_d_c.Search(id);

                if (dt.Rows.Count > 0)
                {
                    f.txtid.Text = dt.Rows[0]["id"].ToString();
                    f.ch_cd.Checked = (bool)dt.Rows[0]["type_cd"];
                    f.ch_dvd.Checked = (bool)dt.Rows[0]["type_dvd"];
                    f.txttitle.Text = dt.Rows[0]["title_in_tablet"].ToString();
                    f.txtplace.Text = dt.Rows[0]["place_keeping"].ToString();
                    f.txtdescribe.Text = dt.Rows[0]["others_describetions"].ToString();

                    f.Show();

                }
                else
                {
                    MessageBox.Show("!این سطر حذف شده است، لطفا از دکمه بازآوری استفاده نمایید");
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
                return;


            cd_dvdclass cd_c = new cd_dvdclass();
            DataTable dt = new DataTable();
            global g = new global();


            int cr = dataGridView1.CurrentRow.Index;

            if (cr >= 0)
            {
                string id = dataGridView1[0, cr].Value.ToString();
                dt = cd_c.Search(id);

                if (dt.Rows.Count > 0)
                {
                    string name = dt.Rows[0]["part_name_fk"].ToString();

                    if (name == g.get_part_name_fk() || g.get_IsAdmin())
                    {
                        btnedit.Enabled = true;
                        btndel.Enabled = true;
                        btnselect_id_bail.Enabled = true;
                        return;
                    }
                    else
                    {
                        btnedit.Enabled = false;
                        btndel.Enabled = false;
                        btnselect_id_bail.Enabled = false;

                        return;
                    }
                }

            }
        }

        private void chdescribe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chall_CheckedChanged(object sender, EventArgs e)
        {
            if (chall.Checked)
            {
                chpart_name.Checked = true;
                chid.Checked = true;
                chcd.Checked = true;
                chdvd.Checked = true;
                chtitle.Checked = true;
                
                chplace.Checked = true;
                chdescribe.Checked = true;
                //chall.Checked = true;
                return;
            }
            else
            {
                chpart_name.Checked = false;
                chid.Checked = false;
                chcd.Checked = false;
                chdvd.Checked = false;
                chtitle.Checked = false;
                chplace.Checked = false;
                chdescribe.Checked = false;
               // chall.Checked = false;
                return;
            }
        }

        private void btnsearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text.Length > 0)
            {
                btnsearch.Enabled = true;
            }
            else
            {
                btnsearch.Enabled = false;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if(chpart_name.Checked ||
                chid.Checked ||
                chcd.Checked ||
                chdvd.Checked ||
                chtitle.Checked || 
                
                chplace.Checked ||
                chdescribe.Checked)
            {
                SearchFlag = 1;
            cd_dvdclass cc = new cd_dvdclass();
            dataGridView1.DataSource = cc.cd_dvd_search(txtsearch.Text,cbselect_part.Text, chid.Checked, chcd.Checked,
            chdvd.Checked, chpart_name.Checked,chtitle.Checked, chplace.Checked, chdescribe.Checked);
            }

            else
            {
                MessageBox.Show("!لطفا محل جستجو را انتخاب نمایید");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnselect_id_bail_Click(object sender, EventArgs e)
        {
            cd_dvdclass cc = new cd_dvdclass();
            DataTable dt = new DataTable();
            global g = new global();



            if ((dataGridView1.Rows.Count == 0) || (dataGridView1.CurrentRow.Index == -1))
            {
                MessageBox.Show("سطری انتخاب نشده است");
                return;
            }
            //eeeeeeeee
            int cr = dataGridView1.CurrentRow.Index;
            if (cr >= 0)
            {
                string id = dataGridView1[0, cr].Value.ToString();

                dt = cc.Search(id);

                if (dt.Rows.Count > 0)
                {
                    g.set_CodeClipBoard_name("بدون نام");
                    g.set_CodeClipBoard(id);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("!این سطر حذف شده است، لطفا از دکمه بازآوری استفاده نمایید");
                }

            }
        }

        private void chcd_CheckedChanged(object sender, EventArgs e)
        {
            if (chcd.Checked)
            {
                btnsearch.Enabled = true;
            }
            else if (!(chcd.Checked) && txtsearch.Text == "")
            {
                btnsearch.Enabled = false;
            }
        }

        private void chdvd_CheckedChanged(object sender, EventArgs e)
        {
            if (chdvd.Checked)
            {
                btnsearch.Enabled = true;
            }
            else if (!(chdvd.Checked)&& txtsearch.Text=="")
            {
                btnsearch.Enabled = false;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            REPORT.cd_dvd_Frmreport f = new e_archive.UIL.REPORT.cd_dvd_Frmreport();

            f.rd.Load(Application.StartupPath + "\\Crystal Reports\\cd_dvd_Report.rpt");
            f.rd.SetDataSource(dataGridView1.DataSource);


            f.Show();
        }

        private void cd_dvd_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.F5))
            {
                Reload();
            }
        }

        private void Reload()
        {
            if (SearchFlag == 0)
            {
             btnrefresh_Click(null, null);
            }
            else if (SearchFlag == 1)
            {
                btnsearch_Click(null, null);
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            label18.Text = "تعداد سطر :" + dataGridView1.Rows.Count.ToString();     
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

       
    }
}