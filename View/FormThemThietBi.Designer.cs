
namespace QL_PhongTro
{
    partial class FormThemThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemThietBi));
            this.gbThietBi = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblTenthietbi = new System.Windows.Forms.Label();
            this.lblDongia = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gbThietBi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThietBi
            // 
            this.gbThietBi.BackColor = System.Drawing.Color.Gainsboro;
            this.gbThietBi.Controls.Add(this.comboBox2);
            this.gbThietBi.Controls.Add(this.comboBox1);
            this.gbThietBi.Controls.Add(this.btnThem);
            this.gbThietBi.Controls.Add(this.btnDong);
            this.gbThietBi.Controls.Add(this.textBox4);
            this.gbThietBi.Controls.Add(this.lblSoluong);
            this.gbThietBi.Controls.Add(this.lblDongia);
            this.gbThietBi.Controls.Add(this.lblTenthietbi);
            this.gbThietBi.Location = new System.Drawing.Point(13, 12);
            this.gbThietBi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbThietBi.Name = "gbThietBi";
            this.gbThietBi.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbThietBi.Size = new System.Drawing.Size(443, 363);
            this.gbThietBi.TabIndex = 0;
            this.gbThietBi.TabStop = false;
            this.gbThietBi.Text = "Thông Tin Thiết Bị";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(224, 299);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 43);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(334, 299);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(91, 43);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(224, 200);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 26);
            this.textBox4.TabIndex = 1;
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(56, 206);
            this.lblSoluong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(69, 18);
            this.lblSoluong.TabIndex = 0;
            this.lblSoluong.Text = "Số Lượng";
            // 
            // lblTenthietbi
            // 
            this.lblTenthietbi.AutoSize = true;
            this.lblTenthietbi.Location = new System.Drawing.Point(56, 65);
            this.lblTenthietbi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenthietbi.Name = "lblTenthietbi";
            this.lblTenthietbi.Size = new System.Drawing.Size(93, 18);
            this.lblTenthietbi.TabIndex = 0;
            this.lblTenthietbi.Text = "Tên Thiết Bị ";
            // 
            // lblDongia
            // 
            this.lblDongia.AutoSize = true;
            this.lblDongia.Location = new System.Drawing.Point(56, 136);
            this.lblDongia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(48, 18);
            this.lblDongia.TabIndex = 0;
            this.lblDongia.Text = "Phòng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(224, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(201, 26);
            this.comboBox2.TabIndex = 4;
            // 
            // FormThemThietBi
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 403);
            this.Controls.Add(this.gbThietBi);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FormThemThietBi.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormThemThietBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thiết bị";
            this.Load += new System.EventHandler(this.FormThemThietBi_Load);
            this.gbThietBi.ResumeLayout(false);
            this.gbThietBi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThietBi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblTenthietbi;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDongia;
    }
}