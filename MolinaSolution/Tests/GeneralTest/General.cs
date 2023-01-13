using System;
using System.Collections.Generic;
using System.IO;
using CsvDataAttributeCustom;

namespace Tests.General;

public class GeneralTests
{
    private int num = 42;
    private DateTime d1 = new(2020, 2, 20);

    private DateTime d2 = new(2020, 2, 25);

    [Fact]
    public void TestNumIsGreaterOrEqualThan42()
    {
        Assert.True(num >= 42);
    }

    [Fact]
    public void TestNumIsLessThan50()
    {
        Assert.True(num < 50);
    }

    [Fact]
    public void TestNumIsBetween40and50()
    {
        Assert.True(num >= 40 && num <= 50);
    }

    [Fact]
    public void TestD1IsNotEqualsToD2()
    {
        Assert.True(d2.CompareTo(d1) != 0);
    }

    [Fact]
    public void TestD1IsEqualToD2In8DayRange()
    {
        Assert.True(d2.Subtract(d1).TotalDays <= 8);
    }

    //Inline data test
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 4, 6)]
    [InlineData(5, 25, 30)]
    public void TestInlineData(int input1, int input2, int result)
    {
        Assert.Equal(result, input1 + input2);
    }

    //Member data test
    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { 1, 2, 3 },
            new object[] { 2, 4, 6 },
            new object[] { 5, 25, 30 },
        };

    [Theory]
    [MemberData(nameof(Data))]
    public void TestAddMemberData(int input1, int input2, int result)
    {
        Assert.Equal(result, input1 + input2);
    }

    //CSV data test
    string csvpath = Path.GetFullPath(Environment.CurrentDirectory);

    [Theory]
    [CsvData("/home/sch/Documents/Github/API/Tests/testdata.csv")]
    public void TestCSVData(int input1, int input2, int result)
    {
        Assert.Equal(result, input1 + input2);
    }
}

//Fixtures

public class ClassFixture : IDisposable
{
    public String id { get; }

    public ClassFixture()
    {
        id = "Some id value";
    }

    public void Dispose() { }
}

public class FixtureTests : IClassFixture<ClassFixture>
{
    ClassFixture fixture;

    public FixtureTests(ClassFixture fixture)
    {
        this.fixture = fixture;
    }

    [Fact]
    public void TestIdValue()
    {
        Assert.Equal("Some id value", fixture.id);
    }
}
