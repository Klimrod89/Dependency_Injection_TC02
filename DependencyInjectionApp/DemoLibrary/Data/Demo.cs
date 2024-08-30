namespace DemoLibrary.Data;

public class Demo : IDemo
{
    public DateTime StartupTime { get; init; }

    public Demo()
    {
        StartupTime = DateTime.Now;
    }
}
