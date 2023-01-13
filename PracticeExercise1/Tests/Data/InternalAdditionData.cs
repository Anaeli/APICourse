public class InternalAdditionData
{
    public static IEnumerable<object[]> AdditionData() // Internal Data
    {
        yield return new object[] { 1, 2, 3 };
        yield return new object[] { 5, -3, 2 };
        yield return new object[] { 0, 0, 0 };
    }
}
