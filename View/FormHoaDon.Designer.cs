
namespace QL_PhongTro
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnInHD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.clmTong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTienPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTienWifi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTienRac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTienNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTienDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNuocThangNay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNuocThangTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDienThangNay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDienThangTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSoPhong,
            this.clmNgayLapHD,
            this.clmDienThangTruoc,
            this.clmDienThangNay,
            this.clmNuocThangTruoc,
            this.clmNuocThangNay,
            this.clmTienDien,
            this.clmTienNuoc,
            this.clmTienRac,
            this.clmTienWifi,
            this.clmXe,
            this.clmTienPhong,
            this.clmTong});
            this.dgvHoaDon.Location = new System.Drawing.Point(14, 25);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersWidth = 62;
            this.dgvHoaDon.RowTemplate.Height = 28;
            this.dgvHoaDon.Size = new System.Drawing.Size(1326, 456);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(1030, 509);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(133, 52);
            this.btnInHD.TabIndex = 5;
            this.btnInHD.Text = "Xuât file excel";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // button1
            // 
            this.button1.ImageKey = "(none)";
            this.button1.Location = new System.Drawing.Point(1201, 509);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "exit.jfif");
            // 
            // clmTong
            // 
            this.clmTong.HeaderText = "Tổng";
            this.clmTong.MinimumWidth = 6;
            this.clmTong.Name = "clmTong";
            this.clmTong.ReadOnly = true;
            // 
            // clmTienPhong
            // 
            this.clmTienPhong.HeaderText = "Tiền Phòng";
            this.clmTienPhong.MinimumWidth = 6;
            this.clmTienPhong.Name = "clmTienPhong";
            this.clmTienPhong.ReadOnly = true;
            // 
            // clmXe
            // 
            this.clmXe.HeaderText = "Xe";
            this.clmXe.MinimumWidth = 6;
            this.clmXe.Name = "clmXe";
            this.clmXe.ReadOnly = true;
            // 
            // clmTienWifi
            // 
            this.clmTienWifi.HeaderText = "Tiền wifi";
            this.clmTienWifi.MinimumWidth = 8;
            this.clmTienWifi.Name = "clmTienWifi";
            this.clmTienWifi.ReadOnly = true;
            // 
            // clmTienRac
            // 
            this.clmTienRac.HeaderText = "Tiền rác";
            this.clmTienRac.MinimumWidth = 8;
            this.clmTienRac.Name = "clmTienRac";
            this.clmTienRac.ReadOnly = true;
            // 
            // clmTienNuoc
            // 
            this.clmTienNuoc.HeaderText = "Tiền nước";
            this.clmTienNuoc.MinimumWidth = 6;
            this.clmTienNuoc.Name = "clmTienNuoc";
            this.clmTienNuoc.ReadOnly = true;
            // 
            // clmTienDien
            // 
            this.clmTienDien.HeaderText = "Tiền điện";
            this.clmTienDien.MinimumWidth = 6;
            this.clmTienDien.Name = "clmTienDien";
            this.clmTienDien.ReadOnly = true;
            // 
            // clmNuocThangNay
            // 
            this.clmNuocThangNay.HeaderText = "Số nước tháng này";
            this.clmNuocThangNay.MinimumWidth = 8;
            this.clmNuocThangNay.Name = "clmNuocThangNay";
            this.clmNuocThangNay.ReadOnly = true;
            // 
            // clmNuocThangTruoc
            // 
            this.clmNuocThangTruoc.HeaderText = "Số nước tháng trước";
            this.clmNuocThangTruoc.MinimumWidth = 8;
            this.clmNuocThangTruoc.Name = "clmNuocThangTruoc";
            this.clmNuocThangTruoc.ReadOnly = true;
            // 
            // clmDienThangNay
            // 
            this.clmDienThangNay.HeaderText = "Số điện tháng này";
            this.clmDienThangNay.MinimumWidth = 8;
            this.clmDienThangNay.Name = "clmDienThangNay";
            this.clmDienThangNay.ReadOnly = true;
            // 
            // clmDienThangTruoc
            // 
            this.clmDienThangTruoc.HeaderText = "Số điện tháng trước";
            this.clmDienThangTruoc.MinimumWidth = 8;
            this.clmDienThangTruoc.Name = "clmDienThangTruoc";
            this.clmDienThangTruoc.ReadOnly = true;
            // 
            // clmNgayLapHD
            // 
            this.clmNgayLapHD.HeaderText = "Ngày lập hóa đơn";
            this.clmNgayLapHD.MinimumWidth = 6;
            this.clmNgayLapHD.Name = "clmNgayLapHD";
            this.clmNgayLapHD.ReadOnly = true;
            // 
            // clmSoPhong
            // 
            this.clmSoPhong.HeaderText = "Số Phòng";
            this.clmSoPhong.MinimumWidth = 8;
            this.clmSoPhong.Name = "clmSoPhong";
            this.clmSoPhong.ReadOnly = true;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.dgvHoaDon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormHoaDon.IconOptions.LargeImage")));
            this.Location = new System.Drawing.Point(561, 261);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(1410, 720);
            this.MinimumSize = new System.Drawing.Size(1228, 640);
            this.Name = "FormHoaDon";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button button1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDienThangTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDienThangNay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNuocThangTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNuocThangNay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTienDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTienNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTienRac;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTienWifi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTienPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTong;
    }
}