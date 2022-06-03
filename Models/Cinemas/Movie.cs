using System.ComponentModel.DataAnnotations;

namespace Hollywood.Models.Cinemas
{
    public class Movie
    {
        [Key]
        public int MovieId {get; set;}
        public string Name {get; set;}
        public int Duration {get; set;}
        public MovieType Type {get; set;}
        public IEnumerable<CinemaMovie> CinemaMovies {get;set;} //Cinemas where this movie is playing
    }
}