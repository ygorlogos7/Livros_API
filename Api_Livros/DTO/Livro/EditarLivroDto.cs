using Api_Livros.Models;

namespace Api_Livros.DTO.Livro
{
    public class EditarLivroDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorModel Autor { get; set; }
    }
}
