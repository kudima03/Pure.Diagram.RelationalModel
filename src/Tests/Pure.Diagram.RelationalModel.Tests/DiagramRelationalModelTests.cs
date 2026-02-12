using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Diagram.RelationalModel.Tests;

public sealed record DiagramRelationalModelTests
{
    [Fact]
    public void InitializeIdCorrectly()
    {
        IGuid id = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            new RandomString(),
            new RandomString(),
            new Guid()
        );

        Assert.Equal(id.GuidValue, model.Id.GuidValue);
    }

    [Fact]
    public void InitializeTypeIdCorrectly()
    {
        IGuid id = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            new Guid(),
            new RandomString(),
            new RandomString(),
            id
        );

        Assert.Equal(id.GuidValue, model.TypeId.GuidValue);
    }

    [Fact]
    public void InitializeTitleCorrectly()
    {
        IString title = new RandomString();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            new Guid(),
            title,
            new RandomString(),
            new Guid()
        );

        Assert.Equal(title.TextValue, model.Title.TextValue);
    }

    [Fact]
    public void InitializeDescriptionCorrectly()
    {
        IString description = new RandomString();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            new Guid(),
            new RandomString(),
            description,
            new Guid()
        );

        Assert.Equal(description.TextValue, model.Description.TextValue);
    }
}
