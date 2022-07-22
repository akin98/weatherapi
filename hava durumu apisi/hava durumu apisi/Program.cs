using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq; //xml kütüphanesini  tanımladık
namespace hava_durumu_apisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string api = "c08a224d877e38c4825dbfee9c489cd6";//hava durumu sitesinden aldığımız key bu site key olarak veriyo normalda referans
            string baglan = "https://api.openweathermap.org/data/2.5/weather?q=%C4%B0zmir&mode=xml&lang=tr&units=metric&appid=" + api; // hocanın attığı bağlantı linki
            XDocument hava=XDocument.Load(baglan); //xml olduğu için bunu ekledik
            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;//var bilinmeyen değişkenler için kullanılır
            Console.WriteLine("izmir hava durumu" + sicaklik);
            Console.Read();
        }
    }
}
