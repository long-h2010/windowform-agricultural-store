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
    public partial class UCThongKe : UserControl
    {
        BindingSource listBills = new BindingSource();

        public UCThongKe()
        {
            InitializeComponent();
        }

        private void UCThongKe_Load(object sender, EventArgs e)
        {
            dtgvBill.DataSource = listBills;
            txbIncome.Text = calIncome();

            LoadBills();
        }

        private void LoadBills()
        {
            listBills.DataSource = BillDAO.Instance.getBills();
        }

        private string calIncome()
        {
            DataTable dtIncome = BillDAO.Instance.getIncome();

            double s = 0;
            for (int i = 0; i < dtIncome.Rows.Count; i++)
            {
                s += dtIncome.Rows[i].Field<double>(0);
            }

            return String.Format("{0:0,00} ₫", s);
        }

        private string calIncomeByDate(DateTime dateFrom, DateTime dateTo)
        {
            DataTable dtIncome = BillDAO.Instance.getIncomeByDate(dateFrom, dateTo);

            double s = 0;
            if (dtIncome.Rows.Count > 0)
            {
                for (int i = 0; i < dtIncome.Rows.Count; i++)
                {
                    s += dtIncome.Rows[i].Field<double>(0);
                }
            }

            return String.Format("{0:0,00} ₫", s);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            listBills.DataSource = BillDAO.Instance.getBillsByDate(dtpDateFrom.Value, dtpDateTo.Value);
            txbIncome.Text = calIncomeByDate(dtpDateFrom.Value, dtpDateTo.Value);
        }

        private void btnSeenAll_Click(object sender, EventArgs e)
        {
            LoadBills();
            txbIncome.Text = calIncome();
        }

        private void btnSeenDetail_Click(object sender, EventArgs e)
        {
            if (dtgvBill.Rows.Count > 0)
            {
                string idBill = dtgvBill.Rows[dtgvBill.CurrentCell.RowIndex].Cells[0].Value.ToString();

                FormChiTietDonHang fCT = new FormChiTietDonHang(idBill);
                fCT.Show();
            }
        }
    }
}
