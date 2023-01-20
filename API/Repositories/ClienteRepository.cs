using API.Context;
using API.Models;
using api_enderecos.Dto;
using Microsoft.EntityFrameworkCore;

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
            var cliente = _context.Clientes.Include(x => x.Enderecos)
                                           .FirstOrDefault(x => x.Id == id);
            
            return cliente;
        }

        public AtualizarClienteDto Atualizar(int id, AtualizarClienteDto cliente)
        {
            var clienteDb = ObterPorId(id);

            if(clienteDb is null)
                return null; 

            clienteDb.Nome = cliente.Nome;
            clienteDb.Documento = cliente.Documento;
            clienteDb.Email = cliente.Email;
            clienteDb.Ativo = cliente.Ativo;
           
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