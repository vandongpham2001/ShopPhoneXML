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
    public partial class frmHoaDon : Form
    {
        FileXml Fxml = new FileXml();
        HoaDon hd = new HoaDon();
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
            SoHD = cbbSoHoaDon.SelectedItem.ToString();
            MaKhachHang = cbbMaKhachHang.SelectedItem.ToString();
            MaNhanVien = cbbMaNhanVien.SelectedItem.ToString();
            DiaChi = txtDiaChi.Text;
            TrangThai = txtTrangThai.Text;
            SDT = txtSDT.Text;
            NgayLap = dtpNgayLap.Value.ToString("yyyy-MM-dd");
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            hienthiHoaDon();
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
            cbbMaKhachHang.SelectedItem = dgvHoaDon.Rows[d].Cells[1].Value.ToString();
            cbbSoHoaDon.SelectedItem = dgvHoaDon.Rows[d].Cells[0].Value.ToString();
            txtSDT.Text = dgvHoaDon.Rows[d].Cells[4].Value.ToString();
            dtpNgayLap.Text = dgvHoaDon.Rows[d].Cells[6].Value.ToString();
            txtDiaChi.Text = dgvHoaDon.Rows[d].Cells[3].Value.ToString();
            txtTrangThai.Text = dgvHoaDon.Rows[d].Cells[5].Value.ToString();
            cbbMaNhanVien.SelectedItem= dgvHoaDon.Rows[d].Cells[2].Value.ToString();
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

        }
    }
}
