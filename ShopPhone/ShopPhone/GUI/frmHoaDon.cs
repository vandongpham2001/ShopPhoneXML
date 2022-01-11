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
using System.Xml;

namespace ShopPhone.GUI
{
    public partial class frmHoaDon : Form
    {
        FileXml Fxml = new FileXml();
        HoaDon hd = new HoaDon();
        KhachHang kh = new KhachHang();
        NhanVien nv = new NhanVien();
        ChiTietHoaDon cthd = new ChiTietHoaDon();
        string MaKhachHang, MaNhanVien, DiaChi, SDT, TrangThai, NgayLap, SoHD;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public void hienthiHoaDon()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("HoaDon.xml");
            dgvHoaDon.DataSource = dt;

        }
        public void LoadDuLieu()
        {
            SoHD = cbbSoHoaDon.SelectedValue.ToString();
            MaKhachHang = cbbMaKhachHang.SelectedValue.ToString();
            MaNhanVien = cbbMaNhanVien.SelectedValue.ToString();
            DiaChi = txtDiaChi.Text;
            TrangThai = txtTrangThai.Text;
            SDT = txtSDT.Text;
            NgayLap = dtpNgayLap.Value.ToString("yyyy-MM-dd");
        }

        private void cbbSoHoaDon_SelectedValueChanged(object sender, EventArgs e)
        {
            //hienthiHoaDon();
            ////string Sohd = cbbSoHoaDon.SelectedValue.ToString();
            ////int sohd = Int32.Parse(Sohd);
            //LoadDuLieu();
            //int sohd = Int32.Parse(SoHD);
            //if (sohd % 1==0)
            //{
            //    dgvHoaDon.Visible = false;
            //    dgvCTHD.Visible = true;
            //    DataTable dt = new DataTable();
            //    dt = Fxml.XemChiTietHoaDonTheoSoHD(sohd);
            //    dgvCTHD.DataSource = dt;
            //}
        }

        private void cbbSoHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hienthiHoaDon();
            //string sohd = cbbSoHoaDon.Text;
            ////int Sohd = Int32.Parse(sohd);
            //if (sohd != null)
            //{
            //    dgvHoaDon.Visible = false;
            //    dgvCTHD.Visible = true;
            //    DataTable dt = new DataTable();
            //    dt = Fxml.XemChiTietHoaDonTheoSoHD(sohd);
            //    dgvCTHD.DataSource = dt;
            //}
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvCTHD.Visible = false;
            hienthiHoaDon();
            cbbSoHoaDon.DataSource = hd.LoadSoHD();
            cbbSoHoaDon.DisplayMember = "SoHoaDon";
            cbbSoHoaDon.ValueMember = "SoHoaDon";
            cbbMaKhachHang.DataSource = kh.LoadMaKH();
            cbbMaKhachHang.DisplayMember = "TenKhachHang";
            cbbMaKhachHang.ValueMember = "MaKhachHang";
            cbbMaNhanVien.DataSource = nv.LoadMaNV();
            cbbMaNhanVien.DisplayMember = "TenNhanVien";
            cbbMaNhanVien.ValueMember = "MaNhanVien";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            int sohd = Int32.Parse(SoHD);
            if (hd.kiemtra(sohd) == true)
            {
                MessageBox.Show("Số hoá đơn đã tồn tại");
            }
            else
            {
                hd.themHD(sohd, MaKhachHang, MaNhanVien, DiaChi, SDT, TrangThai);
                MessageBox.Show("Ok");
                hienthiHoaDon();
                cbbSoHoaDon.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvHoaDon.CurrentRow.Index;
            cbbMaKhachHang.SelectedValue = dgvHoaDon.Rows[d].Cells[1].Value.ToString();
            cbbSoHoaDon.SelectedValue = dgvHoaDon.Rows[d].Cells[0].Value.ToString();
            txtSDT.Text = dgvHoaDon.Rows[d].Cells[4].Value.ToString();
            dtpNgayLap.Text = dgvHoaDon.Rows[d].Cells[6].Value.ToString();
            txtDiaChi.Text = dgvHoaDon.Rows[d].Cells[3].Value.ToString();
            txtTrangThai.Text = dgvHoaDon.Rows[d].Cells[5].Value.ToString();
            cbbMaNhanVien.SelectedValue= dgvHoaDon.Rows[d].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            int sohd = Int32.Parse(SoHD);
            hd.suaHD(sohd, MaKhachHang, MaNhanVien, DiaChi, SDT, TrangThai);
            MessageBox.Show("Ok");
            hienthiHoaDon();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            dgvCTHD.Visible = false;
            dgvHoaDon.Visible = true;
            hienthiHoaDon();
        }
    }
}
