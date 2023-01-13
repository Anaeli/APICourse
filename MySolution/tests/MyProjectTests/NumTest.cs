namespace MyProjectTests;

using Xunit;
using System;

public class NumTest
{
    int num = 42;
    DateTime d1 = new(2020, 2, 20);
    DateTime d2 = new(2020, 2, 25);

    [Fact]
    public void ItShouldBeGreaterOrEqualto42()
    {
        Assert.True(num >= 42);
    }

    [Fact]
    public void ItShouldBeLessThan50()
    {
        Assert.True(num < 50);
    }

    [Fact]
    public void ItShouldBeBetween40and50()
    {
        Assert.InRange<int>(num, 40, 50);
    }

    [Fact]
    public void TheyShouldNotBeEqual()
    {
        Assert.NotEqual(d1, d2);
    }

    [Fact]
    public void TheyShouldBeEqualWithRange()
    {
        Assert.Equal(d1, d2, TimeSpan.FromDays(8));
    }
}