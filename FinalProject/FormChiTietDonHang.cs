using FinalProject.DAO;
using RestSharp.Extensions;
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
    public partial class FormChiTietDonHang : Form
    {
        string idBill;
        BindingSource listProducts = new BindingSource();

        public FormChiTietDonHang(string id)
        {
            InitializeComponent();
            idBill = id;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormChiTietDonHang_Load(object sender, EventArgs e)
        {
            lbId.Text = idBill;
            dtgvDetail.DataSource = listProducts;

            LoadDetail();
        }

        private void LoadDetail()
        {
            listProducts.DataSource = BillDAO.Instance.getBillDetail(idBill);
        }
    }
}
