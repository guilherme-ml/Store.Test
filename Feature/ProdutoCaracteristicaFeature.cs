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
    public class ProdutoCaracteristicaFeature : BaseTest
    {
        [Fact]
        public async Task TestProdutoCaracteristica()
        {
            var postResponse = await Post<RetornoProdutoCaracteristicas>(Endpoints.BaseURI, Endpoints.Caracteristica, ProdutoCaracteristicaPostReturn("12", 1, 2));
            Assert.True(postResponse.ValorCaracteristica != null);

            var getResponse = await Get<RetornoProdutoCaracteristicas>(Endpoints.BaseURI, Path.Combine(Endpoints.Caracteristica, postResponse.Id.ToString()));
            Assert.NotNull(getResponse.ValorCaracteristica);

            var putResponse = await Put<RetornoProdutoCaracteristicas>(Endpoints.BaseURI, Endpoints.Caracteristica, ProdutoCaracteristicaPostReturn("TesteTeste", 8, 6));
            Assert.NotNull(putResponse.ValorCaracteristica);

            var deleteResponse = await Delete<RetornoProdutoCaracteristicas>(Endpoints.BaseURI, Path.Combine(Endpoints.Caracteristica, postResponse.Id.ToString()));
            Assert.NotNull(deleteResponse.ValorCaracteristica);
        }
    }
}
