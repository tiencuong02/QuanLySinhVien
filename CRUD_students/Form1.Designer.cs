
namespace CRUD_students
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            lsvDanhSach = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            splitter1 = new Splitter();
            groupBox1 = new GroupBox();
            btnTimKiem = new Button();
            txtTKTenSV = new TextBox();
            txtTKMaSV = new TextBox();
            radTenSV = new RadioButton();
            radMaSV = new RadioButton();
            GroupBox3 = new GroupBox();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dtpNgaySinh = new DateTimePicker();
            cbGioiTinh = new ComboBox();
            txtHocBong = new TextBox();
            txtMaKhoa = new TextBox();
            txtNoiSinh = new TextBox();
            txtTenSV = new TextBox();
            txtMaSV = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            GroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 84);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AccessibleName = "btnTimKiem";
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1068, 84);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÍ SINH VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 84);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(splitter1);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(GroupBox3);
            splitContainer1.Size = new Size(1068, 620);
            splitContainer1.SplitterDistance = 653;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvDanhSach);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(653, 491);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả :";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lsvDanhSach
            // 
            lsvDanhSach.AccessibleName = "lsvDanhSach";
            lsvDanhSach.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lsvDanhSach.Dock = DockStyle.Fill;
            lsvDanhSach.FullRowSelect = true;
            lsvDanhSach.GridLines = true;
            lsvDanhSach.Location = new Point(3, 26);
            lsvDanhSach.Name = "lsvDanhSach";
            lsvDanhSach.Size = new Size(647, 462);
            lsvDanhSach.TabIndex = 0;
            lsvDanhSach.UseCompatibleStateImageBehavior = false;
            lsvDanhSach.View = View.Details;
            lsvDanhSach.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã SV";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên sinh viên";
            columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Giới tính";
            columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ngày sinh";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nơi sinh";
            columnHeader5.Width = 82;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Mã khoa";
            columnHeader6.Width = 82;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Học bổng ";
            columnHeader7.Width = 100;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 125);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(653, 4);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtTKTenSV);
            groupBox1.Controls.Add(txtTKMaSV);
            groupBox1.Controls.Add(radTenSV);
            groupBox1.Controls.Add(radMaSV);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm :";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AccessibleName = "btnTimKiem";
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(463, 42);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(133, 61);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "T&ìm kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTKTenSV
            // 
            txtTKTenSV.AccessibleName = "txtTKTenSV";
            txtTKTenSV.Location = new Point(243, 74);
            txtTKTenSV.Name = "txtTKTenSV";
            txtTKTenSV.Size = new Size(195, 30);
            txtTKTenSV.TabIndex = 3;
            // 
            // txtTKMaSV
            // 
            txtTKMaSV.AccessibleName = "txtTKMaSV";
            txtTKMaSV.Location = new Point(243, 29);
            txtTKMaSV.Name = "txtTKMaSV";
            txtTKMaSV.Size = new Size(195, 30);
            txtTKMaSV.TabIndex = 2;
            txtTKMaSV.TextChanged += txtTKMaSV_TextChanged;
            // 
            // radTenSV
            // 
            radTenSV.AccessibleName = "radTenSV";
            radTenSV.AutoSize = true;
            radTenSV.Location = new Point(87, 76);
            radTenSV.Name = "radTenSV";
            radTenSV.Size = new Size(138, 27);
            radTenSV.TabIndex = 1;
            radTenSV.Text = "Tên sinh viên :";
            radTenSV.UseVisualStyleBackColor = true;
            radTenSV.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radMaSV
            // 
            radMaSV.AccessibleName = "radMaSV";
            radMaSV.AutoSize = true;
            radMaSV.Checked = true;
            radMaSV.Location = new Point(87, 29);
            radMaSV.Name = "radMaSV";
            radMaSV.Size = new Size(136, 27);
            radMaSV.TabIndex = 0;
            radMaSV.TabStop = true;
            radMaSV.Text = "Mã sinh viên :";
            radMaSV.UseVisualStyleBackColor = true;
            radMaSV.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(btnThoat);
            GroupBox3.Controls.Add(btnHuy);
            GroupBox3.Controls.Add(btnLuu);
            GroupBox3.Controls.Add(btnXoa);
            GroupBox3.Controls.Add(btnSua);
            GroupBox3.Controls.Add(btnThem);
            GroupBox3.Controls.Add(dtpNgaySinh);
            GroupBox3.Controls.Add(cbGioiTinh);
            GroupBox3.Controls.Add(txtHocBong);
            GroupBox3.Controls.Add(txtMaKhoa);
            GroupBox3.Controls.Add(txtNoiSinh);
            GroupBox3.Controls.Add(txtTenSV);
            GroupBox3.Controls.Add(txtMaSV);
            GroupBox3.Controls.Add(label8);
            GroupBox3.Controls.Add(label7);
            GroupBox3.Controls.Add(label6);
            GroupBox3.Controls.Add(label5);
            GroupBox3.Controls.Add(label4);
            GroupBox3.Controls.Add(label3);
            GroupBox3.Controls.Add(label2);
            GroupBox3.Dock = DockStyle.Fill;
            GroupBox3.Location = new Point(0, 0);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(411, 620);
            GroupBox3.TabIndex = 0;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Thông tin chi tiết :";
            GroupBox3.Enter += Groupbox3_Enter;
            // 
            // btnThoat
            // 
            btnThoat.AccessibleName = "btnThoat";
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(274, 513);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(113, 62);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "T&hoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.AccessibleName = "btnHuy";
            btnHuy.Image = (Image)resources.GetObject("btnHuy.Image");
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.Location = new Point(149, 513);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(113, 62);
            btnHuy.TabIndex = 20;
            btnHuy.Text = "H&uỷ";
            btnHuy.TextAlign = ContentAlignment.MiddleRight;
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.AccessibleName = "btnLuu";
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(24, 513);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(113, 62);
            btnLuu.TabIndex = 19;
            btnLuu.Text = "&Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.AccessibleName = "btnXoa";
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(274, 417);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(113, 62);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "&Delete";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.AccessibleName = "btnSua";
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(149, 417);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(113, 62);
            btnSua.TabIndex = 17;
            btnSua.Text = "&Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.AccessibleName = "btnThem";
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(24, 417);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(113, 62);
            btnThem.TabIndex = 16;
            btnThem.Text = "&Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.AccessibleName = "dtpNgaySinh";
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(163, 193);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(196, 30);
            dtpNgaySinh.TabIndex = 15;
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.AccessibleName = "cbGioiTinh";
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Location = new Point(164, 133);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(195, 31);
            cbGioiTinh.TabIndex = 14;
            // 
            // txtHocBong
            // 
            txtHocBong.AccessibleName = "txtHocBong";
            txtHocBong.Location = new Point(164, 351);
            txtHocBong.Name = "txtHocBong";
            txtHocBong.Size = new Size(195, 30);
            txtHocBong.TabIndex = 13;
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.AccessibleName = "txtMaKhoa";
            txtMaKhoa.Location = new Point(164, 298);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(195, 30);
            txtMaKhoa.TabIndex = 12;
            // 
            // txtNoiSinh
            // 
            txtNoiSinh.AccessibleName = "txtNoiSinh";
            txtNoiSinh.Location = new Point(164, 243);
            txtNoiSinh.Name = "txtNoiSinh";
            txtNoiSinh.Size = new Size(195, 30);
            txtNoiSinh.TabIndex = 11;
            // 
            // txtTenSV
            // 
            txtTenSV.AccessibleName = "txtTenSV";
            txtTenSV.Location = new Point(164, 82);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(195, 30);
            txtTenSV.TabIndex = 8;
            // 
            // txtMaSV
            // 
            txtMaSV.AccessibleName = "txtMaSV";
            txtMaSV.Location = new Point(164, 35);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(195, 30);
            txtMaSV.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 358);
            label8.Name = "label8";
            label8.Size = new Size(94, 23);
            label8.TabIndex = 6;
            label8.Text = "Học bổng :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 305);
            label7.Name = "label7";
            label7.Size = new Size(85, 23);
            label7.TabIndex = 5;
            label7.Text = "Mã khoa :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 250);
            label6.Name = "label6";
            label6.Size = new Size(87, 23);
            label6.TabIndex = 4;
            label6.Text = "Nơi sinh : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 194);
            label5.Name = "label5";
            label5.Size = new Size(95, 23);
            label5.TabIndex = 3;
            label5.Text = "Ngày sinh :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 141);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 2;
            label4.Text = "Giới tính :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 89);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 1;
            label3.Text = "Tên sinh viên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 42);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã sinh viên : ";
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 704);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            ResumeLayout(false);
        }

        /*
private void groupBox3_Enter(object sender, EventArgs e)
{
   throw new NotImplementedException();

   btnSua.Enabled = false;
   btnXoa.Enabled = false;
   btnLuu.Enabled = false;
   btnHuy.Enabled = false;
} */

        #endregion

        private Panel panel1;
        private Label label1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private Splitter splitter1;
        private GroupBox groupBox1;
        private GroupBox GroupBox3;
        private RadioButton radTenSV;
        private RadioButton radMaSV;
        private TextBox txtTKTenSV;
        private TextBox txtTKMaSV;
        private Button btnTimKiem;
        private ListView lsvDanhSach;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtHocBong;
        private TextBox txtMaKhoa;
        private TextBox txtNoiSinh;
        private TextBox txtTenSV;
        private TextBox txtMaSV;
        private Button btnThem;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cbGioiTinh;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
    }
}
