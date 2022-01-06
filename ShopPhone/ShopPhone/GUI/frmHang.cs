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
    public partial class frmHang : Form
    {
        FileXml Fxml = new FileXml();
        Hang H = new Hang();
        NhaCungCap ncc = new NhaCungCap();
        public frmHang()
        {
            InitializeComponent();
        }
        public void hienthiHang()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("Hang.xml");
            dgvHang.DataSource = dt;
        }
        void LoadTable()
        {
            DataTable dt = new DataTable();
            dt = ncc.LoadTable();
            dgvHang.DataSource = dt;
        }

        private void frmHang_Load(object sender, EventArgs e)
        {
            cbbMaNCC.DataSource = ncc.LoadMaNCC();
            cbbMaNCC.DisplayMember = "TenNCC";
            cbbMaNCC.ValueMember = "MaNCC";
            hienthiHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (H.kiemtraMaHang(txtMaHang.Text) == true)
            {
                MessageBox.Show("Mã hàng đã tồn tại");
            }
            else
            {
                H.themH(txtMaHang.Text, txtTenHang.Text, txtNhaSX.Text, txtROM.Text, txtRAM.Text, txtCPU.Text, txtManHinh.Text, txtPin.Text, txtCamera.Text, txtDonGia.Text, txtSoLuong.Text, cbbMaNCC.SelectedValue.ToString());
                MessageBox.Show("Ok");
                hienthiHang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            H.suaH(txtMaHang.Text, txtTenHang.Text, txtNhaSX.Text, txtROM.Text, txtRAM.Text, txtCPU.Text, txtManHinh.Text, txtPin.Text, txtCamera.Text, txtDonGia.Text, txtSoLuong.Text, cbbMaNCC.SelectedValue.ToString());
            MessageBox.Show("Ok");
            hienthiHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            H.xoaH(txtMaHang.Text);
            MessageBox.Show("Ok");
            hienthiHang();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            hienthiHang();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("Hang.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "MaHang";
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
                dt.Columns.Add("Mã hàng");
                dt.Columns.Add("Tên hàng");
                dt.Columns.Add("Nhà sản xuất");
                dt.Columns.Add("ROM");
                dt.Columns.Add("RAM");
                dt.Columns.Add("CPU");
                dt.Columns.Add("Màn hình");
                dt.Columns.Add("PIN");
                dt.Columns.Add("Camera");
                dt.Columns.Add("Đơn giá");
                dt.Columns.Add("Sô lượng");
                dt.Columns.Add("Mã NCC");


                object[] list = { dv[index]["MaHang"], dv[index]["TenHang"], dv[index]["NhaSX"], dv[index]["ROM"], dv[index]["RAM"], dv[index]["CPU"], dv[index]["ManHinh"], dv[index]["Pin"], dv[index]["Camera"], dv[index]["DonGia"], dv[index]["SoLuong"], dv[index]["MaNCC"] };
                dt.Rows.Add(list);
                dgvHang.DataSource = dt;
                txtTimKiem.Text = "";
            }
        }

        private void dgvHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvHang.CurrentRow.Index;
            txtMaHang.Text = dgvHang.Rows[d].Cells[0].Value.ToString();
            txtTenHang.Text = dgvHang.Rows[d].Cells[1].Value.ToString();
            txtNhaSX.Text = dgvHang.Rows[d].Cells[2].Value.ToString();
            txtROM.Text = dgvHang.Rows[d].Cells[3].Value.ToString();
            txtRAM.Text = dgvHang.Rows[d].Cells[4].Value.ToString();
            txtCPU.Text = dgvHang.Rows[d].Cells[5].Value.ToString();
            txtManHinh.Text = dgvHang.Rows[d].Cells[6].Value.ToString();
            txtPin.Text = dgvHang.Rows[d].Cells[7].Value.ToString();
            txtCamera.Text = dgvHang.Rows[d].Cells[8].Value.ToString();
            txtDonGia.Text = dgvHang.Rows[d].Cells[9].Value.ToString();
            txtSoLuong.Text = dgvHang.Rows[d].Cells[10].Value.ToString();
            cbbMaNCC.SelectedValue = dgvHang.Rows[d].Cells[11].Value.ToString();
        }
        

    }
}
