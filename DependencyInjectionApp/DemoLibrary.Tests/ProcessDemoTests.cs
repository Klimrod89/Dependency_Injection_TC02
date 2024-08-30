using System.Xml.Serialization;
using DemoLibrary.Data;

namespace DemoLibrary.Tests;

public class ProcessDemoTests
{
    [Fact]
    public void GetDaysInMonth_ShouldReturnProperNumberForLeapYears()
    {
        // Arrange
        TestingDemo t = new(DateTime.Parse("2/1/2000"));
        ProcessDemo sut = CreateProcessDemo(t);
        int expected = 29;
        // Act
        int actual = sut.GetDaysInMonth();
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]

    public void GetDaysInMonth_ShouldReturnProperNumberForNonLeapYears()
    {
        // Arrange
        TestingDemo t = new(DateTime.Parse("2/1/2001"));
        ProcessDemo sut = CreateProcessDemo(t);
        int expected = 28;
        // Act
        int actual = sut.GetDaysInMonth();
        // Assert
        Assert.Equal(expected, actual);
    }

    private static ProcessDemo CreateProcessDemo(IDemo demo) => new(demo);
}

public class TestingDemo : IDemo
{
    public DateTime StartupTime {get; init;}
    public TestingDemo(DateTime startTime)
    {
        StartupTime = startTime;
    }
}