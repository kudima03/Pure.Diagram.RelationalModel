using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RelationalModel;

public sealed record DiagramTypeRelationalModel : IDiagramTypeRelationalModel
{
    public DiagramTypeRelationalModel(IGuid id, IString name)
    {
        Id = id;
        Name = name;
    }

    public IGuid Id { get; }

    public IString Name { get; }
}
