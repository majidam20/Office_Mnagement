namespace e_archive.UIL
{
    partial class repertory
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtdescribe = new System.Windows.Forms.TextBox();
            this.txtplace = new System.Windows.Forms.TextBox();
            this.txtprovider = new System.Windows.Forms.TextBox();
            this.txtday = new System.Windows.Forms.TextBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(17, 20);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "انصراف";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            this.btncancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btncancel_KeyDown);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(106, 20);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "وارد کردن";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnsave_KeyDown);
            // 
            // txtdescribe
            // 
            this.txtdescribe.Location = new System.Drawing.Point(17, 167);
            this.txtdescribe.MaxLength = 500;
            this.txtdescribe.Multiline = true;
            this.txtdescribe.Name = "txtdescribe";
            this.txtdescribe.Size = new System.Drawing.Size(430, 83);
            this.txtdescribe.TabIndex = 7;
            // 
            // txtplace
            // 
            this.txtplace.Location = new System.Drawing.Point(17, 140);
            this.txtplace.MaxLength = 200;
            this.txtplace.Name = "txtplace";
            this.txtplace.Size = new System.Drawing.Size(430, 21);
            this.txtplace.TabIndex = 6;
            this.txtplace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtplace_KeyDown);
            // 
            // txtprovider
            // 
            this.txtprovider.Location = new System.Drawing.Point(306, 89);
            this.txtprovider.MaxLength = 50;
            this.txtprovider.Name = "txtprovider";
            this.txtprovider.Size = new System.Drawing.Size(141, 21);
            this.txtprovider.TabIndex = 2;
            this.txtprovider.TextChanged += new System.EventHandler(this.txtprovider_TextChanged);
            this.txtprovider.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprovider_KeyDown);
            // 
            // txtday
            // 
            this.txtday.Location = new System.Drawing.Point(419, 114);
            this.txtday.MaxLength = 2;
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(28, 21);
            this.txtday.TabIndex = 3;
            this.txtday.Leave += new System.EventHandler(this.txtday_Leave);
            this.txtday.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtday_KeyPress);
            this.txtday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtday_KeyDown);
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(306, 63);
            this.txtsubject.MaxLength = 80;
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(141, 21);
            this.txtsubject.TabIndex = 1;
            this.txtsubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsubject_KeyDown);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(306, 39);
            this.txtid.MaxLength = 40;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(141, 21);
            this.txtid.TabIndex = 0;
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "سایر توضیحات :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "محل نگهداری :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "زمان ورود به بخش :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "شرکت تولید کننده :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "موضوع :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "شماره :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 350);
            this.tableLayoutPanel1.TabIndex = 32;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 591F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 284);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(607, 60);
            this.tableLayoutPanel3.TabIndex = 29;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 60);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ابزار";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 591F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox6, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 5);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(607, 279);
            this.tableLayoutPanel6.TabIndex = 30;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtyear);
            this.groupBox6.Controls.Add(this.txtmonth);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.txtdescribe);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.txtplace);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtprovider);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtday);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.txtsubject);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtid);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(8, 0);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(591, 279);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "اطلاعات";
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(306, 114);
            this.txtyear.MaxLength = 4;
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(43, 21);
            this.txtyear.TabIndex = 5;
            this.txtyear.Leave += new System.EventHandler(this.txtyear_Leave);
            this.txtyear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtyear_KeyPress);
            this.txtyear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtyear_KeyDown_1);
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(372, 114);
            this.txtmonth.MaxLength = 2;
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(28, 21);
            this.txtmonth.TabIndex = 4;
            this.txtmonth.Leave += new System.EventHandler(this.txtmonth_Leave);
            this.txtmonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmonth_KeyPress);
            this.txtmonth.TextChanged += new System.EventHandler(this.txtmonth_TextChanged);
            this.txtmonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmonth_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "/";
            // 
            // repertory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 350);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "repertory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "کاتالوگ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtdescribe;
        public System.Windows.Forms.TextBox txtplace;
        public System.Windows.Forms.TextBox txtprovider;
        public System.Windows.Forms.TextBox txtday;
        public System.Windows.Forms.TextBox txtsubject;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.TextBox txtyear;
        public System.Windows.Forms.TextBox txtmonth;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
    }
}