using API.Context;
using API.Models;

namespace api_enderecos.Repositories
{
    public class ClienteRepository
    {
        private readonly ApiContext _context;

        public ClienteRepository(ApiContext context)
        {
            _context = context;
        }

        public Cliente Adicionar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return cliente;
        }

        public Cliente ObterPorId(int id)
        {
            var cliente = _context.Clientes.Find(id);
            return cliente;
        }

        public Cliente Atualizar(Cliente cliente)
        {
            var clienteDb = ObterPorId(cliente.Id);

            if(clienteDb is null)
                return null; 

            clienteDb.Nome = cliente.Nome;
            clienteDb.Documento = cliente.Documento;
            clienteDb.Email = cliente.Email;
            clienteDb.Ativo = cliente.Ativo;
            //clienteDb.Enderecos = cliente.Enderecos;

            _context.Clientes.Update(clienteDb);
            _context.SaveChanges();
            return cliente;
        }

        public bool Deletar(int id)
        {
            var clienteDb = ObterPorId(id);

            if(clienteDb is null)
                return false;

            _context.Remove(clienteDb);
            _context.SaveChanges();

            return true;
        }

        public List<Cliente> ObterClientes()
        {
            return _context.Clientes.ToList();
        }
    }
}