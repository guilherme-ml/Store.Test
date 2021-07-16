using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.ReturnCep
{
    public class RetornoCompra
    {
        public int Id { get; set; }
        public string DtEHrCompra { get; set; }
        public int ClienteId { get; set; }
        public int CondPagamento { get; set; }
    }
}
