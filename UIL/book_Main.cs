using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class book_Main : Form
    {
        public int SearchFlag = 0;
        public book_Main()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            book f = new book();
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
            if (((bool)(dt.Rows[0]["book"])) == true)
            Reload();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            UIL.book f = new UIL.book();
            f.FormClosed+=new FormClosedEventHandler(f_FormClosed);
            f.MdiParent = this.ParentForm;
            f.mode = type_mode.mode.edit;

            bookclass bc = new bookclass();
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
                f.txtid.Enabled = false;
                dt = bc.Search(id);


                if (dt.Rows.Count > 0)
                {
                    f.txtid.Text = dt.Rows[0]["id"].ToString();
                    f.txttitle.Text = dt.Rows[0]["title"].ToString();
                    f.txtname_writer.Text = dt.Rows[0]["writer_name"].ToString();
                    f.txtname_adverties.Text = dt.Rows[0]["adverties_name"].ToString();
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

        private void btndel_Click(object sender, EventArgs e)
        {
            bookclass bc = new bookclass();
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
                dt = bc.Search(id);
                if (dt.Rows.Count > 0)
                {
                    bool bailmented = (bool)dt.Rows[0]["bailmented"];
                    if (bailmented == false)
                    {
                        DialogResult dr;
                        dr = MessageBox.Show("آیا سطر انتخاب شده حذف گردد؟", "حذف سطر", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            bc.Delete(id);
                            Reload();

                        }
                        if (dr == DialogResult.No)
                        {
                            dataGridView1.Focus();
                        }
                    }//end bailmented
                    else
                    {
                        MessageBox.Show("!زیرااین کتاب در امانت است", "حذف امکان پذیر نیست");
                    }
                    return;
                }//end count
                else
                {
                    MessageBox.Show("چنین سطری وجود ندارد");
                }
            }//end cr
        }

        public void Main_book_Load(object sender, EventArgs e)
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

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            if (cbselect_part.Text == "")
            {
                MessageBox.Show("!لطفا نام بخش را انتخاب نمایید");
                cbselect_part.Focus();
                return;
            }

            bookclass bc = new bookclass();
            DataTable dt = new DataTable();
            if (cbselect_part.Text == "همه بخش ها")
            {
                dt = bc.Search_grid1();
                dataGridView1.DataSource = dt;
                SearchFlag = 0;
                return;
            }

            dt = bc.Search_grid(cbselect_part.Text);
            dataGridView1.DataSource = dt;
            SearchFlag = 0;

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            bookclass bc = new bookclass();
            DataTable dt = new DataTable();
            UIL.book f = new UIL.book();
            f.MdiParent = this.ParentForm;
            f.mode = type_mode.mode.view;

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
                dt = bc.Search(id);

                if (dt.Rows.Count > 0)
                {
                    f.txtid.Text = dt.Rows[0]["id"].ToString();
                    f.txttitle.Text = dt.Rows[0]["title"].ToString();
                    f.txtname_writer.Text = dt.Rows[0]["writer_name"].ToString();
                    f.txtname_adverties.Text = dt.Rows[0]["adverties_name"].ToString();
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
                return;


            bookclass bc = new bookclass();
            DataTable dt = new DataTable();
            global g = new global();

            int cr = dataGridView1.CurrentRow.Index;

            if (cr >= 0)
            {
                string id = dataGridView1[0, cr].Value.ToString();
                dt = bc.Search(id);

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

        private void chall_CheckedChanged(object sender, EventArgs e)
        {

            if (chall.Checked)
            {
                chpart_name.Checked = true;
                chid.Checked = true;
                chtitle.Checked = true;
                chwriter_name.Checked = true;
                chadverties_name.Checked = true;
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
                chwriter_name.Checked = false;
                chadverties_name.Checked = false;
                chplace.Checked = false;
                chdescribe.Checked = false;
                chall.Checked = false;
                return;
            }
        }

        private void txtsearch_TextChanged_1(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsearh_Click(object sender, EventArgs e)
        {
            if (chpart_name.Checked ||
                chid.Checked ||
                chtitle.Checked ||
                chwriter_name.Checked ||
                chadverties_name.Checked ||
                chplace.Checked ||
                chdescribe.Checked)
            {
                SearchFlag = 1;
                bookclass bc = new bookclass();
                dataGridView1.DataSource = bc.book_search(txtsearch.Text, cbselect_part.Text, chid.Checked,
                chtitle.Checked, chwriter_name.Checked, chpart_name.Checked,
                chadverties_name.Checked, chplace.Checked, chdescribe.Checked);
                return;
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
            bookclass bc = new bookclass();
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

                dt = bc.Search(id);

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

        private void btnprint_Click(object sender, EventArgs e)
        {
            REPORT.book_Frmreport f = new e_archive.UIL.REPORT.book_Frmreport();

            f.rd.Load(Application.StartupPath + "\\Crystal Reports\\book_Report.rpt");
            f.rd.SetDataSource(dataGridView1.DataSource);

            f.Show();
        }

        private void book_Main_KeyDown(object sender, KeyEventArgs e)
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
                btnrefresh_Click(null, null);
            }
            else if (SearchFlag == 1)
            {
                btnrefresh_Click(null, null);
            }
        }

        private void btnrefresh_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            label18.Text = "تعداد سطر :" + dataGridView1.Rows.Count.ToString();   
        }


    }
}