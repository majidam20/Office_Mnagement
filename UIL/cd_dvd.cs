using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class cd_dvd : Form
    {
        public type_mode.mode mode;
        public cd_dvd()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            cd_dvdclass c_d_c = new cd_dvdclass();
            DataTable dt = new DataTable();

            if (txtid.Text == "")
            {
                MessageBox.Show("لطفا شماره را وارد نماييد");
                txtid.Focus();
                return;
            }

            if (ch_cd.Checked == false && ch_dvd.Checked==false)
            {
                MessageBox.Show("لطفا نوع لوح فشرده را انتخاب نماييد");
                ch_cd.Focus();
                return;
            }
            if ( ch_dvd.Checked == false && ch_cd.Checked==false)
            {
                MessageBox.Show("لطفا نوع لوح فشرده را انتخاب نماييد");
                ch_cd.Focus();
                return;
            }
         
            if (txttitle.Text == "")
            {
                MessageBox.Show("لطفا عناوین موجود در لوح فشرده را وارد نماييد");
                txttitle.Focus();
                return;
            }
            if (txtplace.Text == "")
            {
                //MessageBox.Show("لطفا محل نگهداری را وارد نماييد");
                txtplace.Text = " ";
                //return;
            }
           
            if (txtdescribe.Text == "")
            {
                //MessageBox.Show("لطفا سایر توضیحات را وارد نماييد");
                txtdescribe.Text = " ";
                //return;
            }


            if (mode == type_mode.mode.edit)
            {
                 c_d_c.Edit(ch_cd.Checked, ch_dvd.Checked, txttitle.Text, txtplace.Text, txtdescribe.Text,txtid.Text);
                 MessageBox.Show("!ویرایش انجام شد ");
                this.Close();
            }

            else if(mode==type_mode.mode.insert)
            {

            dt = c_d_c.Search(txtid.Text);
            if (dt.Rows.Count == 0)
            {             
                c_d_c.Add(txtid.Text, ch_cd.Checked, ch_dvd.Checked,txttitle.Text, txtplace.Text, txtdescribe.Text, false);
                DialogResult dr;
                dr = MessageBox.Show("!داده ها ثبت شد", "ثبت", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    txtid.Text = "";
                    ch_cd.Checked=false;
                    ch_dvd.Checked=false;
                    txttitle.Text = "";
                    txtplace.Text = "";
                    txtdescribe.Text = "";
                }
            }
            else
            {
                MessageBox.Show("! قبلا مشخصاتی با این شماره ، ثبت شده است", " تذکر :فیلد شماره تکراری است");
               txtid.Focus();
            }
        }
            }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                ch_cd.Focus();
            
        }

        private void ch_cd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txttitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtplace.Focus();
        }

        private void txtplace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtdescribe.Focus();
        }

        private void btnsave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                btncancel.Focus();
        }

        private void btncancel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                btnsave.Focus();
        }

         private void ch_cd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txttitle.Focus();
        }

        private void ch_dvd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txttitle.Focus();
               
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CD_DVD_Load(object sender, EventArgs e)
        {

        }

        private void txtplace_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}