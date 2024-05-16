using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Data;
using System.Xml.Linq;

namespace FinalProject.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; } 
        }

        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = "dbo.usp_Login @username , @password";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] {username, password});
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login successful");
            }
            else
            {
                MessageBox.Show("Email or password is invalid");
            }
            return dt.Rows.Count > 0;
        }
        public bool Signin(string username, string password, string name, string phone)
        {
            string query = "Insert into dbo.TAIKHOAN(tendangnhap, hoten, sodienthoai, matkhau) values (@username, @password, @name, @phone)";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { username, name, phone, password });
            MessageBox.Show("Your account has been successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new FormDangNhap().Show();
            return true;
        }

        public DataTable getTypeAccount(string username)
        {
            string query = string.Format("Select loaitaikhoan from dbo.TAIKHOAN where tendangnhap = '{0}'", username);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("Select tendangnhap as 'Tên tài khoản', hoten as 'Tên người dùng', sodienthoai as 'Số điện thoại', loaitaikhoan as 'Loại tài khoản' from TAIKHOAN");
        }

        public DataTable searchAccountByAccountName(string aname)
        {
            string query = string.Format("Select tendangnhap as 'Tên tài khoản', hoten as 'Tên người dùng', sodienthoai as 'Số điện thoại', loaitaikhoan as 'Loại tài khoản' from TAIKHOAN where [dbo].[non_unicode_convert](tendangnhap) like N'%' + [dbo].[non_unicode_convert](N'{0}') + '%'", aname);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable searchAccountByUserName(string uname)
        {
            string query = string.Format("Select tendangnhap as 'Tên tài khoản', hoten as 'Tên người dùng', sodienthoai as 'Số điện thoại', loaitaikhoan as 'Loại tài khoản' from TAIKHOAN where [dbo].[non_unicode_convert](hoten) like N'%' + [dbo].[non_unicode_convert](N'{0}') + '%'", uname);
            
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool checkPrimaryKey(string username)
        {
            string quyery = string.Format("Select tendangnhap from dbo.TAIKHOAN where tendangnhap = '{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(quyery);

            return result > 0;
        }

        public bool addAccount(string username, string name, string phone, int type)
        {
            string quyery = string.Format("Insert dbo.TAIKHOAN values ('{0}', N'{1}', {2}, '123', {3})", username, name, phone, type);
            int result = DataProvider.Instance.ExecuteNonQuery(quyery);

            return result > 0;
        }

        public bool updateAccount(string username, string name, string phone, int type)
        {
            string quyery = string.Format("Update dbo.TAIKHOAN set hoten = N'{0}', sodienthoai = '{1}', loaitaikhoan = {2} where tendangnhap = '{3}'", name, phone, type, username);
            int result = DataProvider.Instance.ExecuteNonQuery(quyery);

            return result > 0;
        }

        public bool deleteAccount(string username)
        {
            string query = string.Format("Delete dbo.TAIKHOAN where tendangnhap = '{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}