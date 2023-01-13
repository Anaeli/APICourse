using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace csv;

public class ExternalAdditionData
{
    public static IEnumerable<object[]> TestData
    {
        get
        {
            string[] csvLines = File.ReadAllLines("../../../CSV/calculatorTest.csv");
            var testCases = new List<Object[]>();
            foreach (var csvLine in csvLines)
            {
                IEnumerable<int> values = csvLine.Split(',').Select(x => int.Parse(x)).ToArray();
                object[] testCase = values.Cast<object>().ToArray();
                testCases.Add(testCase);
            }
            return testCases;
        }
    }
}
