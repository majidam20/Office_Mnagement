using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class login : Form
    {
        public string partcode;
        public login()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            global g = new global();
            g.set(txtServAdd.Text,Txt_db_uid.Text,Txt_db_pass.Text);

            if (txtServAdd.Text=="")
            {
                MessageBox.Show("لطفا آدرس سرور را وارد نمایید");
                txtServAdd.Focus();
                return;
            }

            if (Txt_db_uid.Text == "")
            {
                MessageBox.Show("لطفا کاربری کاربر پایگاه داده را وارد نمایید");
                Txt_db_uid.Focus();
                return;
            }

            if (Txt_db_pass.Text == "")
            {
                MessageBox.Show("لطفا رمز عبور کاربر پایگاه داده را وارد نمایید");
                Txt_db_pass.Focus();
                return;
            }
            
            if (txtuid.Text == "")
            {
                MessageBox.Show("لطفا نام کاربری را وارد نمایید");
                txtuid.Focus();
                return;
            }
            if (txtupass.Text == "")
            {
                MessageBox.Show("لطفا رمز عبور را وارد نمایید");
                txtupass.Focus();
                return;
            }
            
            LDBclass LDB = new LDBclass();
            
            LDB.Edit(txtServAdd.Text, Txt_db_uid.Text, Txt_db_pass.Text);

            try
            {


                DataTable dt = new DataTable();
                usersclass uc = new usersclass();
                partsclass pc = new partsclass();

                dt = uc.Search(txtuid.Text);
                if (dt.Rows.Count > 0 && dt.Rows[0]["upass"].ToString() == txtupass.Text)
                {
                    main f = new main();

                    string p_name = dt.Rows[0]["part_name_fk"].ToString();

                    /////////////////////user_id for main
                    string user_id = dt.Rows[0]["uid"].ToString();
                    g.set_user_id(user_id);


                    dt = pc.Search("part_name", p_name);

                    f.MenuItem_album.Enabled = (bool)dt.Rows[0]["album"];
                    f.MenuItem_Book.Enabled = (bool)dt.Rows[0]["book"];
                    f.MenuItem_CD_DVD.Enabled = (bool)dt.Rows[0]["CD_DVD"];
                    f.MenuItem_Magazine.Enabled = (bool)dt.Rows[0]["magazine"];
                    f.MenuItem_Report.Enabled = (bool)dt.Rows[0]["report"];
                    f.MenuItem_repertory.Enabled = (bool)dt.Rows[0]["repertory"];
                    f.MenuItem_Map.Enabled = (bool)dt.Rows[0]["map"];
                    f.MenuItem_resume.Enabled = (bool)dt.Rows[0]["resume"];
                    f.MenuItem_zuncan.Enabled = (bool)dt.Rows[0]["zuncan"];
                    f.MenuItem_convention.Enabled = (bool)dt.Rows[0]["convention"];

                   
                    /////////////////////set part_name
                    g.set_part_name(p_name);
                    g.set_IsAdmin((bool)dt.Rows[0]["admin"]);

                    f.مدیریتسیستمToolStripMenuItem2.Enabled = (bool)dt.Rows[0]["admin"];
                    f.کاربToolStripMenuItem.Enabled = (bool)dt.Rows[0]["admin"];
                    f.بخشهایسازمانToolStripMenuItem.Enabled = (bool)dt.Rows[0]["admin"];

                    //cbtype bailment  && ret
                    g.set_album((bool)dt.Rows[0]["album"]);
                    g.set_book((bool)dt.Rows[0]["book"]);
                    g.set_cd_dvd((bool)dt.Rows[0]["CD_DVD"]);
                    g.set_magazine((bool)dt.Rows[0]["magazine"]);
                    g.set_report((bool)dt.Rows[0]["report"]);
                    g.set_repertory((bool)dt.Rows[0]["repertory"]);
                    g.set_map((bool)dt.Rows[0]["map"]);
                    g.set_resume((bool)dt.Rows[0]["resume"]);
                    g.set_zuncan((bool)dt.Rows[0]["zuncan"]);
                    g.set_convention((bool)dt.Rows[0]["convention"]);

                    f.Show();
                    this.Visible = false;


                }
                else
                {
                    MessageBox.Show("نام کاربری و/یا رمز عبور اشتباه وارد شده است");
                }

            }
            catch
            {
                MessageBox.Show("!ارتباط با پایگاه داده امکان پذیر نمی باشد،لطفا تنظیمات سرور را بررسی نمایید");
            }
}

        private void login_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo c = new System.Globalization.CultureInfo("en-US");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(c);

            LDBclass LDB = new LDBclass();
            DataTable dt = new DataTable();
            dt = LDB.Search();
            if (dt.Columns.Count > 0)
            {
                
                txtServAdd.Text = dt.Rows[0]["ServerAddress"].ToString();
                Txt_db_uid.Text = dt.Rows[0]["DbUserID"].ToString();
                Txt_db_pass.Text = dt.Rows[0]["DbUserPass"].ToString();
            }
        }

        private void txtuid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode==Keys.Down)
                txtupass.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtupass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
                btnsubmit_Click(null, null);
            if (e.KeyCode == Keys.Up)
                txtuid.Focus();
            if (e.KeyCode == Keys.Down)
                btnsubmit.Focus();
        }

        private void btnsubmit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                btncancel.Focus();
        }

        private void btncancel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                btnsubmit.Focus();
        }

        private void textServAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuid_TextChanged(object sender, EventArgs e)
        {

        }
        

          
    }
}