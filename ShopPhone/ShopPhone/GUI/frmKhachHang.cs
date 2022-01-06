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
    public partial class frmKhachHang : Form
    {
        FileXml Fxml = new FileXml();
        KhachHang kh = new KhachHang();
        string MaKhachHang, TenKhachHang, DiaChi, SDT, NgaySinh, Email;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public void hienthiKhachHang()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("KhachHang.xml");
            dgvKhachHang.DataSource = dt;

        }
        public void LoadDuLieu()
        {
            MaKhachHang = txtMaKhachHang.Text;
            TenKhachHang = txtTenKhachHang.Text;
            NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            DiaChi = txtDiaChi.Text;
            SDT = txtSDT.Text;
            Email = txtEmail.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            if (kh.kiemtra(MaKhachHang) == true)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
            }
            else
            {
                kh.themKH(MaKhachHang, TenKhachHang, SDT, NgaySinh, DiaChi, Email);
                MessageBox.Show("Ok");
                hienthiKhachHang();
                txtMaKhachHang.Focus();
            }
        }

        private void tbnSua_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            kh.suaKH(MaKhachHang, TenKhachHang, SDT, NgaySinh, DiaChi, Email);
            MessageBox.Show("Ok");
            hienthiKhachHang();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            hienthiKhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            kh.xoaKH(MaKhachHang);
            MessageBox.Show("Ok");
            hienthiKhachHang();
        }

        private void tbnHienThi_Click(object sender, EventArgs e)
        {
            hienthiKhachHang();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\KhachHang.xml";
            try
            {
                System.Diagnostics.Process.Start("Chrome.exe", path);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Chưa có file cần mở trong bin/debug", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("KhachHang.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "MaKhachHang";
            reader.Close();
            int index = dv.Find(txtTimKiem.Text);
            if (index == -1)
            {
                MessageBox.Show("Không tìm thấy");
                txtTimKiem.Text = "";
                txtTimKiem.Focus();

            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã khách hàng");
                dt.Columns.Add("Họ và tên");
                dt.Columns.Add("Số điện thoại");
                dt.Columns.Add("Ngày sinh");
                dt.Columns.Add("Địa chỉ");
                dt.Columns.Add("Email");


                object[] list = { dv[index]["MaKhachHang"], dv[index]["TenKhachHang"], dv[index]["SDT"], dv[index]["NgaySinh"], dv[index]["DiaChi"], dv[index]["Email"] };
                dt.Rows.Add(list);
                dgvKhachHang.DataSource = dt;
                txtTimKiem.Text = "";
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvKhachHang.CurrentRow.Index;
            txtMaKhachHang.Text = dgvKhachHang.Rows[d].Cells[0].Value.ToString();
            txtTenKhachHang.Text = dgvKhachHang.Rows[d].Cells[1].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[d].Cells[2].Value.ToString();
            dtpNgaySinh.Text = dgvKhachHang.Rows[d].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[d].Cells[4].Value.ToString();
            txtEmail.Text = dgvKhachHang.Rows[d].Cells[5].Value.ToString();
        }
    }
}
