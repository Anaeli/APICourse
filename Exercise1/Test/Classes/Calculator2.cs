using Xunit.Sdk;
using System.Reflection;
namespace Calculator2;

internal class AdditionDataAttribute : DataAttribute
{
    public override IEnumerable<object[]> GetData(MethodInfo testMethod)
    {
        yield return new object[] { 1, 2, 3 };
        yield return new object[] { -1, 2, 1 };
        yield return new object[] { 0, 0, 0 };
    }
}
public class Calculator2
{
    public int Add(int x, int y)
    {
        return x + y;
    }
}
public class CalculatorTests
{
    [Theory(DisplayName = "Data driven - DataAttribute")]
    [AdditionDataAttribute]
    public void TestAdditionDataDriven(int num1, int num2, int expected)
    {
        Calculator2 addition = new();
        int actualResult = addition.Add(num1, num2);
        Assert.Equal(expected, actualResult);
    }

}
