using System.Text.Json.Serialization;

namespace AppRecria.API.Models
{
    public class Pesagem
    {
        [JsonIgnore]
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public int Peso { get; set; }
        public DateTime DataPesagem { get; set; }
        [JsonIgnore]
        public Animal Animal { get; set; }
    }
}
