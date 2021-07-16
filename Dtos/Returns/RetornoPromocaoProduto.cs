using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.ReturnCep
{
   public class RetornoPromocaoProduto
    {
        public int Id { get; set; }
        public int PrecoProduto { get; set; }
        public int CondicaoPagamentoID { get; set; }
        public int Promocao { get; set; }
        public int ProdutoId { get; set; }
    }
}
