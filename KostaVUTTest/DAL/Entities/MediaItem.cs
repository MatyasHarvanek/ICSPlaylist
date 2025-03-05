using System;
using System.ComponentModel.DataAnnotations;
using KostaVUTTest.DAL.Entities.Base;

namespace KostaVUTTest.DAL.Entities;

public class MediaItem : EntityBase
{
    public Guid Id { get; set; }
    
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Author { get; set; }
    public required string Category { get; set; }
    public required TimeSpan Duration { get; set; }
    public required int SizeInBytes { get; set; }   

    public List<PlaylistMediaItem> PlaylistMediaItems { get; init; } = new List<PlaylistMediaItem>();

}
