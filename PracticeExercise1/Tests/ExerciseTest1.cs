namespace Exercise.Test1;

public class ExerciseTest1
{
    private readonly Student student1 = new Student() { ID = 1, Name = "Juan",  LastName = "Perez", Age = 25, Married = false } ;

    [Fact]
    public void ValidateIsNotMarried()
    {
        Assert.False(student1.Married, "Error: User is married");
    }

    [Fact]
    public void ValidateNameStartsWithJu()
    {
        Assert.StartsWith("Ju", student1.Name);
    }

    [Fact]
    public void ValidateLastNameEndsWithEz()
    {
        Assert.EndsWith("ez", student1.LastName);
    }

    [Fact]
    public void ValidateNameContainsUa()
    {
        Assert.Contains("ua", student1.Name);
    }

    [Fact]
    public void ValidateNameDoesNotContainEr()
    {
        Assert.DoesNotContain("er", student1.Name);
    }

    [Fact]
    public void ValidateNicknameThrowsArgumentNullException()
    {
        student1.NickName = null;

        Assert.Throws<ArgumentNullException>(() => student1.GetNickName());
    }

}
