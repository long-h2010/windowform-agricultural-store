using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    internal class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }

        private BillDAO() { }

        public DataTable createBill(string username, DateTime date, int totalMoney, int discount, float intoMoney)
        {
            string query = string.Format("Insert into dbo.HOADON(id, khachhang, ngaytao, tongtien, giamgia, thanhtien) values (dbo.createmahoadon('{0}'), '{1}', '{0}', {2}, {3}, {4})", date, username, totalMoney, discount, intoMoney);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getBills()
        {
            return DataProvider.Instance.ExecuteQuery("Select id as 'Mã hóa đơn', khachhang as 'Khách hàng', ngaytao as 'Ngày tạo', tongtien as 'Tổng tiền', giamgia as 'Giảm giá (%)', thanhtien as 'Thành tiền' from dbo.HOADON");
        }

        public DataTable getBillsOfAccount(string username)
        {
            string query = string.Format("Select id, ngaytao, thanhtien from dbo.HOADON where khachhang = '{0}'", username);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getLastId()
        {
            return DataProvider.Instance.ExecuteQuery("select TOP 1 id from dbo.HOADON ORDER BY id DESC");
        }

        public DataTable getBillsByDate(DateTime dateFrom, DateTime dateTo)
        {
            string query = string.Format("Select id as 'Mã hóa đơn', khachhang as 'Khách hàng', ngaytao as 'Ngày tạo', tongtien as 'Tổng tiền', giamgia as 'Giảm giá (%)', thanhtien as 'Thành tiền' from dbo.HOADON where ngaytao between '{0}' and '{1}'", dateFrom.ToShortDateString(), dateTo.ToShortDateString());

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getIncome()
        {
            return DataProvider.Instance.ExecuteQuery("Select thanhtien from dbo.HOADON");
        }

        public DataTable getIncomeByDate(DateTime dateFrom, DateTime dateTo)
        {
            string query = string.Format("Select thanhtien from dbo.HOADON where ngaytao between '{0}' and '{1}'", dateFrom.ToShortDateString(), dateTo.ToShortDateString());

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool addBillDetail(string idBill, int idProduct, int amount, int price)
        {
            string quyery = string.Format("Insert into dbo.CHITIETHOADON values ('{0}', {1}, {2}, {3})", idBill, idProduct, amount, price);
            int result = DataProvider.Instance.ExecuteNonQuery(quyery);

            return result > 0;
        }

        public DataTable getBillDetail(string id)
        {
            string query = string.Format("select tensanpham as 'Sản phẩm', soluong as 'Số lượng', giasanpham as 'Đơn giá' from CHITIETHOADON inner join SANPHAM on idsanpham = id where idhoadon = '{0}'", id);

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
