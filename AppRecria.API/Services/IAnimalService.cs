using AppRecria.API.Models;

namespace AppRecria.API.Services
{
    public interface IAnimalService
    {
        Task<Animal> AdicionarAnimal(Animal animal);
        Task<List<Animal>> ListarAnimais();
        Task<Animal?> ObterPorId(int id);
        Task<Animal?> ObterPorBrinco(long brinco);
    }
}
