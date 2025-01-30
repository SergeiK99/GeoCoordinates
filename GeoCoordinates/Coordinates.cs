using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace GeoCoordinates
{
    public class Coordinates
    {
        // Широта
        public double Lat { get; set; }
        // Долгота
        public double Lon { get; set; }

        // Конструктор класса
        public Coordinates(double lat, double lon) 
        {
            Lat = lat;
            Lon = lon;
        }

        // Переопределяем метод ToString() для удобного вывода координат
        public override string ToString()
        {
            return $"Широта: {Lat}, Долгота: {Lon}";
        }
    }
}
