using GMap.NET.MapProviders;
using GMap.NET;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GMap.NET.WindowsPresentation;

namespace GeoCoordinates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gMap.MapProvider = GMapProviders.OpenStreetMap; // Или любой другой провайдер (Яндекс Карты не работают)
            gMap.MinZoom = 2;
            gMap.MaxZoom = 24;
            gMap.Position = new PointLatLng(55.75, 37.62);
        }

        private async void btGetCoord_Click(object sender, RoutedEventArgs e)
        {
            string address = tbAdress.Text.Trim();

            if (string.IsNullOrEmpty(address))
            {
                lbGeoCoord.Content = "Пожалуйста, введите адрес.";
                return;
            }

            try
            {
                // Запускаем асинхронную операцию получения координат
                var coordinates = await GeoCoder.GetCoordinatesAsync(address);

                // Выводим результат в текстовый блок
                if (coordinates != null)
                {
                    lbGeoCoord.Content = coordinates.ToString();

                    gMap.Position = new PointLatLng(coordinates.Lat, coordinates.Lon); //Центрируем карту
                    gMap.Zoom = 15; // Устанавливаем масштаб
                }
                else
                {
                    lbGeoCoord.Content = "Не удалось получить координаты. Проверьте адрес или API ключ.";
                }
            }
            catch (Exception ex)
            {
                lbGeoCoord.Content = $"Ошибка: {ex.Message}";
            }
        }
    }
}