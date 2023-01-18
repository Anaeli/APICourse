namespace Calculator;
using System;
using System.Reflection;
using Xunit;
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

public class ExternalDataProvider
{
    public static IEnumerable<object[]> ExternalAdditionData()
    {
        yield return new object[] { 1, 2, 3 };
        yield return new object[] { 4, 5, 9 };
        yield return new object[] { -2, 3, 1 };
    }
}
public class CalculatorTests
{
    public static TheoryData<int, int, int> InternalAdditionData()
    {
        return new TheoryData<int, int, int>
        {
            {3, 4, 7},
            {-3, -4, -7},
            {0, 0, 0},
            {5, 7, 12},
            {-5, -7, -12},
            {5, 0, 5}
        };
    }
    [Theory]
    [InlineData(3, 4, 7)]
    [InlineData(-3, -4, -7)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, 8, 3)]
    [InlineData(3, 0, 3)]
    [InlineData(-23, 0, -23)]
    public void UsingOnlyInlineData(int num1, int num2, int expectedSum)
    {
        var calculator = new Calculator();
        var actualSum = calculator.Add(num1, num2);
        Assert.Equal(expectedSum, actualSum);
    }

    [Theory]
    [MemberData(nameof(InternalAdditionData))]
    public void UsingMemberData(int num1, int num2, int expectedSum)
    {
        var calculator = new Calculator();
        var actualSum = calculator.Add(num1, num2);
        Assert.Equal(expectedSum, actualSum);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(0, 1, 1)]
    [MemberData(nameof(InternalAdditionData))]
    public void UsingInlineDataAndMemberDataTogether(int num1, int num2, int expectedSum)
    {
        var calculator = new Calculator();
        var actualSum = calculator.Add(num1, num2);
        Assert.Equal(expectedSum, actualSum);
    }

    [Theory]
    [MemberData(nameof(ExternalDataProvider.ExternalAdditionData), MemberType = typeof(ExternalDataProvider))]
    public void Test_Addition(int x, int y, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(x, y);
        Assert.Equal(expected, result);
    }
}

