using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppSistemaVendaBCC.Entities
{
   
       
    [Table("tbItemVenda")]
        public class ItemVenda
        {
            [Column("ProdutoId")]
            public int ProdutoId { get; set; }

            public Produto Produto { get; set; }

            [Column("PedidosId")]
            public int PedidoId { get; set; }

            public Pedido Pedido { get; set; }

            [Column("QuantidadeProduto")]
            public int QuantidadeProduto { get; set; }

            [Column("PrecoUnitario")]
            public decimal PrecoUnitario { get; set; }
        }
    }




