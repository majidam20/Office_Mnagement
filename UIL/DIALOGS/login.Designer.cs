namespace e_archive.UIL
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.txtupass = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtServAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_db_pass = new System.Windows.Forms.TextBox();
            this.Txt_db_uid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "کلمه عبور :";
            // 
            // txtuid
            // 
            this.txtuid.Location = new System.Drawing.Point(9, 6);
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(154, 21);
            this.txtuid.TabIndex = 0;
            this.txtuid.TextChanged += new System.EventHandler(this.txtuid_TextChanged);
            this.txtuid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuid_KeyDown);
            // 
            // txtupass
            // 
            this.txtupass.Location = new System.Drawing.Point(9, 33);
            this.txtupass.Name = "txtupass";
            this.txtupass.PasswordChar = '*';
            this.txtupass.Size = new System.Drawing.Size(154, 21);
            this.txtupass.TabIndex = 1;
            this.txtupass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtupass_KeyDown);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(86, 124);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 4;
            this.btnsubmit.Text = "تایید";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            this.btnsubmit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnsubmit_KeyDown);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(5, 124);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "انصراف";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.button2_Click);
            this.btncancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btncancel_KeyDown);
            // 
            // txtServAdd
            // 
            this.txtServAdd.Location = new System.Drawing.Point(9, 6);
            this.txtServAdd.Name = "txtServAdd";
            this.txtServAdd.Size = new System.Drawing.Size(154, 21);
            this.txtServAdd.TabIndex = 2;
            this.txtServAdd.Text = ".";
            this.txtServAdd.TextChanged += new System.EventHandler(this.textServAdd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "آدرس سرور:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "رمز عبور کاربر پایگاه :";
            // 
            // Txt_db_pass
            // 
            this.Txt_db_pass.Location = new System.Drawing.Point(9, 60);
            this.Txt_db_pass.Name = "Txt_db_pass";
            this.Txt_db_pass.PasswordChar = '*';
            this.Txt_db_pass.Size = new System.Drawing.Size(154, 21);
            this.Txt_db_pass.TabIndex = 4;
            this.Txt_db_pass.Text = "a";
            this.Txt_db_pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Txt_db_uid
            // 
            this.Txt_db_uid.Location = new System.Drawing.Point(9, 33);
            this.Txt_db_uid.Name = "Txt_db_uid";
            this.Txt_db_uid.Size = new System.Drawing.Size(154, 21);
            this.Txt_db_uid.TabIndex = 3;
            this.Txt_db_uid.Text = "sa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "نام کاربری کاربر پایگاه:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(291, 119);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtupass);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtuid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(283, 93);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "شناسایی کاربر";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Txt_db_pass);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Txt_db_uid);
            this.tabPage1.Controls.Add(this.txtServAdd);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(283, 93);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "تنظیمات ارتباط";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 153);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsubmit);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود ";
            this.Load += new System.EventHandler(this.login_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.TextBox txtupass;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtServAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_db_pass;
        private System.Windows.Forms.TextBox Txt_db_uid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
    }
}