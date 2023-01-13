public class HelperFunctions
{
    public static int AddNumbers(int a, int b) => a + b;
    
    public static IEnumerable<object[]> GetTestData() // CSV file
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
}
