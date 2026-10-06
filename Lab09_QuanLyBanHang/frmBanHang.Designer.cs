namespace Lab09_QuanLyBanHang
{
    partial class frmBanHang
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
            grpChonHang = new GroupBox();
            lblGiaDonGia = new Label();
            btnLamMoi = new Button();
            btnXoaHang = new Button();
            btnThem = new Button();
            nudSoLuong = new NumericUpDown();
            lblSoLuong = new Label();
            cboHangHoa = new ComboBox();
            lblHangHoa = new Label();
            grpGioHang = new GroupBox();
            lblTongTien = new Label();
            lblTongTienText = new Label();
            dgvHangHoa = new DataGridView();
            colMaHH = new DataGridViewTextBoxColumn();
            colTenHH = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            grpThanhToan = new GroupBox();
            btnLapHoaDon = new Button();
            txtKhachHang = new TextBox();
            lblKhachHang = new Label();
            panelHeader.SuspendLayout();
            grpChonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            grpGioHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            grpThanhToan.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(24, 76, 120);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(884, 50);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(884, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ BÁN HÀNG ĐƠN GIẢN (LINQ & REPORT)";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpChonHang
            // 
            grpChonHang.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpChonHang.Controls.Add(lblGiaDonGia);
            grpChonHang.Controls.Add(btnLamMoi);
            grpChonHang.Controls.Add(btnXoaHang);
            grpChonHang.Controls.Add(btnThem);
            grpChonHang.Controls.Add(nudSoLuong);
            grpChonHang.Controls.Add(lblSoLuong);
            grpChonHang.Controls.Add(cboHangHoa);
            grpChonHang.Controls.Add(lblHangHoa);
            grpChonHang.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpChonHang.Location = new Point(12, 58);
            grpChonHang.Name = "grpChonHang";
            grpChonHang.Size = new Size(860, 95);
            grpChonHang.TabIndex = 1;
            grpChonHang.TabStop = false;
            grpChonHang.Text = "Chọn hàng hóa mua sắm";
            // 
            // lblGiaDonGia
            // 
            lblGiaDonGia.AutoSize = true;
            lblGiaDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblGiaDonGia.ForeColor = Color.DarkGreen;
            lblGiaDonGia.Location = new Point(115, 60);
            lblGiaDonGia.Name = "lblGiaDonGia";
            lblGiaDonGia.Size = new Size(88, 15);
            lblGiaDonGia.TabIndex = 7;
            lblGiaDonGia.Text = "Đơn giá hiện tại:";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(745, 25);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(95, 32);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoaHang
            // 
            btnXoaHang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoaHang.BackColor = Color.FromArgb(220, 53, 69);
            btnXoaHang.FlatStyle = FlatStyle.Flat;
            btnXoaHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoaHang.ForeColor = Color.White;
            btnXoaHang.Location = new Point(635, 25);
            btnXoaHang.Name = "btnXoaHang";
            btnXoaHang.Size = new Size(100, 32);
            btnXoaHang.TabIndex = 5;
            btnXoaHang.Text = "Xóa mặt hàng";
            btnXoaHang.UseVisualStyleBackColor = false;
            btnXoaHang.Click += btnXoaHang_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.FromArgb(40, 167, 69);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(525, 25);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 32);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(415, 28);
            nudSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(80, 25);
            nudSoLuong.TabIndex = 3;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(345, 31);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(64, 17);
            lblSoLuong.TabIndex = 2;
            lblSoLuong.Text = "Số lượng:";
            // 
            // cboHangHoa
            // 
            cboHangHoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHangHoa.FormattingEnabled = true;
            cboHangHoa.Location = new Point(115, 28);
            cboHangHoa.Name = "cboHangHoa";
            cboHangHoa.Size = new Size(215, 25);
            cboHangHoa.TabIndex = 1;
            cboHangHoa.SelectedIndexChanged += cboHangHoa_SelectedIndexChanged;
            // 
            // lblHangHoa
            // 
            lblHangHoa.AutoSize = true;
            lblHangHoa.Location = new Point(20, 31);
            lblHangHoa.Name = "lblHangHoa";
            lblHangHoa.Size = new Size(95, 17);
            lblHangHoa.TabIndex = 0;
            lblHangHoa.Text = "Chọn hàng hóa:";
            // 
            // grpGioHang
            // 
            grpGioHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpGioHang.Controls.Add(lblTongTien);
            grpGioHang.Controls.Add(lblTongTienText);
            grpGioHang.Controls.Add(dgvHangHoa);
            grpGioHang.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpGioHang.Location = new Point(12, 160);
            grpGioHang.Name = "grpGioHang";
            grpGioHang.Size = new Size(860, 330);
            grpGioHang.TabIndex = 2;
            grpGioHang.TabStop = false;
            grpGioHang.Text = "Danh sách hàng hóa đang chọn mua";
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongTien.ForeColor = Color.FromArgb(192, 0, 0);
            lblTongTien.Location = new Point(620, 295);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(220, 25);
            lblTongTien.TabIndex = 2;
            lblTongTien.Text = "0 đ";
            lblTongTien.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTongTienText
            // 
            lblTongTienText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongTienText.AutoSize = true;
            lblTongTienText.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongTienText.Location = new Point(480, 298);
            lblTongTienText.Name = "lblTongTienText";
            lblTongTienText.Size = new Size(135, 20);
            lblTongTienText.TabIndex = 1;
            lblTongTienText.Text = "TỔNG TIỀN MUA:";
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.AllowUserToDeleteRows = false;
            dgvHangHoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHangHoa.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 76, 120);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Columns.AddRange(new DataGridViewColumn[] { colMaHH, colTenHH, colSoLuong, colDonGia, colThanhTien });
            dgvHangHoa.EnableHeadersVisualStyles = false;
            dgvHangHoa.Location = new Point(10, 25);
            dgvHangHoa.MultiSelect = false;
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.ReadOnly = true;
            dgvHangHoa.RowHeadersWidth = 30;
            dgvHangHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHangHoa.Size = new Size(840, 260);
            dgvHangHoa.TabIndex = 0;
            // 
            // colMaHH
            // 
            colMaHH.DataPropertyName = "MaHH";
            colMaHH.FillWeight = 50F;
            colMaHH.HeaderText = "Mã HH";
            colMaHH.Name = "colMaHH";
            colMaHH.ReadOnly = true;
            // 
            // colTenHH
            // 
            colTenHH.DataPropertyName = "TenHH";
            colTenHH.FillWeight = 160F;
            colTenHH.HeaderText = "Tên hàng hóa";
            colTenHH.Name = "colTenHH";
            colTenHH.ReadOnly = true;
            // 
            // colSoLuong
            // 
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.FillWeight = 50F;
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.Name = "colSoLuong";
            colSoLuong.ReadOnly = true;
            // 
            // colDonGia
            // 
            colDonGia.DataPropertyName = "DonGia";
            colDonGia.FillWeight = 70F;
            colDonGia.HeaderText = "Đơn giá (đ)";
            colDonGia.Name = "colDonGia";
            colDonGia.ReadOnly = true;
            // 
            // colThanhTien
            // 
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.FillWeight = 80F;
            colThanhTien.HeaderText = "Thành tiền (đ)";
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // grpThanhToan
            // 
            grpThanhToan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpThanhToan.Controls.Add(btnLapHoaDon);
            grpThanhToan.Controls.Add(txtKhachHang);
            grpThanhToan.Controls.Add(lblKhachHang);
            grpThanhToan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpThanhToan.Location = new Point(12, 498);
            grpThanhToan.Name = "grpThanhToan";
            grpThanhToan.Size = new Size(860, 65);
            grpThanhToan.TabIndex = 3;
            grpThanhToan.TabStop = false;
            grpThanhToan.Text = "Thanh toán & Lập hóa đơn";
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLapHoaDon.BackColor = Color.FromArgb(0, 123, 255);
            btnLapHoaDon.FlatStyle = FlatStyle.Flat;
            btnLapHoaDon.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLapHoaDon.ForeColor = Color.White;
            btnLapHoaDon.Location = new Point(625, 18);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(215, 35);
            btnLapHoaDon.TabIndex = 2;
            btnLapHoaDon.Text = "LẬP HÓA ĐƠN && IN REPORT";
            btnLapHoaDon.UseVisualStyleBackColor = false;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // txtKhachHang
            // 
            txtKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtKhachHang.Location = new Point(160, 24);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.Size = new Size(440, 25);
            txtKhachHang.TabIndex = 1;
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Location = new Point(20, 27);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(130, 17);
            lblKhachHang.TabIndex = 0;
            lblKhachHang.Text = "Họ tên khách hàng:";
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(884, 576);
            Controls.Add(grpThanhToan);
            Controls.Add(grpGioHang);
            Controls.Add(grpChonHang);
            Controls.Add(panelHeader);
            MinimumSize = new Size(780, 500);
            Name = "frmBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LAB 09 - Quản lý Bán hàng (LINQ + REPORT)";
            Load += frmBanHang_Load;
            panelHeader.ResumeLayout(false);
            grpChonHang.ResumeLayout(false);
            grpChonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            grpGioHang.ResumeLayout(false);
            grpGioHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            grpThanhToan.ResumeLayout(false);
            grpThanhToan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private GroupBox grpChonHang;
        private Label lblHangHoa;
        private ComboBox cboHangHoa;
        private Label lblSoLuong;
        private NumericUpDown nudSoLuong;
        private Button btnThem;
        private Button btnXoaHang;
        private Button btnLamMoi;
        private Label lblGiaDonGia;
        private GroupBox grpGioHang;
        private DataGridView dgvHangHoa;
        private DataGridViewTextBoxColumn colMaHH;
        private DataGridViewTextBoxColumn colTenHH;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private Label lblTongTienText;
        private Label lblTongTien;
        private GroupBox grpThanhToan;
        private Label lblKhachHang;
        private TextBox txtKhachHang;
        private Button btnLapHoaDon;
    }
}
