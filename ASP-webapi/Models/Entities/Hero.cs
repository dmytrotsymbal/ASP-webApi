using System.ComponentModel.DataAnnotations;

namespace ASP_webapi.Models.Entities
{
    public class Hero
    {
        [Key] // Первинний ключ моделі Hero
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TotalRating { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public string SuperPower { get; set; }

        public virtual ICollection<HeroImage> Images { get; set; }
    }
}
