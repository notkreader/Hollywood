using Hollywood.Models.Cinemas;

namespace Hollywood.Models.Users
{
    public class UserClient : AUser
    {
        public IEnumerable<Movie> Favourites {get; set;}
    }
}