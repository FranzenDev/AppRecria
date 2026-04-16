using AppRecria.API.Data;
using AppRecria.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class AnimaisController : ControllerBase
{
    private readonly AppDbContext _context;

    public AnimaisController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var animais = await _context.Animais.ToListAsync();
        return Ok(animais);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Animal animal)
    {
        _context.Animais.Add(animal);
        await _context.SaveChangesAsync();
        return Ok(animal);
    }
}