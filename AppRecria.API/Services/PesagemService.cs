using AppRecria.API.Models;
using AppRecria.API.Repositories;

namespace AppRecria.API.Services
{
    public class PesagemService : IPesagemService
    {
        private readonly IPesagemRepository _repository;
        public PesagemService(IPesagemRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<Pesagem>> ObterPesagemAnimalPorBrinco(long brinco)
        {
            return await _repository.ObterPorBrinco(brinco);
        }
        public async Task<Pesagem> AdicionarPesagem(Pesagem pesagem)
        {
            await _repository.AdicionarPesagem(pesagem);
            return pesagem;
        }
        public async Task<double> CalcularGMD(long brinco)
        {
            var pesagens = await _repository.ObterUltimaPesagem(brinco, 2);

            if (pesagens.Count < 2)
                return 0;

            var atual = pesagens[0];
            var anterior = pesagens[1];

            var dias = (atual.DataPesagem - anterior.DataPesagem).Days;

            if (dias == 0)
                return 0;

            return (double)(atual.Peso - anterior.Peso) / dias;
        }
    }
}
