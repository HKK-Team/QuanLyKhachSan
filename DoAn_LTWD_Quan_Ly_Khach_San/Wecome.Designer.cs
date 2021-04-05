
namespace DoAn_LTWD_Quan_Ly_Khach_San
{
    partial class Wecome
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Lname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(198)))), ((int)(((byte)(152)))));
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wecome";
            // 
            // lbl_Lname
            // 
            this.lbl_Lname.AutoSize = true;
            this.lbl_Lname.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(198)))), ((int)(((byte)(152)))));
            this.lbl_Lname.Location = new System.Drawing.Point(324, 84);
            this.lbl_Lname.Name = "lbl_Lname";
            this.lbl_Lname.Size = new System.Drawing.Size(98, 39);
            this.lbl_Lname.TabIndex = 1;
            this.lbl_Lname.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(198)))), ((int)(((byte)(152)))));
            this.label2.Location = new System.Drawing.Point(273, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "The team wishes you a good day";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(198)))), ((int)(((byte)(152)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(198)))), ((int)(((byte)(152)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 92;
            this.iconPictureBox1.Location = new System.Drawing.Point(175, 153);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(92, 105);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1, 385);
            this.progressBar1.Maximum = 150;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(900, 33);
            this.progressBar1.TabIndex = 4;
            // 
            // Wecome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(900, 416);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Lname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Wecome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wecome";
            this.Load += new System.EventHandler(this.Wecome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Lname;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}