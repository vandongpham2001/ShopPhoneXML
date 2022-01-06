using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ShopPhone.Class
{
    class NhanVien
    {
        FileXml Fxml = new FileXml();
        public bool kiemtra(string MaNhanVien)
        {
            XmlTextReader reader = new XmlTextReader("NhanVien.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/NhanVien[MaNhanVien='" + MaNhanVien + "']");
            reader.Close();
            bool kq = true;
            if (node != null)
            {
                return kq;
            }
            else
            {
                kq= false;
                return kq;
            }

        }
        public void themNV(string MaNhanVien, string TenNhanVien, string NgaySinh, string SDT, string Email, string GioiTinh)
        {
            string noiDung = "<_x0027_NhanVien_x0027_>" +
                    "<MaNhanVien>" + MaNhanVien + "</MaNhanVien>" +
                    "<TenNhanVien>" + TenNhanVien + "</TenNhanVien>" +
                    "<NgaySinh>" + NgaySinh + "</NgaySinh>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<Email>" + Email + "</Email>" +
                    "<GioiTinh>" + GioiTinh + "</GioiTinh>" +
                    "</_x0027_NhanVien_x0027_>";
            Fxml.Them("NhanVien.xml", noiDung);
        }
        public void suaNV(string MaNhanVien, string TenNhanVien, string NgaySinh, string SDT, string Email, string GioiTinh)
        {

            string noiDung = "<MaNhanVien>" + MaNhanVien + "</MaNhanVien>" +
                    "<TenNhanVien>" + TenNhanVien + "</TenNhanVien>" +
                    "<NgaySinh>" + NgaySinh + "</NgaySinh>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<Email>" + Email + "</Email>"+
                    "<GioiTinh>" + GioiTinh + "</GioiTinh>";

            Fxml.Sua("NhanVien.xml", "NhanVien", "MaNhanVien", MaNhanVien, noiDung);


        }
        public void xoaNV(string MaNhanVien)
        {
            Fxml.Xoa("NhanVien.xml", "NhanVien", "MaNhanVien", MaNhanVien);
        }       
    }
}
