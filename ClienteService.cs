using BlazorAppSistemaVendaBCC.Data.Context;
using BlazorAppSistemaVendaBCC.Entities;
using BlazorAppSistemaVendaBCC.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppSistemaVendaBCC.Service.Implementaion
{
    public class ClienteService : IClienteService
    {
        private readonly SQLServerContext _context;
        public ClienteService(SQLServerContext context)
        {
            _context = context;
        }
        public async Task AdicionarAsync(Cliente cliente)
        {
           _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task AlterarAsync(Cliente cliente)
        {
           _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task EcluirAsync(int id)
        {
           var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<(IEnumerable<Cliente> Clientes, int TotalRegistros)> ListarPaginado(int numeroPagina, int itensPorPagina)
        {
            // 1. Calcula quantos registros pular (offset)
            var pular = (numeroPagina - 1) * itensPorPagina;

            // 2. Consulta o total de registros (para o frontend saber quantas páginas existem)
            var totalRegistros = await _context.Clientes.CountAsync();

            // 3. Consulta os dados da página específica
            var clientesPaginados = await _context.Clientes
                .OrderBy(c => c.Nome) // Sempre ordene antes de paginar
                .Skip(pular)          // Pula os registros anteriores
                .Take(itensPorPagina) // Pega apenas a quantidade necessária
                .ToListAsync();

            // 4. Retorna a tupla com os dados da página e o total
            return (clientesPaginados, totalRegistros);
        }

        public async Task<IEnumerable<Cliente>> ListarTodos()
        {
          return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> PesquisarPorId(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }
    }
}

