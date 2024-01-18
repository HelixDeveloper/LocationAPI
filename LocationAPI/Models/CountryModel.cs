using System.ComponentModel.DataAnnotations;

namespace LocationAPI.Models
{
    public class CountryModel
    {
        [Key]
        public int CountryId { get; set; }
        [Required]
        public string CountryName { get; set; } = string.Empty;
        [Required]
        public string CountryCode { get; set; }
    }
    public class VMCountry
    {
        [Required]
        public string CountryName { get; set; } = string.Empty;
        [Required]
        public string CountryCode { get; set; }
    }
}
