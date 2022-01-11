using ShopPhone.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShopPhone.GUI
{
    public partial class frmMain : Form
    {
        FileXml Fxml = new FileXml();
        Main M = new Main();
        HeThong HT = new HeThong();
        public frmMain()
        {
            InitializeComponent();
        }
        public static string tenDNMain = "";
        public static string maNVMain = "";
        void ThongTinDangNhap()
        {

            lblHoTen.Text = M.HoTen(tenDNMain);
            lblTen.Text = M.HoTen(tenDNMain);


        }
        private bool CheckForm(string nameForm)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
                if (frm.Name == nameForm)
                {
                    check = true;
                    break;
                }
            return check;

        }
        private void ActivateForm(string nameForm)
        {
            foreach (Form frm in this.MdiChildren)
                if (frm.Name == nameForm)
                {
                    frm.Activate();
                    break;
                }
        }


        public void QuyenDangNhap(bool e)
        {
            mnuHeThong.Enabled = e;
            mnuKinhDoanh.Enabled = e;
            mnuQLNhanSu.Enabled = e;
            đổiMậtKhẩuToolStripMenuItem.Enabled = e;
            lblQuyen.Visible = e;
            lblHoTen.Visible = e;
            mnuBaoCaoThongKe.Enabled = e;
            đăngNhậpToolStripMenuItem.Enabled = !e;


            if (tenDNMain.Equals("admin"))
            {
                mnuQLNhanSu.Enabled = e;
                lblQuyen.Visible = e;
                lblHoTen.Visible = e;
                mnuBaoCaoThongKe.Enabled = e;
                đổiMậtKhẩuToolStripMenuItem.Enabled = e;
                lblQuyen.Text = "Administrutor";
            }
            else
            {
                mnuQLNhanSu.Enabled = false;
                mnuHeThong.Enabled = true;
                lblQuyen.Text = "Nhân Viên";

            }
            if (e) ThongTinDangNhap();
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckForm("frmDangNhap"))
            {
                Form frm = new frmDangNhap();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActivateForm("frmDangNhap");
            }
            //đăngNhậpToolStripMenuItem.Enabled = false;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuyenDangNhap(false);
            tenDNMain = "";
            maNVMain = "";
            mnuHeThong.Enabled = true;
            đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = false;
            lblHoTen.Text = "";
            lblQuyen.Text = "";
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void quảnLýTàiKhoảnNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoanNV frm = new frmTaiKhoanNV();
            frm.ShowDialog();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHang frm = new frmHang();
            frm.ShowDialog();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            frm.ShowDialog();
        }

        private void mnuBaoCaoThongKe_Click(object sender, EventArgs e)
        {

        }

        private void từSQLXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HT.TaoXML();
                MessageBox.Show("Tạo XML thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void từXMLSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HT.CapNhapSQL();
                MessageBox.Show("Cập nhập SQL server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            QuyenDangNhap(false);
            if (!CheckForm("frmDangNhap"))
            {
                Form frm = new frmDangNhap();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActivateForm("frmDangNhap");
            }
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }

        private void chuyểnĐổiSangHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String pathItem = "NhanVien.xml";
            String pathHTML = "NhanVien.html";
            XDocument xItem = XDocument.Load(pathItem);

            var xI = xItem.Descendants("_x0027_NhanVien_x0027_");
            var html = new XElement("html", // Tạo cây HTML trong bộ nhớ
            new XElement("head",
                new XElement("style", "table{border:solid 1px red;border - collapse: collapse}", "td{border:solid 1px silver;}"// Hãy thêm nhiều style nữa ở đây.
                            )// End of style
                        ), // End of head
                new XElement("body",
                    new XElement("h2", "Danh sách"),
                        new XElement("table",
                            new XElement("tr",
                                new XElement("td", "MaNV"),
                                new XElement("td", "TenNV"),
                                new XElement("td", "SDT"),
                                new XElement("td", "NgaySinh"),
                                new XElement("td", "Email"),
                                new XElement("td", "GioiTinh")
                                        ), // End of tr of table header
                                from el in xI
                                select new XElement("tr",
                                new XElement("td", el.Element("MaNhanVien").Value),
                                new XElement("td", el.Element("TenNhanVien").Value),
                                new XElement("td", el.Element("SDT").Value),
                                new XElement("td", el.Element("NgaySinh").Value),
                                new XElement("td", el.Element("Email").Value),
                                new XElement("td", el.Element("GioiTinh").Value)
                                                    ) 
                                        ) // End of table
                            ) // End of body
                            ); // End of html
            html.Save(pathHTML);
            Process.Start(pathHTML);
        }

        private void chuyểnĐổiSangHTMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String pathItem = "TaiKhoan.xml";
            String pathHTML = "TaiKhoan.html";
            XDocument xItem = XDocument.Load(pathItem);

            var xI = xItem.Descendants("_x0027_TaiKhoan_x0027_");
            var html = new XElement("html", // Tạo cây HTML trong bộ nhớ
            new XElement("head",
                new XElement("style", "table{border:solid 1px red;border - collapse: collapse}", "td{border:solid 1px silver;}"// Hãy thêm nhiều style nữa ở đây.
                            )// End of style
                        ), // End of head
                new XElement("body",
                    new XElement("h2", "Danh sách"),
                        new XElement("table",
                            new XElement("tr",
                                new XElement("td", "MaNV"),
                                new XElement("td", "MatKhau"),
                                new XElement("td", "Quyen")
                                        ), // End of tr of table header
                                from el in xI
                                select new XElement("tr",
                                new XElement("td", el.Element("MaNhanVien").Value),
                                new XElement("td", el.Element("MatKhau").Value),
                                new XElement("td", el.Element("quyen").Value)
                                                    )
                                        ) // End of table
                            ) // End of body
                            ); // End of html
            html.Save(pathHTML);
            Process.Start(pathHTML);
        }

        private void chuyểnĐổiSangHTMLToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            String pathItem = "Hang.xml";
            String pathHTML = "Hang.html";
            XDocument xItem = XDocument.Load(pathItem);

            var xI = xItem.Descendants("_x0027_Hang_x0027_");
            var html = new XElement("html", // Tạo cây HTML trong bộ nhớ
            new XElement("head",
                new XElement("style", "table{border:solid 1px red;border - collapse: collapse}", "td{border:solid 1px silver;}"// Hãy thêm nhiều style nữa ở đây.
                            )// End of style
                        ), // End of head
                new XElement("body",
                    new XElement("h2", "Danh sách"),
                        new XElement("table",
                            new XElement("tr",
                                new XElement("td", "MaHang"),
                                new XElement("td", "TenHang"),
                                new XElement("td", "NhaSX"),
                                new XElement("td", "ROM"),
                                new XElement("td", "RAM"),
                                new XElement("td", "CPU"),
                                new XElement("td", "ManHinh"),
                                new XElement("td", "Pin"),
                                new XElement("td", "Camera"),
                                new XElement("td", "DonGia"),
                                new XElement("td", "SoLuong"),
                                new XElement("td", "MaNCC")
                                        ), // End of tr of table header
                                from el in xI
                                select new XElement("tr",
                                new XElement("td", el.Element("MaHang").Value),
                                new XElement("td", el.Element("TenHang").Value),
                                new XElement("td", el.Element("NhaSX").Value),
                                new XElement("td", el.Element("ROM").Value),
                                new XElement("td", el.Element("RAM").Value),
                                new XElement("td", el.Element("CPU").Value),
                                new XElement("td", el.Element("ManHinh").Value),
                                new XElement("td", el.Element("Pin").Value),
                                new XElement("td", el.Element("Camera").Value),
                                new XElement("td", el.Element("DonGia").Value),
                                new XElement("td", el.Element("SoLuong").Value),
                                new XElement("td", el.Element("MaNCC").Value)
                                                    )
                                        ) // End of table
                            ) // End of body
                            ); // End of html
            html.Save(pathHTML);
            Process.Start(pathHTML);
        }

        private void chuyểnĐổiSangHTMLToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            String pathItem = "NhaCungCap.xml";
            String pathHTML = "NhaCungCap.html";
            XDocument xItem = XDocument.Load(pathItem);

            var xI = xItem.Descendants("_x0027_NhaCungCap_x0027_");
            var html = new XElement("html", // Tạo cây HTML trong bộ nhớ
            new XElement("head",
                new XElement("style", "table{border:solid 1px red;border - collapse: collapse}", "td{border:solid 1px silver;}"// Hãy thêm nhiều style nữa ở đây.
                            )// End of style
                        ), // End of head
                new XElement("body",
                    new XElement("h2", "Danh sách"),
                        new XElement("table",
                            new XElement("tr",
                                new XElement("td", "MaNCC"),
                                new XElement("td", "TenNCC"),
                                new XElement("td", "DiaChi"),
                                new XElement("td", "SDT"),
                                new XElement("td", "Email")
                                        ), // End of tr of table header
                                from el in xI
                                select new XElement("tr",
                                new XElement("td", el.Element("MaNCC").Value),
                                new XElement("td", el.Element("TenNCC").Value),
                                new XElement("td", el.Element("DiaChi").Value),
                                new XElement("td", el.Element("SDT").Value),
                                new XElement("td", el.Element("Email").Value)
                                                    )
                                        ) // End of table
                            ) // End of body
                            ); // End of html
            html.Save(pathHTML);
            Process.Start(pathHTML);
        }

        private void chuyểnĐổiSangHTMLToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            String pathItem = "KhachHang.xml";
            String pathHTML = "KhachHang.html";
            XDocument xItem = XDocument.Load(pathItem);

            var xI = xItem.Descendants("_x0027_KhachHang_x0027_");
            var html = new XElement("html", // Tạo cây HTML trong bộ nhớ
            new XElement("head",
                new XElement("style", "table{border:solid 1px red;border - collapse: collapse}", "td{border:solid 1px silver;}"// Hãy thêm nhiều style nữa ở đây.
                            )// End of style
                        ), // End of head
                new XElement("body",
                    new XElement("h2", "Danh sách"),
                        new XElement("table",
                            new XElement("tr",
                                new XElement("td", "MaKH"),
                                new XElement("td", "TenKH"),
                                new XElement("td", "SDT"),
                                new XElement("td", "NgaySinh"),
                                new XElement("td", "DiaChi"),
                                new XElement("td", "Email")
                                        ), // End of tr of table header
                                from el in xI
                                select new XElement("tr",
                                new XElement("td", el.Element("MaKhachHang").Value),
                                new XElement("td", el.Element("TenKhachHang").Value),
                                new XElement("td", el.Element("SDT").Value),
                                new XElement("td", el.Element("NgaySinh").Value),
                                new XElement("td", el.Element("DiaChi").Value),
                                new XElement("td", el.Element("Email").Value)
                                                    )
                                        ) // End of table
                            ) // End of body
                            ); // End of html
            html.Save(pathHTML);
            Process.Start(pathHTML);
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.ShowDialog();
        }
    }
}
