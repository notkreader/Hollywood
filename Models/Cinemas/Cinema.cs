using System.ComponentModel.DataAnnotations;
using Hollywood.Models.Addresses;
using Hollywood.Models.Users;

namespace Hollywood.Models.Cinemas
{
    public class Cinema
    {
        [Key]
        public int CinemaId {get; set;}
        public string Name {get; set;}
        public int? AddressId {get; set;}
        public Address? Address {get; set;}
        public IEnumerable<CinemaMovie> CinemaMovies {get; set;} //Movies available at this cinema
        public IEnumerable<AUser> Employees {get; set;}
    }
}