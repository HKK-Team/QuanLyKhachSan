
namespace DoAn_LTWD_Quan_Ly_Khach_San
{
    partial class ThongKeGiaoDich
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgShowGD = new System.Windows.Forms.DataGridView();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.cbMaPhong = new System.Windows.Forms.ComboBox();
            this.dtNgayDen = new System.Windows.Forms.DateTimePicker();
            this.dtNgayDi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêGiaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKháchHaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowGD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phòng";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Đến";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Đi";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(455, 202);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 29);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgShowGD
            // 
            this.dgShowGD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgShowGD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgShowGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShowGD.Location = new System.Drawing.Point(22, 253);
            this.dgShowGD.Name = "dgShowGD";
            this.dgShowGD.RowHeadersWidth = 51;
            this.dgShowGD.RowTemplate.Height = 24;
            this.dgShowGD.Size = new System.Drawing.Size(943, 270);
            this.dgShowGD.TabIndex = 6;
            this.dgShowGD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgShowGD_CellClick);
            // 
            // cbMaKH
            // 
            this.cbMaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(372, 89);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(121, 24);
            this.cbMaKH.TabIndex = 7;
            // 
            // cbMaPhong
            // 
            this.cbMaPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMaPhong.FormattingEnabled = true;
            this.cbMaPhong.Location = new System.Drawing.Point(598, 90);
            this.cbMaPhong.Name = "cbMaPhong";
            this.cbMaPhong.Size = new System.Drawing.Size(121, 24);
            this.cbMaPhong.TabIndex = 8;
            // 
            // dtNgayDen
            // 
            this.dtNgayDen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDen.Location = new System.Drawing.Point(307, 156);
            this.dtNgayDen.Name = "dtNgayDen";
            this.dtNgayDen.Size = new System.Drawing.Size(186, 22);
            this.dtNgayDen.TabIndex = 9;
            // 
            // dtNgayDi
            // 
            this.dtNgayDi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDi.Location = new System.Drawing.Point(517, 156);
            this.dtNgayDi.Name = "dtNgayDi";
            this.dtNgayDi.Size = new System.Drawing.Size(202, 22);
            this.dtNgayDi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thống Kê Giao Dịch";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêGiaoDịchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 30);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêGiaoDịchToolStripMenuItem
            // 
            this.thốngKêGiaoDịchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinKháchHaToolStripMenuItem,
            this.thôngTinPhòngToolStripMenuItem,
            this.thanhToánToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.thốngKêGiaoDịchToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thốngKêGiaoDịchToolStripMenuItem.Name = "thốngKêGiaoDịchToolStripMenuItem";
            this.thốngKêGiaoDịchToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.thốngKêGiaoDịchToolStripMenuItem.Text = "Thống Kê Giao Dịch";
            // 
            // thôngTinKháchHaToolStripMenuItem
            // 
            this.thôngTinKháchHaToolStripMenuItem.Name = "thôngTinKháchHaToolStripMenuItem";
            this.thôngTinKháchHaToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.thôngTinKháchHaToolStripMenuItem.Text = " Khách Hàng";
            this.thôngTinKháchHaToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchHaToolStripMenuItem_Click);
            // 
            // thôngTinPhòngToolStripMenuItem
            // 
            this.thôngTinPhòngToolStripMenuItem.Name = "thôngTinPhòngToolStripMenuItem";
            this.thôngTinPhòngToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.thôngTinPhòngToolStripMenuItem.Text = "Tình Trạng Phòng";
            this.thôngTinPhòngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinPhòngToolStripMenuItem_Click);
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.thanhToánToolStripMenuItem.Text = "Thanh Toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // ThongKeGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 551);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtNgayDi);
            this.Controls.Add(this.dtNgayDen);
            this.Controls.Add(this.cbMaPhong);
            this.Controls.Add(this.cbMaKH);
            this.Controls.Add(this.dgShowGD);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ThongKeGiaoDich";
            this.Text = "ThongKeGiaoDich";
            this.Load += new System.EventHandler(this.ThongKeGiaoDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgShowGD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgShowGD;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.ComboBox cbMaPhong;
        private System.Windows.Forms.DateTimePicker dtNgayDen;
        private System.Windows.Forms.DateTimePicker dtNgayDi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêGiaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchHaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}