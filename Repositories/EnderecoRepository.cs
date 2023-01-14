using API.Context;
using API.Models;

namespace api_enderecos.Repositories
{
    public class EnderecoRepository
    {
        private readonly ApiContext _context;

        public EnderecoRepository(ApiContext context)
        {
            _context = context;
        }

        public Endereco Adicionar(Endereco endereco)
        {
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
            return endereco;
        }

        public Endereco ObterPorId(int id)
        {
            var endereco = _context.Enderecos.Find(id);
            return endereco;
        }

        public Endereco Atualizar(Endereco endereco)
        {
            var enderecoDb = ObterPorId(endereco.Id);

            if(enderecoDb is null)
                return null;

            enderecoDb.Logradouro = endereco.Logradouro;
            enderecoDb.Numero = enderecoDb.Numero;
            enderecoDb.Cep = enderecoDb.Cep;

            _context.Enderecos.Update(enderecoDb);
            _context.SaveChanges();
            return endereco;
        }

        public bool Deletar(int id)
        {
            var enderecoDb = ObterPorId(id);

            if(enderecoDb is null)
                return false;

            _context.Remove(enderecoDb);
            _context.SaveChanges();
            
            return true;
        }

        public List<Endereco> ObterEnderecos()
        {
            return _context.Enderecos.ToList();
        }
    }
}