using ASP_webapi.Data;
using ASP_webapi.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {

        private readonly DataContext dbContext;

        public HeroController(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET ALL HEROES ================
        [HttpGet]
        public async Task<IActionResult> GetHeroes()
        {
            var heroes = await dbContext.Heroes.ToListAsync();

            return Ok(heroes);
        }


        // GET HERO BY ID ================
        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetHeroById(Guid id)
        {
            var hero = await dbContext.Heroes.FindAsync(id);

            if (hero == null)
            {
                return NotFound();
            }

            return Ok(hero);
        }

        // ADD NEW HERO =============
        [HttpPost]
        public async Task<IActionResult> PostNewHero(Hero hero)
        {
            dbContext.Heroes.Add(hero);
            await dbContext.SaveChangesAsync();

            return Ok(await GetHeroes());
        }


        // UPDATE HERO ============
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateHeroById(Hero hero)
        {
            var dbHero = await dbContext.Heroes.FindAsync(hero.Id);

            if (dbHero == null)
            {
                return NotFound();
            }

            dbHero.Name = hero.Name;
            dbHero.FirstName = hero.FirstName;
            dbHero.LastName = hero.LastName;
            dbHero.Image = hero.Image;
            dbHero.Description = hero.Description;
            dbHero.Age = hero.Age;
            dbHero.SuperPower = hero.SuperPower;

            await dbContext.SaveChangesAsync();

            return Ok(await GetHeroes());
        }


        // DELETE HERO ============
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteHeroById(Guid id)
        {
            var hero = await dbContext.Heroes.FindAsync(id);

            if (hero == null)
            {
                return NotFound();
            }

            dbContext.Remove(hero);
            await dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
