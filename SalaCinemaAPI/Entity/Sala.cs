using System.ComponentModel.DataAnnotations;

namespace SalaCinemaAPI.Entity
{
    public class Sala
    {
        public int IdSala { get; private set; }
        [Required]
        public int NumeroSala { get; set; }
       public string NomeSala { get; set; }
        //public virtual ICollection<Filme> Filmes { get; private set; } = new List<Filme>(); //Relacionamentos com a Sala
        public Sala() { }
        public Sala(int numerosala, string nomeSala)
        {
            NumeroSala = numerosala;
            NomeSala = nomeSala;
        }
    }
}
