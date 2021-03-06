using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_archive
{
    public partial class main : Form
    {
        
        public string server_add;
        
        public main()
        {
            InitializeComponent();
        }

        private void کاتالوگToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.repertory_Main f = new e_archive.UIL.repertory_Main();
            f.MdiParent = this;
            f.Show();
           
        }

        private void لوحفشردهCDDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.cd_dvd f = new UIL.cd_dvd();
            f.MdiParent = this;
            f.Show();
        }

        private void آلبوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.album f = new UIL.album();
            f.MdiParent = this;
            f.Show();
        }

        private void کتابToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UIL.book f = new UIL.book();
            f.MdiParent = this;
            f.Show();
        }

        private void لوحفشردهCDDVDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UIL.cd_dvd f = new UIL.cd_dvd();
            f.MdiParent = this;
            f.Show();
        }

        private void نقشهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.map f = new UIL.map();
            f.MdiParent = this;
            f.Show();
        }

        private void رزمهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.resume f = new UIL.resume();
            f.MdiParent = this;
            f.Show();
        }

        private void زونکنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.zuncan f = new UIL.zuncan();
            f.MdiParent = this;
            f.Show();
        }

        private void قراردادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.convention f = new UIL.convention();
            f.MdiParent = this;
            f.Show();
        }

        private void امانتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.bailment_Main  f = new UIL.bailment_Main();
            f.MdiParent = this;
            f.Show();
        }

        private void امانتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UIL.bailment f = new UIL.bailment();
            f.MdiParent = this;
            f.Show();
        }

        private void امانتToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UIL.bailment f = new UIL.bailment();
            f.MdiParent = this;
            f.Show();
        }

        private void جستجوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.search_report f = new UIL.search_report();
            f.MdiParent = this;
            f.Show();
        }

        private void جستجوToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UIL.search_report f = new UIL.search_report();
            f.MdiParent = this;
            f.Show();
        }

        private void جستجوToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UIL.search_report f = new UIL.search_report();
            f.MdiParent = this;
            f.Show();
        }

       

        private void پیگیریامانتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.pursuit_bailment f = new UIL.pursuit_bailment();
            f.MdiParent = this;
            f.Show();
        }

        private void پیگیریامانتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UIL.pursuit_bailment f = new UIL.pursuit_bailment();
            f.MdiParent = this;
            f.Show();
        }

        private void پیگیریامانتToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UIL.pursuit_bailment f = new UIL.pursuit_bailment();
            f.MdiParent = this;
            f.Show();
        }

        private void ثبتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.get_number f = new UIL.get_number();
            f.type = type_mode.type.album;
            f.mode = type_mode.mode.insert;
            f.MdiParent = this;
            f.Show();

        }

        private void اصلاحToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UIL.get_number f = new UIL.get_number();
            f.type = type_mode.type.album; //album
            f.mode = type_mode.mode.edit;//edit
            f.MdiParent = this;
            f.Show();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.get_number f = new UIL.get_number();
            f.MdiParent = this;
            f.Show();
        }

        private void نقشهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UIL.map_Main f = new UIL.map_Main();
            f.MdiParent = this;
            f.Show();
        }

        private void رزومهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.resume_Main f = new UIL.resume_Main();
            f.MdiParent = this;
            f.Show();
        }

        private void زونکنToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UIL.zuncan_Main f = new e_archive.UIL.zuncan_Main();
            f.MdiParent = this;
            f.Show();
        }

        private void کاربToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.users_Main f = new e_archive.UIL.users_Main();
            f.MdiParent = this;
            f.Show();
        }

        private void کاربرجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.parts_Main f = new e_archive.UIL.parts_Main();
            f.Show();
        }

        private void بخشجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.get_number f = new UIL.get_number();
            f.type = type_mode.type.album; //album
            f.mode = type_mode.mode.insert;//new
            f.MdiParent = this;
            f.Show();
        }

        private void آلبومToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.album_Main f = new UIL.album_Main();
            f.MdiParent = this;
            f.Show();
            
        }

        private void بخشهایسازمانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.parts_Main f = new UIL.parts_Main();
            f.MdiParent = this;
            f.Show();

        }

        private void گشتوگزارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.album_Main f = new e_archive.UIL.album_Main();
            f.MdiParent = this;
            f.Show();
        }

        private void گشتوگزارToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UIL.cd_dvd_Main f = new e_archive.UIL.cd_dvd_Main();
            f.MdiParent = this;
            f.Show();
        }

        
        private void کتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.book_Main f = new UIL.book_Main();
            f.MdiParent = this;
            f.Show();
        }

        private void لوحفشردهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.cd_dvd_Main f = new e_archive.UIL.cd_dvd_Main();
            f.MdiParent = this;
            f.Show();
        }

        private void lgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.magazine_Main f = new e_archive.UIL.magazine_Main();
            f.MdiParent = this;
            f.Show();
        }

        private void گزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIL.report_Main f = new e_archive.UIL.report_Main();
            f.MdiParent = this;
            f.Show();
        }

        private void قراردادToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UIL.convention_Main f = new e_archive.UIL.convention_Main();
            f.MdiParent = this;
            f.Show();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void تعویضکاربرفعالToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void مدیریتسیستمToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            //lbdate.Text = PersianDateClass.ShamsiDate();
            System.Globalization.CultureInfo c = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(c);

            global g = new global();
            this.Text = "سیستم مدیریت اقلام : سازمان نوسازی و بهسازی شهرداری اصفهان" + " " + "{" + "نام بخش =" + "'" + g.get_part_name_fk() + "'" + "||" + "نام کاربری فعال =" + "'" + g.get_user_id() + "'" + "}";
            
            
            UIL.bailment_Main f = new UIL.bailment_Main();
            f.MdiParent = this;
            f.chlate_date.Checked = true;
            f.Visible = false;
            f.comboBox1.Text = "و";
            f.Show();            
            f.btnsearch_Click(sender, e);
            if (f.dataGridView1.RowCount > 0)
            {
                f.Text = "اخطار: تاریخ تحویل گذشته ها";
                f.Visible = true;
            }
            else
            {
                f.Close();
            }
            
        }

        private void بازآوریToolStripMenuItem_Click(object sender, EventArgs e)
        {
                      
            
            UIL.Options.frm_Reload f = new e_archive.UIL.Options.frm_Reload();
                       
            f.MdiParent = this;
            f.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void دربارهپژواکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            UIL.DIALOGS.AboutUs f = new e_archive.UIL.DIALOGS.AboutUs();

            f.MdiParent = this;
            f.Show();
        }

        private void راهنماToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

  
    }
}