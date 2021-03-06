using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace e_archive.UIL
{
    public partial class get_number : Form
    {
        public type_mode.type type;
        public  type_mode.mode mode;
        
        public get_number()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DAL DA = new DAL();
            if (type == type_mode.type.parts)
            {
            
            }
            parts_Main PA = new parts_Main();
            DataTable DT = new DataTable();
          
            UIL.part f = new UIL.part ();
            f.MdiParent =this.ParentForm;
            this.Close();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UIL.search_report f = new UIL.search_report();
            f.MdiParent = this.ParentForm;
            this.Close();
            f.Show();
        }

        private void get_number_Load(object sender, EventArgs e)
        {
            if (mode==type_mode.mode.insert)
            {
                this.Text = "ثبت  :  ";
            }
            else if (mode ==type_mode.mode.edit)
            {
                this.Text = "ویرایش  :  ";
            }

           
            
            if (type==type_mode.type.album)
            {
                this.Text += "آلبوم";
            }
            else if (type == type_mode.type.magazine)
            {
                this.Text += "مجله";
            }
            else if (type == type_mode.type.parts)
            {
                this.Text += "بخش سازمان";
            }
        }
    }
}