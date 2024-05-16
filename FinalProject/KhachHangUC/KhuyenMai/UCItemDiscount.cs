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

namespace FinalProject.KhachHangUC.KhuyenMai
{
    public partial class UCItemDiscount : UserControl
    {
        public UCItemDiscount()
        {
            InitializeComponent();
        }

        private string code;
        private string content;

        public string Code
        {
            get { return code; }
            set { code = value; lbCode.Text = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; lbContent.Text = value; }
        }
    }
}
