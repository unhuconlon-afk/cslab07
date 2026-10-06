namespace cslab07_Launcher
{
    partial class frmLauncher
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
            panelHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            grpLab08 = new GroupBox();
            btnChayLab08 = new Button();
            lblDescLab08 = new Label();
            grpLab09 = new GroupBox();
            btnChayLab09 = new Button();
            lblDescLab09 = new Label();
            panelFooter = new Panel();
            btnThoat = new Button();
            lblFooterInfo = new Label();
            panelHeader.SuspendLayout();
            grpLab08.SuspendLayout();
            grpLab09.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(24, 76, 120);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(734, 75);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Dock = DockStyle.Bottom;
            lblSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitle.ForeColor = Color.FromArgb(200, 225, 250);
            lblSubtitle.Location = new Point(0, 42);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(734, 33);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Môn học: Lập trình Windows | Giảng viên: ThS. Lương Trần Hy Hiến (FIT - HCMUP)";
            lblSubtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(734, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HỆ THỐNG THỰC HÀNH C# - LAB 08 & LAB 09";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpLab08
            // 
            grpLab08.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpLab08.BackColor = Color.White;
            grpLab08.Controls.Add(btnChayLab08);
            grpLab08.Controls.Add(lblDescLab08);
            grpLab08.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpLab08.ForeColor = Color.FromArgb(24, 76, 120);
            grpLab08.Location = new Point(25, 95);
            grpLab08.Name = "grpLab08";
            grpLab08.Size = new Size(684, 150);
            grpLab08.TabIndex = 1;
            grpLab08.TabStop = false;
            grpLab08.Text = "📌 LAB 08: QUẢN LÝ HỌC SINH (LINQ TO SQL / ENTITY FRAMEWORK)";
            // 
            // btnChayLab08
            // 
            btnChayLab08.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnChayLab08.BackColor = Color.FromArgb(40, 167, 69);
            btnChayLab08.FlatStyle = FlatStyle.Flat;
            btnChayLab08.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnChayLab08.ForeColor = Color.White;
            btnChayLab08.Location = new Point(480, 95);
            btnChayLab08.Name = "btnChayLab08";
            btnChayLab08.Size = new Size(185, 40);
            btnChayLab08.TabIndex = 1;
            btnChayLab08.Text = "🚀 KHỞI CHẠY LAB 08";
            btnChayLab08.UseVisualStyleBackColor = false;
            btnChayLab08.Click += btnChayLab08_Click;
            // 
            // lblDescLab08
            // 
            lblDescLab08.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescLab08.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescLab08.ForeColor = Color.FromArgb(50, 50, 50);
            lblDescLab08.Location = new Point(15, 30);
            lblDescLab08.Name = "lblDescLab08";
            lblDescLab08.Size = new Size(650, 60);
            lblDescLab08.TabIndex = 0;
            lblDescLab08.Text = "• Lập trình kết nối CSDL theo mô hình 2 lớp LINQ.\n• Lọc học sinh theo ComboBox Lớp và tìm kiếm gần đúng theo tên.\n• Thao tác CRUD: InsertOnSubmit, DeleteOnSubmit, SubmitChanges.\n• Áp dụng các hàm tổng hợp LINQ: Count(), Average(), Max(), Min(), OrderBy().";
            // 
            // grpLab09
            // 
            grpLab09.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpLab09.BackColor = Color.White;
            grpLab09.Controls.Add(btnChayLab09);
            grpLab09.Controls.Add(lblDescLab09);
            grpLab09.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpLab09.ForeColor = Color.FromArgb(24, 76, 120);
            grpLab09.Location = new Point(25, 265);
            grpLab09.Name = "grpLab09";
            grpLab09.Size = new Size(684, 150);
            grpLab09.TabIndex = 2;
            grpLab09.TabStop = false;
            grpLab09.Text = "📌 LAB 09: QUẢN LÝ BÁN HÀNG ĐƠN GIẢN (LINQ + REPORT)";
            // 
            // btnChayLab09
            // 
            btnChayLab09.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnChayLab09.BackColor = Color.FromArgb(0, 123, 255);
            btnChayLab09.FlatStyle = FlatStyle.Flat;
            btnChayLab09.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnChayLab09.ForeColor = Color.White;
            btnChayLab09.Location = new Point(480, 95);
            btnChayLab09.Name = "btnChayLab09";
            btnChayLab09.Size = new Size(185, 40);
            btnChayLab09.TabIndex = 1;
            btnChayLab09.Text = "🚀 KHỞI CHẠY LAB 09";
            btnChayLab09.UseVisualStyleBackColor = false;
            btnChayLab09.Click += btnChayLab09_Click;
            // 
            // lblDescLab09
            // 
            lblDescLab09.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescLab09.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescLab09.ForeColor = Color.FromArgb(50, 50, 50);
            lblDescLab09.Location = new Point(15, 30);
            lblDescLab09.Name = "lblDescLab09";
            lblDescLab09.Size = new Size(650, 60);
            lblDescLab09.TabIndex = 0;
            lblDescLab09.Text = "• Chọn mặt hàng và số lượng với NumericUpDown; Thêm/Cập nhật vào DTO HangChonMua.\n• Tính tổng tiền giỏ hàng bằng LINQ Sum().\n• Lập hóa đơn: Lưu thông tin KhachHang, HoaDon và CTHoaDon vào CSDL.\n• Mở Form Report: In & Xem trước hóa đơn bán hàng (PrintDocument / Preview).";
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(btnThoat);
            panelFooter.Controls.Add(lblFooterInfo);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 435);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(734, 55);
            panelFooter.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThoat.BackColor = Color.FromArgb(108, 117, 125);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(605, 10);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 35);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblFooterInfo
            // 
            lblFooterInfo.AutoSize = true;
            lblFooterInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblFooterInfo.ForeColor = Color.Gray;
            lblFooterInfo.Location = new Point(25, 20);
            lblFooterInfo.Name = "lblFooterInfo";
            lblFooterInfo.Size = new Size(335, 15);
            lblFooterInfo.TabIndex = 0;
            lblFooterInfo.Text = "Hỗ trợ chạy độc lập trên mọi máy (Tự động tạo CSDL mẫu SQLite)";
            // 
            // frmLauncher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(734, 490);
            Controls.Add(panelFooter);
            Controls.Add(grpLab09);
            Controls.Add(grpLab08);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmLauncher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CSLAB07 - Trình Khởi Chạy Bài Tập Thực Hành LAB 08 & LAB 09";
            panelHeader.ResumeLayout(false);
            grpLab08.ResumeLayout(false);
            grpLab09.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private GroupBox grpLab08;
        private Button btnChayLab08;
        private Label lblDescLab08;
        private GroupBox grpLab09;
        private Button btnChayLab09;
        private Label lblDescLab09;
        private Panel panelFooter;
        private Label lblFooterInfo;
        private Button btnThoat;
    }
}
