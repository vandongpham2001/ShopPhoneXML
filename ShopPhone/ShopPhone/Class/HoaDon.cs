using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ShopPhone.Class
{
    class HoaDon
    {
        FileXml Fxml = new FileXml();
        public bool kiemtra(int SoHD)
        {
            XmlTextReader reader = new XmlTextReader("HoaDon.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/_x0027_HoaDon_x0027_[SoHoaDon='" + SoHD + "']");
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
        public void themHD(int SoHoaDon, string MaKhachHang, string MaNhanVien, string DiaChi, string SDT, string TrangThai)
        {
            string today=DateTime.Now.ToString("yyyy-MM-dd");
            string noiDung = "<_x0027_HoaDon_x0027_>" +
                    "<SoHoaDon>" + SoHoaDon + "</SoHoaDon>" +
                    "<MaKhachHang>" + MaKhachHang + "</MaKhachHang>" +
                    "<MaNhanVien>" + MaNhanVien + "</MaNhanVien>" +
                    "<diaChi>" + DiaChi + "</diaChi>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<TrangThai>" + TrangThai + "</TrangThai>" +
                    "<ngayTao>" + today + "</ngayTao>" +
                    "</_x0027_HoaDon_x0027_>";
            Fxml.Them("HoaDon.xml", noiDung);
        }
        public void suaHD(int SoHoaDon, string MaKhachHang, string MaNhanVien, string DiaChi, string SDT, string TrangThai)
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string noiDung = "<SoHoaDon>" + SoHoaDon + "</SoHoaDon>" +
                    "<MaKhachHang>" + MaKhachHang + "</MaKhachHang>" +
                    "<MaNhanVien>" + MaNhanVien + "</MaNhanVien>" +
                    "<diaChi>" + DiaChi + "</diaChi>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<TrangThai>" + TrangThai + "</TrangThai>" +
                    "<ngayTao>" + today + "</ngayTao>";

            Fxml.Sua("HoaDon.xml", "_x0027_HoaDon_x0027_", "SoHoaDon", SoHoaDon.ToString(), noiDung);
        }

        public DataTable LoadSoHD()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("HoaDon.xml");
            return dt;
        }
    }
}
