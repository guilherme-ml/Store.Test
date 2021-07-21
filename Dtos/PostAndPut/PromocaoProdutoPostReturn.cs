using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.PostAndPut
{
    public class PromocaoProdutoPostReturn
    {
        public int id { get; set; }
        public int precoProduto { get; set; }
        public int condicaoPagamentoID { get; set; }
        public int promocao { get; set; }
        public int produtoId { get; set; }
    }
}
