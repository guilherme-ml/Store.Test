using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.PostAndPut
{
    public class DepartamentoPostReturn
    {
        public int id { get; set; }
        public string nomeDepartamento { get; set; }
        public int idfAtivo { get; set; }
        public int grupoId { get; set; }
    }
}
