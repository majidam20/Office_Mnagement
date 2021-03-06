using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class album_Main : Form
    {
        public int SearchFlag=0;
        public album_Main()
        {
            InitializeComponent();

        }


        private void btnview_Click(object sender, EventArgs e)
        {
            albumclass ac = new albumclass();
            DataTable dt = new DataTable();
            UIL.album f = new UIL.album();
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

                dt = ac.Search(id);

                if (dt.Rows.Count > 0)
                {

                    f.txtid.Text = dt.Rows[0]["id"].ToString();
                    f.txtonvan.Text = dt.Rows[0]["title"].ToString();
                    f.txtmantaghe.Text = dt.Rows[0]["zone"].ToString();
                    f.cbnoe.Text = dt.Rows[0]["type"].ToString();
                    f.txtghete.Text = dt.Rows[0]["part"].ToString();
                    f.txtmasahat_tozihat.Text = dt.Rows[0]["area_describe"].ToString();
                    f.txtnam_taiekonande.Text = dt.Rows[0]["provider_name"].ToString();

                    f.txtyear.Text = dt.Rows[0]["provide_year"].ToString().Substring(0, 4);
                    f.txtmonth.Text = dt.Rows[0]["provide_year"].ToString().Substring(5, 2);
                    f.txtday.Text = dt.Rows[0]["provide_year"].ToString().Substring(8, 2);

                    f.txtmahale_negahdari.Text = dt.Rows[0]["place_keeping"].ToString();
                    f.txtsaere_tozihat.Text = dt.Rows[0]["others_describetions"].ToString();

                    f.MdiParent = this.ParentForm;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("!این سطر حذف شده است، لطفا از دکمه بازآوری استفاده نمایید");
                }

            }

        }

        public void bbtnrefresh_Click(object sender, EventArgs e)
        {
            if (cbselect_part.Text == "")
            {
                MessageBox.Show("!لطفا نام بخش را انتخاب نمایید");
                cbselect_part.Focus();
                return;
            }

            albumclass ac = new albumclass();
            DataTable dt = new DataTable();

            if (cbselect_part.Text == "همه بخش ها")
            {
                dt = ac.Search_grid1();
                dataGridView1.DataSource = dt;

                SearchFlag = 0;
                return;
            }

            dt = ac.Search_grid(cbselect_part.Text);
            dataGridView1.DataSource = dt;
            SearchFlag = 0;


        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            UIL.album f = new UIL.album();
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
            if (((bool)(dt.Rows[0]["album"])) == true)            
            Reload();
        }

        private void btnedit_Click_1(object sender, EventArgs e)
        {
            UIL.album f = new UIL.album();
            f.FormClosed+=new FormClosedEventHandler(f_FormClosed);
            f.mode = type_mode.mode.edit;

            albumclass ac = new albumclass();
            DataTable dt = new DataTable();

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

                dt = ac.Search(id);

                if (dt.Rows.Count > 0)
                {
                    f.txtid.Text = dt.Rows[0]["id"].ToString();
                    f.txtonvan.Text = dt.Rows[0]["title"].ToString();
                    f.txtmantaghe.Text = dt.Rows[0]["zone"].ToString();
                    f.cbnoe.Text = dt.Rows[0]["type"].ToString();
                    f.txtghete.Text = dt.Rows[0]["part"].ToString();
                    f.txtmasahat_tozihat.Text = dt.Rows[0]["area_describe"].ToString();
                    f.txtnam_taiekonande.Text = dt.Rows[0]["provider_name"].ToString();

                    f.txtyear.Text = dt.Rows[0]["provide_year"].ToString().Substring(0, 4);
                    f.txtmonth.Text = dt.Rows[0]["provide_year"].ToString().Substring(5, 2);
                    f.txtday.Text = dt.Rows[0]["provide_year"].ToString().Substring(8, 2);

                    f.txtmahale_negahdari.Text = dt.Rows[0]["place_keeping"].ToString();
                    f.txtsaere_tozihat.Text = dt.Rows[0]["others_describetions"].ToString();

                    f.MdiParent = this.ParentForm;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("!این سطر حذف شده است، لطفا از دکمه بازآوری استفاده نمایید");
                }

            }
            

        }

        private void btndel_Click_1(object sender, EventArgs e)
        {
            albumclass ac = new albumclass();
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
                dt = ac.Search(id);
                if (dt.Rows.Count > 0)
                {
                    bool bailmented = (bool)dt.Rows[0]["bailmented"];
                    if (bailmented == false)
                    {

                        DialogResult dr;
                        dr = MessageBox.Show("آیا سطر انتخاب شده حذف گردد؟", "حذف سطر", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            ac.Delete(id);
                            Reload();
                        }
                        if (dr == DialogResult.No)
                        {

                            dataGridView1.Focus();
                        }
                    }//end bailmented
                    else
                    {
                        MessageBox.Show("!زیرااین آلبوم در امانت است", "حذف امکان پذیر نیست");
                    }
                    return;
                }//end count
                else
                {
                    MessageBox.Show("چنین سطری وجود ندارد");
                }
            }//end cr
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
                return;
            //    if dataGridView1.CurrentRow.Index
            albumclass ac = new albumclass();
            DataTable dt = new DataTable();
            global g = new global();


            int cr = dataGridView1.CurrentRow.Index;

            if (cr >= 0)
            {
                string id = dataGridView1[0, cr].Value.ToString();
                dt = ac.Search(id);

                if (dt.Rows.Count > 0)
                {
                    string name = dt.Rows[0]["part_name_fk"].ToString();

                    usersclass uc = new usersclass();


                    string name_admin = dt.Rows[0]["part_name_fk"].ToString();

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

        private void album_Main_Load(object sender, EventArgs e)
        {

            partsclass pc = new partsclass();
            DataTable dt = new DataTable();
            dt = pc.Search();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbselect_part.Items.Add(dt.Rows[i]["part_name"].ToString());
            }
            cbselect_part.Items.Add("همه بخش ها");
            global g = new global(); cbselect_part.SelectedIndex = cbselect_part.FindString(g.get_part_name_fk());


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnsearch_Click(null, null);
        }



        //ssssssssssssseeeeeeeeeeeeeeeaaaaaaaaaaaaaaaaaarrrrrrrrrrrrrrccccccccccchhhhhhhhhh

        private void btnsearch_Click(object sender, EventArgs e)
        {

            if (cbselect_part.Text == "")
            {
                MessageBox.Show("!لطفا نام بخش را انتخاب نمایید");
                cbselect_part.Focus();
                return;
            }


            if (chpart_name.Checked ||
                chid.Checked ||
                chtitle.Checked ||
                chzone.Checked ||
                chtype.Checked ||
                chpart.Checked ||
                charea.Checked ||
                chprovider_name.Checked ||
                chplace.Checked ||
                chdescribe.Checked ||

                chdate.Checked)
            {
                SearchFlag = 1;
                albumclass ac = new albumclass();

                dataGridView1.DataSource = ac.album_search(txtsearch.Text, cbselect_part.Text, txtyear.Text + "/" + txtmonth.Text + "/" + txtday.Text,
                txtyear_1.Text + "/" + txtmonth_1.Text + "/" + txtday_1.Text, chdate.Checked,
                chid.Checked, chtitle.Checked, chpart_name.Checked,
                chzone.Checked, chtype.Checked, chpart.Checked, charea.Checked,
                chprovider_name.Checked, chplace.Checked,
                chdescribe.Checked);

                //dataGridView1.Columns[0].Width = 10;

                return;


            }
            else
            {
                MessageBox.Show("!لطفا محل جستجو را انتخاب نمایید");
            }




            //if (rddar_date.Checked)
            //{
            //    dataGridView1.DataSource = ac.album_Search_date(txtday.Text + txtmonth.Text + txtyear.Text);
            //}

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

        private void chall_CheckedChanged(object sender, EventArgs e)
        {
            if (chall.Checked)
            {
                chpart_name.Checked = true;
                chid.Checked = true;
                chtitle.Checked = true;
                chzone.Checked = true;
                chtype.Checked = true;
                chpart.Checked = true;
                charea.Checked = true;
                chprovider_name.Checked = true;
                chplace.Checked = true;
                chdescribe.Checked = true;
                chall.Checked = true;
                return;
            }
            else
            {
                chpart_name.Checked = false;
                chid.Checked = false;
                chtitle.Checked = false;
                chzone.Checked = false;
                chtype.Checked = false;
                chpart.Checked = false;
                charea.Checked = false;
                chprovider_name.Checked = false;
                chplace.Checked = false;
                chdescribe.Checked = false;
                chall.Checked = false;
                return;
            }
        }



        private void btnselect_id_bail_Click(object sender, EventArgs e)
        {
            albumclass ac = new albumclass();
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

                dt = ac.Search(id);

                if (dt.Rows.Count > 0)
                {
                    string name = dt.Rows[0]["title"].ToString();
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chdate_TextChanged(object sender, EventArgs e)
        {

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

        private void txtday_TextChanged(object sender, EventArgs e)
        {

        }

        //eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeevvvvvveeeeeeeeeeee

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
            if ((txtyear.Text.Length > 0) && (Convert.ToInt32(txtyear.Text) < 1300))
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

        private void chzone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            REPORT.album_Frmreport f = new e_archive.UIL.REPORT.album_Frmreport();

            f.rd.Load(Application.StartupPath + "\\Crystal Reports\\album_Report.rpt");
            f.rd.SetDataSource(dataGridView1.DataSource);

            f.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void album_Main_KeyPress(object sender, KeyPressEventArgs e)
        {

            //e.Handled = true;
            //int i = e.KeyChar;
            //this.Text = i.ToString();

            //if (e.KeyChar == (char)Keys.F5)
            //{
            //    albumclass ac = new albumclass();
            //    DataTable dt = new DataTable();

            //    dt = ac.Search_grid1();
            //    dataGridView1.DataSource = dt;
            //}
        }

        private void album_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode) == Keys.F5)
            {
                Reload();
            }
        }

        private void Reload()
        {
            if (SearchFlag == 0)
            {
                bbtnrefresh_Click(null, null);
            }
            else if (SearchFlag == 1)
            {
                btnsearch_Click(null, null);
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {           
            label10.Text = "تعداد سطر :" + dataGridView1.Rows.Count.ToString();   
        }

        private void label_Count_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataMemberChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {
          
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
            
        }

       

    }
}
    





