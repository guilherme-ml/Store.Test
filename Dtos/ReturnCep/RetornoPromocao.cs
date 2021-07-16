using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.ReturnCep
{
   public class RetornoPromocao
    {
        public int Id { get; set; }
        public string NomePromo { get; set; }
        public DateTime DtInicioPromo { get; set; }
        public DateTime DtFimPromo { get; set; }
    }
}
