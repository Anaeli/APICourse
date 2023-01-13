[Collection("ID guide")]
public class FixtureClass
{
    public int ID { get; set; }

    public FixtureClass()
    {
        ID = 1;
    }
}

[CollectionDefinition("ID guide")]
public class CollectionClass : ICollectionFixture<FixtureClass> { }
