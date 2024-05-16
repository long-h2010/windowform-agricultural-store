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

namespace FinalProject.AdminUC
{
    public partial class UCDanhMuc : UserControl
    {
        BindingSource listCategory = new BindingSource();

        public UCDanhMuc()
        {
            InitializeComponent();
        }

        private void UCDanhMuc_Load(object sender, EventArgs e)
        {
            dtgvCategory.DataSource = listCategory;

            LoadCategories();
            CategoryBinding();
        }

        private void LoadCategories()
        {
            listCategory.DataSource = CategoryDAO.Instance.getCategories();
        }

        void CategoryBinding()
        {
            txbNameCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Tên danh mục", true, DataSourceUpdateMode.Never));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txbSearch.Text;

            listCategory.DataSource = AccountDAO.Instance.searchAccountByUserName(name);
        }

        void addCategory(string nameCategory)
        {
            if (CategoryDAO.Instance.addCategory(nameCategory))
                MessageBox.Show("Thêm danh mục thành công!");
            else
                MessageBox.Show("Thêm danh mục thất bại!");

            LoadCategories();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string nameCategory = txbNameCategory.Text;

            addCategory(nameCategory);
        }

        void deleteCategory(string nameCategory)
        {
            int typeId = CategoryDAO.Instance.getIdByTypename(nameCategory).Rows[0].Field<int>(0);
            ProductDAO.Instance.deleteProductsByType(typeId);

            if (CategoryDAO.Instance.deleteCategory(nameCategory))
                MessageBox.Show("Xóa danh mục thành công!");
            else
                MessageBox.Show("Xóa danh mục thất bại!");

            LoadCategories();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string nameCategory = txbNameCategory.Text;

            deleteCategory(nameCategory);
        }

        void editAccount(string username, string name, string phone, int type)
        {
            if (AccountDAO.Instance.updateAccount(username, name, phone, type))
                MessageBox.Show("Cập nhật danh mục thành công!");
            else
                MessageBox.Show("Cập nhật danh mục thất bại!");

            LoadCategories();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
