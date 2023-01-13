public class ExternalAdditionData
{
    public static IEnumerable<object[]> AdditionData()
    {
        yield return new object[] { 1, 2, 3 };
        yield return new object[] { 5, -3, 2 };
        yield return new object[] { 0, 0, 0 };
    }
}
