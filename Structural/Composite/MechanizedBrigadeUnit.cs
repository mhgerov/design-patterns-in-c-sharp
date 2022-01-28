namespace design_patterns_in_c_sharp.Structural.Composite;

public class MechanizedBrigadeUnit : IArmyUnit
{
	private readonly List<IArmyUnit> _subordinateUnits = new()
	{
		new InfantryBattalion(),
		new InfantryBattalion(),
		new InfantryBattalion(),
		new TankBattalion()
	};

	public Dictionary<UnitType, int> GetUnitReport()
	{
		var strength = new Dictionary<UnitType, int>();
		foreach (var unit in _subordinateUnits)
		{
			var unitStrength = unit.GetUnitReport();
			foreach (var unitType in unitStrength.Keys)
			{
				try
				{
					strength[unitType] += unitStrength[unitType];
				}
				catch (KeyNotFoundException e)
				{
					strength[unitType] = unitStrength[unitType];
				}
			}
		}

		return strength;
	}
}