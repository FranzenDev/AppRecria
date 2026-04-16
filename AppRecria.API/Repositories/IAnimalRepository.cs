using AppRecria.API.Models;

namespace AppRecria.API.Repositories
{
    public interface IAnimalRepository
    {
        Task<Animal> AdicionarAnimal(Animal animal);
        Task<List<Animal>> ObterTodos();
        Task<Animal?> ObterPorId(int id);
        Task<Animal?> ObterPorBrinco(long brinco);
    }
}
