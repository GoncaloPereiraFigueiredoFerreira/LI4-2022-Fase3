using System.Collections.Generic;

namespace SpotGuru.Models
{
    public class Utilizador
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; } 
        public string Telemovel { get; set; }

        public List<string> Historico { get; set; }
        public List<string> Favoritos { get; set; }

        public Utilizador(int id, string nome, string email, string telemovel)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telemovel = telemovel;
        }

        public Utilizador(int id, string nome, string email, string telemovel, List<string> historico, List<string> favoritos) : this(id, nome, email, telemovel)
        {
            Historico = historico;
            Favoritos = favoritos;
        }
    }
}
