using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class book : Form
    {
        public type_mode.mode mode;
        public book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            if (txtname_writer.Text == "")
            {
                MessageBox.Show("لطفا نام نویسنده را وارد نماييد");
                txtname_writer.Focus();
                return;
            }
            if (txtname_adverties.Text == "")
            {
               // MessageBox.Show("لطفا نام انتشارات را وارد نماييد");
                txtname_adverties.Text = " ";
                //return;
            }
            if (txtplace.Text == "")
            {
                //MessageBox.Show("لطفا محل نگهداری را وارد نماييد");
                txtplace.Text = " ";
               // return;
            }

            if (txtdescribe.Text == "")
            {
                //MessageBox.Show("لطفا سایر توضیحات را وارد نماييد");
                txtdescribe.Text = " ";
                //return;
            }

            bookclass bc = new bookclass();
            DataTable dt = new DataTable();
            

            if (mode == type_mode.mode.edit)
            {
                bc.Edit(txttitle.Text, txtname_writer.Text, txtname_adverties.Text, txtplace.Text, txtdescribe.Text, txtid.Text);
                MessageBox.Show("!ویرایش انجام شد ");
                this.Close();
               
            }
            else if (mode == type_mode.mode.insert)
            {

                dt = bc.Search(txtid.Text);

                if (dt.Rows.Count == 0)
                {
                    bc.Add(txtid.Text, txttitle.Text, txtname_writer.Text, txtname_adverties.Text, txtplace.Text, txtdescribe.Text, false);

                    DialogResult dr;
                    dr = MessageBox.Show("!داده ها ثبت شد", "ثبت", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        book_Main f = new book_Main();
                        f.Main_book_Load(null, null);
                        txtid.Text = "";
                        txttitle.Text = "";
                        txtname_writer.Text = "";
                        txtname_adverties.Text = "";
                        txtplace.Text = "";
                        txtdescribe.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("! قبلا مشخصاتی با این شماره ، ثبت شده است", " تذکر :فیلد شماره تکراری است");
                    //  txtid.Text = "";
                    txtid.Focus();
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txttitle.Focus();
        }

        private void txttitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtname_writer.Focus();
        }

        private void txtname_writer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtname_adverties.Focus();
        }

        private void txtname_adverties_KeyDown(object sender, KeyEventArgs e)
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

        private void book_Load(object sender, EventArgs e)
        {

        }

        private void txttitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdescribe_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}