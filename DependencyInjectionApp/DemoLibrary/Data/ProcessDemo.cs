using System.Security.Cryptography;

namespace DemoLibrary.Data;

public class ProcessDemo : IProcessDemo
{
    private readonly IDemo demo;

    public ProcessDemo(IDemo demo)
    {
        this.demo = demo;
    }

    public int GetDaysInMonth()
    {
        return demo.StartupTime.Month switch
        {
            1 => 31,
            2 => (DateTime.IsLeapYear(demo.StartupTime.Year) ? 29 : 28),
            3 => 31,
            4 => 30,
            5 => 31,
            6 => 30,
            7 => 31,
            8 => 31,
            9 => 30,
            10 => 31,
            11 => 30,
            12 => 31,
            _ => throw new IndexOutOfRangeException()
        };
    }
}
