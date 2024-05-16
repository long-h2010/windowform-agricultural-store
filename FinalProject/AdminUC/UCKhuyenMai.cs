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
    public partial class UCKhuyenMai : UserControl
    {
        BindingSource discountList = new BindingSource();

        public UCKhuyenMai()
        {
            InitializeComponent();
        }

        private void UCKhuyenMai_Load(object sender, EventArgs e)
        {
            dtgvDiscounts.DataSource = discountList;

            LoadDiscount();
            DiscountBinding();
        }

        void LoadDiscount()
        {
            discountList.DataSource = DiscountDAO.Instance.getListDiscount();
        }

        void DiscountBinding()
        {
            txbCodeDiscount.DataBindings.Add(new Binding("Text", dtgvDiscounts.DataSource, "Mã khuyến mãi", true, DataSourceUpdateMode.Never));
            numDiscount.DataBindings.Add(new Binding("Value", dtgvDiscounts.DataSource, "Phần trăm khuyến mãi", true, DataSourceUpdateMode.Never));
            txbContent.DataBindings.Add(new Binding("Text", dtgvDiscounts.DataSource, "Nội dung", true, DataSourceUpdateMode.Never));
        }

        void addDiscount(string code, int percent, string content)
        {
            if (DiscountDAO.Instance.addDiscount(code, percent, content))
                MessageBox.Show("Thêm khuyến mãi thành công!");
            else
                MessageBox.Show("Thêm khuyến mãi thất bại!");

            LoadDiscount();
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            string code = txbCodeDiscount.Text;
            int percent = (int)numDiscount.Value;
            string content = txbContent.Text;

            addDiscount(code, percent, content);
        }

        void deleteDiscount(string code)
        {
            if (DiscountDAO.Instance.deleteDiscount(code))
                MessageBox.Show("Xóa khuyến mãi thành công!");
            else
                MessageBox.Show("Xóa khuyến mãi thất bại!");

            LoadDiscount();
        }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            string code = txbCodeDiscount.Text;

            if (MessageBox.Show("Bạn chắc chắn muốn xóa khuyến mãi này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                deleteDiscount(code);
        }

        void editDiscount(string code, int percent, string content)
        {
            if (DiscountDAO.Instance.updateDiscount(code, percent, content))
                MessageBox.Show("Cập nhật thành công!");
            else
                MessageBox.Show("Cập nhật thất bại!");

            LoadDiscount();
        }

        private void btnEditDiscount_Click(object sender, EventArgs e)
        {
            string code = txbCodeDiscount.Text;
            int percent = (int)numDiscount.Value;
            string content = txbContent.Text;

            editDiscount(code, percent, content);
        }
    }
}
