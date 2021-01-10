namespace QL_PhongTro
{
    partial class FormChiTietPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietPhong));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbtnThanhToan = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnTraPhong = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDong = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gbThangTruoc = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThangSau = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.gbThangTruoc.SuspendLayout();
            this.gbThangSau.SuspendLayout();
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
            this.bbtnThanhToan,
            this.bbtnTraPhong,
            this.bbtnLuu,
            this.bbtnDong});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(760, 193);
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // bbtnThanhToan
            // 
            this.bbtnThanhToan.Caption = "Thanh toán";
            this.bbtnThanhToan.Id = 1;
            this.bbtnThanhToan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtnThanhToan.ImageOptions.SvgImage")));
            this.bbtnThanhToan.LargeWidth = 100;
            this.bbtnThanhToan.Name = "bbtnThanhToan";
            // 
            // bbtnTraPhong
            // 
            this.bbtnTraPhong.Caption = "Trả phòng";
            this.bbtnTraPhong.Id = 3;
            this.bbtnTraPhong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtnTraPhong.ImageOptions.SvgImage")));
            this.bbtnTraPhong.LargeWidth = 100;
            this.bbtnTraPhong.Name = "bbtnTraPhong";
            // 
            // bbtnLuu
            // 
            this.bbtnLuu.Caption = "Lưu";
            this.bbtnLuu.Id = 5;
            this.bbtnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtnLuu.ImageOptions.SvgImage")));
            this.bbtnLuu.LargeWidth = 100;
            this.bbtnLuu.Name = "bbtnLuu";
            // 
            // bbtnDong
            // 
            this.bbtnDong.Caption = "Đóng";
            this.bbtnDong.Id = 6;
            this.bbtnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtnDong.ImageOptions.SvgImage")));
            this.bbtnDong.LargeWidth = 100;
            this.bbtnDong.Name = "bbtnDong";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tác vụ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnThanhToan);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtnTraPhong);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.bbtnLuu);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.bbtnDong);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // gbThangTruoc
            // 
            this.gbThangTruoc.Controls.Add(this.label7);
            this.gbThangTruoc.Controls.Add(this.label6);
            this.gbThangTruoc.Controls.Add(this.textBox2);
            this.gbThangTruoc.Controls.Add(this.textBox1);
            this.gbThangTruoc.Controls.Add(this.label2);
            this.gbThangTruoc.Controls.Add(this.label1);
            this.gbThangTruoc.Location = new System.Drawing.Point(12, 220);
            this.gbThangTruoc.Name = "gbThangTruoc";
            this.gbThangTruoc.Size = new System.Drawing.Size(367, 212);
            this.gbThangTruoc.TabIndex = 2;
            this.gbThangTruoc.TabStop = false;
            this.gbThangTruoc.Text = "Tháng trước";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "m3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kwh";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nước: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điện: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbThangSau
            // 
            this.gbThangSau.Controls.Add(this.textBox6);
            this.gbThangSau.Controls.Add(this.label11);
            this.gbThangSau.Controls.Add(this.label12);
            this.gbThangSau.Controls.Add(this.label17);
            this.gbThangSau.Controls.Add(this.label16);
            this.gbThangSau.Controls.Add(this.textBox5);
            this.gbThangSau.Location = new System.Drawing.Point(385, 220);
            this.gbThangSau.Name = "gbThangSau";
            this.gbThangSau.Size = new System.Drawing.Size(358, 212);
            this.gbThangSau.TabIndex = 3;
            this.gbThangSau.TabStop = false;
            this.gbThangSau.Text = "Tháng này";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(101, 144);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(173, 23);
            this.textBox6.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.Location = new System.Drawing.Point(5, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Điện: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label12.Location = new System.Drawing.Point(5, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nước: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(280, 150);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 17);
            this.label17.TabIndex = 3;
            this.label17.Text = "m3";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(280, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "Kwh";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(101, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(173, 23);
            this.textBox5.TabIndex = 5;
            // 
            // FormChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 719);
            this.Controls.Add(this.gbThangSau);
            this.Controls.Add(this.gbThangTruoc);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FormChiTietPhong.IconOptions.SvgImage")));
            this.Name = "FormChiTietPhong";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phòng";
            this.Load += new System.EventHandler(this.FormChiTietPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.gbThangTruoc.ResumeLayout(false);
            this.gbThangTruoc.PerformLayout();
            this.gbThangSau.ResumeLayout(false);
            this.gbThangSau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bbtnThanhToan;
        private DevExpress.XtraBars.BarButtonItem bbtnTraPhong;
        private System.Windows.Forms.GroupBox gbThangTruoc;
        private System.Windows.Forms.GroupBox gbThangSau;
        private DevExpress.XtraBars.BarButtonItem bbtnLuu;
        private DevExpress.XtraBars.BarButtonItem bbtnDong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox5;
    }
}