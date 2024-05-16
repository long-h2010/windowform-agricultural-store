namespace FinalProject
{
    partial class FormChiTietSanPham
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 540);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOff);
            this.panel3.Controls.Add(this.btnX);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 38);
            this.panel3.TabIndex = 0;
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(534, 0);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(53, 38);
            this.btnOff.TabIndex = 2;
            this.btnOff.Text = "-";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(583, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(53, 38);
            this.btnX.TabIndex = 1;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(60, 87);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(334, 23);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Cam sấy dẻo phủ muối ớt 50g";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.ForeColor = System.Drawing.Color.Red;
            this.lbPrice.Location = new System.Drawing.Point(184, 164);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(94, 23);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "39,000₫";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numAmount);
            this.panel2.Controls.Add(this.btnAddToCart);
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(338, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 540);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số lượng:";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(199, 215);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(95, 30);
            this.numAmount.TabIndex = 4;
            this.numAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddToCart.Location = new System.Drawing.Point(134, 299);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(243, 54);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Thêm vào giỏ hàng";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // FormChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChiTietSanPham";
            this.Text = "FormDetailProduct";
            this.Load += new System.EventHandler(this.FormChiTietSanPham_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnOff;
        public System.Windows.Forms.Button btnX;
        public System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAmount;
    }
}