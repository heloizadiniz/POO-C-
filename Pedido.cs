using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppSistemaVendaBCC.Entities
{
    [Table("tbPedido")]
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public ICollection<ItemVenda> ItensVenda { get; set; }
    }
}
