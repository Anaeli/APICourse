namespace NumbersAndDates.Test;

public class NumbersAndDatesTest
{
    private readonly int num = 42;
    private readonly DateTime d1 = new(2020, 2, 20);
    private readonly DateTime d2 = new DateTime(2020, 2, 25);

    [Fact]
    public void NumberShouldBeGreaterOrEqualTo42()
    {
        Assert.True(num >= 42);
    }
    [Fact]
    public void NumberShouldBeLessThan50()
    {
        Assert.True(num < 50);
    }
    [Fact]
    public void NumberShouldBeBetween40And50()
    {
        Assert.True(num >= 40);
        Assert.True(num <= 50);
    }
    [Fact]
    public void BothDatesShouldNotBeEqual()
    {
        Assert.NotEqual(d1, d2);
    }
    [Fact]
    public void BothDatesShouldBeInARangeOf8Days()
    {
        TimeSpan difference = d2 - d1;
        Assert.True(difference.TotalDays <= 8);
    }
}
