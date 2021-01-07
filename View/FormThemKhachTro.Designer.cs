
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
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.dgvDSKhachTro = new System.Windows.Forms.DataGridView();
            this.gbQLKhachTro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachTro)).BeginInit();
            this.SuspendLayout();
            // 
            // gbQLKhachTro
            // 
            this.gbQLKhachTro.BackColor = System.Drawing.Color.Gainsboro;
            this.gbQLKhachTro.Controls.Add(this.cbGioitinh);
            this.gbQLKhachTro.Controls.Add(this.cbPhong);
            this.gbQLKhachTro.Controls.Add(this.dtpNgaySinh);
            this.gbQLKhachTro.Controls.Add(this.label8);
            this.gbQLKhachTro.Controls.Add(this.btnDong);
            this.gbQLKhachTro.Controls.Add(this.button1);
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
            this.gbQLKhachTro.Size = new System.Drawing.Size(502, 525);
            this.gbQLKhachTro.TabIndex = 0;
            this.gbQLKhachTro.TabStop = false;
            this.gbQLKhachTro.Text = "Thông Tin Khách Trọ";
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.DropDownHeight = 50;
            this.cbGioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.IntegralHeight = false;
            this.cbGioitinh.ItemHeight = 18;
            this.cbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioitinh.Location = new System.Drawing.Point(220, 221);
            this.cbGioitinh.MaxDropDownItems = 2;
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(121, 26);
            this.cbGioitinh.TabIndex = 3;
            // 
            // cbPhong
            // 
            this.cbPhong.DropDownHeight = 150;
            this.cbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.IntegralHeight = false;
            this.cbPhong.ItemHeight = 18;
            this.cbPhong.Items.AddRange(new object[] {
            "P101",
            "P102",
            "P103",
            "P104",
            "P105",
            "P106",
            "P107",
            "P108",
            "P201",
            "P202",
            "P203",
            "P204",
            "P205",
            "P206",
            "P207",
            "P208",
            "P301",
            "P302",
            "P303",
            "P304"});
            this.cbPhong.Location = new System.Drawing.Point(220, 435);
            this.cbPhong.MaxDropDownItems = 10;
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(121, 26);
            this.cbPhong.TabIndex = 8;
            this.cbPhong.SelectedIndexChanged += new System.EventHandler(this.CbPhong_SelectedIndexChanged);
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
            this.btnDong.Location = new System.Drawing.Point(360, 467);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 45);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.BtnDong_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 467);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
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
            this.txtHoten.Size = new System.Drawing.Size(260, 26);
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
            // dgvDSKhachTro
            // 
            this.dgvDSKhachTro.AllowUserToAddRows = false;
            this.dgvDSKhachTro.AllowUserToDeleteRows = false;
            this.dgvDSKhachTro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSKhachTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhachTro.Location = new System.Drawing.Point(593, 12);
            this.dgvDSKhachTro.Name = "dgvDSKhachTro";
            this.dgvDSKhachTro.ReadOnly = true;
            this.dgvDSKhachTro.RowHeadersWidth = 51;
            this.dgvDSKhachTro.RowTemplate.Height = 24;
            this.dgvDSKhachTro.Size = new System.Drawing.Size(733, 525);
            this.dgvDSKhachTro.TabIndex = 1;
            // 
            // FormThemKhachTro
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 553);
            this.Controls.Add(this.dgvDSKhachTro);
            this.Controls.Add(this.gbQLKhachTro);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FormThemKhachTro.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormThemKhachTro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm khách";
            this.Load += new System.EventHandler(this.FormThemKhachTro_Load);
            this.gbQLKhachTro.ResumeLayout(false);
            this.gbQLKhachTro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachTro)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.DataGridView dgvDSKhachTro;
    }
}