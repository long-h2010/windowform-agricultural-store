namespace FinalProject.KhachHangUC
{
    partial class UCTrangChu_ForKhachHang
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSreach = new System.Windows.Forms.TextBox();
            this.flPanelcenter = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txbSreach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 67);
            this.panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(865, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSreach
            // 
            this.txbSreach.Location = new System.Drawing.Point(614, 28);
            this.txbSreach.Name = "txbSreach";
            this.txbSreach.Size = new System.Drawing.Size(232, 22);
            this.txbSreach.TabIndex = 0;
            // 
            // flPanelcenter
            // 
            this.flPanelcenter.AutoScroll = true;
            this.flPanelcenter.Location = new System.Drawing.Point(37, 67);
            this.flPanelcenter.Name = "flPanelcenter";
            this.flPanelcenter.Size = new System.Drawing.Size(1044, 521);
            this.flPanelcenter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh mục:";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbType.Location = new System.Drawing.Point(170, 28);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 24);
            this.cbType.TabIndex = 3;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // UCTrangChu_ForKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flPanelcenter);
            this.Controls.Add(this.panel1);
            this.Name = "UCTrangChu_ForKhachHang";
            this.Size = new System.Drawing.Size(1081, 588);
            this.Load += new System.EventHandler(this.UCTrangChu_ForKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSreach;
        private System.Windows.Forms.FlowLayoutPanel flPanelcenter;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label1;
    }
}
