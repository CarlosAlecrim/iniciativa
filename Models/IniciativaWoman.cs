using System.Linq;


namespace iniciativa.Models
{
    public class IniciativaWoman
    {
        public int id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public String Imagem { get; set; }
        public String url { get; set; }
        // [JsonIgnore]
        public ICollection<Evento> Eventos { get; set; }


    }
}