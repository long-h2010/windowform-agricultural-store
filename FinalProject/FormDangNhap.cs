using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FinalProject.DAO;

namespace FinalProject
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
            panel1.Height, 30, 30));
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsernameDangNhap.Text;
            string password = txtMatKhauDangNhap.Text;
            if (txtUsernameDangNhap.Text == "")
            {
                MessageBox.Show("User emails cannot be left blank", "Error Message");
                txtUsernameDangNhap.Focus();
            }
            else if (txtMatKhauDangNhap.Text == "")
            {
                MessageBox.Show("User password cannot be left blank", "Error Message");
                txtMatKhauDangNhap.Focus();
            }
            else if(Login(username, password))
            {
                if (AccountDAO.Instance.getTypeAccount(username).Rows[0].Field<int>(0) == 1)
                    new FormHomeForAdmin().Show();
                else
                    new FormHomeForKhachHang(username).Show();

                this.Hide();
            }
            
        }

        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username,password);
        }

        private void btnXDangNhap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelDangKy_Click(object sender, EventArgs e)
        {
            new FormDangKy().Show();
        }

        private void txtEmailDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhauDangNhap_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void txtMatKhauDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
