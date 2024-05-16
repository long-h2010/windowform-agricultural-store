namespace FinalProject
{
    partial class UCSanPham
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvProducts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNote = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbTypeProduct = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbNameProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbIdProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pbImgProduct = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProduct)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvProducts);
            this.panel1.Location = new System.Drawing.Point(23, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 295);
            this.panel1.TabIndex = 0;
            // 
            // dtgvProducts
            // 
            this.dtgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProducts.Location = new System.Drawing.Point(0, 3);
            this.dtgvProducts.Name = "dtgvProducts";
            this.dtgvProducts.RowHeadersWidth = 51;
            this.dtgvProducts.RowTemplate.Height = 24;
            this.dtgvProducts.Size = new System.Drawing.Size(1031, 292);
            this.dtgvProducts.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(23, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 238);
            this.panel2.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.txbNote);
            this.panel8.Location = new System.Drawing.Point(3, 157);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(348, 76);
            this.panel8.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ghi chú:";
            // 
            // txbNote
            // 
            this.txbNote.Location = new System.Drawing.Point(148, 3);
            this.txbNote.Multiline = true;
            this.txbNote.Name = "txbNote";
            this.txbNote.Size = new System.Drawing.Size(193, 70);
            this.txbNote.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbTypeProduct);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(345, 32);
            this.panel5.TabIndex = 3;
            // 
            // cbTypeProduct
            // 
            this.cbTypeProduct.FormattingEnabled = true;
            this.cbTypeProduct.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbTypeProduct.Location = new System.Drawing.Point(148, 4);
            this.cbTypeProduct.Name = "cbTypeProduct";
            this.cbTypeProduct.Size = new System.Drawing.Size(193, 24);
            this.cbTypeProduct.TabIndex = 1;
            this.cbTypeProduct.SelectedIndexChanged += new System.EventHandler(this.cbTypeProduct_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.numPrice);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(3, 119);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(345, 32);
            this.panel6.TabIndex = 3;
            // 
            // numPrice
            // 
            this.numPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPrice.Location = new System.Drawing.Point(148, 7);
            this.numPrice.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(129, 22);
            this.numPrice.TabIndex = 1;
            this.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbNameProduct);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(3, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 32);
            this.panel4.TabIndex = 2;
            // 
            // txbNameProduct
            // 
            this.txbNameProduct.Location = new System.Drawing.Point(148, 6);
            this.txbNameProduct.Name = "txbNameProduct";
            this.txbNameProduct.Size = new System.Drawing.Size(193, 22);
            this.txbNameProduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbIdProduct);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 34);
            this.panel3.TabIndex = 1;
            // 
            // txbIdProduct
            // 
            this.txbIdProduct.Location = new System.Drawing.Point(148, 6);
            this.txbIdProduct.Name = "txbIdProduct";
            this.txbIdProduct.ReadOnly = true;
            this.txbIdProduct.Size = new System.Drawing.Size(193, 22);
            this.txbIdProduct.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id sản phẩm:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel7.Controls.Add(this.pbImgProduct);
            this.panel7.Location = new System.Drawing.Point(386, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(288, 236);
            this.panel7.TabIndex = 2;
            // 
            // pbImgProduct
            // 
            this.pbImgProduct.Location = new System.Drawing.Point(3, 3);
            this.pbImgProduct.Name = "pbImgProduct";
            this.pbImgProduct.Size = new System.Drawing.Size(282, 230);
            this.pbImgProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgProduct.TabIndex = 0;
            this.pbImgProduct.TabStop = false;
            this.pbImgProduct.Click += new System.EventHandler(this.pbImgProduct_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnEditProduct);
            this.panel9.Controls.Add(this.btnDeleteProduct);
            this.panel9.Controls.Add(this.btnAddProduct);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(692, 18);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(361, 234);
            this.panel9.TabIndex = 3;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(251, 86);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(80, 62);
            this.btnEditProduct.TabIndex = 6;
            this.btnEditProduct.Text = "Sửa";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(149, 86);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(80, 62);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "Xóa";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(43, 86);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(80, 62);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnSearch);
            this.panel10.Controls.Add(this.txbSearch);
            this.panel10.Location = new System.Drawing.Point(3, 1);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(355, 33);
            this.panel10.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(248, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(19, 5);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(207, 22);
            this.txbSearch.TabIndex = 5;
            // 
            // UCSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCSanPham";
            this.Size = new System.Drawing.Size(1081, 588);
            this.Load += new System.EventHandler(this.UCSanPham_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProduct)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvProducts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbIdProduct;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNote;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbTypeProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbNameProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pbImgProduct;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
    }
}
