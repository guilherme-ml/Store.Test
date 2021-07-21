using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.PostAndPut
{
    public class ItemCompraPostReturn
    {
        public int id { get; set; }
        public int precoProduto { get; set; }
        public int quantidadeProduto { get; set; }
        public int produtoId { get; set; }
        public int numCompra { get; set; }
    }
}
