using KostaVUTTest.DAL.Entities.ICS.Project.DAL.Entities;

namespace KostaVUTTest.DAL.Entities;

public record PlaylistMedia : IEntity
{
    public required Guid Id { get; set; }
    public required MediaItem MediaItem { get; set; }
    public required PlayList PlayList { get; set; }
}
