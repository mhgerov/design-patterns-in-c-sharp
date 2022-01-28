namespace design_patterns_in_c_sharp.Structural.Composite;

public class TankBattalion : IArmyUnit
{
	
	private readonly Dictionary<UnitType, int> _units = new Dictionary<UnitType, int>()
	{
		{ UnitType.Tank , 100}
	};
	
	public Dictionary<UnitType, int> GetUnitReport() => _units;
}