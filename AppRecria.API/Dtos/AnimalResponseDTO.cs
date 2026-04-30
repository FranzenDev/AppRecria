namespace AppRecria.API.Dtos
{
    public class AnimalResponseDto
    {
        public int Id { get; set; }
        public long Brinco { get; set; }
        public string Lote { get; set; }
        public int PesoEntrada { get; set; }

        public List<PesagemDto> Pesagens { get; set; }
    }
}
