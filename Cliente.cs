using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppSistemaVendaBCC.Entities
{
    [Table("tbCliente")]
    public class Cliente
    {
        [Key]
        [Column("IdCliente")]
        public int Id { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("CpfCnpj")]
        public string CpfCnpj { get; set; }

        [Column("Telefone")]
        public string Telefone { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Endereco")]
        public string Endereco { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
