namespace FinalProject
{
    partial class UCTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.numAccountType = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbAccountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAccountType)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvAccount);
            this.panel1.Location = new System.Drawing.Point(13, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 544);
            this.panel1.TabIndex = 0;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(3, 2);
            this.dtgvAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(629, 538);
            this.dtgvAccount.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbSearchBy);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txbSearch);
            this.panel3.Location = new System.Drawing.Point(669, 52);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 28);
            this.panel3.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(308, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(160, 2);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(138, 22);
            this.txbSearch.TabIndex = 5;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(45, 38);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(71, 52);
            this.btnAddAccount.TabIndex = 3;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteAccount.FlatAppearance.BorderSize = 5;
            this.btnDeleteAccount.Location = new System.Drawing.Point(157, 38);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(71, 52);
            this.btnDeleteAccount.TabIndex = 4;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(669, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 262);
            this.panel2.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.numAccountType);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(3, 198);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(383, 57);
            this.panel7.TabIndex = 6;
            // 
            // numAccountType
            // 
            this.numAccountType.Location = new System.Drawing.Point(175, 16);
            this.numAccountType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numAccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAccountType.Name = "numAccountType";
            this.numAccountType.Size = new System.Drawing.Size(68, 22);
            this.numAccountType.TabIndex = 1;
            this.numAccountType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại tài khoản:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbPhoneNumber);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(3, 135);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(383, 57);
            this.panel6.TabIndex = 6;
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Location = new System.Drawing.Point(175, 16);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(205, 22);
            this.txbPhoneNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại: ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbUserName);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(3, 74);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(383, 57);
            this.panel5.TabIndex = 6;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(175, 16);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(205, 22);
            this.txbUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên người dùng:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbAccountName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 12);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(383, 57);
            this.panel4.TabIndex = 5;
            // 
            // txbAccountName
            // 
            this.txbAccountName.Location = new System.Drawing.Point(175, 16);
            this.txbAccountName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbAccountName.Name = "txbAccountName";
            this.txbAccountName.Size = new System.Drawing.Size(205, 22);
            this.txbAccountName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnEditAccount);
            this.panel8.Controls.Add(this.btnDeleteAccount);
            this.panel8.Controls.Add(this.btnAddAccount);
            this.panel8.Location = new System.Drawing.Point(672, 401);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(380, 121);
            this.panel8.TabIndex = 6;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(276, 38);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(71, 52);
            this.btnEditAccount.TabIndex = 5;
            this.btnEditAccount.Text = "Cập nhật";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Items.AddRange(new object[] {
            "Tên tài khoản",
            "Tên người dùng"});
            this.cbSearchBy.Location = new System.Drawing.Point(10, 2);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(139, 24);
            this.cbSearchBy.TabIndex = 7;
            // 
            // UCTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCTaiKhoan";
            this.Size = new System.Drawing.Size(1081, 588);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAccountType)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbAccountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown numAccountType;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.ComboBox cbSearchBy;
    }
}
