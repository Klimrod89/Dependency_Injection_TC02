﻿namespace DemoLibrary.Data;

public class UtcDemo: IDemo
{
     public DateTime StartupTime { get; init; }

    public UtcDemo()
    {
        StartupTime = DateTime.UtcNow;
    }
}
