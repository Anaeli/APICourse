namespace MyProjectTests;

using Xunit;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using CsvData;
using System.Linq;

public class AddTest
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    [Theory]
    [InlineData(4, 5, 9)]
    [InlineData(-4, -3, -7)]
    [InlineData(0, 0, 0)]
    public void ItShouldReturnEqualsResultsWithInlineData(int x, int y, int expected)
    {
        int result = Add(x, y);
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> Data =>
    new List<object[]>
    {
        new object[] { 1, 2, 3 },
        new object[] { -4, -6, -10 },
        new object[] { 0, 0, 0 },
    };

    [Theory]
    [MemberData(nameof(Data))]
    public void ItShouldReturnEqualsResultsWithInternalData(int x, int y, int expected)
    {
        int result = Add(x, y);
        Assert.Equal(expected, result);
    }


    [Theory]
    [CsvDataAttribute("/Users/joaco/Desktop/Henry/Jalasoft/APICourse/MySolution/tests/MyProjectTests/Data.csv")]
    public void ItShouldReturnEqualsResultsWithExternalData(int x, int y, int expected)
    {
        int result = Add(x, y);
        Assert.Equal(expected, result); 
    }
}