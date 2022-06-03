using System.ComponentModel.DataAnnotations;

namespace Hollywood.Models.Addresses
{
    public class Address
    {
        [Key]
        public int AddressId {get; set;}
        public string Name {get; set;}
        public int CountryId {get; set;}
        public Country Country {get; set;}
    }
}