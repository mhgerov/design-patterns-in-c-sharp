namespace design_patterns_in_c_sharp.Structural.Composite;

public interface IArmyUnit
{
	public Dictionary<UnitType, int> GetUnitReport();
}