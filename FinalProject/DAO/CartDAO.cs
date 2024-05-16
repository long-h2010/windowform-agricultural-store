using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    internal class CartDAO
    {
        private static CartDAO instance;

        public static CartDAO Instance
        {
            get { if (instance == null) instance = new CartDAO(); return instance; }
            private set { instance = value; }
        }

        private CartDAO() { }

        public DataTable getCart()
        {
            return DataProvider.Instance.ExecuteQuery("Select * from dbo.GIOHANG");
        }
        public bool addToCart(int idProduct, int amount)
        {
            string quyery = string.Format("Insert dbo.GIOHANG(idsanpham, soluong) values ({0}, {1})", idProduct, amount);
            int result = DataProvider.Instance.ExecuteNonQuery(quyery);

            return result > 0;
        }

        public bool updateAmount(int idProduct, int amount)
        {
            string quyery = string.Format("Update dbo.GIOHANG set soluong = {0} where idsanpham = {1}", amount, idProduct);
            int result = DataProvider.Instance.ExecuteNonQuery(quyery);

            return result > 0;
        }

        public bool deleteAllInCart()
        {
            int result = DataProvider.Instance.ExecuteNonQuery("Delete from dbo.GIOHANG");

            return result > 0;
        }

        public bool deleteItemInCart(int id)
        {
            string quyery = string.Format("Delete from dbo.GIOHANG where idsanpham = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(quyery);

            return result > 0;
        }
    }
}
