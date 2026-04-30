using AppRecria.API.Dtos;
using AppRecria.API.Models;

namespace AppRecria.API.Services
{
    public interface IAnimalService
    {
        Task<Animal> AdicionarAnimal(AnimalCreateDto animal);
        Task<List<AnimalResponseDto>> ListarAnimais();
        Task<Animal?> ObterPorId(int id);
        Task<Animal?> ObterPorBrinco(long brinco);
    }
}
