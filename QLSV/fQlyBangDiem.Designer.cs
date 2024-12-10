namespace QLSV
{
    partial class fQlyBangDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQlyBangDiem));
            dgvBangDiem = new DataGridView();
            MaSoSV = new DataGridViewTextBoxColumn();
            TenSV = new DataGridViewTextBoxColumn();
            MaLopDN = new DataGridViewTextBoxColumn();
            MaMon = new DataGridViewTextBoxColumn();
            TenMon = new DataGridViewTextBoxColumn();
            DiemChuyenCan = new DataGridViewTextBoxColumn();
            DiemGiuaKy = new DataGridViewTextBoxColumn();
            DiemThiCuoiKy = new DataGridViewTextBoxColumn();
            TiLeDiemQuaTrinh = new DataGridViewTextBoxColumn();
            TiLeDiemThiCuoiKy = new DataGridViewTextBoxColumn();
            DiemTB = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            btn = new Button();
            label2 = new Label();
            label1 = new Label();
            cbLopDanhNghia = new ComboBox();
            cbKhoa = new ComboBox();
            tabPage2 = new TabPage();
            btnBaoCao1 = new Button();
            btnLocTinChi = new Button();
            label3 = new Label();
            cbLopTinChi = new ComboBox();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            MaLopTC = new DataGridViewTextBoxColumn();
            Mon = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            btnBaoCao2 = new Button();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            btnLocSinhVien = new Button();
            label4 = new Label();
            txtTenSV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBangDiem).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dgvBangDiem
            // 
            dgvBangDiem.AllowUserToAddRows = false;
            dgvBangDiem.AllowUserToDeleteRows = false;
            dgvBangDiem.AllowUserToOrderColumns = true;
            dgvBangDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBangDiem.Columns.AddRange(new DataGridViewColumn[] { MaSoSV, TenSV, MaLopDN, MaMon, TenMon, DiemChuyenCan, DiemGiuaKy, DiemThiCuoiKy, TiLeDiemQuaTrinh, TiLeDiemThiCuoiKy, DiemTB });
            dgvBangDiem.Location = new Point(3, 180);
            dgvBangDiem.Margin = new Padding(4);
            dgvBangDiem.Name = "dgvBangDiem";
            dgvBangDiem.RowHeadersWidth = 51;
            dgvBangDiem.Size = new Size(1564, 475);
            dgvBangDiem.TabIndex = 0;
            // 
            // MaSoSV
            // 
            MaSoSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaSoSV.DataPropertyName = "MaSoSV";
            MaSoSV.HeaderText = "Mã số sinh viên";
            MaSoSV.MinimumWidth = 6;
            MaSoSV.Name = "MaSoSV";
            MaSoSV.Width = 128;
            // 
            // TenSV
            // 
            TenSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenSV.DataPropertyName = "TenSV";
            TenSV.HeaderText = "Tên sinh viên";
            TenSV.MinimumWidth = 8;
            TenSV.Name = "TenSV";
            // 
            // MaLopDN
            // 
            MaLopDN.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaLopDN.DataPropertyName = "MaLopDN";
            MaLopDN.HeaderText = "Mã Lớp danh nghĩa";
            MaLopDN.MinimumWidth = 8;
            MaLopDN.Name = "MaLopDN";
            MaLopDN.Width = 126;
            // 
            // MaMon
            // 
            MaMon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaMon.DataPropertyName = "MaMon";
            MaMon.HeaderText = "Mã Môn học";
            MaMon.MinimumWidth = 8;
            MaMon.Name = "MaMon";
            MaMon.Width = 111;
            // 
            // TenMon
            // 
            TenMon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenMon.DataPropertyName = "TenMon";
            TenMon.HeaderText = "Tên môn học";
            TenMon.MinimumWidth = 8;
            TenMon.Name = "TenMon";
            // 
            // DiemChuyenCan
            // 
            DiemChuyenCan.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiemChuyenCan.DataPropertyName = "DiemChuyenCan";
            DiemChuyenCan.HeaderText = "Điểm chuyên cần";
            DiemChuyenCan.MinimumWidth = 6;
            DiemChuyenCan.Name = "DiemChuyenCan";
            DiemChuyenCan.Width = 126;
            // 
            // DiemGiuaKy
            // 
            DiemGiuaKy.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiemGiuaKy.DataPropertyName = "DiemGiuaKy";
            DiemGiuaKy.HeaderText = "Điểm giữa kỳ";
            DiemGiuaKy.MinimumWidth = 6;
            DiemGiuaKy.Name = "DiemGiuaKy";
            DiemGiuaKy.Width = 99;
            // 
            // DiemThiCuoiKy
            // 
            DiemThiCuoiKy.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiemThiCuoiKy.DataPropertyName = "DiemThiCuoiKy";
            DiemThiCuoiKy.HeaderText = "Điểm thi cuối kỳ";
            DiemThiCuoiKy.MinimumWidth = 6;
            DiemThiCuoiKy.Name = "DiemThiCuoiKy";
            DiemThiCuoiKy.Width = 111;
            // 
            // TiLeDiemQuaTrinh
            // 
            TiLeDiemQuaTrinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TiLeDiemQuaTrinh.DataPropertyName = "TiLeDiemQuaTrinh";
            TiLeDiemQuaTrinh.HeaderText = "Tỉ lệ điểm quá trình";
            TiLeDiemQuaTrinh.MinimumWidth = 6;
            TiLeDiemQuaTrinh.Name = "TiLeDiemQuaTrinh";
            TiLeDiemQuaTrinh.Width = 119;
            // 
            // TiLeDiemThiCuoiKy
            // 
            TiLeDiemThiCuoiKy.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TiLeDiemThiCuoiKy.DataPropertyName = "TiLeDiemThiCuoiKy";
            TiLeDiemThiCuoiKy.HeaderText = "Tỉ lệ điểm thi cuối kỳ";
            TiLeDiemThiCuoiKy.MinimumWidth = 6;
            TiLeDiemThiCuoiKy.Name = "TiLeDiemThiCuoiKy";
            TiLeDiemThiCuoiKy.Width = 119;
            // 
            // DiemTB
            // 
            DiemTB.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiemTB.DataPropertyName = "DiemTB";
            DiemTB.HeaderText = "Điểm trung bình";
            DiemTB.MinimumWidth = 6;
            DiemTB.Name = "DiemTB";
            DiemTB.Width = 121;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1578, 696);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Ivory;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(btn);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cbLopDanhNghia);
            tabPage1.Controls.Add(cbKhoa);
            tabPage1.Controls.Add(dgvBangDiem);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1570, 658);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lớp danh nghĩa";
            tabPage1.Click += tabPage1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(769, 43);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(157, 84);
            button1.TabIndex = 7;
            button1.Text = "Báo cáo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn
            // 
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.Image = (Image)resources.GetObject("btn.Image");
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.Location = new Point(593, 43);
            btn.Name = "btn";
            btn.Padding = new Padding(30, 0, 0, 0);
            btn.Size = new Size(157, 84);
            btn.TabIndex = 6;
            btn.Text = "Lọc";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(113, 99);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 5;
            label2.Text = "Lớp danh nghĩa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(210, 43);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 4;
            label1.Text = "Khoa";
            // 
            // cbLopDanhNghia
            // 
            cbLopDanhNghia.FormattingEnabled = true;
            cbLopDanhNghia.Location = new Point(274, 94);
            cbLopDanhNghia.Name = "cbLopDanhNghia";
            cbLopDanhNghia.Size = new Size(293, 33);
            cbLopDanhNghia.TabIndex = 3;
            // 
            // cbKhoa
            // 
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Location = new Point(274, 43);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(293, 33);
            cbKhoa.TabIndex = 1;
            cbKhoa.SelectedIndexChanged += cbKhoa_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Ivory;
            tabPage2.Controls.Add(btnBaoCao1);
            tabPage2.Controls.Add(btnLocTinChi);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(cbLopTinChi);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1570, 658);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lớp tín chỉ";
            tabPage2.Click += tabPage2_Click;
            // 
            // btnBaoCao1
            // 
            btnBaoCao1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBaoCao1.Image = (Image)resources.GetObject("btnBaoCao1.Image");
            btnBaoCao1.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaoCao1.Location = new Point(704, 39);
            btnBaoCao1.Name = "btnBaoCao1";
            btnBaoCao1.Padding = new Padding(20, 0, 0, 0);
            btnBaoCao1.Size = new Size(157, 84);
            btnBaoCao1.TabIndex = 8;
            btnBaoCao1.Text = "Báo cáo";
            btnBaoCao1.UseVisualStyleBackColor = true;
            btnBaoCao1.Click += btnBaoCao1_Click;
            // 
            // btnLocTinChi
            // 
            btnLocTinChi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLocTinChi.Image = (Image)resources.GetObject("btnLocTinChi.Image");
            btnLocTinChi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLocTinChi.Location = new Point(541, 39);
            btnLocTinChi.Name = "btnLocTinChi";
            btnLocTinChi.Padding = new Padding(30, 0, 0, 0);
            btnLocTinChi.Size = new Size(157, 84);
            btnLocTinChi.TabIndex = 7;
            btnLocTinChi.Text = "Lọc";
            btnLocTinChi.UseVisualStyleBackColor = true;
            btnLocTinChi.Click += btnLocTinChi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(93, 71);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 6;
            label3.Text = "Lớp tín chỉ";
            // 
            // cbLopTinChi
            // 
            cbLopTinChi.FormattingEnabled = true;
            cbLopTinChi.Location = new Point(207, 71);
            cbLopTinChi.Name = "cbLopTinChi";
            cbLopTinChi.Size = new Size(293, 33);
            cbLopTinChi.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, MaLopTC, Mon, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dataGridView2.Location = new Point(9, 174);
            dataGridView2.Margin = new Padding(4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1564, 475);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "MaSoSV";
            dataGridViewTextBoxColumn1.HeaderText = "MSSV";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "TenSV";
            dataGridViewTextBoxColumn2.HeaderText = "Tên sinh viên";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // MaLopTC
            // 
            MaLopTC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaLopTC.DataPropertyName = "MaLopTC";
            MaLopTC.HeaderText = "Lớp tín chỉ";
            MaLopTC.MinimumWidth = 8;
            MaLopTC.Name = "MaLopTC";
            // 
            // Mon
            // 
            Mon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mon.DataPropertyName = "Mon";
            Mon.HeaderText = "Tên môn";
            Mon.MinimumWidth = 8;
            Mon.Name = "Mon";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn6.DataPropertyName = "DiemChuyenCan";
            dataGridViewTextBoxColumn6.HeaderText = "Điểm chuyên cần";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 144;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn7.DataPropertyName = "DiemGiuaKy";
            dataGridViewTextBoxColumn7.HeaderText = "Điểm giữa kỳ";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn8.DataPropertyName = "DiemThiCuoiKy";
            dataGridViewTextBoxColumn8.HeaderText = "Điểm thi cuối kỳ";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 145;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn9.DataPropertyName = "TiLeDiemQuaTrinh";
            dataGridViewTextBoxColumn9.HeaderText = "Tỉ lệ điểm quá trình";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 151;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn10.DataPropertyName = "TiLeDiemThiCuoiKy";
            dataGridViewTextBoxColumn10.HeaderText = "Tỉ lệ điểm thi cuối kỳ";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 142;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn11.DataPropertyName = "DiemTB";
            dataGridViewTextBoxColumn11.HeaderText = "Điểm trung bình";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Width = 132;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Ivory;
            tabPage3.Controls.Add(btnBaoCao2);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(btnLocSinhVien);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(txtTenSV);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1570, 658);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sinh viên";
            // 
            // btnBaoCao2
            // 
            btnBaoCao2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBaoCao2.Image = (Image)resources.GetObject("btnBaoCao2.Image");
            btnBaoCao2.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaoCao2.Location = new Point(792, 55);
            btnBaoCao2.Name = "btnBaoCao2";
            btnBaoCao2.Padding = new Padding(20, 0, 0, 0);
            btnBaoCao2.Size = new Size(157, 84);
            btnBaoCao2.TabIndex = 10;
            btnBaoCao2.Text = "Báo cáo";
            btnBaoCao2.UseVisualStyleBackColor = true;
            btnBaoCao2.Click += btnBaoCao2_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToOrderColumns = true;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn19 });
            dataGridView3.Location = new Point(7, 174);
            dataGridView3.Margin = new Padding(4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(1564, 475);
            dataGridView3.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.DataPropertyName = "MaSoSV";
            dataGridViewTextBoxColumn3.HeaderText = "Mã số sinh viên";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 128;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.DataPropertyName = "TenSV";
            dataGridViewTextBoxColumn4.HeaderText = "Tên sinh viên";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn5.DataPropertyName = "MaLopDN";
            dataGridViewTextBoxColumn5.HeaderText = "Mã Lớp danh nghĩa";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 126;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn12.DataPropertyName = "MaMon";
            dataGridViewTextBoxColumn12.HeaderText = "Mã Môn học";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.Width = 111;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn13.DataPropertyName = "TenMon";
            dataGridViewTextBoxColumn13.HeaderText = "Tên môn học";
            dataGridViewTextBoxColumn13.MinimumWidth = 8;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn14.DataPropertyName = "DiemChuyenCan";
            dataGridViewTextBoxColumn14.HeaderText = "Điểm chuyên cần";
            dataGridViewTextBoxColumn14.MinimumWidth = 6;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.Width = 126;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn15.DataPropertyName = "DiemGiuaKy";
            dataGridViewTextBoxColumn15.HeaderText = "Điểm giữa kỳ";
            dataGridViewTextBoxColumn15.MinimumWidth = 6;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.Width = 99;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn16.DataPropertyName = "DiemThiCuoiKy";
            dataGridViewTextBoxColumn16.HeaderText = "Điểm thi cuối kỳ";
            dataGridViewTextBoxColumn16.MinimumWidth = 6;
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.Width = 111;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn17.DataPropertyName = "TiLeDiemQuaTrinh";
            dataGridViewTextBoxColumn17.HeaderText = "Tỉ lệ điểm quá trình";
            dataGridViewTextBoxColumn17.MinimumWidth = 6;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.Width = 119;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn18.DataPropertyName = "TiLeDiemThiCuoiKy";
            dataGridViewTextBoxColumn18.HeaderText = "Tỉ lệ điểm thi cuối kỳ";
            dataGridViewTextBoxColumn18.MinimumWidth = 6;
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.Width = 119;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn19.DataPropertyName = "DiemTB";
            dataGridViewTextBoxColumn19.HeaderText = "Điểm trung bình";
            dataGridViewTextBoxColumn19.MinimumWidth = 6;
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.Width = 121;
            // 
            // btnLocSinhVien
            // 
            btnLocSinhVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLocSinhVien.Image = (Image)resources.GetObject("btnLocSinhVien.Image");
            btnLocSinhVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnLocSinhVien.Location = new Point(629, 55);
            btnLocSinhVien.Name = "btnLocSinhVien";
            btnLocSinhVien.Padding = new Padding(30, 0, 0, 0);
            btnLocSinhVien.Size = new Size(157, 84);
            btnLocSinhVien.TabIndex = 8;
            btnLocSinhVien.Text = "Lọc";
            btnLocSinhVien.UseVisualStyleBackColor = true;
            btnLocSinhVien.Click += btnLocSinhVien_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 85);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 1;
            label4.Text = "Tên sinh viên";
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(244, 82);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(361, 31);
            txtTenSV.TabIndex = 0;
            // 
            // fQlyBangDiem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1578, 696);
            Controls.Add(tabControl1);
            Margin = new Padding(4);
            Name = "fQlyBangDiem";
            Text = "Bảng điểm";
            Load += fQlyBangDiem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBangDiem).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBangDiem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btn;
        private Label label2;
        private Label label1;
        private ComboBox cbLopDanhNghia;
        private ComboBox cbKhoa;
        private TabPage tabPage3;
        private DataGridViewTextBoxColumn MaSoSV;
        private DataGridViewTextBoxColumn TenSV;
        private DataGridViewTextBoxColumn MaLopDN;
        private DataGridViewTextBoxColumn MaMon;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewTextBoxColumn DiemChuyenCan;
        private DataGridViewTextBoxColumn DiemGiuaKy;
        private DataGridViewTextBoxColumn DiemThiCuoiKy;
        private DataGridViewTextBoxColumn TiLeDiemQuaTrinh;
        private DataGridViewTextBoxColumn TiLeDiemThiCuoiKy;
        private DataGridViewTextBoxColumn DiemTB;
        private Button btnLocTinChi;
        private Label label3;
        private ComboBox cbLopTinChi;
        private DataGridView dataGridView2;
        private Button btnLocSinhVien;
        private Label label4;
        private TextBox txtTenSV;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private Button button1;
        private Button btnBaoCao1;
        private Button btnBaoCao2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn MaLopTC;
        private DataGridViewTextBoxColumn Mon;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}