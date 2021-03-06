using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class repertory_Main : Form
    {
        public int SearchFlag = 0;//0=reload,1=search
        public repertory_Main()
        {
            InitializeComponent();
        }


        private void btnedit_Click(object sender, EventArgs e)
        {
            repertoryclass rec = new repertoryclass();
            DataTable dt = new DataTable();
            UIL.repertory f = new UIL.repertory();
            f.FormClosed += new FormClosedEventHandler(f_FormClosed);
            f.mode = type_mode.mode.edit;



            if ((dataGridView1.Rows.Count == 0) || (dataGridView1.CurrentRow.Index == -1))
            {
                MessageBox.Show("سطری انتخاب نشده است");
                return;
            }
            //eeeeeeeee
            int cr = dataGridView1.CurrentRow.Index;
            if (cr >= 0)
            {
                f.txtid.Enabled = false;
                string id = dataGridView1[0, cr].Value.ToString();

                dt = rec.Search(id);
                if (dt.Rows.Count > 0)
                {
                    f.txtid.Text = dt.Rows[0]["id"].ToString();
                    f.txtsubject.Text = dt.Rows[0]["subject"].ToString();
                    f.txtprovider.Text = dt.Rows[0]["provider_company"].ToString();

                    f.txtyear.Text = dt.Rows[0]["year_into_atelier"].ToString().Substring(0, 4);
                    f.txtmonth.Text = dt.Rows[0]["year_into_atelier"].ToString().Substring(5, 2);
                    f.txtday.Text = dt.Rows[0]["year_into_atelier"].ToString().Substring(8, 2);


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
        private void btnrefresh_Click(object sender, EventArgs e)
        {

            if (cbselect_part.Text == "")
            {
                MessageBox.Show("!لطفا نام بخش را انتخاب نمایید");
                cbselect_part.Focus();
                
                return;
            }

            repertoryclass rec = new repertoryclass();
            DataTable dt = new DataTable();

            if (cbselect_part.Text == "همه بخش ها")
            {
                dt = rec.Search_grid1();
                dataGridView1.DataSource = dt;
                SearchFlag = 0;
                return;
            }

            dt = rec.Search_grid(cbselect_part.Text);
            dataGridView1.DataSource = dt;
            SearchFlag = 0;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            repertoryclass rec = new repertoryclass();
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
                dt = rec.Search(id);
                if (dt.Rows.Count > 0)
                {
                    bool bailmented = (bool)dt.Rows[0]["bailmented"];
                    if (bailmented == false)
                    {
                DialogResult dr;
                dr = MessageBox.Show("آیا سطر انتخاب شده حذف گردد؟", "حذف سطر", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    rec.Delete(id);
                    Reload(); 
                }
                if (dr == DialogResult.No)
                {
                    dataGridView1.Focus();
                }
            }//end bailmented
            else
            {
                MessageBox.Show("!زیرااین کاتالوگ در امانت است", "حذف امکان پذیر نیست");
            }
            return;
        }//end count
        else
        {
            MessageBox.Show("چنین سطری وجود ندارد");
        }
    }//end cr
}


        private void repertory_Main_Load(object sender, EventArgs e)
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            repertory f = new repertory();
            f.FormClosed += new FormClosedEventHandler(f_FormClosed);
            f.mode = type_mode.mode.insert;
            f.MdiParent = this.ParentForm;
            f.Show();
            
        }

        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataTable dt = new DataTable();
            ReloadMode rm = new ReloadMode();
            dt = rm.Search();
            if (((bool)(dt.Rows[0]["repertory"])) == true)
            Reload();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            repertoryclass rec = new repertoryclass();
            DataTable dt = new DataTable();
            UIL.repertory f = new UIL.repertory();
            f.mode = type_mode.mode.view;



            if ((dataGridView1.Rows.Count == 0) || (dataGridView1.CurrentRow.Index == -1))
            {
                MessageBox.Show("سطری انتخاب نشده است");
                return;
            }
            //eeeeeeeee
            int cr = dataGridView1.CurrentRow.Index;
            if (cr >= 0)
            {
                f.btnsave.Enabled = false;
                string id = dataGridView1[0, cr].Value.ToString();

                dt = rec.Search(id);
                if (dt.Rows.Count > 0)
                {
                    f.txtid.Text = dt.Rows[0]["id"].ToString();
                    f.txtsubject.Text = dt.Rows[0]["subject"].ToString();
                    f.txtprovider.Text = dt.Rows[0]["provider_company"].ToString();


                    f.txtyear.Text = dt.Rows[0]["year_into_atelier"].ToString().Substring(0, 4);
                    f.txtmonth.Text = dt.Rows[0]["year_into_atelier"].ToString().Substring(5, 2);
                    f.txtday.Text = dt.Rows[0]["year_into_atelier"].ToString().Substring(8, 2);


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
            /////////////////////////////////newshow
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
                return;


            repertoryclass rc = new repertoryclass();
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

        private void chall_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chall.Checked)
            {
                chpart_name.Checked = true;
                chid.Checked = true;
                chsubject.Checked = true;
                chprovider_company.Checked = true;
                
                chplace.Checked = true;
                chdescribe.Checked = true;
                chall.Checked = true;
                return;
            }
            else
            {
                chpart_name.Checked = false;
                chid.Checked = false;
                chsubject.Checked = false;
                chprovider_company.Checked = false;
                chplace.Checked = false;
                chdescribe.Checked = false;
                chall.Checked = false;
                return;
        }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (chpart_name.Checked ||
                chid.Checked ||
                chsubject.Checked ||
                chprovider_company.Checked ||

                chplace.Checked ||
                chdescribe.Checked ||
                chdate.Checked)
            {
                SearchFlag = 1;
                repertoryclass rc = new repertoryclass();
                dataGridView1.DataSource = rc.repertory_search(txtsearch.Text, cbselect_part.Text, txtyear.Text + "/" + txtmonth.Text + "/" + txtday.Text,
                txtyear_1.Text + "/" + txtmonth_1.Text + "/" + txtday_1.Text, chdate.Checked,
               chid.Checked, chsubject.Checked, chprovider_company.Checked, chpart_name.Checked, chplace.Checked, chdescribe.Checked);
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
            repertoryclass rc= new repertoryclass();
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
                    string name = dt.Rows[0]["subject"].ToString();
                    g.set_CodeClipBoard_name(name);
                    g.set_CodeClipBoard(id);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("!این سطر حذف شده است، لطفا از دکمه بازآوری استفاده نمایید");
                }

            }
        }
        private void txtday_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtmonth.Focus();

        }
        private void txtmonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtyear.Focus();

        }


        private void txtyear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtday_1.Focus();
        }

        private void txtday_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;

            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;

        }


        private void txtmonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;

            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;
        }

        private void txtyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;

            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;
        }

        //1111111111111111111111111111111111111111111111


        private void txtday_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtmonth_1.Focus();

        }
        private void txtmonth_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtyear_1.Focus();

        }


        private void txtyear_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnsearch.Focus();
        }

        private void txtday_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;

            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;

        }


        private void txtmonth_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;

            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;
        }

        private void txtyear_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;

            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;
        }


        //lllllllllllllleeeeeeeeeeeeeeeeeeevvvvvvvvv
        private void txtday_Leave(object sender, EventArgs e)
        {

            txtday.Text = string.Format("{0,2:G}", txtday.Text);
            txtday.Text = txtday.Text.Replace(" ", "0");
            if ((bool)(Convert.ToInt32(txtday.Text) > 31) || (bool)(Convert.ToInt32(txtday.Text) == 00))
            {
                MessageBox.Show("!لطفا عدد مربوط به روز را تصحیح نمایید ");
                txtday.Focus();
                return;
            }

        }

        private void txtmonth_Leave(object sender, EventArgs e)
        {
            txtmonth.Text = string.Format("{0,2:G}", txtmonth.Text);
            txtmonth.Text = txtmonth.Text.Replace(" ", "0");
            if ((bool)(Convert.ToInt32(txtmonth.Text) > 12) || (bool)(Convert.ToInt32(txtmonth.Text) == 00))
            {
                MessageBox.Show("!لطفا عدد مربوط به ماه را تصحیح نمایید ");
                txtmonth.Focus();
                return;
            }

        }

        private void txtyear_Leave(object sender, EventArgs e)
        {
if((txtyear.Text.Length > 0)&&(Convert.ToInt32(txtyear.Text) < 1300))
            {
                MessageBox.Show("!لطفا عدد مربوط به سال را تصحیح نمایید ");
                txtyear.Focus();
                return;
            }

        }


        //11lllllllllllllliiiiiiiiiivvvvvvvv


        private void txtday_1_Leave(object sender, EventArgs e)
        {

            txtday_1.Text = string.Format("{0,2:G}", txtday_1.Text);
            txtday_1.Text = txtday_1.Text.Replace(" ", "0");
            if ((bool)(Convert.ToInt32(txtday_1.Text) > 31) || (bool)(Convert.ToInt32(txtday_1.Text) == 00))
            {
                MessageBox.Show("!لطفا عدد مربوط به روز را تصحیح نمایید ");
                txtday_1.Focus();
                return;
            }

        }

        private void txtmonth_1_Leave(object sender, EventArgs e)
        {
            txtmonth_1.Text = string.Format("{0,2:G}", txtmonth_1.Text);
            txtmonth_1.Text = txtmonth_1.Text.Replace(" ", "0");
            if ((bool)(Convert.ToInt32(txtmonth_1.Text) > 12) || (bool)(Convert.ToInt32(txtmonth_1.Text) == 00))
            {
                MessageBox.Show("!لطفا عدد مربوط به ماه را تصحیح نمایید ");
                txtmonth_1.Focus();
                return;
            }

        }

        private void txtyear_1_Leave(object sender, EventArgs e)
        {
            if ((txtyear_1.Text.Length > 0) && (Convert.ToInt32(txtyear_1.Text) < 1300))
            {
                MessageBox.Show("!لطفا عدد مربوط به سال را تصحیح نمایید ");
                txtyear_1.Focus();
                return;
            }

        }

        private void chdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chdate.Checked)
            {
                btnsearch.Enabled = true;
                txtday.Enabled = true;
                txtmonth.Enabled = true;
                txtyear.Enabled = true;

                txtday_1.Enabled = true;
                txtmonth_1.Enabled = true;
                txtyear_1.Enabled = true;
                return;
            }
            else
            {
                btnsearch.Enabled = false;
                txtday.Enabled = false;
                txtmonth.Enabled = false;
                txtyear.Enabled = false;

                txtday_1.Enabled = false;
                txtmonth_1.Enabled = false;
                txtyear_1.Enabled = false;
                return;
            }
        }

        private void repertory_Main_Leave(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void repertory_Main_KeyDown(object sender, KeyEventArgs e)
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