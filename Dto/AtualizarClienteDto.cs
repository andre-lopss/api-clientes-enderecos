namespace api_enderecos.Dto
{
    public class AtualizarClienteDto
    {
        public string Nome { get; set; }
        public string? Documento { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }
}