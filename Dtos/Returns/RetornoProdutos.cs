using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Dtos.ReturnCep
{
    public class RetornoProdutos
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public string DescProduto { get; set; }
        public int PrecoProduto { get; set; }
        public string CategoriaProduto { get; set; }
        public int IdfAtivo { get; set; }
        public int FabricanteId { get; set; }
        public int CategoryId { get; set; }
    }
}
