
namespace ShopPhone.GUI
{
    partial class frmHang
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
            this.cbbMaNCC = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhaSX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtROM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtManHinh = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCamera = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbMaNCC
            // 
            this.cbbMaNCC.FormattingEnabled = true;
            this.cbbMaNCC.Location = new System.Drawing.Point(859, 178);
            this.cbbMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaNCC.Name = "cbbMaNCC";
            this.cbbMaNCC.Size = new System.Drawing.Size(148, 24);
            this.cbbMaNCC.TabIndex = 30;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(521, 87);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(236, 22);
            this.txtTimKiem.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tìm theo mã hàng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(805, 79);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 41);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(741, 18);
            this.btnReview.Margin = new System.Windows.Forms.Padding(4);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(100, 41);
            this.btnReview.TabIndex = 4;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(567, 18);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(100, 41);
            this.btnHienThi.TabIndex = 3;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(392, 18);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 41);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(216, 18);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 41);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnReview);
            this.panel1.Controls.Add(this.btnHienThi);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(67, 229);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 123);
            this.panel1.TabIndex = 29;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(37, 18);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 41);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(758, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Mã NCC";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(859, 120);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(148, 22);
            this.txtSoLuong.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(758, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(859, 66);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(148, 22);
            this.txtDonGia.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(758, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Đơn giá";
            // 
            // txtNhaSX
            // 
            this.txtNhaSX.Location = new System.Drawing.Point(175, 178);
            this.txtNhaSX.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhaSX.Name = "txtNhaSX";
            this.txtNhaSX.Size = new System.Drawing.Size(157, 22);
            this.txtNhaSX.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nhà sản xuất";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(175, 120);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(157, 22);
            this.txtTenHang.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên hàng";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(175, 63);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(157, 22);
            this.txtMaHang.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(367, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quản Lý Thông Tin Hàng";
            // 
            // dgvHang
            // 
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Location = new System.Drawing.Point(67, 360);
            this.dgvHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.RowHeadersWidth = 51;
            this.dgvHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHang.Size = new System.Drawing.Size(940, 209);
            this.dgvHang.TabIndex = 16;
            this.dgvHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHang_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "ROM";
            // 
            // txtROM
            // 
            this.txtROM.Location = new System.Drawing.Point(402, 63);
            this.txtROM.Margin = new System.Windows.Forms.Padding(4);
            this.txtROM.Name = "txtROM";
            this.txtROM.Size = new System.Drawing.Size(125, 22);
            this.txtROM.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "RAM";
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(402, 120);
            this.txtRAM.Margin = new System.Windows.Forms.Padding(4);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(125, 22);
            this.txtRAM.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(348, 181);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "CPU";
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(402, 178);
            this.txtCPU.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(125, 22);
            this.txtCPU.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(546, 66);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Màn hình";
            // 
            // txtManHinh
            // 
            this.txtManHinh.Location = new System.Drawing.Point(620, 63);
            this.txtManHinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtManHinh.Name = "txtManHinh";
            this.txtManHinh.Size = new System.Drawing.Size(125, 22);
            this.txtManHinh.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(546, 123);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Pin";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(620, 120);
            this.txtPin.Margin = new System.Windows.Forms.Padding(4);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(125, 22);
            this.txtPin.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(546, 181);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "Camera";
            // 
            // txtCamera
            // 
            this.txtCamera.Location = new System.Drawing.Point(620, 178);
            this.txtCamera.Margin = new System.Windows.Forms.Padding(4);
            this.txtCamera.Name = "txtCamera";
            this.txtCamera.Size = new System.Drawing.Size(125, 22);
            this.txtCamera.TabIndex = 23;
            // 
            // frmHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 561);
            this.Controls.Add(this.cbbMaNCC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCamera);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.txtNhaSX);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtManHinh);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtROM);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHang);
            this.Name = "frmHang";
            this.Text = "frmHang";
            this.Load += new System.EventHandler(this.frmHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaNCC;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhaSX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtROM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtManHinh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCamera;
    }
}