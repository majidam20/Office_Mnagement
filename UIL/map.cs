using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class map : Form
    {
        public type_mode.mode mode;
        public map()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (txtid.Text == "")
            {
                MessageBox.Show("لطفا شماره را وارد نماييد");
                txtid.Focus();
                return;
            }

            if (txtproject.Text == "")
            {
                MessageBox.Show("لطفا پروژه را وارد نماييد");
                txtproject.Focus();
                return;
            }

            if (txtsize.Text == "")
            {
               // MessageBox.Show("لطفا ابعاد را وارد نماييد");
                txtsize.Text = " ";
                //return;
            }

            if (txtadviser.Text == "")
            {
                MessageBox.Show("لطفا مشاور را وارد نماييد");
                txtadviser.Focus();
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
               // MessageBox.Show("لطفا سایر توضیحات را وارد نماييد");
                txtdescribe.Text = " ";
                //return;
            }

            mapclass mc = new mapclass();
            DataTable dt = new DataTable();

            if (mode == type_mode.mode.edit)
            {
                mc.Edit(txtproject.Text, txtsize.Text, txtadviser.Text, txtproject.Text, txtdescribe.Text,txtid.Text);
                MessageBox.Show("!ویرایش انجام شد ");
                this.Close();
                
            }


            else if (mode == type_mode.mode.insert)
            {
                dt = mc.Search(txtid.Text);

                if (dt.Rows.Count == 0)
                {
                    mc.Add(txtid.Text, txtproject.Text, txtsize.Text, txtadviser.Text, txtplace.Text, txtdescribe.Text, false);

                    DialogResult dr;
                    dr = MessageBox.Show("!داده ها ثبت شد", "ثبت", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        txtid.Text = "";
                        txtsize.Text = "";
                        txtproject.Text = "";
                        txtadviser.Text = "";
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
          
        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtproject.Focus();
        }

        private void txtproject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtsize.Focus();
        }

        private void txtsize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtadviser.Focus();
        }

        private void txtadviser_KeyDown(object sender, KeyEventArgs e)
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
                button2.Focus();
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                btnsave.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
            //int i = e.KeyChar;
          
            //if (i >= 48 && i <= 57 || i == 8)
            //    e.Handled = false;

        }

        private void txtsize_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
            //int i = e.KeyChar;
           
            //if (i >= 48 && i <= 57 || i == 8)
            //    e.Handled = false;
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void map_Load(object sender, EventArgs e)
        {

        }

        private void txtsize_TextChanged(object sender, EventArgs e)
        {

        }


    }
}