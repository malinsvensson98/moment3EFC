using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace moment3.Models
{
    public class Genres
    {
        // PK
        [Key]
        public int GenresId { get; set; }

        [Required]
        public string GenresName { get; set; }

        public ICollection<Cd> Cds { get; set; }


        public Genres()
        {
        }
    }
}


