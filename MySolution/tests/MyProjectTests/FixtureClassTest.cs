namespace FixtureTest;

using Fixture;
using Xunit;

public class FixtureClassTest : IClassFixture<FixtureClass>
{
    FixtureClass fixture;

    public FixtureClassTest(FixtureClass fixture)
    {
        this.fixture = fixture;
    }

    [Fact]
    public void ItShouldShareIdAttribute()
    {
        Assert.Equal(1, fixture.Id);
    }
}