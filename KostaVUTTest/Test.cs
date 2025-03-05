using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICS.Project.DAL.Entities;

public interface IEntity
{
    Guid Id { get; set; }
}

public record MediaItemEntity : IEntity
{
    public Guid Id { get; set; }
    public required string Name { get; set; } = string.Empty;
    public required string Description { get; set; }
    public required string Author { get; set; }
    public required string Category { get; set; }
    public required TimeSpan Duration { get; set; }

    public List<PlaylistMediaItem> PlaylistMediaItems { get; init; } = new List<PlaylistMediaItem>();
}

public record PlaylistEntity : IEntity
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }

    public List<PlaylistMediaItem> PlaylistMediaItems { get; init; } = new List<PlaylistMediaItem>();
}

// Vazba medzi MediaItem a Playlist
public record PlaylistMediaItem : IEntity
{
    public required Guid PlaylistId { get; set; }
    public required Guid MediaItemId { get; set; }
    public required PlaylistEntity Playlist { get; init; }
    public required MediaItemEntity MediaItem { get; init; }
    public required Guid Id { get; set; }
}