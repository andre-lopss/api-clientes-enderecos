using API.Models;
using api_enderecos.Dto;
using api_enderecos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_enderecos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly EnderecoRepository _repository;

        public EnderecoController(EnderecoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public IActionResult ObterporId(int id)
        {
            var endereco = _repository.ObterPorId(id);
            var dto = new ObterEnderecoDto(endereco);
            return Ok(dto);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AtualizarEnderecoDto dto)
        {
            _repository.Atualizar(id, dto);
            return Ok(dto);
        }

    }
}