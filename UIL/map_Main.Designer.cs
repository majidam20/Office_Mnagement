namespace e_archive.UIL
{
    partial class map_Main
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
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnview = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbselect_part = new System.Windows.Forms.ComboBox();
            this.chpart_name = new System.Windows.Forms.CheckBox();
            this.chadviser = new System.Windows.Forms.CheckBox();
            this.chall = new System.Windows.Forms.CheckBox();
            this.chdescribe = new System.Windows.Forms.CheckBox();
            this.chplace = new System.Windows.Forms.CheckBox();
            this.chsize = new System.Windows.Forms.CheckBox();
            this.chproject = new System.Windows.Forms.CheckBox();
            this.chid = new System.Windows.Forms.CheckBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnrefresh.Location = new System.Drawing.Point(328, 19);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 0;
            this.btnrefresh.Text = "بازآوری";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnsave.Location = new System.Drawing.Point(247, 19);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "وارد کردن";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnedit.Location = new System.Drawing.Point(166, 19);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "ویرایش";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btndel.Location = new System.Drawing.Point(85, 19);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 3;
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
            this.btncancel.TabIndex = 4;
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
            this.dataGridView1.Size = new System.Drawing.Size(830, 297);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnview.Location = new System.Drawing.Point(409, 19);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 526);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(836, 317);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "جدول داده ها";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(836, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "سایر ابزار ها";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 567F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(830, 121);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbselect_part);
            this.panel1.Controls.Add(this.chpart_name);
            this.panel1.Controls.Add(this.chadviser);
            this.panel1.Controls.Add(this.chall);
            this.panel1.Controls.Add(this.chdescribe);
            this.panel1.Controls.Add(this.chplace);
            this.panel1.Controls.Add(this.chsize);
            this.panel1.Controls.Add(this.chproject);
            this.panel1.Controls.Add(this.chid);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(263, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 121);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 99;
            this.label9.Text = "انتخاب بخش :";
            // 
            // cbselect_part
            // 
            this.cbselect_part.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbselect_part.FormattingEnabled = true;
            this.cbselect_part.Location = new System.Drawing.Point(359, 7);
            this.cbselect_part.Name = "cbselect_part";
            this.cbselect_part.Size = new System.Drawing.Size(121, 21);
            this.cbselect_part.TabIndex = 98;
            // 
            // chpart_name
            // 
            this.chpart_name.AutoSize = true;
            this.chpart_name.Location = new System.Drawing.Point(116, 69);
            this.chpart_name.Name = "chpart_name";
            this.chpart_name.Size = new System.Drawing.Size(66, 17);
            this.chpart_name.TabIndex = 97;
            this.chpart_name.Text = "نام بخش";
            this.chpart_name.UseVisualStyleBackColor = true;
            // 
            // chadviser
            // 
            this.chadviser.AutoSize = true;
            this.chadviser.Location = new System.Drawing.Point(424, 94);
            this.chadviser.Name = "chadviser";
            this.chadviser.Size = new System.Drawing.Size(56, 17);
            this.chadviser.TabIndex = 73;
            this.chadviser.Text = "مشاور";
            this.chadviser.UseVisualStyleBackColor = true;
            // 
            // chall
            // 
            this.chall.AutoSize = true;
            this.chall.Location = new System.Drawing.Point(60, 93);
            this.chall.Name = "chall";
            this.chall.Size = new System.Drawing.Size(122, 17);
            this.chall.TabIndex = 72;
            this.chall.Text = "همه موارد و لغو همه";
            this.chall.UseVisualStyleBackColor = true;
            this.chall.CursorChanged += new System.EventHandler(this.chall_CursorChanged);
            this.chall.CheckedChanged += new System.EventHandler(this.chall_CheckedChanged);
            // 
            // chdescribe
            // 
            this.chdescribe.AutoSize = true;
            this.chdescribe.Location = new System.Drawing.Point(198, 93);
            this.chdescribe.Name = "chdescribe";
            this.chdescribe.Size = new System.Drawing.Size(94, 17);
            this.chdescribe.TabIndex = 71;
            this.chdescribe.Text = "سایر توضیحات ";
            this.chdescribe.UseVisualStyleBackColor = true;
            // 
            // chplace
            // 
            this.chplace.AutoSize = true;
            this.chplace.Location = new System.Drawing.Point(317, 93);
            this.chplace.Name = "chplace";
            this.chplace.Size = new System.Drawing.Size(88, 17);
            this.chplace.TabIndex = 70;
            this.chplace.Text = "محل نگهداری";
            this.chplace.UseVisualStyleBackColor = true;
            // 
            // chsize
            // 
            this.chsize.AutoSize = true;
            this.chsize.Location = new System.Drawing.Point(246, 70);
            this.chsize.Name = "chsize";
            this.chsize.Size = new System.Drawing.Size(46, 17);
            this.chsize.TabIndex = 69;
            this.chsize.Text = "ابعاد";
            this.chsize.UseVisualStyleBackColor = true;
            // 
            // chproject
            // 
            this.chproject.AutoSize = true;
            this.chproject.Location = new System.Drawing.Point(357, 71);
            this.chproject.Name = "chproject";
            this.chproject.Size = new System.Drawing.Size(48, 17);
            this.chproject.TabIndex = 68;
            this.chproject.Text = "پروژه";
            this.chproject.UseVisualStyleBackColor = true;
            // 
            // chid
            // 
            this.chid.AutoSize = true;
            this.chid.Location = new System.Drawing.Point(424, 71);
            this.chid.Name = "chid";
            this.chid.Size = new System.Drawing.Size(56, 17);
            this.chid.TabIndex = 67;
            this.chid.Text = "شماره";
            this.chid.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(292, 37);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(188, 21);
            this.txtsearch.TabIndex = 66;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "عبارت جستجو :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "محل جستجو :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 121);
            this.panel2.TabIndex = 0;
            // 
            // btnsearch
            // 
            this.btnsearch.Enabled = false;
            this.btnsearch.Location = new System.Drawing.Point(6, 86);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(51, 23);
            this.btnsearch.TabIndex = 64;
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
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btnedit);
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
            this.label18.TabIndex = 31;
            this.label18.Text = "تعداد سطر :";
            // 
            // btnselect_id_bail
            // 
            this.btnselect_id_bail.ForeColor = System.Drawing.Color.Maroon;
            this.btnselect_id_bail.Location = new System.Drawing.Point(490, 19);
            this.btnselect_id_bail.Name = "btnselect_id_bail";
            this.btnselect_id_bail.Size = new System.Drawing.Size(86, 23);
            this.btnselect_id_bail.TabIndex = 14;
            this.btnselect_id_bail.Text = "انتخاب ";
            this.btnselect_id_bail.UseVisualStyleBackColor = true;
            this.btnselect_id_bail.Visible = false;
            this.btnselect_id_bail.Click += new System.EventHandler(this.btnselect_id_bail_Click);
            // 
            // map_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 526);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Name = "map_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "صفحه اصلی نقشه";
            this.Load += new System.EventHandler(this.map_Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.map_Main_KeyDown);
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

        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chadviser;
        private System.Windows.Forms.CheckBox chall;
        private System.Windows.Forms.CheckBox chdescribe;
        private System.Windows.Forms.CheckBox chplace;
        private System.Windows.Forms.CheckBox chsize;
        private System.Windows.Forms.CheckBox chproject;
        private System.Windows.Forms.CheckBox chid;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsearch;
        public System.Windows.Forms.Button btnselect_id_bail;
        private System.Windows.Forms.CheckBox chpart_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbselect_part;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label18;
    }
}