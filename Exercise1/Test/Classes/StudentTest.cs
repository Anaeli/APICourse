using Student;
namespace Student.Test;
public class StudentTest
{
    protected Student student1 = new Student() { ID = 1, Name = "Juan", LastName = "Perez", Age = 25, Married = false };

    [Fact]
    public void ShouldNotBeMarried()
    {
        Assert.False(student1.Married);
    }
    [Fact]
    public void NameShouldStartWith()
    {
        Assert.StartsWith("Ju", student1.Name);
    }
    [Fact]
    public void NameShouldEndWith()
    {
        Assert.EndsWith("ez", student1.LastName);
    }
    [Fact]
    public void NameShouldContain()
    {
        Assert.Contains("ua", student1.Name);
    }
    [Fact]
    public void NameShouldNotContain()
    {
        Assert.DoesNotContain("er", student1.Name);
    }
    [Fact]
    public void NickNameShouldThrowNullException()
    {
        Assert.Throws<ArgumentNullException>(() => student1.GetNickName());
    }
}
