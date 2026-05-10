using System;

namespace BibliotecaAPI.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }

        // Relacionamento com o Livro
        public int LivroId { get; set; }
        public Livro? Livro { get; set; }

        // Relacionamento com o Usuário
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}