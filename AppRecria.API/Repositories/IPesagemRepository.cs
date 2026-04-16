using AppRecria.API.Models;

namespace AppRecria.API.Repositories
{
    public interface IPesagemRepository
    {
        Task AdicionarPesagem(Pesagem pesagem);
        Task<List<Pesagem>> ObterPorBrinco(long brinco);
        Task<List<Pesagem>> ObterUltimaPesagem(long brinco, int quantidade);
    }
}
