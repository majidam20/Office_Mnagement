using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace e_archive.UIL
{
    public partial class album : Form
    {
        UTF8Encoding ue = new UTF8Encoding();
        public type_mode.mode mode;
        public album_Main AlbumMain;

        public string LastLoad;
        
        public album()
        {
            InitializeComponent();
        }
//hash
        private string encryptString(string strToEncrypt)
        {
            UTF8Encoding ue = new UTF8Encoding();
            byte[] bytes = ue.GetBytes(strToEncrypt);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hashBytes = md5.ComputeHash(bytes);

            // Bytes to string
            return System.Text.RegularExpressions.Regex.Replace
                (BitConverter.ToString(hashBytes), ",", "").ToLower();
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
            //txtyear.Text = string.Format("{0,4:G}", txtyear.Text);
            //txtyear.Text = txtyear.Text.Replace(" ", "0");
            if ((txtyear.Text.Length > 0)&&(Convert.ToInt32(txtyear.Text) < 1300))
            {
                MessageBox.Show("!لطفا عدد مربوط به سال را تصحیح نمایید ");
                txtyear.Focus();
                return;
            }  

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            albumclass ac = new albumclass();
            DataTable dt = new DataTable();

            txtday.Text = string.Format("{0,2:G}", txtday.Text);
            txtday.Text = txtday.Text.Replace(" ", "0");

            txtmonth.Text = string.Format("{0,2:G}", txtmonth.Text);
            txtmonth.Text = txtmonth.Text.Replace(" ", "0");

            txtyear.Text = string.Format("{0,4:G}", txtyear.Text);
            txtyear.Text = txtyear.Text.Replace(" ", "0");

            
            ////if (Convert.ToInt32(txtday.Text) == 0)
            ////{
            ////    MessageBox.Show("!لطفا عدد مربوط به روز را تصحیح نمایید ");
            ////    txtday.Focus();
            ////    return;
            ////}
            ////if (Convert.ToInt32(txtmonth.Text) == 0)
            ////{
            ////    MessageBox.Show("!لطفا عدد مربوط به ماه را تصحیح نمایید ");
            ////    txtmonth.Focus();
            ////    return;
            ////}

            if (txtid.Text == "")
            {
                MessageBox.Show("لطفا شماره را وارد نماييد");
                txtid.Focus();
                return;
            }

            if (txtonvan.Text == "")
            {
                MessageBox.Show("لطفاعنوان آلبوم را وارد نماييد");
                txtonvan.Focus();
                return;
            }
            if (txtmantaghe.Text == "")
            {
                //MessageBox.Show("لطفا منطقه را وارد نماييد");
                txtmantaghe.Text=" ";
                //return;
            }
            if (cbnoe.Text == "")
            {
                MessageBox.Show("لطفا نوع آلبوم را وارد نماييد");
                cbnoe.Focus();
                return;
            }
            if (txtmasahat_tozihat.Text == "")
            {
                //MessageBox.Show("لطفا مساحت را وارد نماييد");
                txtmasahat_tozihat.Text = " ";
                //return;
            }

            if (txtnam_taiekonande.Text == "")
            {
               //MessageBox.Show("لطفا نام تهیه کننده را وارد نماييد");
                txtnam_taiekonande.Text = " ";
                //return;
            }

            if ((txtday.Text == "") || (Convert.ToInt32(txtday.Text) == 0))
            {
                MessageBox.Show("لطفا روز را وارد نماييد");
                txtday.Text = " ";
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

            if (txtmahale_negahdari.Text == "")
            {
               //MessageBox.Show("لطفا محل نگهداری را وارد نماييد");
                txtmahale_negahdari.Text = " ";
                //return;
            }

            if (txtsaere_tozihat.Text == "")
            {
                //MessageBox.Show("لطفا سایر توضیحات را وارد نماييد");
                txtsaere_tozihat.Text = " ";
                //return;
            }

            //code asli album

            if (mode == type_mode.mode.edit)
            {
                ac.Edit(txtonvan.Text, txtmantaghe.Text, cbnoe.Text, txtghete.Text, txtmasahat_tozihat.Text, txtnam_taiekonande.Text, txtyear.Text + "/" + txtmonth.Text + "/" + txtday.Text, txtmahale_negahdari.Text, txtsaere_tozihat.Text,txtid.Text);
                MessageBox.Show("!ویرایش انجام شد ");

                this.Close();
                //////////////////////////////////newshow
                //album_Main f = new album_Main();
                //dt = ac.Search_grid1();
                //f.dataGridView1.DataSource = dt;
                //f.Show(); 

            }
            else if (mode == type_mode.mode.insert)
            {
                dt = ac.Search(txtid.Text);

                if (dt.Rows.Count == 0)
                {
                    ac.Add(txtid.Text, txtonvan.Text, txtmantaghe.Text, cbnoe.Text, txtghete.Text, txtmasahat_tozihat.Text, txtnam_taiekonande.Text, txtyear.Text + "/" + txtmonth.Text + "/" + txtday.Text, txtmahale_negahdari.Text, txtsaere_tozihat.Text,false);

                    DialogResult dr;
                    dr = MessageBox.Show("!داده ها ثبت شد", "ثبت", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        txtid.Text = "";
                        txtonvan.Text = "";
                        txtmantaghe.Text = "";
                        cbnoe.SelectedIndex = -1;
                        txtghete.Text = "";
                        txtday.Text = "";
                        txtmonth.Text = "";
                        txtyear.Text = "";
                        txtmasahat_tozihat.Text = "";
                        txtnam_taiekonande.Text = "";
                        txtmahale_negahdari.Text = "";
                        txtsaere_tozihat.Text = "";
                        ////////////////////////////////////////////newshow
                        //album_Main f = new album_Main();
                        ////album_Main f;
                        //dt = ac.Search_grid1();
                        //f.dataGridView1.DataSource = dt;
                        //this.Close();
                        //f.Show(); 
                       
                    }//dr
                }
                else
                {
                    MessageBox.Show("! قبلا مشخصاتی با این شماره ، ثبت شده است", " تذکر :فیلد شماره تکراری است");

                    txtid.Focus();
                }

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {//hashing
            //MessageBox.Show(encryptString("majid"));
            this.Close();

        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtonvan.Focus();
        }

        private void txtonvan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtmantaghe.Focus();
        }

        private void txtmantaghe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbnoe.Focus();
        }

        private void txtnoe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtghete.Focus();
        }

        private void txtghete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtmasahat_tozihat.Focus();
        }

        private void txtmasahat_tozihat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtnam_taiekonande.Focus();
        }

        private void txtnam_taiekonande_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtday.Focus();
        }

        
        private void txtmahale_negahdari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtsaere_tozihat.Focus();
        }

        private void btnsave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                btncancel.Focus();
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
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


        private void txtyear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtmahale_negahdari.Focus();
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

        private void cbnoe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtghete.Focus();
        }

        private void txtyear_TextChanged(object sender, EventArgs e)
        {

        }

        private void album_Load(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtid_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }



        

    }
}