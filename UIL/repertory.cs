using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class repertory : Form
    {
        public type_mode.mode mode;
        public repertory()
        {
            InitializeComponent();
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            repertoryclass rec = new repertoryclass();
            DataTable dt = new DataTable();

            txtday.Text = string.Format("{0,2:G}", txtday.Text);
            txtday.Text = txtday.Text.Replace(" ", "0");

            txtmonth.Text = string.Format("{0,2:G}", txtmonth.Text);
            txtmonth.Text = txtmonth.Text.Replace(" ", "0");

            txtyear.Text = string.Format("{0,4:G}", txtyear.Text);
            txtyear.Text = txtyear.Text.Replace(" ", "0");

            if (txtid.Text == "")
            {
                MessageBox.Show("لطفا شماره را وارد نماييد");
                txtid.Focus();
                return;
            }


            if (txtsubject.Text == "")
            {
                MessageBox.Show("لطفا موضوع را وارد نماييد");
                txtsubject.Focus();
                return;
            }

            if (txtprovider.Text == "")
            {
                //MessageBox.Show("لطفا شرکت تولید کننده را وارد نماييد");
                txtprovider.Text = " ";
                //return;
            }
            if ((txtday.Text == "") || (Convert.ToInt32(txtday.Text) == 0))
            {
                MessageBox.Show("لطفا روز را وارد نماييد");
                txtday.Text=" ";
               return;
            }
            if ((txtmonth.Text == "") || (Convert.ToInt32(txtmonth.Text) == 0))
            {
               MessageBox.Show("لطفا ماه را وارد نماييد");
                txtmonth.Text = " ";
               return;
            }
            if ((txtyear.Text == "") || (Convert.ToInt32(txtyear.Text) == 0))
            {
               MessageBox.Show("لطفا سال را وارد نماييد");
                txtyear.Text = " ";
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
                rec.Edit(txtsubject.Text, txtprovider.Text, txtyear.Text + "/" + txtmonth.Text + "/" + txtday.Text, txtplace.Text, txtdescribe.Text, txtid.Text);

                MessageBox.Show("!ویرایش انجام شد ");
                this.Close();
            }

            else if (mode == type_mode.mode.insert)
            {

                dt = rec.Search(txtid.Text);

                if (dt.Rows.Count == 0)
                {

                    rec.Add(txtid.Text, txtsubject.Text, txtprovider.Text, txtyear.Text + "/" + txtmonth.Text + "/" + txtday.Text, txtplace.Text, txtdescribe.Text,false);

                    DialogResult dr;
                    dr = MessageBox.Show("!داده ها ثبت شد", "ثبت", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        txtid.Text = "";
                        txtsubject.Text = "";
                        txtprovider.Text = "";
                        txtday.Text = "";
                        txtmonth.Text = "";
                        txtyear.Text = "";
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
                txtsubject.Focus();
        }

        private void txtsubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtprovider.Focus();
        }

        private void txtprovider_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtday.Focus();
        }

        private void txtday_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtmonth.Focus();

        }

        private void txtmonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtyear.Focus();

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
                btncancel.Focus();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtday_Leave(object sender, EventArgs e)
        {

            if ((txtday.Text.Length > 0) && ((bool)(Convert.ToInt32(txtday.Text) > 31) || (bool)(Convert.ToInt32(txtday.Text) == 00)))
            {
                MessageBox.Show("!لطفا عدد مربوط به روز را تصحیح نمایید ");
                txtday.Focus();
                return;
            }
        }

        private void txtmonth_Leave(object sender, EventArgs e)
        {

            if ((txtmonth.Text.Length > 0) && ((bool)(Convert.ToInt32(txtmonth.Text) > 12) || (bool)(Convert.ToInt32(txtmonth.Text) == 00)))
            {
                MessageBox.Show("!لطفا عدد مربوط به ماه را تصحیح نمایید ");
                txtmonth.Focus();
                return;
            }
        }

        private void txtyear_Leave(object sender, EventArgs e)
        {
            if ((txtyear.Text.Length > 0) && (Convert.ToInt32(txtyear.Text) < 1300))
            {
                MessageBox.Show("!لطفا عدد مربوط به سال را تصحیح نمایید ");
                txtyear.Focus();
                return;
            }
        }

        private void txtday_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;

            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;

        }

        private void txtmonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;

            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;

        }

        private void txtyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int i = e.KeyChar;

            if (i >= 48 && i <= 57 || i == 8)
                e.Handled = false;

        }

        private void txtprovider_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmonth_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtyear_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtplace.Focus();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}