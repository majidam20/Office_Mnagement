namespace e_archive.UIL
{
    partial class repertory_Main
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
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbselect_part = new System.Windows.Forms.ComboBox();
            this.chpart_name = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chdate = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtyear_1 = new System.Windows.Forms.TextBox();
            this.txtmonth_1 = new System.Windows.Forms.TextBox();
            this.txtday_1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtday = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chall = new System.Windows.Forms.CheckBox();
            this.chdescribe = new System.Windows.Forms.CheckBox();
            this.chplace = new System.Windows.Forms.CheckBox();
            this.chprovider_company = new System.Windows.Forms.CheckBox();
            this.chsubject = new System.Windows.Forms.CheckBox();
            this.chid = new System.Windows.Forms.CheckBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnselect_id_bail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnsave.Location = new System.Drawing.Point(249, 19);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "وارد کردن";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnedit.Location = new System.Drawing.Point(168, 19);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "ویرایش";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btndel.Location = new System.Drawing.Point(87, 19);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 2;
            this.btndel.Text = "حذف";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btncancel.Location = new System.Drawing.Point(6, 19);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "انصراف";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(830, 254);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnrefresh.Location = new System.Drawing.Point(330, 19);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 5;
            this.btnrefresh.Text = "بازآوری";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnview.Location = new System.Drawing.Point(411, 19);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 23);
            this.btnview.TabIndex = 6;
            this.btnview.Text = "نمایش";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 526);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(836, 274);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "جدول داده ها";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(836, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "سایر ابزار ها";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 577F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(830, 164);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbselect_part);
            this.panel1.Controls.Add(this.chpart_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chdate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtyear_1);
            this.panel1.Controls.Add(this.txtmonth_1);
            this.panel1.Controls.Add(this.txtday_1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtyear);
            this.panel1.Controls.Add(this.txtmonth);
            this.panel1.Controls.Add(this.txtday);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chall);
            this.panel1.Controls.Add(this.chdescribe);
            this.panel1.Controls.Add(this.chplace);
            this.panel1.Controls.Add(this.chprovider_company);
            this.panel1.Controls.Add(this.chsubject);
            this.panel1.Controls.Add(this.chid);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(253, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 164);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(489, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 128;
            this.label9.Text = "انتخاب بخش :";
            // 
            // cbselect_part
            // 
            this.cbselect_part.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbselect_part.FormattingEnabled = true;
            this.cbselect_part.Location = new System.Drawing.Point(362, 11);
            this.cbselect_part.Name = "cbselect_part";
            this.cbselect_part.Size = new System.Drawing.Size(121, 21);
            this.cbselect_part.TabIndex = 127;
            // 
            // chpart_name
            // 
            this.chpart_name.AutoSize = true;
            this.chpart_name.Location = new System.Drawing.Point(417, 99);
            this.chpart_name.Name = "chpart_name";
            this.chpart_name.Size = new System.Drawing.Size(66, 17);
            this.chpart_name.TabIndex = 126;
            this.chpart_name.Text = "نام بخش";
            this.chpart_name.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "ازتاریخ :";
            // 
            // chdate
            // 
            this.chdate.AutoSize = true;
            this.chdate.Location = new System.Drawing.Point(432, 131);
            this.chdate.Name = "chdate";
            this.chdate.Size = new System.Drawing.Size(132, 17);
            this.chdate.TabIndex = 124;
            this.chdate.Text = "جستجو برحسب تاریخ :";
            this.chdate.UseVisualStyleBackColor = true;
            this.chdate.CheckedChanged += new System.EventHandler(this.chdate_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 123;
            this.label6.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "/";
            // 
            // txtyear_1
            // 
            this.txtyear_1.Enabled = false;
            this.txtyear_1.Location = new System.Drawing.Point(8, 128);
            this.txtyear_1.MaxLength = 4;
            this.txtyear_1.Name = "txtyear_1";
            this.txtyear_1.Size = new System.Drawing.Size(43, 21);
            this.txtyear_1.TabIndex = 121;
            this.txtyear_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtyear_1_KeyDown);
            this.txtyear_1.Leave += new System.EventHandler(this.txtyear_1_Leave);
            this.txtyear_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtyear_1_KeyPress);
            // 
            // txtmonth_1
            // 
            this.txtmonth_1.Enabled = false;
            this.txtmonth_1.Location = new System.Drawing.Point(72, 128);
            this.txtmonth_1.MaxLength = 2;
            this.txtmonth_1.Name = "txtmonth_1";
            this.txtmonth_1.Size = new System.Drawing.Size(28, 21);
            this.txtmonth_1.TabIndex = 120;
            this.txtmonth_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmonth_1_KeyDown);
            this.txtmonth_1.Leave += new System.EventHandler(this.txtmonth_1_Leave);
            this.txtmonth_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmonth_1_KeyPress);
            // 
            // txtday_1
            // 
            this.txtday_1.Enabled = false;
            this.txtday_1.Location = new System.Drawing.Point(121, 128);
            this.txtday_1.MaxLength = 2;
            this.txtday_1.Name = "txtday_1";
            this.txtday_1.Size = new System.Drawing.Size(28, 21);
            this.txtday_1.TabIndex = 119;
            this.txtday_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtday_1_KeyDown);
            this.txtday_1.Leave += new System.EventHandler(this.txtday_1_Leave);
            this.txtday_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtday_1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 118;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 117;
            this.label5.Text = "/";
            // 
            // txtyear
            // 
            this.txtyear.Enabled = false;
            this.txtyear.Location = new System.Drawing.Point(227, 130);
            this.txtyear.MaxLength = 4;
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(43, 21);
            this.txtyear.TabIndex = 116;
            this.txtyear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtyear_KeyDown);
            this.txtyear.Leave += new System.EventHandler(this.txtyear_Leave);
            this.txtyear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtyear_KeyPress);
            // 
            // txtmonth
            // 
            this.txtmonth.Enabled = false;
            this.txtmonth.Location = new System.Drawing.Point(291, 130);
            this.txtmonth.MaxLength = 2;
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(28, 21);
            this.txtmonth.TabIndex = 115;
            this.txtmonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmonth_KeyDown);
            this.txtmonth.Leave += new System.EventHandler(this.txtmonth_Leave);
            this.txtmonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmonth_KeyPress);
            // 
            // txtday
            // 
            this.txtday.Enabled = false;
            this.txtday.Location = new System.Drawing.Point(340, 130);
            this.txtday.MaxLength = 2;
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(28, 21);
            this.txtday.TabIndex = 114;
            this.txtday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtday_KeyDown);
            this.txtday.Leave += new System.EventHandler(this.txtday_Leave);
            this.txtday.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtday_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "تا تاریخ :";
            // 
            // chall
            // 
            this.chall.AutoSize = true;
            this.chall.Location = new System.Drawing.Point(27, 99);
            this.chall.Name = "chall";
            this.chall.Size = new System.Drawing.Size(122, 17);
            this.chall.TabIndex = 112;
            this.chall.Text = "همه موارد و لغو همه";
            this.chall.UseVisualStyleBackColor = true;
            this.chall.CheckedChanged += new System.EventHandler(this.chall_CheckedChanged_1);
            // 
            // chdescribe
            // 
            this.chdescribe.AutoSize = true;
            this.chdescribe.Location = new System.Drawing.Point(183, 99);
            this.chdescribe.Name = "chdescribe";
            this.chdescribe.Size = new System.Drawing.Size(94, 17);
            this.chdescribe.TabIndex = 111;
            this.chdescribe.Text = "سایر توضیحات ";
            this.chdescribe.UseVisualStyleBackColor = true;
            // 
            // chplace
            // 
            this.chplace.AutoSize = true;
            this.chplace.Location = new System.Drawing.Point(294, 99);
            this.chplace.Name = "chplace";
            this.chplace.Size = new System.Drawing.Size(88, 17);
            this.chplace.TabIndex = 110;
            this.chplace.Text = "محل نگهداری";
            this.chplace.UseVisualStyleBackColor = true;
            // 
            // chprovider_company
            // 
            this.chprovider_company.AutoSize = true;
            this.chprovider_company.Location = new System.Drawing.Point(169, 71);
            this.chprovider_company.Name = "chprovider_company";
            this.chprovider_company.Size = new System.Drawing.Size(108, 17);
            this.chprovider_company.TabIndex = 109;
            this.chprovider_company.Text = "شرکت تولید کننده";
            this.chprovider_company.UseVisualStyleBackColor = true;
            // 
            // chsubject
            // 
            this.chsubject.AutoSize = true;
            this.chsubject.Location = new System.Drawing.Point(324, 71);
            this.chsubject.Name = "chsubject";
            this.chsubject.Size = new System.Drawing.Size(58, 17);
            this.chsubject.TabIndex = 108;
            this.chsubject.Text = "موضوع";
            this.chsubject.UseVisualStyleBackColor = true;
            // 
            // chid
            // 
            this.chid.AutoSize = true;
            this.chid.Location = new System.Drawing.Point(427, 71);
            this.chid.Name = "chid";
            this.chid.Size = new System.Drawing.Size(56, 17);
            this.chid.TabIndex = 107;
            this.chid.Text = "شماره";
            this.chid.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(295, 40);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(188, 21);
            this.txtsearch.TabIndex = 106;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 103;
            this.label7.Text = "عبارت جستجو :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 105;
            this.label8.Text = "محل جستجو :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 164);
            this.panel2.TabIndex = 0;
            // 
            // btnsearch
            // 
            this.btnsearch.Enabled = false;
            this.btnsearch.Location = new System.Drawing.Point(6, 128);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(51, 23);
            this.btnsearch.TabIndex = 104;
            this.btnsearch.Text = "جستجو";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.btnselect_id_bail);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnview);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ابزار";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Right;
            this.label18.Location = new System.Drawing.Point(769, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "تعداد سطر :";
            // 
            // btnselect_id_bail
            // 
            this.btnselect_id_bail.ForeColor = System.Drawing.Color.Maroon;
            this.btnselect_id_bail.Location = new System.Drawing.Point(492, 19);
            this.btnselect_id_bail.Name = "btnselect_id_bail";
            this.btnselect_id_bail.Size = new System.Drawing.Size(86, 23);
            this.btnselect_id_bail.TabIndex = 14;
            this.btnselect_id_bail.Text = "انتخاب ";
            this.btnselect_id_bail.UseVisualStyleBackColor = true;
            this.btnselect_id_bail.Visible = false;
            this.btnselect_id_bail.Click += new System.EventHandler(this.btnselect_id_bail_Click);
            // 
            // repertory_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 526);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Name = "repertory_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "صفحه اصلی کاتالوگ";
            this.Load += new System.EventHandler(this.repertory_Main_Load);
            this.Leave += new System.EventHandler(this.repertory_Main_Leave);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repertory_Main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chall;
        private System.Windows.Forms.CheckBox chdescribe;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.CheckBox chplace;
        private System.Windows.Forms.CheckBox chprovider_company;
        private System.Windows.Forms.CheckBox chsubject;
        private System.Windows.Forms.CheckBox chid;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnselect_id_bail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtyear_1;
        public System.Windows.Forms.TextBox txtmonth_1;
        public System.Windows.Forms.TextBox txtday_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtyear;
        public System.Windows.Forms.TextBox txtmonth;
        public System.Windows.Forms.TextBox txtday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chpart_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbselect_part;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label18;
    }
}