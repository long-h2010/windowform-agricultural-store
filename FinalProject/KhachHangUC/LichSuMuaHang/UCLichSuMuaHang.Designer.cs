namespace FinalProject.KhachHangUC
{
    partial class UCLichSuMuaHang
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
            this.flHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flHistory
            // 
            this.flHistory.AutoScroll = true;
            this.flHistory.Location = new System.Drawing.Point(59, 17);
            this.flHistory.Name = "flHistory";
            this.flHistory.Size = new System.Drawing.Size(962, 526);
            this.flHistory.TabIndex = 0;
            // 
            // UCLichSuMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flHistory);
            this.Name = "UCLichSuMuaHang";
            this.Size = new System.Drawing.Size(1081, 588);
            this.Load += new System.EventHandler(this.UCLichSuMuaHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flHistory;
    }
}
