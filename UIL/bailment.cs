using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class bailment : Form
    {
        public type_mode.mode mode;

        public string Old_id = "";
        public string Old_family_name = "";
        public string Old_type = "";
        public string Old_bailment_date = "";
        public string strAA = "";
        public bailment()
        {
            InitializeComponent();
        }

       

        private void btnsave_Click(object sender, EventArgs e)
        {
            bailmentclass bac = new bailmentclass();
            DataTable dt = new DataTable();
            global g = new global();

            txtday_t.Text = string.Format("{0,2:G}", txtday_t.Text);
            txtday_t.Text = txtday_t.Text.Replace(" ", "0");

            txtmonth_t.Text = string.Format("{0,2:G}", txtmonth_t.Text);
            txtmonth_t.Text = txtmonth_t.Text.Replace(" ", "0");

            txtyear_t.Text = string.Format("{0,4:G}", txtyear_t.Text);
            txtyear_t.Text = txtyear_t.Text.Replace(" ", "0");

            txtday_e.Text = string.Format("{0,2:G}", txtday_e.Text);
            txtday_e.Text = txtday_e.Text.Replace(" ", "0");

            txtmonth_e.Text = string.Format("{0,2:G}", txtmonth_e.Text);
            txtmonth_e.Text = txtmonth_e.Text.Replace(" ", "0");

            txtyear_e.Text = string.Format("{0,4:G}", txtyear_e.Text);
            txtyear_e.Text = txtyear_e.Text.Replace(" ", "0");

            if (txtname_bailment.Text == "")
            {
                MessageBox.Show("لطفا نام و نام خانوادگی امانت گیرنده را وارد نماييد");
                txtname_bailment.Focus();
                return;
            }
            if (cbtype.Text == "")
            {
                MessageBox.Show("لطفا نوع را وارد نماييد");
                cbtype.Focus();
                return;
            }
            if (txtname.Text == "")
            {
                MessageBox.Show("!این شماره در نوع وارد شده موجود نمی باشد", "شماره ناشناس");
                cbtype.Focus();
                return;
            }
            if (txtcode2.Text == "")
            {
                MessageBox.Show("لطفا کد را وارد نماييد");
                txtcode2.Focus();
                return;
            }
            if (txtunit_name.Text == "")
            {
                // MessageBox.Show("لطفا نام واحد را وارد نماييد");
                txtunit_name.Text = " ";
                //return;
            }
            if (txtphone.Text == "")
            {
                //MessageBox.Show("لطفا شماره تلفن را وارد نماييد");
                txtphone.Text = " ";
                //return;
            }
            if ((txtday_t.Text == "") || (Convert.ToInt32(txtday_t.Text) == 0))
            {
                MessageBox.Show("لطفا روز تحویل را وارد نماييد");
                txtday_t.Focus();
                return;
            }
            if ((txtmonth_t.Text == "") || (Convert.ToInt32(txtmonth_t.Text) == 0))
            {
                MessageBox.Show("لطفا ماه تحویل را وارد نماييد");
                txtmonth_t.Focus();
                return;
            }
            if ((txtyear_t.Text == "") || (Convert.ToInt32(txtyear_t.Text) == 0))
            {
                MessageBox.Show("لطفا سال تحویل را وارد نماييد");
                txtyear_t.Focus();
                return;
            }
            //eeeeeeeeeeeeeeeeeeeeeeeeeeeeeee
            if ((txtday_e.Text == "") || (Convert.ToInt32(txtday_e.Text) == 0))
            {
                MessageBox.Show("لطفا روز سررسید تحویل را وارد نماييد");
                txtday_e.Focus();
                return;
            }
            if ((txtmonth_e.Text == "") || (Convert.ToInt32(txtmonth_e.Text) == 0))
            {
                MessageBox.Show("لطفا ماه سررسید تحویل را وارد نماييد");
                txtmonth_e.Focus();
                return;
            }
            if ((txtyear_e.Text == "") || (Convert.ToInt32(txtyear_e.Text) == 0))
            {
                MessageBox.Show("لطفا سال سررسید تحویل را وارد نماييد");
                txtyear_e.Focus();
                return;
            }
            if (txtdescribe.Text == "")
            {
                //MessageBox.Show("لطفا سایر توضیحات را وارد نماييد");
                txtdescribe.Text = " ";
                //return;
            }

            if ((Convert.ToInt32(txtyear_t.Text + txtmonth_t.Text + txtday_t.Text)) > (Convert.ToInt32(txtyear_e.Text + txtmonth_e.Text + txtday_e.Text)))
            {
                MessageBox.Show("!تاریخ تحویل باید بزرگتر مساوی، تاریخ امانت باشد ");
                txtday_e.Focus();
                return;
            }

            //edit
            if (mode == type_mode.mode.edit)
            {
                //bac.Edit(txtname_bailment.Text, cbtype.Text, txtunit_name.Text, txtphone.Text,
                //           txtyear_t.Text + "/" + txtmonth_t.Text + "/" + txtday_t.Text, txtyear_e.Text + "/" +
                //           txtmonth_e.Text + "/" + txtday_e.Text, txtdescribe.Text, txtcode2.Text);
                //MessageBox.Show("!ویرایش انجام شد ");
                //this.Close();
                ///////////////////////////////////////////////////////////////////////////////////////

                //album
                if (cbtype.Text == "آلبوم")
                {
                    albumclass ac = new albumclass();
                    dt = ac.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];
                        if ((bailmented) && (txtcode2.Text != Old_id))//dt.Rows.Count == 0)
                        {
                            MessageBox.Show("   !این آلبوم در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            if ((cbtype.Text != strAA) || (txtcode2.Text != Old_id))
                            {
                                Edit_Old_Bailment(Old_type, Old_id);
                                ac.Edit_bailmented(true, txtcode2.Text);
                            }
                            //else                                                              
                            //    ac.Edit_bailmented(true, txtcode2.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول آلبوم وجود ندارد", "شماره ناشناس");
                        return;
                    }

                }//end album

                //book
                if (cbtype.Text == "کتاب")
                {
                    bookclass bc = new bookclass();
                    dt = bc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if ((bailmented) && (txtcode2.Text != Old_id))
                        {
                            MessageBox.Show("   !این کتاب در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            if ((cbtype.Text != strAA) || (txtcode2.Text != Old_id))
                            {

                                Edit_Old_Bailment(Old_type, Old_id);
                                bc.Edit_bailmented(true, txtcode2.Text);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول کتاب وجود ندارد", "شماره ناشناس");
                        return;
                    }
                }//end book

                //cd_dvd
                if (cbtype.Text == "لوح فشرده (CD-DVD)")
                {
                    cd_dvdclass cc = new cd_dvdclass();
                    dt = cc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if ((bailmented) && (txtcode2.Text != Old_id))
                        {
                            MessageBox.Show("   !این لوح فشرده در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            if ((cbtype.Text != strAA) || (txtcode2.Text != Old_id))
                            {
                                Edit_Old_Bailment(Old_type, Old_id);
                                cc.Edit_bailmented(true, txtcode2.Text);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول لوح فشرده وجود ندارد", "شماره ناشناس");
                        return;
                    }

                }//end cd_dvd

                //magazine
                if (cbtype.Text == "مجله")
                {
                    magazineclass mc = new magazineclass();
                    dt = mc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if ((bailmented) && (txtcode2.Text != Old_id))
                        {
                            MessageBox.Show("   !این مجله در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            if ((cbtype.Text != strAA) || (txtcode2.Text != Old_id))
                            {
                                Edit_Old_Bailment(Old_type, Old_id);
                                mc.Edit_bailmented(true, txtcode2.Text);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول مجله وجود ندارد", "شماره ناشناس");
                        return;
                    }

                }//end magazine

                //report
                if (cbtype.Text == "گزارش")
                {
                    reportclass rc = new reportclass();
                    dt = rc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if ((bailmented) && (txtcode2.Text != Old_id))
                        {
                            MessageBox.Show("   !این گزارش در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            if ((cbtype.Text != strAA) || (txtcode2.Text != Old_id))
                            {
                                Edit_Old_Bailment(Old_type, Old_id);
                                rc.Edit_bailmented(true, txtcode2.Text);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول گزارش وجود ندارد", "شماره ناشناس");
                        return;
                    }

                }//end report

                //repertory
                if (cbtype.Text == "کاتالوگ")
                {
                    repertoryclass rc = new repertoryclass();
                    dt = rc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if ((bailmented) && (txtcode2.Text != Old_id))
                        {
                            MessageBox.Show("   !این کاتالوگ در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            if ((cbtype.Text != strAA) || (txtcode2.Text != Old_id))
                            {
                                Edit_Old_Bailment(Old_type, Old_id);
                                rc.Edit_bailmented(true, txtcode2.Text);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول کاتالوگ وجود ندارد", "شماره ناشناس");
                        return;
                    }

                }//end repertory


                //map
                if (cbtype.Text == "نقشه")
                {
                    mapclass mc = new mapclass();
                    dt = mc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if ((bailmented) && (txtcode2.Text != Old_id))
                        {
                            MessageBox.Show("   !این نقشه در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            if ((cbtype.Text != strAA) || (txtcode2.Text != Old_id))
                            {
                                Edit_Old_Bailment(Old_type, Old_id);
                                mc.Edit_bailmented(true, txtcode2.Text);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول نقشه وجود ندارد", "شماره ناشناس");
                        return;
                    }
                }//end map


                //resume
                if (cbtype.Text == "رزومه")
                {
                    resumeclass rc = new resumeclass();
                    dt = rc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if ((bailmented) && (txtcode2.Text != Old_id))
                        {
                            MessageBox.Show("   !این رزومه در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            if ((cbtype.Text != strAA) || (txtcode2.Text != Old_id))
                            {
                                Edit_Old_Bailment(Old_type, Old_id);
                                rc.Edit_bailmented(true, txtcode2.Text);
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول رزومه وجود ندارد", "شماره ناشناس");
                        return;
                    }

                }//end resume


                //zuncan
                if (cbtype.Text == "زونکن")
                {
                    zuncanclass zc = new zuncanclass();
                    dt = zc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {

                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if ((bailmented) && (txtcode2.Text != Old_id))
                        {
                            MessageBox.Show("   !این زونکن در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            Edit_Old_Bailment(Old_type, Old_id);
                            zc.Edit_bailmented(true, txtcode2.Text);
                        }
                    }


                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول زونکن وجود ندارد", "شماره ناشناس");
                        return;
                    }
                }//end zuncan


                //convention
                if (cbtype.Text == "قرارداد")
                {
                    conventionclass cc = new conventionclass();
                    dt = cc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if ((bailmented) && (txtcode2.Text != Old_id))
                        {
                            MessageBox.Show("   !این قرارداد در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            if ((cbtype.Text != strAA) || (txtcode2.Text != Old_id))
                            {
                                Edit_Old_Bailment(Old_type, Old_id);
                                cc.Edit_bailmented(true, txtcode2.Text);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول قرارداد وجود ندارد", "شماره ناشناس");
                        return;
                    }
                }//end convention





                //dt = bac.Search(txtcode2.Text);

                //if (dt.Rows.Count == 0)//add bailment
                //{
                //bac.Add(txtcode2.Text, txtname_bailment.Text,
                //cbtype.Text, txtname.Text, txtunit_name.Text, txtphone.Text,
                //txtyear_t.Text + "/" + txtmonth_t.Text + "/" + txtday_t.Text, txtyear_e.Text + "/" + txtmonth_e.Text + "/" + txtday_e.Text,
                //txtdescribe.Text, true, " ");

                bac.Edit(txtcode2.Text, txtname.Text, txtname_bailment.Text, cbtype.Text, txtunit_name.Text,
                    txtphone.Text, txtyear_t.Text + "/" + txtmonth_t.Text + "/" + txtday_t.Text,
                    txtyear_e.Text + "/" + txtmonth_e.Text + "/" + txtday_e.Text, txtdescribe.Text,
                   Old_id, Old_family_name, Old_type, Old_bailment_date);
                MessageBox.Show("!ویرایش انجام شد ");
                this.Close();
                //DialogResult dr;

                //dr = MessageBox.Show("!داده ها ثبت شد", "                 ثبت", MessageBoxButtons.OK);
                //if (dr == DialogResult.OK)
                //{

                //    txtcode2.Text = "";
                //    cbtype.SelectedIndex = -1;
                //    txtname_bailment.Text = "";
                //    txtphone.Text = "";
                //    txtunit_name.Text = "";
                //    txtname.Text = "";
                //    txtday_t.Text = "";
                //    txtmonth_t.Text = "";
                //    txtyear_t.Text = "";

                //    txtday_e.Text = "";
                //    txtmonth_e.Text = "";
                //    txtyear_e.Text = "";
                //    txtdescribe.Text = "";

                //}//dr
                //}//end add bailment
                //else
                //{
                //    MessageBox.Show("! قبلا مشخصاتی با این شماره ، ثبت شده است", " تذکر :فیلد شماره تکراری است");

                //}


            }

            //}/////////////////////////////////////////////////////////END EDIT
            //add
            else if (mode == type_mode.mode.insert)
            {
                //album
                if (cbtype.Text == "آلبوم")
                {
                    albumclass ac = new albumclass();
                    dt = ac.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];
                        if (bailmented)//dt.Rows.Count == 0)
                        {
                            MessageBox.Show("   !این آلبوم در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            ac.Edit_bailmented(true, txtcode2.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول آلبوم وجود ندارد", "شماره ناشناس");
                        return;
                    }

                }//end album

                //book
                if (cbtype.Text == "کتاب")
                {
                    bookclass bc = new bookclass();
                    dt = bc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if (bailmented)
                        {
                            MessageBox.Show("   !این کتاب در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            bc.Edit_bailmented(true, txtcode2.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول کتاب وجود ندارد", "شماره ناشناس");
                        return;
                    }
                }//end book

                //cd_dvd
                if (cbtype.Text == "لوح فشرده (CD-DVD)")
                {
                    cd_dvdclass cc = new cd_dvdclass();
                    dt = cc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if (bailmented)
                        {
                            MessageBox.Show("   !این لوح فشرده در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            cc.Edit_bailmented(true, txtcode2.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول لوح فشرده وجود ندارد", "شماره ناشناس");
                        return;
                    }

                }//end cd_dvd

                //magazine
                if (cbtype.Text == "مجله")
                {
                    magazineclass mc = new magazineclass();
                    dt = mc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if (bailmented)
                        {
                            MessageBox.Show("   !این مجله در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            mc.Edit_bailmented(true, txtcode2.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول مجله وجود ندارد", "شماره ناشناس");
                        return;
                    }

                }//end magazine

                //report
                if (cbtype.Text == "گزارش")
                {
                    reportclass rc = new reportclass();
                    dt = rc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if (bailmented)
                        {
                            MessageBox.Show("   !این گزارش در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            rc.Edit_bailmented(true, txtcode2.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول گزارش وجود ندارد", "شماره ناشناس");
                        return;
                    }

                }//end report

                //repertory
                if (cbtype.Text == "کاتالوگ")
                {
                    repertoryclass rc = new repertoryclass();
                    dt = rc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if (bailmented)
                        {
                            MessageBox.Show("   !این کاتالوگ در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            rc.Edit_bailmented(true, txtcode2.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول کاتالوگ وجود ندارد", "شماره ناشناس");
                        return;
                    }

                }//end repertory


                //map
                if (cbtype.Text == "نقشه")
                {
                    mapclass mc = new mapclass();
                    dt = mc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if (bailmented)
                        {
                            MessageBox.Show("   !این نقشه در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            mc.Edit_bailmented(true, txtcode2.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول نقشه وجود ندارد", "شماره ناشناس");
                        return;
                    }
                }//end map


                //resume
                if (cbtype.Text == "رزومه")
                {
                    resumeclass rc = new resumeclass();
                    dt = rc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if (bailmented)
                        {
                            MessageBox.Show("   !این رزومه در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            rc.Edit_bailmented(true, txtcode2.Text);
                        }
                    }

                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول رزومه وجود ندارد", "شماره ناشناس");
                        return;
                    }

                }//end resume


                //zuncan
                if (cbtype.Text == "زونکن")
                {
                    zuncanclass zc = new zuncanclass();
                    dt = zc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {

                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if (bailmented)
                        {
                            MessageBox.Show("   !این زونکن در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            zc.Edit_bailmented(true, txtcode2.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول زونکن وجود ندارد", "شماره ناشناس");
                        return;
                    }
                }//end zuncan


                //convention
                if (cbtype.Text == "قرارداد")
                {
                    conventionclass cc = new conventionclass();
                    dt = cc.Search(txtcode2.Text);
                    if (dt.Rows.Count > 0)
                    {
                        bool bailmented = (bool)dt.Rows[0]["bailmented"];


                        if (bailmented)
                        {
                            MessageBox.Show("   !این قرارداد در امانت می باشد", "         امانت داده شده");
                            txtcode2.Focus();
                            return;
                        }
                        else
                        {
                            cc.Edit_bailmented(true, txtcode2.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("چنین شماره ای در جدول قرارداد وجود ندارد", "شماره ناشناس");
                        return;
                    }
                }//end convention





                //dt = bac.Search(txtcode2.Text);

                //if (dt.Rows.Count == 0)//add bailment
                //{
                bac.Add(txtcode2.Text, txtname_bailment.Text,
                cbtype.Text, txtname.Text, txtunit_name.Text, txtphone.Text,
                txtyear_t.Text + "/" + txtmonth_t.Text + "/" + txtday_t.Text, txtyear_e.Text + "/" + txtmonth_e.Text + "/" + txtday_e.Text,
                txtdescribe.Text, true, " ");
                DialogResult dr;

                dr = MessageBox.Show("!داده ها ثبت شد", "                 ثبت", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {

                    txtcode2.Text = "";
                    cbtype.SelectedIndex = -1;
                    txtname_bailment.Text = "";
                    txtphone.Text = "";
                    txtunit_name.Text = "";
                    txtname.Text = "";
                    txtday_t.Text = "";
                    txtmonth_t.Text = "";
                    txtyear_t.Text = "";

                    txtday_e.Text = "";
                    txtmonth_e.Text = "";
                    txtyear_e.Text = "";
                    txtdescribe.Text = "";

                }//dr
                //}//end add bailment
                //else
                //{
                //    MessageBox.Show("! قبلا مشخصاتی با این شماره ، ثبت شده است", " تذکر :فیلد شماره تکراری است");

                //}


            }

        }



        private void txtday_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;
            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;


        }

        private void txtmonth_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;
            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;


        }

        private void txtyear_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;
            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;


        }

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

        private void txtname_bailment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtunit_name.Focus();
        }

        private void cbtype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtname_bailment.Focus();
        }

        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    txtname_bailment.Focus();
        }
        private void txtname_vahed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtphone.Focus();
        }

        private void txtphone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtday_t.Focus();
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;
            int i = e.KeyChar;
            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;


        }

        private void txtday_t_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtmonth_t.Focus();
        }

        private void txtmonth_t_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtyear_t.Focus();
        }

        private void txtyear_t_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtday_e.Focus();
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

        private void txtday_t_Leave(object sender, EventArgs e)
        {

            if ((txtday_t.Text.Length > 0) && ((bool)(Convert.ToInt32(txtday_t.Text) > 31) || (bool)(Convert.ToInt32(txtday_t.Text) == 00)))
            {
                MessageBox.Show("!لطفا عدد مربوط به روز را تصحیح نمایید ");
                txtday_t.Focus();
                return;
            }

        }

        private void txtmonth_t_Leave(object sender, EventArgs e)
        {


            if ((txtmonth_t.Text.Length > 0) && ((bool)(Convert.ToInt32(txtmonth_t.Text) > 12) || (bool)(Convert.ToInt32(txtmonth_t.Text) == 00)))
            {
                MessageBox.Show("!لطفا عدد مربوط به ماه را تصحیح نمایید ");
                txtmonth_t.Focus();
                return;
            }

        }

        private void txtyear_t_Leave(object sender, EventArgs e)
        {
            if ((txtyear_t.Text.Length > 0) && (Convert.ToInt32(txtyear_t.Text) < 1300))
            {
                MessageBox.Show("!لطفا عدد مربوط به سال را تصحیح نمایید ");
                txtyear_t.Focus();
                return;
            }
        }

        private void txtday_e_Leave(object sender, EventArgs e)
        {

            if ((txtday_e.Text.Length > 0) && ((bool)(Convert.ToInt32(txtday_e.Text) > 31) || (bool)(Convert.ToInt32(txtday_e.Text) == 00)))
            {
                MessageBox.Show("!لطفا عدد مربوط به روز را تصحیح نمایید ");
                txtday_e.Focus();
                return;
            }

        }

        private void txtmonth_e_Leave(object sender, EventArgs e)
        {


            if ((txtmonth_e.Text.Length > 0) && ((bool)(Convert.ToInt32(txtmonth_e.Text) > 12) || (bool)(Convert.ToInt32(txtmonth_e.Text) == 00)))
            {
                MessageBox.Show("!لطفا عدد مربوط به ماه را تصحیح نمایید ");
                txtmonth_e.Focus();
                return;
            }
        }

        private void txtyear_e_Leave(object sender, EventArgs e)
        {

            if ((txtyear_e.Text.Length > 0) && (Convert.ToInt32(txtyear_e.Text) < 1300))
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

        private void bailment_Load(object sender, EventArgs e)
        {
            global g = new global();

            if (g.get_album())
            {
                cbtype.Items.Add("آلبوم");
            }

            if (g.get_book())
            {
                cbtype.Items.Add("کتاب");
            }

            if (g.get_cd_dvd())
            {
                cbtype.Items.Add("لوح فشرده (CD-DVD)");
            }

            if (g.get_magazine())
            {
                cbtype.Items.Add("مجله");
            }

            if (g.get_report())
            {
                cbtype.Items.Add("گزارش");
            }

            if (g.get_repertory())
            {
                cbtype.Items.Add("کاتالوگ");
            }

            if (g.get_map())
            {
                cbtype.Items.Add("نقشه");
            }

            if (g.get_resume())
            {
                cbtype.Items.Add("رزومه");
            }

            if (g.get_zuncan())
            {
                cbtype.Items.Add("زونکن");
            }

            if (g.get_convention())
            {
                cbtype.Items.Add("قرارداد");
            }

            cbtype.SelectedIndex = cbtype.Items.IndexOf(strAA);
            txtcode2.Focus();
        }


        private void btnsearch_id_Click(object sender, EventArgs e)
        {
            global g = new global();
            if (cbtype.Text == "آلبوم")
            {
                UIL.album_Main f = new UIL.album_Main();
                //f.MdiParent = this.;
                f.btnselect_id_bail.Visible = true;
                f.ShowDialog();
                txtname.Text = g.get_CodeClipBoard_name();
                txtcode2.Text = g.get_CodeClipBoard();
                return;
            }
            if (cbtype.Text == "کتاب")
            {
                UIL.book_Main f = new UIL.book_Main();
                //f.MdiParent = this.;
                f.btnselect_id_bail.Visible = true;
                f.ShowDialog();
                txtname.Text = g.get_CodeClipBoard_name();
                txtcode2.Text = g.get_CodeClipBoard();
                return;
            }
            if (cbtype.Text == "لوح فشرده (CD-DVD)")
            {
                UIL.cd_dvd_Main f = new UIL.cd_dvd_Main();
                //f.MdiParent = this.;
                f.btnselect_id_bail.Visible = true;
                f.ShowDialog();
                txtname.Text = g.get_CodeClipBoard_name();
                txtcode2.Text = g.get_CodeClipBoard();
                return;
            }
            if (cbtype.Text == "مجله")
            {
                UIL.magazine_Main f = new UIL.magazine_Main();
                //f.MdiParent = this.;
                f.btnselect_id_bail.Visible = true;
                f.ShowDialog();
                txtname.Text = g.get_CodeClipBoard_name();
                txtcode2.Text = g.get_CodeClipBoard();
                return;
            }
            if (cbtype.Text == "گزارش")
            {
                UIL.report_Main f = new UIL.report_Main();
                //f.MdiParent = this.;
                f.btnselect_id_bail.Visible = true;
                f.ShowDialog();
                txtname.Text = g.get_CodeClipBoard_name();
                txtcode2.Text = g.get_CodeClipBoard();
                return;
            }
            if (cbtype.Text == "کاتالوگ")
            {
                UIL.repertory_Main f = new UIL.repertory_Main();
                //f.MdiParent = this.;
                f.btnselect_id_bail.Visible = true;
                f.ShowDialog();
                txtname.Text = g.get_CodeClipBoard_name();
                txtcode2.Text = g.get_CodeClipBoard();
                return;
            }
            if (cbtype.Text == "نقشه")
            {
                UIL.map_Main f = new UIL.map_Main();
                //f.MdiParent = this.;
                f.btnselect_id_bail.Visible = true;
                f.ShowDialog();
                txtname.Text = g.get_CodeClipBoard_name();
                txtcode2.Text = g.get_CodeClipBoard();
                return;
            }
            if (cbtype.Text == "زونکن")
            {
                UIL.zuncan_Main f = new UIL.zuncan_Main();
                //f.MdiParent = this.;
                f.btnselect_id_bail.Visible = true;
                f.ShowDialog();
                txtname.Text = g.get_CodeClipBoard_name();
                txtcode2.Text = g.get_CodeClipBoard();
                return;
            }
            if (cbtype.Text == "رزومه")
            {
                UIL.resume_Main f = new UIL.resume_Main();
                //f.MdiParent = this.;
                f.btnselect_id_bail.Visible = true;
                f.ShowDialog();
                txtname.Text = g.get_CodeClipBoard_name();
                txtcode2.Text = g.get_CodeClipBoard();
                return;
            }

            if (cbtype.Text == "قرارداد")
            {
                convention_Main f = new convention_Main();
                //f.MdiParent = this.;
                f.btnselect_id_bail.Visible = true;
                f.ShowDialog();
                txtname.Text = g.get_CodeClipBoard_name();
                txtcode2.Text = g.get_CodeClipBoard();
                return;
            }

        }

        private void cbtype_SelectedValueChanged(object sender, EventArgs e)
        {
            //txtcode2.Text = "";
            btnsearch_id.Enabled = true;
            //txtname.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {
            ////DataTable dt = new DataTable();
            //////album
            ////if (cbtype.Text == "آلبوم")
            ////{
            ////    albumclass ac = new albumclass();
            ////    dt = ac.Search(txtcode.Text);
            ////    if (dt.Rows.Count > 0)
            ////    {
            ////        txtname.Text = dt.Rows[0]["title"].ToString();
            ////        return;
            ////    }
            ////}//end album

            ////    //book
            ////    if (cbtype.Text == "کتاب")
            ////    {
            ////        bookclass bc = new bookclass();
            ////        dt = bc.Search(txtcode.Text);

            ////        if (dt.Rows.Count > 0)
            ////        {
            ////            txtname.Text = dt.Rows[0]["title"].ToString();
            ////            return;
            ////        }
            ////    }//end book

            ////    //cd_dvd
            ////    if (cbtype.Text == "لوح فشرده (CD-DVD)")
            ////    {
            ////        cd_dvdclass cc = new cd_dvdclass();
            ////        dt = cc.Search(txtcode.Text);

            ////        if (dt.Rows.Count > 0)
            ////        {
            ////            txtname.Text = "بدون نام";
            ////            return;
            ////        }
            ////    }//end cd_dvd

            ////    //magazine
            ////    if (cbtype.Text == "مجله")
            ////    {
            ////        magazineclass mc = new magazineclass();
            ////        dt = mc.Search(txtcode.Text);
            ////        if (dt.Rows.Count > 0)
            ////        {
            ////            txtname.Text = dt.Rows[0]["name"].ToString();
            ////            return;
            ////        }
            ////    }//end magazine

            ////    //report
            ////    if (cbtype.Text == "گزارش")
            ////    {
            ////        reportclass rc = new reportclass();
            ////        dt = rc.Search(txtcode.Text);

            ////        if (dt.Rows.Count > 0)
            ////        {
            ////            txtname.Text = dt.Rows[0]["title"].ToString();
            ////            return;
            ////        }
            ////    }//end report

            ////    //repertory
            ////    if (cbtype.Text == "کاتالوگ")
            ////    {
            ////        repertoryclass rc = new repertoryclass();
            ////        dt = rc.Search(txtcode.Text);

            ////        if (dt.Rows.Count > 0)
            ////        {
            ////            txtname.Text = dt.Rows[0]["subject"].ToString();
            ////            return;
            ////        }
            ////    }//end repertory


            ////    //map
            ////    if (cbtype.Text == "نقشه")
            ////    {
            ////        mapclass mc = new mapclass();
            ////        dt = mc.Search(txtcode.Text);

            ////        if (dt.Rows.Count > 0)
            ////        {
            ////            txtname.Text = dt.Rows[0]["project"].ToString();
            ////            return;
            ////        }
            ////    }//end map


            ////    //resume
            ////    if (cbtype.Text == "رزومه")
            ////    {
            ////        resumeclass rc = new resumeclass();
            ////        dt = rc.Search(txtcode.Text);
            ////        if (dt.Rows.Count > 0)
            ////        {
            ////            txtname.Text = "بدون نام";
            ////            return;
            ////        }
            ////    }//end resume


            ////    //zuncan
            ////    if (cbtype.Text == "زونکن")
            ////    {
            ////        zuncanclass zc = new zuncanclass();
            ////        dt = zc.Search(txtcode.Text);
            ////        if (dt.Rows.Count > 0)
            ////        {
            ////            txtname.Text = dt.Rows[0]["titles_in_zuncan"].ToString();
            ////            return;
            ////        }
            ////    }//end zuncan


            ////    //convention
            ////    if (cbtype.Text == "قرارداد")
            ////    {
            ////        conventionclass cc = new conventionclass();
            ////        dt = cc.Search(txtcode.Text);

            ////        if (dt.Rows.Count > 0)
            ////        {
            ////            txtname.Text = dt.Rows[0]["convention_subject"].ToString();
            ////            return;
            ////        }
            ////    }//end convention


        }

        private void groupBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void bailment_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //album
            if (cbtype.Text == "آلبوم")
            {
                albumclass ac = new albumclass();
                dt = ac.Search(txtcode2.Text);
                if (dt.Rows.Count > 0)
                {
                    txtname.Text = dt.Rows[0]["title"].ToString();
                    return;
                }
            }//end album

            //book
            if (cbtype.Text == "کتاب")
            {
                bookclass bc = new bookclass();
                dt = bc.Search(txtcode2.Text);

                if (dt.Rows.Count > 0)
                {
                    txtname.Text = dt.Rows[0]["title"].ToString();
                    return;
                }
            }//end book

            //cd_dvd
            if (cbtype.Text == "لوح فشرده (CD-DVD)")
            {
                cd_dvdclass cc = new cd_dvdclass();
                dt = cc.Search(txtcode2.Text);

                if (dt.Rows.Count > 0)
                {
                    txtname.Text = "بدون نام";
                    return;
                }
            }//end cd_dvd

            //magazine
            if (cbtype.Text == "مجله")
            {
                magazineclass mc = new magazineclass();
                dt = mc.Search(txtcode2.Text);
                if (dt.Rows.Count > 0)
                {
                    txtname.Text = dt.Rows[0]["name"].ToString();
                    return;
                }
            }//end magazine

            //report
            if (cbtype.Text == "گزارش")
            {
                reportclass rc = new reportclass();
                dt = rc.Search(txtcode2.Text);

                if (dt.Rows.Count > 0)
                {
                    txtname.Text = dt.Rows[0]["title"].ToString();
                    return;
                }
            }//end report

            //repertory
            if (cbtype.Text == "کاتالوگ")
            {
                repertoryclass rc = new repertoryclass();
                dt = rc.Search(txtcode2.Text);

                if (dt.Rows.Count > 0)
                {
                    txtname.Text = dt.Rows[0]["subject"].ToString();
                    return;
                }
            }//end repertory


            //map
            if (cbtype.Text == "نقشه")
            {
                mapclass mc = new mapclass();
                dt = mc.Search(txtcode2.Text);

                if (dt.Rows.Count > 0)
                {
                    txtname.Text = dt.Rows[0]["project"].ToString();
                    return;
                }
            }//end map


            //resume
            if (cbtype.Text == "رزومه")
            {
                resumeclass rc = new resumeclass();
                dt = rc.Search(txtcode2.Text);
                if (dt.Rows.Count > 0)
                {
                    txtname.Text = "بدون نام";
                    return;
                }
            }//end resume


            //zuncan
            if (cbtype.Text == "زونکن")
            {
                zuncanclass zc = new zuncanclass();
                dt = zc.Search(txtcode2.Text);
                if (dt.Rows.Count > 0)
                {
                    txtname.Text = dt.Rows[0]["titles_in_zuncan"].ToString();
                    return;
                }
            }//end zuncan


            //convention
            if (cbtype.Text == "قرارداد")
            {
                conventionclass cc = new conventionclass();
                dt = cc.Search(txtcode2.Text);

                if (dt.Rows.Count > 0)
                {
                    txtname.Text = dt.Rows[0]["convention_subject"].ToString();
                    return;
                }
            }//end convention
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            global g = new global();
            //album
            if (cbtype.Text == "آلبوم")
            {
                albumclass ac = new albumclass();
                dt = ac.Search(txtcode2.Text);

                //g.get_part_name_fk()
                if ((dt.Rows.Count > 0) && ((g.get_part_name_fk() == dt.Rows[0]["part_name_fk"].ToString()) || (g.get_IsAdmin())))
                {
                    txtname.Text = dt.Rows[0]["title"].ToString();
                    return;
                }
                else
                {
                    txtname.Text = "";
                }
            }//end album

            //book
            if (cbtype.Text == "کتاب")
            {
                bookclass bc = new bookclass();
                dt = bc.Search(txtcode2.Text);

                if ((dt.Rows.Count > 0) && ((g.get_part_name_fk() == dt.Rows[0]["part_name_fk"].ToString()) || (g.get_IsAdmin())))
                {
                    txtname.Text = dt.Rows[0]["title"].ToString();
                    return;
                }
                else
                {
                    txtname.Text = "";
                }
            }//end book

            //cd_dvd
            if (cbtype.Text == "لوح فشرده (CD-DVD)")
            {
                cd_dvdclass cc = new cd_dvdclass();
                dt = cc.Search(txtcode2.Text);

                if ((dt.Rows.Count > 0) && ((g.get_part_name_fk() == dt.Rows[0]["part_name_fk"].ToString()) || (g.get_IsAdmin())))
                {
                    txtname.Text = "بدون نام";
                    return;
                }
                else
                {
                    txtname.Text = "";
                }
            }//end cd_dvd

            //magazine
            if (cbtype.Text == "مجله")
            {
                magazineclass mc = new magazineclass();
                dt = mc.Search(txtcode2.Text);
                if ((dt.Rows.Count > 0) && ((g.get_part_name_fk() == dt.Rows[0]["part_name_fk"].ToString()) || (g.get_IsAdmin())))
                {
                    txtname.Text = dt.Rows[0]["name"].ToString();
                    return;
                }
                else
                {
                    txtname.Text = "";
                }
            }//end magazine

            //report
            if (cbtype.Text == "گزارش")
            {
                reportclass rc = new reportclass();
                dt = rc.Search(txtcode2.Text);

                if ((dt.Rows.Count > 0) && ((g.get_part_name_fk() == dt.Rows[0]["part_name_fk"].ToString()) || (g.get_IsAdmin())))
                {
                    txtname.Text = dt.Rows[0]["title"].ToString();
                    return;
                }
                else
                {
                    txtname.Text = "";
                }
            }//end report

            //repertory
            if (cbtype.Text == "کاتالوگ")
            {
                repertoryclass rc = new repertoryclass();
                dt = rc.Search(txtcode2.Text);

                if ((dt.Rows.Count > 0) && ((g.get_part_name_fk() == dt.Rows[0]["part_name_fk"].ToString()) || (g.get_IsAdmin())))
                {
                    txtname.Text = dt.Rows[0]["subject"].ToString();
                    return;
                }
                else
                {
                    txtname.Text = "";
                }
            }//end repertory


            //map
            if (cbtype.Text == "نقشه")
            {
                mapclass mc = new mapclass();
                dt = mc.Search(txtcode2.Text);

                if ((dt.Rows.Count > 0) && ((g.get_part_name_fk() == dt.Rows[0]["part_name_fk"].ToString()) || (g.get_IsAdmin())))
                {
                    txtname.Text = dt.Rows[0]["project"].ToString();
                    return;
                }
                else
                {
                    txtname.Text = "";
                }
            }//end map


            //resume
            if (cbtype.Text == "رزومه")
            {
                resumeclass rc = new resumeclass();
                dt = rc.Search(txtcode2.Text);
                if ((dt.Rows.Count > 0) && ((g.get_part_name_fk() == dt.Rows[0]["part_name_fk"].ToString()) || (g.get_IsAdmin())))
                {
                    txtname.Text = "بدون نام";
                    return;
                }
                else
                {
                    txtname.Text = "";
                }
            }//end resume


            //zuncan
            if (cbtype.Text == "زونکن")
            {
                zuncanclass zc = new zuncanclass();
                dt = zc.Search(txtcode2.Text);
                if ((dt.Rows.Count > 0) && ((g.get_part_name_fk() == dt.Rows[0]["part_name_fk"].ToString()) || (g.get_IsAdmin())))
                {
                    txtname.Text = dt.Rows[0]["titles_in_zuncan"].ToString();
                    return;
                }
                else
                {
                    txtname.Text = "";
                }
            }//end zuncan


            //convention
            if (cbtype.Text == "قرارداد")
            {
                conventionclass cc = new conventionclass();
                dt = cc.Search(txtcode2.Text);

                if ((dt.Rows.Count > 0) && ((g.get_part_name_fk() == dt.Rows[0]["part_name_fk"].ToString()) || (g.get_IsAdmin())))
                {
                    txtname.Text = dt.Rows[0]["convention_subject"].ToString();
                    return;
                }
                else
                {
                    txtname.Text = "";
                }
            }//end convention
        }


        private void bailment_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }//txt change

        private void Edit_Old_Bailment(string Old_type, string Old_id)
        {

            //album
            if (Old_type == "آلبوم")
            {
                albumclass ac = new albumclass();
                ac.Edit_bailmented(false, Old_id);
            }
            //book
            if (Old_type == "کتاب")
            {
                bookclass bc = new bookclass();

                bc.Edit_bailmented(false, Old_id);

            }//end book

            //cd_dvd
            if (Old_type == "لوح فشرده (CD-DVD)")
            {
                cd_dvdclass cc = new cd_dvdclass();

                cc.Edit_bailmented(false, Old_id);

            }//end cd_dvd

            //magazine
            if (Old_type == "مجله")
            {
                magazineclass mc = new magazineclass();

                mc.Edit_bailmented(false, Old_id);


            }//end magazine

            //report
            if (Old_type == "گزارش")
            {
                reportclass rc = new reportclass();

                rc.Edit_bailmented(false, Old_id);

            }//end report

            //repertory
            if (Old_type == "کاتالوگ")
            {
                repertoryclass rc = new repertoryclass();

                rc.Edit_bailmented(false, Old_id);


            }//end repertory


            //map
            if (Old_type == "نقشه")
            {
                mapclass mc = new mapclass();

                mc.Edit_bailmented(false, Old_id);

            }//end map


            //resume
            if (Old_type == "رزومه")
            {
                resumeclass rc = new resumeclass();
                rc.Edit_bailmented(false, Old_id);
            }//end resume


            //zuncan
            if (Old_type == "زونکن")
            {
                zuncanclass zc = new zuncanclass();
                zc.Edit_bailmented(false, Old_id);
            }//end zuncan


            //convention
            if (Old_type == "قرارداد")
            {
                conventionclass cc = new conventionclass();

                cc.Edit_bailmented(false, Old_id);
            }//end convention

        }

    }


}

 