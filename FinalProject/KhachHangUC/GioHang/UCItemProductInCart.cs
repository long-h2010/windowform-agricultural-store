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
    public partial class UCItemProductInCart : UserControl
    {
        public UCItemProductInCart()
        {
            InitializeComponent();
        }

        private int id;
        private string productName;
        private string productPrice;
        private int productAmount;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; lbName.Text = value; }
        }

        public string ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; lbPrice.Text = value; }
        }

        public int ProductAmount
        {
            get { return productAmount; }
            set { productAmount = value; numAmount.Value = value; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CartDAO.Instance.deleteItemInCart(id);
            MessageBox.Show("Loại bỏ thành công!", "Thông báo");
        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            ProductAmount = (int)numAmount.Value;
            CartDAO.Instance.updateAmount(id, ProductAmount);
        }
    }
}
