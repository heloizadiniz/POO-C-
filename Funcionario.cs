using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppSistemaVendaBCC.Entities
{
    [Table("tbFuncionario")]
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime DataAdimissao { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
