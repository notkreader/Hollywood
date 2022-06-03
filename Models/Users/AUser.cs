using System.ComponentModel.DataAnnotations;

namespace Hollywood.Models.Users
{
    public class AUser
    {
        [Key]
        public int UserId {get; set;}
        public string Name {get; set;}
        public Gender Gender {get; set;}
    }
}