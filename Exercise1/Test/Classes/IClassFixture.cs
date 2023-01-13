namespace IClassFix;
using Xunit;

public class Class1Fixture
{
    public int ID { get; set; }
}

public class IClassFixTest : IClassFixture<Class1Fixture>
{
    private readonly Class1Fixture class1;
    public IClassFixTest( Class1Fixture _class1)
    {
        class1 = _class1;
    }

    [Fact]
    [Trait("Category", "Class")]
    public void Test1()
    {
        class1.ID = 1;
    }
    [Fact]
    [Trait("Category", "Class")]
    public void Test2()
    {
        Assert.NotEqual(1, class1.ID);
    }
}