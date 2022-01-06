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
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void txtMaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDonGia.Text = Fxml.LayGiaTri("Hang.xml", "MaHang", txtMaHang.Text, "DonGia");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSoLuong.Text == " ")
            {
                txtSoLuong.Text = "";
            }
            else
            {
                try
                {
                    int a = int.Parse(txtSoLuong.Text);
                    long t = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
                    txtTongTien.Text = t.ToString();
                }
                catch
                {
                    txtSoLuong.Text = "";
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
