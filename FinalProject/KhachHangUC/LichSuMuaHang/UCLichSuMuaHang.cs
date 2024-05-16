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
    public partial class UCLichSuMuaHang : UserControl
    {
        string usernameLogin;
        DataTable dtBill;

        public UCLichSuMuaHang(string accountLogin)
        {
            InitializeComponent();
            usernameLogin = accountLogin;
        }

        private void UCLichSuMuaHang_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        public void populateItems()
        {
            dtBill = BillDAO.Instance.getBillsOfAccount(usernameLogin);
            int size = dtBill.Rows.Count;
            UCItemHistory[] history = new UCItemHistory[size];

            for (int i = 0; i < size; i++)
            {
                history[i] = new UCItemHistory();
                history[i].Date = dtBill.Rows[i].Field<DateTime>("ngaytao").ToShortDateString();
                history[i].Price = String.Format("{0:0,00} ₫", dtBill.Rows[i].Field<double>("thanhtien"));
            }

            if (flHistory.Controls.Count < 0)
                flHistory.Controls.Clear();
            else
                for (int i = size - 1; i >= 0; i--)
                    flHistory.Controls.Add(history[i]);
        }
    }
}
