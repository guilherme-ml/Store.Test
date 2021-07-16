using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.ReturnCep
{
    public class RetornoProdutoCaracteristicas
    {
        public int Id { get; set; }
        public string ValorCaracteristica { get; set; }
        public int ProdutoId { get; set; }
        public int CaracteristicaId { get; set; }
    }
}
