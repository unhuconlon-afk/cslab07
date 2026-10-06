using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Lab08_QuanLyHocSinh
{
    public partial class frmQLHocSinh : Form
    {
        private QLHSDataContext db = new QLHSDataContext();
        private bool _isBinding = false;

        public frmQLHocSinh()
        {
            InitializeComponent();
        }

        private void frmQLHocSinh_Load(object sender, EventArgs e)
        {
            _isBinding = true;
            try
            {
                // Đổ dữ liệu vào combobox Lớp
                var dsLop = db.Lops.OrderBy(l => l.MaLop).ToList();
                cboLop.DataSource = dsLop;
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";
            }
            finally
            {
                _isBinding = false;
            }

            // Lấy học sinh theo lớp (đang chọn)
            fillHocSinhByLop();
        }

        /// <summary>
        /// Lấy danh sách học sinh theo lớp và lọc gần đúng theo tên
        /// </summary>
        private void fillHocSinhByLop()
        {
            if (_isBinding || cboLop.SelectedValue == null) return;

            string selectedMaLop = cboLop.SelectedValue.ToString() ?? "";
            string tenTim = txtTimTen.Text.Trim().ToLower();

            var query = db.HocSinhs
                .Include(h => h.Lop)
                .Where(p => p.MaLop == selectedMaLop);

            if (!string.IsNullOrEmpty(tenTim))
            {
                query = query.Where(p => p.TenHS.ToLower().Contains(tenTim));
            }

            CapNhatDataGrid(query.ToList());
        }

        private void CapNhatDataGrid(List<HocSinh> list)
        {
            dgvHocSinh.DataSource = null;

            // Sử dụng LINQ Select để chiếu sang anonymous type hiển thị trên DataGridView
            var displayList = list.Select(p => new
            {
                MaHS = p.MaHS,
                TenHS = p.TenHS,
                TenLop = p.Lop != null ? p.Lop.TenLop : p.MaLop,
                DTB = p.DTB,
                NgaySinh = p.NgaySinh.ToString("dd/MM/yyyy"),
                DiaChi = p.DiaChi ?? ""
            }).ToList();

            dgvHocSinh.DataSource = displayList;

            // Định dạng tiêu đề cột
            if (dgvHocSinh.Columns.Count >= 6)
            {
                if (dgvHocSinh.Columns["MaHS"] != null) dgvHocSinh.Columns["MaHS"]!.HeaderText = "Mã HS";
                if (dgvHocSinh.Columns["TenHS"] != null) dgvHocSinh.Columns["TenHS"]!.HeaderText = "Tên học sinh";
                if (dgvHocSinh.Columns["TenLop"] != null) dgvHocSinh.Columns["TenLop"]!.HeaderText = "Lớp học";
                if (dgvHocSinh.Columns["DTB"] != null) dgvHocSinh.Columns["DTB"]!.HeaderText = "Điểm TB";
                if (dgvHocSinh.Columns["NgaySinh"] != null) dgvHocSinh.Columns["NgaySinh"]!.HeaderText = "Ngày sinh";
                if (dgvHocSinh.Columns["DiaChi"] != null) dgvHocSinh.Columns["DiaChi"]!.HeaderText = "Địa chỉ";
            }

            // Tính toán các hàm thống kê LINQ theo giáo trình
            CapNhatThongKeLINQ(list);
        }

        /// <summary>
        /// Minh họa các hàm tổng hợp của LINQ: Count, Average, Max, Min
        /// </summary>
        private void CapNhatThongKeLINQ(List<HocSinh> list)
        {
            int count = list.Count();
            lblTongSoHS.Text = $"Tổng số HS: {count}";

            if (count > 0)
            {
                double avg = list.Average(p => p.DTB);
                float max = list.Max(p => p.DTB);
                float min = list.Min(p => p.DTB);

                lblDiemTrungBinh.Text = $"ĐTB chung: {avg:F2}";
                lblDiemCaoNhat.Text = $"ĐTB cao nhất: {max:F2}";
                lblDiemThapNhat.Text = $"ĐTB thấp nhất: {min:F2}";
            }
            else
            {
                lblDiemTrungBinh.Text = "ĐTB chung: 0.00";
                lblDiemCaoNhat.Text = "ĐTB cao nhất: 0.00";
                lblDiemThapNhat.Text = "ĐTB thấp nhất: 0.00";
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillHocSinhByLop();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            fillHocSinhByLop();
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            string tenTim = txtTimTen.Text.Trim().ToLower();
            var query = db.HocSinhs.Include(h => h.Lop).AsQueryable();

            if (!string.IsNullOrEmpty(tenTim))
            {
                query = query.Where(p => p.TenHS.ToLower().Contains(tenTim));
            }

            CapNhatDataGrid(query.ToList());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHS = txtMaHS.Text.Trim();
            string tenHS = txtTenHS.Text.Trim();

            if (string.IsNullOrEmpty(maHS) || string.IsNullOrEmpty(tenHS))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã học sinh và Tên học sinh!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHS.Focus();
                return;
            }

            if (!float.TryParse(txtDiemTB.Text.Trim(), out float dtb) || dtb < 0 || dtb > 10)
            {
                MessageBox.Show("Điểm trung bình phải từ 0.0 đến 10.0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiemTB.Focus();
                return;
            }

            if (cboLop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã học sinh bằng LINQ SingleOrDefault
            var tonTai = db.HocSinhs.SingleOrDefault(p => p.MaHS == maHS);
            if (tonTai != null)
            {
                MessageBox.Show($"Mã học sinh '{maHS}' đã tồn tại trong cơ sở dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHS.Focus();
                return;
            }

            try
            {
                // 1. Tạo đối tượng
                HocSinh hs = new HocSinh
                {
                    MaHS = maHS,
                    TenHS = tenHS,
                    NgaySinh = dtpNgaySinh.Value,
                    DiaChi = txtDiaChi.Text.Trim(),
                    MaLop = cboLop.SelectedValue.ToString()!,
                    DTB = dtb
                };

                // 2. Thêm
                db.HocSinhs.InsertOnSubmit(hs);

                // 3. Cập nhật
                db.SubmitChanges();

                MessageBox.Show("Thêm học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi_Click(sender, e);
                fillHocSinhByLop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm học sinh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHS = txtMaHS.Text.Trim();
            if (string.IsNullOrEmpty(maHS))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Mã học sinh cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Tìm đối tượng cần xóa bằng LINQ SingleOrDefault
            HocSinh? hs = db.HocSinhs.SingleOrDefault(p => p.MaHS == maHS);

            // nếu có
            if (hs != null)
            {
                var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa học sinh '{hs.TenHS}' (Mã: {hs.MaHS})?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                try
                {
                    // 2. Xóa
                    db.HocSinhs.DeleteOnSubmit(hs);

                    // 3. Cập nhật
                    db.SubmitChanges();

                    MessageBox.Show("Xóa học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi_Click(sender, e);
                    fillHocSinhByLop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa học sinh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Không tìm thấy học sinh có mã '{maHS}'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHS = txtMaHS.Text.Trim();
            if (string.IsNullOrEmpty(maHS))
            {
                MessageBox.Show("Vui lòng chọn học sinh cần sửa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenHS = txtTenHS.Text.Trim();
            if (string.IsNullOrEmpty(tenHS))
            {
                MessageBox.Show("Vui lòng nhập tên học sinh!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHS.Focus();
                return;
            }

            if (!float.TryParse(txtDiemTB.Text.Trim(), out float dtb) || dtb < 0 || dtb > 10)
            {
                MessageBox.Show("Điểm trung bình phải từ 0.0 đến 10.0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiemTB.Focus();
                return;
            }

            // 1. Tìm đối tượng cần sửa bằng LINQ SingleOrDefault
            HocSinh? hs = db.HocSinhs.SingleOrDefault(p => p.MaHS == maHS);
            if (hs != null)
            {
                try
                {
                    // 2. Tiến hành sửa
                    hs.MaLop = cboLop.SelectedValue?.ToString() ?? hs.MaLop;
                    hs.TenHS = tenHS;
                    hs.NgaySinh = dtpNgaySinh.Value;
                    hs.DiaChi = txtDiaChi.Text.Trim();
                    hs.DTB = dtb;

                    // 3. Cập nhật
                    db.SubmitChanges();

                    MessageBox.Show("Cập nhật thông tin học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillHocSinhByLop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật học sinh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Không tìm thấy học sinh có mã '{maHS}'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHS.Clear();
            txtTenHS.Clear();
            txtDiaChi.Clear();
            txtDiemTB.Clear();
            txtTimTen.Clear();
            dtpNgaySinh.Value = new DateTime(2008, 1, 1);
            if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
            txtMaHS.Focus();
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoBindingHocSinh();
        }

        private void dgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            DoBindingHocSinh();
        }

        private void DoBindingHocSinh()
        {
            if (dgvHocSinh.CurrentRow == null || dgvHocSinh.CurrentRow.Index < 0) return;

            var row = dgvHocSinh.CurrentRow;
            string maHS = row.Cells["MaHS"].Value?.ToString() ?? "";
            if (string.IsNullOrEmpty(maHS)) return;

            var hs = db.HocSinhs.SingleOrDefault(p => p.MaHS == maHS);
            if (hs != null)
            {
                txtMaHS.Text = hs.MaHS;
                txtTenHS.Text = hs.TenHS;
                dtpNgaySinh.Value = hs.NgaySinh;
                txtDiaChi.Text = hs.DiaChi ?? "";
                txtDiemTB.Text = hs.DTB.ToString("0.00");

                for (int i = 0; i < cboLop.Items.Count; i++)
                {
                    if (cboLop.Items[i] is Lop lop && lop.MaLop == hs.MaLop)
                    {
                        cboLop.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        // Các hàm sắp xếp LINQ OrderBy và OrderByDescending
        private void btnSapXepTen_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null) return;
            string selectedMaLop = cboLop.SelectedValue.ToString()!;
            var ds = db.HocSinhs.Where(p => p.MaLop == selectedMaLop)
                                .OrderBy(p => p.TenHS)
                                .ToList();
            CapNhatDataGrid(ds);
        }

        private void btnSapXepDiem_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null) return;
            string selectedMaLop = cboLop.SelectedValue.ToString()!;
            var ds = db.HocSinhs.Where(p => p.MaLop == selectedMaLop)
                                .OrderByDescending(p => p.DTB)
                                .ToList();
            CapNhatDataGrid(ds);
        }
    }
}
