using Models;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests.Models;

public class StudentTestsPart1
{
    private Student student1 = new Student()
    {
        ID = 1,
        Name = "Juan",
        LastName = "Perez",
        Age = 25,
        Married = false
    };

    [Fact]
    public void TestJuanIsNotMarried()
    {
        Assert.False(student1.Married);
    }

    [Fact]
    public void TestStudent1NameStartsWithJu()
    {
        Assert.StartsWith("Ju", student1.Name);
    }

    [Fact]
    public void TestStudent1LastNameEndsWithEz()
    {
        Assert.EndsWith("ez", student1.LastName);
    }

    [Fact]
    public void TestStudent1NameContainsUa()
    {
        Assert.Contains("ua", student1.Name);
    }

    [Fact]
    public void TestStudent1NameDoesNotContainsEr()
    {
        Assert.DoesNotContain("er", student1.Name);
    }

    [Fact]
    public void TestStudent1ThrowsNullException()
    {
        Assert.Throws<ArgumentNullException>(() => student1.GetNickName());
    }
}

public class StudentTestsPart2
{
    [Fact]
    public void Tests()
    {
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

        Assert.Equal(studentList1, studentList);
        Assert.NotEqual(studentList2, studentList);
        Assert.Equal(2, studentList.Count);
        Assert.True(studentList3.Distinct().Count() == studentList3.Count);
        Assert.Contains(studentList3, x => x.FullName.Equals("Juan Perez"));
        Assert.Contains(studentList3, x => x.Age == 25);
    }
}
