namespace FinalProject.KhachHangUC.KhuyenMai
{
    partial class UCViewKhuyenMai
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
            this.flDiscounts = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flDiscounts
            // 
            this.flDiscounts.AutoScroll = true;
            this.flDiscounts.Location = new System.Drawing.Point(71, 93);
            this.flDiscounts.Name = "flDiscounts";
            this.flDiscounts.Size = new System.Drawing.Size(939, 452);
            this.flDiscounts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách khuyến mãi hiện có";
            // 
            // UCViewKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flDiscounts);
            this.Name = "UCViewKhuyenMai";
            this.Size = new System.Drawing.Size(1081, 588);
            this.Load += new System.EventHandler(this.UCViewKhuyenMai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flDiscounts;
        private System.Windows.Forms.Label label1;
    }
}
