namespace Lab08_QuanLyHocSinh
{
    partial class frmQLHocSinh
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblTitle = new Label();
            grpThongTin = new GroupBox();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtDiemTB = new TextBox();
            lblDiemTB = new Label();
            cboLop = new ComboBox();
            lblLop = new Label();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            txtTenHS = new TextBox();
            lblTenHS = new Label();
            txtMaHS = new TextBox();
            lblMaHS = new Label();
            grpTimKiem = new GroupBox();
            btnXemTatCa = new Button();
            btnTim = new Button();
            txtTimTen = new TextBox();
            lblTimTen = new Label();
            grpDanhSach = new GroupBox();
            dgvHocSinh = new DataGridView();
            grpThongKe = new GroupBox();
            btnSapXepDiem = new Button();
            btnSapXepTen = new Button();
            lblDiemThapNhat = new Label();
            lblDiemCaoNhat = new Label();
            lblDiemTrungBinh = new Label();
            lblTongSoHS = new Label();
            panelHeader.SuspendLayout();
            grpThongTin.SuspendLayout();
            grpTimKiem.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).BeginInit();
            grpThongKe.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(24, 76, 120);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(934, 50);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(934, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ HỌC SINH (MÔ HÌNH LINQ TO SQL / ENTITY FRAMEWORK)";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpThongTin
            // 
            grpThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTin.Controls.Add(btnLamMoi);
            grpThongTin.Controls.Add(btnSua);
            grpThongTin.Controls.Add(btnXoa);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Controls.Add(txtDiemTB);
            grpThongTin.Controls.Add(lblDiemTB);
            grpThongTin.Controls.Add(cboLop);
            grpThongTin.Controls.Add(lblLop);
            grpThongTin.Controls.Add(txtDiaChi);
            grpThongTin.Controls.Add(lblDiaChi);
            grpThongTin.Controls.Add(dtpNgaySinh);
            grpThongTin.Controls.Add(lblNgaySinh);
            grpThongTin.Controls.Add(txtTenHS);
            grpThongTin.Controls.Add(lblTenHS);
            grpThongTin.Controls.Add(txtMaHS);
            grpThongTin.Controls.Add(lblMaHS);
            grpThongTin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpThongTin.Location = new Point(12, 58);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(910, 160);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin chi tiết học sinh";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(800, 108);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(95, 35);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.BackColor = Color.FromArgb(255, 193, 7);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(690, 108);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 35);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(800, 60);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 35);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.FromArgb(40, 167, 69);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(690, 60);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 35);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(505, 68);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(160, 25);
            txtDiemTB.TabIndex = 11;
            // 
            // lblDiemTB
            // 
            lblDiemTB.AutoSize = true;
            lblDiemTB.Location = new Point(435, 71);
            lblDiemTB.Name = "lblDiemTB";
            lblDiemTB.Size = new Size(61, 17);
            lblDiemTB.TabIndex = 10;
            lblDiemTB.Text = "Điểm TB:";
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(505, 28);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(160, 25);
            cboLop.TabIndex = 9;
            cboLop.SelectedIndexChanged += cboLop_SelectedIndexChanged;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(435, 31);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(60, 17);
            lblLop.TabIndex = 8;
            lblLop.Text = "Lớp học:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDiaChi.Location = new Point(100, 115);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(565, 25);
            txtDiaChi.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(20, 118);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(50, 17);
            lblDiaChi.TabIndex = 6;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(100, 75);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(310, 25);
            dtpNgaySinh.TabIndex = 5;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(20, 78);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(69, 17);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtTenHS
            // 
            txtTenHS.Location = new Point(100, 40);
            txtTenHS.Name = "txtTenHS";
            txtTenHS.Size = new Size(310, 25);
            txtTenHS.TabIndex = 3;
            // 
            // lblTenHS
            // 
            lblTenHS.AutoSize = true;
            lblTenHS.Location = new Point(20, 43);
            lblTenHS.Name = "lblTenHS";
            lblTenHS.Size = new Size(50, 17);
            lblTenHS.TabIndex = 2;
            lblTenHS.Text = "Tên HS:";
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(100, 10);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(310, 25);
            txtMaHS.TabIndex = 1;
            // 
            // lblMaHS
            // 
            lblMaHS.AutoSize = true;
            lblMaHS.Location = new Point(20, 13);
            lblMaHS.Name = "lblMaHS";
            lblMaHS.Size = new Size(50, 17);
            lblMaHS.TabIndex = 0;
            lblMaHS.Text = "Mã HS:";
            // 
            // grpTimKiem
            // 
            grpTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTimKiem.Controls.Add(btnXemTatCa);
            grpTimKiem.Controls.Add(btnTim);
            grpTimKiem.Controls.Add(txtTimTen);
            grpTimKiem.Controls.Add(lblTimTen);
            grpTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpTimKiem.Location = new Point(12, 224);
            grpTimKiem.Name = "grpTimKiem";
            grpTimKiem.Size = new Size(910, 60);
            grpTimKiem.TabIndex = 2;
            grpTimKiem.TabStop = false;
            grpTimKiem.Text = "Tìm kiếm học sinh theo tên (LINQ Where & Contains)";
            // 
            // btnXemTatCa
            // 
            btnXemTatCa.BackColor = Color.FromArgb(23, 162, 184);
            btnXemTatCa.FlatStyle = FlatStyle.Flat;
            btnXemTatCa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXemTatCa.ForeColor = Color.White;
            btnXemTatCa.Location = new Point(480, 20);
            btnXemTatCa.Name = "btnXemTatCa";
            btnXemTatCa.Size = new Size(110, 30);
            btnXemTatCa.TabIndex = 3;
            btnXemTatCa.Text = "Xem tất cả";
            btnXemTatCa.UseVisualStyleBackColor = false;
            btnXemTatCa.Click += btnXemTatCa_Click;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(0, 123, 255);
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(360, 20);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(110, 30);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // txtTimTen
            // 
            txtTimTen.Location = new Point(130, 23);
            txtTimTen.Name = "txtTimTen";
            txtTimTen.Size = new Size(215, 25);
            txtTimTen.TabIndex = 1;
            // 
            // lblTimTen
            // 
            lblTimTen.AutoSize = true;
            lblTimTen.Location = new Point(20, 26);
            lblTimTen.Name = "lblTimTen";
            lblTimTen.Size = new Size(101, 17);
            lblTimTen.TabIndex = 0;
            lblTimTen.Text = "Nhập tên cần tìm:";
            // 
            // grpDanhSach
            // 
            grpDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSach.Controls.Add(dgvHocSinh);
            grpDanhSach.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpDanhSach.Location = new Point(12, 290);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(910, 220);
            grpDanhSach.TabIndex = 3;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách học sinh";
            // 
            // dgvHocSinh
            // 
            dgvHocSinh.AllowUserToAddRows = false;
            dgvHocSinh.AllowUserToDeleteRows = false;
            dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHocSinh.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 76, 120);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHocSinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocSinh.Dock = DockStyle.Fill;
            dgvHocSinh.EnableHeadersVisualStyles = false;
            dgvHocSinh.Location = new Point(3, 21);
            dgvHocSinh.MultiSelect = false;
            dgvHocSinh.Name = "dgvHocSinh";
            dgvHocSinh.ReadOnly = true;
            dgvHocSinh.RowHeadersWidth = 30;
            dgvHocSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHocSinh.Size = new Size(904, 196);
            dgvHocSinh.TabIndex = 0;
            dgvHocSinh.CellClick += dgvHocSinh_CellClick;
            dgvHocSinh.SelectionChanged += dgvHocSinh_SelectionChanged;
            // 
            // grpThongKe
            // 
            grpThongKe.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpThongKe.BackColor = Color.FromArgb(240, 244, 248);
            grpThongKe.Controls.Add(btnSapXepDiem);
            grpThongKe.Controls.Add(btnSapXepTen);
            grpThongKe.Controls.Add(lblDiemThapNhat);
            grpThongKe.Controls.Add(lblDiemCaoNhat);
            grpThongKe.Controls.Add(lblDiemTrungBinh);
            grpThongKe.Controls.Add(lblTongSoHS);
            grpThongKe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpThongKe.Location = new Point(12, 516);
            grpThongKe.Name = "grpThongKe";
            grpThongKe.Size = new Size(910, 60);
            grpThongKe.TabIndex = 4;
            grpThongKe.TabStop = false;
            grpThongKe.Text = "Thống kê LINQ (Count, Average, Max, Min, OrderBy)";
            // 
            // btnSapXepDiem
            // 
            btnSapXepDiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSapXepDiem.BackColor = Color.FromArgb(70, 80, 95);
            btnSapXepDiem.FlatStyle = FlatStyle.Flat;
            btnSapXepDiem.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSapXepDiem.ForeColor = Color.White;
            btnSapXepDiem.Location = new Point(780, 20);
            btnSapXepDiem.Name = "btnSapXepDiem";
            btnSapXepDiem.Size = new Size(115, 30);
            btnSapXepDiem.TabIndex = 5;
            btnSapXepDiem.Text = "Xếp điểm giảm";
            btnSapXepDiem.UseVisualStyleBackColor = false;
            btnSapXepDiem.Click += btnSapXepDiem_Click;
            // 
            // btnSapXepTen
            // 
            btnSapXepTen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSapXepTen.BackColor = Color.FromArgb(70, 80, 95);
            btnSapXepTen.FlatStyle = FlatStyle.Flat;
            btnSapXepTen.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSapXepTen.ForeColor = Color.White;
            btnSapXepTen.Location = new Point(660, 20);
            btnSapXepTen.Name = "btnSapXepTen";
            btnSapXepTen.Size = new Size(115, 30);
            btnSapXepTen.TabIndex = 4;
            btnSapXepTen.Text = "Xếp tên A-Z";
            btnSapXepTen.UseVisualStyleBackColor = false;
            btnSapXepTen.Click += btnSapXepTen_Click;
            // 
            // lblDiemThapNhat
            // 
            lblDiemThapNhat.AutoSize = true;
            lblDiemThapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiemThapNhat.ForeColor = Color.FromArgb(192, 0, 0);
            lblDiemThapNhat.Location = new Point(480, 26);
            lblDiemThapNhat.Name = "lblDiemThapNhat";
            lblDiemThapNhat.Size = new Size(112, 15);
            lblDiemThapNhat.TabIndex = 3;
            lblDiemThapNhat.Text = "ĐTB thấp nhất: 0.00";
            // 
            // lblDiemCaoNhat
            // 
            lblDiemCaoNhat.AutoSize = true;
            lblDiemCaoNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiemCaoNhat.ForeColor = Color.FromArgb(0, 128, 0);
            lblDiemCaoNhat.Location = new Point(330, 26);
            lblDiemCaoNhat.Name = "lblDiemCaoNhat";
            lblDiemCaoNhat.Size = new Size(109, 15);
            lblDiemCaoNhat.TabIndex = 2;
            lblDiemCaoNhat.Text = "ĐTB cao nhất: 0.00";
            // 
            // lblDiemTrungBinh
            // 
            lblDiemTrungBinh.AutoSize = true;
            lblDiemTrungBinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiemTrungBinh.ForeColor = Color.FromArgb(0, 102, 204);
            lblDiemTrungBinh.Location = new Point(170, 26);
            lblDiemTrungBinh.Name = "lblDiemTrungBinh";
            lblDiemTrungBinh.Size = new Size(110, 15);
            lblDiemTrungBinh.TabIndex = 1;
            lblDiemTrungBinh.Text = "ĐTB chung: 0.00";
            // 
            // lblTongSoHS
            // 
            lblTongSoHS.AutoSize = true;
            lblTongSoHS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongSoHS.Location = new Point(20, 26);
            lblTongSoHS.Name = "lblTongSoHS";
            lblTongSoHS.Size = new Size(100, 15);
            lblTongSoHS.TabIndex = 0;
            lblTongSoHS.Text = "Tổng số HS: 0";
            // 
            // frmQLHocSinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(934, 586);
            Controls.Add(grpThongKe);
            Controls.Add(grpDanhSach);
            Controls.Add(grpTimKiem);
            Controls.Add(grpThongTin);
            Controls.Add(panelHeader);
            MinimumSize = new Size(800, 550);
            Name = "frmQLHocSinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LAB 08 - Quản lý Học sinh (LINQ)";
            Load += frmQLHocSinh_Load;
            panelHeader.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpTimKiem.ResumeLayout(false);
            grpTimKiem.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).EndInit();
            grpThongKe.ResumeLayout(false);
            grpThongKe.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private GroupBox grpThongTin;
        private Label lblMaHS;
        private TextBox txtMaHS;
        private TextBox txtTenHS;
        private Label lblTenHS;
        private DateTimePicker dtpNgaySinh;
        private Label lblNgaySinh;
        private TextBox txtDiaChi;
        private Label lblDiaChi;
        private ComboBox cboLop;
        private Label lblLop;
        private TextBox txtDiemTB;
        private Label lblDiemTB;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLamMoi;
        private GroupBox grpTimKiem;
        private Label lblTimTen;
        private TextBox txtTimTen;
        private Button btnTim;
        private Button btnXemTatCa;
        private GroupBox grpDanhSach;
        private DataGridView dgvHocSinh;
        private GroupBox grpThongKe;
        private Label lblTongSoHS;
        private Label lblDiemTrungBinh;
        private Label lblDiemCaoNhat;
        private Label lblDiemThapNhat;
        private Button btnSapXepTen;
        private Button btnSapXepDiem;
    }
}
