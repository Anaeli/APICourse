namespace Exercise.Test5;

[Collection("ID guide")]
public class Class1Tests
{
    private readonly FixtureClass _fixture;

    public Class1Tests(FixtureClass fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void TestMethod1()
    {
        _fixture.ID = 2;
    }
}

[Collection("ID guide")]
public class Class2Tests
{
    private readonly FixtureClass _fixture;

    public Class2Tests(FixtureClass fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void TestMethod2()
    {
        Assert.Equal(2, _fixture.ID);
    }
}
