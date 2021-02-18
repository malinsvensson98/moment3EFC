using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace moment3.Models
{
    public class Cd
    {
        // Properties
        // PK
        [Key]
        public int CdId { get; set; } 

        [Required]
        public string Artist { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public double Length { get; set; }


        [Required]
        public double Year { get; set; }

        // FK
        [Required]
        public int GenresId { get; set; } 

        public virtual Genres Genres { get; set; }


        public Cd()
        {
        }
    }
}
