using Api_Livros.DTO.Vinculo;
using Api_Livros.Models;

namespace Api_Livros.DTO.Livro
{
    public class LivroDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
