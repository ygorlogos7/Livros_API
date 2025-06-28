using Api_Livros.DTO.Autor;
using Api_Livros.DTO.Livro;
using Api_Livros.DTO.Vinculo;
using Api_Livros.Models;
using Api_Livros.Services.Autor;
using Api_Livros.Services.Livro;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Livros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroInterface _livroInterface;

        public LivroController(ILivroInterface livroInterface)
        {
            _livroInterface = livroInterface;
        }

        [HttpGet("ListarLivros")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarLivros()
        {
            var livros = await _livroInterface.ListarLivros();
            return Ok(livros);
        }

        [HttpGet("BuscarLivroPorId/{idLivro}")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> BuscarLivrosPorId(int idLivro)
        {
            var livro = await _livroInterface.BuscarLivroPorId(idLivro);
            if (!livro.Status)
            {
                return NotFound(livro);
            }
            return Ok(livro);
        }

        [HttpPost("CriarLivro")]
        public async Task<ActionResult<List<ResponseModel<LivroModel>>>> CriarLivro(AutorVinculoDto livroDto)
        {
            var livro = await _livroInterface.CriarLivro(livroDto);
            return Ok(livro);
        }


        [HttpPut("AtualizarLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> AtualizarLivro(EditarLivroDto editarLivroDto)
        {
            var livro = await _livroInterface.AtualizarLivro(editarLivroDto);
            return Ok(livro);
        }

        [HttpDelete("DeletarLivro/{idLivro}")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> DeletarLivro(int idLivro)
        {
            var livro = await _livroInterface.DeletarLivro(idLivro);
            if (!livro.Status)
            {
                return NotFound(livro);
            }
            return Ok(livro);
        }
    }
}
