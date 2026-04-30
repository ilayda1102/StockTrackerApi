namespace StockTrackerApi.Models
{
    public class StockPrice// stokları bilgilerini tutan kısım
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public decimal CurrentPrice { get; set; }
        public decimal HighPrice { get; set; }
        public decimal LowPrice { get; set; }
        public decimal OpenPrice { get; set; }
        public decimal PreviousClosePrice { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
