using design_patterns_in_c_sharp.Structural.Adapter;
using design_patterns_in_c_sharp.Structural.Bridge;
using design_patterns_in_c_sharp.Structural.Composite;

// Adapter
var adapter = new StockPriceServiceAdapter(new ExternalStockService());
var prices = adapter.GetLatestStockPrices();
Console.WriteLine(prices.GetValueOrDefault("KDY"));

// Bridge
// Is basic interface/implementation separation
IRemoteControl remote = new SamsungRemoteControl(new SamsungTV());
remote.SetChannel(66);

// Composite
// Good for recursive tree-style hierarchies
var brigade = new MechanizedBrigadeUnit();
var unitReport = brigade.GetUnitReport();
foreach (var type in unitReport)
{
	Console.WriteLine(type.Key+": "+type.Value);
}