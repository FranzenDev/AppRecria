using AppRecria.API.Dtos;
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
        public async Task<Animal> AdicionarAnimal(AnimalCreateDto animalDto)
        {
            var animal = new Animal
            {
                Brinco = animalDto.Brinco,
                Lote = animalDto.Lote,
                DataCompra = animalDto.DataCompra,
                PesoEntrada = animalDto.PesoEntrada,
                TipoMedicacao = animalDto.TipoMedicacao,
                PrecoCompra = animalDto.PrecoCompra,
                Origem = animalDto.Origem
            };
            return await _repository.AdicionarAnimal(animal);
        }

        public async Task<List<AnimalResponseDto>> ListarAnimais()
        {
            var animais = await _repository.ObterTodos();

            return animais.Select(a => new AnimalResponseDto
            {
                Id = a.Id,
                Brinco = a.Brinco,
                Lote = a.Lote,
                PesoEntrada = a.PesoEntrada,
                Pesagens = a.Pesagens.Select(p => new PesagemDto
                {
                    Peso = p.Peso,
                    DataPesagem = p.DataPesagem
                }).ToList()
            }).ToList();
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
