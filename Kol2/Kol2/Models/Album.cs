using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kol2.Models
{
    public class Album
    {   [Key]
        public int IdAlbum { get; set; }
        [Required, MaxLength(30)]
        public string AlbumName { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        [ForeignKey("IdMusicLabe")]
        public virtual MusicLabel MusicLabel { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
