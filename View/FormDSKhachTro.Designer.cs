namespace QL_PhongTro
{
    partial class FormDSKhachTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDSKhachTro));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dgvDSKhachTro = new System.Windows.Forms.DataGridView();
            this.clmMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachTro)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AllowMinimizeRibbon = false;
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Blue;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.btnDong});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 412;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1163, 193);
            this.ribbon.Click += new System.EventHandler(this.Ribbon_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Xuất file Excel";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.LargeWidth = 100;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem1_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 2;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.LargeWidth = 100;
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDong_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tác vụ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDong);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // dgvDSKhachTro
            // 
            this.dgvDSKhachTro.AllowUserToAddRows = false;
            this.dgvDSKhachTro.AllowUserToDeleteRows = false;
            this.dgvDSKhachTro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSKhachTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhachTro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaKH,
            this.clmHoTen,
            this.clmNamSinh,
            this.clmSDT,
            this.clmGioiTinh,
            this.clmQueQuan,
            this.clmCMND});
            this.dgvDSKhachTro.Location = new System.Drawing.Point(12, 200);
            this.dgvDSKhachTro.Name = "dgvDSKhachTro";
            this.dgvDSKhachTro.ReadOnly = true;
            this.dgvDSKhachTro.RowHeadersWidth = 51;
            this.dgvDSKhachTro.RowTemplate.Height = 24;
            this.dgvDSKhachTro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKhachTro.Size = new System.Drawing.Size(1137, 499);
            this.dgvDSKhachTro.TabIndex = 2;
            // 
            // clmMaKH
            // 
            this.clmMaKH.HeaderText = "Mã khách hàng";
            this.clmMaKH.MinimumWidth = 6;
            this.clmMaKH.Name = "clmMaKH";
            this.clmMaKH.ReadOnly = true;
            // 
            // clmHoTen
            // 
            this.clmHoTen.HeaderText = "Họ tên";
            this.clmHoTen.MinimumWidth = 6;
            this.clmHoTen.Name = "clmHoTen";
            this.clmHoTen.ReadOnly = true;
            // 
            // clmNamSinh
            // 
            this.clmNamSinh.HeaderText = "Năm sinh";
            this.clmNamSinh.MinimumWidth = 6;
            this.clmNamSinh.Name = "clmNamSinh";
            this.clmNamSinh.ReadOnly = true;
            // 
            // clmSDT
            // 
            this.clmSDT.HeaderText = "SDT";
            this.clmSDT.MinimumWidth = 6;
            this.clmSDT.Name = "clmSDT";
            this.clmSDT.ReadOnly = true;
            // 
            // clmGioiTinh
            // 
            this.clmGioiTinh.HeaderText = "Giới tính";
            this.clmGioiTinh.MinimumWidth = 6;
            this.clmGioiTinh.Name = "clmGioiTinh";
            this.clmGioiTinh.ReadOnly = true;
            // 
            // clmQueQuan
            // 
            this.clmQueQuan.HeaderText = "Quê quán";
            this.clmQueQuan.MinimumWidth = 6;
            this.clmQueQuan.Name = "clmQueQuan";
            this.clmQueQuan.ReadOnly = true;
            // 
            // clmCMND
            // 
            this.clmCMND.HeaderText = "CMND";
            this.clmCMND.MinimumWidth = 6;
            this.clmCMND.Name = "clmCMND";
            this.clmCMND.ReadOnly = true;
            // 
            // FormDSKhachTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 704);
            this.Controls.Add(this.dgvDSKhachTro);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FormDSKhachTro.IconOptions.SvgImage")));
            this.MaximumSize = new System.Drawing.Size(1165, 705);
            this.MinimumSize = new System.Drawing.Size(1165, 705);
            this.Name = "FormDSKhachTro";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách khách trọ";
            this.Load += new System.EventHandler(this.DFormDSKhachTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachTro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.DataGridView dgvDSKhachTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCMND;
    }
}