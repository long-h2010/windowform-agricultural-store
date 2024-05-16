using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject.KhachHangUC
{
    public partial class UCItemHistory : UserControl
    {
        public UCItemHistory()
        {
            InitializeComponent();
        }

        private string date;
        private string price;

        public string Date
        {
            get { return date; }
            set { date = value; lbDate.Text = value.ToString(); }
        }

        public string Price
        {
            get { return price; }
            set { price = value; lbPrice.Text = value; }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {

        }
    }
}
