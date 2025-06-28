using Api_Livros.DTO.Livro;
using Api_Livros.Models;
using Api_Livros.DTO.Livro;
using Api_Livros.DTO.Vinculo;

namespace Api_Livros.Services.Livro
{

    public interface ILivroInterface
    {
        Task<ResponseModel<List<LivroModel>>> ListarLivros();
        Task<ResponseModel<LivroModel>> BuscarLivroPorId(int idLivro);
        Task<ResponseModel<List<LivroModel>>> CriarLivro(AutorVinculoDto livroDto);
        Task<ResponseModel<List<LivroModel>>> AtualizarLivro(EditarLivroDto editarLivroDto);
        Task<ResponseModel<List<LivroModel>>> DeletarLivro(int idLivro);
    }
}
