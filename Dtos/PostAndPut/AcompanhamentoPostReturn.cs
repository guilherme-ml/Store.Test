using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.PostAndPut
{
   public class AcompanhamentoPostReturn
    {
        public int Id { get; set; }
        public DateTime DtEHrSituacao { get; set; }
        public int SituacaoCompraId { get; set; }
        public int NumeroItemCompraId { get; set; }
    }
}
