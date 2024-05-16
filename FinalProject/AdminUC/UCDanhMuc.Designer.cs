namespace FinalProject.AdminUC
{
    partial class UCDanhMuc
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txbNameCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.txbNameCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.dtgvCategory);
            this.panel1.Location = new System.Drawing.Point(144, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 326);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnEditCategory);
            this.panel8.Controls.Add(this.btnDeleteCategory);
            this.panel8.Controls.Add(this.btnAddCategory);
            this.panel8.Location = new System.Drawing.Point(56, 225);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(291, 55);
            this.panel8.TabIndex = 7;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(217, 2);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(71, 52);
            this.btnEditCategory.TabIndex = 5;
            this.btnEditCategory.Text = "Cập nhật";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteCategory.FlatAppearance.BorderSize = 5;
            this.btnDeleteCategory.Location = new System.Drawing.Point(111, 2);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(71, 52);
            this.btnDeleteCategory.TabIndex = 4;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(3, 2);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(71, 52);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txbNameCategory
            // 
            this.txbNameCategory.Location = new System.Drawing.Point(56, 144);
            this.txbNameCategory.Name = "txbNameCategory";
            this.txbNameCategory.Size = new System.Drawing.Size(291, 22);
            this.txbNameCategory.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên danh mục:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(260, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(56, 40);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(182, 22);
            this.txbSearch.TabIndex = 1;
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(455, 0);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.RowHeadersWidth = 51;
            this.dtgvCategory.RowTemplate.Height = 24;
            this.dtgvCategory.Size = new System.Drawing.Size(343, 325);
            this.dtgvCategory.TabIndex = 0;
            // 
            // UCDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCDanhMuc";
            this.Size = new System.Drawing.Size(1081, 588);
            this.Load += new System.EventHandler(this.UCDanhMuc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbNameCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
    }
}
