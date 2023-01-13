using Xunit;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Jorge_HW1;

namespace JorgeTests;

public class UnitTest1
{
    [Fact]
    public void ValidateStrings()
    {
        // Variables
        var student1 = new Student()
        {
            ID = 1,
            Name = "Juan",
            LastName = "Perez",
            Age = 25,
            Married = false
        };

        // Assertions
        Assert.False(student1.Married);
        Assert.StartsWith("Ju", student1.Name);
        Assert.EndsWith("ez", student1.LastName);
        Assert.Contains("ua", student1.Name);
        Assert.DoesNotContain("er", student1.Name);
        Assert.Throws<ArgumentNullException>(() => student1.GetNickName());
    }

    [Fact]
    public void ValidateIntegers()
    {
        // Variables
        int num = 42;
        DateTime d1 = new(2020, 2, 20);
        DateTime d2 = new(2020, 2, 25);

        // Assertions
        Assert.True(num >= 42);
        Assert.True(num < 50);
        Assert.InRange(num, 40, 50);
        Assert.False(d1 == d2);
        Assert.Equal(d1, d2, TimeSpan.FromDays(8));
    }

    [Fact]
    public void ValidateLists()
    {
        //Variables
        Student student1 = new();
        student1.Name = "Ana";
        student1.LastName = "Martinez";
        Student student2 = student1;
        Student student3 = new();
        student3.Name = "Juan";
        student3.LastName = "Perez";
        student3.Age = 25;
        Student student4 = new();
        student4.Name = "Maria";
        student4.LastName = "Pepita";
        List<Student> studentList = new() { student1, student2, };
        List<Student> studentList1 = studentList;
        List<Student> studentList2 = new() { student1, };
        List<Student> studentList3 = new() { student1, student3, student4, };

        //Asserts
        Assert.Equal(studentList, studentList1);
        Assert.NotEqual(studentList, studentList2);
        Assert.Equal(2, studentList.Count);
        Assert.Equal(studentList3, studentList3.Distinct());
        Assert.NotEmpty(studentList3.Where(n => n.Name == "Juan" && n.LastName == "Perez"));
        Assert.NotEmpty(studentList3.Where(s => s.Age == 25));
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 4, 7)]
    [InlineData(-1, -2, -3)]
    public void InlineData(int a, int b, int expectedResult)
    {
        Assert.Equal(expectedResult, a + b);
    }

    public static IEnumerable<object[]> AdditionDataSet()
    {
        yield return new object[] { 20, 20, 40 };
        yield return new object[] { -2, -12, -14 };
        yield return new object[] { -20, 40, 20 };
    }

    [Theory]
    [MemberData(nameof(AdditionDataSet))]
    public void ItShouldReturnEqualsResultsWithInternalData(int a, int b, int expectedResult)
    {
        Assert.Equal(expectedResult, a + b);
    }

    public static IEnumerable<object[]> AdditionDataFromCsv()
    {
        var data = File.ReadAllLines(
                "/home/jorgech/Documents/API Testing/APICourse/JorgeTests/Data.csv"
            )
            .Select(x => x.Split(','))
            .Select(x => new object[] { int.Parse(x[0]), int.Parse(x[1]), int.Parse(x[2]) });

        return data;
    }

    [Theory]
    [MemberData("AdditionDataFromCsv")]
    public void TestAdditionFromCsv(int a, int b, int expectedResult)
    {
        // Assert
        Assert.Equal(expectedResult, a + b);
    }
}
