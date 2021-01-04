
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
            this.dgwHoaDon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInHD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.clmSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDienThangTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDienThangNay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTienDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNuocThangTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNuocThangNay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTienNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTienRac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwHoaDon
            // 
            this.dgwHoaDon.AllowUserToAddRows = false;
            this.dgwHoaDon.AllowUserToDeleteRows = false;
            this.dgwHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSoPhong,
            this.clmNgayLapHD,
            this.clmDienThangTruoc,
            this.clmDienThangNay,
            this.clmTienDien,
            this.clmNuocThangTruoc,
            this.clmNuocThangNay,
            this.clmTienNuoc,
            this.clmTienRac,
            this.clmTongTien});
            this.dgwHoaDon.Location = new System.Drawing.Point(5, 6);
            this.dgwHoaDon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgwHoaDon.Name = "dgwHoaDon";
            this.dgwHoaDon.ReadOnly = true;
            this.dgwHoaDon.RowHeadersWidth = 62;
            this.dgwHoaDon.RowTemplate.Height = 28;
            this.dgwHoaDon.Size = new System.Drawing.Size(1184, 456);
            this.dgwHoaDon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(932, 514);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiền lãi tháng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1049, 477);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1049, 507);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(932, 484);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng tiền";
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(935, 535);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(106, 26);
            this.btnInHD.TabIndex = 5;
            this.btnInHD.Text = "In hóa đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // button1
            // 
            this.button1.ImageKey = "(none)";
            this.button1.Location = new System.Drawing.Point(1050, 535);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "exit.jfif");
            // 
            // clmSoPhong
            // 
            this.clmSoPhong.HeaderText = "Số Phòng";
            this.clmSoPhong.MinimumWidth = 8;
            this.clmSoPhong.Name = "clmSoPhong";
            this.clmSoPhong.ReadOnly = true;
            // 
            // clmNgayLapHD
            // 
            this.clmNgayLapHD.HeaderText = "Ngày lập hóa đơn";
            this.clmNgayLapHD.MinimumWidth = 6;
            this.clmNgayLapHD.Name = "clmNgayLapHD";
            this.clmNgayLapHD.ReadOnly = true;
            // 
            // clmDienThangTruoc
            // 
            this.clmDienThangTruoc.HeaderText = "Số điện tháng rồi";
            this.clmDienThangTruoc.MinimumWidth = 8;
            this.clmDienThangTruoc.Name = "clmDienThangTruoc";
            this.clmDienThangTruoc.ReadOnly = true;
            // 
            // clmDienThangNay
            // 
            this.clmDienThangNay.HeaderText = "Số điện tháng này";
            this.clmDienThangNay.MinimumWidth = 8;
            this.clmDienThangNay.Name = "clmDienThangNay";
            this.clmDienThangNay.ReadOnly = true;
            // 
            // clmTienDien
            // 
            this.clmTienDien.HeaderText = "Tiền điện";
            this.clmTienDien.MinimumWidth = 8;
            this.clmTienDien.Name = "clmTienDien";
            this.clmTienDien.ReadOnly = true;
            // 
            // clmNuocThangTruoc
            // 
            this.clmNuocThangTruoc.HeaderText = "Số nước tháng rồi";
            this.clmNuocThangTruoc.MinimumWidth = 8;
            this.clmNuocThangTruoc.Name = "clmNuocThangTruoc";
            this.clmNuocThangTruoc.ReadOnly = true;
            // 
            // clmNuocThangNay
            // 
            this.clmNuocThangNay.HeaderText = "Số nước tháng này";
            this.clmNuocThangNay.MinimumWidth = 8;
            this.clmNuocThangNay.Name = "clmNuocThangNay";
            this.clmNuocThangNay.ReadOnly = true;
            // 
            // clmTienNuoc
            // 
            this.clmTienNuoc.HeaderText = "Tiền nước";
            this.clmTienNuoc.MinimumWidth = 8;
            this.clmTienNuoc.Name = "clmTienNuoc";
            this.clmTienNuoc.ReadOnly = true;
            // 
            // clmTienRac
            // 
            this.clmTienRac.HeaderText = "Tiền rác";
            this.clmTienRac.MinimumWidth = 8;
            this.clmTienRac.Name = "clmTienRac";
            this.clmTienRac.ReadOnly = true;
            // 
            // clmTongTien
            // 
            this.clmTongTien.HeaderText = "Tổng tiền";
            this.clmTongTien.MinimumWidth = 8;
            this.clmTongTien.Name = "clmTongTien";
            this.clmTongTien.ReadOnly = true;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwHoaDon);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgwHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button button1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDienThangTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDienThangNay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTienDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNuocThangTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNuocThangNay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTienNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTienRac;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTongTien;
    }
}