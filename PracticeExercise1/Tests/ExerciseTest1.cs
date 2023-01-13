namespace Exercise.Test1;

public class ExerciseTest1
{
    private readonly Student student1 = new Student() { ID = 1, Name = "Juan",  LastName = "Perez", Age = 25, Married = false } ;

    [Fact]
    public void IsNotMarried()
    {
        Assert.False(student1.Married);
    }

    [Fact]
    public void NameStartsWithJu()
    {
        Assert.StartsWith("Ju", student1.Name);
    }

    [Fact]
    public void LastNameEndsWithEz()
    {
        Assert.EndsWith("ez", student1.LastName);
    }

    [Fact]
    public void NameContainsUa()
    {
        Assert.Contains("ua", student1.Name);
    }

    [Fact]
    public void NameDoesNotContainEr()
    {
        Assert.DoesNotContain("er", student1.Name);
    }

    [Fact]
    public void NicknameThrowsArgumentNullException()
    {
        student1.NickName = null;

        Assert.Throws<ArgumentNullException>(() => student1.GetNickName());
    }

}
