using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class bailment_Main : Form
    {
        public string StrPara = "";
        public int SearchFlag=0;//0=reload,1=search
        
            
        public bailment_Main()
        {
            InitializeComponent();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //if (txtsearch.Text.Length > 0)
            //{
            //    btnsearch.Enabled = true;
            //}
            //else
            //{
            //    btnsearch.Enabled = false;
            //}3/12/1387
        }

        private void chall_CheckedChanged(object sender, EventArgs e)
        {
            if (chall.Checked)
            {
                chpart_name.Checked = true;
                chcode.Checked = true;
                chtype.Checked = true;
                chname_family.Checked = true;
                chname.Checked = true;
                chunit_name.Checked = true;
                chphone.Checked = true;
                chdescribe.Checked = true;
                return;
            }
            else
            {
                chpart_name.Checked = false;
                chcode.Checked = false;
                chtype.Checked = false;
                chname_family.Checked = false;
                chname.Checked = false;
                chunit_name.Checked = false;
                chphone.Checked = false;
                chdescribe.Checked = false;
                return;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbailment_Click(object sender, EventArgs e)
        {
            UIL.bailment f = new bailment();
            f.FormClosed += new FormClosedEventHandler(f_FormClosed);
            
            f.mode = type_mode.mode.insert;
            f.MdiParent = this.ParentForm;
            f.Show();

        }

        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            Reload();
        }
        

        public void bbtnrefresh_Click(object sender, EventArgs e)
        {
            if (cbselect_part.Text == "")
            {
                MessageBox.Show("!لطفا نام بخش را انتخاب نمایید");
                cbselect_part.Focus();
                return;
            }

            bailmentclass bc = new bailmentclass();
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
            bailmentclass bc = new bailmentclass();
            DataTable dt = new DataTable();
            bailment f = new UIL.bailment();
            f.mode = type_mode.mode.view;
           // f.txtcode2.Text = "";
            

            if ((dataGridView1.Rows.Count == 0) || (dataGridView1.CurrentRow.Index == -1))
            {
                MessageBox.Show("سطری انتخاب نشده است");
                return;
            }
            //eeeeeeeee
            int cr = dataGridView1.CurrentRow.Index;
            if (cr >= 0)
            {
                f.btnsearch_id.Visible = false;
                f.btnsave.Enabled = false;
                f.txtcode2.ReadOnly = false;
                f.txtname.ReadOnly = false;

                string id = dataGridView1[0, cr].Value.ToString();
                string name_family = dataGridView1[3, cr].Value.ToString();
                string type = dataGridView1[5, cr].Value.ToString();
                string bailment_date = dataGridView1[6, cr].Value.ToString();
                
                dt = bc.Search(id, name_family, type, bailment_date);
                
                
                if (dt.Rows.Count > 0)
                {
                    StrPara = dt.Rows[0]["type"].ToString();

                    f.txtcode2.Text = dt.Rows[0]["id"].ToString();
                    f.txtname.Text = dt.Rows[0]["name"].ToString();
                   
                    f.txtname_bailment.Text = dt.Rows[0]["name_family"].ToString();
                   
                    f.txtphone.Text = dt.Rows[0]["phone_number"].ToString();
                    f.txtunit_name.Text = dt.Rows[0]["unit_name"].ToString();
                    
                    f.txtyear_t.Text = dt.Rows[0]["bailment_date"].ToString().Substring(0, 4);
                    f.txtmonth_t.Text = dt.Rows[0]["bailment_date"].ToString().Substring(5, 2);
                    f.txtday_t.Text = dt.Rows[0]["bailment_date"].ToString().Substring(8, 2);

                    f.txtyear_e.Text = dt.Rows[0]["ret_date"].ToString().Substring(0, 4);
                    f.txtmonth_e.Text = dt.Rows[0]["ret_date"].ToString().Substring(5, 2);
                    f.txtday_e.Text = dt.Rows[0]["ret_date"].ToString().Substring(8, 2);

                    f.txtdescribe.Text = dt.Rows[0]["others_describetions"].ToString();
                    f.strAA = dt.Rows[0]["type"].ToString();

                    f.MdiParent = this.ParentForm;

                    f.Show();
                }
                else
                {
                    MessageBox.Show("!این سطر حذف شده است، لطفا از دکمه بازآوری استفاده نمایید");
                }

            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            UIL.bailment f = new bailment();
            f.FormClosed += new FormClosedEventHandler(f_FormClosed);
            
            bailmentclass bc = new bailmentclass();
            DataTable dt = new DataTable();
            
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
                //f.btnsearch_id.Visible = false;
                //f.txtcode2.ReadOnly = true;
                //f.cbtype.Enabled = false;


                string id = dataGridView1[0, cr].Value.ToString();
                string name_family = dataGridView1[3, cr].Value.ToString();
                string type = dataGridView1[5, cr].Value.ToString();
                string bailment_date = dataGridView1[6, cr].Value.ToString();

                dt = bc.Search(id, name_family, type, bailment_date);


                if (dt.Rows.Count > 0)
                {
                    bool bailmented = (bool)dt.Rows[0]["bailmented"];
                    if (bailmented)//bail true is editing if false dont editing
                    {

                        f.strAA = dt.Rows[0]["type"].ToString();                        
                        f.txtcode2.Text = dt.Rows[0]["id"].ToString();
                        
                        f.Old_id=dt.Rows[0]["id"].ToString();
                        f.Old_family_name = dt.Rows[0]["name_family"].ToString();
                        f.Old_type = dt.Rows[0]["type"].ToString();
                        f.Old_bailment_date = dt.Rows[0]["bailment_date"].ToString();
                        f.txtname_bailment.Text = dt.Rows[0]["name_family"].ToString();
                        f.txtname.Text = dt.Rows[0]["name"].ToString();
                        f.txtphone.Text = dt.Rows[0]["phone_number"].ToString();
                        f.txtunit_name.Text = dt.Rows[0]["unit_name"].ToString();

                        f.txtyear_t.Text = dt.Rows[0]["bailment_date"].ToString().Substring(0, 4);
                        f.txtmonth_t.Text = dt.Rows[0]["bailment_date"].ToString().Substring(5, 2);
                        f.txtday_t.Text = dt.Rows[0]["bailment_date"].ToString().Substring(8, 2);

                        f.txtyear_e.Text = dt.Rows[0]["ret_date"].ToString().Substring(0, 4);
                        f.txtmonth_e.Text = dt.Rows[0]["ret_date"].ToString().Substring(5, 2);
                        f.txtday_e.Text = dt.Rows[0]["ret_date"].ToString().Substring(8, 2);
                        f.txtdescribe.Text = dt.Rows[0]["others_describetions"].ToString();
                        f.MdiParent = this.ParentForm;
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("!زیرابازگشت شده هاامکان ویرایش ندارند ", "ویرایش امکان پذیر نیست");
                    }
                }
                else
                {
                    MessageBox.Show("!این سطر حذف شده است، لطفا از دکمه بازآوری استفاده نمایید");
                }

            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
           
            DataTable dt = new DataTable();
            bailmentclass bac = new bailmentclass();
            if ((dataGridView1.Rows.Count == 0) || (dataGridView1.CurrentRow.Index == -1))
            {
                MessageBox.Show("سطری انتخاب نشده است");
                return;
            }
            int cr = dataGridView1.CurrentRow.Index;
            if (cr >= 0)
            {
                /////////////////////////equal
                string id = dataGridView1[0, cr].Value.ToString();
                string name_family1 = dataGridView1[3, cr].Value.ToString();
                string type1 = dataGridView1[5, cr].Value.ToString();
                string bailment_date1 = dataGridView1[6, cr].Value.ToString();
               
                dt = bac.Search(id, name_family1, type1, bailment_date1);

                string name_family = dt.Rows[0]["name_family"].ToString();
                string type = dt.Rows[0]["type"].ToString();
                string bailment_date = dt.Rows[0]["bailment_date"].ToString();
                
               

                
                DialogResult dr;
                dr = MessageBox.Show("آیا سطر انتخاب شده حذف گردد؟", "حذف سطر", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if ((dr == DialogResult.Yes) && ((bool)dt.Rows[0]["bailmented"] == true))
                {
                    //album
                    if (type == "آلبوم")
                    {
                        albumclass ac = new albumclass();
                        ///////////////////////////////equal
                        ac.Edit_bailmented(false, id);
                        //return;
                    }

                    //book
                    if (type == "کتاب")
                    {
                        bookclass bc = new bookclass();
                        bc.Edit_bailmented(false, id);
                        //return;
                    }

                    //cd_dvd
                    if (type == "لوح فشرده (CD-DVD)")
                    {
                        cd_dvdclass cc = new cd_dvdclass();
                        cc.Edit_bailmented(false, id);
                    }

                    if (type == "مجله")
                    {
                        magazineclass mc = new magazineclass();
                        mc.Edit_bailmented(false, id);
                    }

                    //report
                    if (type == "گزارش")
                    {
                        reportclass rc = new reportclass();
                        rc.Edit_bailmented(false, id);
                    }


                    //repertory
                    if (type == "کاتالوگ")
                    {
                        repertoryclass rc = new repertoryclass();
                        rc.Edit_bailmented(false, id);
                    }

                    //map
                    if (type == "نقشه")
                    {
                        mapclass mc = new mapclass();
                        mc.Edit_bailmented(false, id);
                    }


                    //resume
                    if (type == "رزومه")
                    {
                        resumeclass rc = new resumeclass();
                        rc.Edit_bailmented(false, id);
                    }

                    //zuncan
                    if (type == "زونکن")
                    {
                        zuncanclass zc = new zuncanclass();
                        zc.Edit_bailmented(false, id);
                    }

                    //convention
                    if (type == "قرارداد")
                    {
                        conventionclass cc = new conventionclass();
                        cc.Edit_bailmented(false, id);
                    }

                   
                    bac.Delete(id, name_family, type, bailment_date);
                    return;
                }
                if (dr == DialogResult.No)
                {
                    dataGridView1.Focus();
                }
                if ((dr == DialogResult.Yes) && ((bool)dt.Rows[0]["bailmented"] == false))
                {
                     
                     bac.Delete(id, name_family, type, bailment_date);
                     Reload();
                     return;
                }

            }
        }

        public void btnsearch_Click(object sender, EventArgs e)
        {
            if (cbselect_part.Text == "")
            {
                MessageBox.Show("!لطفا نام بخش را انتخاب نمایید");
                cbselect_part.Focus();
                return;
            }
            
            if (chpart_name.Checked ||
                chcode.Checked ||
                chtype.Checked ||
                chname_family.Checked ||
                chname.Checked ||
                chunit_name.Checked ||
                chphone.Checked ||
                chdescribe.Checked ||
                chdate.Checked ||
                chdate_ret.Checked ||
                chbail_yes.Checked ||
                chbail_no.Checked ||
                chlate_date.Checked)
            {
                SearchFlag = 1;
                
                string OPword;
                if (comboBox1.Text == "و")
                {
                    OPword = "and";
                }
                else 
                {
                    OPword = "or";
                }
                    bailmentclass bc = new bailmentclass();
                    dataGridView1.DataSource = bc.bailment_search(txtsearch.Text, chbail_yes.Checked, chbail_no.Checked,
                    txtyear.Text + "/" + txtmonth.Text + "/" + txtday.Text,
                    txtyear_1.Text + "/" + txtmonth_1.Text + "/" + txtday_1.Text, chdate.Checked,//ret

                    txtyear_r.Text + "/" + txtmonth_r.Text + "/" + txtday_r.Text,
                    txtyear_r1.Text + "/" + txtmonth_r1.Text + "/" + txtday_r1.Text, chdate_ret.Checked,
                    PersianDateClass.ShamsiDate(), chlate_date.Checked,
                    chcode.Checked, chname_family.Checked, chpart_name.Checked, chtype.Checked, chname.Checked,
                    chunit_name.Checked, chphone.Checked, chdescribe.Checked, OPword,cbselect_part.Text);
                
            }

            
            else
            {
                MessageBox.Show("!لطفا محل جستجو را انتخاب نمایید");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
                return;


            bailmentclass bc = new bailmentclass();
            DataTable dt = new DataTable();
            global g = new global();

            

            int cr = dataGridView1.CurrentRow.Index;

            if (cr >= 0)
            {
               string id = dataGridView1[0, cr].Value.ToString();
                string name_family = dataGridView1[3, cr].Value.ToString();
                string type = dataGridView1[5, cr].Value.ToString();
                string bailment_date = dataGridView1[6, cr].Value.ToString();

                dt = bc.Search(id, name_family, type, bailment_date);
                if (dt.Rows.Count > 0)
                {
                    string name = dt.Rows[0]["part_name_fk"].ToString();

                    if (name == g.get_part_name_fk() || g.get_IsAdmin())
                    {
                        btnedit.Enabled = true;
                        btndel.Enabled = true;
                        btnret.Enabled = true;
                        btnbailment.Enabled = true;
                       // return;
                    }
                    else
                    {
                        btnedit.Enabled = false;
                        btndel.Enabled = false;
                        btnret.Enabled = false;
                        //btnbailment.Enabled = false;
                        //return;
                    }
                    //tahvil
                    
                }

            }
           
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
                if (txtsearch.Text == "")
                { btnsearch.Enabled = false; }

                txtday.Enabled = false;
                txtmonth.Enabled = false;
                txtyear.Enabled = false;

                txtday_1.Enabled = false;
                txtmonth_1.Enabled = false;
                txtyear_1.Enabled = false;
                return;
            }
        }

        private void chdate_ret_CheckedChanged(object sender, EventArgs e)
        {
            if (chdate_ret.Checked)
            {
                
                btnsearch.Enabled = true;
                txtday_r.Enabled = true;
                txtmonth_r.Enabled = true;
                txtyear_r.Enabled = true;

                txtday_r1.Enabled = true;
                txtmonth_r1.Enabled = true;
                txtyear_r1.Enabled = true;
                return;
            }
            else 
            {
                if (txtsearch.Text=="")
                {btnsearch.Enabled = false;}
                
                txtday_r.Enabled = false;
                txtmonth_r.Enabled = false;
                txtyear_r.Enabled = false;

                txtday_r1.Enabled = false;
                txtmonth_r1.Enabled = false;
                txtyear_r1.Enabled = false;
               
            }
        }

        private void bailment_Main_Load(object sender, EventArgs e)
        {
            partsclass pc = new partsclass();
            DataTable dt = new DataTable();
            dt = pc.Search();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbselect_part.Items.Add(dt.Rows[i]["part_name"].ToString());
            }
            
            cbselect_part.Items.Add("همه بخش ها");
            
            global g = new global();            
            cbselect_part.SelectedIndex = cbselect_part.FindString(g.get_part_name_fk());
        }
        
        
        //rrrrrrrrrrrrrrrrrrrrrrrrrrrreeeeeeeeeeeeeeeeeeeeeeeeeeeeeettttttttttt
        private void txtday_r_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtmonth_r.Focus();
        }

        private void txtmonth_r_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtyear_r.Focus();

        }

        private void txtyear_r_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtday_r1.Focus();
        }

        private void txtday_r1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtmonth_r1.Focus();
        }

        private void txtmonth_r1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtyear_r1.Focus();
        }

        private void txtyear_r1_KeyDown(object sender, KeyEventArgs e)
        
        {
            if (e.KeyCode == Keys.Enter)
            btnsearch.Focus();
        }

        private void txtday_r_TextChanged(object sender, EventArgs e)
        {

        }
        //ppppppppppppppppppppppppppppppppppppp

        private void txtday_r_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;

            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;
        }

        private void txtmonth_r_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;

            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;

        }

        private void txtyear_r_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;

            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;
        }

        private void txtday_r1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;

            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;

        }

        private void txtmonth_r1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;

            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;
        }

        private void txtyear_r1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;

            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;

        }

        private void txtday_r_Leave(object sender, EventArgs e)
        {
            txtday_r.Text = string.Format("{0,2:G}", txtday_r.Text);
            txtday_r.Text = txtday_r.Text.Replace(" ", "0");
            if ((bool)(Convert.ToInt32(txtday_r.Text) > 31) || (bool)(Convert.ToInt32(txtday_r.Text) == 00))
            {
                MessageBox.Show("!لطفا عدد مربوط به روز را تصحیح نمایید ");
                txtday_r.Focus();
                return;
            }

        }

        private void txtmonth_r_Leave(object sender, EventArgs e)
        {
            txtmonth_r.Text = string.Format("{0,2:G}", txtmonth_r.Text);
            txtmonth_r.Text = txtmonth_r.Text.Replace(" ", "0");
            if ((bool)(Convert.ToInt32(txtmonth_r.Text) > 12) || (bool)(Convert.ToInt32(txtmonth_r.Text) == 00))
            {
                MessageBox.Show("!لطفا عدد مربوط به ماه را تصحیح نمایید ");
                txtmonth_r.Focus();
                return;
            }
        }

        private void txtyear_r_Leave(object sender, EventArgs e)
        {
            if ((txtyear_r.Text.Length > 0) && (Convert.ToInt32(txtyear_r.Text) < 1300))
            {
                MessageBox.Show("!لطفا عدد مربوط به سال را تصحیح نمایید ");
                txtyear_r.Focus();
                return;
            }
        }
        //1111111111111111111111111111111
        private void txtday_r1_Leave(object sender, EventArgs e)
        {
            txtday_r1.Text = string.Format("{0,2:G}", txtday_r1.Text);
            txtday_r1.Text = txtday_r1.Text.Replace(" ", "0");
            if ((bool)(Convert.ToInt32(txtday_r1.Text) > 31) || (bool)(Convert.ToInt32(txtday_r1.Text) == 00))
            {
                MessageBox.Show("!لطفا عدد مربوط به روز را تصحیح نمایید ");
                txtday_r1.Focus();
                return;
            }

        }

        private void txtmonth_r1_Leave(object sender, EventArgs e)
        {
            txtmonth_r1.Text = string.Format("{0,2:G}", txtmonth_r1.Text);
            txtmonth_r1.Text = txtmonth_r1.Text.Replace(" ", "0");
            if ((bool)(Convert.ToInt32(txtmonth_r1.Text) > 12) || (bool)(Convert.ToInt32(txtmonth_r1.Text) == 00))
            {
                MessageBox.Show("!لطفا عدد مربوط به ماه را تصحیح نمایید ");
                txtmonth_r1.Focus();
                return;
            }

        }

        private void txtyear_r1_Leave(object sender, EventArgs e)
        {
            if ((txtyear_r1.Text.Length > 0) && (Convert.ToInt32(txtyear_r1.Text) < 1300))
            {
                MessageBox.Show("!لطفا عدد مربوط به سال را تصحیح نمایید ");
                txtyear_r1.Focus();
                return;
            }
        }

        private void btnret_Click(object sender, EventArgs e)
        {
            UIL.ret f = new UIL.ret();
            f.FormClosed+=new FormClosedEventHandler(f_FormClosed);
            f.MdiParent = this.ParentForm;
            DataTable dt = new DataTable();
            bailmentclass bc = new bailmentclass();
            
            if ((dataGridView1.Rows.Count == 0) || (dataGridView1.CurrentRow.Index == -1))
            {
                MessageBox.Show("سطری انتخاب نشده است");
                return;
            }

            
            int cr = dataGridView1.CurrentRow.Index;
            if (cr >= 0)
            {
                
                string id = dataGridView1[0, cr].Value.ToString();
                string name_family = dataGridView1[3, cr].Value.ToString();
                string type = dataGridView1[5, cr].Value.ToString();
                string bailment_date = dataGridView1[6, cr].Value.ToString();

                dt = bc.Search(id, name_family, type, bailment_date);


                if (dt.Rows.Count > 0)
                {

                    f.txtcode.Text = dt.Rows[0]["id"].ToString();
                    f.cbtype.Text=dt.Rows[0]["type"].ToString();
                    f.txtname_bailment.Text = dt.Rows[0]["name_family"].ToString();
                    f.txtphone.Text = dt.Rows[0]["phone_number"].ToString();
                    //f.txtunit_name.Text = dt.Rows[0]["unit_name"].ToString();
                    f.txtname.Text = dt.Rows[0]["name"].ToString();
                    f.txtyear_t.Text = dt.Rows[0]["bailment_date"].ToString().Substring(0, 4);
                    f.txtmonth_t.Text = dt.Rows[0]["bailment_date"].ToString().Substring(5, 2);
                    f.txtday_t.Text = dt.Rows[0]["bailment_date"].ToString().Substring(8, 2);

                    f.txtyear_e.Text = dt.Rows[0]["ret_date"].ToString().Substring(0, 4);
                    f.txtmonth_e.Text = dt.Rows[0]["ret_date"].ToString().Substring(5, 2);
                    f.txtday_e.Text = dt.Rows[0]["ret_date"].ToString().Substring(8, 2);

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

        private void chbail_yes_CheckedChanged(object sender, EventArgs e)
        {
            if (chbail_yes.Checked || chbail_no.Checked)
            {
                btnsearch.Enabled = true;
            }
            else
            {
                if (txtsearch.Text == "")
                { btnsearch.Enabled = false; }
                chlate_date.Checked = false;
            }

        }

        private void chbail_no_CheckedChanged(object sender, EventArgs e)
        {
            if (chbail_no.Checked)
            {
                chlate_date.Checked = false;
            }

            if (chbail_yes.Checked || chbail_no.Checked)
            {
                btnsearch.Enabled = true;
            }
            else
            {
                if (txtsearch.Text == "")
                { btnsearch.Enabled = false; }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PersianDateClass.ShamsiDate());
        }

        private void chlate_date_CheckedChanged(object sender, EventArgs e)
        {
            if (chlate_date.Checked)
            {
                btnsearch.Enabled = true;
                chbail_yes.Checked = true;
            }
            else
            {
                if (txtsearch.Text == "")
                { btnsearch.Enabled = false; }

                chbail_yes.Checked = false;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            REPORT.bailment_Frmreport f = new e_archive.UIL.REPORT.bailment_Frmreport();

            f.rd.Load(Application.StartupPath + "\\Crystal Reports\\bailment_Report.rpt");
            f.rd.SetDataSource(dataGridView1.DataSource);

            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bailment_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode)==Keys.F5)
            {
                Reload();
            }
        }//

        private void Reload(){
            if (SearchFlag == 0)
            {
                bbtnrefresh_Click(null, null);
            }
            else if (SearchFlag == 1)
            {
                btnsearch_Click(null, null);
            }
        }

        private void bailment_Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

       

        private void dataGridView1_DataSourceChanged_1(object sender, EventArgs e)
        {
            label18.Text = "تعداد سطر :" + dataGridView1.Rows.Count.ToString();     
        }

        private void label_Count_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}