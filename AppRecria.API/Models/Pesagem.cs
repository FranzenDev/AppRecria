namespace AppRecria.API.Models
{
    public class Pesagem
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public int Peso { get; set; }
        public DateTime DataPesagem { get; set; }
        public Animal Animal { get; set; }
    }
}
