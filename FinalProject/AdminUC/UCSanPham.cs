using FinalProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FinalProject
{
    public partial class UCSanPham : UserControl
    {
        BindingSource productsList = new BindingSource();
        List<int> listIdType = new List<int>();

        public UCSanPham()
        {
            InitializeComponent();
        }

        private void UCSanPham_Load(object sender, EventArgs e)
        {
            cbTypeProduct.SelectedIndex = 0;
            dtgvProducts.DataSource = productsList;

            setItemsForcbType();
            LoadProducts();
            ProductBinding();
        }

        private void LoadProducts()
        {
            productsList.DataSource = ProductDAO.Instance.getListProducts();
        }

        private void ProductBinding()
        {
            txbIdProduct.DataBindings.Add(new Binding("Text", dtgvProducts.DataSource, "Id sản phẩm", true, DataSourceUpdateMode.Never));
            txbNameProduct.DataBindings.Add(new Binding("Text", dtgvProducts.DataSource, "Tên sản phẩm", true, DataSourceUpdateMode.Never));
            numPrice.DataBindings.Add(new Binding("Value", dtgvProducts.DataSource, "Giá tiền", true, DataSourceUpdateMode.Never));
            txbNote.DataBindings.Add(new Binding("Text", dtgvProducts.DataSource, "Ghi chú", true, DataSourceUpdateMode.Never));

            /*BindingSource dtImg = new BindingSource();
            dtImg.DataSource = ProductDAO.Instance.getImgProduct(Int32.Parse(txbIdProduct.Text));
            DataRowView currentRow = (DataRowView)dtImg.Current;
            string id = currentRow[0].ToString();
            MessageBox.Show(id);
            byte[] bimg = Encoding.ASCII.GetBytes(id);*/

            if (txbIdProduct.Text != "")
            {
                DataTable dtImg = ProductDAO.Instance.getImgProduct(Int32.Parse(txbIdProduct.Text));
                byte[] bimg = dtImg.Rows[0].Field<byte[]>(0).ToArray();
                MessageBox.Show(bimg.ToString());

                pbImgProduct.Image = ByteArrayToImage(bimg);
            }
        }

        private byte[] ImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

            return ms.ToArray();
        }

        private Image ByteArrayToImage(byte[] bimg)
        {
            MemoryStream ms = new MemoryStream(bimg);
            //string base64String = Convert.ToBase64String(bimg);

            return Image.FromStream(ms);
        }

        private void setItemsForcbType()
        {
            DataTable dtType = ProductDAO.Instance.getTypeProducts();

            for (int i = 0; i < dtType.Rows.Count; i++)
            {
                listIdType.Add(dtType.Rows[i].Field<int>("id"));
                cbTypeProduct.Items.Add(dtType.Rows[i].Field<string>("tendanhmuc"));
            }
        }

        private void cbTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeProduct.SelectedIndex > 0)
                productsList.DataSource = ProductDAO.Instance.getProductsByType(listIdType[cbTypeProduct.SelectedIndex - 1]);
            else
                productsList.DataSource = ProductDAO.Instance.getListProducts();
        }

        private void pbImgProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImgProduct.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txbSearch.Text;
            if (cbTypeProduct.SelectedIndex == 0)
                productsList.DataSource = ProductDAO.Instance.searchProductByName(name);
            else
                productsList.DataSource = ProductDAO.Instance.searchProductByNameAndType(name, listIdType[cbTypeProduct.SelectedIndex - 1]);
        }

        void addProduct(string productname, int type, int price, string note, byte[] img)
        {
            if (ProductDAO.Instance.addProduct(productname, type, price, note, img))
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                CategoryDAO.Instance.updateAmountProductOfCategory(type);
            }
            else
                MessageBox.Show("Thêm sản phẩm thất bại!");

            LoadProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (cbTypeProduct.SelectedIndex == 0)
            {
                MessageBox.Show("Chọn danh mục trước khi thêm sản phẩm!", "Thông báo");
                return;
            }    

            string productname = txbNameProduct.Text;
            int type = listIdType[cbTypeProduct.SelectedIndex - 1];
            int price = (int) numPrice.Value;
            string note = txbNote.Text;
            Image img = pbImgProduct.Image;
            byte[] bimg = ImageToByteArray(img);
            string x = Encoding.Default.GetString(bimg);
            MessageBox.Show(x);

            addProduct(productname, type, price, note, bimg);
        }

        void deleteProduct(int id, int type)
        {
            if (ProductDAO.Instance.deleteProduct(id))
            {
                MessageBox.Show("Xóa sản phẩm thành công!");
                CategoryDAO.Instance.updateAmountProductOfCategory(type);
            }
            else
                MessageBox.Show("Xóa sản phẩm thất bại!");

            LoadProducts();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txbIdProduct.Text);
            int type = ProductDAO.Instance.getTypeProductById(id).Rows[0].Field<int>(0);

            if (MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                deleteProduct(id, type);
        }

        void editProduct(int id, string productname, int price, string note, byte[] img)
        {
            if (ProductDAO.Instance.updateProduct(id, productname, price, note, img))
                MessageBox.Show("Cập nhật thành công!");
            else
                MessageBox.Show("Cập nhật thất bại!");

            LoadProducts();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txbIdProduct.Text);
            string productname = txbNameProduct.Text;
            int price = (int) numPrice.Value;
            string note = txbNote.Text;
            Image img = pbImgProduct.Image;
            byte[] bimg = ImageToByteArray(img);

            editProduct(id, productname, price, note, bimg);
        }
    }
}