namespace Exercise.Test4;

using System.Reflection;
using Xunit.Sdk;

public class ExerciseTest4
{
    public int AddNumbers(int a, int b) => a + b;
    public static IEnumerable<object[]> InternalAdditionData() // Internal Data
    {
        yield return new object[] { 1, 2, 3 };
        yield return new object[] { 5, -3, 2 };
        yield return new object[] { 0, 0, 0 };
    }
    private static IEnumerable<object[]> GetTestData() // CSV file
    {
        string[] lines = File.ReadAllLines("../../../Tests/Data/AdditionData.csv");
        var testCases = new List<Object[]>();
        foreach (var line in lines)
        {
            IEnumerable<int> values = line.Split(',').Select(x => int.Parse(x)).ToArray();
            object[] testCase = values.Cast<object>().ToArray();
            testCases.Add(testCase);
        }
        return testCases;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(5, -3, 2)]
    [InlineData(0, 0, 0)]
    public void TestAddNumbersWithInlineData(int a, int b, int expected)
    {
        var result = AddNumbers(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(InternalAdditionData))]
    public void TestAddNumbersWithMemberDataInternal(int a, int b, int expected)
    {
        var result = AddNumbers(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(ExternalAdditionData.AdditionData), MemberType = typeof(ExternalAdditionData))]
    public void TestAddNumbersWithMemberDataExternal(int a, int b, int expected)
    {
        var result = AddNumbers(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [AdditionData]
    public void TestAddNumbersWithAdditionDataAttribute(int a, int b, int expected)
    {
        var result = AddNumbers(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void TestAddNumbersWithCsvData(int a, int b, int expected)
    {
        var result = AddNumbers(a, b);
        Assert.Equal(expected, result);
    }
}

public class AdditionDataAttribute : DataAttribute // Data Attribute
{
    public override IEnumerable<object[]> GetData(MethodInfo testMethod)
    {
        yield return new object[] { 1, 2, 3 };
        yield return new object[] { 5, -3, 2 };
        yield return new object[] { 0, 0, 0 };
    }
}
