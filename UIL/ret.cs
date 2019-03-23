using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class ret : Form
    {
        public ret()
        {
            InitializeComponent();
        }

       // public type_mode.mode mode;

        private void btnsave_Click(object sender, EventArgs e)
        {
            txtday_ret.Text = string.Format("{0,2:G}", txtday_ret.Text);
            txtday_ret.Text = txtday_ret.Text.Replace(" ", "0");


            txtmonth_ret.Text = string.Format("{0,2:G}", txtmonth_ret.Text);
            txtmonth_ret.Text = txtmonth_ret.Text.Replace(" ", "0");

            if (Convert.ToInt32(txtday_ret.Text) == 0)
            {
                MessageBox.Show("!لطفا عدد مربوط به روز بازگشت را تصحیح نمایید ");
                txtday_ret.Focus();
                return;
            }
            if (Convert.ToInt32(txtmonth_ret.Text) == 0)
            {
                MessageBox.Show("!لطفا عدد مربوط به ماه بازگشت را تصحیح نمایید ");
                txtmonth_ret.Focus();
                return;
            }

            DataTable dt = new DataTable();
            
            //if (txtcode.Text == "")
            //{
            //    MessageBox.Show("لطفا کد را وارد نماييد");
            //    txtcode.Focus();
            //    return;
            //}
            //if (cbtype.Text == "")
            //{
            //    MessageBox.Show("لطفا نوع را وارد نماييد");
            //    cbtype.Focus();
            //    return;
            //}
            //if (txtname_bailment.Text == "")
            //{
            //    MessageBox.Show("لطفا نام و نام خانوادگی امانت گیرنده را وارد نماييد");
            //    txtname_bailment.Focus();
            //    return;
            //}
                    
            //if (txtphone.Text == "")
            //{
            //    MessageBox.Show("لطفا شماره تلفن را وارد نماييد");
            //    txtphone.Focus();
            //    return;
            //}
            ////ret
            //if (txtday_ret.Text == "")
            //{
            //    MessageBox.Show("لطفا روز بازگشت را وارد نماييد");
            //    txtday_ret.Focus();
            //    return;
            //}
            //if (txtmonth_ret.Text == "")
            //{
            //    MessageBox.Show("لطفا ماه بازگشت را وارد نماييد");
            //    txtmonth_ret.Focus();
            //    return;
            //}
            //if (txtyear_ret.Text == "")
            //{
            //    MessageBox.Show("لطفا سال بازگشت را وارد نماييد");
            //    txtyear_ret.Focus();
            //    return;
            //}
            //ent ret
            //if (txtday_e.Text == "")
            //{
            //    MessageBox.Show("لطفا روز سررسید تحویل را وارد نماييد");
            //    txtday_e.Focus();
            //    return;
            //}
            //if (txtmonth_e.Text == "")
            //{
            //    MessageBox.Show("لطفا ماه سررسید تحویل را وارد نماييد");
            //    txtmonth_e.Focus();
            //    return;
            //}
            //if (txtyear_e.Text == "")
            //{
            //    MessageBox.Show("لطفا سال سررسید تحویل را وارد نماييد");
            //    txtyear_e.Focus();
            //    return;
            //}
            //if (txtdescribe.Text == "")
            //{
            //    MessageBox.Show("لطفا سایر توضیحات را وارد نماييد");
            //    txtdescribe.Focus();
            //    return;
            //}


            ////if (mode == type_mode.mode.edit)
            ////{
            ////    rec.Edit(cbtype.Text, txtname_bailment.Text, txtphone.Text, txtyear_t.Text + "/" + txtmonth_t.Text + "/" + txtday_t.Text, txtyear_e.Text + "/" + txtmonth_e.Text + "/" + txtday_e.Text, txtdescribe.Text, txtcode.Text);
            ////    MessageBox.Show("!ویرایش انجام شد ");
            ////    this.Close();

            ////}
            ////else if (mode == type_mode.mode.insert)
            ////{

            if ( ( Convert.ToInt32(txtyear_ret.Text + txtmonth_ret.Text + txtday_ret.Text))<(Convert.ToInt32(txtyear_e.Text + txtmonth_e.Text + txtday_e.Text) )&&
               ( Convert.ToInt32(txtyear_ret.Text + txtmonth_ret.Text + txtday_ret.Text))<(Convert.ToInt32(txtyear_t.Text + txtmonth_t.Text + txtday_t.Text) ))
            {
                MessageBox.Show("!تاریخ بازگشت  باید بزرگتر یا مساوی، تاریخ امانت یاتاریخ تحویل باشد ");
                txtday_t.Focus();
                return;
            }

                //album
                if (cbtype.Text == "آلبوم")
                {
                    albumclass ac = new albumclass();

                    dt = ac.Search(txtcode.Text);

                    bool bailmented = (bool)dt.Rows[0]["bailmented"];


                    if (bailmented)//dt.Rows.Count == 0)
                    {
                        ac.Edit_bailmented(false, txtcode.Text);
                    }
                    else
                    {
                        MessageBox.Show(" !این آلبوم موجود می باشد", "                       موجود بودن");
                        txtcode.Focus();
                        return;
                    }

                }//end album


                //book
                if (cbtype.Text == "کتاب")
                {
                    bookclass bc = new bookclass();
                    dt = bc.Search(txtcode.Text);

                    bool bailmented = (bool)dt.Rows[0]["bailmented"];


                    if (bailmented)
                    {
                        bc.Edit_bailmented(false, txtcode.Text);
                    }
                    else
                    {
                        MessageBox.Show(" !این کتاب موجود می باشد", "                        موجود بودن");
                        txtcode.Focus();
                        return;
                       
                    }
                }//end book

                //cd_dvd
                if (cbtype.Text == "لوح فشرده (CD-DVD)")
                {
                    cd_dvdclass cc = new cd_dvdclass();
                    dt = cc.Search(txtcode.Text);

                    bool bailmented = (bool)dt.Rows[0]["bailmented"];


                    if (bailmented)
                    {
                        cc.Edit_bailmented(false, txtcode.Text);
                    }
                    else
                    {

                        MessageBox.Show(" !این لوح فشرده موجود می باشد", "                   موجود بودن");
                        txtcode.Focus();
                        return;
                    }
                }//end cd_dvd


                //magazine
                if (cbtype.Text == "مجله")
                {
                    magazineclass mc = new magazineclass();
                    dt = mc.Search(txtcode.Text);

                    bool bailmented = (bool)dt.Rows[0]["bailmented"];


                    if (bailmented)
                    {
                        mc.Edit_bailmented(false, txtcode.Text);
                    }
                    else
                    {
                        MessageBox.Show(" !این مجله موجود می باشد", "                        موجود بودن");
                        txtcode.Focus();
                        return;
                       
                    }
                }//end magazine

                //report
                if (cbtype.Text == "گزارش")
                {
                    reportclass rc = new reportclass();
                    dt = rc.Search(txtcode.Text);

                    bool bailmented = (bool)dt.Rows[0]["bailmented"];


                    if (bailmented)
                    {
                        rc.Edit_bailmented(false, txtcode.Text);
                    }
                    else
                    {
                        MessageBox.Show(" !این گزارش موجود می باشد", "                       موجود بودن");
                        txtcode.Focus();
                        return;
                       
                    }
                }//end report

                //repertory
                if (cbtype.Text == "کاتالوگ")
                {
                    repertoryclass rc = new repertoryclass();
                    dt = rc.Search(txtcode.Text);

                    bool bailmented = (bool)dt.Rows[0]["bailmented"];


                    if (bailmented)
                    {
                        rc.Edit_bailmented(false, txtcode.Text);
                    }
                    else
                    {
                        MessageBox.Show(" !این کاتالوگ موجود می باشد", "                     موجود بودن");
                        txtcode.Focus();
                        return;
                       }
                }//end repertory


                //map
                if (cbtype.Text == "نقشه")
                {
                    mapclass mc = new mapclass();
                    dt = mc.Search(txtcode.Text);

                    bool bailmented = (bool)dt.Rows[0]["bailmented"];


                    if (bailmented)
                    {
                        mc.Edit_bailmented(false, txtcode.Text);
                    }
                    else
                    {
                        MessageBox.Show(" !این نقشه موجود می باشد", "                        موجود بودن");
                        txtcode.Focus();
                        return;
                    }
                }//end map


                //resume
                if (cbtype.Text == "رزومه")
                {
                    resumeclass rc = new resumeclass();
                    dt = rc.Search(txtcode.Text);

                    bool bailmented = (bool)dt.Rows[0]["bailmented"];


                    if (bailmented)
                    {
                        rc.Edit_bailmented(false, txtcode.Text);
                    }
                    else
                    {
                        MessageBox.Show(" !این رزومه موجود می باشد", "                       موجود بودن");
                        txtcode.Focus();
                        return;
                    }
                }//end resume


                //zuncan
                if (cbtype.Text == "زونکن")
                {
                    zuncanclass zc = new zuncanclass();
                    dt = zc.Search(txtcode.Text);

                    bool bailmented = (bool)dt.Rows[0]["bailmented"];


                    if (bailmented)
                    {
                        zc.Edit_bailmented(false, txtcode.Text);
                    }
                    else
                    {
                        MessageBox.Show(" !این زونکن موجود می باشد", "                       موجود بودن");
                        txtcode.Focus();
                        return;
                    }
                }//end zuncan


                //convention
                if (cbtype.Text == "قرارداد")
                {
                    conventionclass cc = new conventionclass();
                    dt = cc.Search(txtcode.Text);

                    bool bailmented = (bool)dt.Rows[0]["bailmented"];


                    if (bailmented)
                    {
                        cc.Edit_bailmented(false, txtcode.Text);
                    }
                    else
                    {
                        MessageBox.Show(" !این قرارداد موجود می باشد", "                       موجود بودن");
                        txtcode.Focus();
                        return;
                    }
                }//end convention

               
               bailmentclass bac = new bailmentclass();
               bac.Edit_bailmented(false,txtyear_ret.Text+"/"+txtmonth_ret.Text+"/"+txtday_ret.Text,
               txtcode.Text,txtname_bailment.Text,
               cbtype.Text, txtyear_t.Text + "/" + txtmonth_t.Text + "/" + txtday_t.Text);
               MessageBox.Show("!داده ها ثبت شد", "                ثبت", MessageBoxButtons.OK);
               this.Close();
            
            
            
            
            //dt = rec.Search(txtcode.Text);

                //if (dt.Rows.Count == 0)
                //{

                    //rec.Add(txtcode.Text, cbtype.Text, txtname_bailment.Text, txtphone.Text, txtyear_t.Text + "/" + txtmonth_t.Text + "/" + txtday_t.Text, txtyear_e.Text + "/" + txtmonth_e.Text + "/" + txtday_e.Text, txtdescribe.Text);
                    
                    //bailmented
                   
                    //

                    //DialogResult dr;
                   
                    //dr = MessageBox.Show("!داده ها ثبت شد", "                ثبت", MessageBoxButtons.OK);
                    //if (dr == DialogResult.OK)
                    //{
                    //    txtcode.Text = "";
                    //    cbtype.SelectedIndex=-1;
                    //    txtname_bailment.Text = "";
                    //    txtphone.Text = "";
                    //    txtday_t.Text = "";
                    //    txtmonth_t.Text = "";
                    //    txtyear_t.Text = "";

                    //    txtday_e.Text = "";
                    //    txtmonth_e.Text = "";
                    //    txtyear_e.Text = "";
                    //    txtdescribe.Text = "";

                    //}//dr
                //}
                //else
                //{
                //    MessageBox.Show("! قبلا مشخصاتی با این شماره ، ثبت شده است", " تذکر :فیلد شماره تکراری است");

                //    txtcode.Focus();
                //}

            }

        
        //ret

        private void txtday_ret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;
            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;
        }

        private void txtmonth_ret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;
            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;
        }

        private void txtyear_ret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;
            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;
        }
        //end ret

        private void txtday_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;
            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;
        }

        private void txtmonth_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;
            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;
        }

        private void txtyear_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;
            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;
        }

       
      
       
       //ret

        private void txtday_ret_Leave(object sender, EventArgs e)
        {
            if ((txtday_ret.Text.Length > 0) && ((bool)(Convert.ToInt32(txtday_ret.Text) > 31) || (bool)(Convert.ToInt32(txtday_ret.Text) == 00)))
            {
               
                MessageBox.Show("!لطفا عدد مربوط به روز را تصحیح نمایید ");
                txtday_ret.Focus();
                return;
            }
        }

        private void txtmonth_ret_Leave(object sender, EventArgs e)
        {

            if ((txtmonth_ret.Text.Length > 0) && ((bool)(Convert.ToInt32(txtmonth_ret.Text) > 12) || (bool)(Convert.ToInt32(txtmonth_ret.Text) == 00)))
            {
                MessageBox.Show("!لطفا عدد مربوط به ماه را تصحیح نمایید ");
                txtmonth_ret.Focus();
                return;
            }
        }

        private void txtyear_ret_Leave(object sender, EventArgs e)
        {
            if ((txtyear_ret.Text.Length>0)&&(Convert.ToInt32(txtyear_ret.Text) < 1300))
            {
                MessageBox.Show("!لطفا عدد مربوط به سال را تصحیح نمایید ");
                txtyear_ret.Focus();
                return;
            }
        }

        //end ret
        private void txtday_e_Leave(object sender, EventArgs e)
        {
            txtday_e.Text = string.Format("{0,2:G}", txtday_e.Text);
            txtday_e.Text = txtday_e.Text.Replace(" ", "0");
            if ((bool)(Convert.ToInt32(txtday_e.Text) > 31) || (bool)(Convert.ToInt32(txtday_e.Text) == 00))
            {
                MessageBox.Show("!لطفا عدد مربوط به روز را تصحیح نمایید ");
                txtday_e.Focus();
                return;
            }

        }

        private void txtmonth_e_Leave(object sender, EventArgs e)
        {
            txtmonth_e.Text = string.Format("{0,2:G}", txtmonth_e.Text);
            txtmonth_e.Text = txtmonth_e.Text.Replace(" ", "0");
            if ((bool)(Convert.ToInt32(txtmonth_e.Text) > 12) || (bool)(Convert.ToInt32(txtmonth_e.Text) == 00))
            {
                MessageBox.Show("!لطفا عدد مربوط به ماه را تصحیح نمایید ");
                txtmonth_e.Focus();
                return;
            }
        }

        private void txtyear_e_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtyear_e.Text) < 1300)
            {
                MessageBox.Show("!لطفا عدد مربوط به سال را تصحیح نمایید ");
                txtyear_e.Focus();
                return;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;
            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;
        }

        
        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtname_bailment.Focus();
        }

        private void cbtype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtcode.Focus();
        }

        private void txtname_bailment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtphone.Focus();
        }
        private void txtday_ret_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtmonth_ret.Focus();
        }

        private void txtmonth_ret_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtyear_ret.Focus();
        }

        private void txtyear_ret_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                btnsave.Focus();
        }

        private void txtday_e_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                txtmonth_e.Focus();
        }

        private void txtmonth_e_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtyear_e.Focus();
        }

        private void txtyear_e_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtdescribe.Focus();
        }

        private void txtphone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtday_t.Focus();
        }

        private void txtphone_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ret_Load(object sender, EventArgs e)
        {

        }

        ////private void ret_Load(object sender, EventArgs e)
        ////{
        ////    global g = new global();

        ////    if (g.get_album())
        ////    {
        ////        cbtype.Items.Add("آلبوم");
        ////    }

        ////    if (g.get_book())
        ////    {
        ////        cbtype.Items.Add("کتاب");
        ////    }

        ////    if (g.get_cd_dvd())
        ////    {
        ////        cbtype.Items.Add("لوح فشرده (CD-DVD)");
        ////    }

        ////    if (g.get_magazine())
        ////    {
        ////        cbtype.Items.Add("مجله");
        ////    }

        ////    if (g.get_report())
        ////    {
        ////        cbtype.Items.Add("گزارش");
        ////    }

        ////    if (g.get_repertory())
        ////    {
        ////        cbtype.Items.Add("کاتالوگ");
        ////    }

        ////    if (g.get_map())
        ////    {
        ////        cbtype.Items.Add("نقشه");
        ////    }

        ////    if (g.get_resume())
        ////    {
        ////        cbtype.Items.Add("رزومه");
        ////    }

        ////    if (g.get_zuncan())
        ////    {
        ////        cbtype.Items.Add("زونکن");
        ////    }

        ////    if (g.get_convention())
        ////    {
        ////        cbtype.Items.Add("قرارداد");
        ////    }
        ////    txtcode.Focus();
        ////}

        //private void btnsearch_id_Click(object sender, EventArgs e)
        //{
        //    global g = new global();
        //    if (cbtype.Text == "آلبوم")
        //    {
        //        UIL.album_Main f = new UIL.album_Main();
        //        //f.MdiParent = this.;
        //        f.btnselect_id_bail.Visible = true;
        //        f.ShowDialog();
        //        txtcode.Text = g.get_CodeClipBoard();
        //        return;
        //    }
        //    if (cbtype.Text == "کتاب")
        //    {
        //        UIL.book_Main f = new UIL.book_Main();
        //        //f.MdiParent = this.;
        //        f.btnselect_id_bail.Visible = true;
        //        f.ShowDialog();
        //        txtcode.Text = g.get_CodeClipBoard();
        //        return;
        //    }
        //    if (cbtype.Text == "لوح فشرده (CD-DVD)")
        //    {
        //        UIL.cd_dvd_Main f = new UIL.cd_dvd_Main();
        //        //f.MdiParent = this.;
        //        f.btnselect_id_bail.Visible = true;
        //        f.ShowDialog();
        //        txtcode.Text = g.get_CodeClipBoard();
        //        return;
        //    }
        //    if (cbtype.Text == "مجله")
        //    {
        //        UIL.magazine_Main f = new UIL.magazine_Main();
        //        //f.MdiParent = this.;
        //        f.btnselect_id_bail.Visible = true;
        //        f.ShowDialog();
        //        txtcode.Text = g.get_CodeClipBoard();
        //        return;
        //    }
        //    if (cbtype.Text == "گزارش")
        //    {
        //        UIL.report_Main f = new UIL.report_Main();
        //        //f.MdiParent = this.;
        //        f.btnselect_id_bail.Visible = true;
        //        f.ShowDialog();
        //        txtcode.Text = g.get_CodeClipBoard();
        //        return;
        //    }
        //    if (cbtype.Text == "کاتالوگ")
        //    {
        //        UIL.repertory_Main f = new UIL.repertory_Main();
        //        //f.MdiParent = this.;
        //        f.btnselect_id_bail.Visible = true;
        //        f.ShowDialog();
        //        txtcode.Text = g.get_CodeClipBoard();
        //        return;
        //    }
        //    if (cbtype.Text == "نقشه")
        //    {
        //        UIL.map_Main f = new UIL.map_Main();
        //        //f.MdiParent = this.;
        //        f.btnselect_id_bail.Visible = true;
        //        f.ShowDialog();
        //        txtcode.Text = g.get_CodeClipBoard();
        //        return;
        //    }
        //    if (cbtype.Text == "زونکن")
        //    {
        //        UIL.zuncan_Main f = new UIL.zuncan_Main();
        //        //f.MdiParent = this.;
        //        f.btnselect_id_bail.Visible = true;
        //        f.ShowDialog();
        //        txtcode.Text = g.get_CodeClipBoard();
        //        return;
        //    }
        //    if (cbtype.Text == "رزومه")
        //    {
        //        UIL.resume_Main f = new UIL.resume_Main();
        //        //f.MdiParent = this.;
        //        f.btnselect_id_bail.Visible = true;
        //        f.ShowDialog();
        //        txtcode.Text = g.get_CodeClipBoard();
        //        return;
        //    }
        //    if (cbtype.Text == "قرارداد")
        //    {
        //        convention_Main f = new convention_Main();
        //        //f.MdiParent = this.;
        //        f.btnselect_id_bail.Visible = true;
        //        f.ShowDialog();
        //        txtcode.Text = g.get_CodeClipBoard();
        //        return;
        //    }
        
        //}

        //private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        ////{
        ////    btnsearch_id.Enabled = true;
        ////}

}         
                          
    }
