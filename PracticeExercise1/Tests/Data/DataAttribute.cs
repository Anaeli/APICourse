using System.Reflection;
using Xunit.Sdk;

public class AdditionDataAttribute : DataAttribute // Data Attribute
{
    public override IEnumerable<object[]> GetData(MethodInfo testMethod)
    {
        yield return new object[] { 1, 2, 3 };
        yield return new object[] { 5, -3, 2 };
        yield return new object[] { 0, 0, 0 };
    }
}
