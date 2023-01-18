namespace csv.test;
using Xunit;
using Calculator;

public class CsvTest
{
    [Theory(DisplayName = "Data driven - ExternalAdditionData")]
    [MemberData(nameof(ExternalAdditionData.TestData), MemberType = typeof(ExternalAdditionData))]
    public void TestExternalAdditionData(int num1, int num2, int expected)
    {
        Calculator addition = new Calculator();
        int actualResult = addition.Add(num1, num2);
        Assert.Equal(expected, actualResult);
    }
}