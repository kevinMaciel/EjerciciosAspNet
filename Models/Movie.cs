using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vydly2.Models
{
    public class Movie
    {
        
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        
        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }


    }
    
}