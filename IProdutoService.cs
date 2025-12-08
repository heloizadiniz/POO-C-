using BlazorAppSistemaVendaBCC.Entities;

namespace BlazorAppSistemaVendaBCC.Service.Interface
{
    public interface IProdutoService
    {

        public interface IProdutoService
        {


            Task AdicionarAsync(Produto produto);
            Task AlterarAsync(Produto produto);
            Task EcluirAsync(int id);

            Task<IEnumerable<Produto>> ListarTodos();
            Task<Produto> PesquisarPorId(int id);
        }
    }
}
