using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    internal class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { instance = value; }
        }

        private CategoryDAO() { }

        public DataTable getCategories()
        {
            return DataProvider.Instance.ExecuteQuery("Select tendanhmuc as 'Tên danh mục', soluongsanpham as 'Số lượng sản phẩm' from dbo.DANHMUC");
        }

        public DataTable getIdByTypename(string name)
        {
            string quyery = string.Format("Select id from dbo.DANHMUC where tendanhmuc = N'{0}'", name);
            return DataProvider.Instance.ExecuteQuery(quyery);
        }

        public bool updateAmountProductOfCategory(int id)
        {
            string quyery = string.Format("Update dbo.DANHMUC set soluongsanpham = dbo.soluongsanpham({0}) where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(quyery);

            return result > 0;
        }

        public bool addCategory(string name)
        {
            string quyery = string.Format("Insert into dbo.DANHMUC(tendanhmuc) values (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(quyery);

            return result > 0;
        }

        public bool updateCategory(string lastName, string newName)
        {
            string quyery = string.Format("Update dbo.DANHMUC set tendanhmuc = N'{0}' where tendanhmuc = N'{1}'", newName, lastName);
            int result = DataProvider.Instance.ExecuteNonQuery(quyery);

            return result > 0;
        }

        public bool deleteCategory(string name)
        {
            string query = string.Format("Delete dbo.DANHMUC where tendanhmuc = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
