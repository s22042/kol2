using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kol2.Models.DTO
{
    public class GetAlbum
    {
        public string AlbumName { get; set; }
        public ICollection<GetTrack> TracksNames { get; set; }
    }
}
