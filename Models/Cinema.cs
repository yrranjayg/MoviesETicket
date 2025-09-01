using System.ComponentModel.DataAnnotations;

namespace MoviesETicket.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }

        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }

        [Display(Name = "Cinema name")]
        public string Name { get; set; }

        [Display(Name = "Cinema Description")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies
        {
            get; set;

        }
    }
}
