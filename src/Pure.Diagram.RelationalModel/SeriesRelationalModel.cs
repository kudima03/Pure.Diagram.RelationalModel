using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RelationalModel;

public sealed record SeriesRelationalModel : ISeriesRelationalModel
{
    public SeriesRelationalModel(IGuid id, IGuid diagramId, IString label, IString source)
    {
        Id = id;
        DiagramId = diagramId;
        Label = label;
        Source = source;
    }

    public IGuid Id { get; }

    public IGuid DiagramId { get; }

    public IString Label { get; }

    public IString Source { get; }
}
