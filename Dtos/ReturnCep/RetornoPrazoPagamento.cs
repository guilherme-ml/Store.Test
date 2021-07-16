using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.ReturnCep
{
   public class RetornoPrazoPagamento
    {
        public int Id { get; set; }
        public int NumeroParcelas { get; set; }
        public int CondPagamentoId { get; set; }
    }
}
