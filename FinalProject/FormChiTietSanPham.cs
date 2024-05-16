using FinalProject.DAO;
using FinalProject.KhachHangUC;
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
    public partial class FormChiTietSanPham : Form
    {
        int idProduct;
        DataTable dtProduct = new DataTable();

        public FormChiTietSanPham()
        {
            InitializeComponent();
        }

        public FormChiTietSanPham(int id)
        {
            InitializeComponent();
            idProduct = id;
            dtProduct = ProductDAO.Instance.getProductsById(idProduct);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormChiTietSanPham_Load(object sender, EventArgs e)
        {
            lbName.Text = dtProduct.Rows[0].Field<string>("tensanpham");
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            DataTable dtCart = CartDAO.Instance.getCart();
            for (int i = 0; i < dtCart.Rows.Count; i++)
            {
                if (idProduct == dtCart.Rows[i].Field<int>("idsanpham"))
                {
                    CartDAO.Instance.updateAmount(idProduct, (int)numAmount.Value + dtCart.Rows[i].Field<int>("soluong"));
                    MessageBox.Show("Thêm thành công sản phẩm vào giỏ hàng");
                    this.Close();
                    return;
                }
            }    
            CartDAO.Instance.addToCart(dtProduct.Rows[0].Field<int>("id"), (int)numAmount.Value);
            MessageBox.Show("Thêm thành công sản phẩm vào giỏ hàng");
            this.Close();
        }
    }
}
