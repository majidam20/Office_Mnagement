using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class zuncan : Form
    {
        public type_mode.mode mode;
        public zuncan()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("لطفا شماره را وارد نماييد");
                txtid.Focus();
                return;
            }

            if (txttitle.Text == "")
            {
                MessageBox.Show("لطفا عناوین موجود در زونکن را وارد نماييد");
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

            zuncanclass zc = new zuncanclass();
            DataTable dt = new DataTable();

            if (mode == type_mode.mode.edit)
            {
                zc.Edit(txttitle.Text, txtplace.Text, txtdescribe.Text,txtid.Text);
                MessageBox.Show("!ویرایش انجام شد ");
                this.Close();
                
            }
            else if (mode == type_mode.mode.insert)
            {

                dt = zc.Search(txtid.Text);

                if (dt.Rows.Count == 0)
                {
                    zc.Add(txtid.Text, txttitle.Text, txtplace.Text, txtdescribe.Text,false);

                    DialogResult dr;
                    dr = MessageBox.Show("!داده ها ثبت شد", "ثبت", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        txtid.Text = "";
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
            if (e.KeyCode == Keys.Enter)
                txttitle.Focus();
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

        private void zuncan_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txttitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}