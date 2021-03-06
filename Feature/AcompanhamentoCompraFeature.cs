using Store.Test.Base;
using Store.Test.Dtos.ReturnCep;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Store.Test.Feature
{
   public class AcompanhamentoCompraFeature : BaseTest
    {
        [Fact]
        public async Task TestAcompanhamento()
        {
            var postAcompanhamento = await Post<RetornoAcompanhementoCompra>(Endpoints.BaseURI, Endpoints.Acompanhamentocompra, AcompanhamentoPostReturn(DateTime.Now, 5, 3));

            await Get<RetornoAcompanhementoCompra>(Endpoints.BaseURI, Path.Combine(Endpoints.Acompanhamentocompra, postAcompanhamento.Id.ToString()));

            await Put<RetornoAcompanhementoCompra>(Endpoints.BaseURI, Endpoints.Acompanhamentocompra, AcompanhamentoPostReturn(DateTime.Now, 8, 5 ));

            await Delete<RetornoAcompanhementoCompra>(Endpoints.BaseURI, Path.Combine(Endpoints.Acompanhamentocompra, postAcompanhamento.Id.ToString()));

        }
    }
}
