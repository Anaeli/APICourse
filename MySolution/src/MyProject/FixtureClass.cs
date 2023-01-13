namespace Fixture;

public class FixtureClass : IDisposable
{
    public int Id { get; set; }

    public FixtureClass()
    {
        Id = 1;
    }

    public void Dispose() { }
}
