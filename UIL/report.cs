using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class report : Form
    {
        public type_mode.mode mode;
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            reportclass rc = new reportclass();
            DataTable dt = new DataTable();

            if (txtid.Text == "")
            {
                MessageBox.Show("لطفا شماره را وارد نماييد");
                txtid.Focus();
                return;
            }

            if (txttitle.Text == "")
            {
                MessageBox.Show("لطفا عنوان را وارد نماييد");
                txttitle.Focus();
                return;
            }
            if (txtsubject.Text == "")
            {
                //MessageBox.Show("لطفا موضوع را وارد نماييد");
                txtsubject.Text = " ";
                //return;
            }

            if (txtname_provider.Text == "")
            {
                //MessageBox.Show("لطفا تهیه کننده را وارد نماييد");
                txtname_provider.Text = " ";
                //return;
            }
            if (txtplace.Text == "")
            {
               // MessageBox.Show("لطفا محل نگهداری را وارد نماييد");
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
                rc.Edit(txttitle.Text, txtsubject.Text, txtname_provider.Text, txtplace.Text, txtdescribe.Text,txtid.Text);
                MessageBox.Show("!ویرایش انجام شد ");
                this.Close();
            }

            else if (mode == type_mode.mode.insert)
            {

                dt = rc.Search(txtid.Text);

                if (dt.Rows.Count == 0)
                {

                    rc.Add(txtid.Text, txttitle.Text, txtsubject.Text, txtname_provider.Text, txtplace.Text, txtdescribe.Text, false);

                    DialogResult dr;
                    dr = MessageBox.Show("!داده ها ثبت شد", "ثبت", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        txtid.Text = "";
                        txttitle.Text = "";
                        txtsubject.Text = "";
                        txtname_provider.Text = "";
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
                txttitle.Focus();
        }

        private void txttitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtsubject.Focus();
        }

        private void txtsubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtname_provider.Focus();
        }

        private void txtname_provider_KeyDown(object sender, KeyEventArgs e)
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

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
            //int i = e.KeyChar;

            //if (i >= 48 && i <= 57 || i == 8)
            //    e.Handled = false;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtplace_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}