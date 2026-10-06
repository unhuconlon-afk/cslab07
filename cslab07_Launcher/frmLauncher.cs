using System;
using System.Windows.Forms;

namespace cslab07_Launcher
{
    public partial class frmLauncher : Form
    {
        public frmLauncher()
        {
            InitializeComponent();
        }

        private void btnChayLab08_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new Lab08_QuanLyHocSinh.frmQLHocSinh())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void btnChayLab09_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new Lab09_QuanLyBanHang.frmBanHang())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
