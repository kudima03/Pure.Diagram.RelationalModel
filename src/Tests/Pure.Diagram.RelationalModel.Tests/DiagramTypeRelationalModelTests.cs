using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Diagram.RelationalModel.Tests;

public sealed record DiagramTypeRelationalModelTests
{
    [Fact]
    public void InitializeIdCorrectly()
    {
        IGuid id = new Guid();

        IDiagramTypeRelationalModel model = new DiagramTypeRelationalModel(
            id,
            new RandomString()
        );

        Assert.Equal(id.GuidValue, model.Id.GuidValue);
    }

    [Fact]
    public void InitializeNameCorrectly()
    {
        IString name = new RandomString();

        IDiagramTypeRelationalModel model = new DiagramTypeRelationalModel(
            new Guid(),
            name
        );

        Assert.Equal(name.TextValue, model.Name.TextValue);
    }
}
