using FinalProject.KhachHangUC;
using FinalProject.KhachHangUC.KhuyenMai;
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
    public partial class FormHomeForKhachHang : Form
    {
        string accountLogin;

        public FormHomeForKhachHang(string username)
        {
            InitializeComponent();
            accountLogin = username;
        }

        public string getAccountLogin()
        {
            return accountLogin;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void FormHomeForKhachHang_Load(object sender, EventArgs e)
        {
            btnTrangChu_Click(sender, e);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            position(btnTrangChu);
            UCTrangChu_ForKhachHang ucTrangChu = new UCTrangChu_ForKhachHang();
            addUC(ucTrangChu);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            position(btnDiscount);
            UCViewKhuyenMai ucKhuyenMai = new UCViewKhuyenMai();
            addUC(ucKhuyenMai);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            position(btnCart);
            UCGioHang ucGioHang = new UCGioHang(accountLogin);
            addUC(ucGioHang);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            position(btnHistory);
            UCLichSuMuaHang ucLichSUMuaHang = new UCLichSuMuaHang(accountLogin);
            addUC(ucLichSUMuaHang);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            position(btnProfile);
        }
    }
}
