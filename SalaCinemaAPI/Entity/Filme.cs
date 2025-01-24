using System.ComponentModel.DataAnnotations;
namespace SalaCinemaAPI.Entity
{
    public class Filme
    {
        public int Id {  get; protected set; }
        [Required]
        public string NomeFilme {  get; set; }
        public string Diretor {  get; set; }
        public string Duracao { get; set; }

        public Filme() { }
        public Filme(int id, string nome, string diretor)
        {
            Id = id;
            NomeFilme = nome;
            Diretor = diretor;
            Duracao = DateTime.Now.ToString("HH:mm");
        }
    }
}
