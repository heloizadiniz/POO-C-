using BlazorAppSistemaVendaBCC.Data.Context;
using BlazorAppSistemaVendaBCC.Entities;

namespace BlazorAppSistemaVendaBCC.Service.Interface
{
    public interface IClienteService
    {
      

        Task AdicionarAsync(Cliente cliente);
        Task AlterarAsync(Cliente cliente);
        Task EcluirAsync(int id);

        Task<IEnumerable<Cliente>> ListarTodos();
        Task<Cliente> PesquisarPorId(int id);

        Task<(IEnumerable<Cliente> Clientes, int TotalRegistros)> ListarPaginado(int numeroPagina, int itensPorPagina);


    }

}
