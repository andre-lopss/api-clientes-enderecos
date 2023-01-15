using api_enderecos.Dto;

namespace API.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Documento { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public List<Endereco> Enderecos { get; set; }

        public Cliente()
        {
        }

        public Cliente(ClienteDto dto)
        {
            Nome = dto.Nome;
            Documento = dto.Documento;
            Email = dto.Email;
            Ativo = dto.Ativo;
            Enderecos = new List<Endereco>();
            foreach (var endereco in dto.Enderecos)
            {
                Enderecos.Add(new Endereco(endereco));
            }
        }
    }
}