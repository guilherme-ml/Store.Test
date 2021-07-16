using System;

namespace Store.Test.Dtos.ReturnCep
{
    public class RetornoAcompanhementoCompra
    {
        public int Id { get; set; }
        public DateTime DtEHrSituacao { get; set; }
        public int SituacaoCompraId { get; set; }
        public int NumeroItemCompraId { get; set; }
    }
}