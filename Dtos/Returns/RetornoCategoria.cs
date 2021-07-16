using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.ReturnCep
{
   public class RetornoCategoria
    { 
        public int Id { get; set; }
        public string NomeCategoria { get; set; }
        public int PosCategoria { get; set; }
        public int IdfAtivo { get; set; }
        public int DepartamentoId { get; set; }
    }
}

