using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class resume_Main : Form
    {
        public int SearchFlag = 0;//0=reload,1=search
        public resume_Main()
        {
            InitializeComponent();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            if (cbselect_part.Text == "")
            {
                MessageBox.Show("!لطفا نام بخش را انتخاب نمایید");
                cbselect_part.Focus();
                return;
            }

            resumeclass rc = new resumeclass();
            DataTable dt = new DataTable();

            if (cbselect_part.Text == "همه بخش ها")
            {
                dt = rc.Search_grid1();
                dataGridView1.DataSource = dt;
                SearchFlag = 0;
                return;
            }

            dt = rc.Search_grid(cbselect_part.Text);
            dataGridView1.DataSource = dt;
            SearchFlag = 0;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            resume f = new resume();
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
            if (((bool)(dt.Rows[0]["resume"])) == true)
            Reload();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            resumeclass rc = new resumeclass();   
            DataTable dt = new DataTable();
            resume f = new resume();
            f.FormClosed+=new FormClosedEventHandler(f_FormClosed);
            f.mode = type_mode.mode.edit;

            if ((dataGridView1.Rows.Count == 0) || (dataGridView1.CurrentRow.Index == -1))
            {
                MessageBox.Show("سطری انتخاب نشده است");
                return;
            }

            int cr = dataGridView1.CurrentRow.Index;
            if (cr >= 0)
            {

                string id = dataGridView1[0, cr].Value.ToString();
                f.txtid.Enabled = false;
                dt = rc.Search(id);
                if (dt.Rows.Count > 0)
                {
                    f.txtid.Text = dt.Rows[0]["id"].ToString();
                    f.txtname.Text = dt.Rows[0]["applicant_name"].ToString();
                    f.txttype.Text = dt.Rows[0]["action_type"].ToString();
                    f.txtplace.Text = dt.Rows[0]["place_keeping"].ToString();
                    f.txtdescribe.Text = dt.Rows[0]["others_describetions"].ToString();

                    f.MdiParent = this.ParentForm;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("!این سطر حذف شده است، لطفا از دکمه بازآوری استفاده نمایید");
                }

            }
                    }

        private void btndel_Click(object sender, EventArgs e)
        {
            resumeclass rc = new resumeclass();
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
                dt=rc.Search(id);
                if (dt.Rows.Count > 0)
                {
                    bool bailmented = (bool)dt.Rows[0]["bailmented"];
                    if (bailmented == false)
                    {
                DialogResult dr;
                dr = MessageBox.Show("آیا سطر انتخاب شده حذف گردد؟", "حذف سطر", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    rc.Delete(id);
                    Reload();

                }
                if (dr == DialogResult.No)
                {
                    dataGridView1.Focus();
                }
            }//end bailmented
            else
            {
                MessageBox.Show("!زیرااین رزومه در امانت است", "حذف امکان پذیر نیست");
            }
            return;
        }//end count
        else
        {
            MessageBox.Show("چنین سطری وجود ندارد");
        }
    }//end cr
}


        private void resume_Main_Load(object sender, EventArgs e)
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            resumeclass rc = new resumeclass();
            DataTable dt = new DataTable();
            resume f = new resume();
            f.mode = type_mode.mode.view;

            if ((dataGridView1.Rows.Count == 0) || (dataGridView1.CurrentRow.Index == -1))
            {
                MessageBox.Show("سطری انتخاب نشده است");
                return;
            }

            int cr = dataGridView1.CurrentRow.Index;
            if (cr >= 0)
            {

                string id = dataGridView1[0, cr].Value.ToString();
                f.btnsave.Enabled = false;
                dt = rc.Search(id);
                if (dt.Rows.Count > 0)
                {

                    f.txtid.Text = dt.Rows[0]["id"].ToString();
                    f.txtname.Text = dt.Rows[0]["applicant_name"].ToString();
                    f.txttype.Text = dt.Rows[0]["action_type"].ToString();
                    f.txtplace.Text = dt.Rows[0]["place_keeping"].ToString();
                    f.txtdescribe.Text = dt.Rows[0]["others_describetions"].ToString();

                    f.MdiParent = this.ParentForm;
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


            resumeclass rc = new resumeclass();
            DataTable dt = new DataTable();
            global g = new global();


            int cr = dataGridView1.CurrentRow.Index;

            if (cr >= 0)
            {
                string id = dataGridView1[0, cr].Value.ToString();
                dt = rc.Search(id);

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chall_CheckedChanged(object sender, EventArgs e)
        {
            if (chall.Checked)
            {
                chpart_name.Checked = true;
                chid.Checked = true;
                chapplicant_name.Checked = true;
                chaction_type.Checked = true;
               
              
                chplace.Checked = true;
                chdescribe.Checked = true;
                chall.Checked = true;
                return;
            }
            else
            {
                chpart_name.Checked = false;
                chid.Checked = false;
                chapplicant_name.Checked = false;
                chaction_type.Checked = false;
               
                chplace.Checked = false;
                chdescribe.Checked = false;
                chall.Checked = false;
                return;
            }
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
            if( chpart_name.Checked||
                chid.Checked||
                chapplicant_name.Checked||
                chaction_type.Checked||
               
              
                chplace.Checked||
                chdescribe.Checked)
            {
                SearchFlag = 1;
            resumeclass rc = new resumeclass();
            dataGridView1.DataSource = rc.resume_search(txtsearch.Text,cbselect_part.Text, chid.Checked,chpart_name.Checked,
            chapplicant_name.Checked, chaction_type.Checked, chplace.Checked, chdescribe.Checked);
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
            resumeclass rc = new resumeclass();
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

                dt = rc.Search(id);

                if (dt.Rows.Count > 0)
                {
                    string name = dt.Rows[0]["action_type"].ToString();
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

        private void resume_Main_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode) == Keys.F5)
            {
                Reload();
            }
        }//

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

                   
    }
}