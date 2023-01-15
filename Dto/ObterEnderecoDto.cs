using API.Models;

namespace api_enderecos.Dto
{
    public class ObterEnderecoDto
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public ObterEnderecoDto()
        {
        }

        public ObterEnderecoDto(Endereco endereco)
        {
            Logradouro = endereco.Logradouro;
            Numero = endereco.Numero;
            Cep = endereco.Cep;
        }
    }
}