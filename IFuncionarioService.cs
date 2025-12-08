using BlazorAppSistemaVendaBCC.Entities;

namespace BlazorAppSistemaVendaBCC.Service.Interface
{
    public interface IFuncionarioService
    {

        public interface IFuncionarioService
        {


            Task AdicionarAsync(Funcionario funcionario);
            Task AlterarAsync(Funcionario funcionario);
            Task EcluirAsync(int id);

            Task<IEnumerable<Funcionario>> ListarTodos();
            Task<Funcionario> PesquisarPorId(int id);
        }
    }
}
