using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    internal class DiscountDAO
    {
        private static DiscountDAO instance;

        public static DiscountDAO Instance
        {
            get { if (instance == null) instance = new DiscountDAO(); return instance; }
            private set { instance = value; }
        }

        private DiscountDAO() { }

        public DataTable getListDiscount()
        {
            return DataProvider.Instance.ExecuteQuery("Select makhuyenmai as 'Mã khuyến mãi', phantramkm as 'Phần trăm khuyến mãi', noidungkm as 'Nội dung' from dbo.KHUYENMAI");
        }

        public DataTable getDiscountByCode(string code)
        {
            string query = string.Format("Select phantramkm from dbo.KHUYENMAI where makhuyenmai = '{0}'", code);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool addDiscount(string code, int percent, string content)
        {
            string quyery = string.Format("Insert into dbo.KHUYENMAI values ('{0}', {1}, N'{2}')", code, percent, content);
            int result = DataProvider.Instance.ExecuteNonQuery(quyery);

            return result > 0;
        }

        public bool updateDiscount(string code, int percent, string content)
        {
            string quyery = string.Format("Update dbo.KHUYENMAI set phantramkm = {0}, noidungkm = N'{1}' where makhuyenmai = '{2}'", percent, content, code);
            int result = DataProvider.Instance.ExecuteNonQuery(quyery);

            return result > 0;
        }

        public bool deleteDiscount(string code)
        {
            string query = string.Format("Delete dbo.KHUYENMAI where makhuyenmai = '{0}'", code);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
