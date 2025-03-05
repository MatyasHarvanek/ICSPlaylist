using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KostaVUTTest.DAL.Entities;
public record PlayList
{
    
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        public List<PlaylistMediaItem> PlaylistMediaItems { get; init; } = new List<PlaylistMediaItem>();
    
}
