using API.Models;

namespace api_enderecos.Dto
{
    public class ObterClienteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Documento { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public List<EnderecoDto> Enderecos { get; set; } = new List<EnderecoDto>();

        public ObterClienteDto()
        {
        }

        public ObterClienteDto(Cliente cliente)
        {
            Id = cliente.Id;
            Nome = cliente.Nome;
            Documento = cliente.Documento;
            Email = cliente.Email;
            Ativo = cliente.Ativo;
            
            foreach (var endereco in cliente.Enderecos)
            {
                Enderecos.Add(new EnderecoDto(endereco));
            }
        }

    }
}