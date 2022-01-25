namespace design_patterns_in_c_sharp.Structural.Bridge;

public interface IRemoteControl
{
	public bool IsEnabled();
	public void Enable();
	public void Disable();
	public int GetVolume();
	public void SetVolume(int volume);
	public int GetChannel();
	public void SetChannel(int channel);
}