using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    internal class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return instance; }
            private set { instance = value; }
        }

        private ProductDAO() { }

        public DataTable getListProducts()
        {
            return DataProvider.Instance.ExecuteQuery("Select id as 'Id sản phẩm', tensanpham as 'Tên sản phẩm', giasanpham as 'Giá tiền', ghichu as 'Ghi chú' from dbo.SANPHAM");
        }

        public DataTable getProductsById(int id)
        {
            string quyery = string.Format("Select * from dbo.SANPHAM where id = {0}", id);

            return DataProvider.Instance.ExecuteQuery(quyery);
        }

        public DataTable getProductsByType(int idType)
        {
            string quyery = string.Format("Select id as 'Id sản phẩm', tensanpham as 'Tên sản phẩm', giasanpham as 'Giá tiền', ghichu as 'Ghi chú' from dbo.SANPHAM where idloaisanpham = {0}", idType);

            return DataProvider.Instance.ExecuteQuery(quyery);
        }

        public DataTable getTypeProducts()
        {
            return DataProvider.Instance.ExecuteQuery("Select * from dbo.DANHMUC");
        }

        public DataTable getTypeProductById(int id)
        {
            string quyery = string.Format("Select idloaisanpham from dbo.SANPHAM where id = {0}", id);

            return DataProvider.Instance.ExecuteQuery(quyery);
        }

        public DataTable searchProductByName(string name)
        {
            string query = string.Format("Select id as 'Id sản phẩm', tensanpham as 'Tên sản phẩm', idloaisanpham as 'Loại sản phẩm', giasanpham as 'Giá tiền', ghichu as 'Ghi chú' from dbo.SANPHAM where [dbo].[non_unicode_convert](tensanpham) like N'%' + [dbo].[non_unicode_convert](N'{0}') + '%'", name);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable searchProductByNameAndType(string name, int type)
        {
            string query = string.Format("Select id as 'Id sản phẩm', tensanpham as 'Tên sản phẩm', idloaisanpham as 'Loại sản phẩm', giasanpham as 'Giá tiền', ghichu as 'Ghi chú' from dbo.SANPHAM where [dbo].[non_unicode_convert](tensanpham) like N'%' + [dbo].[non_unicode_convert](N'{0}') + '%' and idloaisanpham = {1}", name, type);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool addProduct(string productname, int type, int price, string note, byte[] img)
        {
            string quyery = string.Format("Insert into dbo.SANPHAM(tensanpham, idloaisanpham, giasanpham, ghichu, hinhanh) values (N'{0}', {1}, {2}, '{3}', '{4}')", productname, type, price, note, img);
            int result = DataProvider.Instance.ExecuteNonQuery(quyery);

            return result > 0;
        }

        public bool updateProduct(int id, string productname, int price, string note, byte[] img)
        {
            string quyery = string.Format("Update dbo.SANPHAM set tensanpham = N'{0}', giasanpham = {1}, ghichu = '{2}', hinhanh = '{3}' where id = {4}", productname, price, note, img, id);
            int result = DataProvider.Instance.ExecuteNonQuery(quyery);

            return result > 0;
        }

        public bool deleteProduct(int id)
        {
            string query = string.Format("Delete dbo.SANPHAM where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable getImgProduct(int id)
        {
            string quyery = string.Format("Select hinhanh from dbo.SANPHAM where id = {0}", id);

            return DataProvider.Instance.ExecuteQuery(quyery);
        }

        public bool deleteProductsByType(int idType)
        {
            string query = string.Format("Delete dbo.SANPHAM where idloaisanpham = {0}", idType);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
