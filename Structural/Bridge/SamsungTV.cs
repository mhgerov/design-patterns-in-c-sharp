namespace design_patterns_in_c_sharp.Structural.Bridge;

public class SamsungTV : TV
{
	public bool Enabled { get; set; }
	public int Volume { get; set; } = 50;
	public int Channel { get; set; } = 1;
}