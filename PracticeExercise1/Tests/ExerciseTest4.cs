namespace Exercise.Test4;

public class ExerciseTest4
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(5, -3, 2)]
    [InlineData(0, 0, 0)]
    public void TestAddNumbersWithInlineData(int a, int b, int expected)
    {
        var result = HelperFunctions.AddNumbers(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(InternalAdditionData.AdditionData), MemberType = typeof(InternalAdditionData))]
    public void TestAddNumbersWithMemberDataInternal(int a, int b, int expected)
    {
        var result = HelperFunctions.AddNumbers(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(ExternalAdditionData.AdditionData), MemberType = typeof(ExternalAdditionData))]
    public void TestAddNumbersWithMemberDataExternal(int a, int b, int expected)
    {
        var result = HelperFunctions.AddNumbers(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [AdditionData]
    public void TestAddNumbersWithAdditionDataAttribute(int a, int b, int expected)
    {
        var result = HelperFunctions.AddNumbers(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(HelperFunctions.GetTestData), MemberType = typeof(HelperFunctions))]
    public void TestAddNumbersWithCsvData(int a, int b, int expected)
    {
        var result = HelperFunctions.AddNumbers(a, b);
        Assert.Equal(expected, result);
    }
}
