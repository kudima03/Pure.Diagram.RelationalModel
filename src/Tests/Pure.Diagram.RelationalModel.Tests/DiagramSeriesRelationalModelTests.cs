using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Diagram.RelationalModel.Tests;

public sealed record DiagramSeriesRelationalModelTests
{
    [Fact]
    public void InitializeIdCorrectly()
    {
        IGuid id = new Guid();

        IDiagramSeriesRelationalModel model = new DiagramSeriesRelationalModel(
            id,
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        Assert.Equal(id.GuidValue, model.Id.GuidValue);
    }

    [Fact]
    public void InitializeDiagramIdCorrectly()
    {
        IGuid id = new Guid();

        IDiagramSeriesRelationalModel model = new DiagramSeriesRelationalModel(
            new Guid(),
            id,
            new RandomString(),
            new RandomString()
        );

        Assert.Equal(id.GuidValue, model.DiagramId.GuidValue);
    }

    [Fact]
    public void InitializeLabelCorrectly()
    {
        IString label = new RandomString();

        IDiagramSeriesRelationalModel model = new DiagramSeriesRelationalModel(
            new Guid(),
            new Guid(),
            label,
            new RandomString()
        );

        Assert.Equal(label.TextValue, model.Label.TextValue);
    }

    [Fact]
    public void InitializeSourceCorrectly()
    {
        IString source = new RandomString();

        IDiagramSeriesRelationalModel model = new DiagramSeriesRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            source
        );

        Assert.Equal(source.TextValue, model.Source.TextValue);
    }
}
