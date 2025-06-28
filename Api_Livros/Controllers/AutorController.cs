using Api_Livros.DTO.Autor;
using Api_Livros.Models;
using Api_Livros.Services.Autor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Livros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorInterface _autorInterface;
        public AutorController(IAutorInterface autorInterface)
        {
            _autorInterface = autorInterface;
        }

        [HttpGet("ListarAutores")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores()
        {
            var autores = await _autorInterface.ListarAutores();
            return Ok(autores);
        }

        [HttpGet("BuscarAutorPorId/{idAutor}")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarAutorPorId(int idAutor)
        {
            var autor = await _autorInterface.BuscarAutorPorId(idAutor);
            if (!autor.Status)
            {
                return NotFound(autor);
            }
            return Ok(autor);
        }

        [HttpGet("BuscarAutorPorIdLivro/{idLivro}")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarAutorporIdLivro(int idLivro)
        {
            var autor = await _autorInterface.BuscarAutorPorIdLivro(idLivro);
            return Ok(autor);
        }

        [HttpPost("CriarAutor")]
        public async Task<ActionResult<List<ResponseModel<AutorModel>>>> CriarAutor(AutorDto autorDto)
        {
            var autores = await _autorInterface.CriarAutor(autorDto);
            return Ok(autores);
        }

        [HttpPut("AtualizarAutor")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> AtualizarAutor(EditarAutorDto editarAutorDto)
        {
            var autores = await _autorInterface.AtualizarAutor(editarAutorDto);
            return Ok(autores);
        }
        [HttpDelete("DeletarAutor/{idAutor}")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> DeletarAutor(int idAutor)
        {
            var autores = await _autorInterface.DeletarAutor(idAutor);
            if (!autores.Status)
            {
                return NotFound(autores);
            }
            return Ok(autores);
        }
    }
}
