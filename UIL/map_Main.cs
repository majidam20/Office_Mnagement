using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class map_Main : Form
    {
        public int Search_Flag = 0;
        public map_Main()
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

            mapclass mc = new mapclass();
            DataTable dt = new DataTable();

            if (cbselect_part.Text == "همه بخش ها")
            {
                dt = mc.Search_grid1();
                dataGridView1.DataSource = dt;
                Search_Flag = 0;
                return;
            }

            dt = mc.Search_grid(cbselect_part.Text);
            dataGridView1.DataSource = dt;
            Search_Flag = 0;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            map f = new map();
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
            if (((bool)(dt.Rows[0]["map"])) == true)
            Reload();   
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            mapclass mc = new mapclass();
            DataTable dt = new DataTable();
            map f = new map();
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
                dt = mc.Search(id);

                if (dt.Rows.Count > 0)
                {

                    f.txtid.Text = dt.Rows[0]["id"].ToString();
                    f.txtproject.Text = dt.Rows[0]["project"].ToString();
                    f.txtsize.Text = dt.Rows[0]["size"].ToString();
                    f.txtadviser.Text = dt.Rows[0]["adviser"].ToString();
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
            mapclass mc = new mapclass();
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
                dt = mc.Search(id);
                if (dt.Rows.Count > 0)
                {
                    bool bailmented = (bool)dt.Rows[0]["bailmented"];
                    if (bailmented == false)
                    {
                
                DialogResult dr;
                dr = MessageBox.Show("آیا سطر انتخاب شده حذف گردد؟", "حذف سطر", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    mc.Delete(id);
                    Reload();
                }
                if (dr == DialogResult.No)
                {
                    dataGridView1.Focus();
                }
            }//end bailmented
            else
            {
                MessageBox.Show("!زیرااین نقشه در امانت است", "حذف امکان پذیر نیست");
            }
            return;
        }//end count
        else
        {
            MessageBox.Show("چنین سطری وجود ندارد");
        }
    }//end cr
}


        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void map_Main_Load(object sender, EventArgs e)
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

        private void btnview_Click(object sender, EventArgs e)
        {
            mapclass mc = new mapclass();
            DataTable dt = new DataTable();
            map f = new map();
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
                dt = mc.Search(id);

                if (dt.Rows.Count > 0)
                {
                    f.txtid.Text = dt.Rows[0]["id"].ToString();
                    f.txtproject.Text = dt.Rows[0]["project"].ToString();
                    f.txtsize.Text = dt.Rows[0]["size"].ToString();
                    f.txtadviser.Text = dt.Rows[0]["adviser"].ToString();
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


            mapclass mc = new mapclass();
            DataTable dt = new DataTable();
            global g = new global();


            int cr = dataGridView1.CurrentRow.Index;

            if (cr >= 0)
            {
                string id = dataGridView1[0, cr].Value.ToString();
                dt = mc.Search(id);

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

        private void chadviser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void chall_CursorChanged(object sender, EventArgs e)
        {
           
            }

        private void chall_CheckedChanged(object sender, EventArgs e)
        {
            if (chall.Checked)
            {
                chpart_name.Checked = true;
                chid.Checked = true;
                chproject.Checked = true;
                chsize.Checked = true;
                chadviser.Checked = true;
                
                chplace.Checked = true;
                chdescribe.Checked = true;
                chall.Checked = true;
                return;
            }
            else
            {
                chpart_name.Checked = false;
                chid.Checked = false;
                chproject.Checked = false;
                chsize.Checked = false;
                chadviser.Checked = false;
                chplace.Checked = false;
                chdescribe.Checked = false;
                chall.Checked = false;
                return;
        }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
              if(chpart_name.Checked||
                chid.Checked ||
                chproject.Checked ||
                chsize.Checked ||
                chadviser.Checked||
                
                chplace.Checked ||
                chdescribe.Checked)
              {
                  Search_Flag = 1;
            mapclass mc = new mapclass();
            dataGridView1.DataSource = mc.map_search(txtsearch.Text,cbselect_part.Text, chid.Checked,
            chproject.Checked, chsize.Checked,chpart_name.Checked, chadviser.Checked, chplace.Checked, chdescribe.Checked);
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
            mapclass mc = new mapclass();
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

                dt = mc.Search(id);

                if (dt.Rows.Count > 0)
                {
                    string name = dt.Rows[0]["project"].ToString();
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            label18.Text = "تعداد سطر :" + dataGridView1.Rows.Count.ToString();   
        }

        private void map_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Reload();
            }
        }
        private void Reload()
        {
            if (Search_Flag == 0)
            {
                btnrefresh_Click(null, null);
            }
            else if (Search_Flag == 1)
            {
                btnrefresh_Click(null, null);
            }
        }

    }
}