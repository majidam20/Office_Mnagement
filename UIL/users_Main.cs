using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class users_Main : Form
    {
        public int SearchFlag=0;
        public users_Main()
        {
            InitializeComponent();
        }

               
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            usersclass uc = new usersclass();
            DataTable dt = new DataTable();
            dt = uc.Search_grid();
            dataGridView1.DataSource = dt;
            SearchFlag = 0;
        }

        private void users_Main_Load(object sender, EventArgs e)
        {

        }

        private void btnnew_Click_1(object sender, EventArgs e)
        {
            UIL.user f = new UIL.user();
            f.FormClosed += new FormClosedEventHandler(f_FormClosed);
            f.MdiParent = this.ParentForm;
            f.mode = type_mode.mode.insert;
            f.Show();
        }

        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataTable dt = new DataTable();
            ReloadMode rm = new ReloadMode();
            dt = rm.Search();
            if (((bool)(dt.Rows[0]["users"])) == true)
            Reload();
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
                chname.Checked = true;
                chfamily.Checked = true;
                chid.Checked = true;
            }
            else
            {
                chpart_name.Checked = false;
                chname.Checked = false;
                chfamily.Checked = false;
                chid.Checked = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {

            usersclass uc = new usersclass();
            DataTable dt = new DataTable();
            UIL.user f = new UIL.user();
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

                string id = dataGridView1[3, cr].Value.ToString();

                dt = uc.Search(id);

                if (dt.Rows.Count > 0)
                {
                    f.txtname.Text = dt.Rows[0]["name"].ToString();
                    f.txtfamily.Text = dt.Rows[0]["family"].ToString();
                    f.txtuid.Text = dt.Rows[0]["uid"].ToString();
                    f.txtupass.Text = dt.Rows[0]["upass"].ToString();
                   // f.cbpartname.Text = dt.Rows[0]["part_name_fk"].ToString();
                 f.part_name_fk = dt.Rows[0]["part_name_fk"].ToString();
                    f.MdiParent = this.ParentForm;
                    f.Show();
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            usersclass uc = new usersclass();
            DataTable dt = new DataTable();
            UIL.user f = new UIL.user();
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
                
                string id = dataGridView1[3, cr].Value.ToString();

                dt = uc.Search(id);

                if (dt.Rows.Count > 0)
                {
                    f.txtname.Text = dt.Rows[0]["name"].ToString();
                    f.txtfamily.Text = dt.Rows[0]["family"].ToString();
                    f.txtuid.Text = dt.Rows[0]["uid"].ToString();
                    f.txtupass.Text = dt.Rows[0]["upass"].ToString();
            //        f.cbpartname.Text = dt.Rows[0]["part_name_fk"].ToString();
                    f.part_name_fk = dt.Rows[0]["part_name_fk"].ToString();      
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
            usersclass uc = new usersclass();

            if ((dataGridView1.Rows.Count == 0) || (dataGridView1.CurrentRow.Index == -1))
            {
                MessageBox.Show("سطری انتخاب نشده است");
                return;
            }
            int cr = dataGridView1.CurrentRow.Index;
            if (cr >= 0)
            {

                string id = dataGridView1[3, cr].Value.ToString();
                DialogResult dr;
                dr = MessageBox.Show("آیا سطر انتخاب شده حذف گردد؟", "حذف سطر", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    uc.Delete(id);
                    Reload();
                }
                if (dr == DialogResult.No)
                {
                    dataGridView1.Focus();
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
                return;

                      
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if(chpart_name.Checked||
                chname.Checked||
                chfamily.Checked||
                chid.Checked)
            {
                SearchFlag = 1;
            usersclass uc = new usersclass();
            dataGridView1.DataSource = uc.users_search(txtsearch.Text,chname.Checked,
            chfamily.Checked,chpart_name.Checked, chid.Checked);
            }
            else
            {
                MessageBox.Show("!لطفا محل جستجو را انتخاب نمایید");
            }
            }

        private void users_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.F5 == e.KeyCode)
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
            if (SearchFlag == 1)
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