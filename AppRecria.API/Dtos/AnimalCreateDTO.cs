using AppRecria.API.Enums;

namespace AppRecria.API.Dtos
{
    public class AnimalCreateDto
    {
        public long Brinco { get; set; }
        public string Lote { get; set; }
        public DateTime DataCompra { get; set; }
        public int PesoEntrada { get; set; }
        public TipoMedicacao TipoMedicacao { get; set; }
        public int PrecoCompra { get; set; }
        public string Origem { get; set; }
    }
}
