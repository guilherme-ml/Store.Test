using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.PostAndPut
{
    public class CompraPostReturn
    {
        public int id { get; set; }
        public string dtEHrCompra { get; set; }
        public int clienteId { get; set; }
        public int condPagamento { get; set; }
    }
}
