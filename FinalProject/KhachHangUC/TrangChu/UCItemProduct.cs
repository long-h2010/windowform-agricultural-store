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
    public partial class UCItemProduct : UserControl
    {
        public UCItemProduct()
        {
            InitializeComponent();
        }

        private int id;
        private string productName;
        private string productPrice;

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

        private void btnSeenDetail_Click(object sender, EventArgs e)
        {
            FormChiTietSanPham fCT = new FormChiTietSanPham(id);
            fCT.Show();
        }
    }
}
