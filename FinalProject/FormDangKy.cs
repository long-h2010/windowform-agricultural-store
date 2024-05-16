using FinalProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
            panel1.Height, 30, 30));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtMatKhau.Text;
            string name = txtHoTen.Text;
            string phone = txtPhone.Text;
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("User's names cannot be left blank", "Error Message");
                txtHoTen.Focus();
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("User's phone cannot be left blank", "Error Message");
                txtPhone.Focus();
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("User's emails cannot be left blank", "Error Message");
                txtUsername.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("User's password cannot be left blank", "Error Message");
                txtMatKhau.Focus();
            }
            else if (Signin(username, password, name, phone ))
            {
                 new FormHomeForAdmin().Show();
                 this.Hide();
            }     
        }

        bool Signin(string username, string password, string name, string phone)
        {
            return AccountDAO.Instance.Signin(username, password, name, phone);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new FormDangNhap().Show();
        }
    }
}
