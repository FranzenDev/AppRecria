using AppRecria.API.Dtos;
using AppRecria.API.Models;
using AppRecria.API.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AnimaisController : ControllerBase
{
    private readonly IAnimalService _service;

    public AnimaisController(IAnimalService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var animais = await _service.ListarAnimais();
        return Ok(animais);
    }

    [HttpPost]
    public async Task<IActionResult> Post(AnimalCreateDto animal)
    {
        var result = await _service.AdicionarAnimal(animal);
        return Ok(result);
    }
}