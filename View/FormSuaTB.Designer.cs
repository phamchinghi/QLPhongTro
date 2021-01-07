
namespace QL_PhongTro
{
    partial class FormSuaTB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuaTB));
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSoLuong = new System.Windows.Forms.ComboBox();
            this.txtTenThietBi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgayTrangBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.AllowUserToAddRows = false;
            this.dgvThietBi.AllowUserToDeleteRows = false;
            this.dgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTB,
            this.tenTB,
            this.clmNgayTrangBi,
            this.dongia,
            this.sl});
            this.dgvThietBi.Location = new System.Drawing.Point(12, 236);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.ReadOnly = true;
            this.dgvThietBi.RowHeadersWidth = 51;
            this.dgvThietBi.RowTemplate.Height = 24;
            this.dgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThietBi.Size = new System.Drawing.Size(930, 270);
            this.dgvThietBi.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(633, 159);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 60);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Chỉnh Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(822, 159);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 60);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cbSoLuong);
            this.groupBox1.Controls.Add(this.txtTenThietBi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 207);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // cbSoLuong
            // 
            this.cbSoLuong.FormattingEnabled = true;
            this.cbSoLuong.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbSoLuong.Location = new System.Drawing.Point(360, 146);
            this.cbSoLuong.Name = "cbSoLuong";
            this.cbSoLuong.Size = new System.Drawing.Size(49, 24);
            this.cbSoLuong.TabIndex = 2;
            // 
            // txtTenThietBi
            // 
            this.txtTenThietBi.Location = new System.Drawing.Point(88, 147);
            this.txtTenThietBi.Name = "txtTenThietBi";
            this.txtTenThietBi.Size = new System.Drawing.Size(100, 23);
            this.txtTenThietBi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên thiết bị";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(360, 55);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 23);
            this.txtDonGia.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng";
            // 
            // txtMaTB
            // 
            this.txtMaTB.Location = new System.Drawing.Point(88, 55);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.Size = new System.Drawing.Size(100, 23);
            this.txtMaTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thiết bị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phòng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(360, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // maTB
            // 
            this.maTB.HeaderText = "Mã Thiết Bị";
            this.maTB.MinimumWidth = 6;
            this.maTB.Name = "maTB";
            this.maTB.ReadOnly = true;
            // 
            // tenTB
            // 
            this.tenTB.HeaderText = "Tên Thiết Bị";
            this.tenTB.MinimumWidth = 6;
            this.tenTB.Name = "tenTB";
            this.tenTB.ReadOnly = true;
            // 
            // clmNgayTrangBi
            // 
            this.clmNgayTrangBi.HeaderText = "Ngày trang bị";
            this.clmNgayTrangBi.MinimumWidth = 6;
            this.clmNgayTrangBi.Name = "clmNgayTrangBi";
            this.clmNgayTrangBi.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn Giá";
            this.dongia.MinimumWidth = 6;
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // sl
            // 
            this.sl.HeaderText = "Số Lượng";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            // 
            // FormSuaTB
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvThietBi);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FormSuaTB.IconOptions.SvgImage")));
            this.MaximumSize = new System.Drawing.Size(970, 560);
            this.MinimumSize = new System.Drawing.Size(970, 560);
            this.Name = "FormSuaTB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa TT thiết bị";
            this.Load += new System.EventHandler(this.FormSuaTB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSoLuong;
        private System.Windows.Forms.TextBox txtTenThietBi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgayTrangBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}