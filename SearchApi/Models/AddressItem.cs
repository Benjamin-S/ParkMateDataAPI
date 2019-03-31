using System.ComponentModel.DataAnnotations;

namespace SearchApi.Models
{
    public class AddressItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string Suburb { get; set; }
        public string DwellingType { get; set; }
        public int DwellingNumber { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Location { get; set; }
    }
}