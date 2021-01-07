
namespace QL_PhongTro
{
    partial class FormDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiMatKhau));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmkhientai = new System.Windows.Forms.TextBox();
            this.txtmkmoi = new System.Windows.Forms.TextBox();
            this.txtcapnhatmkmoi = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gõ lại mật khẩu mới";
            // 
            // txtmkhientai
            // 
            this.txtmkhientai.Location = new System.Drawing.Point(181, 27);
            this.txtmkhientai.Name = "txtmkhientai";
            this.txtmkhientai.Size = new System.Drawing.Size(241, 26);
            this.txtmkhientai.TabIndex = 0;
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(181, 106);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.PasswordChar = '*';
            this.txtmkmoi.Size = new System.Drawing.Size(241, 26);
            this.txtmkmoi.TabIndex = 1;
            // 
            // txtcapnhatmkmoi
            // 
            this.txtcapnhatmkmoi.Location = new System.Drawing.Point(181, 181);
            this.txtcapnhatmkmoi.Name = "txtcapnhatmkmoi";
            this.txtcapnhatmkmoi.PasswordChar = '*';
            this.txtcapnhatmkmoi.Size = new System.Drawing.Size(241, 26);
            this.txtcapnhatmkmoi.TabIndex = 2;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(309, 301);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(117, 47);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.BtnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(181, 301);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(117, 47);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // FormDoiMatKhau
            // 
            this.AcceptButton = this.btnLuu;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 360);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.txtcapnhatmkmoi);
            this.Controls.Add(this.txtmkmoi);
            this.Controls.Add(this.txtmkhientai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FormDoiMatKhau.IconOptions.Image")));
            this.MaximumSize = new System.Drawing.Size(440, 400);
            this.MinimumSize = new System.Drawing.Size(440, 400);
            this.Name = "FormDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.FormDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmkhientai;
        private System.Windows.Forms.TextBox txtmkmoi;
        private System.Windows.Forms.TextBox txtcapnhatmkmoi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
    }
}