namespace FinalProject
{
    partial class FormChiTietDonHang
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
            this.lbId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.dtgvDetail = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOff);
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 42);
            this.panel1.TabIndex = 0;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.Red;
            this.lbId.Location = new System.Drawing.Point(253, 10);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(142, 23);
            this.lbId.TabIndex = 8;
            this.lbId.Text = "20102002001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chi tiết đơn hàng";
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(469, 1);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(53, 38);
            this.btnOff.TabIndex = 6;
            this.btnOff.Text = "-";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.Location = new System.Drawing.Point(518, 1);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(53, 38);
            this.btnX.TabIndex = 5;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // dtgvDetail
            // 
            this.dtgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetail.Location = new System.Drawing.Point(18, 60);
            this.dtgvDetail.Name = "dtgvDetail";
            this.dtgvDetail.RowHeadersWidth = 51;
            this.dtgvDetail.RowTemplate.Height = 24;
            this.dtgvDetail.Size = new System.Drawing.Size(535, 281);
            this.dtgvDetail.TabIndex = 1;
            // 
            // FormChiTietDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 364);
            this.Controls.Add(this.dtgvDetail);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChiTietDonHang";
            this.Text = "FormDetailProduct";
            this.Load += new System.EventHandler(this.FormChiTietDonHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnOff;
        public System.Windows.Forms.Button btnX;
        private System.Windows.Forms.DataGridView dtgvDetail;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label1;
    }
}