using AppRecria.API.Data;
using AppRecria.API.Models;
using System.Data.Entity;

namespace AppRecria.API.Repositories
{
    public class PesagemRepository:IPesagemRepository
    {
        private readonly AppDbContext _context;

        public PesagemRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AdicionarPesagem(Pesagem pesagem)
        {
            _context.Pesagens.Add(pesagem);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Pesagem>> ObterPorBrinco(long brinco)
        {
            return await _context.Pesagens
                .Where(p => p.Animal.Brinco == brinco)
                .ToListAsync();
        }
        public async Task<List<Pesagem>> ObterUltimaPesagem(long brinco, int quantidade)
        {
            return await _context.Pesagens
                .Where(p => p.Animal.Brinco == brinco)
                .OrderByDescending(p => p.DataPesagem)
                .Take(quantidade)
                .ToListAsync();
        }
    }
}
