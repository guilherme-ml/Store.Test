using Store.Test.Base;
using Store.Test.Dtos.ReturnCep;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Store.Test.Feature
{
   public class AcompanhamentoCompraFeature : BaseTest
    {
        [Fact]
        public async Task TesteAcompanhamentoCompra()
        {
            var response = await Get<List<RetornoAcompanhementoCompra>>(Endpoints.BaseURI, Endpoints.Acompanhamentocompra);
            Assert.NotNull(response[0]);
        }
    }
}
