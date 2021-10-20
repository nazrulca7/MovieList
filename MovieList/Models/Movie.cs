using System;
using System.ComponentModel.DataAnnotations;

namespace MovieList.Models
{
    public class Movie
    {
        // EF will instruct the database to automatically generate this value
        public int MovieId { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Please enter a name.")]
        public string MovieName { get; set; }

     
        [StringLength(60, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 3)]
        [Required(ErrorMessage = "Please enter Movie's Main Star name.")]
        public string MainStar { get; set; }
       

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1889, 2050, ErrorMessage = "Year must be between {1} and {2}.")]
        
         public int? Year { get; set; }

        
     
        [Range((int)(Ishorror.Yes), (int)(Ishorror.Yes), ErrorMessage = "Please Select is Horror or Not.")]
         public Ishorror Ishorror { get; set; }
       

        [Required(ErrorMessage = "Please enter an Email.")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Url]
        public string Website { get; set; }


        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between {1} and {1}.")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Please enter a genre.")]
        public string GenreId { get; set; }
        public Genre Genre { get; set; }
       

        public string Slug =>
            MovieName?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();
    }

    public enum Ishorror : int
    {
        No = 0,
        Yes = 1
      
    }
}