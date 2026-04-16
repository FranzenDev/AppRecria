using AppRecria.API.Data;
using AppRecria.API.Models;
using System.Data.Entity;

namespace AppRecria.API.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly AppDbContext _context;

        public AnimalRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Animal> AdicionarAnimal(Animal animal)
        {
            _context.Animais.Add(animal);
            await _context.SaveChangesAsync();
            return animal;
        }

        public async Task<Animal?> ObterPorBrinco(long brinco)
        {
            return await _context.Animais
            .FirstOrDefaultAsync(a => a.Brinco == brinco);
        }

        public async Task<Animal?> ObterPorId(int id)
        {
            return await _context.Animais.FindAsync(id);
        }

        public async Task<List<Animal>> ObterTodos()
        {
            return await _context.Animais.ToListAsync();
        }
    }
}
