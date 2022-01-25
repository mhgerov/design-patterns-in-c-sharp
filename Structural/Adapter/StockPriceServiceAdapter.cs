namespace design_patterns_in_c_sharp.Structural.Adapter;

public class StockPriceServiceAdapter
{
	private readonly ExternalStockService _stockService;

	public StockPriceServiceAdapter(ExternalStockService stockService)
	{
		_stockService = stockService;
	}

	public Dictionary<string, float> GetLatestStockPrices()
	{
		var prices = _stockService.GetLatestStockPrices();

		var pricesConverted = new Dictionary<string, float>();
		var splitStocks = prices.Split(",");
		foreach (var stockString in splitStocks)
		{
			var parsed = stockString.Split(":");
			pricesConverted.Add(parsed[0],float.Parse(parsed[1]));
		}

		return pricesConverted;
	}
}