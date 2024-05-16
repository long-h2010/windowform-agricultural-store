using FinalProject.AdminUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormHomeForAdmin : Form
    {
        public FormHomeForAdmin()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormHomeForAdmin_Load(object sender, EventArgs e)
        {
            panelslide.Height = btnTrangChu.Height;
            position(btnTrangChu);
        }

        private void position(Button b)
        {
            panelslide.Location = new Point(b.Location.X - panelslide.Width, b.Location.Y);
        }

        public void addUC(UserControl uc)
        {
            panelcenter.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelcenter.Controls.Clear();
            panelcenter.Controls.Add(uc);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            position(btnTrangChu);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            position(btnTaiKhoan);
            UCTaiKhoan ucTaiKhoan = new UCTaiKhoan();
            addUC(ucTaiKhoan);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            position(btnDanhMuc);
            UCDanhMuc ucDanhMuc = new UCDanhMuc();
            addUC(ucDanhMuc);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            position(btnSanPham);
            UCSanPham ucSanPham = new UCSanPham();
            addUC(ucSanPham);
        }

        private void btnTinTuc_Click(object sender, EventArgs e)
        {
            position(btnTinTuc);
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            position(btnKhuyenMai);
            UCKhuyenMai ucKhuyenMai = new UCKhuyenMai();
            addUC(ucKhuyenMai);

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            position(btnThongKe);
            UCThongKe ucThongKe = new UCThongKe();
            addUC(ucThongKe);
        }
    }
}
