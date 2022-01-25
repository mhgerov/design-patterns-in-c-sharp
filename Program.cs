using design_patterns_in_c_sharp.Structural.Adapter;
using design_patterns_in_c_sharp.Structural.Bridge;

// Adapter
var adapter = new StockPriceServiceAdapter(new ExternalStockService());
var prices = adapter.GetLatestStockPrices();
Console.WriteLine(prices.GetValueOrDefault("KDY"));

// Bridge
// Is basic interface/implementation separation

IRemoteControl remote = new SamsungRemoteControl(new SamsungTV());
remote.SetChannel(66);