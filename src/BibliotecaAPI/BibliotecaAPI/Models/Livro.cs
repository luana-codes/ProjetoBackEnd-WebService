namespace BibliotecaAPI.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public int AnoPublicacao { get; set; }

        // Relacionamento: O Livro pertence a um Autor
        public int AutorId { get; set; }
        public Autor? Autor { get; set; }
    }
}