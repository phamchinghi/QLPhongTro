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
            this.bbtnThuePhong = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnTraPhong = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnGiuCho = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDong = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gbThangTruoc = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbXeMay = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThangSau = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbXeMay2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
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
            this.bbtnThuePhong,
            this.bbtnTraPhong,
            this.bbtnGiuCho,
            this.bbtnLuu,
            this.bbtnDong});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(848, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            // bbtnThuePhong
            // 
            this.bbtnThuePhong.Caption = "Thuê phòng";
            this.bbtnThuePhong.Id = 2;
            this.bbtnThuePhong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtnThuePhong.ImageOptions.SvgImage")));
            this.bbtnThuePhong.LargeWidth = 100;
            this.bbtnThuePhong.Name = "bbtnThuePhong";
            this.bbtnThuePhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnThuePhong_ItemClick);
            // 
            // bbtnTraPhong
            // 
            this.bbtnTraPhong.Caption = "Trả phòng";
            this.bbtnTraPhong.Id = 3;
            this.bbtnTraPhong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtnTraPhong.ImageOptions.SvgImage")));
            this.bbtnTraPhong.LargeWidth = 100;
            this.bbtnTraPhong.Name = "bbtnTraPhong";
            // 
            // bbtnGiuCho
            // 
            this.bbtnGiuCho.Caption = "Giữ chỗ";
            this.bbtnGiuCho.Id = 4;
            this.bbtnGiuCho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtnGiuCho.ImageOptions.SvgImage")));
            this.bbtnGiuCho.LargeWidth = 100;
            this.bbtnGiuCho.Name = "bbtnGiuCho";
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
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
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
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnThuePhong);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtnTraPhong);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnGiuCho);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
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
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 689);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(848, 30);
            // 
            // gbThangTruoc
            // 
            this.gbThangTruoc.Controls.Add(this.label10);
            this.gbThangTruoc.Controls.Add(this.label9);
            this.gbThangTruoc.Controls.Add(this.label8);
            this.gbThangTruoc.Controls.Add(this.label7);
            this.gbThangTruoc.Controls.Add(this.label6);
            this.gbThangTruoc.Controls.Add(this.cbXeMay);
            this.gbThangTruoc.Controls.Add(this.textBox4);
            this.gbThangTruoc.Controls.Add(this.textBox3);
            this.gbThangTruoc.Controls.Add(this.textBox2);
            this.gbThangTruoc.Controls.Add(this.textBox1);
            this.gbThangTruoc.Controls.Add(this.label5);
            this.gbThangTruoc.Controls.Add(this.label4);
            this.gbThangTruoc.Controls.Add(this.label3);
            this.gbThangTruoc.Controls.Add(this.label2);
            this.gbThangTruoc.Controls.Add(this.label1);
            this.gbThangTruoc.Location = new System.Drawing.Point(12, 220);
            this.gbThangTruoc.Name = "gbThangTruoc";
            this.gbThangTruoc.Size = new System.Drawing.Size(400, 463);
            this.gbThangTruoc.TabIndex = 2;
            this.gbThangTruoc.TabStop = false;
            this.gbThangTruoc.Text = "Tháng trước";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "vnđ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "vnđ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "chiếc";
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
            // cbXeMay
            // 
            this.cbXeMay.FormattingEnabled = true;
            this.cbXeMay.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cbXeMay.Location = new System.Drawing.Point(102, 240);
            this.cbXeMay.Name = "cbXeMay";
            this.cbXeMay.Size = new System.Drawing.Size(100, 24);
            this.cbXeMay.TabIndex = 2;
            this.cbXeMay.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(102, 419);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(173, 23);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 322);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 23);
            this.textBox3.TabIndex = 3;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(6, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Wifi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(6, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rác:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(6, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số xe máy:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
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
            this.gbThangSau.Controls.Add(this.label20);
            this.gbThangSau.Controls.Add(this.textBox6);
            this.gbThangSau.Controls.Add(this.label19);
            this.gbThangSau.Controls.Add(this.label11);
            this.gbThangSau.Controls.Add(this.label18);
            this.gbThangSau.Controls.Add(this.label12);
            this.gbThangSau.Controls.Add(this.label17);
            this.gbThangSau.Controls.Add(this.label13);
            this.gbThangSau.Controls.Add(this.label16);
            this.gbThangSau.Controls.Add(this.label14);
            this.gbThangSau.Controls.Add(this.cbXeMay2);
            this.gbThangSau.Controls.Add(this.label15);
            this.gbThangSau.Controls.Add(this.textBox8);
            this.gbThangSau.Controls.Add(this.textBox5);
            this.gbThangSau.Controls.Add(this.textBox7);
            this.gbThangSau.Location = new System.Drawing.Point(436, 220);
            this.gbThangSau.Name = "gbThangSau";
            this.gbThangSau.Size = new System.Drawing.Size(400, 463);
            this.gbThangSau.TabIndex = 3;
            this.gbThangSau.TabStop = false;
            this.gbThangSau.Text = "Tháng này";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(280, 425);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 17);
            this.label20.TabIndex = 3;
            this.label20.Text = "vnđ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(101, 144);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(173, 23);
            this.textBox6.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(280, 328);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 17);
            this.label19.TabIndex = 3;
            this.label19.Text = "vnđ";
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(280, 247);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "chiếc";
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label13.Location = new System.Drawing.Point(5, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Số xe máy:";
            this.label13.Click += new System.EventHandler(this.Label3_Click);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label14.Location = new System.Drawing.Point(5, 324);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Rác:";
            // 
            // cbXeMay2
            // 
            this.cbXeMay2.FormattingEnabled = true;
            this.cbXeMay2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cbXeMay2.Location = new System.Drawing.Point(101, 240);
            this.cbXeMay2.Name = "cbXeMay2";
            this.cbXeMay2.Size = new System.Drawing.Size(100, 24);
            this.cbXeMay2.TabIndex = 7;
            this.cbXeMay2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label15.Location = new System.Drawing.Point(5, 421);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "Wifi:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(101, 419);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(173, 23);
            this.textBox8.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(101, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(173, 23);
            this.textBox5.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(101, 322);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(173, 23);
            this.textBox7.TabIndex = 8;
            // 
            // FormChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 719);
            this.Controls.Add(this.gbThangSau);
            this.Controls.Add(this.gbThangTruoc);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FormChiTietPhong.IconOptions.SvgImage")));
            this.MaximumSize = new System.Drawing.Size(850, 720);
            this.MinimumSize = new System.Drawing.Size(850, 720);
            this.Name = "FormChiTietPhong";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
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
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem bbtnThanhToan;
        private DevExpress.XtraBars.BarButtonItem bbtnThuePhong;
        private DevExpress.XtraBars.BarButtonItem bbtnTraPhong;
        private DevExpress.XtraBars.BarButtonItem bbtnGiuCho;
        private System.Windows.Forms.GroupBox gbThangTruoc;
        private System.Windows.Forms.GroupBox gbThangSau;
        private DevExpress.XtraBars.BarButtonItem bbtnLuu;
        private DevExpress.XtraBars.BarButtonItem bbtnDong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbXeMay;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbXeMay2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
    }
}