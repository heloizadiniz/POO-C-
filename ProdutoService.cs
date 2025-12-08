using BlazorAppSistemaVendaBCC.Data.Context;
using BlazorAppSistemaVendaBCC.Entities;
using BlazorAppSistemaVendaBCC.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppSistemaVendaBCC.Service.Implementaion
{
    public class ProdutoService : IProdutoService
    {
        private readonly SQLServerContext _context;
        public ProdutoService(SQLServerContext context)
        {
            _context = context;
        }
        public async Task AdicionarAsync(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
        }

        public async Task AlterarAsync(Produto produto)
        {
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
        }

        public async Task EcluirAsync(int id)
        {
            var Produto = await _context.Produtos.FindAsync(id);
            if (Produto != null)
            {
                _context.Produtos.Remove(Produto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Produto>> ListarTodos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> PesquisarPorId(int id)
        {
            return await _context.Produtos.FindAsync(id);
        }
    }
}

    

