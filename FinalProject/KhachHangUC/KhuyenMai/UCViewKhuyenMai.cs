using FinalProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.KhachHangUC.KhuyenMai
{
    public partial class UCViewKhuyenMai : UserControl
    {
        DataTable dtDiscount;
        public UCViewKhuyenMai()
        {
            InitializeComponent();
        }

        private void UCViewKhuyenMai_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        public void populateItems()
        {
            dtDiscount = DiscountDAO.Instance.getListDiscount();
            int size = dtDiscount.Rows.Count;
            UCItemDiscount[] itemDiscount = new UCItemDiscount[size];

            for (int i = 0; i < size; i++)
            {
                itemDiscount[i] = new UCItemDiscount();
                itemDiscount[i].Code = dtDiscount.Rows[0].Field<string>("Mã khuyến mãi");
                itemDiscount[i].Content = dtDiscount.Rows[0].Field<string>("Nội dung");

                if (flDiscounts.Controls.Count < 0)
                    flDiscounts.Controls.Clear();
                else
                    flDiscounts.Controls.Add(itemDiscount[i]);
            }
        }
    }
}
