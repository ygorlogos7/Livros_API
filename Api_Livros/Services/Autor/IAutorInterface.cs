using Api_Livros.DTO.Autor;
using Api_Livros.Models;

namespace Api_Livros.Services.Autor
{
    public interface IAutorInterface
    { 
        Task<ResponseModel<List<AutorModel>>> ListarAutores();
        Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor);
        Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro);
        Task<ResponseModel<List<AutorModel>>> CriarAutor(AutorDto autorDto);
        Task<ResponseModel<List<AutorModel>>> AtualizarAutor(EditarAutorDto editarAutorDto);
        Task<ResponseModel<List<AutorModel>>> DeletarAutor(int idAutor);

    }
}
