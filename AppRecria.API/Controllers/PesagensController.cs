using AppRecria.API.Data;
using AppRecria.API.Models;
using AppRecria.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class PesagensController : ControllerBase
{
    private readonly PesagemService _service;

    public PesagensController(PesagemService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Post(Pesagem pesagem)
    {
        var result = await _service.AdicionarPesagem(pesagem);
        return Ok(result);
    }

    [HttpGet("animal/{brinco}")]
    public async Task<IActionResult> GetByAnimal(long brinco)
    {
        var pesagens = await _service.ObterPesagemAnimalPorBrinco(brinco);
        return Ok(pesagens);
    }
}