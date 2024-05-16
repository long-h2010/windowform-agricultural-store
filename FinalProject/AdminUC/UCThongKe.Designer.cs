namespace FinalProject.AdminUC
{
    partial class UCThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeenDetail = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbIncome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.btnSeenAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSeenAll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSeenDetail);
            this.panel1.Controls.Add(this.btnStatistic);
            this.panel1.Controls.Add(this.dtpDateTo);
            this.panel1.Controls.Add(this.dtpDateFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // btnSeenDetail
            // 
            this.btnSeenDetail.Location = new System.Drawing.Point(927, 18);
            this.btnSeenDetail.Name = "btnSeenDetail";
            this.btnSeenDetail.Size = new System.Drawing.Size(100, 30);
            this.btnSeenDetail.TabIndex = 3;
            this.btnSeenDetail.Text = "Xem chi tiết";
            this.btnSeenDetail.UseVisualStyleBackColor = true;
            this.btnSeenDetail.Click += new System.EventHandler(this.btnSeenDetail_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(632, 18);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(100, 30);
            this.btnStatistic.TabIndex = 2;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(342, 20);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(258, 22);
            this.dtpDateTo.TabIndex = 1;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(54, 20);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(258, 22);
            this.dtpDateFrom.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbIncome);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 538);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 50);
            this.panel2.TabIndex = 1;
            // 
            // txbIncome
            // 
            this.txbIncome.Location = new System.Drawing.Point(876, 16);
            this.txbIncome.Name = "txbIncome";
            this.txbIncome.ReadOnly = true;
            this.txbIncome.Size = new System.Drawing.Size(151, 22);
            this.txbIncome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(682, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng doanh thu:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1081, 480);
            this.panel3.TabIndex = 2;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(54, 0);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(973, 480);
            this.dtgvBill.TabIndex = 0;
            // 
            // btnSeenAll
            // 
            this.btnSeenAll.Location = new System.Drawing.Point(809, 18);
            this.btnSeenAll.Name = "btnSeenAll";
            this.btnSeenAll.Size = new System.Drawing.Size(100, 30);
            this.btnSeenAll.TabIndex = 5;
            this.btnSeenAll.Text = "Xem tất cả";
            this.btnSeenAll.UseVisualStyleBackColor = true;
            this.btnSeenAll.Click += new System.EventHandler(this.btnSeenAll_Click);
            // 
            // UCThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCThongKe";
            this.Size = new System.Drawing.Size(1081, 588);
            this.Load += new System.EventHandler(this.UCThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeenDetail;
        private System.Windows.Forms.TextBox txbIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeenAll;
    }
}
