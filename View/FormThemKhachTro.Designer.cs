
namespace QL_PhongTro
{
    partial class FormThemKhachTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemKhachTro));
            this.gbQLKhachTro = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbQLKhachTro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbQLKhachTro
            // 
            this.gbQLKhachTro.BackColor = System.Drawing.Color.Gainsboro;
            this.gbQLKhachTro.Controls.Add(this.dtpNgaySinh);
            this.gbQLKhachTro.Controls.Add(this.cbbPhong);
            this.gbQLKhachTro.Controls.Add(this.label8);
            this.gbQLKhachTro.Controls.Add(this.btnDong);
            this.gbQLKhachTro.Controls.Add(this.button1);
            this.gbQLKhachTro.Controls.Add(this.rbtnNu);
            this.gbQLKhachTro.Controls.Add(this.rbtnNam);
            this.gbQLKhachTro.Controls.Add(this.txtCMND);
            this.gbQLKhachTro.Controls.Add(this.txtQueQuan);
            this.gbQLKhachTro.Controls.Add(this.txtSDT);
            this.gbQLKhachTro.Controls.Add(this.txtHoten);
            this.gbQLKhachTro.Controls.Add(this.txtMaKhach);
            this.gbQLKhachTro.Controls.Add(this.label7);
            this.gbQLKhachTro.Controls.Add(this.label6);
            this.gbQLKhachTro.Controls.Add(this.label5);
            this.gbQLKhachTro.Controls.Add(this.label4);
            this.gbQLKhachTro.Controls.Add(this.label3);
            this.gbQLKhachTro.Controls.Add(this.label2);
            this.gbQLKhachTro.Controls.Add(this.label1);
            this.gbQLKhachTro.Location = new System.Drawing.Point(22, 12);
            this.gbQLKhachTro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbQLKhachTro.Name = "gbQLKhachTro";
            this.gbQLKhachTro.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbQLKhachTro.Size = new System.Drawing.Size(553, 544);
            this.gbQLKhachTro.TabIndex = 0;
            this.gbQLKhachTro.TabStop = false;
            this.gbQLKhachTro.Text = "Thông Tin Khách Trọ";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgaySinh.CustomFormat = "yyyy/MM/dd";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(220, 166);
            this.dtpNgaySinh.MaxDate = new System.DateTime(2021, 1, 10, 22, 33, 10, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 26);
            this.dtpNgaySinh.TabIndex = 2;
            this.dtpNgaySinh.Value = new System.DateTime(2021, 1, 10, 0, 0, 0, 0);
            // 
            // cbbPhong
            // 
            this.cbbPhong.DropDownHeight = 90;
            this.cbbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.IntegralHeight = false;
            this.cbbPhong.Items.AddRange(new object[] {
            "Phòng 101",
            "Phòng 102",
            "Phòng103",
            "Phòng104",
            "Phòng 105",
            "Phòng 106",
            "Phòng 107",
            "Phòng 108",
            "Phòng 201",
            "Phòng 202",
            "Phòng 203",
            "Phòng 204",
            "Phòng 205",
            "Phòng 206",
            "Phòng207",
            "Phòng 208",
            "Phòng 301",
            "Phòng 302",
            "Phòng 303",
            "Phòng 304"});
            this.cbbPhong.Location = new System.Drawing.Point(220, 427);
            this.cbbPhong.MaxDropDownItems = 4;
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(168, 26);
            this.cbbPhong.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Phòng";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(403, 465);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 60);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.BtnDong_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 465);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(340, 216);
            this.rbtnNu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(48, 22);
            this.rbtnNu.TabIndex = 4;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(220, 216);
            this.rbtnNam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(60, 22);
            this.rbtnNam.TabIndex = 3;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(220, 379);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCMND.MaxLength = 9;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(168, 26);
            this.txtCMND.TabIndex = 7;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCMND_KeyPress);
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(220, 322);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(168, 26);
            this.txtQueQuan.TabIndex = 6;
            this.txtQueQuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQueQuan_KeyPress);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(220, 265);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSDT.MaxLength = 11;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(168, 26);
            this.txtSDT.TabIndex = 5;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSDT_KeyPress);
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(220, 108);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(303, 26);
            this.txtHoten.TabIndex = 1;
            this.txtHoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHoten_KeyPress);
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(220, 52);
            this.txtMaKhach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaKhach.MaxLength = 5;
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(168, 26);
            this.txtMaKhach.TabIndex = 0;
            this.txtMaKhach.WordWrap = false;
            this.txtMaKhach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMaKhach_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 385);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "CMND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quê Quán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Trọ";
            // 
            // FormThemKhachTro
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 576);
            this.Controls.Add(this.gbQLKhachTro);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FormThemKhachTro.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(600, 616);
            this.MinimumSize = new System.Drawing.Size(600, 616);
            this.Name = "FormThemKhachTro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm khách";
            this.Load += new System.EventHandler(this.FormThemKhachTro_Load);
            this.gbQLKhachTro.ResumeLayout(false);
            this.gbQLKhachTro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbQLKhachTro;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}