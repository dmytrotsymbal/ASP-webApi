using ASP_webapi.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class HeroImage
{
    [Key] // Визначає, що поле Id є первинним ключем
    public Guid Id { get; set; }

    [ForeignKey("Hero")] // Вказує, що HeroId є зовнішнім ключем, який пов'язаний з моделлю Hero
    public Guid HeroId { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public Hero Hero { get; set; } // Навігаційна властивість для Hero
}
