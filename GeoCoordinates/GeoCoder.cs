using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GeoCoordinates
{
    public class GeoCoder
    {
        private static readonly string apiKey = "f0b05bf4-c297-4c8a-b050-f47d36d15342";

        public static async Task<Coordinates> GetCoordinatesAsync(string address)
        {
            // Запрос к API 2ГИС на прямое геокодирование
            string apiUrl = $"https://catalog.api.2gis.com/3.0/items/geocode?q={Uri.EscapeDataString(address)}&fields=items.point&key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode(); // Проверяем успешность ответа
                string jsonResponse = await response.Content.ReadAsStringAsync();

                // Парсинг JSON
                return ParseCoordinates(jsonResponse);
            }
        }

        private static Coordinates ParseCoordinates(string jsonResponse)
        {
            JObject json = JObject.Parse(jsonResponse);

            // Проверяем наличие данных и координат
            if (json["result"] != null && json["result"]["items"] != null && json["result"]["items"].HasValues)
            {

                // Получаем первую найденную геопозицию из списка
                var item = json["result"]["items"][0];

                // Извлекаем координаты из ответа
                var point = item["point"];
                if (point != null)
                {
                    double lat = (double)point["lat"];
                    double lon = (double)point["lon"];
                    return new Coordinates(lat, lon);
                }
            }

            return null; // Координаты не найдены
        }
    }
}
