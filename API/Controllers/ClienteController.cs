using Microsoft.AspNetCore.Mvc;
using api_enderecos.Repositories;
using API.Models;
using api_enderecos.Dto;

namespace api_enderecos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteRepository _repository;

        public ClienteController(ClienteRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(ClienteDto dto)
        {
            if (string.IsNullOrEmpty(dto.Nome))
                return BadRequest("Cliente não pode ser cadastrado sem nome!");

            var cliente = new Cliente(dto);
            _repository.Adicionar(cliente);
            return Ok(dto);
        }


        [HttpGet("{id}")]
        public IActionResult ObterporId(int id)
        {
            var cliente = _repository.ObterPorId(id);
            var dto = new ObterClienteDto(cliente);
            return Ok(dto);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AtualizarClienteDto dto)
        {
            _repository.Atualizar(id, dto);
            return Ok(dto);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _repository.Deletar(id);
            return NoContent();
        }
    }
}