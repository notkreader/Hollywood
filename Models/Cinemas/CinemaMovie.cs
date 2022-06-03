using System.ComponentModel.DataAnnotations;

namespace Hollywood.Models.Cinemas
{
    public class CinemaMovie
    {
        [Key]
        public int CinemaMovieId {get; set;}
        public int CinemaId {get; set;}
        public Cinema Cinema {get; set;}
        public int MovieId {get; set;}
        public Movie Movie {get; set;}
    }
}