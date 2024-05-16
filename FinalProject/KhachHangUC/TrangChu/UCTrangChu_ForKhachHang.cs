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

namespace FinalProject.KhachHangUC
{
    public partial class UCTrangChu_ForKhachHang : UserControl
    {
        BindingSource productsList = new BindingSource();
        DataTable dtproductsList = new DataTable();
        List<int> listIdType = new List<int>();

        public UCTrangChu_ForKhachHang()
        {
            InitializeComponent();
        }

        private void UCTrangChu_ForKhachHang_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
            flPanelcenter.Controls.Clear();

            setItemsForcbType();
            getProducts();
            populateItems();
        }

        void getProducts()
        {
            productsList.DataSource = ProductDAO.Instance.getListProducts();
            dtproductsList = (DataTable) productsList.DataSource;
        }

        private void populateItems()
        {
            int size = productsList.Count;
            UCItemProduct[] products = new UCItemProduct[size];

            for (int i = 0; i < size; i++)
            {
                products[i] = new UCItemProduct();
                products[i].Id = dtproductsList.Rows[i].Field<int>("Id sản phẩm");
                products[i].ProductName = dtproductsList.Rows[i].Field<string>("Tên sản phẩm");
                products[i].ProductPrice = String.Format("{0:0,00} ₫", dtproductsList.Rows[i].Field<int>("Giá tiền"));

                if (flPanelcenter.Controls.Count < 0)
                    flPanelcenter.Controls.Clear();
                else
                    flPanelcenter.Controls.Add(products[i]);
            }    
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txbSreach.Text;
            if (cbType.SelectedIndex == 0)
            {
                productsList.DataSource = ProductDAO.Instance.searchProductByName(name);
                dtproductsList = (DataTable)productsList.DataSource;
            }
            else
            {
                productsList.DataSource = ProductDAO.Instance.searchProductByNameAndType(name, listIdType[cbType.SelectedIndex - 1]);
                dtproductsList = (DataTable)productsList.DataSource;
            }

            flPanelcenter.Controls.Clear();
            populateItems();
        }

        private void setItemsForcbType()
        {
            DataTable dtType = ProductDAO.Instance.getTypeProducts();

            for (int i = 0; i < dtType.Rows.Count; i++)
            {
                listIdType.Add(dtType.Rows[i].Field<int>("id"));
                cbType.Items.Add(dtType.Rows[i].Field<string>("tendanhmuc"));
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex > 0)
            {
                productsList.DataSource = ProductDAO.Instance.getProductsByType(listIdType[cbType.SelectedIndex - 1]);
                dtproductsList = (DataTable)productsList.DataSource;
            }
            else
            {
                productsList.DataSource = ProductDAO.Instance.getListProducts();
                dtproductsList = (DataTable)productsList.DataSource;
            }

            flPanelcenter.Controls.Clear();
            populateItems();
        }
    }
}
