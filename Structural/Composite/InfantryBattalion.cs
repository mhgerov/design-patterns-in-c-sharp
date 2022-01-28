namespace design_patterns_in_c_sharp.Structural.Composite;

public class InfantryBattalion : IArmyUnit
{
	private readonly Dictionary<UnitType, int> _units = new()
	{
		{ UnitType.Soldier , 600}
	};

	public Dictionary<UnitType, int> GetUnitReport() => _units;
}