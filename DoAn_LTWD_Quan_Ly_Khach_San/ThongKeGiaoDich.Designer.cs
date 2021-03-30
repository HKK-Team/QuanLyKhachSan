
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
            ((System.ComponentModel.ISupportInitialize)(this.dgShowGD)).BeginInit();
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
            this.btnTimKiem.Location = new System.Drawing.Point(485, 203);
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
            this.label5.Location = new System.Drawing.Point(401, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thống Kê Giao Dịch";
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
            this.Name = "ThongKeGiaoDich";
            this.Text = "ThongKeGiaoDich";
            this.Load += new System.EventHandler(this.ThongKeGiaoDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgShowGD)).EndInit();
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
    }
}