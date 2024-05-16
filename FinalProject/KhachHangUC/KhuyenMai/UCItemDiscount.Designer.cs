namespace FinalProject.KhachHangUC.KhuyenMai
{
    partial class UCItemDiscount
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khuyến mãi:";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.ForeColor = System.Drawing.Color.Red;
            this.lbCode.Location = new System.Drawing.Point(243, 32);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(69, 20);
            this.lbCode.TabIndex = 1;
            this.lbCode.Text = "CodeKM";
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent.Location = new System.Drawing.Point(79, 74);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(72, 17);
            this.lbContent.TabIndex = 2;
            this.lbContent.Text = "Nội dung";
            // 
            // UCItemDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.label1);
            this.Name = "UCItemDiscount";
            this.Size = new System.Drawing.Size(911, 159);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbContent;
    }
}
