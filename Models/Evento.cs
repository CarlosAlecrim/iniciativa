

using System.Text.Json.Serialization;

namespace iniciativa.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public DateTime Data { get; set; }
        public String Endereco { get; set; }
        [JsonIgnore]
        public IniciativaWoman? iniciativaWoman { get; set; }
       
    }
}