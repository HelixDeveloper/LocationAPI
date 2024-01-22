namespace LocationAPI.Models
{
    public class CountryCRUDModel
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public bool IsCountryDisabled { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? LastModifiedDate { get; set; } 
        public DateTime? DeletedDate { get; set;}
    }
    public class CountryCRUDVM
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }
}
