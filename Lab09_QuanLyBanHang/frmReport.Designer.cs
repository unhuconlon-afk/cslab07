namespace Lab09_QuanLyBanHang
{
    partial class frmReport
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
            panelTop = new Panel();
            lblTitle = new Label();
            panelInvoice = new Panel();
            lblLoiCamOn = new Label();
            lblBangChu = new Label();
            lblTongCong = new Label();
            lblTongTienTitle = new Label();
            dgvChiTiet = new DataGridView();
            colSTT = new DataGridViewTextBoxColumn();
            colMaHH = new DataGridViewTextBoxColumn();
            colTenHH = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            lblNgayLap = new Label();
            lblKhachHang = new Label();
            lblShopInfo = new Label();
            lblShopName = new Label();
            panelActions = new Panel();
            btnDong = new Button();
            btnXemTruoc = new Button();
            btnIn = new Button();
            panelTop.SuspendLayout();
            panelInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(24, 76, 120);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(684, 45);
            panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(684, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HÓA ĐƠN BÁN HÀNG (IN & XEM REPORT)";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelInvoice
            // 
            panelInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelInvoice.BackColor = Color.White;
            panelInvoice.BorderStyle = BorderStyle.FixedSingle;
            panelInvoice.Controls.Add(lblLoiCamOn);
            panelInvoice.Controls.Add(lblBangChu);
            panelInvoice.Controls.Add(lblTongCong);
            panelInvoice.Controls.Add(lblTongTienTitle);
            panelInvoice.Controls.Add(dgvChiTiet);
            panelInvoice.Controls.Add(lblNgayLap);
            panelInvoice.Controls.Add(lblKhachHang);
            panelInvoice.Controls.Add(lblShopInfo);
            panelInvoice.Controls.Add(lblShopName);
            panelInvoice.Location = new Point(20, 55);
            panelInvoice.Name = "panelInvoice";
            panelInvoice.Size = new Size(644, 535);
            panelInvoice.TabIndex = 1;
            // 
            // lblLoiCamOn
            // 
            lblLoiCamOn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLoiCamOn.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblLoiCamOn.ForeColor = Color.Gray;
            lblLoiCamOn.Location = new Point(20, 495);
            lblLoiCamOn.Name = "lblLoiCamOn";
            lblLoiCamOn.Size = new Size(600, 25);
            lblLoiCamOn.TabIndex = 8;
            lblLoiCamOn.Text = "Cảm ơn quý khách đã mua sắm! Hẹn gặp lại quý khách lần sau.";
            lblLoiCamOn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBangChu
            // 
            lblBangChu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBangChu.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblBangChu.Location = new Point(20, 460);
            lblBangChu.Name = "lblBangChu";
            lblBangChu.Size = new Size(600, 25);
            lblBangChu.TabIndex = 7;
            lblBangChu.Text = "Số tiền viết bằng chữ: ...";
            // 
            // lblTongCong
            // 
            lblTongCong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongCong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongCong.ForeColor = Color.FromArgb(192, 0, 0);
            lblTongCong.Location = new Point(410, 425);
            lblTongCong.Name = "lblTongCong";
            lblTongCong.Size = new Size(210, 25);
            lblTongCong.TabIndex = 6;
            lblTongCong.Text = "0 đ";
            lblTongCong.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTongTienTitle
            // 
            lblTongTienTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongTienTitle.AutoSize = true;
            lblTongTienTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongTienTitle.Location = new Point(245, 428);
            lblTongTienTitle.Name = "lblTongTienTitle";
            lblTongTienTitle.Size = new Size(163, 20);
            lblTongTienTitle.TabIndex = 5;
            lblTongTienTitle.Text = "TỔNG CỘNG TIỀN:";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 244, 248);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { colSTT, colMaHH, colTenHH, colSoLuong, colDonGia, colThanhTien });
            dgvChiTiet.EnableHeadersVisualStyles = false;
            dgvChiTiet.Location = new Point(20, 130);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(602, 285);
            dgvChiTiet.TabIndex = 4;
            // 
            // colSTT
            // 
            colSTT.FillWeight = 40F;
            colSTT.HeaderText = "STT";
            colSTT.Name = "colSTT";
            colSTT.ReadOnly = true;
            // 
            // colMaHH
            // 
            colMaHH.FillWeight = 50F;
            colMaHH.HeaderText = "Mã HH";
            colMaHH.Name = "colMaHH";
            colMaHH.ReadOnly = true;
            // 
            // colTenHH
            // 
            colTenHH.FillWeight = 160F;
            colTenHH.HeaderText = "Tên hàng hóa";
            colTenHH.Name = "colTenHH";
            colTenHH.ReadOnly = true;
            // 
            // colSoLuong
            // 
            colSoLuong.FillWeight = 50F;
            colSoLuong.HeaderText = "SL";
            colSoLuong.Name = "colSoLuong";
            colSoLuong.ReadOnly = true;
            // 
            // colDonGia
            // 
            colDonGia.FillWeight = 70F;
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.Name = "colDonGia";
            colDonGia.ReadOnly = true;
            // 
            // colThanhTien
            // 
            colThanhTien.FillWeight = 80F;
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgayLap.Location = new Point(20, 95);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(122, 17);
            lblNgayLap.TabIndex = 3;
            lblNgayLap.Text = "Ngày lập hóa đơn: ...";
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblKhachHang.Location = new Point(20, 70);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(160, 19);
            lblKhachHang.TabIndex = 2;
            lblKhachHang.Text = "Khách hàng: Nguyễn Văn A";
            // 
            // lblShopInfo
            // 
            lblShopInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblShopInfo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblShopInfo.ForeColor = Color.DimGray;
            lblShopInfo.Location = new Point(20, 38);
            lblShopInfo.Name = "lblShopInfo";
            lblShopInfo.Size = new Size(602, 20);
            lblShopInfo.TabIndex = 1;
            lblShopInfo.Text = "Địa chỉ: 280 An Dương Vương, P.4, Q.5, TP.HCM | ĐT: 028.38352020";
            lblShopInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShopName
            // 
            lblShopName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblShopName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblShopName.ForeColor = Color.FromArgb(24, 76, 120);
            lblShopName.Location = new Point(20, 10);
            lblShopName.Name = "lblShopName";
            lblShopName.Size = new Size(602, 28);
            lblShopName.TabIndex = 0;
            lblShopName.Text = "CỬA HÀNG BÁN LẺ TIỆN LỢI";
            lblShopName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnDong);
            panelActions.Controls.Add(btnXemTruoc);
            panelActions.Controls.Add(btnIn);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(0, 597);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(684, 54);
            panelActions.TabIndex = 2;
            // 
            // btnDong
            // 
            btnDong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDong.BackColor = Color.FromArgb(108, 117, 125);
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(545, 10);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(115, 35);
            btnDong.TabIndex = 2;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // btnXemTruoc
            // 
            btnXemTruoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXemTruoc.BackColor = Color.FromArgb(23, 162, 184);
            btnXemTruoc.FlatStyle = FlatStyle.Flat;
            btnXemTruoc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnXemTruoc.ForeColor = Color.White;
            btnXemTruoc.Location = new Point(415, 10);
            btnXemTruoc.Name = "btnXemTruoc";
            btnXemTruoc.Size = new Size(120, 35);
            btnXemTruoc.TabIndex = 1;
            btnXemTruoc.Text = "Xem trước in";
            btnXemTruoc.UseVisualStyleBackColor = false;
            btnXemTruoc.Click += btnXemTruoc_Click;
            // 
            // btnIn
            // 
            btnIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIn.BackColor = Color.FromArgb(40, 167, 69);
            btnIn.FlatStyle = FlatStyle.Flat;
            btnIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIn.ForeColor = Color.White;
            btnIn.Location = new Point(285, 10);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(120, 35);
            btnIn.TabIndex = 0;
            btnIn.Text = "In hóa đơn";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(684, 651);
            Controls.Add(panelActions);
            Controls.Add(panelInvoice);
            Controls.Add(panelTop);
            MinimumSize = new Size(600, 500);
            Name = "frmReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu In Hóa Đơn Bán Hàng";
            Load += frmReport_Load;
            panelTop.ResumeLayout(false);
            panelInvoice.ResumeLayout(false);
            panelInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblTitle;
        private Panel panelInvoice;
        private Label lblShopName;
        private Label lblShopInfo;
        private Label lblKhachHang;
        private Label lblNgayLap;
        private DataGridView dgvChiTiet;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colMaHH;
        private DataGridViewTextBoxColumn colTenHH;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private Label lblTongTienTitle;
        private Label lblTongCong;
        private Label lblBangChu;
        private Label lblLoiCamOn;
        private Panel panelActions;
        private Button btnIn;
        private Button btnXemTruoc;
        private Button btnDong;
    }
}
