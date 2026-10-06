using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Lab09_QuanLyBanHang
{
    public partial class frmReport : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string HoTenKH { get; set; } = "";

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<HangChonMua> DSMua { get; set; } = new List<HangChonMua>();

        private PrintDocument printDoc = new PrintDocument();
        private PrintPreviewDialog printPreview = new PrintPreviewDialog();

        public frmReport(string hoten, List<HangChonMua> dsmua)
        {
            InitializeComponent();
            HoTenKH = hoten;
            DSMua = dsmua ?? new List<HangChonMua>();

            printDoc.PrintPage += PrintDoc_PrintPage;
        }

        public frmReport()
        {
            InitializeComponent();
            printDoc.PrintPage += PrintDoc_PrintPage;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            lblKhachHang.Text = $"Khách hàng: {(string.IsNullOrEmpty(HoTenKH) ? "Khách vãng lai" : HoTenKH)}";
            lblNgayLap.Text = $"Ngày lập hóa đơn: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";

            dgvChiTiet.Rows.Clear();
            int stt = 1;
            foreach (var item in DSMua)
            {
                dgvChiTiet.Rows.Add(
                    stt++,
                    item.MaHH,
                    item.TenHH,
                    item.SoLuong,
                    $"{item.DonGia:#,##0} đ",
                    $"{item.ThanhTien:#,##0} đ"
                );
            }

            // Sử dụng LINQ Sum để tính tổng cộng tiền
            double tongTien = DSMua.Sum(p => p.ThanhTien);
            lblTongCong.Text = $"{tongTien:#,##0} đ";
            lblBangChu.Text = $"Số tiền viết bằng chữ: {SoTienBangChu(tongTien)}";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using (PrintDialog pd = new PrintDialog())
            {
                pd.Document = printDoc;
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }
            }
        }

        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            printPreview.Document = printDoc;
            printPreview.WindowState = FormWindowState.Maximized;
            printPreview.ShowDialog();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (e.Graphics == null) return;
            Graphics g = e.Graphics;

            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font regularFont = new Font("Arial", 10, FontStyle.Regular);
            Font italicFont = new Font("Arial", 9, FontStyle.Italic);

            float y = 50;
            float leftMargin = 50;

            // Tiêu đề
            string title = "HÓA ĐƠN BÁN HÀNG";
            SizeF titleSize = g.MeasureString(title, titleFont);
            g.DrawString(title, titleFont, Brushes.Black, (e.PageBounds.Width - titleSize.Width) / 2, y);
            y += 35;

            string storeInfo = "CỬA HÀNG BÁN LẺ TIỆN LỢI - 280 An Dương Vương, Q.5, TP.HCM";
            SizeF storeSize = g.MeasureString(storeInfo, italicFont);
            g.DrawString(storeInfo, italicFont, Brushes.Gray, (e.PageBounds.Width - storeSize.Width) / 2, y);
            y += 30;

            g.DrawLine(Pens.Black, leftMargin, y, e.PageBounds.Width - leftMargin, y);
            y += 15;

            // Thông tin khách hàng & ngày
            g.DrawString($"Khách hàng: {(string.IsNullOrEmpty(HoTenKH) ? "Khách vãng lai" : HoTenKH)}", regularFont, Brushes.Black, leftMargin, y);
            y += 20;
            g.DrawString($"Ngày lập: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", regularFont, Brushes.Black, leftMargin, y);
            y += 30;

            // Header bảng
            g.DrawString("STT", headerFont, Brushes.Black, leftMargin, y);
            g.DrawString("Tên hàng hóa", headerFont, Brushes.Black, leftMargin + 50, y);
            g.DrawString("SL", headerFont, Brushes.Black, leftMargin + 320, y);
            g.DrawString("Đơn giá", headerFont, Brushes.Black, leftMargin + 380, y);
            g.DrawString("Thành tiền", headerFont, Brushes.Black, leftMargin + 480, y);
            y += 20;
            g.DrawLine(Pens.Gray, leftMargin, y, e.PageBounds.Width - leftMargin, y);
            y += 10;

            int index = 1;
            foreach (var item in DSMua)
            {
                g.DrawString(index.ToString(), regularFont, Brushes.Black, leftMargin, y);
                g.DrawString(item.TenHH, regularFont, Brushes.Black, leftMargin + 50, y);
                g.DrawString(item.SoLuong.ToString(), regularFont, Brushes.Black, leftMargin + 320, y);
                g.DrawString($"{item.DonGia:#,##0}", regularFont, Brushes.Black, leftMargin + 380, y);
                g.DrawString($"{item.ThanhTien:#,##0}", regularFont, Brushes.Black, leftMargin + 480, y);
                y += 25;
                index++;
            }

            y += 10;
            g.DrawLine(Pens.Black, leftMargin, y, e.PageBounds.Width - leftMargin, y);
            y += 15;

            // Tổng tiền
            double tongTien = DSMua.Sum(p => p.ThanhTien);
            g.DrawString($"TỔNG CỘNG TIỀN: {tongTien:#,##0} VNĐ", headerFont, Brushes.DarkRed, leftMargin + 350, y);
            y += 25;

            g.DrawString($"Bằng chữ: {SoTienBangChu(tongTien)}", italicFont, Brushes.Black, leftMargin, y);
            y += 40;

            string thankYou = "Xin cảm ơn quý khách và hẹn gặp lại!";
            SizeF thankSize = g.MeasureString(thankYou, italicFont);
            g.DrawString(thankYou, italicFont, Brushes.Black, (e.PageBounds.Width - thankSize.Width) / 2, y);
        }

        private string SoTienBangChu(double soTien)
        {
            if (soTien <= 0) return "Không đồng";
            long n = (long)soTien;

            string[] chuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = { "", "nghìn", "triệu", "tỷ" };

            List<string> parts = new List<string>();
            int hangIndex = 0;

            while (n > 0)
            {
                int block = (int)(n % 1000);
                if (block > 0)
                {
                    string blockStr = DocBlock3ChuSo(block, chuSo, n >= 1000);
                    string donVi = hang[hangIndex];
                    if (!string.IsNullOrEmpty(donVi))
                    {
                        parts.Insert(0, $"{blockStr} {donVi}");
                    }
                    else
                    {
                        parts.Insert(0, blockStr);
                    }
                }
                n /= 1000;
                hangIndex++;
            }

            string result = string.Join(" ", parts).Trim() + " đồng";
            // Viết hoa chữ cái đầu tiên
            if (result.Length > 0)
            {
                result = char.ToUpper(result[0]) + result.Substring(1);
            }
            return result;
        }

        private string DocBlock3ChuSo(int number, string[] chuSo, bool coHangTruoc)
        {
            int tram = number / 100;
            int chuc = (number % 100) / 10;
            int donVi = number % 10;

            List<string> res = new List<string>();

            if (tram > 0 || coHangTruoc)
            {
                res.Add(chuSo[tram] + " trăm");
            }

            if (chuc > 1)
            {
                res.Add(chuSo[chuc] + " mươi");
                if (donVi == 1) res.Add("mốt");
                else if (donVi == 5) res.Add("lăm");
                else if (donVi > 0) res.Add(chuSo[donVi]);
            }
            else if (chuc == 1)
            {
                res.Add("mười");
                if (donVi == 5) res.Add("lăm");
                else if (donVi > 0) res.Add(chuSo[donVi]);
            }
            else if (chuc == 0 && donVi > 0)
            {
                if (tram > 0 || coHangTruoc) res.Add("lẻ");
                res.Add(chuSo[donVi]);
            }

            return string.Join(" ", res);
        }
    }
}
