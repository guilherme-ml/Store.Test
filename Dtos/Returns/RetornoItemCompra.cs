using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.ReturnCep
{
    public class RetornoItemCompra
    {
        public int Id { get; set; }
        public int PrecoProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public int ProdutoId { get; set; }
        public int NumCompra { get; set; }
    }
}
