namespace FinalProject.KhachHangUC
{
    partial class UCItemProduct
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnSeenDetail = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(24, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(15, 9);
            this.lbName.MaximumSize = new System.Drawing.Size(180, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(159, 40);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name Name Name Name";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Red;
            this.lbPrice.Location = new System.Drawing.Point(15, 62);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPrice.Size = new System.Drawing.Size(70, 22);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price";
            // 
            // btnSeenDetail
            // 
            this.btnSeenDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSeenDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSeenDetail.Location = new System.Drawing.Point(3, 4);
            this.btnSeenDetail.Name = "btnSeenDetail";
            this.btnSeenDetail.Size = new System.Drawing.Size(127, 37);
            this.btnSeenDetail.TabIndex = 1;
            this.btnSeenDetail.Text = "Xem";
            this.btnSeenDetail.UseVisualStyleBackColor = true;
            this.btnSeenDetail.Click += new System.EventHandler(this.btnSeenDetail_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnSeenDetail);
            this.panel1.Location = new System.Drawing.Point(83, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 44);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Location = new System.Drawing.Point(24, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 95);
            this.panel2.TabIndex = 4;
            // 
            // UCItemProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCItemProduct";
            this.Size = new System.Drawing.Size(247, 315);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnSeenDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
