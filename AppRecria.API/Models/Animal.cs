using AppRecria.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace AppRecria.API.Models
{
    public class Animal
    {
        public int Id { get; set; }
        [Required]
        public long Brinco { get; set; }
        public string Lote { get; set; }
        public DateTime DataCompra { get; set; }
        public int PesoEntrada { get; set; }
        public TipoMedicacao TipoMedicacao { get; set; }
        public int PrecoCompra { get; set; }
        public string Origem { get; set; }
        public List<Pesagem> Pesagens { get; set; } = new();

    }
}
