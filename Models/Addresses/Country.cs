using System.ComponentModel.DataAnnotations;

namespace Hollywood.Models.Addresses
{
    public class Country
    {
        [Key]
        public int CountryId {get; set;}
        public string Name {get; set;}
    }
}