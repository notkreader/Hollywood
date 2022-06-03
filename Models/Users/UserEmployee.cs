using Hollywood.Models.Cinemas;

namespace Hollywood.Models.Users
{
    public class UserEmployee : AUser
    {
        private static int HOURS_OF_WORK = 8;
        public int CinemaId {get; set;}
        public Cinema Cinema {get; set;}
    }
}