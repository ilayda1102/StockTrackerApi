using System.Text.Json;

namespace StockTrackerApi.Services
{
    //API çağrılarını ayrı bir sınıfa koydum bu sayede görünmesi daha kolay oldu
    public class StockService
    {
        private readonly HttpClient _httpClient;

        public StockService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<StockResponse> GetStockPrice(string symbol)
        {
            var apiKey = "d7pg0fpr01qlb0a9rrk0d7pg0fpr01qlb0a9rrkg";// API KEY giriş

            var url = $"https://finnhub.io/api/v1/quote?symbol={symbol}&token={apiKey}";

            var response = await _httpClient.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();

            Console.WriteLine(json);

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Finnhub API error: {response.StatusCode} - {json}");

            var data = JsonSerializer.Deserialize<StockResponse>(json);

            if (data == null)
                throw new Exception("API veri döndürmedi.");

            return data;
        }
    }
    public class StockResponse
    {
        public decimal c { get; set; }  // şuan
        public decimal h { get; set; }  // max
        public decimal l { get; set; }  // min
        public decimal o { get; set; }  // açıkken
        public decimal pc { get; set; } // kapalıyken
    }
}