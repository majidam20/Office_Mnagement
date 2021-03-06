using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class part : Form
    {
        public type_mode.mode mode;

        public part()
        {
            InitializeComponent();
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("!نام بخش وارد نشده است");
                return;
            }

            partsclass pc = new partsclass();
            DataTable dt = new DataTable();

            //edit
            if (mode == type_mode.mode.edit)
            {
                dt = pc.Search(txtname.Text);

                string part_name = dt.Rows[0]["part_name"].ToString();
                string MessTitle = "        !محدود کردن این بخش امکان پذیر نیست " + "\r\n" + "        :  در جدول(های)زیر استفاده شده است " + "\r\n" + "\r\n";
                string mess="";
                
                    //album
                    if (!chalbum.Checked)
                    {
                        albumclass ac = new albumclass();
                        dt = ac.Search_partname_fk(part_name);

                        if (dt.Rows.Count > 0)
                        {
                            mess += "                                                       آلبوم" + "\r\n";
                        }
                    }

                    //book
                    if (!chbook.Checked)
                    {
                        bookclass bc = new bookclass();
                        dt = bc.Search_partname_fk(part_name);
                        if (dt.Rows.Count > 0)
                        {
                            mess += "                                                  کتاب " + "\r\n";
                        }
                    }

                    //cd_dvd
                    if (!chloh11.Checked)
                    {
                        cd_dvdclass cc = new cd_dvdclass();
                        dt = cc.Search_partname_fk(part_name);
                        if (dt.Rows.Count > 0)
                        {
                            mess += "                                              لوح فشرده" + "\r\n";
                        }
                    }
                 
                 //magazine
                if(!chmagazine.Checked)
                {
                    magazineclass mc = new magazineclass();
                    dt = mc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {
                        mess += "                                                       مجله" + "\r\n";
                    }
                }
                if(!chreport.Checked)
                {
                    //report
                    reportclass rc = new reportclass();
                    dt = rc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {
                        mess += "                                                     گزارش" + "\r\n";
                    }
                }
                if(!chrepotery.Checked)
                {
                    //repertory
                    repertoryclass rrc = new repertoryclass();
                    dt = rrc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {
                        mess += "                                                    کاتالوگ" + "\r\n";
                    }
                }
                //map
                if(!chmap.Checked)
                {
                    mapclass mmc = new mapclass();
                    dt = mmc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {
                        mess += "                                                     نقشه" + "\r\n";
                    }
                }

                //resumeh
                if(!chrezumeh.Checked)
                {
                    resumeclass rrrc = new resumeclass();
                    dt = rrrc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {
                        mess += "                                                      رزومه" + "\r\n";   
                    }
                }
                    //zuncan
                if(!chzuncan.Checked)
                {
                    zuncanclass zc = new zuncanclass();
                    dt = zc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {
                        mess += "                                                      زونکن" + "\r\n";
                    }
                }   
                    //convention
                if(!chcontention.Checked)
                {
                    conventionclass ccc = new conventionclass();
                    dt = ccc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {
                        mess += "                                                     قرارداد" + "\r\n";
                    }
                }
                    //MessageBox.Show(mess,"                          حذف بخش");

                    if (mess.Length > 0)
                    {
                        mess = MessTitle + mess;
                        MessageBox.Show(mess, "حذف بخش",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
                        return;
                    }

                    pc.Edit(chalbum.Checked, chbook.Checked, chloh11.Checked, chmagazine.Checked, chreport.Checked, chrepotery.Checked, chmap.Checked, chrezumeh.Checked, chzuncan.Checked, chcontention.Checked, chadmin.Checked, txtname.Text);
                    MessageBox.Show("!ویرایش انجام شد ");
                    this.Close();

            }//end edit



            else if (mode == type_mode.mode.insert)
            {
                dt = pc.Search(txtname.Text);

                if (dt.Rows.Count == 0)
                {

                    pc.Add(txtname.Text, chalbum.Checked, chbook.Checked, chloh11.Checked, chmagazine.Checked, chreport.Checked, chrepotery.Checked, chmap.Checked, chrezumeh.Checked, chzuncan.Checked, chcontention.Checked, chadmin.Checked);

                    DialogResult dr;
                    dr = MessageBox.Show("!داده ها ثبت شد", "ثبت", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        txtname.Text = "";
                        chalbum.Checked = false;
                        chloh11.Checked = false;
                        chreport.Checked = false;
                        chmap.Checked = false;
                        chzuncan.Checked = false;
                        chbook.Checked = false;
                        chmagazine.Checked = false;
                        chrepotery.Checked = false;
                        chrezumeh.Checked = false;
                        chcontention.Checked = false;
                        chadmin.Checked = false;


                        return;
                    }

                    else
                    {
                        MessageBox.Show("! قبلا مشخصاتی با این شماره ، ثبت شده است", " تذکر :فیلد شماره تکراری است");

                        txtname.Focus();
                    }

                }

                //clean form 

            }
        }


        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                chalbum.Focus();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void part_Load(object sender, EventArgs e)
        {

        }

        private void chalbum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }




    }
}