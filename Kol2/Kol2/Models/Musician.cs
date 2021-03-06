using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kol2.Models
{
    public class Musician
    {   [Key]
        public int IdMusician { get; set; }
        [Required, MaxLength(30)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Required, MaxLength(20)]
        public string Nickname { get; set; }

        public virtual ICollection<Musician_track> Musician_Tracks { get; set; }

    }
}
