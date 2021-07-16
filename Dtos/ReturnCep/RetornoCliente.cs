using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.ReturnCep
{
    public class RetornoCliente
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public string CpfCliente { get; set; }
        public string CepCliente { get; set; }
        public string BairroCliente { get; set; }
        public string TelefoneFixCliente { get; set; }
        public string CelularCliente { get; set; }
    }
}
