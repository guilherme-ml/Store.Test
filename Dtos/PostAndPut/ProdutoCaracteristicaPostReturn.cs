using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.PostAndPut
{
    public class ProdutoCaracteristicaPostReturn
    {
        public int id { get; set; }
        public string valorCaracteristica { get; set; }
        public int produtoId { get; set; }
        public int caracteristicaId { get; set; }
    }
}
