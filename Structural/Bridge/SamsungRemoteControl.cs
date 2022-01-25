namespace design_patterns_in_c_sharp.Structural.Bridge;

public class SamsungRemoteControl : IRemoteControl
{
	private SamsungTV _tv;

	public SamsungRemoteControl(SamsungTV tv)
	{
		_tv = tv;
	}
	public bool IsEnabled() => _tv.Enabled;

	public void Enable() => _tv.Enabled = true;

	public void Disable() => _tv.Enabled = false;

	public int GetVolume() => _tv.Volume;

	public void SetVolume(int volume)
	{
		if (volume < 0 || volume > 100)
		{
			throw new Exception("Invalid Number");
		}

		_tv.Volume = volume;
	}

	public int GetChannel() => _tv.Channel;

	public void SetChannel(int channel) => _tv.Channel = channel;
}