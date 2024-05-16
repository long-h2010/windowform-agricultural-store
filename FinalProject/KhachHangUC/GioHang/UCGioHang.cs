using FinalProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.KhachHangUC
{
    public partial class UCGioHang : UserControl
    {
        string usernameLogin;
        DataTable dtCart;
        UCItemProductInCart[] productInCarts;
        int totalMoney;
        float intoMoney;
        int discount = 0;
        List<int> price = new List<int>();

        public UCGioHang(string accountLogin)
        {
            InitializeComponent();
            usernameLogin = accountLogin;
        }

        private void UCGioHang_Load(object sender, EventArgs e)
        {
            populateItems();

            txbTotalMoney.Text = calTotalMoney();
        }

        public void populateItems()
        {
            dtCart = CartDAO.Instance.getCart();
            int size = dtCart.Rows.Count;
            productInCarts = new UCItemProductInCart[size];

            for (int i = 0; i < size; i++)
            {
                DataTable dtProduct = ProductDAO.Instance.getProductsById(dtCart.Rows[i].Field<int>("idsanpham"));

                productInCarts[i] = new UCItemProductInCart();
                productInCarts[i].Id = dtProduct.Rows[0].Field<int>("id");
                productInCarts[i].ProductName = dtProduct.Rows[0].Field<string>("tensanpham");
                productInCarts[i].ProductPrice = String.Format("{0:0,00} ₫", dtProduct.Rows[0].Field<int>("giasanpham"));
                productInCarts[i].ProductAmount = dtCart.Rows[i].Field<int>("soluong");

                price.Add(dtProduct.Rows[0].Field<int>("giasanpham"));

                if (flCart.Controls.Count < 0)
                    flCart.Controls.Clear();
                else
                    flCart.Controls.Add(productInCarts[i]);
            }

            if (flCart.Controls.Count == 0)
            {
                UCCartEmpty uc = new UCCartEmpty();
                flCart.Controls.Add(uc);
            }
        }

        private string calTotalMoney()
        {
            int money = 0;

            for (int i = 0; i < productInCarts.Length; i++)
            {
                money += price[i]*productInCarts[i].ProductAmount;
            }

            totalMoney = money;

            return String.Format("{0:0,00} ₫", money);
        }

        private int percentDiscount()
        {
            string code = txbCodeDiscount.Text;
            DataTable dtDiscount = DiscountDAO.Instance.getDiscountByCode(code);

            int discount;
            if (dtDiscount.Rows.Count == 0)
                discount = 0;
            else
                discount = dtDiscount.Rows[0].Field<int>(0);

            return discount;
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            CartDAO.Instance.deleteAllInCart();
            flCart.Controls.Clear();
            UCGioHang_Load(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            flCart.Controls.Clear();
            UCGioHang_Load(sender, e);
            btnEnterDiscount_Click(sender, e);
        }

        private void btnEnterDiscount_Click(object sender, EventArgs e)
        {
            if (txbCodeDiscount.Text != "")
            {
                discount = percentDiscount();
            }

            intoMoney = totalMoney - totalMoney * discount / 100;

            txbTotalMoney.Text = String.Format("{0:0,00} ₫", intoMoney);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dtCart.Rows.Count != 0)
            {
                DateTime date = DateTime.Now;
                intoMoney = totalMoney - totalMoney * discount / 100;

                BillDAO.Instance.createBill(usernameLogin, date, totalMoney, discount, intoMoney);

                DataTable dtIdBill = BillDAO.Instance.getLastId();
                string idBill = dtIdBill.Rows[0].Field<string>(0);

                for (int i = 0; i < dtCart.Rows.Count; i++)
                {
                    BillDAO.Instance.addBillDetail(idBill, dtCart.Rows[i].Field<int>("idsanpham"), dtCart.Rows[i].Field<int>("soluong"), price[i]);
                }

                MessageBox.Show("Thanh toán thành công!", "Thông báo");
                btnDeleteAll_Click(sender, e);
            }
        }
    }
}