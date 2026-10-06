using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab09_QuanLyBanHang
{
    public partial class frmBanHang : Form
    {
        private QLBHDataContext db = new QLBHDataContext();
        // Chứa danh sách các mặt hàng đang chọn theo mục 4.2 giáo trình
        private List<HangChonMua> dsmua = new List<HangChonMua>();

        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu vào combobox hàng hóa theo mục 4.3
            cboHangHoa.DataSource = db.HangHoas.OrderBy(h => h.MaHH).ToList();
            cboHangHoa.DisplayMember = "TenHH";
            cboHangHoa.ValueMember = "MaHH";

            CapNhatDonGiaLabel();
            hien_thi_ds_mua();
        }

        private void cboHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatDonGiaLabel();
        }

        private void CapNhatDonGiaLabel()
        {
            if (cboHangHoa.SelectedItem is HangHoa hh)
            {
                lblGiaDonGia.Text = $"Đơn giá niêm yết: {hh.DonGia:#,##0} đ/đơn vị";
            }
        }

        /// <summary>
        /// Xử lý nút Thêm theo mục 4.4 giáo trình
        /// </summary>
        private void btnThem_Click(object sender, EventArgs e)
        {
            int soluong;
            if (!int.TryParse(nudSoLuong.Value.ToString(), out soluong) || soluong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboHangHoa.SelectedValue == null) return;

            // Lấy mã hàng hóa đang chọn
            int mahh = int.Parse(cboHangHoa.SelectedValue.ToString()!);

            // Kiểm tra xem hàng hóa đó đã có trong giỏ hay chưa
            HangChonMua? hcm = dsmua.SingleOrDefault(p => p.MaHH == mahh);

            if (hcm == null) // Chưa có
            {
                // Lấy hàng hóa có mã
                HangHoa? hh = db.HangHoas.SingleOrDefault(p => p.MaHH == mahh);
                if (hh != null)
                {
                    // Thêm vào list dsmua
                    dsmua.Add(new HangChonMua
                    {
                        MaHH = hh.MaHH,
                        TenHH = hh.TenHH,
                        DonGia = hh.DonGia,
                        SoLuong = soluong
                    });
                }
            }
            else // Có rồi -> cập nhật số lượng
            {
                hcm.SoLuong += soluong;
                MessageBox.Show($"Đã cập nhật số lượng mới: {hcm.SoLuong}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Hiển thị lưới
            hien_thi_ds_mua();
            nudSoLuong.Value = 1;
        }

        /// <summary>
        /// Hiển thị danh sách mua theo mục 4.5 giáo trình
        /// </summary>
        private void hien_thi_ds_mua()
        {
            dgvHangHoa.DataSource = null;
            dgvHangHoa.DataSource = dsmua.ToList();

            // Sử dụng LINQ Sum để tính tổng tiền
            lblTongTien.Text = dsmua.Sum(p => p.SoLuong * p.DonGia).ToString("#,##0.00") + " đ";
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            if (dgvHangHoa.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng trong giỏ cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvHangHoa.CurrentRow.DataBoundItem is HangChonMua hcm)
            {
                dsmua.Remove(hcm);
                hien_thi_ds_mua();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dsmua.Clear();
            hien_thi_ds_mua();
            nudSoLuong.Value = 1;
        }

        /// <summary>
        /// Xử lý nút Lập hóa đơn theo mục 4.6 và mở Report theo mục 5.8 giáo trình
        /// </summary>
        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            if (!dsmua.Any())
            {
                MessageBox.Show("Danh sách mua hàng đang trống! Vui lòng chọn hàng hóa trước khi lập hóa đơn.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string khachHang = txtKhachHang.Text.Trim();
            if (string.IsNullOrEmpty(khachHang))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhachHang.Focus();
                return;
            }

            try
            {
                // Tạo mới hóa đơn
                HoaDon hd = new HoaDon
                {
                    NgayLapHD = DateTime.Now,
                    KhachHang = khachHang,
                    TongTien = dsmua.Sum(p => p.ThanhTien)
                };

                // Thêm hóa đơn
                db.HoaDons.InsertOnSubmit(hd);
                // Cập nhật để sinh MaHD
                db.SubmitChanges();

                // Thêm chi tiết hóa đơn
                foreach (HangChonMua hcm in dsmua)
                {
                    var cthd = new CTHoaDon
                    {
                        MaHD = hd.MaHD,
                        MaHH = hcm.MaHH,
                        SoLuong = hcm.SoLuong
                    };
                    db.CTHoaDons.InsertOnSubmit(cthd);
                }
                db.SubmitChanges();

                MessageBox.Show($"Đã thêm thành công hóa đơn #{hd.MaHD} vào CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị Report theo mục 5.8 giáo trình
                frmReport f = new frmReport(khachHang, dsmua.ToList());
                f.ShowDialog();

                // Cập nhật lại giao diện bán hàng
                txtKhachHang.Text = "";
                dsmua.Clear();
                hien_thi_ds_mua(); // Cập nhật lưới
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lập hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
