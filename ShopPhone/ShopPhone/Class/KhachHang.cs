using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ShopPhone.Class
{
    class KhachHang
    {
        FileXml Fxml = new FileXml();
        public bool kiemtra(string MaKhachHang)
        {
            XmlTextReader reader = new XmlTextReader("KhachHang.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/_x0027_KhachHang_x0027_[MaKhachHang='" + MaKhachHang + "']");
            reader.Close();
            bool kq = true;
            if (node != null)
            {
                return kq;
            }
            else
            {
                kq = false;
                return kq;
            }

        }
        public void themKH(string MaKhachHang, string TenKhachHang, string SDT, string NgaySinh, string DiaChi, string Email)
        {
            string noiDung = "<_x0027_KhachHang_x0027_>" +
                    "<MaKhachHang>" + MaKhachHang + "</MaKhachHang>" +
                    "<TenKhachHang>" + TenKhachHang + "</TenKhachHang>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<NgaySinh>" + NgaySinh + "</NgaySinh>" +
                    "<DiaChi>" + DiaChi + "</DiaChi>" +
                    "<Email>" + Email + "</Email>" +
                    "</_x0027_KhachHang_x0027_>";
            Fxml.Them("KhachHang.xml", noiDung);
        }
        public void suaKH(string MaKhachHang, string TenKhachHang, string SDT, string NgaySinh, string DiaChi, string Email)
        {

            string noiDung = "<MaKhachHang>" + MaKhachHang + "</MaKhachHang>" +
                    "<TenKhachHang>" + TenKhachHang + "</TenKhachHang>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<NgaySinh>" + NgaySinh + "</NgaySinh>" +
                    "<DiaChi>" + DiaChi + "</DiaChi>" +
                    "<Email>" + Email + "</Email>";

            Fxml.Sua("KhachHang.xml", "_x0027_KhachHang_x0027_", "MaKhachHang", MaKhachHang, noiDung);


        }
        public void xoaKH(string MaKhachHang)
        {
            Fxml.Xoa("KhachHang.xml", "KhachHang", "MaKhachHang", MaKhachHang);
        }

        public DataTable LoadMaKH()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("KhachHang.xml");
            return dt;
        }
    }
}
