using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ShopPhone.Class
{
    class ChiTietHoaDon
    {
        FileXml Fxml = new FileXml();
        public bool kiemtra(int SoHD)
        {
            XmlTextReader reader = new XmlTextReader("ChiTietHoaDon.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/_x0027_ChiTietHoaDon_x0027_[SoHoaDon='" + SoHD + "']");
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
    }
}
