using ShopPhone.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopPhone.GUI
{
    public partial class frmTaiKhoanNV : Form
    {
        FileXml Fxml = new FileXml();
        NhanVien nv = new NhanVien();
        DangNhap dn = new DangNhap();
        //string MaNhanVien, MatKhau; int Quyen;
        public frmTaiKhoanNV()
        {
            InitializeComponent();
        }
        public void hienthiTTTK()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("TaiKhoan.xml");
            dgvTaiKhoanNhanVien.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool kt = nv.kiemtra(txtMaNhanVien.Text.ToString());
            if (nv.kiemtra(txtMaNhanVien.Text.ToString()) == false)
            {
                MessageBox.Show("Không có nhân viên này");
            }
            if (kt==true)
            {
                if (dn.kiemtraTTTK(txtMaNhanVien.Text) == true)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                    txtMaNhanVien.Text = "";
                    txtMatKhau.Text = "";
                    txtQuyen.Text = "";
                    txtTenNhanVien.Text = "";
                    txtMaNhanVien.Focus();

                }
                else
                {
                    dn.dangkiTaiKhoan(txtMaNhanVien.Text, txtMatKhau.Text, int.Parse(txtQuyen.Text));
                    MessageBox.Show("Ok");
                    hienthiTTTK();
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dn.xoaTK(txtMaNhanVien.Text);
            MessageBox.Show("Ok");
            hienthiTTTK();
        }

        private void tbnTen_Click(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = Fxml.LayGiaTri("NhanVien.xml", "MaNhanVien", txtMaNhanVien.Text, "TenNhanVien");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTaiKhoanNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvTaiKhoanNhanVien.CurrentRow.Index;
            txtMaNhanVien.Text = dgvTaiKhoanNhanVien.Rows[d].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoanNhanVien.Rows[d].Cells[1].Value.ToString();
            //txtTenNhanVien.Text = dgvTaiKhoanNhanVien.Rows[d].Cells[2].Value.ToString();
            txtQuyen.Text = dgvTaiKhoanNhanVien.Rows[d].Cells[2].Value.ToString();
        }

        private void frmTaiKhoanNV_Load(object sender, EventArgs e)
        {
            hienthiTTTK();
        }
        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    if (nv.kiemtra(txtMaNhanVien.Text) == false)
        //    {
        //        MessageBox.Show("Không có nhân viên này");
        //    }

        //    else
        //    {
        //        if (dn.kiemtraTTTK(txtMaNhanVien.Text) == true)
        //        {
        //            MessageBox.Show("Tên đăng nhập đã tồn tại");
        //            txtMaNhanVien.Text = "";
        //            txtMatKhau.Text = "";
        //            txtQuyen.Text = "";
        //            txtTenNhanVien.Text = "";
        //            txtMaNhanVien.Focus();

        //        }
        //        else
        //        {
        //            dn.dangkiTaiKhoan(txtMaNhanVien.Text, txtMatKhau.Text, int.Parse(txtQuyen.Text));
        //            MessageBox.Show("Ok");
        //            hienthiTTTK();
        //        }

        //    }
        //}

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    dn.xoaTK(txtMaNhanVien.Text);
        //    MessageBox.Show("Ok");
        //    hienthiTTTK();
        //}

        //private void btnThoat_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void tbnTen_Click(object sender, EventArgs e)
        //{
        //    txtTenNhanVien.Text = Fxml.LayGiaTri("NhanVien.xml", "MaNhanVien", txtMaNhanVien.Text, "TenNhanVien");
        //}

        //private void frmTaiKhoanNV_Load(object sender, EventArgs e)
        //{
        //    hienthiTTTK();
        //}
        //private void dgvTaiKhoanNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int d = dgvTaiKhoanNhanVien.CurrentRow.Index;
        //    txtMaNhanVien.Text = dgvTaiKhoanNhanVien.Rows[d].Cells[0].Value.ToString();
        //    txtMatKhau.Text = dgvTaiKhoanNhanVien.Rows[d].Cells[1].Value.ToString();
        //    //txtTenNhanVien.Text = dgvTaiKhoanNhanVien.Rows[d].Cells[2].Value.ToString();
        //    txtQuyen.Text = dgvTaiKhoanNhanVien.Rows[d].Cells[2].Value.ToString();

        //}

    }
}
