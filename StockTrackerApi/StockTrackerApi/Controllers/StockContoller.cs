using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockTrackerApi.Data;
using StockTrackerApi.Models;
using StockTrackerApi.Services;

namespace StockTrackerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {
        private readonly StockService _stockService;
        private readonly AppDbContext _context;

        public StockController(StockService stockService, AppDbContext context)
        {
            _stockService = stockService;
            _context = context;
        }

        [HttpGet("{symbol}")]//veri çekilen yer
        public async Task<IActionResult> Get(string symbol)
        {
            var data = await _stockService.GetStockPrice(symbol);
            return Ok(data);
        }
        [HttpGet("change/{symbol}")]// veri farkı hesaplama
        public async Task<IActionResult> GetChange(string symbol)
        {
            var data = await _stockService.GetStockPrice(symbol);
            var change = data.c - data.pc;
            var percentage = (change / data.pc) * 100;

            return Ok(new
            {
                symbol = symbol,
                currentPrice = data.c,
                previousClose = data.pc,
                change = change,
                percentage = percentage
            });
        }
        [HttpPost("{symbol}")]// veri kaydetme
        public async Task<IActionResult> SaveStock(string symbol)
        {
            var data = await _stockService.GetStockPrice(symbol);

            var stock = new StockPrice
            {
                Symbol = symbol,
                CurrentPrice = data.c,
                HighPrice = data.h,
                LowPrice = data.l,
                OpenPrice = data.o,
                PreviousClosePrice = data.pc,
                CreatedAt = DateTime.Now
            };

            _context.StockPrices.Add(stock);
            await _context.SaveChangesAsync();
            return Ok(stock);
        }

        [HttpGet("history")]// veri kayıtlarını listeleme
        public async Task<IActionResult> GetHistory()
        {
            var data = await _context.StockPrices
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();
            return Ok(data);
        }
    }
}