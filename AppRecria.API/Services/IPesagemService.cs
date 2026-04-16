using AppRecria.API.Models;

namespace AppRecria.API.Services
{
    public interface IPesagemService
    {
        Task<Pesagem> AdicionarPesagem(Pesagem pesagem);
        Task<List<Pesagem>> ObterPesagemAnimalPorBrinco(long brinco);
        Task<double> CalcularGMD(long brinco);
    }
}
