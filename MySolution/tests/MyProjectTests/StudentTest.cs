namespace MyProjectTests;

using Xunit;
using System;
using Student;

public class StudentTest
{
    Student student1 = new Student() { ID = 1, Name = "Juan",  LastName = "Perez", Age = 25, Married = false } ;

    [Fact]
    public void ItShouldNotBeMarried()
    {
        Assert.False(student1.Married);
    }

    [Fact]
    public void ItShouldBeTrue()
    {
        Assert.StartsWith("Ju", student1.Name);
        Assert.EndsWith("ez", student1.LastName);
    }

    [Fact]
    public void ItShouldContainTheSpecifiedLetters()
    {
        Assert.Contains("ua", student1.Name);
    }

    [Fact]
    public void ItShouldNotContainTheSpecifiedLetters()
    {
        Assert.DoesNotContain("er", student1.Name);
    }

    [Fact]
    public void ItShouldThrowAnExceptionIfNicknameIsNull()
    {
        Assert.Null(student1.NickName);
        Assert.Throws<ArgumentNullException>(() => student1.GetNickName());
    }

    [Fact]
    public void ItShouldReturnTheNickname()
    {
        student1.NickName = "Juancito";
        Assert.Equal("Juancito", student1.GetNickName());
    }

    [Fact]
    public void ItShouldReturnFullName()
    {
        string fullName = student1.FullName;
        Assert.Equal("Juan Perez", fullName);
    }
}