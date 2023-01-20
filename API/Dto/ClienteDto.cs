using API.Models;

namespace api_enderecos.Dto
{
    public class ClienteDto
    {
        public string Nome { get; set; }
        public string? Documento { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public List<EnderecoDto> Enderecos { get; set; }

        public ClienteDto()
        {
        }
        public ClienteDto(Cliente cliente)
        {
            Nome = cliente.Nome;
            Documento = cliente.Documento;
            Email = cliente.Email;
            Ativo = cliente.Ativo;
        }
    }
}