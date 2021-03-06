using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive.UIL
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }
        public type_mode.mode mode;
        public string part_name_fk;
        private void btnsave_Click(object sender, EventArgs e)
        {
            usersclass uc = new usersclass();

            DataTable dt = new DataTable();

            if (txtname.Text == "")
            {
                MessageBox.Show("لطفا نام را وارد نماييد");
                txtname.Focus();
                return;
            }

            if (txtfamily.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگي را وارد نماييد");
                txtfamily.Focus();
                return;
            }

            if (txtuid.Text == "")
            {
                MessageBox.Show("لطفا نام کاربري را وارد نماييد");
                txtuid.Focus();
                return;
            }

            if (txtupass.Text == "")
            {
                MessageBox.Show("لطفا رمزعبور را وارد نماييد");
                txtupass.Focus();
                return;
            }

            if (cbpartname.Text == "")
            {
                MessageBox.Show("لطفا نام بخش را وارد نماييد");
                cbpartname.Focus();
                return;
            }

            if (mode == type_mode.mode.edit)
            {
                uc.Edit(txtname.Text , txtfamily.Text, txtupass.Text, cbpartname.Text, txtuid.Text);
                MessageBox.Show("!ویرایش انجام شد ");
                this.Close();

            }
            else if (mode == type_mode.mode.insert)
            {
                dt = uc.Search(txtuid.Text);

                if (dt.Rows.Count == 0)
                {

                    uc.Add(txtname.Text, txtfamily.Text, txtuid.Text, txtupass.Text, cbpartname.Text);

                    DialogResult dr;
                    dr = MessageBox.Show("!داده ها ثبت شد", "ثبت", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {

                        txtname.Text = "";
                        txtfamily.Text = "";
                        txtuid.Text = "";
                        txtupass.Text = "";
                        cbpartname.SelectedIndex = -1;
                    }

                    else
                    {
                        MessageBox.Show("! قبلا مشخصاتی با این شماره ، ثبت شده است", " تذکر :فیلد شماره تکراری است");

                        txtname.Focus();
                    }

                }
            }
        }


        private void User_Load(object sender, EventArgs e)
        {
            partsclass pc = new partsclass();
            DataTable dt = new DataTable();
            dt = pc.Search();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbpartname.Items.Add(dt.Rows[i]["part_name"].ToString());
            }
            if (part_name_fk != null)
            {
                cbpartname.SelectedIndex = cbpartname.Items.IndexOf(part_name_fk);
            }

            
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtfamily.Focus();
        }

        private void txtfamily_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtuid.Focus();
        }

        private void txtuid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtupass.Focus();
        }

        private void txtupass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbpartname.Focus();
        }
        private void cbpartname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnsave.Focus();
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbpartname_DropDown(object sender, EventArgs e)
        {
            
        }

       
    }
}



