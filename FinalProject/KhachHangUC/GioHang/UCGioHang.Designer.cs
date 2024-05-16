namespace FinalProject.KhachHangUC
{
    partial class UCGioHang
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
            this.flCart = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnterDiscount = new System.Windows.Forms.Button();
            this.txbCodeDiscount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTotalMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flCart
            // 
            this.flCart.AutoScroll = true;
            this.flCart.Location = new System.Drawing.Point(34, 37);
            this.flCart.Name = "flCart";
            this.flCart.Size = new System.Drawing.Size(1010, 427);
            this.flCart.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEnterDiscount);
            this.panel1.Controls.Add(this.txbCodeDiscount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbTotalMoney);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDeleteAll);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Location = new System.Drawing.Point(34, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 94);
            this.panel1.TabIndex = 1;
            // 
            // btnEnterDiscount
            // 
            this.btnEnterDiscount.Location = new System.Drawing.Point(720, 22);
            this.btnEnterDiscount.Name = "btnEnterDiscount";
            this.btnEnterDiscount.Size = new System.Drawing.Size(83, 23);
            this.btnEnterDiscount.TabIndex = 7;
            this.btnEnterDiscount.Text = "Xác nhận";
            this.btnEnterDiscount.UseVisualStyleBackColor = true;
            this.btnEnterDiscount.Click += new System.EventHandler(this.btnEnterDiscount_Click);
            // 
            // txbCodeDiscount
            // 
            this.txbCodeDiscount.Location = new System.Drawing.Point(595, 22);
            this.txbCodeDiscount.Name = "txbCodeDiscount";
            this.txbCodeDiscount.Size = new System.Drawing.Size(118, 22);
            this.txbCodeDiscount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã giảm giá:";
            // 
            // txbTotalMoney
            // 
            this.txbTotalMoney.Location = new System.Drawing.Point(595, 50);
            this.txbTotalMoney.Name = "txbTotalMoney";
            this.txbTotalMoney.ReadOnly = true;
            this.txbTotalMoney.Size = new System.Drawing.Size(118, 22);
            this.txbTotalMoney.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng tiền:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(171, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 50);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(23, 22);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(120, 50);
            this.btnDeleteAll.TabIndex = 1;
            this.btnDeleteAll.Text = "Bỏ chọn tất cả";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(864, 31);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(110, 33);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // UCGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flCart);
            this.Name = "UCGioHang";
            this.Size = new System.Drawing.Size(1081, 588);
            this.Load += new System.EventHandler(this.UCGioHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTotalMoney;
        private System.Windows.Forms.TextBox txbCodeDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnterDiscount;
    }
}
