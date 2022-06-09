using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kol2.Models
{
    public class Musician_track

    {   [Key]
        
        public int IdMusician_track { get; set; }
        [Required]
        [ForeignKey("IdMusician")]
        
        
        public virtual Musician Musician { get; set; }

        [Required]
        [ForeignKey("IdTrack")]

        
        public virtual Track Track { get; set; }

       
    }
}
