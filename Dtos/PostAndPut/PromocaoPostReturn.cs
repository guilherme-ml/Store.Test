using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.PostAndPut
{
    public class PromocaoPostReturn
    {
        public int id { get; set; }
        public string nomePromo { get; set; }
        public DateTime dtInicioPromo { get; set; }
        public DateTime dtFimPromo { get; set; }
    }
}
