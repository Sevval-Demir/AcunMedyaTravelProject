namespace AcunMedyaTravelProject.Entities
{
    public class Destination
    {
        public int Id { get; set; }
        public string cityName { get; set; }
        public string coverImageUrl { get; set; }
        public int countryId { get; set; }
        public Country Country { get; set; }
        public List<Package> Packages { get; set; }
    }
}
