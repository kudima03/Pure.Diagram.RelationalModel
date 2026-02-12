using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RelationalModel;

public sealed record DiagramRelationalModel : IDiagramRelationalModel
{
    public DiagramRelationalModel(
        IGuid id,
        IString title,
        IString description,
        IGuid typeId
    )
    {
        Id = id;
        Title = title;
        Description = description;
        TypeId = typeId;
    }

    public IGuid Id { get; }

    public IString Title { get; }

    public IString Description { get; }

    public IGuid TypeId { get; }
}
