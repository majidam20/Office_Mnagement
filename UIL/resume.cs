using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class resume : Form
    {
        public type_mode.mode mode;
        public resume()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        //bbbbbbbbbbbbbbtttttttttttnnnnnnnnnnsssssssaaaaavvvvvvveeeeeeee
        private void btnsave_Click(object sender, EventArgs e)
        {

            if (txtid.Text == "")
            {
                MessageBox.Show("لطفا شماره را وارد نماييد");
                txtid.Focus();
                return;
            }

            if (txtname.Text == "")
            {
                MessageBox.Show("لطفا نام درخواست کننده را وارد نماييد");
                txtname.Focus();
                return;
            }

            if (txttype.Text == "")
            {
                MessageBox.Show("لطفا نوع کار را وارد نماييد");
                txttype.Focus();
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


            //code asli resume         
            resumeclass rc = new resumeclass();
            DataTable dt = new DataTable();


            if (mode == type_mode.mode.edit)
            {
                rc.Edit(txtname.Text, txttype.Text, txtplace.Text, txtdescribe.Text,txtid.Text);
                MessageBox.Show("!ویرایش انجام شد");
                this.Close();
                
            }
            else if (mode == type_mode.mode.insert)
            {

                dt = rc.Search(txtid.Text);

                if (dt.Rows.Count == 0)
                {
                    rc.Add(txtid.Text, txtname.Text, txttype.Text, txtplace.Text, txtdescribe.Text,false);

                    DialogResult dr;
                    dr = MessageBox.Show("!داده ها ثبت شد", "ثبت", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        txtid.Text = "";
                        txtname.Text = "";
                        txttype.Text = "";
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
            if (e.KeyCode == Keys.Enter)
                txtname.Focus();

        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txttype.Focus();

        }

        private void txttype_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttype_KeyDown(object sender, KeyEventArgs e)
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

         private void resume_Load(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

    }
}