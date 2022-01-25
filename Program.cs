using design_patterns_in_c_sharp.Structural.Adapter;

// Adapter
var adapter = new StockPriceServiceAdapter(new ExternalStockService());
var prices = adapter.GetLatestStockPrices();
Console.WriteLine(prices.GetValueOrDefault("KDY"));