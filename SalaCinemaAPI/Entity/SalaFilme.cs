namespace SalaCinemaAPI.Entity
{
    public class SalaFilme
    {
        public int Id { get; protected set; }
        public int SalaId { get; set; }
        public int FilmeId { get; set; }
        public bool Status { get; set; }

        public SalaFilme() { }
        public SalaFilme(int salaId, int filmeId)
        {
            SalaId = salaId;
            FilmeId = filmeId;
            Status = true;
        }
    }
}
