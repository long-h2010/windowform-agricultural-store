using FinalProject.DAO;
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
    public partial class UCTaiKhoan : UserControl
    {
        BindingSource accountList = new BindingSource();

        public UCTaiKhoan()
        {
            InitializeComponent();
            UCTaiKhoan_Load();
        }

        private void UCTaiKhoan_Load()
        {
            dtgvAccount.DataSource = accountList;
            cbSearchBy.SelectedIndex = 0;

            LoadAccount();
            AccountBinding();
        }

        void AccountBinding()
        {
            txbAccountName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Tên tài khoản", true, DataSourceUpdateMode.Never));
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Tên người dùng", true, DataSourceUpdateMode.Never));
            txbPhoneNumber.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
            numAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Loại tài khoản", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.getListAccount();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txbSearch.Text;

            if (cbSearchBy.SelectedIndex == 0)
                accountList.DataSource = AccountDAO.Instance.searchAccountByAccountName(name);
            else
                accountList.DataSource = AccountDAO.Instance.searchAccountByUserName(name);
        }

        void addAcount(string username, string name, string phone, int type)
        {
            if (AccountDAO.Instance.addAccount(username, name, phone, type))
                MessageBox.Show("Thêm tài khoản thành công!");
            else
                MessageBox.Show("Thêm tài khoản thất bại!");

            LoadAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string username = txbAccountName.Text;
            string name = txbUserName.Text;
            string phone = txbPhoneNumber.Text;
            int type = (int) numAccountType.Value;

            addAcount(username, name, phone, type);
        }

        void deleteAccount(string username)
        {
            if (AccountDAO.Instance.deleteAccount(username))
                MessageBox.Show("Xóa tài khoản thành công!");
            else
                MessageBox.Show("Xóa tài khoản thất bại!");

            LoadAccount();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = txbAccountName.Text;

            if (MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa tài khoản", MessageBoxButtons.YesNo) == DialogResult.Yes)
                deleteAccount(username);
        }

        void editAccount(string username, string name, string phone, int type)
        {
            if (AccountDAO.Instance.updateAccount(username, name, phone, type))
                MessageBox.Show("Cập nhật tài khoản thành công!");
            else
                MessageBox.Show("Cập nhật tài khoản thất bại!");

            LoadAccount();
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string username = txbAccountName.Text;
            string name = txbUserName.Text;
            string phone = txbPhoneNumber.Text;
            int type = (int)numAccountType.Value;

            editAccount(username, name, phone, type);
        }
    }
}
