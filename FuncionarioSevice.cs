using BlazorAppSistemaVendaBCC.Data.Context;
using BlazorAppSistemaVendaBCC.Entities;
using BlazorAppSistemaVendaBCC.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppSistemaVendaBCC.Service.Implementaion
{
    public class FuncionarioSevice : IFuncionarioService
    {
        private readonly SQLServerContext _context;
        public FuncionarioSevice(SQLServerContext context)
        {
            _context = context;
        }
        public async Task AdicionarAsync(Funcionario Funcionario)
        {
            _context.Funcionarios.Add(Funcionario);
            await _context.SaveChangesAsync();
        } 

        public async Task AlterarAsync(Funcionario Funcionario)
        {
            _context.Funcionarios.Update(Funcionario);
            await _context.SaveChangesAsync();
        }

        public async Task EcluirAsync(int id)
        {
            var Funcionario = await _context.Funcionarios.FindAsync(id);
            if (Funcionario != null)
            {
                _context.Funcionarios.Remove(Funcionario);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Funcionario>> ListarTodos()
        {
            return await _context.Funcionarios.ToListAsync();
        }

        public async Task<Funcionario> PesquisarPorId(int id)
        {
            return await _context.Funcionarios.FindAsync(id);
        }
    }
}

    

