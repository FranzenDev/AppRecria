using AppRecria.API.Models;
using AppRecria.API.Repositories;

namespace AppRecria.API.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _repository;

        public AnimalService(IAnimalRepository repository)
        {
            _repository = repository;
        }

        public async Task<Animal> AdicionarAnimal(Animal animal)
        {
            return await _repository.AdicionarAnimal(animal);
        }

        public async Task<List<Animal>> ListarAnimais()
        {
            return await _repository.ObterTodos();
        }

        public async Task<Animal?> ObterPorBrinco(long brinco)
        {
            return await _repository.ObterPorBrinco(brinco);
        }

        public async Task<Animal?> ObterPorId(int id)
        {
            return await _repository.ObterPorId(id);
        }
    }
}
