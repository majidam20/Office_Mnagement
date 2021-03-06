using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class parts_Main : Form
    {
        public int SearchFlag = 0;
        public parts_Main()
        {
            InitializeComponent();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            partsclass pc = new partsclass();
            dataGridView1.DataSource = pc.search_grid(); 
            SearchFlag=0;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            UIL.part f = new UIL.part();
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
            if (((bool)(dt.Rows[0]["parts"])) == true)
            Reload();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            partsclass pc = new partsclass();
            DataTable dt = new DataTable();
            part f = new part();
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

                dt = pc.Search(id);

                if (dt.Rows.Count > 0)
                {
                    
                    f.txtname.Text = dt.Rows[0]["part_name"].ToString();
                    f.chalbum.Checked = (bool)dt.Rows[0]["album"];
                    f.chbook.Checked =(bool) dt.Rows[0]["book"];
                    f.chloh11.Checked = (bool)dt.Rows[0]["cd_dvd"];
                    f.chmagazine.Checked = (bool)dt.Rows[0]["magazine"];
                    f.chreport.Checked = (bool)dt.Rows[0]["report"];
                    f.chrepotery.Checked = (bool)dt.Rows[0]["repertory"];
                    f.chmap.Checked = (bool)dt.Rows[0]["map"];

                    f.chrezumeh.Checked = (bool)dt.Rows[0]["resume"];
                    f.chzuncan.Checked = (bool)dt.Rows[0]["zuncan"];
                    f.chcontention.Checked = (bool)dt.Rows[0]["convention"];
                    f.chadmin.Checked = (bool)dt.Rows[0]["admin"];
                    
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
            partsclass pc = new partsclass();
            DataTable dt = new DataTable();
            part f = new part();
            f.FormClosed+=new FormClosedEventHandler(f_FormClosed);
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
                f.txtname.Enabled = false;
                string id = dataGridView1[0, cr].Value.ToString();

                dt = pc.Search(id);

                if (dt.Rows.Count > 0)
                {
                    f.txtname.Text = dt.Rows[0]["part_name"].ToString();
                    f.chalbum.Checked = (bool)dt.Rows[0]["album"];
                    f.chbook.Checked = (bool)dt.Rows[0]["book"];
                    f.chloh11.Checked = (bool)dt.Rows[0]["cd_dvd"];
                    f.chmagazine.Checked = (bool)dt.Rows[0]["magazine"];
                    f.chreport.Checked = (bool)dt.Rows[0]["report"];
                    f.chrepotery.Checked = (bool)dt.Rows[0]["repertory"];
                    f.chmap.Checked = (bool)dt.Rows[0]["map"];

                    f.chrezumeh.Checked = (bool)dt.Rows[0]["resume"];
                    f.chzuncan.Checked = (bool)dt.Rows[0]["zuncan"];
                    f.chcontention.Checked = (bool)dt.Rows[0]["convention"];
                    f.chadmin.Checked = (bool)dt.Rows[0]["admin"];

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
            partsclass pc = new partsclass();
            DataTable dt = new DataTable();
            if ((dataGridView1.Rows.Count == 0) || (dataGridView1.CurrentRow.Index == -1))
            {
                MessageBox.Show("سطری انتخاب نشده است");
                return;
            }

            string MessTitle = "        ! حذف این بخش امکان پذیر نیست " + "\r\n" + " : در بخش(های)زیر استفاده شده است " + "\r\n" + "\r\n";
            string mess = "";

            int cr = dataGridView1.CurrentRow.Index;
            if (cr >= 0)
            {
                
                string id = dataGridView1[0, cr].Value.ToString();
                dt = pc.Search(id);
                //if (dt.Rows.Count > 0)
                //{
                    string part_name = dt.Rows[0]["part_name"].ToString();
                   
                    //album
                    albumclass ac = new albumclass();
                    dt = ac.Search_partname_fk(part_name);
                    
                    if (dt.Rows.Count > 0)
                    {
                        mess += "                                                 آلبوم" + "\r\n";
                    }
                  
                    //book
                    bookclass bc = new bookclass();
                    dt = bc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {
                        mess += "                                                 کتاب "+"\r\n";

                    }

                    //cd_dvd
                    cd_dvdclass cc = new cd_dvdclass();
                    dt = cc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {
                        mess += "                                          لوح فشرده" + "\r\n";   

                    }

                    //magazine
                    magazineclass mc = new magazineclass();
                    dt = mc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {

                        mess += "                                                  مجله" + "\r\n";

                    }

                    //report
                    reportclass rc = new reportclass();
                    dt = rc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {

                        mess += "                                                گزارش" + "\r\n";

                    }

                    //repertory
                    repertoryclass rrc = new repertoryclass();
                    dt = rrc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {

                        mess += "                                              کاتالوگ" + "\r\n";

                    }

                    //map
                    mapclass mmc = new mapclass();
                    dt = mmc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {

                        mess += "                                                 نقشه" + "\r\n";

                    }

                    //resumeh
                    resumeclass rrrc = new resumeclass();
                    dt = rrrc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {

                        mess += "                                                  رزومه" + "\r\n";   
                         
                    }

                    //zuncan
                    zuncanclass zc = new zuncanclass();
                    dt = zc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {

                        mess += "                                                  زونکن" + "\r\n";

                    }
                    
                    //convention
                    conventionclass ccc = new conventionclass();
                    dt = ccc.Search_partname_fk(part_name);
                    if (dt.Rows.Count > 0)
                    {

                        mess += "                                                قرارداد" + "\r\n";

                    }

                    if(mess.Length > 0)
                    {
                        mess = MessTitle + mess;
                        MessageBox.Show(mess, "حذف بخش", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                        return;
                    }

                   // }//dt count
                    //else 
                    //{
                        DialogResult dr;
                        dr = MessageBox.Show("آیا سطر انتخاب شده حذف گردد؟", "حذف سطر", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            pc.Delete(id);
                            Reload();

                        }
                        if (dr == DialogResult.No)
                        {
                            dataGridView1.Focus();
                        }
                    //}
               

            

            }//cr
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

        private void btnsearch_Click_1(object sender, EventArgs e)
        {            
            partsclass pc = new partsclass();
            DataTable dt = new DataTable();
            dt = pc.part_Search(txtsearch.Text);
            dataGridView1.DataSource = dt;
            SearchFlag = 1;
        }

        private void parts_Main_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            label18.Text = "تعداد سطر :" + dataGridView1.Rows.Count.ToString();   
        }

        private void parts_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.F5 == e.KeyCode)
                Reload();
        }
        private void Reload()
        {
            if (SearchFlag == 0)
            {
                btnrefresh_Click(null, null);
            }
            else if (SearchFlag == 1)
            {
                btnsearch_Click_1(null, null);
            }
        }

      
    }
}