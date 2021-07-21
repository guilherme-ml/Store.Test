using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.PostAndPut
{
    public class CategoriaPostReturn
    {
        public int id { get; set; }
        public string nomeCategoria { get; set; }
        public int posCategoria { get; set; }
        public int idfAtivo { get; set; }
        public int departamentoId { get; set; }
    }
}
