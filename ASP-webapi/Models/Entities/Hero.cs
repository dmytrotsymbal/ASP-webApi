namespace ASP_webapi.Models.Entities
{
    public class Hero
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public int TotalRating { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public string SuperPower { get; set; }
    }
}
