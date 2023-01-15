using api_enderecos.Dto;

namespace API.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }

        public Endereco()
        {

        }
        public Endereco(EnderecoDto dto)
        {
            Logradouro = dto.Logradouro;
            Numero = dto.Numero;
            Cep = dto.Cep;
        }
    }
}